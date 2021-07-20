Imports System.Data.SqlClient
Public Class frmemployee
    Dim empid
    Dim ename As String
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        Con.Open()
        qry = "select max(substring(empid,3,len(empid)))+1 from tbl_employee"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            empid = dr(0).ToString
            If empid = "" Then
                txteid.Text = "EM001"
            Else
                If Len(empid) = 1 Then
                    txteid.Text = "EM00" & empid
                ElseIf Len(empid) = 2 Then
                    txteid.Text = "EM0" & empid
                Else
                    txteid.Text = "EM" & empid

                End If
            End If

        End If
        Con.Close()
        btnsave.Enabled = True
        txtename.Clear()

    End Sub
    Sub clear()
        txteid.Text = ""
        txtename.Text = ""
        txteadd.Text = ""
        txtpno.Text = ""
        txtsalary.Text = ""


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txteid.Text = "" Or txtename.Text = "" Or txteadd.Text = "" Or txtpno.Text = "" Or txtsalary.Text = "" Then
            MsgBox("Please enter the required details", MsgBoxStyle.Information, "save")
        Else
            Con.Close()
            Con.Open()
            qry = "insert into tbl_employee(empid,ename,eadd,pno,doj,basic) values('" & txteid.Text & "','" & txtename.Text & "','" & txteadd.Text & "','" & txtpno.Text & "','" & dtpdoj.Value & "','" & txtsalary.Text & "')"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Details Added Successfully", MsgBoxStyle.Information, "save")
            Con.Close()
            clear()
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "delete") Then Exit Sub
        Con.Open()
        qry = "delete from tbl_employee where empid='" & txteid.Text & "'"
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        MsgBox("deleted successfully", MsgBoxStyle.Information, "delete")
        Con.Close()
        clear()

    End Sub
    

End Class