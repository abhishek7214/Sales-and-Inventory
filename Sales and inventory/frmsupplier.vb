Imports System.Data.SqlClient
Public Class frmsupplier
    Dim s_id

    Private Sub txtpno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Only Numbers", MsgBoxStyle.Exclamation, "numbers")
        End If
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        Con.Open()
        qry = "select max(substring(s_id,3,len(s_id)))+1 from tbl_supplier"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            s_id = dr(0).ToString
            If s_id = "" Then
                txtsid.Text = "SP001"
            Else
                If Len(s_id) = 1 Then
                    txtsid.Text = "SP00" & s_id
                ElseIf Len(s_id) = 2 Then
                    txtsid.Text = "SP0" & s_id
                Else
                    txtsid.Text = "SP" & s_id

                End If
            End If

        End If
        Con.Close()
        btnsave.Enabled = True
        txtsname.Clear()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtsid.Text = "" Or txtsname.Text = "" Or txteid.Text = "" Or txtcmpy.Text = "" Or txtpno.Text = "" Or txtsadd.Text = "" Then
            MsgBox("Please enter the required details", MsgBoxStyle.Information, "save")
        Else
            Con.Close()
            Con.Open()
            qry = "select * from tbl_supplier where s_id='" & txtsid.Text & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                If MsgBoxResult.No = MsgBox("do you want to update?", MsgBoxStyle.YesNo, "update") Then
                    Exit Sub
                End If
               
                Con.Close()
                Con.Open()
                qry = "update tbl_supplier set s_name='" & txtsname.Text & "',s_add='" & txtsadd.Text & "',s_pno='" & txtpno.Text & "',s_eid='" & txteid.Text & "',s_cmpy='" & txtcmpy.Text & "' where s_id='" & txtsid.Text & "'"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("supplier details updated", MsgBoxStyle.Information, "updation")
                Con.Close()
                fill_supplier()
            Else
                Con.Close()
                Con.Open()
                qry = "insert into tbl_supplier(s_id,s_name,s_add,s_pno,s_eid,s_cmpy) values ('" & txtsid.Text & "','" & txtsname.Text & "','" & txtsadd.Text & "','" & txtpno.Text & "','" & txteid.Text & "','" & txtcmpy.Text & "')"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("supplier details added successfully", MsgBoxStyle.Information, "save")
                Con.Close()
                fill_supplier()
            End If

        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "delete") Then Exit Sub
        Con.Open()
        qry = "delete from tbl_supplier where s_id='" & txtsid.Text & "'"
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        MsgBox("deleted successfully", MsgBoxStyle.Information, "delete")
        Con.Close()
        clear()
        fill_supplier()
    End Sub
    Sub fill_supplier()
        Con.Open()
        qry = "select * from tbl_supplier"
        adp = New SqlDataAdapter(qry, Con)
        ds = New DataSet
        adp.Fill(ds, "tbl_supplier")
        dgvsupplier.DataSource = ds
        dgvsupplier.DataMember = ds.Tables(0).ToString
        Con.Close()

    End Sub
    Sub clear()
        txtcmpy.Text = ""
        txtpno.Text = ""
        txteid.Text = ""
        txtsadd.Text = ""
        txtsid.Text = ""
        txtsname.Text = ""

    End Sub

    Private Sub dgvsupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsupplier.CellClick
        txtsid.Text = dgvsupplier.CurrentRow.Cells(0).Value
        txtsname.Text = dgvsupplier.CurrentRow.Cells(1).Value
        txtsadd.Text = dgvsupplier.CurrentRow.Cells(2).Value
        txtpno.Text = dgvsupplier.CurrentRow.Cells(3).Value
        txteid.Text = dgvsupplier.CurrentRow.Cells(4).Value
        txtcmpy.Text = dgvsupplier.CurrentRow.Cells(5).Value

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        fill_supplier()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBoxResult.No = MsgBox("do you want to exit", MsgBoxStyle.YesNo, "exit") Then Exit Sub
        Me.Close()
    End Sub
End Class