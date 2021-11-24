Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.getProducto' Puede moverla o quitarla según sea necesario.
        Me.GetProductoTableAdapter.Fill(Me.TiendaRopaDataSet.getProducto)

    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Me.Hide()
        SetProducto.Show()
    End Sub
End Class