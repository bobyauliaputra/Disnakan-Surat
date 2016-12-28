<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTerms
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
        Me.tbTermBaru = New System.Windows.Forms.TextBox()
        Me.btnSimpanTutup = New System.Windows.Forms.Button()
        Me.cbGrupName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpanBaru = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbTermBaru
        '
        Me.tbTermBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTermBaru.Location = New System.Drawing.Point(19, 29)
        Me.tbTermBaru.Name = "tbTermBaru"
        Me.tbTermBaru.Size = New System.Drawing.Size(346, 21)
        Me.tbTermBaru.TabIndex = 0
        '
        'btnSimpanTutup
        '
        Me.btnSimpanTutup.Location = New System.Drawing.Point(107, 100)
        Me.btnSimpanTutup.Name = "btnSimpanTutup"
        Me.btnSimpanTutup.Size = New System.Drawing.Size(122, 28)
        Me.btnSimpanTutup.TabIndex = 2
        Me.btnSimpanTutup.Text = "Simpan && Tutup"
        Me.btnSimpanTutup.UseVisualStyleBackColor = True
        '
        'cbGrupName
        '
        Me.cbGrupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupName.FormattingEnabled = True
        Me.cbGrupName.Location = New System.Drawing.Point(20, 71)
        Me.cbGrupName.Name = "cbGrupName"
        Me.cbGrupName.Size = New System.Drawing.Size(345, 23)
        Me.cbGrupName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Term baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Grup Istilah"
        '
        'btnSimpanBaru
        '
        Me.btnSimpanBaru.Location = New System.Drawing.Point(235, 100)
        Me.btnSimpanBaru.Name = "btnSimpanBaru"
        Me.btnSimpanBaru.Size = New System.Drawing.Size(130, 28)
        Me.btnSimpanBaru.TabIndex = 11
        Me.btnSimpanBaru.Text = "Simpan && Buat Baru"
        Me.btnSimpanBaru.UseVisualStyleBackColor = True
        '
        'TambahTerms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 138)
        Me.Controls.Add(Me.btnSimpanBaru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGrupName)
        Me.Controls.Add(Me.btnSimpanTutup)
        Me.Controls.Add(Me.tbTermBaru)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahTerms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Terms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTermBaru As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpanTutup As System.Windows.Forms.Button
    Friend WithEvents cbGrupName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSimpanBaru As System.Windows.Forms.Button
End Class
