Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class TambahUser
    Dim c As New Connection

    Private Sub TambahUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindStaff()
    End Sub

    Private Sub BindStaff()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, nama FROM karyawan order by nama"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()
            lbStaff.Items.Clear()
            Dim cbSource As New Dictionary(Of String, String)()
            While SQLreader.Read()
                cbSource.Add(SQLreader(0), SQLreader(1))
                lbStaff.DataSource = New BindingSource(cbSource, Nothing)
                lbStaff.DisplayMember = "Value"
                lbStaff.ValueMember = "Key"
            End While
            con.Close()
        End Using
    End Sub

    Private Sub TambahUser_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Pengaturan.Enabled = True
    End Sub

    Private Sub lbStaff_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbStaff.SelectedIndexChanged
        lblSelectedStaff.Text = lbStaff.SelectedItem.Value
        lblStaffID.Text = lbStaff.SelectedItem.Key
    End Sub

    Private Sub cbSemua_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbSemua.CheckedChanged
        If cbSemua.Checked Then
            cbTambah.Checked = True : cbKoreksi.Checked = True : cbHapus.Checked = True : cbCari.Checked = True : cbLihat.Checked = True
        Else
            cbTambah.Checked = False : cbKoreksi.Checked = False : cbHapus.Checked = False : cbCari.Checked = False : cbLihat.Checked = False
        End If
    End Sub
End Class