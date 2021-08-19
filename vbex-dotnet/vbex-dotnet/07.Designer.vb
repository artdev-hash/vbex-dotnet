<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 07
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
        Me.lbltuition = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btncompute = New System.Windows.Forms.Button
        Me.txtunits = New System.Windows.Forms.TextBox
        Me.cmbyear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbltuition
        '
        Me.lbltuition.AutoSize = True
        Me.lbltuition.BackColor = System.Drawing.Color.White
        Me.lbltuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltuition.Location = New System.Drawing.Point(134, 82)
        Me.lbltuition.Name = "lbltuition"
        Me.lbltuition.Size = New System.Drawing.Size(12, 15)
        Me.lbltuition.TabIndex = 13
        Me.lbltuition.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tuition Fee :"
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(61, 109)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(148, 23)
        Me.btncompute.TabIndex = 11
        Me.btncompute.Text = "-=Compute Tuition Fee=-"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'txtunits
        '
        Me.txtunits.Location = New System.Drawing.Point(134, 12)
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(121, 20)
        Me.txtunits.TabIndex = 10
        '
        'cmbyear
        '
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbyear.Location = New System.Drawing.Point(134, 42)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(121, 21)
        Me.cmbyear.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Choose Yr. Level:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter  Number of Units:"
        '
        'Student_Fee1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(267, 143)
        Me.Controls.Add(Me.lbltuition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.txtunits)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student_Fee1"
        Me.Text = "Student_Fee1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltuition As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents txtunits As System.Windows.Forms.TextBox
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
