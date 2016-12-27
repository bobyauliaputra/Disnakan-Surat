Public Class PermintaanPengujianKeManajer

    Private Sub PermintaanPengujianKeManajer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title
    End Sub

    Private Sub PermintaanPengujianKeManajer_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub
End Class