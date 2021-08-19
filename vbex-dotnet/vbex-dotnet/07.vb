Public Class 07

    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        If cmbyear.SelectedItem = "1st Year" Then
            lbltuition.Text = txtunits.Text * 200
        End If
        If cmbyear.SelectedItem = "2nd Year" Then
            lbltuition.Text = txtunits.Text * 210
        End If
        If cmbyear.SelectedItem = "3rd Year" Then
            lbltuition.Text = txtunits.Text * 220
        End If
        If cmbyear.SelectedItem = "4th Year" Then
            lbltuition.Text = txtunits.Text * 230
        End If
    End Sub
End Class