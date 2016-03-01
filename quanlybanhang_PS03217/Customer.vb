Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCusInf
    Dim db As New DataTable

    Private Sub btnCloseCustomer_Click(sender As Object, e As EventArgs) Handles btnCloseCustomer.Click
        Me.Close()
    End Sub


    Private Sub btnSeachCus_Click(sender As Object, e As EventArgs) Handles btnSeachCus.Click
        Dim ketnoi As SqlConnection = New SqlConnection(conn)
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', Diachi as 'Địa chỉ', SDT as 'SĐT', [Email] from KHACHHANG_PS03217 where MAKH='" & txtId.Text & "'", conn)
        Try
            If txtId.Text = "" Then
                MessageBox.Show("Bạn cần nhập ID", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvCustomer.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvCustomer.DataSource = db.DefaultView
                    txtId.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtId.Text = Nothing
                End If
            End If
            ketnoi.Close()
        Catch ex As Exception
        End Try
    End Sub
    
End Class