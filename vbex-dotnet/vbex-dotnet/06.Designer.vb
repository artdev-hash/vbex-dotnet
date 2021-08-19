<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 06
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
        Me.cmbprice = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.btncompute = New System.Windows.Forms.Button
        Me.lblp = New System.Windows.Forms.Label
        Me.lblprice = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Value Meal:"
        '
        'cmbprice
        '
        Me.cmbprice.FormattingEnabled = True
        Me.cmbprice.Items.AddRange(New Object() {"VM1 - Hamburger & Coke", "VM2 - CheeseBurger, Fries & Coke", "VM3 - Spaghetti, Chicken & Coke"})
        Me.cmbprice.Location = New System.Drawing.Point(16, 57)
        Me.cmbprice.Name = "cmbprice"
        Me.cmbprice.Size = New System.Drawing.Size(279, 21)
        Me.cmbprice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount Of Payment:"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(195, 95)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(100, 20)
        Me.txtamount.TabIndex = 3
        '
        'btncompute
        '
        Me.btncompute.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompute.Location = New System.Drawing.Point(70, 178)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(171, 24)
        Me.btncompute.TabIndex = 4
        Me.btncompute.Text = "--= COMPUTE =--"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'lblp
        '
        Me.lblp.AutoSize = True
        Me.lblp.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp.Location = New System.Drawing.Point(16, 135)
        Me.lblp.Name = "lblp"
        Me.lblp.Size = New System.Drawing.Size(43, 14)
        Me.lblp.TabIndex = 5
        Me.lblp.Text = "price"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.White
        Me.lblprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprice.Location = New System.Drawing.Point(70, 135)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(12, 15)
        Me.lblprice.TabIndex = 6
        Me.lblprice.Text = " "
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(311, 227)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblp)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbprice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cashier"
        Me.Text = "Cashier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbprice As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents lblp As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
End Class
