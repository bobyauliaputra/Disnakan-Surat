Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class TambahKaryawan
    Dim c As New Connection

    Private Sub TambahKaryawan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindJabatan()
        BindDepartemen()
    End Sub

    Private Sub TambahKaryawan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Karyawan.Enabled = True
    End Sub

    Private Sub BindJabatan()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, termname FROM terms where groupname like 'jabatan' order by termname asc"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()
            cbJabatan.Items.Clear()

            While SQLreader.Read()
                cbJabatan.Items.Add(SQLreader(1))
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

            While SQLreader.Read()
                cbDepartemen.Items.Add(SQLreader(1))
            End While
            con.Close()
        End Using
    End Sub

    Private Sub SimpanKaryawan()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            'cmd.CommandText = "insert into karyawan (nama, jabatanID, DepartemenID) values ('" + tbTermBaru.Text + "', '" + cbGrupName.SelectedItem + "')"
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class