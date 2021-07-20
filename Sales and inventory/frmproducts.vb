Imports System.Data.SqlClient
Public Class frmproducts
    Dim cat_id
    Dim initial_qty
    Dim current_qty
    Dim cat_name As String
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click

        txtcname.Visible = True
        cmbcname.Visible = False

        Con.Open()
        qry = "select max(substring(cat_id,3,len(cat_id)))+1 from tbl_product"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            cat_id = dr(0).ToString
            If cat_id = "" Then
                txtcatid.Text = "CT001"
            Else
                If Len(cat_id) = 1 Then
                    txtcatid.Text = "CT00" & cat_id
                ElseIf Len(cat_id) = 2 Then
                    txtcatid.Text = "CT0" & cat_id
                Else
                    txtcatid.Text = "CT" & cat_id

                End If
            End If

        End If
        Con.Close()
        btnsave.Enabled = True
        txtpname.Clear()


    End Sub
    Sub clear()
        txtcatid.Text = ""
        txtcname.Visible = False
        txtpname.Text = ""
        txtqty.Text = ""
        txtprice.Text = ""
        lblper.Visible = False
        cmbcname.Text = "-select-"
        cmbmesure.Text = "-select-"
        txtsprice.Text = ""


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcatid.Text = "" Or txtpname.Text = "" Or txtqty.Text = "" Or txtprice.Text = "" Or cmbmesure.Text = "" Or txtsprice.Text = "" Then
            MsgBox("Please enter the required details", MsgBoxStyle.Information, "save")
        ElseIf txtcname.Text = "" And cmbcname.Text = "" Then
            MsgBox("Please enter the category", MsgBoxStyle.Information, "save")
        Else
            Con.Close()
            Con.Open()
            qry = "select * from tbl_product where cat_id='" & txtcatid.Text & "' and p_name='" & txtpname.Text & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                If MsgBoxResult.No = MsgBox("do you want to update?", MsgBoxStyle.YesNo, "update") Then
                    Exit Sub
                End If
                initial_qty = Convert.ToInt32(dr(3).ToString)
                current_qty = Convert.ToInt32(txtqty.Text)
                qty = initial_qty + current_qty
                Con.Close()
                Con.Open()
                qry = "update tbl_product set p_name='" & txtpname.Text & "',price='" & txtprice.Text & "',,qty='" & txtqty.Text & "',mesure='" & cmbmesure.Text & "' where cat_id='" & txtcatid.Text & "'"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("product updated", MsgBoxStyle.Information, "updation")
                Con.Close()

            Else
                If txtcname.Text = "" Then
                    cat_name = cmbcname.Text
                ElseIf cmbcname.Text = "-select-" Then
                    cat_name = txtcname.Text
                End If
                Con.Close()
                Con.Open()
                qry = "insert into tbl_product(cat_id,cat_name,p_name,qty,mesure,price,sprice) values ('" & txtcatid.Text & "','" & cat_name & "','" & txtpname.Text & "','" & txtqty.Text & "','" & cmbmesure.Text & "','" & txtprice.Text & "','" & txtsprice.Text & "')"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Product added successfully", MsgBoxStyle.Information, "save")
                Con.Close()
                clear()
            End If

        End If
    End Sub

    Private Sub cmbmesure_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmesure.SelectedIndexChanged
        lblper.Visible = True
        lblper.Text = "Per " & cmbmesure.Text
    End Sub

  
    Private Sub frmproducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con.Close()
        Con.Open()
        qry = "select distinct(cat_name) from tbl_product"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbcname.Items.Add(dr(0).ToString)

        End While
        Con.Close()
        products()
    End Sub

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged
        Con.Close()
        Con.Open()
        qry = "select cat_id from tbl_product where cat_name='" & cmbcname.Text & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtcatid.Text = dr(0).ToString
        End If
        Con.Close()
    End Sub

    Private Sub txtcname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcname.TextChanged
        If txtcname.Text = "" Then
            lstcatname.Visible = False
            Exit Sub
        End If
        lstcatname.Items.Clear()
        Con.Close()
        Con.Open()
        qry = "select distinct(cat_name) from tbl_product where cat_name like '" & txtcname.Text & "%' "
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            lstcatname.Visible = True
            lstcatname.Items.Add(dr(0).ToString)
        End While
        Con.Close()
    End Sub

    Private Sub lstcatname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcatname.SelectedIndexChanged
        txtcname.Visible = False
        cmbcname.Visible = True
        cmbcname.Text = lstcatname.SelectedItem.ToString
        lstcatname.Visible = False
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If cmbsearch.Text = "CATEGORY" Then
            Con.Close()
            Con.Open()
            qry = "select p_name as PRODUCTNAME,price as PRICE,mesure as PER,sprice as SELLINGPRICE,qty as QUANTITY from tbl_product where cat_name='" & txtcat.Text & "'"
            adp = New SqlDataAdapter(qry, Con)
            ds = New DataSet
            adp.Fill(ds, "tbl_product")
            dgvproduct.DataSource = ds
            dgvproduct.DataMember = ds.Tables(0).ToString
            Con.Close()
        ElseIf cmbsearch.Text = "ITEM NAME" Then
            Con.Close()
            Con.Open()
            qry = "select p_name as PRODUCTNAME,cat_name as CATEGORYNAME,price as PRICE,mesure as PER,qty as QUANTITY from tbl_product where p_name='" & txtiname.Text & "'"
            adp = New SqlDataAdapter(qry, Con)
            ds = New DataSet
            adp.Fill(ds, "tbl_product")
            dgvproduct.DataSource = ds
            dgvproduct.DataMember = ds.Tables(0).ToString
            Con.Close()
       


        End If
    End Sub

    Private Sub txtcat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcat.TextChanged
        lstcategory.Items.Clear()
        If txtcat.Text = "" Then
            lstcategory.Visible = False
        Else
            Con.Close()
            Con.Open()
            qry = "select distinct(cat_name) from tbl_product where cat_name like '" & txtcat.Text & "%'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                lstcategory.Visible = True
                lstcategory.Items.Add(dr(0).ToString)
            End While
            Con.Close()
        End If

    End Sub

    Private Sub txtiname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtiname.TextChanged
        lstiname.Items.Clear()
        If txtiname.Text = "" Then
            lstiname.Visible = False
        Else
            Con.Close()
            Con.Open()
            qry = "select p_name from tbl_product where p_name like '" & txtiname.Text & "%'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                lstiname.Visible = True
                lstiname.Items.Add(dr(0).ToString)
            End While
            Con.Close()
        End If
    End Sub

    Private Sub lstcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcategory.SelectedIndexChanged
        txtcat.Text = lstcategory.SelectedItem.ToString
        lstcategory.Visible = False
    End Sub

    Private Sub lstiname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstiname.SelectedIndexChanged
        txtiname.Text = lstiname.SelectedItem.ToString
        lstiname.Visible = False
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.Text = "CATEGORY" Then
            Label1.Visible = True
            txtcat.Visible = True
            Label3.Visible = False
            txtiname.Visible = False
            Label4.Visible = False
            Label9.Visible = True
        ElseIf cmbsearch.Text = "ITEM NAME" Then
            Label3.Visible = True
            txtiname.Visible = True
            Label4.Visible = False
            Label7.Visible = True
            Label1.Visible = False
            txtcat.Visible = False
            Label9.Visible = False
        End If
    End Sub

    
    Sub products()
        Con.Close()
        Con.Open()
        qry = "select cat_id as ID,cat_name as CATEGORY_NAME,p_name as PRODUCT_NAME,qty as QUANTITY,mesure as MEASUREMENT,price as ACTUAL_PRICE,sprice as SELLING_PRICE from tbl_product"
        adp = New SqlDataAdapter(qry, Con)
        ds = New DataSet
        adp.Fill(ds, "tbl_product")
        dgvstock.DataSource = ds
        dgvstock.DataMember = ds.Tables(0).ToString
        Con.Close()

    End Sub
End Class