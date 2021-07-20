Imports System.Data.SqlClient

Public Class frmpurchase
    Dim o_num
    Private Sub frmpurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con.Open()
        qry = "select cat_name from tbl_category"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbcat.Items.Add(dr(0).ToString)
        End While
        Con.Close()
    End Sub

    Private Sub cmbcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcat.SelectedIndexChanged
        Con.Close()
        Con.Open()
        qry = "select p_name from tbl_product where cat_name='" & cmbcat.SelectedItem.ToString & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = False Then
            lstsearch.Visible = False
            MsgBox("No Products Found Under '" & cmbcat.SelectedItem.ToString & "' Category", MsgBoxStyle.Exclamation, "PURCHASE")
        Else


            lstsearch.Items.Clear()
            Con.Close()
            Con.Open()
            qry = "select p_name from tbl_product where cat_name='" & cmbcat.SelectedItem.ToString & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                lstsearch.Visible = True
                lstsearch.Items.Add(dr(0).ToString)
            End While
            Con.Close()
        End If
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        Con.Open()
        qry = "select max(orderno)from tbl_customerorder"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            o_num = dr(0).ToString
            If o_num = "" Then
                txtono.Text = "1"
            Else
                o_num = o_num + 1
                txtono.Text = o_num

            End If
        End If
        Con.Close()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtono.Text = "" Or txtcname.Text = "" Or txtadd.Text = "" Or txtpname.Text = "" Or txtqty.Text = "" Then
            MsgBox("Please enter the details", MsgBoxStyle.Information, "enter")
        Else
            Con.Open()
            qry = "insert into tbl_customerorder(orderno,c_name,address,phone_no,p_name,price,qty,order_date,delivery_date)values('" & txtono.Text & "','" & txtcname.Text & "','" & txtadd.Text & "','" & txtpno.Text & "','" & txtpname.Text & "','" & txtprice.Text & "','" & txtqty.Text & "','" & dtpodate.Text & "','" & dtpddate.Text & "')"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("submitted successfully", MsgBoxStyle.Information, "submit")
            Con.Close()
        End If
        
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBoxResult.No = MsgBox("do you want to exit", MsgBoxStyle.YesNo, "exit") Then Exit Sub
        Me.Close()

    End Sub

    Private Sub lstsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstsearch.SelectedIndexChanged
        Con.Open()
        qry = "select p_name,p_price,mesure_name from tbl_product where p_name='" & lstsearch.SelectedItem.ToString & "' and cat_name='" & cmbcat.SelectedItem.ToString & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtpname.Text = dr(0).ToString
            txtprice.Text = dr(1).ToString
            txtmesure.Text = dr(2).ToString
            lblmesure.Text = dr(2).ToString
        End If
        Con.Close()
    End Sub

    Sub clear()
        txtadd.Text = ""
        txtcname.Text = ""
        txtpname.Text = ""
        txtpno.Text = ""
        txtqty.Text = ""
        txtprice.Text = ""
    End Sub

    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        Dim total As Integer = Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)
        MsgBox("Total amount is '" & total & "'", MsgBoxStyle.Information, "TOTAL")

    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If txtqty.Text = "" Then
            Exit Sub
        Else


            Con.Close()
            Con.Open()
            qry = "select p_quantity from tbl_product where cat_name='" & cmbcat.Text & "' and p_name='" & txtpname.Text & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                qty = Convert.ToInt32(dr(0).ToString)
            End If
            Con.Close()
            pname = txtpname.Text
            If qty = 0 Then
                lblin.Visible = False
                Label13.Visible = True
                Con.Open()
                qry = "select * from tbl_sorder where p_name='" & txtpname.Text & "'"
                cmd = New SqlCommand(qry, Con)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    lblorder.Visible = True
                    lblin.Visible = False
                Else
                    Con.Close()
                    If MsgBoxResult.Yes = MsgBox("Do you want to order", MsgBoxStyle.YesNo, "order") Then
                        'status = "YES"
                        frmsupplierorder.Show()
                    End If
                End If
                Con.Close()
            ElseIf qty < Convert.ToInt32(txtqty.Text) Then
                lblin.Visible = True
                Label13.Visible = False
                Con.Close()
                Con.Open()
                qry = "select * from tbl_sorder where p_name='" & txtpname.Text & "'"
                cmd = New SqlCommand(qry, Con)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    lblorder.Visible = True
                    lblin.Visible = False
                Else
                    Con.Close()

                    If MsgBoxResult.Yes = MsgBox("Do you want to order", MsgBoxStyle.YesNo, "order") Then
                        frmsupplierorder.Show()
                    End If

                End If
                Con.Close()
            End If
        End If
    End Sub

End Class