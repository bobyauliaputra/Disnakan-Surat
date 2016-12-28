<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahUser
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
        Me.lbStaff = New System.Windows.Forms.ListBox()
        Me.btnSimpanTutup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTambah = New System.Windows.Forms.CheckBox()
        Me.cbKoreksi = New System.Windows.Forms.CheckBox()
        Me.cbHapus = New System.Windows.Forms.CheckBox()
        Me.cbCari = New System.Windows.Forms.CheckBox()
        Me.cbLihat = New System.Windows.Forms.CheckBox()
        Me.lblSelectedStaff = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSemua = New System.Windows.Forms.CheckBox()
        Me.btnSimpanBaru = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbStaff
        '
        Me.lbStaff.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStaff.FormattingEnabled = True
        Me.lbStaff.ItemHeight = 16
        Me.lbStaff.Location = New System.Drawing.Point(12, 35)
        Me.lbStaff.Name = "lbStaff"
        Me.lbStaff.Size = New System.Drawing.Size(194, 276)
        Me.lbStaff.TabIndex = 1
        '
        'btnSimpanTutup
        '
        Me.btnSimpanTutup.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanTutup.Location = New System.Drawing.Point(272, 255)
        Me.btnSimpanTutup.Name = "btnSimpanTutup"
        Me.btnSimpanTutup.Size = New System.Drawing.Size(117, 23)
        Me.btnSimpanTutup.TabIndex = 8
        Me.btnSimpanTutup.Text = "Simpan && Tutup"
        Me.btnSimpanTutup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSemua)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cbLihat)
        Me.GroupBox1.Controls.Add(Me.cbCari)
        Me.GroupBox1.Controls.Add(Me.cbHapus)
        Me.GroupBox1.Controls.Add(Me.cbKoreksi)
        Me.GroupBox1.Controls.Add(Me.cbTambah)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(231, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 154)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sekuriti"
        '
        'cbTambah
        '
        Me.cbTambah.AutoSize = True
        Me.cbTambah.Location = New System.Drawing.Point(9, 51)
        Me.cbTambah.Name = "cbTambah"
        Me.cbTambah.Size = New System.Drawing.Size(97, 22)
        Me.cbTambah.TabIndex = 3
        Me.cbTambah.Text = "Menambah"
        Me.cbTambah.UseVisualStyleBackColor = True
        '
        'cbKoreksi
        '
        Me.cbKoreksi.AutoSize = True
        Me.cbKoreksi.Location = New System.Drawing.Point(9, 70)
        Me.cbKoreksi.Name = "cbKoreksi"
        Me.cbKoreksi.Size = New System.Drawing.Size(99, 22)
        Me.cbKoreksi.TabIndex = 4
        Me.cbKoreksi.Text = "Mengoreksi"
        Me.cbKoreksi.UseVisualStyleBackColor = True
        '
        'cbHapus
        '
        Me.cbHapus.AutoSize = True
        Me.cbHapus.Location = New System.Drawing.Point(9, 89)
        Me.cbHapus.Name = "cbHapus"
        Me.cbHapus.Size = New System.Drawing.Size(100, 22)
        Me.cbHapus.TabIndex = 5
        Me.cbHapus.Text = "Menghapus"
        Me.cbHapus.UseVisualStyleBackColor = True
        '
        'cbCari
        '
        Me.cbCari.AutoSize = True
        Me.cbCari.Location = New System.Drawing.Point(9, 108)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(76, 22)
        Me.cbCari.TabIndex = 6
        Me.cbCari.Text = "Mencari"
        Me.cbCari.UseVisualStyleBackColor = True
        '
        'cbLihat
        '
        Me.cbLihat.AutoSize = True
        Me.cbLihat.Location = New System.Drawing.Point(9, 127)
        Me.cbLihat.Name = "cbLihat"
        Me.cbLihat.Size = New System.Drawing.Size(73, 22)
        Me.cbLihat.TabIndex = 7
        Me.cbLihat.Text = "Melihat"
        Me.cbLihat.UseVisualStyleBackColor = True
        '
        'lblSelectedStaff
        '
        Me.lblSelectedStaff.AutoSize = True
        Me.lblSelectedStaff.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedStaff.Location = New System.Drawing.Point(281, 35)
        Me.lblSelectedStaff.Name = "lblSelectedStaff"
        Me.lblSelectedStaff.Size = New System.Drawing.Size(108, 18)
        Me.lblSelectedStaff.TabIndex = 6
        Me.lblSelectedStaff.Text = "Tidak ada data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 10)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'cbSemua
        '
        Me.cbSemua.AutoSize = True
        Me.cbSemua.Location = New System.Drawing.Point(9, 23)
        Me.cbSemua.Name = "cbSemua"
        Me.cbSemua.Size = New System.Drawing.Size(97, 22)
        Me.cbSemua.TabIndex = 2
        Me.cbSemua.Text = "Pilih Semua"
        Me.cbSemua.UseVisualStyleBackColor = True
        '
        'btnSimpanBaru
        '
        Me.btnSimpanBaru.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanBaru.Location = New System.Drawing.Point(272, 284)
        Me.btnSimpanBaru.Name = "btnSimpanBaru"
        Me.btnSimpanBaru.Size = New System.Drawing.Size(117, 23)
        Me.btnSimpanBaru.TabIndex = 9
        Me.btnSimpanBaru.Text = "Simpan && Buat Baru"
        Me.btnSimpanBaru.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(272, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Staff"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(385, 9)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(53, 18)
        Me.lblStaffID.TabIndex = 12
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'TambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 323)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSimpanBaru)
        Me.Controls.Add(Me.lblSelectedStaff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSimpanTutup)
        Me.Controls.Add(Me.lbStaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbStaff As System.Windows.Forms.ListBox
    Friend WithEvents btnSimpanTutup As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbLihat As System.Windows.Forms.CheckBox
    Friend WithEvents cbCari As System.Windows.Forms.CheckBox
    Friend WithEvents cbHapus As System.Windows.Forms.CheckBox
    Friend WithEvents cbKoreksi As System.Windows.Forms.CheckBox
    Friend WithEvents cbTambah As System.Windows.Forms.CheckBox
    Friend WithEvents lblSelectedStaff As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSemua As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpanBaru As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
End Class
