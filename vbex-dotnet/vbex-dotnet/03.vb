Public Class 03
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        Dim num As Integer
        Dim times As Integer
        Dim name As String
        times = Val(txtno.Text)
        name = txtname.Text
        For num = 1 To times
            lisdisplay.Items.Add(name)
        Next num
    End Sub

    Private Sub btndowhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndowhile.Click
        Dim num As Integer = 1
        Dim times1 As Integer
        Dim name1 As String
        times1 = Val(txtno.Text)
        name1 = txtname.Text
        Do While num <= times1
            lisdisplay.Items.Add(name1)
            num = num + 1
        Loop
    End Sub

    Private Sub btndountil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndountil.Click
        Dim num As Integer = 0
        Dim times2 As Integer
        Dim name2 As String
        times2 = Val(txtno.Text)
        name2 = txtname.Text
        Do Until num >= times2
            num = num + 1
            lisdisplay.Items.Add(name2)
        Loop
    End Sub

    Private Sub Print_name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class