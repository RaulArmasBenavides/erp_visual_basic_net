Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DArticulo
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarVenta(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar_venta", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarCodigo(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar_codigo", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarCodigoVenta(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar_codigo_venta", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Sub Insertar(Obj As Articulo)
        Try
            Dim Comando As New SqlCommand("articulo_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria
            Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta
            Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock
            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
            Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As Articulo)
        Try
            Dim Comando As New SqlCommand("articulo_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Obj.IdArticulo
            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria
            Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta
            Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock
            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
            Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("articulo_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desactivar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("articulo_desactivar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("articulo_activar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
