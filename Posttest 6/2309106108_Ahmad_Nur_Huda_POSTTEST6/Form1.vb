Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadForm()
    End Sub

    Sub loadForm()
        DataGridView1.Rows.Clear()
        For Each kv As KeyValuePair(Of String, List(Of String)) In dataFilms
            Dim kvVal As List(Of String) = kv.Value
            If currentUser.Equals(kvVal(kvVal.Count - 1)) Then
                DataGridView1.Rows.Add(kvVal(0), kvVal(1), kvVal(2), kvVal(3))
            End If
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

    Function cekJudulFilm(textJudul As String) As Boolean
        If dataFilms.ContainsKey(textJudul) Then
            Return True
        End If
        Return False
    End Function

    Sub cekError()
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
    End Sub

    Function cariIndeksBaris(textJudul) As Integer
        Dim indeks As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If textJudul.Equals(DataGridView1.Rows(i).Cells("Nama_Film").Value) Then
                indeks = i
                Exit For
            End If
        Next
        Return indeks
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        cekError()
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
            Dim valuesFilm() As String = {txtJudul.Text, lbGenre, tglRilis.Value.ToString("dd MMMM yyyy"), listRate(indeksRate).Text, currentUser}
            DataGridView1.Rows.Add(valuesFilm(0), valuesFilm(1), valuesFilm(2), valuesFilm(3))

            dataFilms(txtJudul.Text) = New List(Of String)
            For Each v As String In valuesFilm
                dataFilms(txtJudul.Text).Add(v)
            Next

            MessageBox.Show("Film berhasil ditambahkan")
            cls()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        Dim valuesFilm() As String = {txtJudul.Text, lbGenre, tglRilis.Value.ToString("dd MMMM yyyy"), listRate(indeksRate).Text, currentUser}
        If dataFilms.ContainsKey(txtJudul.Text) Then
            dataFilms(txtJudul.Text) = New List(Of String)
            For Each v As String In valuesFilm
                dataFilms(txtJudul.Text).Add(v)
            Next
            loadForm()
            MessageBox.Show("Berhasil Mengedit")
            cls()
        Else
            MessageBox.Show("Judul Tidak Ditemukan")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dataFilms.ContainsKey(txtJudul.Text) Then
            dataFilms.Remove(txtJudul.Text)
            Dim indeksRow As Integer = cariIndeksBaris(txtJudul.Text)
            DataGridView1.Rows.RemoveAt(indeksRow)
            MessageBox.Show("Berhasil Menghapus")
            cls()
        Else
            MessageBox.Show("Judul Tidak Ditemukan")
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