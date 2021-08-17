<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 04
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.btnmessage = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Age:"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(124, 25)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(123, 22)
        Me.txtage.TabIndex = 1
        '
        'btnmessage
        '
        Me.btnmessage.Font = New System.Drawing.Font("Viner Hand ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmessage.Location = New System.Drawing.Point(32, 68)
        Me.btnmessage.Name = "btnmessage"
        Me.btnmessage.Size = New System.Drawing.Size(215, 23)
        Me.btnmessage.TabIndex = 2
        Me.btnmessage.Text = "--==ShOw MeSsEGe==-"
        Me.btnmessage.UseVisualStyleBackColor = True
        '
        'Age_Range
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(271, 112)
        Me.Controls.Add(Me.btnmessage)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Age_Range"
        Me.Text = "Age_Range"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents btnmessage As System.Windows.Forms.Button
End Class
