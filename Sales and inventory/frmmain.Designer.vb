<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_category = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_product = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_supplier = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_search = New System.Windows.Forms.ToolStripMenuItem
        Me.ORDERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOMERORDERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SUPPLIERORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.mnu_search, Me.ORDERSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_category, Me.mnu_product, Me.mnu_supplier})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'mnu_category
        '
        Me.mnu_category.Name = "mnu_category"
        Me.mnu_category.Size = New System.Drawing.Size(181, 22)
        Me.mnu_category.Text = "CATEGORY DETAILS"
        '
        'mnu_product
        '
        Me.mnu_product.Name = "mnu_product"
        Me.mnu_product.Size = New System.Drawing.Size(181, 22)
        Me.mnu_product.Text = "PRODUCT DETAILS"
        '
        'mnu_supplier
        '
        Me.mnu_supplier.Name = "mnu_supplier"
        Me.mnu_supplier.Size = New System.Drawing.Size(181, 22)
        Me.mnu_supplier.Text = "SUPPLIER DETAILS"
        '
        'mnu_search
        '
        Me.mnu_search.Name = "mnu_search"
        Me.mnu_search.Size = New System.Drawing.Size(63, 20)
        Me.mnu_search.Text = "SEARCH"
        '
        'ORDERSToolStripMenuItem
        '
        Me.ORDERSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUSTOMERORDERSToolStripMenuItem, Me.SUPPLIERORDERToolStripMenuItem})
        Me.ORDERSToolStripMenuItem.Name = "ORDERSToolStripMenuItem"
        Me.ORDERSToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ORDERSToolStripMenuItem.Text = "ORDERS"
        '
        'CUSTOMERORDERSToolStripMenuItem
        '
        Me.CUSTOMERORDERSToolStripMenuItem.Name = "CUSTOMERORDERSToolStripMenuItem"
        Me.CUSTOMERORDERSToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CUSTOMERORDERSToolStripMenuItem.Text = "CUSTOMER ORDERS"
        '
        'SUPPLIERORDERToolStripMenuItem
        '
        Me.SUPPLIERORDERToolStripMenuItem.Name = "SUPPLIERORDERToolStripMenuItem"
        Me.SUPPLIERORDERToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SUPPLIERORDERToolStripMenuItem.Text = "SUPPLIER ORDER"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.Text = "SALES AND INVENTORY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_category As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_product As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_supplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_search As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERORDERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUPPLIERORDERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
