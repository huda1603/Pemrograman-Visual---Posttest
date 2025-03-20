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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtJudulBuku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtJudulBuku2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listBuku = New System.Windows.Forms.ListBox()
        Me.s = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtGenre)
        Me.GroupBox1.Controls.Add(Me.txtJudulBuku)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Buku"
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTambah.Location = New System.Drawing.Point(109, 86)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(77, 24)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtGenre
        '
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenre.Location = New System.Drawing.Point(77, 57)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(109, 20)
        Me.txtGenre.TabIndex = 3
        '
        'txtJudulBuku
        '
        Me.txtJudulBuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudulBuku.Location = New System.Drawing.Point(77, 27)
        Me.txtJudulBuku.Name = "txtJudulBuku"
        Me.txtJudulBuku.Size = New System.Drawing.Size(109, 20)
        Me.txtJudulBuku.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul Buku"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.txtJudulBuku2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 116)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hapus Buku"
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHapus.Location = New System.Drawing.Point(109, 86)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(77, 24)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtJudulBuku2
        '
        Me.txtJudulBuku2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudulBuku2.Location = New System.Drawing.Point(77, 27)
        Me.txtJudulBuku2.Name = "txtJudulBuku2"
        Me.txtJudulBuku2.Size = New System.Drawing.Size(109, 20)
        Me.txtJudulBuku2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Judul Buku"
        '
        'listBuku
        '
        Me.listBuku.FormattingEnabled = True
        Me.listBuku.Location = New System.Drawing.Point(88, 178)
        Me.listBuku.Name = "listBuku"
        Me.listBuku.Size = New System.Drawing.Size(410, 160)
        Me.listBuku.TabIndex = 6
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.Location = New System.Drawing.Point(633, 56)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(37, 13)
        Me.s.TabIndex = 7
        Me.s.Text = "Status"
        '
        'status
        '
        Me.status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.status.Location = New System.Drawing.Point(525, 79)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(251, 13)
        Me.status.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.listBuku)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudulBuku2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents listBuku As ListBox
    Friend WithEvents s As Label
    Friend WithEvents status As TextBox
End Class