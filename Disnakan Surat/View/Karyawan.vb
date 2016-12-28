Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class Karyawan
    Dim c As New Connection

    Private Sub User_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title

        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT id, nama, jabatanid, departemenID FROM karyawan"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            GridViewKaryawan.Rows.Clear()

            While SQLreader.Read()
                GridViewKaryawan.Rows.Add(SQLreader(0), SQLreader(1), SQLreader(2), "Cetak", "Buka")
            End While
            con.Close()
        End Using

    End Sub

    Private Sub User_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
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
End Class