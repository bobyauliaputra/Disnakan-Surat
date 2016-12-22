Imports System.Data.SQLite
Imports Disnakan_Surat.Connection

Public Class Login
    Dim c As New Connection
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Login()
        Using con As New SQLiteConnection(c.connection)
            Dim cmd As New SQLiteCommand(con)
            Dim log As Integer
            con.Open()
            lblError.Visible = False
            cmd.Connection = con
            cmd.CommandText = "select count(*) FROM users WHERE username = '" + tbUsername.Text + "' and password = '" + tbPassword.Text + "';"
            log = cmd.ExecuteScalar
            If String.IsNullOrEmpty(tbUsername.Text) Then
                lblError.Visible = True
                lblError.Text = "Username kosong"
            ElseIf String.IsNullOrEmpty(tbPassword.Text) Then
                lblError.Visible = True
                lblError.Text = "Password Kosong"
            Else
                If log = 1 Then
                    Me.Hide()
                    Dashboard.Show()
                Else
                    lblError.Visible = True
                    lblError.Text = "Password Salah"
                End If
            End If
            con.Clone()
        End Using
    End Sub

    Private Sub tbUsername_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbUsername.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Login()
        End If
    End Sub

    Private Sub tbPassword_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Login()
        End If
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblError.Visible = False
    End Sub
End Class