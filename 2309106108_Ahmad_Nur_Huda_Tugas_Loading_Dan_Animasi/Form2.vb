Public Class Form2
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim f1 As New Form1()
        f1.Show()
        Me.Hide()
    End Sub
End Class