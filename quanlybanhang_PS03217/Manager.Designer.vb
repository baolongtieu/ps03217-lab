<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mtrCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtrEditCus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtrCusInf = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtrProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtrEditPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtrProInf = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCusMa = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtrCustomer, Me.mtrProduct})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mtrCustomer
        '
        Me.mtrCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtrEditCus, Me.mtrCusInf})
        Me.mtrCustomer.Name = "mtrCustomer"
        Me.mtrCustomer.Size = New System.Drawing.Size(71, 20)
        Me.mtrCustomer.Text = "Customer"
        '
        'mtrEditCus
        '
        Me.mtrEditCus.Name = "mtrEditCus"
        Me.mtrEditCus.Size = New System.Drawing.Size(192, 22)
        Me.mtrEditCus.Text = "Edit Customer"
        '
        'mtrCusInf
        '
        Me.mtrCusInf.Name = "mtrCusInf"
        Me.mtrCusInf.Size = New System.Drawing.Size(192, 22)
        Me.mtrCusInf.Text = "Customer Information"
        '
        'mtrProduct
        '
        Me.mtrProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtrEditPro, Me.mtrProInf})
        Me.mtrProduct.Name = "mtrProduct"
        Me.mtrProduct.Size = New System.Drawing.Size(61, 20)
        Me.mtrProduct.Text = "Product"
        '
        'mtrEditPro
        '
        Me.mtrEditPro.Name = "mtrEditPro"
        Me.mtrEditPro.Size = New System.Drawing.Size(182, 22)
        Me.mtrEditPro.Text = "Edit Product"
        '
        'mtrProInf
        '
        Me.mtrProInf.Name = "mtrProInf"
        Me.mtrProInf.Size = New System.Drawing.Size(182, 22)
        Me.mtrProInf.Text = "Product Information"
        '
        'lblCusMa
        '
        Me.lblCusMa.AutoSize = True
        Me.lblCusMa.BackColor = System.Drawing.Color.Transparent
        Me.lblCusMa.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusMa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCusMa.Location = New System.Drawing.Point(214, 36)
        Me.lblCusMa.Name = "lblCusMa"
        Me.lblCusMa.Size = New System.Drawing.Size(314, 38)
        Me.lblCusMa.TabIndex = 1
        Me.lblCusMa.Text = "Customer Manager"
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.quanlybanhang_PS03217.My.Resources.Resources.DSC_77091
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 269)
        Me.Controls.Add(Me.lblCusMa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManager"
        Me.Text = "Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mtrCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtrEditCus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtrCusInf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtrProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtrEditPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtrProInf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCusMa As System.Windows.Forms.Label
End Class
