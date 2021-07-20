Imports System.Data.SqlClient
Public Class frmdeliverydetails

    Private Sub frmdeliverydetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con.Open()
        qry = "select * from tbl_customerorder where delivery_date='" & dtpdeliver.Value & "'"
        adp = New SqlDataAdapter(qry, Con)
        ds = New DataSet
        adp.Fill(ds, "tbl_customerorder")
        dgvdelivery.DataSource = ds
        dgvdelivery.DataMember = ds.Tables(0).ToString
        Con.Close()
    End Sub

    
End Class