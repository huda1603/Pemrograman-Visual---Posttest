Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Clear()
        txtPassword.Clear()
        Panel2.Left = Me.Width
        Timers.Interval = 5
        Timers.Start()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text IsNot Nothing Or txtUsername.Text IsNot "" Then
            Dim f2 As New Form2()
            f2.lblNama.Text = txtUsername.Text
            f2.lblNama.Left = (f2.Panel1.Width - f2.lblNama.Width) / 2
            MessageBox.Show("Berhasil Login")
            f2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Timers_Tick(sender As Object, e As EventArgs) Handles Timers.Tick
        If Panel2.Left >= 18 Then
            Panel2.Left -= 12
        Else
            Panel2.Left = 18
            Timers.Stop()
        End If
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim halaman_awal As New halaman_awal()
        halaman_awal.Show()
        Me.Hide()
    End Sub
End Class
