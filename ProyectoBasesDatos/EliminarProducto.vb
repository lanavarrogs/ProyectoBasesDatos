Imports System.Data.SqlClient

Public Class EliminarProducto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Index As Int32
        Dim conn As New SqlConnection(My.Settings.tiendaRopaConnectionString)
        Dim cmd

        Index = ListBox1.SelectedIndex
        conn.Open()
        cmd = New SqlCommand("delProducto", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigo_producto", Index + 1)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Elemento Borrado Exitosamente")


        If Index = 0 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 1 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 2 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 3 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 4 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 5 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 6 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 7 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 8 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 9 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 10 Then
            ListBox1.Items.RemoveAt(Index)
        ElseIf Index = 11 Then
            ListBox1.Items.RemoveAt(Index)

        End If


        conn.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index As Int32
        index = ListBox1.SelectedIndex
        If index = 0 Then
            imageBox.Image = My.Resources.Playera_V1
        ElseIf index = 1 Then
            imageBox.Image = My.Resources.Playera_V2
        ElseIf index = 2 Then
            imageBox.Image = My.Resources.Playera_V3
        ElseIf index = 3 Then
            imageBox.Image = My.Resources.pants_deportivo
        ElseIf index = 4 Then
            imageBox.Image = My.Resources.pants_deportivo2
        ElseIf index = 5 Then
            imageBox.Image = My.Resources.patns_deportivo3
        ElseIf index = 6 Then
            imageBox.Image = My.Resources.gorra_hombre
        End If

    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Me.Hide()
        Productos.Show()
    End Sub
    Private Sub SetProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetProductoToolStripMenuItem.Click
        Me.Hide()

    End Sub
End Class