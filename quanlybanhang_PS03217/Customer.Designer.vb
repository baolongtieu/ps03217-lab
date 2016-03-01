<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusInf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusInf))
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnSeachCus = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.btnCloseCustomer = New System.Windows.Forms.Button()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(20, 27)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(50, 25)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(140, 20)
        Me.txtId.TabIndex = 1
        '
        'btnSeachCus
        '
        Me.btnSeachCus.Location = New System.Drawing.Point(196, 23)
        Me.btnSeachCus.Name = "btnSeachCus"
        Me.btnSeachCus.Size = New System.Drawing.Size(75, 23)
        Me.btnSeachCus.TabIndex = 2
        Me.btnSeachCus.Text = "Seach"
        Me.btnSeachCus.UseVisualStyleBackColor = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(12, 62)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(481, 253)
        Me.dgvCustomer.TabIndex = 3
        '
        'btnCloseCustomer
        '
        Me.btnCloseCustomer.Location = New System.Drawing.Point(418, 321)
        Me.btnCloseCustomer.Name = "btnCloseCustomer"
        Me.btnCloseCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseCustomer.TabIndex = 2
        Me.btnCloseCustomer.Text = "Close"
        Me.btnCloseCustomer.UseVisualStyleBackColor = True
        '
        'frmCusInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 351)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.btnCloseCustomer)
        Me.Controls.Add(Me.btnSeachCus)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCusInf"
        Me.Text = "Customer Information"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnSeachCus As System.Windows.Forms.Button
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents btnCloseCustomer As System.Windows.Forms.Button
End Class
