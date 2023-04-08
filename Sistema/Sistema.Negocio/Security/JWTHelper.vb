Imports System.IdentityModel.Tokens.Jwt
Imports System.Web.Script.Serialization
Imports Microsoft.IdentityModel.Tokens

Public Class JWTHelper
    Public Shared Function GetZoomAuthorization() As String
        Dim jss As New JavaScriptSerializer
        Dim tokenHandler As New JwtSecurityTokenHandler()
        Dim now As DateTime = DateTime.UtcNow
        Dim apiSecret As String = "eJ6utDrXOqSrudO68B0P2j0BzRUunVW2OK8z" 'GetPortalRegistryValueMeetingPlatforms("14d76a01-59a5-4638-bd2c-9df83f1ec844") 'Organization API secret
        Dim symmetricKey As Byte() = System.Text.Encoding.ASCII.GetBytes(apiSecret)
        Dim tokenCode As String = "1" 'GetPortalRegistryValueMeetingPlatforms("33858c10-ed79-4065-9e3b-639cb5693054") ' Organization  Token COde
        Dim tokenDescriptor As SecurityTokenDescriptor = New SecurityTokenDescriptor()
        tokenDescriptor.Issuer = tokenCode
        tokenDescriptor.Expires = now.AddSeconds(30)
        tokenDescriptor.SigningCredentials = New SigningCredentials(New SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256)
        Dim token As SecurityToken = tokenHandler.CreateToken(tokenDescriptor)
        Dim tokenString As String = tokenHandler.WriteToken(token)
        Return tokenString
    End Function
End Class
