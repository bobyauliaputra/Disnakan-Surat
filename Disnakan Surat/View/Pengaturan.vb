Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class Pengaturan
    Dim c As New Connection

    Private Sub Pengaturan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title

        BindTerms()
    End Sub

    Private Sub Pengaturan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.Enabled = False
        TambahTerms.Show()
    End Sub

    Public Sub BindTerms()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            Dim i As Integer = 1
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT termname, groupname FROM terms"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            DataGridViewTerms.Rows.Clear()

            While SQLreader.Read()
                DataGridViewTerms.Rows.Add(i, SQLreader(0), SQLreader(1))
                i += 1
            End While
            con.Close()
        End Using
    End Sub
End Class