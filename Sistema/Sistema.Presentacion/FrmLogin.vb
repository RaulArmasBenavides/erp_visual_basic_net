Public Class FrmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class