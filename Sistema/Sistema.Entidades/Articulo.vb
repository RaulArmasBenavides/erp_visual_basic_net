Public Class Articulo
    Private _IdArticulo As Integer
    Private _IdCategoria As Integer
    Private _Codigo As String
    Private _Nombre As String
    Private _PrecioVenta As Decimal
    Private _Stock As Integer
    Private _Imagen As String
    Private _Descripcion As String
    Private _Estado As Boolean

    Public Property IdArticulo As Integer
        Get
            Return _IdArticulo
        End Get
        Set(value As Integer)
            _IdArticulo = value
        End Set
    End Property

    Public Property IdCategoria As Integer
        Get
            Return _IdCategoria
        End Get
        Set(value As Integer)
            _IdCategoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property PrecioVenta As Decimal
        Get
            Return _PrecioVenta
        End Get
        Set(value As Decimal)
            _PrecioVenta = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(value As String)
            _Imagen = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _Estado
        End Get
        Set(value As Boolean)
            _Estado = value
        End Set
    End Property
End Class
