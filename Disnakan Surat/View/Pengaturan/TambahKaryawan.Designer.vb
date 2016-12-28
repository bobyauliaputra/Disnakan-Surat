<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKaryawan
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
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.cbJabatan = New System.Windows.Forms.ComboBox()
        Me.cbDepartemen = New System.Windows.Forms.ComboBox()
        Me.btnSimpanBaru = New System.Windows.Forms.Button()
        Me.btnSimpanTutup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(126, 29)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(265, 24)
        Me.tbNama.TabIndex = 0
        '
        'cbJabatan
        '
        Me.cbJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJabatan.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJabatan.FormattingEnabled = True
        Me.cbJabatan.Location = New System.Drawing.Point(126, 59)
        Me.cbJabatan.Name = "cbJabatan"
        Me.cbJabatan.Size = New System.Drawing.Size(265, 24)
        Me.cbJabatan.TabIndex = 1
        '
        'cbDepartemen
        '
        Me.cbDepartemen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartemen.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartemen.FormattingEnabled = True
        Me.cbDepartemen.Location = New System.Drawing.Point(126, 89)
        Me.cbDepartemen.Name = "cbDepartemen"
        Me.cbDepartemen.Size = New System.Drawing.Size(265, 24)
        Me.cbDepartemen.TabIndex = 2
        '
        'btnSimpanBaru
        '
        Me.btnSimpanBaru.Location = New System.Drawing.Point(274, 124)
        Me.btnSimpanBaru.Name = "btnSimpanBaru"
        Me.btnSimpanBaru.Size = New System.Drawing.Size(117, 27)
        Me.btnSimpanBaru.TabIndex = 3
        Me.btnSimpanBaru.Text = "Simpan && Buat Baru"
        Me.btnSimpanBaru.UseVisualStyleBackColor = True
        '
        'btnSimpanTutup
        '
        Me.btnSimpanTutup.Location = New System.Drawing.Point(175, 124)
        Me.btnSimpanTutup.Name = "btnSimpanTutup"
        Me.btnSimpanTutup.Size = New System.Drawing.Size(93, 27)
        Me.btnSimpanTutup.TabIndex = 4
        Me.btnSimpanTutup.Text = "Simpan && Tutup"
        Me.btnSimpanTutup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Departemen"
        '
        'TambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 164)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpanTutup)
        Me.Controls.Add(Me.btnSimpanBaru)
        Me.Controls.Add(Me.cbDepartemen)
        Me.Controls.Add(Me.cbJabatan)
        Me.Controls.Add(Me.tbNama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Karyawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents cbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartemen As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpanBaru As System.Windows.Forms.Button
    Friend WithEvents btnSimpanTutup As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
