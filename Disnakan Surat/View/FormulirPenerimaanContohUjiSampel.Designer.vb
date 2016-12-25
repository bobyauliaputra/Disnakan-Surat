<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulirPenerimaanContohUjiSampel
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
        Me.dtTanggalTerima = New System.Windows.Forms.DateTimePicker()
        Me.dtTanggalDiserahkanKeMT = New System.Windows.Forms.DateTimePicker()
        Me.tbNoContohUji = New System.Windows.Forms.TextBox()
        Me.tbNoEpi = New System.Windows.Forms.TextBox()
        Me.GridViewUjiSample = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtKUPTanggalPenerimaan = New System.Windows.Forms.DateTimePicker()
        Me.tbKUPLamaPengujian = New System.Windows.Forms.TextBox()
        Me.tbKUPNoEpidContohUji = New System.Windows.Forms.TextBox()
        Me.tbKUPLaboratorium = New System.Windows.Forms.TextBox()
        Me.tbKUPBiayaUji = New System.Windows.Forms.TextBox()
        Me.tbKUPMetodaUji = New System.Windows.Forms.TextBox()
        Me.tbKUPJumlahSample = New System.Windows.Forms.TextBox()
        Me.tbKUPJenisSample = New System.Windows.Forms.TextBox()
        Me.tbKUPPengirimanSample = New System.Windows.Forms.TextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbPenerimaanContohUji1 = New System.Windows.Forms.ComboBox()
        Me.cbPenerimaanContohUji2 = New System.Windows.Forms.ComboBox()
        Me.cbMengetahuiMAnajerAdministrasi = New System.Windows.Forms.ComboBox()
        Me.cbDisampaikanKeMT = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
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
        CType(Me.GridViewUjiSample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTanggalTerima
        '
        Me.dtTanggalTerima.CustomFormat = "dd MMM yyyy"
        Me.dtTanggalTerima.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalTerima.Location = New System.Drawing.Point(191, 101)
        Me.dtTanggalTerima.Name = "dtTanggalTerima"
        Me.dtTanggalTerima.Size = New System.Drawing.Size(167, 21)
        Me.dtTanggalTerima.TabIndex = 1
        '
        'dtTanggalDiserahkanKeMT
        '
        Me.dtTanggalDiserahkanKeMT.CustomFormat = "dd MMM yyyy"
        Me.dtTanggalDiserahkanKeMT.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalDiserahkanKeMT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalDiserahkanKeMT.Location = New System.Drawing.Point(191, 125)
        Me.dtTanggalDiserahkanKeMT.Name = "dtTanggalDiserahkanKeMT"
        Me.dtTanggalDiserahkanKeMT.Size = New System.Drawing.Size(167, 21)
        Me.dtTanggalDiserahkanKeMT.TabIndex = 2
        '
        'tbNoContohUji
        '
        Me.tbNoContohUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoContohUji.Location = New System.Drawing.Point(573, 101)
        Me.tbNoContohUji.Name = "tbNoContohUji"
        Me.tbNoContohUji.Size = New System.Drawing.Size(173, 21)
        Me.tbNoContohUji.TabIndex = 3
        '
        'tbNoEpi
        '
        Me.tbNoEpi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoEpi.Location = New System.Drawing.Point(573, 127)
        Me.tbNoEpi.Name = "tbNoEpi"
        Me.tbNoEpi.Size = New System.Drawing.Size(173, 21)
        Me.tbNoEpi.TabIndex = 4
        '
        'GridViewUjiSample
        '
        Me.GridViewUjiSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewUjiSample.Location = New System.Drawing.Point(35, 153)
        Me.GridViewUjiSample.Name = "GridViewUjiSample"
        Me.GridViewUjiSample.Size = New System.Drawing.Size(711, 131)
        Me.GridViewUjiSample.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtKUPTanggalPenerimaan)
        Me.GroupBox1.Controls.Add(Me.tbKUPLamaPengujian)
        Me.GroupBox1.Controls.Add(Me.tbKUPNoEpidContohUji)
        Me.GroupBox1.Controls.Add(Me.tbKUPLaboratorium)
        Me.GroupBox1.Controls.Add(Me.tbKUPBiayaUji)
        Me.GroupBox1.Controls.Add(Me.tbKUPMetodaUji)
        Me.GroupBox1.Controls.Add(Me.tbKUPJumlahSample)
        Me.GroupBox1.Controls.Add(Me.tbKUPJenisSample)
        Me.GroupBox1.Controls.Add(Me.tbKUPPengirimanSample)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 262)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kaji Ulang Permintaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(219, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 14)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "9. Lama Pengujian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(219, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 14)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "8. No. Epid/Contoh Uji"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(219, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 14)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "7. Laboratorium"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(219, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "6. Biaya Uji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(17, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "5. Metoda Uji"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(17, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "4. Jumlah Sampel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "3. Jenis Sampel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "2. Pengiriman Sampel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "1. Tanggal Penerimaan"
        '
        'dtKUPTanggalPenerimaan
        '
        Me.dtKUPTanggalPenerimaan.CustomFormat = "dd MMM yyyy"
        Me.dtKUPTanggalPenerimaan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.dtKUPTanggalPenerimaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtKUPTanggalPenerimaan.Location = New System.Drawing.Point(17, 41)
        Me.dtKUPTanggalPenerimaan.Name = "dtKUPTanggalPenerimaan"
        Me.dtKUPTanggalPenerimaan.Size = New System.Drawing.Size(196, 21)
        Me.dtKUPTanggalPenerimaan.TabIndex = 7
        '
        'tbKUPLamaPengujian
        '
        Me.tbKUPLamaPengujian.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPLamaPengujian.Location = New System.Drawing.Point(222, 182)
        Me.tbKUPLamaPengujian.Name = "tbKUPLamaPengujian"
        Me.tbKUPLamaPengujian.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPLamaPengujian.TabIndex = 15
        '
        'tbKUPNoEpidContohUji
        '
        Me.tbKUPNoEpidContohUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPNoEpidContohUji.Location = New System.Drawing.Point(222, 136)
        Me.tbKUPNoEpidContohUji.Name = "tbKUPNoEpidContohUji"
        Me.tbKUPNoEpidContohUji.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPNoEpidContohUji.TabIndex = 14
        '
        'tbKUPLaboratorium
        '
        Me.tbKUPLaboratorium.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPLaboratorium.Location = New System.Drawing.Point(222, 89)
        Me.tbKUPLaboratorium.Name = "tbKUPLaboratorium"
        Me.tbKUPLaboratorium.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPLaboratorium.TabIndex = 13
        '
        'tbKUPBiayaUji
        '
        Me.tbKUPBiayaUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPBiayaUji.Location = New System.Drawing.Point(222, 41)
        Me.tbKUPBiayaUji.Name = "tbKUPBiayaUji"
        Me.tbKUPBiayaUji.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPBiayaUji.TabIndex = 12
        '
        'tbKUPMetodaUji
        '
        Me.tbKUPMetodaUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPMetodaUji.Location = New System.Drawing.Point(17, 228)
        Me.tbKUPMetodaUji.Name = "tbKUPMetodaUji"
        Me.tbKUPMetodaUji.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPMetodaUji.TabIndex = 11
        '
        'tbKUPJumlahSample
        '
        Me.tbKUPJumlahSample.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPJumlahSample.Location = New System.Drawing.Point(17, 182)
        Me.tbKUPJumlahSample.Name = "tbKUPJumlahSample"
        Me.tbKUPJumlahSample.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPJumlahSample.TabIndex = 10
        '
        'tbKUPJenisSample
        '
        Me.tbKUPJenisSample.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPJenisSample.Location = New System.Drawing.Point(17, 136)
        Me.tbKUPJenisSample.Name = "tbKUPJenisSample"
        Me.tbKUPJenisSample.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPJenisSample.TabIndex = 9
        '
        'tbKUPPengirimanSample
        '
        Me.tbKUPPengirimanSample.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.tbKUPPengirimanSample.Location = New System.Drawing.Point(17, 89)
        Me.tbKUPPengirimanSample.Name = "tbKUPPengirimanSample"
        Me.tbKUPPengirimanSample.Size = New System.Drawing.Size(199, 21)
        Me.tbKUPPengirimanSample.TabIndex = 8
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "dd MMM yyyy"
        Me.dtTanggal.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(500, 316)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(246, 21)
        Me.dtTanggal.TabIndex = 16
        '
        'cbPenerimaanContohUji1
        '
        Me.cbPenerimaanContohUji1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenerimaanContohUji1.FormattingEnabled = True
        Me.cbPenerimaanContohUji1.Location = New System.Drawing.Point(500, 365)
        Me.cbPenerimaanContohUji1.Name = "cbPenerimaanContohUji1"
        Me.cbPenerimaanContohUji1.Size = New System.Drawing.Size(246, 22)
        Me.cbPenerimaanContohUji1.TabIndex = 17
        '
        'cbPenerimaanContohUji2
        '
        Me.cbPenerimaanContohUji2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenerimaanContohUji2.FormattingEnabled = True
        Me.cbPenerimaanContohUji2.Location = New System.Drawing.Point(500, 416)
        Me.cbPenerimaanContohUji2.Name = "cbPenerimaanContohUji2"
        Me.cbPenerimaanContohUji2.Size = New System.Drawing.Size(246, 22)
        Me.cbPenerimaanContohUji2.TabIndex = 18
        '
        'cbMengetahuiMAnajerAdministrasi
        '
        Me.cbMengetahuiMAnajerAdministrasi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMengetahuiMAnajerAdministrasi.FormattingEnabled = True
        Me.cbMengetahuiMAnajerAdministrasi.Location = New System.Drawing.Point(500, 470)
        Me.cbMengetahuiMAnajerAdministrasi.Name = "cbMengetahuiMAnajerAdministrasi"
        Me.cbMengetahuiMAnajerAdministrasi.Size = New System.Drawing.Size(246, 22)
        Me.cbMengetahuiMAnajerAdministrasi.TabIndex = 19
        '
        'cbDisampaikanKeMT
        '
        Me.cbDisampaikanKeMT.AutoSize = True
        Me.cbDisampaikanKeMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisampaikanKeMT.Location = New System.Drawing.Point(500, 500)
        Me.cbDisampaikanKeMT.Name = "cbDisampaikanKeMT"
        Me.cbDisampaikanKeMT.Size = New System.Drawing.Size(121, 17)
        Me.cbDisampaikanKeMT.TabIndex = 20
        Me.cbDisampaikanKeMT.Text = "Disampaikan ke MT"
        Me.cbDisampaikanKeMT.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(81, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Tanggal Diterima"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Tanggal Diserahkan ke MT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(471, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "No Contoh Uji"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(508, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 14)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "No. Epi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(497, 298)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 14)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Tanggal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(497, 346)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 14)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Penerima Contoh Uji 1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(497, 398)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 14)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Pengirim Contoh Uji 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(497, 451)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Mengetahui Manajer Administrasi"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.DimGray
        Me.btnSimpan.Location = New System.Drawing.Point(668, 518)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(78, 34)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 95)
        Me.Panel1.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label24.Location = New System.Drawing.Point(33, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(274, 14)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "UPT LABORATORIUM VETERINER DAN KLINIK HEWAN"
        '
        'cbMenyetujuiMM
        '
        Me.cbMenyetujuiMM.AutoSize = True
        Me.cbMenyetujuiMM.BackColor = System.Drawing.Color.Transparent
        Me.cbMenyetujuiMM.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenyetujuiMM.Location = New System.Drawing.Point(669, 67)
        Me.cbMenyetujuiMM.Name = "cbMenyetujuiMM"
        Me.cbMenyetujuiMM.Size = New System.Drawing.Size(107, 18)
        Me.cbMenyetujuiMM.TabIndex = 39
        Me.cbMenyetujuiMM.Text = "Menyetujui MM"
        Me.cbMenyetujuiMM.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(662, 9)
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
        Me.Label22.Location = New System.Drawing.Point(552, 50)
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
        Me.Label21.Location = New System.Drawing.Point(552, 9)
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
        Me.Label20.Location = New System.Drawing.Point(442, 50)
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
        Me.Label19.Location = New System.Drawing.Point(442, 9)
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
        Me.dtRevisi.Location = New System.Drawing.Point(665, 25)
        Me.dtRevisi.Name = "dtRevisi"
        Me.dtRevisi.Size = New System.Drawing.Size(108, 21)
        Me.dtRevisi.TabIndex = 32
        '
        'dtTerbitan
        '
        Me.dtTerbitan.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtTerbitan.CustomFormat = "dd MMM yyyy"
        Me.dtTerbitan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTerbitan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTerbitan.Location = New System.Drawing.Point(555, 65)
        Me.dtTerbitan.Name = "dtTerbitan"
        Me.dtTerbitan.Size = New System.Drawing.Size(108, 21)
        Me.dtTerbitan.TabIndex = 31
        '
        'dtTerbitanRevisi
        '
        Me.dtTerbitanRevisi.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtTerbitanRevisi.CustomFormat = "dd MMM yyyy"
        Me.dtTerbitanRevisi.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTerbitanRevisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTerbitanRevisi.Location = New System.Drawing.Point(555, 25)
        Me.dtTerbitanRevisi.Name = "dtTerbitanRevisi"
        Me.dtTerbitanRevisi.Size = New System.Drawing.Size(108, 21)
        Me.dtTerbitanRevisi.TabIndex = 30
        '
        'tbHalaman
        '
        Me.tbHalaman.BackColor = System.Drawing.SystemColors.Window
        Me.tbHalaman.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHalaman.Location = New System.Drawing.Point(445, 65)
        Me.tbHalaman.Name = "tbHalaman"
        Me.tbHalaman.Size = New System.Drawing.Size(108, 21)
        Me.tbHalaman.TabIndex = 2
        '
        'tbNoBagian
        '
        Me.tbNoBagian.BackColor = System.Drawing.SystemColors.Window
        Me.tbNoBagian.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoBagian.Location = New System.Drawing.Point(445, 25)
        Me.tbNoBagian.Name = "tbNoBagian"
        Me.tbNoBagian.Size = New System.Drawing.Size(108, 21)
        Me.tbNoBagian.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMULIR PENERIMAAN CONTOH UJI/SAMPEL"
        '
        'FormulirPenerimaanContohUjiSampel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbDisampaikanKeMT)
        Me.Controls.Add(Me.cbMengetahuiMAnajerAdministrasi)
        Me.Controls.Add(Me.cbPenerimaanContohUji2)
        Me.Controls.Add(Me.cbPenerimaanContohUji1)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridViewUjiSample)
        Me.Controls.Add(Me.tbNoEpi)
        Me.Controls.Add(Me.tbNoContohUji)
        Me.Controls.Add(Me.dtTanggalDiserahkanKeMT)
        Me.Controls.Add(Me.dtTanggalTerima)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormulirPenerimaanContohUjiSampel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormulirPenerimaanContohUjiSampel"
        CType(Me.GridViewUjiSample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTanggalTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTanggalDiserahkanKeMT As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbNoContohUji As System.Windows.Forms.TextBox
    Friend WithEvents tbNoEpi As System.Windows.Forms.TextBox
    Friend WithEvents GridViewUjiSample As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbKUPLamaPengujian As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPNoEpidContohUji As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPLaboratorium As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPBiayaUji As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPMetodaUji As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPJumlahSample As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPJenisSample As System.Windows.Forms.TextBox
    Friend WithEvents tbKUPPengirimanSample As System.Windows.Forms.TextBox
    Friend WithEvents dtKUPTanggalPenerimaan As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPenerimaanContohUji1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbPenerimaanContohUji2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbMengetahuiMAnajerAdministrasi As System.Windows.Forms.ComboBox
    Friend WithEvents cbDisampaikanKeMT As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tbHalaman As System.Windows.Forms.TextBox
    Friend WithEvents tbNoBagian As System.Windows.Forms.TextBox
    Friend WithEvents dtTerbitanRevisi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtRevisi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTerbitan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbMenyetujuiMM As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
