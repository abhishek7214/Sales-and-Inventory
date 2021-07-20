<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpurchase
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblorder = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblin = New System.Windows.Forms.Label
        Me.lblmesure = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtmesure = New System.Windows.Forms.TextBox
        Me.txtpno = New System.Windows.Forms.TextBox
        Me.dtpddate = New System.Windows.Forms.DateTimePicker
        Me.dtpodate = New System.Windows.Forms.DateTimePicker
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.txtono = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstsearch = New System.Windows.Forms.ListBox
        Me.cmbcat = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btntotal = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.lblorder)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblin)
        Me.Panel1.Controls.Add(Me.lblmesure)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtmesure)
        Me.Panel1.Controls.Add(Me.txtpno)
        Me.Panel1.Controls.Add(Me.dtpddate)
        Me.Panel1.Controls.Add(Me.dtpodate)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.txtpname)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.txtcname)
        Me.Panel1.Controls.Add(Me.txtono)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 420)
        Me.Panel1.TabIndex = 0
        '
        'lblorder
        '
        Me.lblorder.AutoSize = True
        Me.lblorder.Location = New System.Drawing.Point(309, 297)
        Me.lblorder.Name = "lblorder"
        Me.lblorder.Size = New System.Drawing.Size(117, 13)
        Me.lblorder.TabIndex = 23
        Me.lblorder.Text = "PRODUCT ORDERED"
        Me.lblorder.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(306, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "NO STOCK"
        Me.Label13.Visible = False
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.ForeColor = System.Drawing.Color.Red
        Me.lblin.Location = New System.Drawing.Point(306, 280)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(119, 13)
        Me.lblin.TabIndex = 21
        Me.lblin.Text = "INSUFFICIENT STOCK"
        Me.lblin.Visible = False
        '
        'lblmesure
        '
        Me.lblmesure.AutoSize = True
        Me.lblmesure.Location = New System.Drawing.Point(271, 298)
        Me.lblmesure.Name = "lblmesure"
        Me.lblmesure.Size = New System.Drawing.Size(0, 13)
        Me.lblmesure.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(274, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "PER"
        '
        'txtmesure
        '
        Me.txtmesure.Location = New System.Drawing.Point(309, 242)
        Me.txtmesure.Name = "txtmesure"
        Me.txtmesure.Size = New System.Drawing.Size(68, 20)
        Me.txtmesure.TabIndex = 18
        '
        'txtpno
        '
        Me.txtpno.Location = New System.Drawing.Point(180, 163)
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(198, 20)
        Me.txtpno.TabIndex = 17
        '
        'dtpddate
        '
        Me.dtpddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpddate.Location = New System.Drawing.Point(178, 382)
        Me.dtpddate.Name = "dtpddate"
        Me.dtpddate.Size = New System.Drawing.Size(200, 20)
        Me.dtpddate.TabIndex = 16
        '
        'dtpodate
        '
        Me.dtpodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpodate.Location = New System.Drawing.Point(178, 344)
        Me.dtpodate.Name = "dtpodate"
        Me.dtpodate.Size = New System.Drawing.Size(200, 20)
        Me.dtpodate.TabIndex = 15
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(179, 294)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(89, 20)
        Me.txtqty.TabIndex = 14
        '
        'txtprice
        '
        Me.txtprice.Enabled = False
        Me.txtprice.Location = New System.Drawing.Point(180, 243)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(88, 20)
        Me.txtprice.TabIndex = 13
        '
        'txtpname
        '
        Me.txtpname.Enabled = False
        Me.txtpname.Location = New System.Drawing.Point(180, 201)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(198, 20)
        Me.txtpname.TabIndex = 12
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(180, 110)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(198, 20)
        Me.txtadd.TabIndex = 11
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(180, 58)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(198, 20)
        Me.txtcname.TabIndex = 10
        '
        'txtono
        '
        Me.txtono.Enabled = False
        Me.txtono.Location = New System.Drawing.Point(179, 17)
        Me.txtono.Name = "txtono"
        Me.txtono.Size = New System.Drawing.Size(199, 20)
        Me.txtono.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DELIVERY DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ORDER DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PRODUCT NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PHONE NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER NO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.lstsearch)
        Me.Panel2.Controls.Add(Me.cmbcat)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(503, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 217)
        Me.Panel2.TabIndex = 1
        '
        'lstsearch
        '
        Me.lstsearch.FormattingEnabled = True
        Me.lstsearch.Location = New System.Drawing.Point(124, 77)
        Me.lstsearch.Name = "lstsearch"
        Me.lstsearch.Size = New System.Drawing.Size(120, 95)
        Me.lstsearch.TabIndex = 3
        Me.lstsearch.Visible = False
        '
        'cmbcat
        '
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Location = New System.Drawing.Point(124, 31)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(97, 21)
        Me.cmbcat.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CATEGORY"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.btntotal)
        Me.Panel3.Controls.Add(Me.btnexit)
        Me.Panel3.Controls.Add(Me.btnsubmit)
        Me.Panel3.Controls.Add(Me.btnnew)
        Me.Panel3.Location = New System.Drawing.Point(503, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 139)
        Me.Panel3.TabIndex = 2
        '
        'btntotal
        '
        Me.btntotal.Location = New System.Drawing.Point(126, 104)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(75, 23)
        Me.btntotal.TabIndex = 3
        Me.btntotal.Text = "TOTAL"
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(208, 52)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(103, 52)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 1
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(3, 52)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'frmpurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(835, 452)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmpurchase"
        Me.Text = "CUSTOMER ORDER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents txtono As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents dtpddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstsearch As System.Windows.Forms.ListBox
    Friend WithEvents cmbcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btntotal As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtmesure As System.Windows.Forms.TextBox
    Friend WithEvents lblmesure As System.Windows.Forms.Label
    Friend WithEvents lblin As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblorder As System.Windows.Forms.Label
End Class
