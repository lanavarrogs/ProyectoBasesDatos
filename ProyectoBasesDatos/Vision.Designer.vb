<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vision))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.visionContenido = New System.Windows.Forms.Label()
        Me.visionTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'visionContenido
        '
        Me.visionContenido.AutoSize = True
        Me.visionContenido.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.visionContenido.Location = New System.Drawing.Point(30, 199)
        Me.visionContenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.visionContenido.Name = "visionContenido"
        Me.visionContenido.Size = New System.Drawing.Size(894, 180)
        Me.visionContenido.TabIndex = 9
        Me.visionContenido.Text = resources.GetString("visionContenido.Text")
        '
        'visionTitulo
        '
        Me.visionTitulo.AutoSize = True
        Me.visionTitulo.Font = New System.Drawing.Font("Segoe UI", 54.0!)
        Me.visionTitulo.Location = New System.Drawing.Point(341, 74)
        Me.visionTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.visionTitulo.Name = "visionTitulo"
        Me.visionTitulo.Size = New System.Drawing.Size(233, 96)
        Me.visionTitulo.TabIndex = 10
        Me.visionTitulo.Text = "Vision"
        '
        'Vision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 505)
        Me.Controls.Add(Me.visionTitulo)
        Me.Controls.Add(Me.visionContenido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Vision"
        Me.Text = "Vision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents visionContenido As Label
    Friend WithEvents visionTitulo As Label
End Class
