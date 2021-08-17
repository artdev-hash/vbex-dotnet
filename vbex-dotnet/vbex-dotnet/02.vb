Public Class 02

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim num As Integer
        Dim times As Integer
        Dim name As String
        Dim columb As Integer
        times = Val(txtno.Text)
        name = txtname.Text
        columb = Val(txtcolumb.Text)
        Select Case (columb)
            Case 1
                For num = 1 To times
                    lisdisplay.Items.Add(name)
                Next num
            Case 2
                For num = 1 To times
                    lisdisplay.Items.Add(name)
                    lisdisplay1.Items.Add(name)
                Next num
            Case 3
                For num = 1 To times
                    lisdisplay.Items.Add(name)
                    lisdisplay1.Items.Add(name)
                    lisdisplay2.Items.Add(name)
                Next num
        End Select
    End Sub

    Private Sub btndowhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndowhile.Click
        Dim num As Integer = 1
        Dim times1 As Integer
        Dim name1 As String
        Dim columb As Integer
        times1 = Val(txtno.Text)
        name1 = txtname.Text
        columb = Val(txtcolumb.Text)
        Select Case (columb)
            Case 1
                Do While num <= times1
                    lisdisplay.Items.Add(name1)
                    num = num + 1
                Loop
            Case 2
                Do While num <= times1
                    lisdisplay.Items.Add(name1)
                    lisdisplay1.Items.Add(name1)
                    num = num + 1
                Loop
            Case 3
                Do While num <= times1
                    lisdisplay.Items.Add(name1)
                    lisdisplay1.Items.Add(name1)
                    lisdisplay2.Items.Add(name1)
                    num = num + 1
                Loop
        End Select
    End Sub

    Private Sub btndountil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndountil.Click
        Dim num As Integer = 0
        Dim times2 As Integer
        Dim name2 As String
        Dim columb As Integer
        times2 = Val(txtno.Text)
        name2 = txtname.Text
        columb = Val(txtcolumb.Text)
        Select Case (columb)
            Case 1
                Do Until num >= times2
                    num = num + 1
                    lisdisplay.Items.Add(name2)
                Loop
            Case 2
                Do Until num >= times2
                    num = num + 1
                    lisdisplay.Items.Add(Name)
                    lisdisplay1.Items.Add(name2)
                Loop
            Case 3
                Do Until num >= times2
                    num = num + 1
                    lisdisplay.Items.Add(name2)
                    lisdisplay1.Items.Add(name2)
                    lisdisplay2.Items.Add(name2)
                Loop
        End Select

    End Sub
End Class