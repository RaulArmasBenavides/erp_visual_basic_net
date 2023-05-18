Imports System.DirectoryServices
Imports Sistema.Negocio

Public Class FrmAD

    Private b_UseCredentials As Boolean = False
    Const UF_DISABLED As Integer = &H2
    Private Function IsUserActive(ByVal Flag As Integer) As Boolean
        'If (de.NativeGuid Is Nothing) Then Return False
        'Dim flags As Integer = Convert.ToInt32(de.Properties("userAccountControl").Value)
        Return Not ((Flag & UF_DISABLED) = UF_DISABLED)
    End Function
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim msproperty As String = txtProperty.Text
        Dim msquery As String = TxtQuery.Text.Trim
        Dim mspath As String = txtPath.Text.Trim
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
                If (result.Properties.Contains("cn") AndAlso result.Properties.Contains("userAccountControl")) Then
                    ADInfo = ADInfo + Environment.NewLine + " Is Active " + Me.IsUserActive(Convert.ToInt32(result.Properties("userAccountControl")(0))).ToString()  'result.Properties("userAccountControl")(0).ToString()
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
                ADInfo += Environment.NewLine
                txt_result.Text = ADInfo
            Next
        Catch ex As Exception
            txt_result.Text = "ERROR " + ex.Message
        End Try
    End Sub

    Private Function createDirectoryEntry(ByVal path As String, ByVal query As String) As DirectoryEntry
        Dim ldapConnection As DirectoryEntry
        If b_UseCredentials Then
            ldapConnection = New DirectoryEntry(path, TxtUser.Text.Trim(), TxtPassword.Text.Trim())
        Else
            ldapConnection = New DirectoryEntry(path)
        End If
        ldapConnection.Path = query
        ldapConnection.AuthenticationType = AuthenticationTypes.Secure
        Return ldapConnection
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtPath.Text = String.Empty
        txtProperty.Text = String.Empty
        TxtUser.Text = String.Empty
        TxtPassword.Text = String.Empty
        TxtQuery.Text = String.Empty
        txt_result.Text = String.Empty
    End Sub

    Private Sub chkCredentials_CheckedChanged(sender As Object, e As EventArgs) Handles chkCredentials.CheckedChanged
        PanelCredentials.Enabled = chkCredentials.Checked
    End Sub

    Private Sub FrmAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelCredentials.Enabled = False
        'Array de Tooltip
        Dim TL(5) As ToolTip
        TL(0) = New ToolTip
        TL(0).SetToolTip(Me.btnConnect, "Connect to Actvie Directory")
        TL(1) = New ToolTip
        TL(1).SetToolTip(Me.chkCredentials, "Select this option if you want to connect with an user of the domain")
        TL(2) = New ToolTip
        TL(2).SetToolTip(Me.chkAllProperties, "Select this option if you want to read all properties from the Active Directory folder")
        TL(3) = New ToolTip
        TL(3).SetToolTip(Me.txtPath, "Path of the Active Directory ( example :" & "LDAP://bw2test.com" & ")")
        TL(4) = New ToolTip
        TL(4).SetToolTip(Me.TxtQuery, " LDAP Query to read ( example :" & "LDAP://OU=Users,OU=Hosting,DC=bw2dev,DC=local" & ")")
        DefaultValues()
    End Sub

    Private Sub DefaultValues()
        TxtQuery.Text = CustomXMLReader.GetRegistryValue("ldapquery")
        txtPath.Text = CustomXMLReader.GetRegistryValue("ldappath")
    End Sub

End Class