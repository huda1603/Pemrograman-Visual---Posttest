Public Class loading
    Dim d As New Dictionary(Of String, Button)
    Dim putaran As Integer = 1
    Dim lap As Integer = 1

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each b As Button In {b1, b2, b3, b4, b5, b6, b7, b8}
            b.Image = My.Resources.dry_clean
            d.Add(b.Tag, b)
        Next
        Timer1.Interval = 80
        Timer1.Start()
    End Sub

    Private Sub Loads()
        d(putaran.ToString()).Image = My.Resources.record
        If putaran > 1 Then
            d((putaran - 1).ToString()).Image = My.Resources.dry_clean
        Else
            d("8").Image = My.Resources.dry_clean
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If putaran <= 8 Then
            Loads()
            putaran += 1
            If putaran.Equals(9) Then
                lap += 1
                putaran = 1
            End If
            If lap.Equals(6) Then
                For Each b As Button In {b1, b2, b3, b4, b5, b6, b7, b8}
                    b.Image = My.Resources.dry_clean
                Next
                Timer1.Stop()
                Dim f1 As New Form1()
                f1.Show()
                Dim parent As Form = Me.FindForm()
                If TypeOf parent Is halaman_awal Then
                    parent.Hide()
                End If
            End If
        End If

    End Sub
End Class