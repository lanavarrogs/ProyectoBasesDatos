<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetProyecto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDimensiones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecioProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidadStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Producto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(57, 93)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(165, 22)
        Me.txtIdProducto.TabIndex = 1
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(57, 196)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(165, 22)
        Me.txtNombreProducto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Producto"
        '
        'txtGama
        '
        Me.txtGama.Location = New System.Drawing.Point(57, 296)
        Me.txtGama.Name = "txtGama"
        Me.txtGama.Size = New System.Drawing.Size(165, 22)
        Me.txtGama.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gama"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(359, 93)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(165, 22)
        Me.txtProveedor.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Proveedor"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(359, 196)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(165, 22)
        Me.txtDescripcion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descripcion"
        '
        'txtDimensiones
        '
        Me.txtDimensiones.Location = New System.Drawing.Point(57, 398)
        Me.txtDimensiones.Name = "txtDimensiones"
        Me.txtDimensiones.Size = New System.Drawing.Size(165, 22)
        Me.txtDimensiones.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dimensiones"
        '
        'txtPrecioProveedor
        '
        Me.txtPrecioProveedor.Location = New System.Drawing.Point(617, 93)
        Me.txtPrecioProveedor.Name = "txtPrecioProveedor"
        Me.txtPrecioProveedor.Size = New System.Drawing.Size(165, 22)
        Me.txtPrecioProveedor.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(612, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Precio Proveedor"
        '
        'txtCodigoVenta
        '
        Me.txtCodigoVenta.Location = New System.Drawing.Point(617, 223)
        Me.txtCodigoVenta.Name = "txtCodigoVenta"
        Me.txtCodigoVenta.Size = New System.Drawing.Size(165, 22)
        Me.txtCodigoVenta.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(612, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Codigo Venta"
        '
        'txtCantidadStock
        '
        Me.txtCantidadStock.Location = New System.Drawing.Point(359, 296)
        Me.txtCantidadStock.Name = "txtCantidadStock"
        Me.txtCantidadStock.Size = New System.Drawing.Size(165, 22)
        Me.txtCantidadStock.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(354, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 28)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cantidad_Stock"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(359, 398)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(165, 22)
        Me.txtPrecioVenta.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(354, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 28)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio Venta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoBasesDatos.My.Resources.Resources.sidebar
        Me.PictureBox1.Location = New System.Drawing.Point(840, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(607, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 75)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Agregar Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.EliminarProductosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1186, 28)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'EliminarProductosToolStripMenuItem
        '
        Me.EliminarProductosToolStripMenuItem.Name = "EliminarProductosToolStripMenuItem"
        Me.EliminarProductosToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.EliminarProductosToolStripMenuItem.Text = "Eliminar Productos"
        '
        'SetProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1186, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantidadStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodigoVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecioProveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDimensiones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SetProyecto"
        Me.Text = "SetProyecto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDimensiones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodigoVenta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCantidadStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductosToolStripMenuItem As ToolStripMenuItem
End Class
