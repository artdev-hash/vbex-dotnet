Public Class Form1

    Private Sub btntransfer_Click(sender As System.Object, e As System.EventArgs) Handles btntransfer.Click
        Dim strname As String
        strname = txtlast.Text + ", " + txtfirst.Text + " " + txtmi.Text
        lblname.Text = strname
    End Sub
End Class
