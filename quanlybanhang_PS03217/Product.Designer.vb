<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProInf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProInf))
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnSeachPro = New System.Windows.Forms.Button()
        Me.btnCloseProduct = New System.Windows.Forms.Button()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 29)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(42, 26)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(171, 20)
        Me.txtId.TabIndex = 1
        '
        'btnSeachPro
        '
        Me.btnSeachPro.Location = New System.Drawing.Point(229, 24)
        Me.btnSeachPro.Name = "btnSeachPro"
        Me.btnSeachPro.Size = New System.Drawing.Size(75, 23)
        Me.btnSeachPro.TabIndex = 2
        Me.btnSeachPro.Text = "Seach"
        Me.btnSeachPro.UseVisualStyleBackColor = True
        '
        'btnCloseProduct
        '
        Me.btnCloseProduct.Location = New System.Drawing.Point(457, 294)
        Me.btnCloseProduct.Name = "btnCloseProduct"
        Me.btnCloseProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseProduct.TabIndex = 2
        Me.btnCloseProduct.Text = "Close"
        Me.btnCloseProduct.UseVisualStyleBackColor = True
        '
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(12, 62)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(520, 226)
        Me.dgvProduct.TabIndex = 3
        '
        'frmProInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 322)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.btnCloseProduct)
        Me.Controls.Add(Me.btnSeachPro)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProInf"
        Me.Text = "Product Information"
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnSeachPro As System.Windows.Forms.Button
    Friend WithEvents btnCloseProduct As System.Windows.Forms.Button
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
End Class
