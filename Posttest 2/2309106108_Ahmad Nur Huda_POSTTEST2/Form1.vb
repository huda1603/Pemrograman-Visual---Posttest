Module dataBuku
    Public bukuArr(2, 100) As String
    Public j_buku As Integer
End Module

Public Class Form1

    Private Sub cls()
        txtJudulBuku.Clear()
        txtJudulBuku2.Clear()
        txtGenre.Clear()
    End Sub

    Sub updateJumlahBuku(ByRef j As Integer, operasi As String)
        If operasi = "+" Then
            j += 1
        Else
            j -= 1
        End If
    End Sub

    Function cekJudulBuku(labelJudul As String) As Boolean
        For i As Integer = 0 To dataBuku.j_buku - 1
            If dataBuku.bukuArr(0, i) = labelJudul Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim cekJudul As Boolean
        cekJudul = cekJudulBuku(txtJudulBuku.Text)

        If cekJudul = True Then
            status.Text = "Judul " + txtJudulBuku.Text + " Sudah Dipake"
        Else
            dataBuku.bukuArr(0, dataBuku.j_buku) = txtJudulBuku.Text
            dataBuku.bukuArr(1, dataBuku.j_buku) = txtGenre.Text
            listBuku.Items.Add(dataBuku.bukuArr(0, dataBuku.j_buku) + " (" + dataBuku.bukuArr(1, dataBuku.j_buku) + ")")
            updateJumlahBuku(dataBuku.j_buku, "+")
            status.Text = "Berhasil Menambah"
        End If
        cls()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim cekJudul As Boolean
        Dim indeksBuku As Integer
        cekJudul = cekJudulBuku(txtJudulBuku2.Text)
        If cekJudul = True Then
            For i As Integer = 0 To dataBuku.j_buku - 1
                If dataBuku.bukuArr(0, i) = txtJudulBuku2.Text Then
                    indeksBuku = i
                    Exit For
                End If
            Next

            listBuku.Items.RemoveAt(indeksBuku)
            updateJumlahBuku(dataBuku.j_buku, "-")

            For i As Integer = indeksBuku To dataBuku.j_buku - 1
                dataBuku.bukuArr(0, i) = dataBuku.bukuArr(0, i + 1)
                dataBuku.bukuArr(1, i) = dataBuku.bukuArr(1, i + 1)
            Next

            status.Text = "Berhasil Menghapus"
        Else
            status.Text = "Ga Ada Judul " + txtJudulBuku2.Text + " Dalam List"
        End If
        cls()
    End Sub

    Private Sub listBuku_MouseClick(sender As Object, e As MouseEventArgs) Handles listBuku.MouseClick
        Dim bukuDipilih As String
        Dim pemisah As Integer
        If listBuku.SelectedIndex >= 0 Then
            bukuDipilih = listBuku.SelectedItem.ToString()
            pemisah = bukuDipilih.IndexOf("("c) - 1
            txtJudulBuku2.Text = bukuDipilih.Substring(0, pemisah)
        End If
    End Sub

End Class