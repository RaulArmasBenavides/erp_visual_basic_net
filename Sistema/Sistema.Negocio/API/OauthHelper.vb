

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


    Public Shared Function GetTeamsAuthorization(ByVal crede As AuthDto) As String
        Dim meetToken As String = String.Empty
        Try
            Dim jss As New JavaScriptSerializer
            Dim teamsClientId As String = crede.TeamsClientId 'GetPortalRegistryValueMeetingPlatforms("c6c72552-60f3-4561-b567-ee420bb01c7c") 'TeamsClientId 
            Dim teamsClientSecret As String = crede.Client_secret 'GetPortalRegistryValueMeetingPlatforms("d56d827c-c39f-4573-91b1-4219320dffd7") 'TeamsClientSecret
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
        Dim clientId As String = "101821102064205189688"
        Dim clientSecret As String = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCVHdqNzaYogz90\nzxufGNzsP2sPp2S8TmywEWpruVRs+2AvL6z55915eY/Y1huuJGhHE4+hQTeFA9hT\nXKUJnpv10iC9vUSzcK5Sd7GUBf6MHW505SN61jNL5IxeQoe3gv1alW6AuluYCiIm\nUZ7FmA1Y1HcFrDpsFEE5lQGJbiWL1xzZlhMstS+UIW7ilGbs9MgToQMi5kWtO2OZ\nvMaOZTHzDjwFsRF7S/RfjJ2qZo+QeTFLNj4ABHDDHAwGmGYjl1zuMFlwRmsmeg9u\nnOb2FibeibNm0/haYPQw6z5x7O3gSGEQtyyVaqN0vUdZzHnz4kaygxmj7p6RtNyV\nGaDa2mKHAgMBAAECggEABhCYRoMyOlyYNJ6Fz5M5zQwJRTI4OSZxajnTG72GbwZM\nU677OJDTI7ErhhSzPIJzkUx834ChCvJslntipQED89wPg9gSVsAC/wyqNsyFnVpH\nF08IgeL7ZB9QDDdlgLO9rTT9sROjTQxAdlGEhSHZjR7bFmp6V9H9EyP504ac1VKj\nCpfgbpXF4sFm7Thwii/AGfsoWnTw/YZyzfTFkBba9uq47oihA6EdFNnAw1j6rSR1\n5Momb5WBVSqCW9B3ADbEuMvxa9YHwAe4KAcTdRG1/T3WXY89hiTeW5ChKEcS5TJT\n9+WbVCTHc7fJdCVi84qXhI0NPqUJBGNlM2gAmIoKzQKBgQDNTmVZOpKISU8BBiOf\n9RDlPw9BG551YqpstE39nwSuSj9mZJjNfXHFGoID15kNrF+y4xs3NQJbxUQ8QzUe\nVek1O469pJcwwEZoYpsT34bkQ/V6PlJfkqz4BonSAqB7YPZcvDJQ5trZnKrxOHGO\ntHL6PdpKSL4fboRILSOtoPODNQKBgQC576h9Asdql0q0S9Bo+qXEaStkndiaIHUt\nN5bhcGrVab0Igcd9Whafc0Dm1ujH8SXtgNUJy7vuagyuKlyfkZSEnLfF+rOjRXRR\npE61KDcWhm1EmN2AQKFaSwk8U53HOnwdkU5tvNyQmnAOld6VTA9lH/GU2QaPCi3h\nyXjOoVNqSwKBgHj7GHfjLxQGdvq4fme1BtbAOSH5v3+Wu6zA9zBb82stL30MDIsS\nv+cRPso60uMez2nfsFrw7snbTeFhDT0qDPmkdfHEup8svpCmgpHMZ3W9ojr93Jab\nHTguyioqCB2MPsDY2aGY2B/h1U2+IBSiuxpBNpANm5N0EZlimCKptLV9AoGALpL5\ngVbQ3MJI1CCpc6JVI320gN+JAhJfR5RFFvMxz4NM9nSLo7qNMCOOfkQWyv58oaFD\nu9BsoqutwXKbAN1WdmFLJyxFEwCywkCF9pq8Mcg6VpRz50xJHnTtO082llDwBff/\nzT0hgpcsunqP5pXGxW3a9Y3nNq02EPiGaju+yUECgYEAiIiU1+ekaWZtSj2V6f60\nTVlzyWXWX2izi4rvS+iMhquiWP67AHKzYwsT98sS9fGuSsdkhOeh3J61eF2rb+7Z\nAeox9ZFYoEil2NhwU0RTKXDT/sPN18d9f6tRO2ZvvR/mbXbXxjV8Qnbr10bxSagJ\ndyJPkvykIrdu/2XXenKoNm0="
        Dim scope As String = "https://www.googleapis.com/auth/calendar.events"
        Dim serviceAccountEmail As String = "mytestservicemeeting@amplified-album-299218.iam.gserviceaccount.com"

        Dim postData As String = $"grant_type=client_credentials" &
            $"&client_id={HttpUtility.UrlEncode(clientId)}" &
            $"&client_secret={HttpUtility.UrlEncode(clientSecret)}" &
            $"&scope={HttpUtility.UrlEncode(scope)}" &
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

        ' Parsea la respuesta del token de acceso
        ' Dim tokenObject As JObject = JObject.Parse(responseJson)
        Dim tokenObject As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(responseJson)
        Dim accessToken As String = tokenObject("access_token").ToString()
        Return accessToken
    End Function


    Public Shared Function GetGoogleAuthorizationFile() As String

        Dim credentialsFile As String = "C://credenciales.json"
        Dim scope As String = CalendarService.Scope.Calendar

        Dim credential As ServiceAccountCredential

        Using stream = New FileStream(credentialsFile, FileMode.Open, FileAccess.Read)
            credential = GoogleCredential.FromStream(stream).CreateScoped(scope).UnderlyingCredential
        End Using

        Dim service = New CalendarService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = "VB.NET Google Calendar API"
        })

        Dim accessToken = credential.GetAccessTokenForRequestAsync().Result

        'Console.WriteLine("Token de acceso: {0}", accessToken)
        Return accessToken
    End Function
End Class