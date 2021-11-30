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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'telefonoText
        '
        Me.telefonoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoText.Location = New System.Drawing.Point(773, 204)
        Me.telefonoText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.telefonoText.Name = "telefonoText"
        Me.telefonoText.Size = New System.Drawing.Size(244, 34)
        Me.telefonoText.TabIndex = 19
        '
        'telefonoLabel
        '
        Me.telefonoLabel.AutoSize = True
        Me.telefonoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoLabel.Location = New System.Drawing.Point(768, 163)
        Me.telefonoLabel.Name = "telefonoLabel"
        Me.telefonoLabel.Size = New System.Drawing.Size(86, 28)
        Me.telefonoLabel.TabIndex = 18
        Me.telefonoLabel.Text = "Telefono"
        '
        'apellidoText
        '
        Me.apellidoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoText.Location = New System.Drawing.Point(762, 97)
        Me.apellidoText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.apellidoText.Name = "apellidoText"
        Me.apellidoText.Size = New System.Drawing.Size(244, 34)
        Me.apellidoText.TabIndex = 17
        '
        'apellidoLabel
        '
        Me.apellidoLabel.AutoSize = True
        Me.apellidoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoLabel.Location = New System.Drawing.Point(768, 67)
        Me.apellidoLabel.Name = "apellidoLabel"
        Me.apellidoLabel.Size = New System.Drawing.Size(86, 28)
        Me.apellidoLabel.TabIndex = 16
        Me.apellidoLabel.Text = "Apellido"
        '
        'emailText
        '
        Me.emailText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailText.Location = New System.Drawing.Point(449, 204)
        Me.emailText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(244, 34)
        Me.emailText.TabIndex = 15
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(444, 163)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(59, 28)
        Me.emailLabel.TabIndex = 14
        Me.emailLabel.Text = "Email"
        '
        'nombreText
        '
        Me.nombreText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreText.Location = New System.Drawing.Point(449, 97)
        Me.nombreText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nombreText.Name = "nombreText"
        Me.nombreText.Size = New System.Drawing.Size(244, 34)
        Me.nombreText.TabIndex = 13
        '
        'nombreLabel
        '
        Me.nombreLabel.AutoSize = True
        Me.nombreLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreLabel.Location = New System.Drawing.Point(444, 67)
        Me.nombreLabel.Name = "nombreLabel"
        Me.nombreLabel.Size = New System.Drawing.Size(85, 28)
        Me.nombreLabel.TabIndex = 12
        Me.nombreLabel.Text = "Nombre"
        '
        'comentariosLabel
        '
        Me.comentariosLabel.AutoSize = True
        Me.comentariosLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentariosLabel.Location = New System.Drawing.Point(444, 257)
        Me.comentariosLabel.Name = "comentariosLabel"
        Me.comentariosLabel.Size = New System.Drawing.Size(123, 28)
        Me.comentariosLabel.TabIndex = 20
        Me.comentariosLabel.Text = "Comentarios"
        '
        'comentariosText
        '
        Me.comentariosText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentariosText.Location = New System.Drawing.Point(449, 287)
        Me.comentariosText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comentariosText.Multiline = True
        Me.comentariosText.Name = "comentariosText"
        Me.comentariosText.Size = New System.Drawing.Size(568, 283)
        Me.comentariosText.TabIndex = 21
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'contactanosButton
        '
        Me.contactanosButton.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactanosButton.Location = New System.Drawing.Point(449, 586)
        Me.contactanosButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contactanosButton.Name = "contactanosButton"
        Me.contactanosButton.Size = New System.Drawing.Size(568, 79)
        Me.contactanosButton.TabIndex = 23
        Me.contactanosButton.Text = "Contactanos"
        Me.contactanosButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1499, 28)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Contactanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1499, 676)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Contactanos"
        Me.Text = "Contactanos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
End Class
