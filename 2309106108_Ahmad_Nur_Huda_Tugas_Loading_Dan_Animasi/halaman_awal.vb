Public Class halaman_awal
    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        lblKet.Text = "Loading... Silahkan Tunggu"
        lblKet.Left = (Me.Width - lblKet.Width) / 2
        Panel1.Controls.Clear()
        Dim loading As New loading()
        Panel1.Controls.Add(loading)
        loading.Show()
    End Sub
End Class