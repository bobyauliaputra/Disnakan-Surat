<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulirKesimpulanDiagnosa
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbManajerTeknis = New System.Windows.Forms.ComboBox()
        Me.tbKesimpulanDiagnosa = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.tbNoEpi = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbNoContohUji = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMenyetujuiKepalaUPT = New System.Windows.Forms.ComboBox()
        Me.tbCatatan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSaran = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPenguji = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbMenyetujuiMM = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtRevisi = New System.Windows.Forms.DateTimePicker()
        Me.dtTerbitan = New System.Windows.Forms.DateTimePicker()
        Me.dtTerbitanRevisi = New System.Windows.Forms.DateTimePicker()
        Me.tbHalaman = New System.Windows.Forms.TextBox()
        Me.tbNoBagian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(84, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Manajer Teknis"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbManajerTeknis
        '
        Me.cbManajerTeknis.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbManajerTeknis.FormattingEnabled = True
        Me.cbManajerTeknis.Location = New System.Drawing.Point(184, 463)
        Me.cbManajerTeknis.Name = "cbManajerTeknis"
        Me.cbManajerTeknis.Size = New System.Drawing.Size(210, 22)
        Me.cbManajerTeknis.TabIndex = 108
        '
        'tbKesimpulanDiagnosa
        '
        Me.tbKesimpulanDiagnosa.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKesimpulanDiagnosa.Location = New System.Drawing.Point(184, 181)
        Me.tbKesimpulanDiagnosa.Multiline = True
        Me.tbKesimpulanDiagnosa.Name = "tbKesimpulanDiagnosa"
        Me.tbKesimpulanDiagnosa.Size = New System.Drawing.Size(531, 75)
        Me.tbKesimpulanDiagnosa.TabIndex = 91
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.DimGray
        Me.btnSimpan.Location = New System.Drawing.Point(669, 520)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(78, 33)
        Me.btnSimpan.TabIndex = 111
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tbNoEpi
        '
        Me.tbNoEpi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoEpi.Location = New System.Drawing.Point(184, 153)
        Me.tbNoEpi.Name = "tbNoEpi"
        Me.tbNoEpi.Size = New System.Drawing.Size(210, 21)
        Me.tbNoEpi.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(50, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 14)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Kesimpulan Diagnosa"
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "dd MMM yyyy"
        Me.dtTanggal.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(505, 438)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(210, 21)
        Me.dtTanggal.TabIndex = 110
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(116, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 14)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "No. Epi"
        '
        'tbNoContohUji
        '
        Me.tbNoContohUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoContohUji.Location = New System.Drawing.Point(184, 126)
        Me.tbNoContohUji.Name = "tbNoContohUji"
        Me.tbNoContohUji.Size = New System.Drawing.Size(210, 21)
        Me.tbNoContohUji.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(87, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 14)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "No Contoh Uji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 14)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Tanggal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(44, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 14)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Menyetujui Kepala UPT"
        '
        'cbMenyetujuiKepalaUPT
        '
        Me.cbMenyetujuiKepalaUPT.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenyetujuiKepalaUPT.FormattingEnabled = True
        Me.cbMenyetujuiKepalaUPT.Location = New System.Drawing.Point(184, 435)
        Me.cbMenyetujuiKepalaUPT.Name = "cbMenyetujuiKepalaUPT"
        Me.cbMenyetujuiKepalaUPT.Size = New System.Drawing.Size(210, 22)
        Me.cbMenyetujuiKepalaUPT.TabIndex = 107
        '
        'tbCatatan
        '
        Me.tbCatatan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCatatan.Location = New System.Drawing.Point(184, 262)
        Me.tbCatatan.Multiline = True
        Me.tbCatatan.Name = "tbCatatan"
        Me.tbCatatan.Size = New System.Drawing.Size(531, 75)
        Me.tbCatatan.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(121, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Catatan"
        '
        'tbSaran
        '
        Me.tbSaran.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaran.Location = New System.Drawing.Point(184, 343)
        Me.tbSaran.Multiline = True
        Me.tbSaran.Name = "tbSaran"
        Me.tbSaran.Size = New System.Drawing.Size(531, 75)
        Me.tbSaran.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(132, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Saran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(122, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 14)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Penguji"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbPenguji
        '
        Me.cbPenguji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenguji.FormattingEnabled = True
        Me.cbPenguji.Location = New System.Drawing.Point(184, 491)
        Me.cbPenguji.Name = "cbPenguji"
        Me.cbPenguji.Size = New System.Drawing.Size(210, 22)
        Me.cbPenguji.TabIndex = 109
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.toolbar_bg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.cbMenyetujuiMM)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.dtRevisi)
        Me.Panel1.Controls.Add(Me.dtTerbitan)
        Me.Panel1.Controls.Add(Me.dtTerbitanRevisi)
        Me.Panel1.Controls.Add(Me.tbHalaman)
        Me.Panel1.Controls.Add(Me.tbNoBagian)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 94)
        Me.Panel1.TabIndex = 86
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label24.Location = New System.Drawing.Point(32, 55)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(274, 14)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "UPT LABORATORIUM VETERINER DAN KLINIK HEWAN"
        '
        'cbMenyetujuiMM
        '
        Me.cbMenyetujuiMM.AutoSize = True
        Me.cbMenyetujuiMM.BackColor = System.Drawing.Color.Transparent
        Me.cbMenyetujuiMM.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenyetujuiMM.Location = New System.Drawing.Point(668, 65)
        Me.cbMenyetujuiMM.Name = "cbMenyetujuiMM"
        Me.cbMenyetujuiMM.Size = New System.Drawing.Size(107, 18)
        Me.cbMenyetujuiMM.TabIndex = 27
        Me.cbMenyetujuiMM.Text = "Menyetujui MM"
        Me.cbMenyetujuiMM.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(661, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 14)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Tanggal Revisi"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(551, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 14)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Tanggal Terbitan"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(551, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 14)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Terbitan/Revisi"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(441, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 14)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Halaman"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(441, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 14)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "No. Bagian"
        '
        'dtRevisi
        '
        Me.dtRevisi.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtRevisi.CustomFormat = "dd MMM yyyy"
        Me.dtRevisi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRevisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRevisi.Location = New System.Drawing.Point(664, 23)
        Me.dtRevisi.Name = "dtRevisi"
        Me.dtRevisi.Size = New System.Drawing.Size(108, 21)
        Me.dtRevisi.TabIndex = 26
        '
        'dtTerbitan
        '
        Me.dtTerbitan.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtTerbitan.CustomFormat = "dd MMM yyyy"
        Me.dtTerbitan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTerbitan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTerbitan.Location = New System.Drawing.Point(554, 63)
        Me.dtTerbitan.Name = "dtTerbitan"
        Me.dtTerbitan.Size = New System.Drawing.Size(108, 21)
        Me.dtTerbitan.TabIndex = 25
        '
        'dtTerbitanRevisi
        '
        Me.dtTerbitanRevisi.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtTerbitanRevisi.CustomFormat = "dd MMM yyyy"
        Me.dtTerbitanRevisi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTerbitanRevisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTerbitanRevisi.Location = New System.Drawing.Point(554, 23)
        Me.dtTerbitanRevisi.Name = "dtTerbitanRevisi"
        Me.dtTerbitanRevisi.Size = New System.Drawing.Size(108, 21)
        Me.dtTerbitanRevisi.TabIndex = 24
        '
        'tbHalaman
        '
        Me.tbHalaman.BackColor = System.Drawing.SystemColors.Window
        Me.tbHalaman.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHalaman.Location = New System.Drawing.Point(444, 63)
        Me.tbHalaman.Name = "tbHalaman"
        Me.tbHalaman.Size = New System.Drawing.Size(108, 21)
        Me.tbHalaman.TabIndex = 23
        '
        'tbNoBagian
        '
        Me.tbNoBagian.BackColor = System.Drawing.SystemColors.Window
        Me.tbNoBagian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNoBagian.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoBagian.Location = New System.Drawing.Point(444, 23)
        Me.tbNoBagian.Name = "tbNoBagian"
        Me.tbNoBagian.Size = New System.Drawing.Size(108, 21)
        Me.tbNoBagian.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "KESIMPULAN/DIAGNOSA"
        '
        'FormulirKesimpulanDiagnosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbPenguji)
        Me.Controls.Add(Me.tbSaran)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbCatatan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbManajerTeknis)
        Me.Controls.Add(Me.tbKesimpulanDiagnosa)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.tbNoEpi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbNoContohUji)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMenyetujuiKepalaUPT)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "FormulirKesimpulanDiagnosa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKesimpulanDiagnosa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbManajerTeknis As System.Windows.Forms.ComboBox
    Friend WithEvents tbKesimpulanDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tbNoEpi As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbNoContohUji As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMenyetujuiKepalaUPT As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbMenyetujuiMM As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtRevisi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTerbitan As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTerbitanRevisi As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbHalaman As System.Windows.Forms.TextBox
    Friend WithEvents tbNoBagian As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCatatan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSaran As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPenguji As System.Windows.Forms.ComboBox
End Class
