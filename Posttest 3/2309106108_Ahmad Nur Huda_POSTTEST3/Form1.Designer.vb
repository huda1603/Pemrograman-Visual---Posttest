<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbFoto = New System.Windows.Forms.CheckBox()
        Me.cbNonton = New System.Windows.Forms.CheckBox()
        Me.cbNgoding = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbPetualang = New System.Windows.Forms.CheckBox()
        Me.cbVideo = New System.Windows.Forms.CheckBox()
        Me.cbMasak = New System.Windows.Forms.CheckBox()
        Me.cbNulis = New System.Windows.Forms.CheckBox()
        Me.cbBaca = New System.Windows.Forms.CheckBox()
        Me.cbNari = New System.Windows.Forms.CheckBox()
        Me.cbLukis = New System.Windows.Forms.CheckBox()
        Me.cbNyanyi = New System.Windows.Forms.CheckBox()
        Me.txtTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.status = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(77, 277)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(74, 31)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(221, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(221, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Umur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(221, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(221, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(221, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(314, 38)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(261, 21)
        Me.txtNama.TabIndex = 8
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(314, 160)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(261, 21)
        Me.txtAlamat.TabIndex = 10
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(314, 129)
        Me.txtNomor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(261, 21)
        Me.txtNomor.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPerempuan)
        Me.GroupBox1.Controls.Add(Me.rbLaki)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(215, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(143, 111)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(17, 63)
        Me.rbPerempuan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(79, 19)
        Me.rbPerempuan.TabIndex = 15
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbLaki.Location = New System.Drawing.Point(17, 37)
        Me.rbLaki.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(64, 19)
        Me.rbLaki.TabIndex = 14
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFoto)
        Me.GroupBox2.Controls.Add(Me.cbNonton)
        Me.GroupBox2.Controls.Add(Me.cbNgoding)
        Me.GroupBox2.Controls.Add(Me.cbOlahraga)
        Me.GroupBox2.Controls.Add(Me.cbPetualang)
        Me.GroupBox2.Controls.Add(Me.cbVideo)
        Me.GroupBox2.Controls.Add(Me.cbMasak)
        Me.GroupBox2.Controls.Add(Me.cbNulis)
        Me.GroupBox2.Controls.Add(Me.cbBaca)
        Me.GroupBox2.Controls.Add(Me.cbNari)
        Me.GroupBox2.Controls.Add(Me.cbLukis)
        Me.GroupBox2.Controls.Add(Me.cbNyanyi)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(362, 197)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(213, 212)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hobi"
        '
        'cbFoto
        '
        Me.cbFoto.AutoSize = True
        Me.cbFoto.Location = New System.Drawing.Point(112, 167)
        Me.cbFoto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbFoto.Name = "cbFoto"
        Me.cbFoto.Size = New System.Drawing.Size(67, 19)
        Me.cbFoto.TabIndex = 11
        Me.cbFoto.Text = "Fotografi"
        Me.cbFoto.UseVisualStyleBackColor = True
        '
        'cbNonton
        '
        Me.cbNonton.AutoSize = True
        Me.cbNonton.Location = New System.Drawing.Point(17, 167)
        Me.cbNonton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNonton.Name = "cbNonton"
        Me.cbNonton.Size = New System.Drawing.Size(73, 19)
        Me.cbNonton.TabIndex = 10
        Me.cbNonton.Text = "Menonton"
        Me.cbNonton.UseVisualStyleBackColor = True
        '
        'cbNgoding
        '
        Me.cbNgoding.AutoSize = True
        Me.cbNgoding.Location = New System.Drawing.Point(112, 141)
        Me.cbNgoding.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNgoding.Name = "cbNgoding"
        Me.cbNgoding.Size = New System.Drawing.Size(79, 19)
        Me.cbNgoding.TabIndex = 9
        Me.cbNgoding.Text = "Mengoding"
        Me.cbNgoding.UseVisualStyleBackColor = True
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Location = New System.Drawing.Point(17, 141)
        Me.cbOlahraga.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(69, 19)
        Me.cbOlahraga.TabIndex = 8
        Me.cbOlahraga.Text = "Olahraga"
        Me.cbOlahraga.UseVisualStyleBackColor = True
        '
        'cbPetualang
        '
        Me.cbPetualang.AutoSize = True
        Me.cbPetualang.Location = New System.Drawing.Point(112, 117)
        Me.cbPetualang.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbPetualang.Name = "cbPetualang"
        Me.cbPetualang.Size = New System.Drawing.Size(90, 19)
        Me.cbPetualang.TabIndex = 7
        Me.cbPetualang.Text = "Berpetualang"
        Me.cbPetualang.UseVisualStyleBackColor = True
        '
        'cbVideo
        '
        Me.cbVideo.AutoSize = True
        Me.cbVideo.Location = New System.Drawing.Point(17, 117)
        Me.cbVideo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbVideo.Name = "cbVideo"
        Me.cbVideo.Size = New System.Drawing.Size(75, 19)
        Me.cbVideo.TabIndex = 6
        Me.cbVideo.Text = "Videografi"
        Me.cbVideo.UseVisualStyleBackColor = True
        '
        'cbMasak
        '
        Me.cbMasak.AutoSize = True
        Me.cbMasak.Location = New System.Drawing.Point(112, 90)
        Me.cbMasak.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbMasak.Name = "cbMasak"
        Me.cbMasak.Size = New System.Drawing.Size(70, 19)
        Me.cbMasak.TabIndex = 5
        Me.cbMasak.Text = "Memasak"
        Me.cbMasak.UseVisualStyleBackColor = True
        '
        'cbNulis
        '
        Me.cbNulis.AutoSize = True
        Me.cbNulis.Location = New System.Drawing.Point(17, 90)
        Me.cbNulis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNulis.Name = "cbNulis"
        Me.cbNulis.Size = New System.Drawing.Size(63, 19)
        Me.cbNulis.TabIndex = 4
        Me.cbNulis.Text = "Menulis"
        Me.cbNulis.UseVisualStyleBackColor = True
        '
        'cbBaca
        '
        Me.cbBaca.AutoSize = True
        Me.cbBaca.Location = New System.Drawing.Point(112, 64)
        Me.cbBaca.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbBaca.Name = "cbBaca"
        Me.cbBaca.Size = New System.Drawing.Size(71, 19)
        Me.cbBaca.TabIndex = 3
        Me.cbBaca.Text = "Membaca"
        Me.cbBaca.UseVisualStyleBackColor = True
        '
        'cbNari
        '
        Me.cbNari.AutoSize = True
        Me.cbNari.Location = New System.Drawing.Point(17, 63)
        Me.cbNari.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNari.Name = "cbNari"
        Me.cbNari.Size = New System.Drawing.Size(59, 19)
        Me.cbNari.TabIndex = 2
        Me.cbNari.Text = "Menari"
        Me.cbNari.UseVisualStyleBackColor = True
        '
        'cbLukis
        '
        Me.cbLukis.AutoSize = True
        Me.cbLukis.Location = New System.Drawing.Point(112, 37)
        Me.cbLukis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbLukis.Name = "cbLukis"
        Me.cbLukis.Size = New System.Drawing.Size(62, 19)
        Me.cbLukis.TabIndex = 1
        Me.cbLukis.Text = "Melukis"
        Me.cbLukis.UseVisualStyleBackColor = True
        '
        'cbNyanyi
        '
        Me.cbNyanyi.AutoSize = True
        Me.cbNyanyi.Location = New System.Drawing.Point(17, 37)
        Me.cbNyanyi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNyanyi.Name = "cbNyanyi"
        Me.cbNyanyi.Size = New System.Drawing.Size(71, 19)
        Me.cbNyanyi.TabIndex = 0
        Me.cbNyanyi.Text = "Menyanyi"
        Me.cbNyanyi.UseVisualStyleBackColor = True
        '
        'txtTglLahir
        '
        Me.txtTglLahir.Location = New System.Drawing.Point(314, 98)
        Me.txtTglLahir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTglLahir.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtTglLahir.Name = "txtTglLahir"
        Me.txtTglLahir.Size = New System.Drawing.Size(261, 21)
        Me.txtTglLahir.TabIndex = 17
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Location = New System.Drawing.Point(21, 417)
        Me.btnCetak.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(554, 31)
        Me.btnCetak.TabIndex = 18
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(314, 68)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(261, 21)
        Me.txtUmur.TabIndex = 19
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.ForeColor = System.Drawing.Color.Gold
        Me.status.Location = New System.Drawing.Point(27, 394)
        Me.status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 15)
        Me.status.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(601, 460)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTglLahir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents txtTglLahir As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents cbNyanyi As CheckBox
    Friend WithEvents cbFoto As CheckBox
    Friend WithEvents cbNonton As CheckBox
    Friend WithEvents cbNgoding As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbPetualang As CheckBox
    Friend WithEvents cbVideo As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbNulis As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbNari As CheckBox
    Friend WithEvents cbLukis As CheckBox
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents status As Label
End Class
