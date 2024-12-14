Public Class Settings
    Public boxinstalllocation
    Public usingcustomlocation = False
    Dim truemax = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        boxinstalllocation = TextBox1.Text


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        usingcustomlocation = True
    End Sub
End Class