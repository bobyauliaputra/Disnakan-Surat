Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class TambahKaryawan
    Dim c As New Connection

    Private Sub TambahKaryawan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindJabatan()
        BindDepartemen()
    End Sub

    Private Sub TambahKaryawan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Pengaturan.Enabled = True
    End Sub

    Private Sub BindJabatan()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, termname FROM terms where groupname like 'jabatan' order by termname asc"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()
            cbJabatan.Items.Clear()
            Dim cbSource As New Dictionary(Of String, String)()
            While SQLreader.Read()
                cbSource.Add(SQLreader(0), SQLreader(1))
                cbJabatan.DataSource = New BindingSource(cbSource, Nothing)
                cbJabatan.DisplayMember = "Value"
                cbJabatan.ValueMember = "Key"
            End While
            con.Close()
        End Using
    End Sub

    Private Sub BindDepartemen()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, termname FROM terms where groupname like 'departemen' order by termname asc"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()
            cbDepartemen.Items.Clear()
            Dim cbSource As New Dictionary(Of String, String)()
            While SQLreader.Read()
                cbSource.Add(SQLreader(0), SQLreader(1))
                cbDepartemen.DataSource = New BindingSource(cbSource, Nothing)
                cbDepartemen.DisplayMember = "Value"
                cbDepartemen.ValueMember = "Key"
            End While
            con.Close()
        End Using
    End Sub

    Private Sub SimpanKaryawan()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into karyawan (nama, jabatanID, DepartemenID) values ('" + tbNama.Text + "', '" + cbJabatan.SelectedValue + "', '" + cbDepartemen.SelectedValue + "')"
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Sub btnSimpanBaru_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpanBaru.Click
        If tbNama.Text.Trim() = "" Then
            MsgBox("Nama karyawan harus diisi.")
        Else
            SimpanKaryawan()
            tbNama.Text = ""
            cbJabatan.SelectedIndex = 0
            Pengaturan.BindKaryawan()
        End If
    End Sub

    Private Sub btnSimpanTutup_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpanTutup.Click
        If tbNama.Text.Trim() = "" Then
            MsgBox("Nama karyawan harus diisi.")
        Else
            SimpanKaryawan()
            Me.Close()
            Pengaturan.BindKaryawan()
        End If
    End Sub
End Class