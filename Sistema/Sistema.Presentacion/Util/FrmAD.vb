Imports System.DirectoryServices

Public Class FrmAD
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim msproperty As String = txtProperty.Text
        Try
            Dim myLdapConnection As DirectoryEntry = createDirectoryEntry()
            Dim search As DirectorySearcher = New DirectorySearcher(myLdapConnection)
            search.PropertiesToLoad.Add("cn")
            search.PropertiesToLoad.Add(msproperty)
            If msproperty <> "" Then
                Dim allUsers As SearchResultCollection = search.FindAll()

                For Each result As SearchResult In allUsers
                    If (result.Properties.Contains("cn") AndAlso result.Properties.Contains(msproperty)) Then
                        txt_result.Text = String.Format("{0,-20} : {1}",
                                                  result.Properties("cn").ToString(),
                                                   result.Properties(msproperty).ToString())
                    End If
                Next
            End If
        Catch ex As Exception
            txt_result.Text = ex.Message
        End Try

    End Sub

    'create And return New LDAP connection with desired settings 
    Private Shared Function createDirectoryEntry() As DirectoryEntry
        Dim ldapConnection As DirectoryEntry = New DirectoryEntry("bw2.com")
        ldapConnection.Path = "LDAP://OU=allusers,DC=bw2,DC=com"
        ldapConnection.AuthenticationType = AuthenticationTypes.Secure
        Return ldapConnection
    End Function

End Class