Imports System.Data.SQLite

Public Class Connection
    Public connection As String = "Data Source=distanak.s3db"
    Dim con As New SQLiteConnection(connection)
    Dim cmd As New SQLiteCommand(con)
End Class
