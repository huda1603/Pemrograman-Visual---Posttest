Imports System.Text.RegularExpressions

Public Class Form1

    Function cekAngka(nama As String) As Boolean
        Dim angka As Integer
        For Each s As Char In nama
            If Char.IsDigit(s) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            Dim InputTextBox() As String = {txtNama.Text, txtUmur.Text, txtNomor.Text, txtAlamat.Text}
            For i As Integer = 0 To InputTextBox.Length - 1
                If String.IsNullOrEmpty(InputTextBox(i)) Then
                    Throw New FormatException("Nama/Umur/No Telepon/Alamat Tidak Boleh Kosong")
                End If
            Next

            If txtTglLahir.Value = DateTime.Now.Date Or txtTglLahir.Value > DateTime.Now.Date Then
                Throw New FormatException("Tanggal Lahir Harus Valid Dan Tidak Boleh Kosong")
            End If

            If Not (rbLaki.Checked Or rbPerempuan.Checked) Then
                Throw New FormatException("Mohon Pilih Salah Satu Jenis Kelamin")
            End If

            If Not (cbBaca.Checked Or cbFoto.Checked Or cbLukis.Checked Or cbMasak.Checked Or cbNari.Checked Or cbNgoding.Checked Or cbNonton.Checked Or cbNulis.Checked Or cbNyanyi.Checked Or cbOlahraga.Checked Or cbPetualang.Checked Or cbVideo.Checked) Then
                Throw New FormatException("Mohon Pilih Salah Satu Atau Lebih Hobi")
            End If

            If PictureBox1.Image Is Nothing Then
                Throw New FormatException("Mohon Masukkan Gambar Anda")
            End If

            Dim pattern As String = "^[A-Za-z\s]+$"
            Dim regex As New Regex(pattern)
            If Not regex.IsMatch(txtNama.Text) Or cekAngka(txtNama.Text) Then
                Throw New FormatException("Nama Harus Mengandung Huruf Tidak Boleh Ada Yang Mengandung Angka/Simbol")
            End If

            Dim angkaInput() As String = {txtUmur.Text, txtNomor.Text}
            For i As Integer = 0 To angkaInput.Length - 1
                If Not IsNumeric(angkaInput(i)) Then
                    Throw New FormatException("Umur Atau No Telepon Harus Berupa Angka Bukan Huruf/Simbol")
                End If
            Next
        Catch ex As FormatException
            MessageBox.Show(ex.Message)
            Return
        End Try

        Form2.lblNama.Text = "Nama: " + txtNama.Text
        Form2.lblUmur.Text = "Umur: " + txtUmur.Text
        Form2.lblTglLahir.Text = "Tgl Lahir: " + txtTglLahir.Value.ToString("dddd MMMM yyyy")
        Form2.lblNomor.Text = "No Telepon: " + txtNomor.Text
        Form2.lblAlamat.Text = "Alamat: " + txtAlamat.Text

        If rbLaki.Checked Then
            Form2.lblJenkel.Text = "Jenis Kelamin: Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            Form2.lblJenkel.Text = "Jenis Kelamin: Perempuan"
        End If
        Dim cbHobiBool() As Boolean = {cbBaca.Checked, cbFoto.Checked, cbLukis.Checked, cbMasak.Checked, cbNari.Checked, cbNgoding.Checked, cbNonton.Checked, cbNulis.Checked, cbNyanyi.Checked, cbOlahraga.Checked, cbPetualang.Checked, cbVideo.Checked}
        Dim cbHobiStr() As String = {cbBaca.Text, cbFoto.Text, cbLukis.Text, cbMasak.Text, cbNari.Text, cbNgoding.Text, cbNonton.Text, cbNulis.Text, cbNyanyi.Text, cbOlahraga.Text, cbPetualang.Text, cbVideo.Text}
        Dim listHobi As New List(Of String)
        Dim lbHobi As String = ""
        For i As Integer = 0 To 11
            If cbHobiBool(i) = True Then
                listHobi.Add(cbHobiStr(i))
            End If
        Next
        For i As Integer = 0 To listHobi.Count - 1
            If i < listHobi.Count - 1 Then
                lbHobi = lbHobi + listHobi(i) + ", "
            Else
                lbHobi = lbHobi + listHobi(i)
            End If
        Next
        Form2.lblHobi.Text = "Hobi: " + lbHobi
        Form2.PictureBox1.ImageLocation = BukaFile.FileName

        Form2.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BukaFile.Filter = "PNG Image|*.png|JPG Image|*.jpg"
        If BukaFile.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = BukaFile.FileName
        End If
    End Sub
End Class
