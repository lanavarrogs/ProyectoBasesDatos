<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Valores
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
        Me.valoresTitulo = New System.Windows.Forms.Label()
        Me.valoresContenido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'valoresTitulo
        '
        Me.valoresTitulo.AutoSize = True
        Me.valoresTitulo.Font = New System.Drawing.Font("Segoe UI", 54.0!)
        Me.valoresTitulo.Location = New System.Drawing.Point(355, 83)
        Me.valoresTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.valoresTitulo.Name = "valoresTitulo"
        Me.valoresTitulo.Size = New System.Drawing.Size(270, 96)
        Me.valoresTitulo.TabIndex = 12
        Me.valoresTitulo.Text = "Valores"
        '
        'valoresContenido
        '
        Me.valoresContenido.AutoSize = True
        Me.valoresContenido.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.valoresContenido.Location = New System.Drawing.Point(175, 193)
        Me.valoresContenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.valoresContenido.Name = "valoresContenido"
        Me.valoresContenido.Size = New System.Drawing.Size(683, 270)
        Me.valoresContenido.TabIndex = 13
        Me.valoresContenido.Text = "-Nos atrevemos a diseñar el futuro de la moda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Un equipo empoderado, diverso e i" &
    "nclusivo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-El mundo es nuestra comunidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Un futuro justo y sostenible para tod" &
    "os " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Accesibilidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Medio ambiente"
        '
        'Valores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 520)
        Me.Controls.Add(Me.valoresContenido)
        Me.Controls.Add(Me.valoresTitulo)
        Me.Name = "Valores"
        Me.Text = "Valores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valoresTitulo As Label
    Friend WithEvents valoresContenido As Label
End Class
