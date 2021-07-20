<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsorderview
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
        Me.dgvsoview = New System.Windows.Forms.DataGridView
        Me.btnrecived = New System.Windows.Forms.Button
        Me.btnrestore = New System.Windows.Forms.Button
        CType(Me.dgvsoview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsoview
        '
        Me.dgvsoview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsoview.Location = New System.Drawing.Point(24, 23)
        Me.dgvsoview.Name = "dgvsoview"
        Me.dgvsoview.Size = New System.Drawing.Size(439, 249)
        Me.dgvsoview.TabIndex = 0
        '
        'btnrecived
        '
        Me.btnrecived.Location = New System.Drawing.Point(94, 299)
        Me.btnrecived.Name = "btnrecived"
        Me.btnrecived.Size = New System.Drawing.Size(105, 38)
        Me.btnrecived.TabIndex = 1
        Me.btnrecived.Text = "RECEIVED"
        Me.btnrecived.UseVisualStyleBackColor = True
        '
        'btnrestore
        '
        Me.btnrestore.Enabled = False
        Me.btnrestore.Location = New System.Drawing.Point(205, 300)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(103, 37)
        Me.btnrestore.TabIndex = 2
        Me.btnrestore.Text = "RESTORE"
        Me.btnrestore.UseVisualStyleBackColor = True
        '
        'frmsorderview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 369)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnrecived)
        Me.Controls.Add(Me.dgvsoview)
        Me.Name = "frmsorderview"
        Me.Text = "frmsorderview"
        CType(Me.dgvsoview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvsoview As System.Windows.Forms.DataGridView
    Friend WithEvents btnrecived As System.Windows.Forms.Button
    Friend WithEvents btnrestore As System.Windows.Forms.Button
End Class
