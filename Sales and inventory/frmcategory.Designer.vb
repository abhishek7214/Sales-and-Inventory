<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcategory
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
        Me.lstcategory = New System.Windows.Forms.ListBox
        Me.txtcatname = New System.Windows.Forms.TextBox
        Me.txtcatid = New System.Windows.Forms.TextBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.lblcname = New System.Windows.Forms.Label
        Me.lblcid = New System.Windows.Forms.Label
        Me.txtmname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtmname)
        Me.Panel1.Controls.Add(Me.lstcategory)
        Me.Panel1.Controls.Add(Me.txtcatname)
        Me.Panel1.Controls.Add(Me.txtcatid)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnnew)
        Me.Panel1.Controls.Add(Me.lblcname)
        Me.Panel1.Controls.Add(Me.lblcid)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 412)
        Me.Panel1.TabIndex = 0
        '
        'lstcategory
        '
        Me.lstcategory.FormattingEnabled = True
        Me.lstcategory.Location = New System.Drawing.Point(396, 21)
        Me.lstcategory.Name = "lstcategory"
        Me.lstcategory.Size = New System.Drawing.Size(120, 95)
        Me.lstcategory.TabIndex = 8
        '
        'txtcatname
        '
        Me.txtcatname.Location = New System.Drawing.Point(229, 71)
        Me.txtcatname.Name = "txtcatname"
        Me.txtcatname.Size = New System.Drawing.Size(89, 20)
        Me.txtcatname.TabIndex = 7
        '
        'txtcatid
        '
        Me.txtcatid.Enabled = False
        Me.txtcatid.Location = New System.Drawing.Point(229, 21)
        Me.txtcatid.Name = "txtcatid"
        Me.txtcatid.Size = New System.Drawing.Size(86, 20)
        Me.txtcatid.TabIndex = 6
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(269, 178)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(81, 26)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(180, 178)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(66, 26)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(94, 177)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(65, 27)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(23, 176)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(53, 28)
        Me.btnnew.TabIndex = 2
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'lblcname
        '
        Me.lblcname.AutoSize = True
        Me.lblcname.Location = New System.Drawing.Point(34, 71)
        Me.lblcname.Name = "lblcname"
        Me.lblcname.Size = New System.Drawing.Size(100, 13)
        Me.lblcname.TabIndex = 1
        Me.lblcname.Text = "CATEGORY NAME"
        '
        'lblcid
        '
        Me.lblcid.AutoSize = True
        Me.lblcid.Location = New System.Drawing.Point(34, 21)
        Me.lblcid.Name = "lblcid"
        Me.lblcid.Size = New System.Drawing.Size(80, 13)
        Me.lblcid.TabIndex = 0
        Me.lblcid.Text = "CATEGORY ID"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(229, 122)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(97, 20)
        Me.txtmname.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MEASURE NAME"
        '
        'frmcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmcategory"
        Me.Text = "frmcategory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents lblcname As System.Windows.Forms.Label
    Friend WithEvents lblcid As System.Windows.Forms.Label
    Friend WithEvents txtcatname As System.Windows.Forms.TextBox
    Friend WithEvents txtcatid As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents lstcategory As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
End Class
