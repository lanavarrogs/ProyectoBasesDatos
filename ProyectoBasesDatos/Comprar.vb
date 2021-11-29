Imports System.Data.SqlClient
Public Class Comprar
    Private Sub Comprar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Index As Int32
        Index = Module1.index

        If Index = 0 Then
            imageBox.Image = My.Resources.Playera_V1
        ElseIf Index = 1 Then
            imageBox.Image = My.Resources.Playera_V2
        ElseIf Index = 2 Then
            imageBox.Image = My.Resources.Playera_V3
        ElseIf Index = 3 Then
            imageBox.Image = My.Resources.pants_deportivo
        ElseIf Index = 4 Then
            imageBox.Image = My.Resources.pants_deportivo2
        ElseIf Index = 5 Then
            imageBox.Image = My.Resources.patns_deportivo3
        ElseIf Index = 6 Then
            imageBox.Image = My.Resources.gorra_hombre
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection(My.Settings.tiendaRopaConnectionString)
        Dim cmd As New SqlCommand
        Dim codigo_pedido As Int32
        Dim estado As String
        Dim fecha_esperada As String
        Dim fecha_entrega As String
        Dim fecha_pedido As String
        Dim comentarios As String
        Dim codigo_cliente As Int32

        codigo_pedido = Convert.ToInt32(txtCodigoPedido.Text)
        estado = txtEstado.Text
        fecha_esperada = txtFechaEsperada.Text
        fecha_entrega = txtFechaEntrega.Text
        fecha_pedido = txtFechaPedido.Text
        comentarios = txtComentarios.Text
        codigo_cliente = Convert.ToInt32(txtCodigoCliente.Text)

        conn.Open()
        cmd = New SqlCommand("setProducto", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigo_pedido", codigo_pedido)
        cmd.Parameters.AddWithValue("@fecha_pedido", fecha_pedido)
        cmd.Parameters.AddWithValue("@fecha_espearada", fecha_esperada)
        cmd.Parameters.AddWithValue("@fecha_entrega", fecha_entrega)
        cmd.Parameters.AddWithValue("@estado", estado)
        cmd.Parameters.AddWithValue("@comentarios", comentarios)
        cmd.Parameters.AddWithValue("@codigo_cliente", codigo_cliente)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Producto Su compra se realizo Correctamente")
        conn.Close()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub
End Class