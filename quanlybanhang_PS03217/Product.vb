Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmProInf
    Dim db1 As New DataTable
    Private Sub btnCloseProduct_Click(sender As Object, e As EventArgs) Handles btnCloseProduct.Click
        Me.Close()
    End Sub

    Private Sub btnSeachPro_Click(sender As Object, e As EventArgs) Handles btnSeachPro.Click
        Dim ketnoi As SqlConnection = New SqlConnection(conn)
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP', TenSP as 'TenSP', MaLoai as 'Mã loại' from SANPHAM_PS03217 where MaSP='" & txtId.Text & "'", conn)
        Try
            If txtId.Text = "" Then
                MessageBox.Show("Bạn cần nhập ID", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db1.Clear()
                dgvProduct.DataSource = Nothing
                xem.Fill(db1)
                If db1.Rows.Count > 0 Then
                    dgvProduct.DataSource = db1.DefaultView
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