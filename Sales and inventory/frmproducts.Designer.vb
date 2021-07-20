<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproducts
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtsprice = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lstcatname = New System.Windows.Forms.ListBox
        Me.lblper = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.cmbmesure = New System.Windows.Forms.ComboBox
        Me.cmbcname = New System.Windows.Forms.ComboBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.txtcatid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstiname = New System.Windows.Forms.ListBox
        Me.lstcategory = New System.Windows.Forms.ListBox
        Me.txtiname = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtcat = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.dgvproduct = New System.Windows.Forms.DataGridView
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnexit1 = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.dgvstock = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(759, 510)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(751, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Products"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.txtsprice)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lstcatname)
        Me.Panel1.Controls.Add(Me.lblper)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnnew)
        Me.Panel1.Controls.Add(Me.cmbmesure)
        Me.Panel1.Controls.Add(Me.cmbcname)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.txtpname)
        Me.Panel1.Controls.Add(Me.txtcname)
        Me.Panel1.Controls.Add(Me.txtcatid)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(154, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 396)
        Me.Panel1.TabIndex = 0
        '
        'txtsprice
        '
        Me.txtsprice.Location = New System.Drawing.Point(131, 283)
        Me.txtsprice.Name = "txtsprice"
        Me.txtsprice.Size = New System.Drawing.Size(100, 20)
        Me.txtsprice.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "SELLING PRICE"
        '
        'lstcatname
        '
        Me.lstcatname.FormattingEnabled = True
        Me.lstcatname.Location = New System.Drawing.Point(131, 114)
        Me.lstcatname.Name = "lstcatname"
        Me.lstcatname.Size = New System.Drawing.Size(102, 95)
        Me.lstcatname.TabIndex = 18
        Me.lstcatname.Visible = False
        '
        'lblper
        '
        Me.lblper.AutoSize = True
        Me.lblper.Location = New System.Drawing.Point(245, 247)
        Me.lblper.Name = "lblper"
        Me.lblper.Size = New System.Drawing.Size(0, 13)
        Me.lblper.TabIndex = 17
        Me.lblper.Visible = False
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(280, 352)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(69, 22)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(184, 352)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(61, 23)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(92, 352)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(61, 24)
        Me.btnnew.TabIndex = 12
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'cmbmesure
        '
        Me.cmbmesure.FormattingEnabled = True
        Me.cmbmesure.Items.AddRange(New Object() {"Pieces", "Meter", "Leter", "Tin"})
        Me.cmbmesure.Location = New System.Drawing.Point(257, 188)
        Me.cmbmesure.Name = "cmbmesure"
        Me.cmbmesure.Size = New System.Drawing.Size(92, 21)
        Me.cmbmesure.TabIndex = 11
        Me.cmbmesure.Text = "-select-"
        '
        'cmbcname
        '
        Me.cmbcname.FormattingEnabled = True
        Me.cmbcname.Location = New System.Drawing.Point(131, 96)
        Me.cmbcname.Name = "cmbcname"
        Me.cmbcname.Size = New System.Drawing.Size(100, 21)
        Me.cmbcname.TabIndex = 10
        Me.cmbcname.Text = "-select-"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(131, 239)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(102, 20)
        Me.txtprice.TabIndex = 9
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(131, 189)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 8
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(133, 137)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(100, 20)
        Me.txtpname.TabIndex = 7
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(131, 96)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(100, 20)
        Me.txtcname.TabIndex = 6
        Me.txtcname.Visible = False
        '
        'txtcatid
        '
        Me.txtcatid.Location = New System.Drawing.Point(131, 44)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.ReadOnly = True
        Me.txtcatid.Size = New System.Drawing.Size(100, 20)
        Me.txtcatid.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ACTUAL PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRODUCT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CATEGORY NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORY ID"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(751, 484)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.lstiname)
        Me.Panel2.Controls.Add(Me.lstcategory)
        Me.Panel2.Controls.Add(Me.txtiname)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmbsearch)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtcat)
        Me.Panel2.Controls.Add(Me.btnsearch)
        Me.Panel2.Controls.Add(Me.dgvproduct)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(29, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 293)
        Me.Panel2.TabIndex = 1
        '
        'lstiname
        '
        Me.lstiname.FormattingEnabled = True
        Me.lstiname.Location = New System.Drawing.Point(197, 157)
        Me.lstiname.Name = "lstiname"
        Me.lstiname.Size = New System.Drawing.Size(120, 95)
        Me.lstiname.TabIndex = 11
        Me.lstiname.Visible = False
        '
        'lstcategory
        '
        Me.lstcategory.FormattingEnabled = True
        Me.lstcategory.Location = New System.Drawing.Point(199, 70)
        Me.lstcategory.Name = "lstcategory"
        Me.lstcategory.Size = New System.Drawing.Size(120, 69)
        Me.lstcategory.TabIndex = 10
        Me.lstcategory.Visible = False
        '
        'txtiname
        '
        Me.txtiname.Location = New System.Drawing.Point(197, 141)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(121, 20)
        Me.txtiname.TabIndex = 7
        Me.txtiname.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ENTER THE ITEM NAME"
        Me.Label7.Visible = False
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"CATEGORY", "ITEM NAME"})
        Me.cmbsearch.Location = New System.Drawing.Point(198, 25)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(122, 21)
        Me.cmbsearch.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "SELECT TYPE OF SEARCH"
        '
        'txtcat
        '
        Me.txtcat.Location = New System.Drawing.Point(197, 52)
        Me.txtcat.Name = "txtcat"
        Me.txtcat.Size = New System.Drawing.Size(122, 20)
        Me.txtcat.TabIndex = 3
        Me.txtcat.Visible = False
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(42, 236)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(106, 29)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'dgvproduct
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproduct.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvproduct.Location = New System.Drawing.Point(347, 13)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.Size = New System.Drawing.Size(334, 213)
        Me.dgvproduct.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ENTER THE CATEGORY"
        Me.Label9.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(751, 484)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stocks"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btnexit1)
        Me.Panel3.Controls.Add(Me.btnupdate)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.dgvstock)
        Me.Panel3.Location = New System.Drawing.Point(17, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 444)
        Me.Panel3.TabIndex = 0
        '
        'btnexit1
        '
        Me.btnexit1.Location = New System.Drawing.Point(472, 370)
        Me.btnexit1.Name = "btnexit1"
        Me.btnexit1.Size = New System.Drawing.Size(67, 23)
        Me.btnexit1.TabIndex = 3
        Me.btnexit1.Text = "EXIT"
        Me.btnexit1.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(185, 370)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(309, 370)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'dgvstock
        '
        Me.dgvstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvstock.BackgroundColor = System.Drawing.Color.White
        Me.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstock.Location = New System.Drawing.Point(23, 26)
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.Size = New System.Drawing.Size(677, 311)
        Me.dgvstock.TabIndex = 0
        '
        'frmproducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmproducts"
        Me.Text = "frmproducts"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbcname As System.Windows.Forms.ComboBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents txtcatid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmbmesure As System.Windows.Forms.ComboBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents lblper As System.Windows.Forms.Label
    Friend WithEvents lstcatname As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridView
    Friend WithEvents txtsprice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstiname As System.Windows.Forms.ListBox
    Friend WithEvents lstcategory As System.Windows.Forms.ListBox
    Friend WithEvents txtiname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcat As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents dgvproduct As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnexit1 As System.Windows.Forms.Button
End Class
