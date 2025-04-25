Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form2
    Private Sub btnBuat_Click(sender As Object, e As EventArgs) Handles btnBuat.Click
        Dim f3 As New Form3()
        f3.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If akunUser.ContainsKey(username) AndAlso akunUser(username) = password Then
            currentUser = username
            MessageBox.Show("Login berhasil")
            Dim f1 As New Form1()
            f1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username Atau Password salah.")
        End If
    End Sub
End Class