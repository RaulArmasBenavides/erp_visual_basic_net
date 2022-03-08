Public Class Ingreso
    Private _IdIngreso As Integer
    Private _IdProveedor As Integer
    Private _IdUsuario As Integer
    Private _TipoComprobante As String
    Private _SerieComprobante As String
    Private _NumComprobante As String
    Private _Fecha As Date
    Private _Impuesto As Decimal
    Private _Total As Decimal
    Private _Estado As Boolean

    Public Property IdIngreso As Integer
        Get
            Return _IdIngreso
        End Get
        Set(value As Integer)
            _IdIngreso = value
        End Set
    End Property

    Public Property IdProveedor As Integer
        Get
            Return _IdProveedor
        End Get
        Set(value As Integer)
            _IdProveedor = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property TipoComprobante As String
        Get
            Return _TipoComprobante
        End Get
        Set(value As String)
            _TipoComprobante = value
        End Set
    End Property

    Public Property SerieComprobante As String
        Get
            Return _SerieComprobante
        End Get
        Set(value As String)
            _SerieComprobante = value
        End Set
    End Property

    Public Property NumComprobante As String
        Get
            Return _NumComprobante
        End Get
        Set(value As String)
            _NumComprobante = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Impuesto As Decimal
        Get
            Return _Impuesto
        End Get
        Set(value As Decimal)
            _Impuesto = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
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
