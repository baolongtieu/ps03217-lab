<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCus))
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnInsertCus = New System.Windows.Forms.Button()
        Me.btnEditCus = New System.Windows.Forms.Button()
        Me.btnDeleteCus = New System.Windows.Forms.Button()
        Me.btnCloseCus = New System.Windows.Forms.Button()
        Me.dgvEdit1 = New System.Windows.Forms.DataGridView()
        Me.makh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenkh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(13, 13)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(125, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(13, 39)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(51, 13)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address :"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(307, 13)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(44, 13)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(13, 65)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(43, 10)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(62, 20)
        Me.txtId.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 10)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(117, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(65, 36)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(419, 20)
        Me.txtAddress.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(357, 10)
        Me.txtPhone.MaxLength = 12
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(127, 20)
        Me.txtPhone.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(65, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(211, 20)
        Me.txtEmail.TabIndex = 1
        '
        'btnInsertCus
        '
        Me.btnInsertCus.Location = New System.Drawing.Point(16, 314)
        Me.btnInsertCus.Name = "btnInsertCus"
        Me.btnInsertCus.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertCus.TabIndex = 4
        Me.btnInsertCus.Text = "Insert"
        Me.btnInsertCus.UseVisualStyleBackColor = True
        '
        'btnEditCus
        '
        Me.btnEditCus.Location = New System.Drawing.Point(97, 314)
        Me.btnEditCus.Name = "btnEditCus"
        Me.btnEditCus.Size = New System.Drawing.Size(75, 23)
        Me.btnEditCus.TabIndex = 4
        Me.btnEditCus.Text = "Edit"
        Me.btnEditCus.UseVisualStyleBackColor = True
        '
        'btnDeleteCus
        '
        Me.btnDeleteCus.Location = New System.Drawing.Point(178, 314)
        Me.btnDeleteCus.Name = "btnDeleteCus"
        Me.btnDeleteCus.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCus.TabIndex = 4
        Me.btnDeleteCus.Text = "Delete"
        Me.btnDeleteCus.UseVisualStyleBackColor = True
        '
        'btnCloseCus
        '
        Me.btnCloseCus.Location = New System.Drawing.Point(554, 314)
        Me.btnCloseCus.Name = "btnCloseCus"
        Me.btnCloseCus.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseCus.TabIndex = 4
        Me.btnCloseCus.Text = "Close"
        Me.btnCloseCus.UseVisualStyleBackColor = True
        '
        'dgvEdit1
        '
        Me.dgvEdit1.AutoGenerateColumns = False
        Me.dgvEdit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdit1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.makh, Me.tenkh, Me.diachi, Me.sdt, Me.email})
        Me.dgvEdit1.DataSource = Me.bs
        Me.dgvEdit1.Location = New System.Drawing.Point(16, 100)
        Me.dgvEdit1.Name = "dgvEdit1"
        Me.dgvEdit1.Size = New System.Drawing.Size(613, 208)
        Me.dgvEdit1.TabIndex = 5
        '
        'makh
        '
        Me.makh.DataPropertyName = "makh"
        Me.makh.HeaderText = "Mã khách hàng"
        Me.makh.Name = "makh"
        Me.makh.Width = 110
        '
        'tenkh
        '
        Me.tenkh.DataPropertyName = "tenkh"
        Me.tenkh.HeaderText = "Tên khách hàng"
        Me.tenkh.Name = "tenkh"
        Me.tenkh.Width = 110
        '
        'diachi
        '
        Me.diachi.DataPropertyName = "diachi"
        Me.diachi.HeaderText = "Địa chỉ"
        Me.diachi.Name = "diachi"
        '
        'sdt
        '
        Me.sdt.DataPropertyName = "sdt"
        Me.sdt.HeaderText = "Số điện thoại"
        Me.sdt.Name = "sdt"
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 150
        '
        'frmEditCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 340)
        Me.Controls.Add(Me.dgvEdit1)
        Me.Controls.Add(Me.btnCloseCus)
        Me.Controls.Add(Me.btnDeleteCus)
        Me.Controls.Add(Me.btnEditCus)
        Me.Controls.Add(Me.btnInsertCus)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditCus"
        Me.Text = "Edit Customer"
        CType(Me.dgvEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertCus As System.Windows.Forms.Button
    Friend WithEvents btnEditCus As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCus As System.Windows.Forms.Button
    Friend WithEvents btnCloseCus As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents dgvEdit1 As System.Windows.Forms.DataGridView
    Friend WithEvents makh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenkh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diachi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
