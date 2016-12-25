Public Class FormulirPenerimaanContohUjiSampel

    Private Sub FormulirPenerimaanContohUjiSampel_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Enabled = True
    End Sub

    Private Sub FormulirPenerimaanContohUjiSampel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim g As New General
        Me.Text = g.Title
    End Sub

    Private Sub tbNoBagian_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbNoBagian.MouseDown
        Me.tbNoBagian.SelectAll()
    End Sub
End Class