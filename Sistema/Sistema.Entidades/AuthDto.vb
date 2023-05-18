Public Class AuthDto


    Private _teamsClientId As String
    Public Property TeamsClientId() As String
        Get
            Return _teamsClientId
        End Get
        Set(ByVal value As String)
            _teamsClientId = value
        End Set
    End Property


    Private _client_secret As String
    Public Property Client_secret() As String
        Get
            Return _client_secret
        End Get
        Set(ByVal value As String)
            _client_secret = value
        End Set
    End Property
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _usuarioEmail As String
    Public Property UsuarioEmail() As String
        Get
            Return _usuarioEmail
        End Get
        Set(ByVal value As String)
            _usuarioEmail = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

End Class
