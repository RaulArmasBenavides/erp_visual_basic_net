Imports Sistema.Datos
Public Class NRol
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DRol
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
