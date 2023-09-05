Option Strict On
Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Web.Script.Serialization

Public Class SophosClientAPI

    Public Shared Function GetSMPTProfiles() As String
        Dim meetToken As String = String.Empty
        Dim domainDictionary As New Dictionary(Of String, String)
        Try
            Dim jss As New JavaScriptSerializer
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            'Skip validation of SSL/TLS certificate
            ServicePointManager.ServerCertificateValidationCallback = Function()
                                                                          Dim nestedFunction As Func(Of Object, Object, X509Chain, SslPolicyErrors, Boolean) = Function(sender As Object, certificate As Object, chain As X509Chain, errors As SslPolicyErrors) True
                                                                          Return True
                                                                      End Function
            Dim requestTeams As WebRequest = WebRequest.Create($"https://out.bw2hosting.ch:4444/api/objects/smtp/profile/")
            requestTeams.Method = WebRequestMethods.Http.Get
            Dim credentials As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(Sistema.Entidades.Constants.SophosUser & ":" & Sistema.Entidades.Constants.SophosPassword))
            requestTeams.Headers(HttpRequestHeader.Authorization) = "Basic " & credentials
            Dim responseTeams As WebResponse = requestTeams.GetResponse()
            Dim data As Stream = responseTeams.GetResponseStream()
            Dim streamReader As New StreamReader(data)
            Dim content As String = streamReader.ReadToEnd()
            Dim listSophosItems As List(Of Dictionary(Of String, Object)) = jss.Deserialize(Of List(Of Dictionary(Of String, Object)))(content)
            For Each SophosItem As Dictionary(Of String, Object) In listSophosItems
                Dim domainList As ArrayList = TryCast(SophosItem("domains"), ArrayList)
                If domainList IsNot Nothing Then
                    For Each _domain As Object In domainList
                        If TypeOf _domain Is String Then
                            domainDictionary.Add(CStr(_domain), CStr(SophosItem("name")))
                        End If
                    Next
                End If
            Next

        Catch ex As Exception
            meetToken = "ERROR -Teams" & ex.Message
        End Try
        Return meetToken
    End Function
End Class
