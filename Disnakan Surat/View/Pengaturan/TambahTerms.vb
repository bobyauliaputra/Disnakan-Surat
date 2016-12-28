Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class TambahTerms
    Dim c As New Connection

    Private Sub TambahTerms_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindGroupName()
    End Sub

    Private Sub TambahTerms_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Pengaturan.Enabled = True
    End Sub

    Private Sub BindGroupName()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT groupname FROM terms order by groupname asc"
            Dim SQLreader As SQLiteDataReader = cmd.ExecuteReader()

            cbGrupName.Items.Clear()

            While SQLreader.Read()
                cbGrupName.Items.Add(SQLreader(0))
            End While
            con.Close()
        End Using
    End Sub

    Private Sub btnSimpanTutup_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpanTutup.Click
        SimpanTerm()
        Me.Close()
        Pengaturan.Enabled = True
        Pengaturan.BindTerms()
    End Sub

    Private Sub btnSimpanBaru_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpanBaru.Click
        SimpanTerm()
        Pengaturan.BindTerms()
    End Sub

    Private Sub SimpanTerm()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into terms (termname, groupname) values ('" + tbTermBaru.Text + "', '" + cbGrupName.SelectedItem + "')"
            cmd.ExecuteNonQuery()
            cbGrupName.Items.Clear()
            con.Close()
        End Using
    End Sub
End Class