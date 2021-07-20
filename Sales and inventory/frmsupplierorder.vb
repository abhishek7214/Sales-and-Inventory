Imports System.Data.SqlClient
Public Class frmsupplierorder
    Dim o_num
    Dim status As String
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clear()
        Con.Open()
        qry = "select max(o_no)from tbl_sorder"
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
        If txtono.Text = "" Or cmbsname.Text = "" Or txtpname.Text = "" Or txtqty.Text = "" Then
            MsgBox("Please enter the details", MsgBoxStyle.Information, "enter")
        Else
            status = "ORDERED"
            Con.Open()
            qry = "insert into tbl_sorder(o_no,s_name,p_name,qty,odate,ddate,status)values('" & txtono.Text & "','" & cmbsname.Text & "','" & txtpname.Text & "','" & txtqty.Text & "','" & dtpodate.Value & "','" & dtpddate.Value & "','" & status & "')"
            cmd = New SqlCommand(qry, Con)
            cmd.ExecuteNonQuery()
            MsgBox("submitted successfully", MsgBoxStyle.Information, "submit")
            Con.Close()
        End If
    End Sub
    Sub clear()
        txtono.Text = ""
        cmbsname.Text = ""
        txtpname.Text = ""
        txtqty.Text = ""

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBoxResult.No = MsgBox("do you want to exit", MsgBoxStyle.YesNo, "exit") Then Exit Sub
        Me.Close()

    End Sub

   
    Private Sub frmsupplierorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If status <> "YES" Then
            btnnew.Enabled = False

            txtpname.Text = pname
            cmbsname.Text = ""
            txtono.Text = ""
            txtqty.Text = ""
            Con.Open()
            qry = "select max(o_no)from tbl_sorder"
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
        End If
    End Sub
End Class