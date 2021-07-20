Imports System.Data.SqlClient
Module general
    Public Con As New SqlConnection("Data Source=SNEHESH-PC\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True")
    Public qry As String
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public adp As SqlDataAdapter
    Public ds As DataSet
    Public qty As Integer
    Public pname As String
    Public status As String
End Module
