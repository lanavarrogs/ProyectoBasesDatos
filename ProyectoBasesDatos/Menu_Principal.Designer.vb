﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuienesSomosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuTitulo
        '
        Me.menuTitulo.AutoSize = True
        Me.menuTitulo.BackColor = System.Drawing.Color.Transparent
        Me.menuTitulo.Font = New System.Drawing.Font("Segoe UI", 90.0!)
        Me.menuTitulo.ForeColor = System.Drawing.Color.Maroon
        Me.menuTitulo.Location = New System.Drawing.Point(284, 133)
        Me.menuTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.menuTitulo.Name = "menuTitulo"
        Me.menuTitulo.Size = New System.Drawing.Size(374, 159)
        Me.menuTitulo.TabIndex = 12
        Me.menuTitulo.Text = "Menu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.CompraToolStripMenuItem, Me.ContactanosToolStripMenuItem, Me.VisionToolStripMenuItem, Me.MisionToolStripMenuItem, Me.ValoresToolStripMenuItem, Me.QuienesSomosToolStripMenuItem, Me.VentasToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'ContactanosToolStripMenuItem
        '
        Me.ContactanosToolStripMenuItem.Name = "ContactanosToolStripMenuItem"
        Me.ContactanosToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ContactanosToolStripMenuItem.Text = "Contactanos"
        '
        'VisionToolStripMenuItem
        '
        Me.VisionToolStripMenuItem.Name = "VisionToolStripMenuItem"
        Me.VisionToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VisionToolStripMenuItem.Text = "Vision"
        '
        'MisionToolStripMenuItem
        '
        Me.MisionToolStripMenuItem.Name = "MisionToolStripMenuItem"
        Me.MisionToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MisionToolStripMenuItem.Text = "Mision"
        '
        'ValoresToolStripMenuItem
        '
        Me.ValoresToolStripMenuItem.Name = "ValoresToolStripMenuItem"
        Me.ValoresToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ValoresToolStripMenuItem.Text = "Valores"
        '
        'QuienesSomosToolStripMenuItem
        '
        Me.QuienesSomosToolStripMenuItem.Name = "QuienesSomosToolStripMenuItem"
        Me.QuienesSomosToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.QuienesSomosToolStripMenuItem.Text = "Quienes somos?"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.VentasToolStripMenuItem1.Text = "Vistas"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoBasesDatos.My.Resources.Resources.tienda_ropa_inicio
        Me.ClientSize = New System.Drawing.Size(936, 478)
        Me.Controls.Add(Me.menuTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Principal"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuTitulo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuienesSomosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
End Class
