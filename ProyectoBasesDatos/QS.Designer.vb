<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QS))
        Me.qsTitulo = New System.Windows.Forms.Label()
        Me.qsContenido = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'qsTitulo
        '
        Me.qsTitulo.AutoSize = True
        Me.qsTitulo.BackColor = System.Drawing.Color.Transparent
        Me.qsTitulo.Font = New System.Drawing.Font("Segoe UI", 54.0!)
        Me.qsTitulo.ForeColor = System.Drawing.Color.Maroon
        Me.qsTitulo.Location = New System.Drawing.Point(11, 98)
        Me.qsTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.qsTitulo.Name = "qsTitulo"
        Me.qsTitulo.Size = New System.Drawing.Size(632, 96)
        Me.qsTitulo.TabIndex = 13
        Me.qsTitulo.Text = "¿ Quiénes somos ?"
        '
        'qsContenido
        '
        Me.qsContenido.AutoSize = True
        Me.qsContenido.BackColor = System.Drawing.Color.Transparent
        Me.qsContenido.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.qsContenido.ForeColor = System.Drawing.Color.Maroon
        Me.qsContenido.Location = New System.Drawing.Point(33, 194)
        Me.qsContenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.qsContenido.Name = "qsContenido"
        Me.qsContenido.Size = New System.Drawing.Size(787, 315)
        Me.qsContenido.TabIndex = 14
        Me.qsContenido.Text = resources.GetString("qsContenido.Text")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(991, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'QS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoBasesDatos.My.Resources.Resources.tienda_ropa
        Me.ClientSize = New System.Drawing.Size(991, 518)
        Me.Controls.Add(Me.qsContenido)
        Me.Controls.Add(Me.qsTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "QS"
        Me.Text = "QS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents qsTitulo As Label
    Friend WithEvents qsContenido As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
End Class
