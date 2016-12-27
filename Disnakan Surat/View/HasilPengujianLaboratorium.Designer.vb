<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HasilPengujianLaboratorium
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbNoContohUji = New System.Windows.Forms.TextBox()
        Me.dtTanggalTerima = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.GridViewData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbPenerimaanContohUji1 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.GridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPenguji
        '
        Me.cbPenguji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenguji.FormattingEnabled = True
        Me.cbPenguji.Location = New System.Drawing.Point(35, 525)
        Me.cbPenguji.Name = "cbPenguji"
        Me.cbPenguji.Size = New System.Drawing.Size(246, 22)
        Me.cbPenguji.TabIndex = 156
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(32, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Penguji"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(175, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 14)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Tanggal Diterima"
        '
        'tbNoContohUji
        '
        Me.tbNoContohUji.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoContohUji.Location = New System.Drawing.Point(567, 114)
        Me.tbNoContohUji.Name = "tbNoContohUji"
        Me.tbNoContohUji.Size = New System.Drawing.Size(180, 21)
        Me.tbNoContohUji.TabIndex = 10
        '
        'dtTanggalTerima
        '
        Me.dtTanggalTerima.CustomFormat = "dd MMM yyyy"
        Me.dtTanggalTerima.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggalTerima.Location = New System.Drawing.Point(275, 161)
        Me.dtTanggalTerima.Name = "dtTanggalTerima"
        Me.dtTanggalTerima.Size = New System.Drawing.Size(201, 21)
        Me.dtTanggalTerima.TabIndex = 140
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(519, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 14)
        Me.Label13.TabIndex = 151
        Me.Label13.Text = "Nomor"
        '
        'dtTanggal
        '
        Me.dtTanggal.CustomFormat = "dd MMM yyyy"
        Me.dtTanggal.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTanggal.Location = New System.Drawing.Point(624, 457)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(123, 21)
        Me.dtTanggal.TabIndex = 146
        '
        'GridViewData
        '
        Me.GridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewData.Location = New System.Drawing.Point(35, 198)
        Me.GridViewData.Name = "GridViewData"
        Me.GridViewData.Size = New System.Drawing.Size(711, 250)
        Me.GridViewData.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Kepada Yth."
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
        Me.btnSimpan.TabIndex = 142
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbPenerimaanContohUji1
        '
        Me.cbPenerimaanContohUji1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPenerimaanContohUji1.FormattingEnabled = True
        Me.cbPenerimaanContohUji1.Location = New System.Drawing.Point(35, 479)
        Me.cbPenerimaanContohUji1.Name = "cbPenerimaanContohUji1"
        Me.cbPenerimaanContohUji1.Size = New System.Drawing.Size(246, 22)
        Me.cbPenerimaanContohUji1.TabIndex = 147
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(32, 462)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 14)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Mengetahui Manajer Teknis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(570, 462)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 94)
        Me.Panel1.TabIndex = 141
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label24.Location = New System.Drawing.Point(32, 54)
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
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "HASIL PENGUJIAN LABORATORIUM"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(275, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 21)
        Me.TextBox1.TabIndex = 158
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 14)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Bersama ini kami laporkan hasil uji terhadap"
        '
        'HasilPengujianLaboratorium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbPenguji)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbNoContohUji)
        Me.Controls.Add(Me.dtTanggalTerima)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.GridViewData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbPenerimaanContohUji1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "HasilPengujianLaboratorium"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HasilPengujianLaboratorium"
        CType(Me.GridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbPenguji As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbNoContohUji As System.Windows.Forms.TextBox
    Friend WithEvents dtTanggalTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridViewData As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbPenerimaanContohUji1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
