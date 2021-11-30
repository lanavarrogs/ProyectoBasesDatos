Public Class Vistas1
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub

    Private Sub Vistas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.VISTA2' Puede moverla o quitarla según sea necesario.
        Me.VISTA2TableAdapter.Fill(Me.TiendaRopaDataSet.VISTA2)
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.VISTA1' Puede moverla o quitarla según sea necesario.
        Me.VISTA1TableAdapter.Fill(Me.TiendaRopaDataSet.VISTA1)

    End Sub
End Class