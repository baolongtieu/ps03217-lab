Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmEditPro
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=.; database=quanlybanhang_2; integrated security =true"
    Dim chuoiketnoi As String = "workstation id=longtbps03217.mssql.somee.com;packet size=4096;user id=baolong95_SQLLogin_1;pwd=4mcygq5nzf;data source=longtbps03217.mssql.somee.com;persist security info=False;initial catalog=longtbps03217"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub filldata()
        Dim sql As String = <sql>
                                select * from sanpham_ps03217 inner join loaisp_ps03217 on sanpham_ps03217.MaLoai = loaisp_ps03217.MaLoai
                            </sql>
        Fill(sql, "sanpham_ps03217")
        data.DataSource = ds.Tables("sanpham_ps03217")
        dgvEdit2.DataSource = data
        data.ResetBindings(False)

    End Sub
    Private Sub btnClosePro_Click(sender As Object, e As EventArgs) Handles btnClosePro.Click
        Me.Close()
    End Sub

    Private Sub frmEditPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LOAISP_PS03217TableAdapter.Fill(Me.Quanlybanhang_2DataSet.LOAISP_PS03217)
        filldata()
    End Sub

    Private Sub btnInsertPro_Click(sender As Object, e As EventArgs) Handles btnInsertPro.Click
        Try

            If txtId.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ElseIf txtProName.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ElseIf cboIDform.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Lưu thành công")

                Dim Sql As String =
                            <sql>
                insert into SANPHAM_PS03217 (MaSP, TenSP, MaLoai)
        values( N'{0}', N'{1}', N'{2}')
                                            </sql>

                Sql = String.Format(Sql, txtId.Text, txtProName.Text, cboIDform.Text)
                ExecuteNonQuery(Sql)

                filldata()
                txtId.Text = Nothing
                txtProName.Text = Nothing
                cboIDform.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Không được trùng Mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles data.CurrentChanged

    End Sub

    Private Sub dgvEdit2_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEdit2.SelectionChanged
        Try
            Dim rowview As DataRowView = data.Current
            Dim row As DataRow = rowview.Row
            txtId.Text = row("masp")
            txtProName.Text = row("tensp")
            cboIDform.Text = row("maloai")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEditPro_Click(sender As Object, e As EventArgs) Handles btnEditPro.Click
        Dim sql As String = <sql>
                                update sanpham_ps03217
                                set tensp = N'{0}', maloai = N'{1}'
                                where masp = '{2}'
                            
                            </sql>
        sql = String.Format(sql, txtProName.Text, cboIDform.Text, txtId.Text)
        ExecuteNonQuery(sql)
        filldata()
    End Sub
    Private Sub btnDeletePro_Click(sender As Object, e As EventArgs) Handles btnDeletePro.Click
        Dim Sql As String = <sql>
                                DELETE FROM  SANPHAM_ps03217
                                WHERE          (MaSP = N'{0}')
                                
                           </sql>
        Sql = String.Format(Sql, txtId.Text)
        ExecuteNonQuery(Sql)
        filldata()
    End Sub

    Private Sub LoadDataComboBox()
        Dim sqlquery As String = "select MaLoai,TenLoai from dbo.LOAISP_PS03217"
        filldata()
        Dim sql As String = <sql>
                                select * from sanpham_ps03217 inner join loaisp_ps03217 on sanpham_ps03217.MaLoai = loaisp_ps03217.MaLoai
                            </sql>
        Fill(sql, "SANPHAM_PS03217")
        cboIDform.DataSource = ds.Tables("SANPHAM_PS03217")
        cboIDform.ValueMember = "MaLoai"
        cboIDform.DisplayMember = "TenLoai"
    End Sub
End Class