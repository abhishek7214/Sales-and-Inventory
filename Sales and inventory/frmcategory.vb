Imports System.Data.SqlClient
Public Class frmcategory
    Dim c_id
    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Con.Open()
        qry = "select max(substring(cat_id,3,len(cat_id)))+1 from tbl_category"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            c_id = dr(0).ToString
            If c_id = "" Then
                txtcatid.Text = "CT001"
            Else
                If Len(c_id) = 1 Then
                    txtcatid.Text = "CT00" & c_id
                ElseIf Len(c_id) = 2 Then
                    txtcatid.Text = "CT0" & c_id
                Else
                    txtcatid.Text = "CT" & c_id

                End If
            End If

        End If
        Con.Close()
        btnsave.Enabled = True
        txtcatname.Clear()
        txtmname.Clear()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcatid.Text = "" Or txtcatname.Text = "" Then
            MsgBox("please enter the details", MsgBoxStyle.Information, "enter")
        Else
            Con.Open()
            qry = "select * from tbl_category where cat_id='" & txtcatid.Text & "'"
            cmd = New SqlCommand(qry, Con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Already exists", MsgBoxStyle.Exclamation, "exists")
            Else
                Con.Close()
                Con.Open()
                qry = "insert into tbl_category(cat_id,cat_name,mesure_name)values('" & txtcatid.Text & "','" & txtcatname.Text & "','" & txtmname.Text & "')"
                cmd = New SqlCommand(qry, Con)
                cmd.ExecuteNonQuery()
                MsgBox("saved successfully", MsgBoxStyle.Information, "save")
                Con.Close()
                fill_catname()

            End If
            Con.Close()
        End If
    End Sub

   

    Private Sub lstcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcategory.SelectedIndexChanged
        Con.Open()
        qry = "select * from tbl_category where cat_name='" & lstcategory.SelectedItem.ToString & "'"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtcatid.Text = dr(0).ToString
            txtcatname.Text = dr(1).ToString
            txtmname.Text = dr(2).ToString
        End If
        Con.Close()
    End Sub

    Sub fill_catname()
        lstcategory.Items.Clear()
        Con.Open()
        qry = "select cat_name from tbl_category"
        cmd = New SqlCommand(qry, Con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            lstcategory.Items.Add(dr(0).ToString)

        End While
        Con.Close()
    End Sub


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("do you want to delete?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        Con.Open()
        qry = "delete from tbl_category where cat_id='" & txtcatid.Text & "' "
        cmd = New SqlCommand(qry, Con)
        cmd.ExecuteNonQuery()
        MsgBox("deleted successfully", MsgBoxStyle.Information, "deletion")
        Con.Close()
        fill_catname()
    End Sub

   
    Private Sub frmcategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnsave.Enabled = False
        fill_catname()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MsgBoxResult.No = MsgBox("do you want to exit", MsgBoxStyle.YesNo, "exit") Then Exit Sub
        Me.Close()
    End Sub
End Class