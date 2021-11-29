Imports System.Data.SqlClient
Public Class ComprarProducto
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComprarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.getProducto' Puede moverla o quitarla según sea necesario.
        Me.GetProductoTableAdapter.Fill(Me.TiendaRopaDataSet.getProducto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.index = ListBox1.SelectedIndex
        Me.Hide()
        Comprar.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Index As Int32
        Index = ListBox1.SelectedIndex
        If Index = 0 Then
            PictureBox1.Image = My.Resources.Playera_V1
        ElseIf Index = 1 Then
            PictureBox1.Image = My.Resources.Playera_V2
        ElseIf Index = 2 Then
            PictureBox1.Image = My.Resources.Playera_V3
        ElseIf Index = 3 Then
            PictureBox1.Image = My.Resources.pants_deportivo
        ElseIf Index = 4 Then
            PictureBox1.Image = My.Resources.pants_deportivo2
        ElseIf Index = 5 Then
            PictureBox1.Image = My.Resources.patns_deportivo3
        ElseIf Index = 6 Then
            PictureBox1.Image = My.Resources.gorra_hombre
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub
End Class