<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class halaman_awal
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
        Me.lblKet = New System.Windows.Forms.Label()
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblKet
        '
        Me.lblKet.AutoSize = True
        Me.lblKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet.Location = New System.Drawing.Point(191, 131)
        Me.lblKet.Name = "lblKet"
        Me.lblKet.Size = New System.Drawing.Size(413, 24)
        Me.lblKet.TabIndex = 0
        Me.lblKet.Text = "TEKAN TOMBOL DIBAWAH UNTUK MULAI"
        '
        'btnMulai
        '
        Me.btnMulai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMulai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnMulai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulai.Location = New System.Drawing.Point(3, 3)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(115, 32)
        Me.btnMulai.TabIndex = 1
        Me.btnMulai.Text = "Mulai"
        Me.btnMulai.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnMulai)
        Me.Panel1.Location = New System.Drawing.Point(324, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 93)
        Me.Panel1.TabIndex = 2
        '
        'halaman_awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblKet)
        Me.Name = "halaman_awal"
        Me.Text = "halaman_awal"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKet As Label
    Friend WithEvents btnMulai As Button
    Friend WithEvents Panel1 As Panel
End Class
