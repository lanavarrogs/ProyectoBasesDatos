Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String
        Dim password As String

        username = UsernameTextBox.Text
        password = PasswordTextBox.Text

        Dim conn As New SqlConnection(My.Settings.tiendaRopaConnectionString)
        Dim cmd As New SqlCommand
        conn.Open()
        cmd = New SqlCommand("SELECT * FROM cliente WHERE id_cliente = " + username, conn)


        If username = "administrator" And password = "u1*Dd&FLQNsH" Then
            Me.Hide()
            SetProducto.Show()
        ElseIf username = "cliente" And password = "password" Then
            Me.Hide()
            ComprarProducto.Show()
        Else
            MessageBox.Show("Usuario o contrase�a incorrecta")
        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
