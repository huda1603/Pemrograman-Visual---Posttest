Public Class Form3
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim f2 As New Form2()
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username dan Password tidak boleh kosong.")
            Return
        End If

        If users.ContainsKey(username) Then
            MessageBox.Show("Username sudah terdaftar.")
        Else
            users.Add(username, password)
            MessageBox.Show("Registrasi berhasil. Silakan login.")
            Dim f2 As New Form2()
            f2.Show()
            Me.Hide()
        End If
    End Sub
End Class