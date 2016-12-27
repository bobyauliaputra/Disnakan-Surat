Public Class Dashboard

    Private Sub Dashboard_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Dispose()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Login.Dispose()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Enabled = False
        FormulirPenerimaanContohUjiSampel.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        FormulirDistribusiContohUjiSample.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Enabled = False
        FormulirHasilUjiLaboratorium.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Enabled = False
        FormulirKesimpulanDiagnosa.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Enabled = False
        PermintaanPengujianKeManajer.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Enabled = False
        PermintaanPengujianKeFisikKimiawiMikrobiologi.Show()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Me.Enabled = False
        HasilPengujianProdukAsalHewanTerhadapCemaranMikroba.Show()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Me.Enabled = False
        NilaiBMCMPanganAsalHewan.Show()
    End Sub
End Class
