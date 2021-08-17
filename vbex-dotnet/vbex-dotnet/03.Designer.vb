<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 03
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
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtno = New System.Windows.Forms.TextBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.lisdisplay = New System.Windows.Forms.ListBox
        Me.btndowhile = New System.Windows.Forms.Button
        Me.btndountil = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type Your Name :"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(165, 22)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(193, 20)
        Me.txtname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Viner Hand ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Times :"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(165, 59)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(94, 20)
        Me.txtno.TabIndex = 3
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(97, 206)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(176, 23)
        Me.btnprint.TabIndex = 5
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'lisdisplay
        '
        Me.lisdisplay.FormattingEnabled = True
        Me.lisdisplay.Location = New System.Drawing.Point(44, 94)
        Me.lisdisplay.Name = "lisdisplay"
        Me.lisdisplay.Size = New System.Drawing.Size(276, 108)
        Me.lisdisplay.TabIndex = 6
        '
        'btndowhile
        '
        Me.btndowhile.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndowhile.Location = New System.Drawing.Point(79, 244)
        Me.btndowhile.Name = "btndowhile"
        Me.btndowhile.Size = New System.Drawing.Size(210, 23)
        Me.btndowhile.TabIndex = 7
        Me.btndowhile.Text = "-Print Name in Do while Form-"
        Me.btndowhile.UseVisualStyleBackColor = True
        '
        'btndountil
        '
        Me.btndountil.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndountil.Location = New System.Drawing.Point(79, 273)
        Me.btndountil.Name = "btndountil"
        Me.btndountil.Size = New System.Drawing.Size(210, 23)
        Me.btndountil.TabIndex = 8
        Me.btndountil.Text = "-Print Name in Do Until Form-"
        Me.btndountil.UseVisualStyleBackColor = True
        '
        'Print_name
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 308)
        Me.Controls.Add(Me.btndountil)
        Me.Controls.Add(Me.btndowhile)
        Me.Controls.Add(Me.lisdisplay)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Print_name"
        Me.Text = "Print_name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents lisdisplay As System.Windows.Forms.ListBox
    Friend WithEvents btndowhile As System.Windows.Forms.Button
    Friend WithEvents btndountil As System.Windows.Forms.Button
End Class
