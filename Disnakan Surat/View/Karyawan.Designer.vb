<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnSimpan.TabIndex = 116
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(341, 14)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Digunakan untuk memberikan akses kepada penggunaan sistem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 14)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Data Staff Pengguna Sistem"
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
        Me.GridViewKaryawan.Location = New System.Drawing.Point(35, 159)
        Me.GridViewKaryawan.Name = "GridViewKaryawan"
        Me.GridViewKaryawan.RowHeadersVisible = False
        Me.GridViewKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewKaryawan.Size = New System.Drawing.Size(711, 180)
        Me.GridViewKaryawan.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(651, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 14)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Update Terakhir :"
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
        Me.Panel1.TabIndex = 115
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
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "USER MANAGEMENT"
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
        Me.Nama.Width = 308
        '
        'Jabatan
        '
        Me.Jabatan.HeaderText = "Jabatan"
        Me.Jabatan.Name = "Jabatan"
        Me.Jabatan.ReadOnly = True
        Me.Jabatan.Width = 150
        '
        'Departemen
        '
        Me.Departemen.HeaderText = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.ReadOnly = True
        Me.Departemen.Width = 150
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridViewKaryawan)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridViewKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departemen As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
