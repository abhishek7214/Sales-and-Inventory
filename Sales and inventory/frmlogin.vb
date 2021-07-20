Imports System.Data.SqlClient
Public Class frmlogin

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clear()
    End Sub


    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Con.Open()
        qry = "select * from tbl_login where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("login sucess", MsgBoxStyle.Information, Me.Text)
            clear()
            pgbar.Visible = True
            pgbar.Value = 0
            lblnum.Visible = True
            lblpcntg.Visible = True
            Timer1.Enabled = True

        Else
            MsgBox("Login Failed.Try Again!!!", MsgBoxStyle.Critical, "INVALID")
            clear()
        End If
        Con.Close()
    End Sub
    Sub clear()
        txtusername.Clear()
        txtpassword.Clear()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pgbar.Value >= 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmmain.Show()
        Else
            pgbar.Value = pgbar.Value + 1
            lblnum.Text = pgbar.Value
        End If
    End Sub

    Private Sub btnnewuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewuser.Click
        Me.Hide()
        frmnewuser.Show()

    End Sub
End Class
