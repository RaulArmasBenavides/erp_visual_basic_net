Public Class Usuario
    Private _IdUsuario As Integer
    Private _IdRol As Integer
    Private _Nombre As String
    Private _TipoDocumento As String
    Private _NumDocumento As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _Clave As String
    Private _Estado As Boolean
    Private _Rol As String

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _IdRol
        End Get
        Set(value As Integer)
            _IdRol = value
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

    Public Property TipoDocumento As String
        Get
            Return _TipoDocumento
        End Get
        Set(value As String)
            _TipoDocumento = value
        End Set
    End Property

    Public Property NumDocumento As String
        Get
            Return _NumDocumento
        End Get
        Set(value As String)
            _NumDocumento = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
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
    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property
End Class
