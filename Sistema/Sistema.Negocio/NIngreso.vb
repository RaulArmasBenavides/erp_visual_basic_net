Imports Sistema.Entidades
Imports Sistema.Datos
Public Class NIngreso
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DIngreso
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DIngreso
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Datos As New DIngreso
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDetalle(Id)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Anular(Id As Integer) As Boolean
        Try
            Dim Datos As New DIngreso
            Datos.Anular(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Insertar(Obj As Ingreso, Det As DataTable) As Boolean
        Try
            Dim Datos As New DIngreso
            Datos.Insertar(Obj, Det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
