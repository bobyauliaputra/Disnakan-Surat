<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengaturan
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAddTerms = New System.Windows.Forms.Button()
        Me.DataGridViewTerms = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddKaryawan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Istilah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupIstilah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnSimpan.TabIndex = 122
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 112)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 401)
        Me.TabControl1.TabIndex = 123
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddKaryawan)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.GridViewKaryawan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Management"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnAddTerms)
        Me.TabPage2.Controls.Add(Me.DataGridViewTerms)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Istilah"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAddTerms
        '
        Me.btnAddTerms.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.add
        Me.btnAddTerms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddTerms.Location = New System.Drawing.Point(716, 14)
        Me.btnAddTerms.Name = "btnAddTerms"
        Me.btnAddTerms.Size = New System.Drawing.Size(33, 33)
        Me.btnAddTerms.TabIndex = 3
        Me.btnAddTerms.UseVisualStyleBackColor = True
        '
        'DataGridViewTerms
        '
        Me.DataGridViewTerms.AllowUserToAddRows = False
        Me.DataGridViewTerms.AllowUserToDeleteRows = False
        Me.DataGridViewTerms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomor, Me.Istilah, Me.GrupIstilah})
        Me.DataGridViewTerms.EnableHeadersVisualStyles = False
        Me.DataGridViewTerms.Location = New System.Drawing.Point(3, 49)
        Me.DataGridViewTerms.Name = "DataGridViewTerms"
        Me.DataGridViewTerms.RowHeadersVisible = False
        Me.DataGridViewTerms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTerms.Size = New System.Drawing.Size(746, 318)
        Me.DataGridViewTerms.TabIndex = 2
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
        Me.Panel1.TabIndex = 121
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label24.Location = New System.Drawing.Point(32, 50)
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
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "PENGATURAN"
        '
        'btnAddKaryawan
        '
        Me.btnAddKaryawan.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.add
        Me.btnAddKaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddKaryawan.Location = New System.Drawing.Point(716, 14)
        Me.btnAddKaryawan.Name = "btnAddKaryawan"
        Me.btnAddKaryawan.Size = New System.Drawing.Size(33, 33)
        Me.btnAddKaryawan.TabIndex = 124
        Me.btnAddKaryawan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(451, 14)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Data ini digunakan untuk memberikan opsi login dan data persetujuan di setiap sur" & _
    "at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 14)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Data Staff Dinas Pertanian dan Peternakan"
        '
        'GridViewKaryawan
        '
        Me.GridViewKaryawan.AllowUserToAddRows = False
        Me.GridViewKaryawan.AllowUserToDeleteRows = False
        Me.GridViewKaryawan.AllowUserToResizeColumns = False
        Me.GridViewKaryawan.AllowUserToResizeRows = False
        Me.GridViewKaryawan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridViewKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridViewKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nama, Me.Jabatan, Me.Departemen})
        Me.GridViewKaryawan.EnableHeadersVisualStyles = False
        Me.GridViewKaryawan.Location = New System.Drawing.Point(3, 49)
        Me.GridViewKaryawan.Name = "GridViewKaryawan"
        Me.GridViewKaryawan.RowHeadersVisible = False
        Me.GridViewKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewKaryawan.Size = New System.Drawing.Size(746, 323)
        Me.GridViewKaryawan.TabIndex = 123
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Karyawan"
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Width = 309
        '
        'Jabatan
        '
        Me.Jabatan.HeaderText = "Jabatan"
        Me.Jabatan.Name = "Jabatan"
        Me.Jabatan.ReadOnly = True
        Me.Jabatan.Width = 167
        '
        'Departemen
        '
        Me.Departemen.HeaderText = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.ReadOnly = True
        Me.Departemen.Width = 167
        '
        'Nomor
        '
        Me.Nomor.HeaderText = "Nomor"
        Me.Nomor.Name = "Nomor"
        Me.Nomor.ReadOnly = True
        '
        'Istilah
        '
        Me.Istilah.HeaderText = "Istilah"
        Me.Istilah.Name = "Istilah"
        Me.Istilah.ReadOnly = True
        Me.Istilah.Width = 360
        '
        'GrupIstilah
        '
        Me.GrupIstilah.HeaderText = "Grup Istilah"
        Me.GrupIstilah.Name = "GrupIstilah"
        Me.GrupIstilah.ReadOnly = True
        Me.GrupIstilah.Width = 282
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(523, 14)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Data ini digunakan untuk mengatur istilah yang digunakan dalam semua form yang me" & _
    "miliki pilihan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 14)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Data Istilah Sistem"
        '
        'Pengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Pengaturan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengaturan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewTerms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnAddTerms As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTerms As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddKaryawan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridViewKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departemen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Istilah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupIstilah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
