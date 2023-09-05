
Option Strict On
Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Web
Imports System.Web.Script.Serialization
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Calendar.v3
Imports Google.Apis.Services
Imports Sistema.Entidades

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
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{client_id}:{client_secret}"))
        request.Headers("Authorization") = $"Basic {credentials}"
        ' Get the response from the server
        Dim response As WebResponse = request.GetResponse()
        Using responseStream As Stream = response.GetResponseStream()
            Using reader As New StreamReader(responseStream)
                Dim responseText As String = reader.ReadToEnd()
                Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(responseText)
                meetToken = CStr(jsonDict("access_token"))
            End Using
        End Using
        Return meetToken
    End Function


    Public Shared Function GetTeamsAuthorization(ByVal crede As AuthDto) As String
        Dim meetToken As String = String.Empty
        Try
            Dim jss As New JavaScriptSerializer
            Dim teamsClientId As String = crede.TeamsClientId
            Dim teamsClientSecret As String = crede.Client_secret
            Dim userEmail As String = crede.UsuarioEmail
            Dim userPassword As String = crede.Password
            Dim requestTeams As WebRequest = WebRequest.Create("https://login.microsoftonline.com/common/oauth2/token")
            requestTeams.Method = WebRequestMethods.Http.Post
            requestTeams.ContentType = "application/x-www-form-urlencoded"

            Using streamWriter As New StreamWriter(requestTeams.GetRequestStream())
                Dim dataTeams As String = $"grant_type=password
                                                &client_id={HttpUtility.UrlEncode(teamsClientId)}
                                                &client_secret={HttpUtility.UrlEncode(teamsClientSecret)}
                                                &resource=https://graph.microsoft.com
                                                &username={HttpUtility.UrlEncode(userEmail)}
                                                &password={HttpUtility.UrlEncode(userPassword)}"

                streamWriter.Write(dataTeams)
            End Using

            Dim responseTeams As WebResponse = requestTeams.GetResponse()
            Dim data As Stream = responseTeams.GetResponseStream()
            Dim streamReader As New StreamReader(data)
            Dim content As String = streamReader.ReadToEnd()
            Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(content)
            meetToken = CStr(jsonDict("access_token"))

        Catch ex As Exception
            meetToken = "ERROR -Teams" & ex.Message
        End Try
        Return meetToken
    End Function


    Public Shared Function GetTeamsAuthorizationWOAsync(ByVal crede As AuthDto) As String
        Dim meetToken As String = String.Empty
        Try
            Dim jss As New JavaScriptSerializer
            Dim teamsClientId As String = crede.TeamsClientId '"" 'GetPortalRegistryValueMeetingPlatforms("c6c72552-60f3-4561-b567-ee420bb01c7c") 'TeamsClientId 
            Dim teamsClientSecret As String = crede.Client_secret '"" 'GetPortalRegistryValueMeetingPlatforms("d56d827c-c39f-4573-91b1-4219320dffd7") 'TeamsClientSecret
            Dim requestTeams As WebRequest = WebRequest.Create("https://login.microsoftonline.com/65271f45-ca21-4647-91d9-5f411bb6826a/oauth2/token")
            requestTeams.Method = WebRequestMethods.Http.Post
            requestTeams.ContentType = "application/x-www-form-urlencoded"

            Using streamWriter As New StreamWriter(requestTeams.GetRequestStream())
                Dim dataTeams As String = $"grant_type=client_credentials
                                                &client_id={HttpUtility.UrlEncode(teamsClientId)}
                                                &client_secret={HttpUtility.UrlEncode(teamsClientSecret)}
                                                &resource=https://graph.microsoft.com"

                streamWriter.Write(dataTeams)
            End Using

            Dim responseTeams As WebResponse = requestTeams.GetResponse()
            Dim data As Stream = responseTeams.GetResponseStream()
            Dim streamReader As New StreamReader(data)
            Dim content As String = streamReader.ReadToEnd()
            Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(content)
            meetToken = CStr(jsonDict("access_token"))

        Catch ex As Exception
            meetToken = "ERROR -Teams" & ex.Message
        End Try
        Return meetToken
    End Function


    Public Shared Function GetGoogleAuthorization() As String
        Dim jss As New JavaScriptSerializer
        Dim tokenEndpoint As String = "https://oauth2.googleapis.com/token"
        Dim clientId As String = "104109131828044807705"
        Dim clientSecret As String = "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDVznEPem83epAY\ng7CXv0ThJoVDOYvP9iat2xi7WmnAvqj9UETolbmfUicMbwiXwlQpVXat6qrpJbIO\nnxU6s5Sa7tAdZH1rNFCOZkYtpbOovfrbYPcqLLHDNLMPgOiwCKUR4/4NDngKCG+r\nq/baoTToN2bFSwxpALG+4SVQcnttvPlGpcrYr5VVkiMMGqHUHWDFg+jO3mqq8G21\ne8SdUm2uEaoVnC23nwqglLk+DPY03StNDIVcNlYa2JOaeh121aiuM2zXUFB99zEH\nqmELNgqHM8ADO48dOoHf1SdIhQni1KAyQQjwGDcU0KhVf1ZxI8zJwpK/nJLOoSH8\n12VUalNhAgMBAAECggEAFRURaG+P8mZDOauYmOn7EoFwIAgXXXb96uRBDM5WQbN7\nKdlFpjKHVmqtH4h+TiqTDm1XMcCDQFCffVoZ54soItvcCR3s0QqcS+JRVrRxYfjz\nuLiXvqCgGanDY0q4hw0fK8OxvBtaYlDhJAolofrF4wT9fQRQsbToEfSU75kOSyxq\nOwYbvkAL6hOuB+Y7KTY3SHw8a4xACuiQLthQB7qIN4fstYtoBdCE0iLEaEf5THu3\nZpbF7cGFK+GvUbbPIwdeM8sxnLwjcohKBJJU/n7you5V0TDGwYqMizDyusIEDboq\nctmzwjTpopAvKW5TGyidwqj7skBn7m16hib9vDdSsQKBgQDsUyWdzQpheXLS3lFZ\nGdfK4npy1RRY0iQ1DJulV8eAqpiirfePri18nJmqVS+cZAiX8aRYaep27k2MbI/E\n4+gNBp3OZosFLPZl+6/HTDmTqqPUpIHCXOLnMg35CkfXR4DPmHWbTGiRpRFETjkY\nE+7J+VQzKM2l99GYBHkZOI/KyQKBgQDnm1q/0tEFEezcEKi6dCigmsTkPet7KodO\n1m665XRtRgUTvv0kwfeV7q8vO7k1jNnZVY6Pvo09J2EJ1mlRJIggOAD/jIA9E/yz\ncSQVnjomJsWCHN9gX26+6CaOXrGNsOsqaqCcQnR6Yt6/KtbJRg2qutnu1h5Qza7e\nX74FTyR32QKBgFK5hFhptvGKDtyrv/QdrMEzaEOcPSQeY1hCkpVdVdO/Y/DGTvt3\nsCqHsu7CJQlspulxR+M/KDj7kB/QvL7iPI+aulDO6mkkZRgr80sjbqA3QmQkNdvw\noejmR6fepmlAeWGx77EuHQimrJWpgCjiiVsgMQ47gUlQp4i8QBvJBeSpAoGAHnsK\noW4sRf+K7ZdfrVI2OpTDzsn7YLVDI3QDFKO4A92QM34SMLE6VUgZVB0HDe4giYLC\nBVbtnZu+IJ5QM/ab16mnL/qcse0cd70vI400V+sIWUxVdYh5ubQxxtDdiyk6edWY\nl5gDXkv+xqfrpoeKqup2XgFd8gJvviJZjrdQtFkCgYAmE3eT2JvL9u0qDMZBZJb9\nTE+2xVgdghyiBTDn5tzeq0l1Od07NG9C1vUBQ4YJTp8EaG3B2JwDeKCcwzgLFhaY\nqOEa/Hv5ARxsr6XsAQOkNFugkLdSobV7CHdRy+ROrgYZvPJQnwXidI1Qm7JcD878\nxPpXSJ0ZmJkeOXglgwMiNQ=="
        Dim scope As String = "https://www.googleapis.com/auth/calendar.events"
        Dim serviceAccountEmail As String = "bw2serviceaccount@projectappointments.iam.gserviceaccount.com"

        Dim postData As String = $"grant_type=client_credentials" &
            $"&client_id={HttpUtility.UrlEncode(clientId)}" &
            $"&client_secret={HttpUtility.UrlEncode(clientSecret)}" &
            $"&subject={HttpUtility.UrlEncode(serviceAccountEmail)}"

        Dim request As WebRequest = WebRequest.Create(tokenEndpoint)
        request.Method = "POST"
        request.Headers.Set("MethodName", "GetToken")
        request.ContentType = "text/plain"
        request.ContentLength = 0
        Dim postDataBytes As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentLength = postDataBytes.Length
        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postDataBytes, 0, postDataBytes.Length)
        End Using
        Dim response As WebResponse = request.GetResponse()
        Dim responseStream As Stream = response.GetResponseStream()
        Dim responseReader As New StreamReader(responseStream)
        Dim responseJson As String = responseReader.ReadToEnd()
        Dim tokenObject As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(responseJson)
        Dim accessToken As String = tokenObject("access_token").ToString()
        Return accessToken
    End Function


    Public Shared Function GetGoogleAuthorizationFile() As String

        Dim credentialsFile As String = "C://credenciales2.json"
        Dim scope As String = CalendarService.Scope.Calendar
        Dim credential As ServiceAccountCredential
        Using stream = New FileStream(credentialsFile, FileMode.Open, FileAccess.Read)
            credential = CType(GoogleCredential.FromStream(stream).CreateScoped(scope).UnderlyingCredential, ServiceAccountCredential)
        End Using
        Dim service = New CalendarService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = "VB.NET Google Calendar API"
        })
        Dim accessToken = credential.GetAccessTokenForRequestAsync().Result
        Return accessToken
    End Function



End Class