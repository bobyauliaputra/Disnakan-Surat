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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridViewUser = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(451, 14)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Data ini digunakan untuk memberikan opsi login dan data persetujuan di setiap sur" & _
    "at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 14)
        Me.Label2.TabIndex = 117
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
        Me.GridViewKaryawan.Location = New System.Drawing.Point(35, 141)
        Me.GridViewKaryawan.Name = "GridViewKaryawan"
        Me.GridViewKaryawan.RowHeadersVisible = False
        Me.GridViewKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewKaryawan.Size = New System.Drawing.Size(711, 180)
        Me.GridViewKaryawan.TabIndex = 119
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
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.add
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Location = New System.Drawing.Point(713, 106)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(33, 33)
        Me.btnAdd.TabIndex = 120
        Me.btnAdd.UseVisualStyleBackColor = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(433, 14)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Data ini digunakan untuk memberikan akses kepada staff untuk mengakses sistem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(32, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 14)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Data Login Pengguna Sistem"
        '
        'GridViewUser
        '
        Me.GridViewUser.AllowUserToAddRows = False
        Me.GridViewUser.AllowUserToDeleteRows = False
        Me.GridViewUser.AllowUserToResizeColumns = False
        Me.GridViewUser.AllowUserToResizeRows = False
        Me.GridViewUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridViewUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GridViewUser.EnableHeadersVisualStyles = False
        Me.GridViewUser.Location = New System.Drawing.Point(35, 368)
        Me.GridViewUser.Name = "GridViewUser"
        Me.GridViewUser.RowHeadersVisible = False
        Me.GridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewUser.Size = New System.Drawing.Size(711, 180)
        Me.GridViewUser.TabIndex = 123
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Distanak_Surat.My.Resources.Resources.add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(713, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 124
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 208
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama Karyawan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Login Terakhir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridViewUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridViewKaryawan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.GridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridViewKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departemen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridViewUser As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
