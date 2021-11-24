<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contactanos
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
        Me.components = New System.ComponentModel.Container()
        Me.telefonoText = New System.Windows.Forms.TextBox()
        Me.telefonoLabel = New System.Windows.Forms.Label()
        Me.apellidoText = New System.Windows.Forms.TextBox()
        Me.apellidoLabel = New System.Windows.Forms.Label()
        Me.emailText = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.nombreText = New System.Windows.Forms.TextBox()
        Me.nombreLabel = New System.Windows.Forms.Label()
        Me.comentariosLabel = New System.Windows.Forms.Label()
        Me.comentariosText = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contactanosButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'telefonoText
        '
        Me.telefonoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoText.Location = New System.Drawing.Point(279, 154)
        Me.telefonoText.Margin = New System.Windows.Forms.Padding(2)
        Me.telefonoText.Name = "telefonoText"
        Me.telefonoText.Size = New System.Drawing.Size(184, 29)
        Me.telefonoText.TabIndex = 19
        '
        'telefonoLabel
        '
        Me.telefonoLabel.AutoSize = True
        Me.telefonoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoLabel.Location = New System.Drawing.Point(275, 121)
        Me.telefonoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.telefonoLabel.Name = "telefonoLabel"
        Me.telefonoLabel.Size = New System.Drawing.Size(68, 21)
        Me.telefonoLabel.TabIndex = 18
        Me.telefonoLabel.Text = "Telefono"
        '
        'apellidoText
        '
        Me.apellidoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoText.Location = New System.Drawing.Point(279, 79)
        Me.apellidoText.Margin = New System.Windows.Forms.Padding(2)
        Me.apellidoText.Name = "apellidoText"
        Me.apellidoText.Size = New System.Drawing.Size(184, 29)
        Me.apellidoText.TabIndex = 17
        '
        'apellidoLabel
        '
        Me.apellidoLabel.AutoSize = True
        Me.apellidoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoLabel.Location = New System.Drawing.Point(275, 47)
        Me.apellidoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.apellidoLabel.Name = "apellidoLabel"
        Me.apellidoLabel.Size = New System.Drawing.Size(67, 21)
        Me.apellidoLabel.TabIndex = 16
        Me.apellidoLabel.Text = "Apellido"
        '
        'emailText
        '
        Me.emailText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailText.Location = New System.Drawing.Point(36, 154)
        Me.emailText.Margin = New System.Windows.Forms.Padding(2)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(184, 29)
        Me.emailText.TabIndex = 15
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(32, 121)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(48, 21)
        Me.emailLabel.TabIndex = 14
        Me.emailLabel.Text = "Email"
        '
        'nombreText
        '
        Me.nombreText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreText.Location = New System.Drawing.Point(36, 79)
        Me.nombreText.Margin = New System.Windows.Forms.Padding(2)
        Me.nombreText.Name = "nombreText"
        Me.nombreText.Size = New System.Drawing.Size(184, 29)
        Me.nombreText.TabIndex = 13
        '
        'nombreLabel
        '
        Me.nombreLabel.AutoSize = True
        Me.nombreLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreLabel.Location = New System.Drawing.Point(32, 47)
        Me.nombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nombreLabel.Name = "nombreLabel"
        Me.nombreLabel.Size = New System.Drawing.Size(68, 21)
        Me.nombreLabel.TabIndex = 12
        Me.nombreLabel.Text = "Nombre"
        '
        'comentariosLabel
        '
        Me.comentariosLabel.AutoSize = True
        Me.comentariosLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentariosLabel.Location = New System.Drawing.Point(32, 220)
        Me.comentariosLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.comentariosLabel.Name = "comentariosLabel"
        Me.comentariosLabel.Size = New System.Drawing.Size(99, 21)
        Me.comentariosLabel.TabIndex = 20
        Me.comentariosLabel.Text = "Comentarios"
        '
        'comentariosText
        '
        Me.comentariosText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentariosText.Location = New System.Drawing.Point(36, 258)
        Me.comentariosText.Margin = New System.Windows.Forms.Padding(2)
        Me.comentariosText.Multiline = True
        Me.comentariosText.Name = "comentariosText"
        Me.comentariosText.Size = New System.Drawing.Size(427, 231)
        Me.comentariosText.TabIndex = 21
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'contactanosButton
        '
        Me.contactanosButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactanosButton.Location = New System.Drawing.Point(467, 425)
        Me.contactanosButton.Margin = New System.Windows.Forms.Padding(2)
        Me.contactanosButton.Name = "contactanosButton"
        Me.contactanosButton.Size = New System.Drawing.Size(288, 64)
        Me.contactanosButton.TabIndex = 23
        Me.contactanosButton.Text = "Contactanos"
        Me.contactanosButton.UseVisualStyleBackColor = True
        '
        'Contactanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 549)
        Me.Controls.Add(Me.contactanosButton)
        Me.Controls.Add(Me.comentariosText)
        Me.Controls.Add(Me.comentariosLabel)
        Me.Controls.Add(Me.telefonoText)
        Me.Controls.Add(Me.telefonoLabel)
        Me.Controls.Add(Me.apellidoText)
        Me.Controls.Add(Me.apellidoLabel)
        Me.Controls.Add(Me.emailText)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.nombreText)
        Me.Controls.Add(Me.nombreLabel)
        Me.Name = "Contactanos"
        Me.Text = "Contactanos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents telefonoText As TextBox
    Friend WithEvents telefonoLabel As Label
    Friend WithEvents apellidoText As TextBox
    Friend WithEvents apellidoLabel As Label
    Friend WithEvents emailText As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents nombreText As TextBox
    Friend WithEvents nombreLabel As Label
    Friend WithEvents comentariosLabel As Label
    Friend WithEvents comentariosText As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents contactanosButton As Button
End Class
