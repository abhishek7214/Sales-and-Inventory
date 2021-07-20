Imports System.Data.SqlClient
Public Class frmsearch

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged

        If cmbsearch.Text = "CATEGORY" Then
            Label1.Visible = True
            txtcat.Visible = True
            Label3.Visible = False
            txtiname.Visible = False
            Label4.Visible = False
            txticode.Visible = False
        ElseIf cmbsearch.Text = "ITEM NAME" Then
            Label3.Visible = True
            txtiname.Visible = True
            Label4.Visible = False
            txticode.Visible = False
            Label1.Visible = False
            txtcat.Visible = False
        ElseIf cmbsearch.Text = "ITEMCODE" Then
            Label4.Visible = True
            txticode.Visible = True
            Label1.Visible = False
            txtcat.Visible = False
            Label3.Visible = False
            txtiname.Visible = False
        End If

    End Sub

    Private Sub txtcat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcat.TextChanged
        lstcategory.Items.Clear()
        If txtcat.Text = "" Then
            lstcategory.Visible = False
        Else
            Con.Close()
            Con.Open()
            qry = "select cat_name from tbl_category where cat_name like '" & txtcat.Text & "%'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                lstcategory.Visible = True
                lstcategory.Items.Add(dr(0).ToString)
            End While
            Con.Close()
        End If
        

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If cmbsearch.Text = "CATEGORY" Then
            Con.Close()
            Con.Open()
            qry = "select p_name as PRODUCTNAME,p_price as PRICE,mesure_name as PER,p_quantity as QUANTITY from tbl_product where cat_name='" & txtcat.Text & "'"
            adp = New SqlDataAdapter(qry, Con)
            ds = New DataSet
            adp.Fill(ds, "tbl_product")
            dgvproduct.DataSource = ds
            dgvproduct.DataMember = ds.Tables(0).ToString
            Con.Close()
        ElseIf cmbsearch.Text = "ITEM NAME" Then
            Con.Close()
            Con.Open()
            qry = "select p_name as PRODUCTNAME,cat_name as CATEGORYNAME,p_price as PRICE,mesure_name as PER,p_quantity as QUANTITY from tbl_product where p_name='" & txtiname.Text & "'"
            adp = New SqlDataAdapter(qry, Con)
            ds = New DataSet
            adp.Fill(ds, "tbl_product")
            dgvproduct.DataSource = ds
            dgvproduct.DataMember = ds.Tables(0).ToString
            Con.Close()
        ElseIf cmbsearch.Text = "ITEMCODE" Then
            Con.Close()
            Con.Open()
            qry = "select p_name as PRODUCTNAME,cat_name as CATEGORYNAME,p_price as PRICE,mesure_name as PER,p_quantity as QUANTITY from tbl_product where p_id='" & txticode.Text & "'"
            adp = New SqlDataAdapter(qry, Con)
            ds = New DataSet
            adp.Fill(ds, "tbl_product")
            dgvproduct.DataSource = ds
            dgvproduct.DataMember = ds.Tables(0).ToString
            Con.Close()


        End If
    End Sub

    Private Sub lstcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcategory.SelectedIndexChanged
        txtcat.Text = lstcategory.SelectedItem.ToString
        lstcategory.Visible = False
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

    Private Sub lstiname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstiname.SelectedIndexChanged
        txtiname.Text = lstiname.SelectedItem.ToString
        lstiname.Visible = False
    End Sub

    Private Sub frmsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class