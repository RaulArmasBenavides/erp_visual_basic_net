

Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Web.Script.Serialization

Public Class OauthHelper


    Public Shared Function GetTokenOauthServerToServer() As String
        Dim jss As New JavaScriptSerializer
        Dim meetToken As String = String.Empty
        Dim account_id As String = CustomXMLReader.GetRegistryValue("AccountIDOauth")
        Dim url As String = "https://zoom.us/oauth/token?grant_type=account_credentials&account_id=" & account_id
        Dim client_id As String = CustomXMLReader.GetRegistryValue("ClientIDOauth")
        Dim client_secret As String = CustomXMLReader.GetRegistryValue("ClientSecretOauth")

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'Skip validation of SSL/TLS certificate
        ServicePointManager.ServerCertificateValidationCallback = Function()
                                                                      Dim nestedFunction = Function(sender As Object, certificate As Object, chain As X509Chain, errors As SslPolicyErrors) True
                                                                      Return True
                                                                  End Function
        ' Create a request object
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        ' Set the Basic Authentication header
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{client_id}:{client_secret}"))
        request.Headers("Authorization") = $"Basic {credentials}"
        'Set the request content type and data
        'Dim postData As String = $"grant_type=account_credential&account_id={account_id}"
        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        'request.ContentType = "application/x-www-form-urlencoded"
        'request.ContentLength = byteArray.Length
        'Write the request data to the request stream
        Using requestStream As Stream = request.GetRequestStream()
            ' requestStream.Write(byteArray, 0, byteArray.Length)
        End Using

        ' Get the response from the server
        Dim response As WebResponse = request.GetResponse()
        Using responseStream As Stream = response.GetResponseStream()
            Using reader As New StreamReader(responseStream)
                Dim responseText As String = reader.ReadToEnd()
                ' Do something with the response text
                Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(responseText)
                meetToken = CStr(jsonDict("access_token"))
            End Using
        End Using
        Return meetToken
    End Function
End Class