<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDimensiones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidadStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecioProveedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TiendaRopaDataSet = New ProyectoBasesDatos.tiendaRopaDataSet()
        Me.GetProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductoTableAdapter = New ProyectoBasesDatos.tiendaRopaDataSetTableAdapters.getProductoTableAdapter()
        Me.TableAdapterManager = New ProyectoBasesDatos.tiendaRopaDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Producto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Location = New System.Drawing.Point(21, 68)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(184, 29)
        Me.txtIdProducto.TabIndex = 1
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(21, 143)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(184, 29)
        Me.txtNombreProducto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Producto"
        '
        'txtGama
        '
        Me.txtGama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGama.Location = New System.Drawing.Point(21, 218)
        Me.txtGama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGama.Name = "txtGama"
        Me.txtGama.Size = New System.Drawing.Size(184, 29)
        Me.txtGama.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gama"
        '
        'txtDimensiones
        '
        Me.txtDimensiones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimensiones.Location = New System.Drawing.Point(22, 304)
        Me.txtDimensiones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDimensiones.Name = "txtDimensiones"
        Me.txtDimensiones.Size = New System.Drawing.Size(184, 29)
        Me.txtDimensiones.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dimensiones"
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(264, 68)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(184, 29)
        Me.txtProveedor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Proveedor"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(264, 143)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(184, 29)
        Me.txtDescripcion.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 110)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descripcion"
        '
        'txtCantidadStock
        '
        Me.txtCantidadStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadStock.Location = New System.Drawing.Point(264, 218)
        Me.txtCantidadStock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadStock.Name = "txtCantidadStock"
        Me.txtCantidadStock.Size = New System.Drawing.Size(184, 29)
        Me.txtCantidadStock.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 185)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad_Stock"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.Location = New System.Drawing.Point(264, 304)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(184, 29)
        Me.txtPrecioVenta.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(260, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio Venta"
        '
        'txtPrecioProveedor
        '
        Me.txtPrecioProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProveedor.Location = New System.Drawing.Point(483, 68)
        Me.txtPrecioProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioProveedor.Name = "txtPrecioProveedor"
        Me.txtPrecioProveedor.Size = New System.Drawing.Size(184, 29)
        Me.txtPrecioProveedor.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(479, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Precio Proveedor"
        '
        'txtCodigoVenta
        '
        Me.txtCodigoVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoVenta.Location = New System.Drawing.Point(483, 143)
        Me.txtCodigoVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoVenta.Name = "txtCodigoVenta"
        Me.txtCodigoVenta.Size = New System.Drawing.Size(184, 29)
        Me.txtCodigoVenta.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(479, 110)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Codigo de Venta"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(251, 380)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 64)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Agregar Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TiendaRopaDataSet
        '
        Me.TiendaRopaDataSet.DataSetName = "tiendaRopaDataSet"
        Me.TiendaRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetProductoBindingSource
        '
        Me.GetProductoBindingSource.DataMember = "getProducto"
        Me.GetProductoBindingSource.DataSource = Me.TiendaRopaDataSet
        '
        'GetProductoTableAdapter
        '
        Me.GetProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.detalle_pedidoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.pagoTableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoBasesDatos.tiendaRopaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuiToolStripMenuItem
        '
        Me.MenuiToolStripMenuItem.Name = "MenuiToolStripMenuItem"
        Me.MenuiToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuiToolStripMenuItem.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoBasesDatos.My.Resources.Resources.sidebar
        Me.PictureBox1.Location = New System.Drawing.Point(720, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'SetProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 454)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodigoVenta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecioProveedor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCantidadStock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDimensiones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SetProducto"
        Me.Text = "Dimensiones"
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDimensiones As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidadStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecioProveedor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigoVenta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TiendaRopaDataSet As tiendaRopaDataSet
    Friend WithEvents GetProductoBindingSource As BindingSource
    Friend WithEvents GetProductoTableAdapter As tiendaRopaDataSetTableAdapters.getProductoTableAdapter
    Friend WithEvents TableAdapterManager As tiendaRopaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuiToolStripMenuItem As ToolStripMenuItem
End Class
