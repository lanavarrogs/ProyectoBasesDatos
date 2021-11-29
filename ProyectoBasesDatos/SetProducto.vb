Imports System.Data.SqlClient
Public Class SetProducto
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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
        cmd = New SqlCommand("setProducto", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigo_producto", id)
        cmd.Parameters.AddWithValue("@nombre", nombre_producto)
        cmd.Parameters.AddWithValue("@gama", gama)
        cmd.Parameters.AddWithValue("@dimensiones", dimensiones)
        cmd.Parameters.AddWithValue("@proveedor", proveedor)
        cmd.Parameters.AddWithValue("@descripcion", descripcion)
        cmd.Parameters.AddWithValue("@cantidad_en_stock", cantidad_stock)
        cmd.Parameters.AddWithValue("@precio_venta", precio_venta)
        cmd.Parameters.AddWithValue("@precio_proveedor", precio_proveedor)
        cmd.Parameters.AddWithValue("@codigo_venta", codigo_venta)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Producto Agregado Correctamente")
        conn.Close()





    End Sub

    Private Sub SetProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.getProducto' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProductoToolStripMenuItem.Click
        Me.Hide()
        EliminarProducto.Show()
    End Sub
End Class