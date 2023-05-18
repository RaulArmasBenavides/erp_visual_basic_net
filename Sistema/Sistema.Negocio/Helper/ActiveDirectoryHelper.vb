Imports System.DirectoryServices

Public Class AccountAD
    Public ID As Long = 0L
    Public BOID As Long = 0L
    Public Email As String = String.Empty
    Public GivenName As String = String.Empty
    Public sn As String = String.Empty
    Public BirthDate As Date = Date.MinValue
    Public userPrincipalName As String = String.Empty
    Public physicalDeliveryOfficeName As String = String.Empty
    Public description As String = String.Empty
    Public telephoneNumber As String = String.Empty
    Public department As String = String.Empty
End Class
Public Class ActiveDirectoryHelper

    Private b_UseCredentials As Boolean = False
    Const UF_DISABLED As Integer = &H2
    Private Function IsUserActive(ByVal Flag As Integer) As Boolean
        Return Not ((Flag & UF_DISABLED) = UF_DISABLED)
    End Function

    Private Function createDirectoryEntry(ByVal path As String, ByVal query As String, Optional ByVal user As String = "", Optional ByVal password As String = "") As DirectoryEntry
        Dim ldapConnection As DirectoryEntry
        If b_UseCredentials Then
            ldapConnection = New DirectoryEntry(path, user, password)
        Else
            ldapConnection = New DirectoryEntry(path)
        End If
        ldapConnection.Path = query
        ldapConnection.AuthenticationType = AuthenticationTypes.Secure
        Return ldapConnection
    End Function


    Private Sub ReadProperties(ByVal mspath As String, ByVal msquery As String)
        ' Dim msproperty As String = txtProperty.Text

        Try
            Dim myLdapConnection As DirectoryEntry = createDirectoryEntry(mspath, msquery)
            Dim search As New DirectorySearcher(myLdapConnection)
            search.PropertiesToLoad.Add("cn")
            search.PropertiesToLoad.Add("userPrincipalName")
            search.PropertiesToLoad.Add("sn")
            search.PropertiesToLoad.Add("telephoneNumber")
            search.PropertiesToLoad.Add("description")
            search.PropertiesToLoad.Add("mail")
            search.PropertiesToLoad.Add("givenname")
            search.PropertiesToLoad.Add("homedirectory")
            search.PropertiesToLoad.Add("homedrive")
            search.PropertiesToLoad.Add("department")
            search.PropertiesToLoad.Add("physicalDeliveryOfficeName")
            search.PropertiesToLoad.Add("userAccountControl")
            Dim allUsers As SearchResultCollection = search.FindAll()
            Dim ADInfo As String = "USERS FIRMA ACTIVE DIRECTORY"
            For Each result As SearchResult In allUsers
                If Me.IsUserActive(Convert.ToInt32(result.Properties("userAccountControl")(0))) Then
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("givenname")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Nachname " + result.Properties("givenname")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("sn")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Vorname " + result.Properties("sn")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("mail")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Mail " + result.Properties("mail")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("userPrincipalName")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Benutzernamen " + result.Properties("userPrincipalName")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("physicalDeliveryOfficeName")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Abteilung (Office) " + result.Properties("physicalDeliveryOfficeName")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("department")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Standort  (department) " + result.Properties("department")(0).ToString()
                    End If

                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("telephoneNumber")) Then
                        ADInfo = ADInfo + Environment.NewLine + "Phone " + result.Properties("telephoneNumber")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("description")) Then
                        ADInfo = ADInfo + Environment.NewLine + result.Properties("description")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("homedirectory")) Then
                        ADInfo = ADInfo + Environment.NewLine + result.Properties("homedirectory")(0).ToString()
                    End If
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("homedrive")) Then
                        ADInfo = ADInfo + Environment.NewLine + result.Properties("homedrive")(0).ToString()
                    End If
                End If

                'If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("userAccountControl")) Then
                '    ADInfo = ADInfo + Environment.NewLine + " Is Active " + Me.IsUserActive(Convert.ToInt32(result.Properties("userAccountControl")(0))).ToString()  'result.Properties("userAccountControl")(0).ToString()
                'End If
                ADInfo += Environment.NewLine

            Next
        Catch ex As Exception
            'txt_result.Text = "ERROR " + ex.Message
        End Try
    End Sub
End Class
