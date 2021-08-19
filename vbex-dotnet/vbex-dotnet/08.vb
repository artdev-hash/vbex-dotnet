Public Class 08

    Private Sub btnpnumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnumber.Click
        Dim MyNum(4) As Integer
        Dim Mycount As Integer
        MyNum(0) = 10
        MyNum(1) = 20
        MyNum(2) = 30
        MyNum(3) = 40
        MyNum(4) = 50

        For Mycount = 0 To 4
            lisdisplay.Items.Add(MyNum(Mycount))
        Next Mycount
    End Sub
End Class