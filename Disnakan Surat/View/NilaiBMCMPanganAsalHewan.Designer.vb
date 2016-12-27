<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NilaiBMCMPanganAsalHewan
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
        Me.cbPenguji = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNoContohUji = New System.Windows.Forms.TextBox()
        Me.dtTanggalTerima = New System.Windows.Forms.DateTimePicker()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridViewData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbPenerimaanContohUji1 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPenguji
        '
        Me.cbPenguji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenguji.FormattingEnabled = True
        Me.cbPenguji.Location = New System.Drawing.Point(387, 519)
        Me.cbPenguji.Name = "cbPenguji"
        Me.cbPenguji.Size = New System.Drawing.Size(246, 22)
        Me.cbPenguji.TabIndex = 156
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 14)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "E. Coli : > 1 x 10^1 CFU/g"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 14)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Coliform : > 1 x 10^2 CFU/g"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 14)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "TPC : > 1 x 10^6 CFU/g"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 14)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Ket: Batas Maksimum Cemaran Mikroba (SNI - 7388 - 2009)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(52, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 14)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "No Contoh Uji"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 14)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Tanggal Diterima"
        '
        'tbNoContohUji
        '
        Me.tbNoContohUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoContohUji.Location = New System.Drawing.Point(139, 133)
        Me.tbNoContohUji.Name = "tbNoContohUji"
        Me.tbNoContohUji.Size = New System.Drawing.Size(164, 21)
        Me.tbNoContohUji.TabIndex = 139
        '
        'dtTanggalTerima
        '
        Me.dtTanggalTerima.CustomFormat = "dd MMM yyyy"
        Me.dtTanggalTerima.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalTerima.Location = New System.Drawing.Point(139, 160)
        Me.dtTanggalTerima.Name = "dtTanggalTerima"
        Me.dtTanggalTerima.Size = New System.Drawing.Size(167, 21)
        Me.dtTanggalTerima.TabIndex = 140
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "dd MMM yyyy"
        Me.dtTanggal.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(108, 523)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(123, 21)
        Me.dtTanggal.TabIndex = 146
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(384, 502)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Penguji"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(693, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Lembar 1"
        '
        'GridViewData
        '
        Me.GridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewData.Location = New System.Drawing.Point(35, 197)
        Me.GridViewData.Name = "GridViewData"
        Me.GridViewData.Size = New System.Drawing.Size(711, 250)
        Me.GridViewData.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Lampiran Hasil Pengujian Laboratorium Kesmavet"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.DimGray
        Me.btnSimpan.Location = New System.Drawing.Point(669, 519)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(78, 33)
        Me.btnSimpan.TabIndex = 142
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbPenerimaanContohUji1
        '
        Me.cbPenerimaanContohUji1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenerimaanContohUji1.FormattingEnabled = True
        Me.cbPenerimaanContohUji1.Location = New System.Drawing.Point(387, 473)
        Me.cbPenerimaanContohUji1.Name = "cbPenerimaanContohUji1"
        Me.cbPenerimaanContohUji1.Size = New System.Drawing.Size(246, 22)
        Me.cbPenerimaanContohUji1.TabIndex = 147
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(384, 456)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 14)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Mengetahui Manajer Teknis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(54, 528)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 14)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Tanggal"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.toolbar_bg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 94)
        Me.Panel1.TabIndex = 141
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label24.Location = New System.Drawing.Point(35, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(274, 14)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "UPT LABORATORIUM VETERINER DAN KLINIK HEWAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "NILAI BMCM PANGAN ASAL HEWAN"
        '
        'NilaiBMCMPanganAsalHewan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.cbPenguji)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbNoContohUji)
        Me.Controls.Add(Me.dtTanggalTerima)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridViewData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbPenerimaanContohUji1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "NilaiBMCMPanganAsalHewan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NilaiBMCMPanganAsalHewan"
        CType(Me.GridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPenguji As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbNoContohUji As System.Windows.Forms.TextBox
    Friend WithEvents dtTanggalTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridViewData As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPenerimaanContohUji1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
