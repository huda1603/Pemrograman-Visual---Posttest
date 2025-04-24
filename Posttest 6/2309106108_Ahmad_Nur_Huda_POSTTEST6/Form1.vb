Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentUser Is Nothing OrElse Not userFilmData.ContainsKey(currentUser) Then
            DataGridView1.Rows.Clear()
            Return
        End If

        DataGridView1.Rows.Clear()
        For Each filmData As String In userFilmData(currentUser)
            Dim filmValues() As String = filmData.Split("|"c)
            DataGridView1.Rows.Add(filmValues(0), filmValues(1), filmValues(2), filmValues(3))
        Next
    End Sub

    Sub cls()
        txtJudul.Clear()
        tglRilis.Value = Date.Now()
        For Each cb As CheckBox In {cbAdv, cbAct, cbDra, cbHor, cbKom, cbMis, cbMus, cbRom, cbSciFi, cbThr}
            cb.Checked = False
        Next
        For Each rb As RadioButton In {rb1, rb1_5, rb2, rb2_5, rb3, rb3_5, rb4, rb4_5, rb5}
            rb.Checked = False
        Next
    End Sub

    Sub updateJumlahFilm(ByRef j As Integer, operasi As String)
        If operasi = "+" Then
            j += 1
        Else
            j -= 1
        End If
    End Sub

    Function cekJudulFilm(textJudul As String) As Boolean
        For i As Integer = 0 To j_film - 1
            If dataFilms(0, i) = textJudul Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim InputTextBox() As String = {txtJudul.Text}
            For i As Integer = 0 To InputTextBox.Length - 1
                If String.IsNullOrEmpty(InputTextBox(i)) Then
                    Throw New FormatException("Judul Tidak Boleh Kosong")
                End If
            Next

            If Not (rb1.Checked Or rb1_5.Checked Or rb2.Checked Or rb2_5.Checked Or rb3.Checked Or rb3_5.Checked Or rb4.Checked Or rb4_5.Checked Or rb5.Checked) Then
                Throw New FormatException("Mohon Pilih Salah Satu Rating")
            End If

            If Not (cbAdv.Checked Or cbHor.Checked Or cbAct.Checked Or cbKom.Checked Or cbSciFi.Checked Or cbDra.Checked Or cbThr.Checked Or cbMis.Checked Or cbRom.Checked Or cbMus.Checked) Then
                Throw New FormatException("Mohon Pilih Salah Satu Atau Lebih Genre")
            End If

        Catch ex As FormatException
            MessageBox.Show(ex.Message)
            Return
        End Try

        If cekJudulFilm(txtJudul.Text) = True Then
            MessageBox.Show("Judul Sudah Ada Yang Pake")
        Else
            Dim cbGenre() As CheckBox = {cbAdv, cbHor, cbAct, cbKom, cbSciFi, cbDra, cbThr, cbMis, cbRom, cbMus}
            Dim listGenre As New List(Of String)
            Dim listGenreCb As New List(Of CheckBox)
            Dim lbGenre As String = ""
            For i As Integer = 0 To cbGenre.Length - 1
                If cbGenre(i).Checked = True Then
                    listGenre.Add(cbGenre(i).Text)
                    listGenreCb.Add(cbGenre(i))
                End If
            Next
            For i As Integer = 0 To listGenre.Count - 1
                If i < listGenre.Count - 1 Then
                    lbGenre = lbGenre + listGenre(i) + ", "
                Else
                    lbGenre = lbGenre + listGenre(i)
                End If
            Next
            Dim listRate() As RadioButton = {rb1, rb1_5, rb2, rb2_5, rb3, rb3_5, rb4, rb4_5, rb5}
            Dim indeksRate As Integer
            For i As Integer = 0 To listRate.Length - 1
                If listRate(i).Checked Then
                    indeksRate = i
                    Exit For
                End If
            Next
            Dim valuesFilm() As String = {txtJudul.Text, lbGenre, tglRilis.Value.ToString("dd MMMM yyyy"), listRate(indeksRate).Text}
            For i As Integer = 0 To 3
                dataFilms(i, j_film) = valuesFilm(i)
            Next
            DataGridView1.Rows.Add(valuesFilm(0), valuesFilm(1), valuesFilm(2), valuesFilm(3))

            If Not userFilmData.ContainsKey(currentUser) Then
                userFilmData(currentUser) = New List(Of String)
            End If

            Dim valueFilm As String = txtJudul.Text & "|" & lbGenre & "|" & tglRilis.Value.ToString("dd MMMM yyyy") & "|" & listRate(indeksRate).Text
            userFilmData(currentUser).Add(valueFilm)
            MessageBox.Show("Film berhasil ditambahkan")

            updateJumlahFilm(j_film, "+")
            cls()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim indeksDataFilm As Integer = -1
        For i As Integer = 0 To j_film - 1
            If dataFilms(0, i) = txtJudul.Text Then
                indeksDataFilm = i
                Exit For
            End If
        Next
        Dim cbGenre() As CheckBox = {cbAdv, cbHor, cbAct, cbKom, cbSciFi, cbDra, cbThr, cbMis, cbRom, cbMus}
        Dim listGenre As New List(Of String)
        Dim listGenreCb As New List(Of CheckBox)
        Dim lbGenre As String = ""
        For i As Integer = 0 To cbGenre.Length - 1
            If cbGenre(i).Checked = True Then
                listGenre.Add(cbGenre(i).Text)
                listGenreCb.Add(cbGenre(i))
            End If
        Next
        For i As Integer = 0 To listGenre.Count - 1
            If i < listGenre.Count - 1 Then
                lbGenre = lbGenre + listGenre(i) + ", "
            Else
                lbGenre = lbGenre + listGenre(i)
            End If
        Next
        Dim listRate() As RadioButton = {rb1, rb1_5, rb2, rb2_5, rb3, rb3_5, rb4, rb4_5, rb5}
        Dim indeksRate As Integer
        For i As Integer = 0 To listRate.Length - 1
            If listRate(i).Checked Then
                indeksRate = i
                Exit For
            End If
        Next
        Dim valuesFilm() As String = {txtJudul.Text, lbGenre, tglRilis.Value.ToString("dd MMMM yyyy"), listRate(indeksRate).Text}

        If indeksDataFilm = -1 Then
            For i As Integer = 0 To valuesFilm.Length - 1
                dataFilms(i, j_film) = valuesFilm(i)
            Next
            DataGridView1.Rows.Add(valuesFilm(0), valuesFilm(1), valuesFilm(2), valuesFilm(3))
            updateJumlahFilm(j_film, "+")
        Else
            Dim indeksDatagrid As Integer
            For i As Integer = 0 To j_film - 1
                If txtJudul.Text = DataGridView1.Rows(i).Cells("Nama_Film").Value.ToString() Then
                    indeksDatagrid = i
                    Exit For
                End If
            Next
            For i As Integer = 1 To valuesFilm.Length - 1
                dataFilms(i, indeksDataFilm) = valuesFilm(i)
                DataGridView1.Rows(indeksDataFilm).Cells(i).Value = valuesFilm(i)
            Next
        End If
        cls()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim indeksDataFilm As Integer = -1
        For i As Integer = 0 To j_film - 1
            If dataFilms(0, i) = txtJudul.Text Then
                indeksDataFilm = i
                Exit For
            End If
        Next
        If indeksDataFilm = -1 Then
            MessageBox.Show("Tidak Ditemukan Data")
        Else
            For i As Integer = indeksDataFilm + 1 To j_film
                If i = j_film Then
                    Exit For
                Else
                    dataFilms(0, i - 1) = dataFilms(0, i)
                    dataFilms(1, i - 1) = dataFilms(1, i)
                    dataFilms(2, i - 1) = dataFilms(2, i)
                    dataFilms(3, i - 1) = dataFilms(3, i)
                End If
            Next
            DataGridView1.Rows.RemoveAt(indeksDataFilm)
            updateJumlahFilm(j_film, "-")
            cls()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cls()
        If e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtJudul.Text = row.Cells("Nama_Film").Value.ToString()
            tglRilis.Value = Date.Parse(row.Cells("Tanggal_Rilis").Value.ToString())
            Dim listGenre() As String = row.Cells("Genre").Value.ToString().Split(New String() {", "}, StringSplitOptions.None)
            Dim cbGenre() As CheckBox = {cbAdv, cbHor, cbAct, cbKom, cbSciFi, cbDra, cbThr, cbMis, cbRom, cbMus}
            For Each cb As CheckBox In cbGenre
                For Each genre_str As String In listGenre
                    If cb.Text = genre_str Then
                        cb.Checked = True
                    End If
                Next
            Next
            Dim rate As String = row.Cells("Rating").Value.ToString()
            Dim rbRate() As RadioButton = {rb1, rb1_5, rb2, rb2_5, rb3, rb3_5, rb4, rb4_5, rb5}
            For Each rb As RadioButton In rbRate
                If rb.Text = rate Then
                    rb.Checked = True
                End If
            Next
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        currentUser = Nothing
        Dim f2 As New Form2()
        f2.Show()
        Me.Hide()
    End Sub
End Class