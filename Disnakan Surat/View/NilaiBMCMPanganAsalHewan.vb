Public Class NilaiBMCMPanganAsalHewan

    Private Sub NilaiBMCMPanganAsalHewan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Private Sub NilaiBMCMPanganAsalHewan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title
    End Sub
End Class