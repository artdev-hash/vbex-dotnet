<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 08
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lisdisplay = New System.Windows.Forms.ListBox
        Me.btnpnumber = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lisdisplay
        '
        Me.lisdisplay.FormattingEnabled = True
        Me.lisdisplay.Location = New System.Drawing.Point(31, 41)
        Me.lisdisplay.Name = "lisdisplay"
        Me.lisdisplay.Size = New System.Drawing.Size(220, 160)
        Me.lisdisplay.TabIndex = 0
        '
        'btnpnumber
        '
        Me.btnpnumber.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpnumber.Location = New System.Drawing.Point(31, 222)
        Me.btnpnumber.Name = "btnpnumber"
        Me.btnpnumber.Size = New System.Drawing.Size(220, 23)
        Me.btnpnumber.TabIndex = 1
        Me.btnpnumber.Text = "-==Print Numbers==-"
        Me.btnpnumber.UseVisualStyleBackColor = True
        '
        'Array_numbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 262)
        Me.Controls.Add(Me.btnpnumber)
        Me.Controls.Add(Me.lisdisplay)
        Me.Name = "Array_numbers"
        Me.Text = "Array_numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lisdisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnpnumber As System.Windows.Forms.Button
End Class
