Public Class Form1
    Private Sub cmdRand_Click(sender As Object, e As EventArgs) Handles cmdRand.Click
        Dim intNum As Integer
        Dim randl As New System.Random
        intNum = randl.Next(10)
        lblNum.Text = intNum
    End Sub
End Class
