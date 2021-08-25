Public Class 09

    Private Sub btnpnumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnumber.Click
        Dim MyNum(4) As String
        Dim Mycount As Integer
        MyNum(0) = "This"
        MyNum(1) = "Is"
        MyNum(2) = "An Array"
        MyNum(3) = "String"
        MyNum(4) = "!"

        For Mycount = 0 To 4
            lisdisplay.Items.Add(MyNum(Mycount))
        Next Mycount
    End Sub
End Class