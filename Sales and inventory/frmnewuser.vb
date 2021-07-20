Imports System.Data.SqlClient

Public Class frmnewuser
    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        If txtuser.Text = "" Or txtpwd.Text = "" Or txtcpwd.text = "" Then
            MsgBox("enter the details", MsgBoxStyle.Information, "invalid")
        ElseIf txtpwd.Text <> txtcpwd.Text Then
            MsgBox("confirm the password", MsgBoxStyle.Exclamation, "confirm")
        Else
            Con.Open()
            qry = "insert into tbl_login(username,password)values('" & txtuser.Text & "','" & txtpwd.Text & "')"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("user created", MsgBoxStyle.Information, "newuser")
            Me.Hide()
            frmlogin.Show()
            Con.Close()


        End If
    End Sub
End Class

