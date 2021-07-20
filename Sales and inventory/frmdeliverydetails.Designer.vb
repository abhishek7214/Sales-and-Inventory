<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdeliverydetails
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
        Me.dgvdelivery = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpdeliver = New System.Windows.Forms.DateTimePicker
        Me.btndelivered = New System.Windows.Forms.Button
        CType(Me.dgvdelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdelivery
        '
        Me.dgvdelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdelivery.Location = New System.Drawing.Point(19, 58)
        Me.dgvdelivery.Name = "dgvdelivery"
        Me.dgvdelivery.Size = New System.Drawing.Size(573, 217)
        Me.dgvdelivery.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECT THE DATE"
        '
        'dtpdeliver
        '
        Me.dtpdeliver.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdeliver.Location = New System.Drawing.Point(185, 21)
        Me.dtpdeliver.Name = "dtpdeliver"
        Me.dtpdeliver.Size = New System.Drawing.Size(200, 20)
        Me.dtpdeliver.TabIndex = 2
        '
        'btndelivered
        '
        Me.btndelivered.Location = New System.Drawing.Point(184, 306)
        Me.btndelivered.Name = "btndelivered"
        Me.btndelivered.Size = New System.Drawing.Size(117, 23)
        Me.btndelivered.TabIndex = 3
        Me.btndelivered.Text = "DELIVERED"
        Me.btndelivered.UseVisualStyleBackColor = True
        '
        'frmdeliverydetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 361)
        Me.Controls.Add(Me.btndelivered)
        Me.Controls.Add(Me.dtpdeliver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdelivery)
        Me.Name = "frmdeliverydetails"
        Me.Text = "frmdeliverydetails"
        CType(Me.dgvdelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdelivery As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdeliver As System.Windows.Forms.DateTimePicker
    Friend WithEvents btndelivered As System.Windows.Forms.Button
End Class
