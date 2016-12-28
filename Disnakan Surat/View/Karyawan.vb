Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class Karyawan
    Dim c As New Connection

    Private Sub User_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title
        BindKaryawan()
        BindUsers()
    End Sub

    Private Sub User_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Public Sub BindKaryawan()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT k.id, k.nama, jabatan.termname, departemen.termname FROM karyawan k left join terms jabatan on k.jabatanid = jabatan.id left join terms departemen on k.departemenid = departemen.id"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            GridViewKaryawan.Rows.Clear()

            While SQLreader.Read()
                GridViewKaryawan.Rows.Add(SQLreader(0), SQLreader(1), SQLreader(2), SQLreader(3), "Cetak", "Buka")
            End While
            con.Close()
        End Using
    End Sub

    Public Sub BindUsers()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "select u.ID, u.username, k.Nama, u.LastLogin from user u left join karyawan k on k.id = u.karyawanid"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            GridViewUser.Rows.Clear()

            While SQLreader.Read()
                GridViewUser.Rows.Add(SQLreader(0), SQLreader(1), SQLreader(2), SQLreader(3))
            End While
            con.Close()
        End Using
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs)
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, nama, jabatanid, departemenID FROM karyawan"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            GridViewKaryawan.Rows.Clear()

            While SQLreader.Read()
                'GridViewKaryawan.Rows.Add(String.Format("id = {0}, nama = {1}, jabatanid = {2}", SQLreader(0), SQLreader(1), SQLreader(2)))
                GridViewKaryawan.Rows.Add(0)
            End While
            con.Close()
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.Enabled = False
        TambahKaryawan.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class