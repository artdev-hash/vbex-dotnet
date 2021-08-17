Public Class 04

    
    Private Sub btnmessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmessage.Click
        Dim Age As Integer
        Age = txtage.Text
        Select Case (Age)
            Case 10 To 16
                MsgBox("You are too young to fall in love")
            Case 17 To 40
                MsgBox("You are ready to fall in love")
        End Select


    End Sub
End Class