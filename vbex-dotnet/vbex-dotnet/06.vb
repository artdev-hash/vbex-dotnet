Public Class 06

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        Dim Hamburger As Double = 49.0
        Dim CheeseBurger As Double = 57.0
        Dim Coke As Double = 19.0
        Dim Spaghetti As Double = 25.0
        Dim Chicken As Double = 38.0
        Dim Fries As Double = 24.0
        Dim change As Double
        Dim price As Double

        If cmbprice.SelectedItem = "VM1 - Hamburger & Coke" Then
            lblprice.Text = Hamburger + Coke
        End If
        If cmbprice.SelectedItem = "VM2 - CheeseBurger, Fries & Coke" Then
            lblprice.Text = CheeseBurger + Fries + Coke
        End If
        If cmbprice.SelectedItem = "VM3 - Spaghetti, Chicken & Coke" Then
            lblprice.Text = Spaghetti + Chicken + Coke
        End If

        txtamount.Text = Integer.Parse(txtamount.Text)
        price = lblprice.Text

        Select Case (price)
            Case 68.0
                change = txtamount.Text - price
                MsgBox("Total Price :" & 68.0 & vbCrLf & "Change :" & change)

            Case 100.0
                change = txtamount.Text - price
                MsgBox("Total Price :" & 100.0 & vbCrLf & "Change :" & change)

            Case 82.0
                change = txtamount.Text - price
                MsgBox("Total Price :" & 82.0 & vbCrLf & "Change :" & change)

        End Select
    End Sub
End Class