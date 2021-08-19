Public Class 05

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim intname As Integer
        intname = txtrpay.Text * txtdw.Text
        lblGP.Text = intname


    End Sub

    Private Sub lblGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGP.Click
        Dim intname As Integer
        intname = txtrpay.Text * txtdw.Text
        lblGP.Text = intname



    End Sub
End Class