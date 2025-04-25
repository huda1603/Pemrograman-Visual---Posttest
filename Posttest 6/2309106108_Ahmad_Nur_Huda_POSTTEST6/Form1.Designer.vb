<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nama_Film = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal_Rilis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tglRilis = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSciFi = New System.Windows.Forms.CheckBox()
        Me.cbRom = New System.Windows.Forms.CheckBox()
        Me.cbMus = New System.Windows.Forms.CheckBox()
        Me.cbMis = New System.Windows.Forms.CheckBox()
        Me.cbDra = New System.Windows.Forms.CheckBox()
        Me.cbThr = New System.Windows.Forms.CheckBox()
        Me.cbKom = New System.Windows.Forms.CheckBox()
        Me.cbAct = New System.Windows.Forms.CheckBox()
        Me.cbHor = New System.Windows.Forms.CheckBox()
        Me.cbAdv = New System.Windows.Forms.CheckBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4_5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3_5 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2_5 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1_5 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(230, 44)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(240, 20)
        Me.txtJudul.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nama_Film, Me.Genre, Me.Tanggal_Rilis, Me.Rating})
        Me.DataGridView1.Location = New System.Drawing.Point(151, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'Nama_Film
        '
        Me.Nama_Film.HeaderText = "Nama_Film"
        Me.Nama_Film.Name = "Nama_Film"
        '
        'Genre
        '
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        '
        'Tanggal_Rilis
        '
        Me.Tanggal_Rilis.HeaderText = "Tanggal_Rilis"
        Me.Tanggal_Rilis.Name = "Tanggal_Rilis"
        '
        'Rating
        '
        Me.Rating.HeaderText = "Rating"
        Me.Rating.Name = "Rating"
        '
        'btnTambah
        '
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(215, 413)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(84, 31)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(319, 413)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 31)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(425, 413)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(84, 31)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tanggal Rilis"
        '
        'tglRilis
        '
        Me.tglRilis.Location = New System.Drawing.Point(230, 75)
        Me.tglRilis.Name = "tglRilis"
        Me.tglRilis.Size = New System.Drawing.Size(240, 20)
        Me.tglRilis.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbSciFi)
        Me.GroupBox1.Controls.Add(Me.cbRom)
        Me.GroupBox1.Controls.Add(Me.cbMus)
        Me.GroupBox1.Controls.Add(Me.cbMis)
        Me.GroupBox1.Controls.Add(Me.cbDra)
        Me.GroupBox1.Controls.Add(Me.cbThr)
        Me.GroupBox1.Controls.Add(Me.cbKom)
        Me.GroupBox1.Controls.Add(Me.cbAct)
        Me.GroupBox1.Controls.Add(Me.cbHor)
        Me.GroupBox1.Controls.Add(Me.cbAdv)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 79)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genre"
        '
        'cbSciFi
        '
        Me.cbSciFi.AutoSize = True
        Me.cbSciFi.Location = New System.Drawing.Point(304, 51)
        Me.cbSciFi.Name = "cbSciFi"
        Me.cbSciFi.Size = New System.Drawing.Size(99, 17)
        Me.cbSciFi.TabIndex = 17
        Me.cbSciFi.Text = "Science Fiction"
        Me.cbSciFi.UseVisualStyleBackColor = True
        '
        'cbRom
        '
        Me.cbRom.AutoSize = True
        Me.cbRom.Location = New System.Drawing.Point(304, 28)
        Me.cbRom.Name = "cbRom"
        Me.cbRom.Size = New System.Drawing.Size(71, 17)
        Me.cbRom.TabIndex = 16
        Me.cbRom.Text = "Romantic"
        Me.cbRom.UseVisualStyleBackColor = True
        '
        'cbMus
        '
        Me.cbMus.AutoSize = True
        Me.cbMus.Location = New System.Drawing.Point(231, 51)
        Me.cbMus.Name = "cbMus"
        Me.cbMus.Size = New System.Drawing.Size(62, 17)
        Me.cbMus.TabIndex = 15
        Me.cbMus.Text = "Musical"
        Me.cbMus.UseVisualStyleBackColor = True
        '
        'cbMis
        '
        Me.cbMis.AutoSize = True
        Me.cbMis.Location = New System.Drawing.Point(231, 28)
        Me.cbMis.Name = "cbMis"
        Me.cbMis.Size = New System.Drawing.Size(59, 17)
        Me.cbMis.TabIndex = 14
        Me.cbMis.Text = "Mistery"
        Me.cbMis.UseVisualStyleBackColor = True
        '
        'cbDra
        '
        Me.cbDra.AutoSize = True
        Me.cbDra.Location = New System.Drawing.Point(159, 51)
        Me.cbDra.Name = "cbDra"
        Me.cbDra.Size = New System.Drawing.Size(57, 17)
        Me.cbDra.TabIndex = 13
        Me.cbDra.Text = "Drama"
        Me.cbDra.UseVisualStyleBackColor = True
        '
        'cbThr
        '
        Me.cbThr.AutoSize = True
        Me.cbThr.Location = New System.Drawing.Point(159, 28)
        Me.cbThr.Name = "cbThr"
        Me.cbThr.Size = New System.Drawing.Size(57, 17)
        Me.cbThr.TabIndex = 12
        Me.cbThr.Text = "Thriller"
        Me.cbThr.UseVisualStyleBackColor = True
        '
        'cbKom
        '
        Me.cbKom.AutoSize = True
        Me.cbKom.Location = New System.Drawing.Point(87, 51)
        Me.cbKom.Name = "cbKom"
        Me.cbKom.Size = New System.Drawing.Size(61, 17)
        Me.cbKom.TabIndex = 11
        Me.cbKom.Text = "Komedi"
        Me.cbKom.UseVisualStyleBackColor = True
        '
        'cbAct
        '
        Me.cbAct.AutoSize = True
        Me.cbAct.Location = New System.Drawing.Point(87, 28)
        Me.cbAct.Name = "cbAct"
        Me.cbAct.Size = New System.Drawing.Size(56, 17)
        Me.cbAct.TabIndex = 10
        Me.cbAct.Text = "Action"
        Me.cbAct.UseVisualStyleBackColor = True
        '
        'cbHor
        '
        Me.cbHor.AutoSize = True
        Me.cbHor.Location = New System.Drawing.Point(6, 51)
        Me.cbHor.Name = "cbHor"
        Me.cbHor.Size = New System.Drawing.Size(55, 17)
        Me.cbHor.TabIndex = 9
        Me.cbHor.Text = "Horror"
        Me.cbHor.UseVisualStyleBackColor = True
        '
        'cbAdv
        '
        Me.cbAdv.AutoSize = True
        Me.cbAdv.Location = New System.Drawing.Point(6, 28)
        Me.cbAdv.Name = "cbAdv"
        Me.cbAdv.Size = New System.Drawing.Size(75, 17)
        Me.cbAdv.TabIndex = 8
        Me.cbAdv.Text = "Adventure"
        Me.cbAdv.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 31)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(31, 17)
        Me.rb1.TabIndex = 9
        Me.rb1.TabStop = True
        Me.rb1.Text = "1"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb5)
        Me.GroupBox2.Controls.Add(Me.rb4_5)
        Me.GroupBox2.Controls.Add(Me.rb4)
        Me.GroupBox2.Controls.Add(Me.rb3_5)
        Me.GroupBox2.Controls.Add(Me.rb3)
        Me.GroupBox2.Controls.Add(Me.rb2_5)
        Me.GroupBox2.Controls.Add(Me.rb2)
        Me.GroupBox2.Controls.Add(Me.rb1_5)
        Me.GroupBox2.Controls.Add(Me.rb1)
        Me.GroupBox2.Location = New System.Drawing.Point(151, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 59)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rating"
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Location = New System.Drawing.Point(372, 31)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(31, 17)
        Me.rb5.TabIndex = 17
        Me.rb5.TabStop = True
        Me.rb5.Text = "5"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb4_5
        '
        Me.rb4_5.AutoSize = True
        Me.rb4_5.Location = New System.Drawing.Point(320, 31)
        Me.rb4_5.Name = "rb4_5"
        Me.rb4_5.Size = New System.Drawing.Size(40, 17)
        Me.rb4_5.TabIndex = 16
        Me.rb4_5.TabStop = True
        Me.rb4_5.Text = "4,5"
        Me.rb4_5.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Location = New System.Drawing.Point(276, 31)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(31, 17)
        Me.rb4.TabIndex = 15
        Me.rb4.TabStop = True
        Me.rb4.Text = "4"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3_5
        '
        Me.rb3_5.AutoSize = True
        Me.rb3_5.Location = New System.Drawing.Point(230, 31)
        Me.rb3_5.Name = "rb3_5"
        Me.rb3_5.Size = New System.Drawing.Size(40, 17)
        Me.rb3_5.TabIndex = 14
        Me.rb3_5.TabStop = True
        Me.rb3_5.Text = "3,5"
        Me.rb3_5.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(186, 31)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(31, 17)
        Me.rb3.TabIndex = 13
        Me.rb3.TabStop = True
        Me.rb3.Text = "3"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2_5
        '
        Me.rb2_5.AutoSize = True
        Me.rb2_5.Location = New System.Drawing.Point(140, 31)
        Me.rb2_5.Name = "rb2_5"
        Me.rb2_5.Size = New System.Drawing.Size(40, 17)
        Me.rb2_5.TabIndex = 12
        Me.rb2_5.TabStop = True
        Me.rb2_5.Text = "2,5"
        Me.rb2_5.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(96, 31)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(31, 17)
        Me.rb2.TabIndex = 11
        Me.rb2.TabStop = True
        Me.rb2.Text = "2"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1_5
        '
        Me.rb1_5.AutoSize = True
        Me.rb1_5.Location = New System.Drawing.Point(50, 31)
        Me.rb1_5.Name = "rb1_5"
        Me.rb1_5.Size = New System.Drawing.Size(40, 17)
        Me.rb1_5.TabIndex = 10
        Me.rb1_5.TabStop = True
        Me.rb1_5.Text = "1,5"
        Me.rb1_5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Judul"
        '
        'btnLogout
        '
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(530, 413)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 31)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tglRilis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtJudul)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJudul As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tglRilis As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbAdv As CheckBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbMus As CheckBox
    Friend WithEvents cbMis As CheckBox
    Friend WithEvents cbDra As CheckBox
    Friend WithEvents cbThr As CheckBox
    Friend WithEvents cbKom As CheckBox
    Friend WithEvents cbAct As CheckBox
    Friend WithEvents cbHor As CheckBox
    Friend WithEvents cbSciFi As CheckBox
    Friend WithEvents cbRom As CheckBox
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb4_5 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3_5 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2_5 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1_5 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Nama_Film As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal_Rilis As DataGridViewTextBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents btnLogout As Button
End Class
