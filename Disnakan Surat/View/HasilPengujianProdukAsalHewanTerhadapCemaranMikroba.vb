Public Class HasilPengujianProdukAsalHewanTerhadapCemaranMikroba

    Private Sub HasilPengujianProdukAsalHewanTerhadapCemaranMikroba_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Private Sub HasilPengujianProdukAsalHewanTerhadapCemaranMikroba_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title
    End Sub
End Class