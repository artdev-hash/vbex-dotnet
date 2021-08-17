<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.btntransfer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(74, 141)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(17, 26)
        Me.lblname.TabIndex = 15
        Me.lblname.Text = " "
        '
        'btntransfer
        '
        Me.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btntransfer.Location = New System.Drawing.Point(74, 190)
        Me.btntransfer.Name = "btntransfer"
        Me.btntransfer.Size = New System.Drawing.Size(260, 23)
        Me.btntransfer.TabIndex = 14
        Me.btntransfer.Text = "CLICK THIS TO DISPLAY FULL NAME"
        Me.btntransfer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enter your Middle initial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Enter your First name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter your last name: "
        '
        'txtmi
        '
        Me.txtmi.Location = New System.Drawing.Point(182, 93)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(190, 20)
        Me.txtmi.TabIndex = 10
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(182, 66)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(190, 20)
        Me.txtfirst.TabIndex = 9
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(182, 39)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(190, 20)
        Me.txtlast.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(410, 252)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btntransfer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.txtlast)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  FULL NAME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btntransfer As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents txtfirst As System.Windows.Forms.TextBox
    Friend WithEvents txtlast As System.Windows.Forms.TextBox

End Class
