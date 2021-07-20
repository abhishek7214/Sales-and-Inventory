Imports System.Data.SqlClient

Public Class frmproduct
    Dim p_id
    Dim initial_qty, current_qty, qty As Integer
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        Con.Open()
        qry = "select max(substring(p_id,3,len(p_id)))+1 from tbl_product"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            p_id = dr(0).ToString
            If p_id = "" Then
                txtpid.Text = "PD001"
            Else
                If Len(p_id) = 1 Then
                    txtpid.Text = "PD00" & p_id
                ElseIf Len(p_id) = 2 Then
                    txtpid.Text = "PD0" & p_id
                Else
                    txtpid.Text = "PD" & p_id

                End If
            End If

        End If
        Con.Close()
        btnsave.Enabled = True
        txtpname.Clear()


    End Sub

    Private Sub frmproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con.Open()
        qry = "select cat_name from tbl_category"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbcat.Items.Add(dr(0).ToString)
        End While
        Con.Close()
        Con.Open()
        qry = "select mesure_name from tbl_mesure"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        
        Con.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtpid.Text = "" Or txtpname.Text = "" Or txtprice.Text = "" Or cmbcat.Text = "" Then
            MsgBox("Please enter the required details", MsgBoxStyle.Information, "save")
        Else
            Con.Close()
            Con.Open()
            qry = "select * from tbl_product where p_id='" & txtpid.Text & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                If MsgBoxResult.No = MsgBox("do you want to update?", MsgBoxStyle.YesNo, "update") Then
                    Exit Sub
                End If
                initial_qty = Convert.ToInt32(dr(5).ToString)
                current_qty = Convert.ToInt32(txtquantity.Text)
                qty = initial_qty + current_qty
                Con.Close()
                Con.Open()
                qry = "update tbl_product set p_name='" & txtpname.Text & "',p_price='" & txtprice.Text & "',p_desc='" & txtdis.Text & "',p_quantity='" & qty & "',mesure_name='" & txtmesure.Text & "' where p_id='" & txtpid.Text & "'"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("product updated", MsgBoxStyle.Information, "updation")
                Con.Close()
                fill_products()
            Else
                Con.Close()
                Con.Open()
                qry = "insert into tbl_product(p_id,p_name,cat_name,p_price,p_desc,p_quantity,mesure_name) values ('" & txtpid.Text & "','" & txtpname.Text & "','" & cmbcat.Text & "','" & txtprice.Text & "','" & txtdis.Text & "','" & txtquantity.Text & "','" & txtmesure.Text & "')"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Product added successfully", MsgBoxStyle.Information, "save")
                Con.Close()
                fill_products()
            End If
           
        End If

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        fill_products()

    End Sub

    Private Sub dgvproduct_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduct.CellClick
        txtpid.Text = dgvproduct.CurrentRow.Cells(0).Value
        txtpname.Text = dgvproduct.CurrentRow.Cells(1).Value
        cmbcat.Text = dgvproduct.CurrentRow.Cells(2).Value
        txtprice.Text = dgvproduct.CurrentRow.Cells(3).Value
        txtdis.Text = dgvproduct.CurrentRow.Cells(4).Value
        txtquantity.Text = dgvproduct.CurrentRow.Cells(5).Value
        txtmesure.Text = dgvproduct.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "delete") Then Exit Sub
        Con.Open()
        qry = "delete from tbl_product where p_id='" & txtpid.Text & "'"
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        MsgBox("deleted successfully", MsgBoxStyle.Information, "delete")
        Con.Close()
        clear()
        fill_products()
    End Sub
    Sub fill_products()
        Con.Open()
        qry = "select * from tbl_product"
        adp = New SqlDataAdapter(qry, Con)
        ds = New DataSet
        adp.Fill(ds, "tbl_product")
        dgvproduct.DataSource = ds
        dgvproduct.DataMember = ds.Tables(0).ToString
        Con.Close()

    End Sub
    Sub clear()
        txtdis.Clear()
        txtpid.Clear()
        txtpname.Clear()
        txtprice.Clear()
        cmbcat.Text = ""
        txtmesure.Text = ""
        txtquantity.Text = ""

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub



    Private Sub txtquantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MsgBox("Only Numbers", MsgBoxStyle.Exclamation, "numbers")
        End If
    End Sub



    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MsgBox("Only Numbers", MsgBoxStyle.Exclamation, "numbers")
        End If
    End Sub

    Private Sub cmbcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcat.SelectedIndexChanged
        Con.Close()
        Con.Open()
        qry = "select mesure_name from tbl_category where cat_name='" & cmbcat.SelectedItem.ToString & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtmesure.Text = dr(0).ToString

        End If
        Con.Close()
    End Sub

    
End Class