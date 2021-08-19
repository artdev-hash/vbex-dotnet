<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 05
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtename = New System.Windows.Forms.TextBox
        Me.txtrpay = New System.Windows.Forms.TextBox
        Me.txtdw = New System.Windows.Forms.TextBox
        Me.lblGP = New System.Windows.Forms.Label
        Me.btnEnter = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYROLL PERIOD : NOVEMBER 1 - 15 2008"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 11)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Employer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 11)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Rate per day:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 11)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Days worked:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 11)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gross Pay :"
        '
        'txtename
        '
        Me.txtename.Location = New System.Drawing.Point(203, 47)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(198, 20)
        Me.txtename.TabIndex = 5
        '
        'txtrpay
        '
        Me.txtrpay.Location = New System.Drawing.Point(203, 75)
        Me.txtrpay.Name = "txtrpay"
        Me.txtrpay.Size = New System.Drawing.Size(198, 20)
        Me.txtrpay.TabIndex = 6
        '
        'txtdw
        '
        Me.txtdw.Location = New System.Drawing.Point(203, 102)
        Me.txtdw.Name = "txtdw"
        Me.txtdw.Size = New System.Drawing.Size(198, 20)
        Me.txtdw.TabIndex = 7
        '
        'lblGP
        '
        Me.lblGP.AutoSize = True
        Me.lblGP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGP.Location = New System.Drawing.Point(203, 148)
        Me.lblGP.Name = "lblGP"
        Me.lblGP.Size = New System.Drawing.Size(12, 15)
        Me.lblGP.TabIndex = 8
        Me.lblGP.Text = " "
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(14, 180)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(188, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'exer1_calculategross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 237)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblGP)
        Me.Controls.Add(Me.txtdw)
        Me.Controls.Add(Me.txtrpay)
        Me.Controls.Add(Me.txtename)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "exer1_calculategross"
        Me.Text = "exer1_calculategross"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtename As System.Windows.Forms.TextBox
    Friend WithEvents txtrpay As System.Windows.Forms.TextBox
    Friend WithEvents txtdw As System.Windows.Forms.TextBox
    Friend WithEvents lblGP As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
End Class
