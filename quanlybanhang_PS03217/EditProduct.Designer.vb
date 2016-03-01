<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditPro))
        Me.btnClosePro = New System.Windows.Forms.Button()
        Me.btnDeletePro = New System.Windows.Forms.Button()
        Me.btnEditPro = New System.Windows.Forms.Button()
        Me.btnInsertPro = New System.Windows.Forms.Button()
        Me.dgvEdit2 = New System.Windows.Forms.DataGridView()
        Me.masp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maloai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenloai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tensp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtProName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIDform = New System.Windows.Forms.ComboBox()
        Me.Quanlybanhang_2DataSet = New quanlybanhang_PS03217.quanlybanhang_2DataSet()
        Me.LOAISPPS03217BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOAISP_PS03217TableAdapter = New quanlybanhang_PS03217.quanlybanhang_2DataSetTableAdapters.LOAISP_PS03217TableAdapter()
        CType(Me.dgvEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quanlybanhang_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOAISPPS03217BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClosePro
        '
        Me.btnClosePro.Location = New System.Drawing.Point(381, 292)
        Me.btnClosePro.Name = "btnClosePro"
        Me.btnClosePro.Size = New System.Drawing.Size(75, 23)
        Me.btnClosePro.TabIndex = 16
        Me.btnClosePro.Text = "Close"
        Me.btnClosePro.UseVisualStyleBackColor = True
        '
        'btnDeletePro
        '
        Me.btnDeletePro.Location = New System.Drawing.Point(174, 292)
        Me.btnDeletePro.Name = "btnDeletePro"
        Me.btnDeletePro.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletePro.TabIndex = 17
        Me.btnDeletePro.Text = "Delete"
        Me.btnDeletePro.UseVisualStyleBackColor = True
        '
        'btnEditPro
        '
        Me.btnEditPro.Location = New System.Drawing.Point(93, 292)
        Me.btnEditPro.Name = "btnEditPro"
        Me.btnEditPro.Size = New System.Drawing.Size(75, 23)
        Me.btnEditPro.TabIndex = 18
        Me.btnEditPro.Text = "Edit"
        Me.btnEditPro.UseVisualStyleBackColor = True
        '
        'btnInsertPro
        '
        Me.btnInsertPro.Location = New System.Drawing.Point(12, 292)
        Me.btnInsertPro.Name = "btnInsertPro"
        Me.btnInsertPro.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertPro.TabIndex = 19
        Me.btnInsertPro.Text = "Insert"
        Me.btnInsertPro.UseVisualStyleBackColor = True
        '
        'dgvEdit2
        '
        Me.dgvEdit2.AllowUserToDeleteRows = False
        Me.dgvEdit2.AutoGenerateColumns = False
        Me.dgvEdit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdit2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masp, Me.maloai, Me.tenloai, Me.tensp})
        Me.dgvEdit2.DataSource = Me.data
        Me.dgvEdit2.Location = New System.Drawing.Point(12, 60)
        Me.dgvEdit2.Name = "dgvEdit2"
        Me.dgvEdit2.ReadOnly = True
        Me.dgvEdit2.Size = New System.Drawing.Size(444, 226)
        Me.dgvEdit2.TabIndex = 15
        '
        'masp
        '
        Me.masp.DataPropertyName = "masp"
        Me.masp.HeaderText = "Mã sản phẩm"
        Me.masp.Name = "masp"
        Me.masp.ReadOnly = True
        '
        'maloai
        '
        Me.maloai.DataPropertyName = "maloai"
        Me.maloai.HeaderText = "Mã loại"
        Me.maloai.Name = "maloai"
        Me.maloai.ReadOnly = True
        '
        'tenloai
        '
        Me.tenloai.DataPropertyName = "tenloai"
        Me.tenloai.HeaderText = "Tên loại"
        Me.tenloai.Name = "tenloai"
        Me.tenloai.ReadOnly = True
        '
        'tensp
        '
        Me.tensp.DataPropertyName = "tensp"
        Me.tensp.HeaderText = "Tên Sản phẩm"
        Me.tensp.Name = "tensp"
        Me.tensp.ReadOnly = True
        '
        'data
        '
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 13)
        Me.lblId.TabIndex = 20
        Me.lblId.Text = "ID :"
        '
        'lblProName
        '
        Me.lblProName.AutoSize = True
        Me.lblProName.Location = New System.Drawing.Point(148, 9)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(81, 13)
        Me.lblProName.TabIndex = 20
        Me.lblProName.Text = "Product Name :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(42, 7)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 21
        '
        'txtProName
        '
        Me.txtProName.Location = New System.Drawing.Point(235, 6)
        Me.txtProName.Name = "txtProName"
        Me.txtProName.Size = New System.Drawing.Size(221, 20)
        Me.txtProName.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID Form :"
        '
        'cboIDform
        '
        Me.cboIDform.FormattingEnabled = True
        Me.cboIDform.Items.AddRange(New Object() {"ML001", "ML002", "ML003", "ML004"})
        Me.cboIDform.Location = New System.Drawing.Point(68, 33)
        Me.cboIDform.Name = "cboIDform"
        Me.cboIDform.Size = New System.Drawing.Size(121, 21)
        Me.cboIDform.TabIndex = 22
        '
        'Quanlybanhang_2DataSet
        '
        Me.Quanlybanhang_2DataSet.DataSetName = "quanlybanhang_2DataSet"
        Me.Quanlybanhang_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LOAISPPS03217BindingSource
        '
        Me.LOAISPPS03217BindingSource.DataMember = "LOAISP_PS03217"
        Me.LOAISPPS03217BindingSource.DataSource = Me.Quanlybanhang_2DataSet
        '
        'LOAISP_PS03217TableAdapter
        '
        Me.LOAISP_PS03217TableAdapter.ClearBeforeFill = True
        '
        'frmEditPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 326)
        Me.Controls.Add(Me.cboIDform)
        Me.Controls.Add(Me.txtProName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnClosePro)
        Me.Controls.Add(Me.btnDeletePro)
        Me.Controls.Add(Me.btnEditPro)
        Me.Controls.Add(Me.btnInsertPro)
        Me.Controls.Add(Me.dgvEdit2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditPro"
        Me.Text = "Edit Product"
        CType(Me.dgvEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quanlybanhang_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOAISPPS03217BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClosePro As System.Windows.Forms.Button
    Friend WithEvents btnDeletePro As System.Windows.Forms.Button
    Friend WithEvents btnEditPro As System.Windows.Forms.Button
    Friend WithEvents btnInsertPro As System.Windows.Forms.Button
    Friend WithEvents dgvEdit2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtProName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.BindingSource
    Friend WithEvents cboIDform As System.Windows.Forms.ComboBox
    Friend WithEvents Quanlybanhang_2DataSet As quanlybanhang_PS03217.quanlybanhang_2DataSet
    Friend WithEvents LOAISPPS03217BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOAISP_PS03217TableAdapter As quanlybanhang_PS03217.quanlybanhang_2DataSetTableAdapters.LOAISP_PS03217TableAdapter
    Friend WithEvents masp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maloai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenloai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tensp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
