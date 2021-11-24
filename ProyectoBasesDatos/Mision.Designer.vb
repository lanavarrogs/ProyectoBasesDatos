<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mision
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
        Me.misionTitulo = New System.Windows.Forms.Label()
        Me.visionContenido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'misionTitulo
        '
        Me.misionTitulo.AutoSize = True
        Me.misionTitulo.Font = New System.Drawing.Font("Segoe UI", 54.0!)
        Me.misionTitulo.Location = New System.Drawing.Point(349, 88)
        Me.misionTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.misionTitulo.Name = "misionTitulo"
        Me.misionTitulo.Size = New System.Drawing.Size(253, 96)
        Me.misionTitulo.TabIndex = 11
        Me.misionTitulo.Text = "Mision"
        '
        'visionContenido
        '
        Me.visionContenido.AutoSize = True
        Me.visionContenido.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.visionContenido.Location = New System.Drawing.Point(21, 211)
        Me.visionContenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.visionContenido.Name = "visionContenido"
        Me.visionContenido.Size = New System.Drawing.Size(904, 90)
        Me.visionContenido.TabIndex = 12
        Me.visionContenido.Text = "““Nuestra misión es la de dar la oportunidad al consumidor de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      disfrutar de" &
    "l mundo de la moda a un precio accesible””" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Mision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 505)
        Me.Controls.Add(Me.visionContenido)
        Me.Controls.Add(Me.misionTitulo)
        Me.Name = "Mision"
        Me.Text = "Mision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents misionTitulo As Label
    Friend WithEvents visionContenido As Label
End Class
