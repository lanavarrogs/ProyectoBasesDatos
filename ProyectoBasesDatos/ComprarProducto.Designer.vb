﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprarProducto
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TiendaRopaDataSet = New ProyectoBasesDatos.tiendaRopaDataSet()
        Me.GetProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetProductoTableAdapter = New ProyectoBasesDatos.tiendaRopaDataSetTableAdapters.getProductoTableAdapter()
        Me.TableAdapterManager = New ProyectoBasesDatos.tiendaRopaDataSetTableAdapters.TableAdapterManager()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(524, 401)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(503, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comprar"
        Me.Button1.UseVisualStyleBackColor = False
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
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 28
        Me.ListBox1.Items.AddRange(New Object() {"Playera1", "Playera2", "Playera3", "Pants1", "Pants2", "Pants3", "Gorra"})
        Me.ListBox1.Location = New System.Drawing.Point(524, 32)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(503, 284)
        Me.ListBox1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoBasesDatos.My.Resources.Resources.Playera_V1
        Me.PictureBox1.Location = New System.Drawing.Point(35, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(447, 442)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComprarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 514)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ComprarProducto"
        Me.Text = "Compra"
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TiendaRopaDataSet As tiendaRopaDataSet
    Friend WithEvents GetProductoBindingSource As BindingSource
    Friend WithEvents GetProductoTableAdapter As tiendaRopaDataSetTableAdapters.getProductoTableAdapter
    Friend WithEvents TableAdapterManager As tiendaRopaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListBox1 As ListBox
End Class
