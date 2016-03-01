
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmEditCus
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=.; database=quanlybanhang_2; integrated security =true"
    Dim chuoiketnoi As String = "workstation id=longtbps03217.mssql.somee.com;packet size=4096;user id=baolong95_SQLLogin_1;pwd=4mcygq5nzf;data source=longtbps03217.mssql.somee.com;persist security info=False;initial catalog=longtbps03217"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnCloseCus_Click(sender As Object, e As EventArgs) Handles btnCloseCus.Click
        Me.Close()
    End Sub

    Private Sub frmEditCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldata()
    End Sub
    Private Sub dgvEdit1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEdit1.SelectionChanged
        Try
            Dim rowview As DataRowView = bs.Current
            Dim row As DataRow = rowview.Row
            txtId.Text = row("makh")
            txtName.Text = row("tenkh")
            txtAddress.Text = row("diachi")
            txtPhone.Text = row("sdt")
            txtEmail.Text = row("email")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnInsertCus_Click(sender As Object, e As EventArgs) Handles btnInsertCus.Click
        Try

            If txtId.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ElseIf txtName.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ElseIf txtPhone.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                ElseIf txtEmail.Text = "" Then
                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Lưu thành công")

                Dim Sql As String =
                            <sql>
                insert into KHACHHANG_PS03217 (MaKH, TenKH, DiaChi, SDT, Email)
        values( N'{0}', N'{1}', N'{2}',N'{3}',N'{4}')
            </sql>

                Sql = String.Format(Sql, txtId.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text)
                ExecuteNonQuery(Sql)

                filldata()
                txtId.Text = Nothing
                txtName.Text = Nothing
                txtAddress.Text = Nothing
                txtPhone.Text = Nothing
                txtEmail.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub filldata()
        Dim sql As String = <sql>
                                select * from khachhang_ps03217 
                            </sql>
        Fill(sql, "sanpham_ps03217")
        bs.DataSource = ds.Tables("sanpham_ps03217")
        dgvEdit1.DataSource = bs
        bs.ResetBindings(False)

    End Sub

    Private Sub btnDeleteCus_Click(sender As Object, e As EventArgs) Handles btnDeleteCus.Click
        Dim Sql As String = <sql>
                                DELETE FROM  KHACHHANG_PS03217
                                WHERE          (MaKH = N'{0}')
                                </sql>
        Sql = String.Format(Sql, txtId.Text)
        ExecuteNonQuery(Sql)
        filldata()
    End Sub

    Private Sub btnEditCus_Click(sender As Object, e As EventArgs) Handles btnEditCus.Click
        Dim Sql As String =
                    <sql>
                        UPDATE KHACHHANG_PS03217 
                        SET TenKH = N'{0}', DiaChi = N'{1}', SDT = N'{2}', Email = N'{3}'
                        WHERE (MaKH = N'{4}')
                    </sql>
        Sql = String.Format(Sql, txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtId.Text)
        ExecuteNonQuery(Sql)
        filldata()
    End Sub
End Class