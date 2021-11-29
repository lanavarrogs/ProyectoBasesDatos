Public Class Menu_Principal
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Comprar.Show()
        Me.Hide()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        ComprarProducto.Show()
        Me.Hide()
    End Sub

    Private Sub ContactanosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactanosToolStripMenuItem.Click
        Contactanos.Show()
        Me.Hide()
    End Sub

    Private Sub VisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisionToolStripMenuItem.Click
        Vision.Show()
        Me.Hide()
    End Sub

    Private Sub MisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisionToolStripMenuItem.Click
        Mision.Show()
        Me.Hide()
    End Sub

    Private Sub ValoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValoresToolStripMenuItem.Click
        Valores.Show()
        Me.Hide()
    End Sub

    Private Sub QuienesSomosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuienesSomosToolStripMenuItem.Click
        QS.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        Vistas1.Show()
        Me.Hide()
    End Sub
End Class