﻿Imports System.Data.SQLite
Imports System.Data.SqlClient

Public Class Pengaturan
    Dim c As New Connection

    Private Sub Pengaturan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title

        BindTerms()
        BindKaryawan()
        BindUsers()
    End Sub

    Private Sub Pengaturan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
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

    Private Sub btnAddKaryawan_Click(sender As System.Object, e As System.EventArgs) Handles btnAddKaryawan.Click
        Me.Enabled = False
        TambahKaryawan.Show()
    End Sub

    Private Sub btnAddTerms_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAddTerms.Click
        Me.Enabled = False
        TambahTerms.Show()
    End Sub

    Private Sub btnAddUser_Click(sender As System.Object, e As System.EventArgs) Handles btnAddUser.Click
        Me.Enabled = False
        TambahUser.Show()
    End Sub
End Class