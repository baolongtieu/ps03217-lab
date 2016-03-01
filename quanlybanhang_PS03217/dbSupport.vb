Imports System.Data.SqlClient
Imports System.Data

Module dbSupport
    Public ds As New DataSet()
    Public conn As String = "Data Source=localhost;Initial Catalog=quanlybanhang_2;Integrated Security=True"
    Dim chuoiketnoi As String = "workstation id=longtbps03217.mssql.somee.com;packet size=4096;user id=baolong95_SQLLogin_1;pwd=4mcygq5nzf;data source=longtbps03217.mssql.somee.com;persist security info=False;initial catalog=longtbps03217"
    Public ketnoi As SqlConnection = New SqlConnection(conn)

    Public Sub ExecuteNonQuery(Sql As String)
        Dim Connection As New SqlConnection(conn)
        Dim Command As New SqlCommand(Sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Fill(Sql As String, TableName As String)
        Dim Connection As New SqlConnection(conn)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub

    Public Function KhachHangData() As DataSet

        Dim xemds As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', Diachi as 'Địa chỉ', SDT as 'SĐT', [Email] from KHACHHANG_PS03217", conn)
        Dim db As New DataSet
        ketnoi.Open()
        xemds.Fill(db)
        ketnoi.Close()
        Return db
    End Function
    Public Function SanPhamData() As DataSet

        Dim xemds1 As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP', TenSP as 'Tên SP', MaLoai as 'Mã loại' from KHACHHANG_PS03217", conn)
        Dim db1 As New DataSet
        ketnoi.Open()
        xemds1.Fill(db1)
        ketnoi.Close()
        Return db1
    End Function
End Module
