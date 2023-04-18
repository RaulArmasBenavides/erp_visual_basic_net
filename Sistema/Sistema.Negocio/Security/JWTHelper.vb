Imports System.IdentityModel.Tokens.Jwt
Imports System.Web.Script.Serialization
Imports Microsoft.IdentityModel.Tokens

Public Class JWTHelper

    Public Sub New()
    End Sub

    Public Shared Function GetZoomAuthorization() As String
        Dim jss As New JavaScriptSerializer
        Dim tokenHandler As New JwtSecurityTokenHandler()
        Dim now As DateTime = DateTime.UtcNow
        Dim apiSecret As String = CustomXMLReader.GetRegistryValue("apiSecretJWT")
        Dim symmetricKey As Byte() = System.Text.Encoding.ASCII.GetBytes(apiSecret)
        Dim tokenCode As String = "1" 'CustomXMLReader.GetRegistryValue("tokenCode")
        Dim tokenDescriptor As SecurityTokenDescriptor = New SecurityTokenDescriptor()
        tokenDescriptor.Issuer = tokenCode
        tokenDescriptor.Expires = now.AddMinutes(30)
        tokenDescriptor.SigningCredentials = New SigningCredentials(New SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256)
        Dim token As SecurityToken = tokenHandler.CreateToken(tokenDescriptor)
        Dim tokenString As String = tokenHandler.WriteToken(token)
        Return tokenString
    End Function
End Class
