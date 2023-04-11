

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

    Public Sub OauthHelper()

    End Sub
    Public Shared Function GetTokenOauthServerToServerold()
        Dim meetToken As String = String.Empty
        Dim jss As New JavaScriptSerializer
        Dim requestTeams As WebRequest = WebRequest.Create("https://zoom.us/oauth/token?grant_type=account_credentials&account_id=ScUmscKsQDGrTDQPwViSAA")
        requestTeams.Method = WebRequestMethods.Http.Post
        'requestTeams.ContentType = "application/multipart/form-data"
        ' requestTeams.Headers.Add("Content-Type", "multipart/form-data; boundary=---011000010111000001101001")
        requestTeams.Headers.Add("Authorization", "Basic dFE5U2RQZUlTcmVhTkx0M2diUUtNdzo1UHlWMVptR3Nqa256MDFSTHA0elRsRnppMWVsTDBCYg==")
        requestTeams.Headers.Add("Cookie", "cred=5AFB3F5CEC6CE5C3ED333F96BAF8B6AB; _zm_page_auth=us02_c_WG2m-6MBR9a4F28zD5s9TA; _zm_ssid=us02_c_8b-HQ4dwS8SDvWoR6h336w; _zm_mtk_guid=fdc03919193e4a29968215aeac556452; TS01f92dc5=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8; TS018dd1ba=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8")
        '{"cookie", "cred=5AFB3F5CEC6CE5C3ED333F96BAF8B6AB; _zm_page_auth=us02_c_WG2m-6MBR9a4F28zD5s9TA; _zm_ssid=us02_c_8b-HQ4dwS8SDvWoR6h336w; _zm_mtk_guid=fdc03919193e4a29968215aeac556452; TS01f92dc5=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8; TS018dd1ba=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8"},
        '{"Authorization", "Basic dFE5U2RQZUlTcmVhTkx0M2diUUtNdzo1UHlWMVptR3Nqa256MDFSTHA0elRsRnppMWVsTDBCYg=="},

        'Using streamWriter As New StreamWriter(requestTeams.GetRequestStream())
        '    Dim dataTeams As String = $"grant_type=password
        '                                        &client_id={HttpUtility.UrlEncode(teamsClientId)}
        '                                        &client_secret={HttpUtility.UrlEncode(teamsClientSecret)}
        '                                        &resource=https://graph.microsoft.com
        '                                        &username={HttpUtility.UrlEncode(userEmail)}
        '                                        &password={HttpUtility.UrlEncode(userPassword)}"

        '    streamWriter.Write(dataTeams)
        'End Using

        Dim responseTeams As WebResponse = requestTeams.GetResponse()
        Dim data As Stream = responseTeams.GetResponseStream()
        Dim streamReader As New StreamReader(data)
        Dim content As String = streamReader.ReadToEnd()
        Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(content)
        meetToken = CStr(jsonDict("access_token"))

        Return meetToken

    End Function

    'old
    'Public Shared Async Function GetTokenOauthServerToServer() As Task(Of String)
    '    Dim clientHandler As HttpClientHandler = New HttpClientHandler
    '    Dim jss As New JavaScriptSerializer
    '    Dim meetToken As String = String.Empty
    '    clientHandler.UseCookies = False
    '    Dim request As HttpRequestMessage = New HttpRequestMessage
    '    request.Method = HttpMethod.Post
    '    request.RequestUri = New Uri("https://zoom.us/oauth/token?grant_type=account_credentials&account_id=ScUmscKsQDGrTDQPwViSAA")
    '    request.Headers.Add("cookie", "cred=5AFB3F5CEC6CE5C3ED333F96BAF8B6AB; _zm_page_auth=us02_c_WG2m-6MBR9a4F28zD5s9TA; _zm_ssid=us02_c_8b-HQ4dwS8SDvWoR6h336w; _zm_mtk_guid=fdc03919193e4a29968215aeac556452; TS01f92dc5=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8; TS018dd1ba=01377c1b733f87cd5abaddfa61275a6ef2fa07ae6790600e271b3204430c8fb30376b34fc3143fbdcf716f018393de090793aec3a8")
    '    request.Headers.Add("Authorization", "Basic dFE5U2RQZUlTcmVhTkx0M2diUUtNdzo1UHlWMVptR3Nqa256MDFSTHA0elRsRnppMWVsTDBCYg==")
    '    Using client As New HttpClient(clientHandler)
    '        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    '        ServicePointManager.ServerCertificateValidationCallback = Function() True
    '        Dim response As HttpResponseMessage = Await client.SendAsync(request)
    '        response.EnsureSuccessStatusCode()
    '        Dim body As String = Await response.Content.ReadAsStringAsync()
    '        Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(body)
    '        meetToken = CStr(jsonDict("access_token"))
    '    End Using
    '    Return meetToken
    'End Function

    'Public Shared Async Function GetTokenOauthServerToServer() As Task(Of String)
    '    Dim clientHandler As HttpClientHandler = New HttpClientHandler
    '    Dim jss As New JavaScriptSerializer
    '    Dim meetToken As String = String.Empty
    '    clientHandler.UseCookies = False
    '    Dim request As HttpRequestMessage = New HttpRequestMessage
    '    request.Method = HttpMethod.Post
    '    Dim account_id As String = "ScUmscKsQDGrTDQPwViSAA"
    '    Dim username As String = "tQ9SdPeISreaNLt3gbQKMw"
    '    Dim password As String = "5PyV1ZmGsjknz01RLp4zTlFzi1elL0Bb"
    '    Dim Uri As String = "https://zoom.us/oauth/token?grant_type=account_credentials&account_id=" & account_id
    '    request.RequestUri = New Uri(Uri)
    '    Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"))
    '    request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"))}")
    '    Using client As New HttpClient(clientHandler)
    '        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    '        ServicePointManager.ServerCertificateValidationCallback = Function() True
    '        Dim response As HttpResponseMessage = Await client.SendAsync(request)
    '        response.EnsureSuccessStatusCode()
    '        Dim body As String = Await response.Content.ReadAsStringAsync()
    '        Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(body)
    '        meetToken = CStr(jsonDict("access_token"))
    '    End Using
    '    Return meetToken
    'End Function

    'Option 01 : using a delegate method
    Private Function AcceptAllCertificates(sender As Object, certificate As Object, chain As X509Chain, errors As SslPolicyErrors) As Boolean
        Return True
    End Function
    Public Function GetTokenOauthServerToServer2() As String
        Dim jss As New JavaScriptSerializer
        Dim meetToken As String = String.Empty
        Dim account_id As String = "ScUmscKsQDGrTDQPwViSAA"
        Dim url As String = "https://zoom.us/oauth/token?grant_type=account_credentials&account_id=" & account_id
        Dim username As String = "tQ9SdPeISreaNLt3gbQKMw"
        Dim password As String = "5PyV1ZmGsjknz01RLp4zTlFzi1elL0Bb"

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'Skip validation of SSL/TLS certificate
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertificates
        ' Create a request object
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        ' Set the Basic Authentication header
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"))
        request.Headers("Authorization") = $"Basic {credentials}"
        'Set the request content type and data
        'Dim postData As String = $"grant_type=account_credential&account_id={account_id}"
        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        'request.ContentType = "application/x-www-form-urlencoded"
        'request.ContentLength = byteArray.Length
        ' Write the request data to the request stream
        Using requestStream As Stream = request.GetRequestStream()
            'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
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

    Public Shared Function GetTokenOauthServerToServer() As String
        Dim jss As New JavaScriptSerializer
        Dim meetToken As String = String.Empty
        Dim account_id As String = "ScUmscKsQDGrTDQPwViSAA" 'GetPortalRegistryValueMeetingPlatforms("14d76a01-59a5-4638-bd2c-9df83f1ec844") 'Account ID
        Dim url As String = "https://zoom.us/oauth/token?grant_type=account_credentials&account_id=" & account_id
        Dim client_id As String = "tQ9SdPeISreaNLt3gbQKMw" 'GetPortalRegistryValueMeetingPlatforms("14d76a01-59a5-4638-bd2c-9df83f1ec844") 'Username
        Dim client_secret As String = "5PyV1ZmGsjknz01RLp4zTlFzi1elL0Bb" 'GetPortalRegistryValueMeetingPlatforms("14d76a01-59a5-4638-bd2c-9df83f1ec844") 'Secret

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
        ' Write the request data to the request stream
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