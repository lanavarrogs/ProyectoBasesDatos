Imports System.Data.SqlClient
Public Class SetProyecto
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection(My.Settings.tiendaRopaConnectionString)
        Dim cmd As New SqlCommand
        Dim id As String
        Dim nombre_producto As String
        Dim gama As String
        Dim dimensiones As String
        Dim proveedor As String
        Dim descripcion As String
        Dim cantidad_stock As Int32
        Dim precio_venta As Int32
        Dim precio_proveedor As Int32
        Dim codigo_venta As Int32

        id = txtIdProducto.Text
        nombre_producto = txtNombreProducto.Text
        gama = txtGama.Text
        dimensiones = txtDimensiones.Text
        proveedor = txtProveedor.Text
        descripcion = txtDescripcion.Text
        cantidad_stock = Convert.ToInt32(txtCantidadStock.Text)
        precio_venta = Convert.ToInt32(txtPrecioVenta.Text)
        precio_proveedor = Convert.ToInt32(txtPrecioProveedor.Text)
        codigo_venta = Convert.ToInt32(txtCodigoVenta.Text)
        conn.Open()

    End Sub
End Class