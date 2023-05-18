Public Class FrmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        Try
            Login()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub Login()
        Dim Email As String, Clave As String
        Dim Obj As New Entidades.Usuario
        Dim Neg As New Negocio.NUsuario
        Email = TxtEmail.Text.Trim()
        Clave = TxtClave.Text.Trim()
        Obj = Neg.Login(Email, Clave)
        If (Obj Is Nothing) Then
            MsgBox("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
        Else
            If (Obj.Estado = False) Then
                MsgBox("El usuario no esta activo", vbOKOnly + vbCritical, "Usuario no tiene acceso")
            Else
                Me.Hide()
                FrmPrincipal.IdUsuario = Obj.IdUsuario
                Variables.IdUsuario = Obj.IdUsuario
                FrmPrincipal.IdRol = Obj.IdRol
                FrmPrincipal.Rol = Obj.Rol
                FrmPrincipal.Nombre = Obj.Nombre
                FrmPrincipal.Show()
            End If
        End If
    End Sub

    Private Sub TxtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEmail.Text = "raul.armas@unmsm.edu.pe"
        TxtClave.Text = "123"
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged

    End Sub
End Class