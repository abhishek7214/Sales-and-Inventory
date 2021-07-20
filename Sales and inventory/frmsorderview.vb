Imports System.Data.SqlClient
Public Class frmsorderview
    Dim initial_qty, current_qty, qty As Integer
    Dim status As String
    Sub fillorders()
        Con.Open()
        qry = "select * from tbl_sorder"
        adp = New SqlDataAdapter(qry, Con)
        ds = New DataSet
        adp.Fill(ds, "tbl_sorder")
        dgvsoview.DataSource = ds
        dgvsoview.DataMember = ds.Tables(0).ToString
        Con.Close()
    End Sub

    Private Sub frmsorderview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillorders()
    End Sub

    Private Sub btnrecived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecived.Click
        btnrestore.Enabled = True
        Con.Close()
        Con.Open()
        qry = "update tbl_sorder set status='RECEIVED' where o_no='" & dgvsoview.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        qry = "select * from tbl_product where p_name='" & dgvsoview.CurrentRow.Cells(2).Value & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            initial_qty = Convert.ToInt32(dr(5).ToString)
            current_qty = Convert.ToInt32(dgvsoview.CurrentRow.Cells(3).Value)
            qty = initial_qty + current_qty
            Con.Close()
            Con.Open()
            qry = "update tbl_product set p_quantity='" & qty & "' where p_name='" & dgvsoview.CurrentRow.Cells(2).Value & "'"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product updated", MsgBoxStyle.Information, "updation")
            Con.Close()

        End If
        fillorders()
    End Sub

    Private Sub btnrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestore.Click
        If MsgBoxResult.No = MsgBox("Do you want to update", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "RESTORE") Then Exit Sub
        Con.Close()
        Con.Open()
        qry = "select status from tbl_sorder where o_no='" & dgvsoview.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If dr(0).ToString = "RECEIVED" Then
                status = "ORDERED"
            ElseIf dr(0).ToString = "ORDERED" Then
                status = "RECEIVED"
            End If
        End If
        Con.Close()
        Con.Open()
        qry = "update tbl_sorder set status='" & status & "' where o_no='" & dgvsoview.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        qry = "select * from tbl_product where p_name='" & dgvsoview.CurrentRow.Cells(2).Value & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            initial_qty = Convert.ToInt32(dr(5).ToString)
            current_qty = Convert.ToInt32(dgvsoview.CurrentRow.Cells(3).Value)
            qty = initial_qty - current_qty
            Con.Close()
            Con.Open()
            qry = "update tbl_product set p_quantity='" & qty & "' where p_name='" & dgvsoview.CurrentRow.Cells(2).Value & "'"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product updated", MsgBoxStyle.Information, "updation")
            Con.Close()

        End If
        fillorders()
    End Sub
End Class