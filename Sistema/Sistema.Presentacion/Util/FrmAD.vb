Imports System.DirectoryServices

Public Class FrmAD

    Private b_UseCredentials As Boolean = False
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim msproperty As String = txtProperty.Text
        Dim msquery As String = TxtQuery.Text.Trim
        Dim mspath As String = txtPath.Text.Trim
        Try
            Dim myLdapConnection As DirectoryEntry = createDirectoryEntry(mspath, msquery)
            Dim search As DirectorySearcher = New DirectorySearcher(myLdapConnection)
            search.PropertiesToLoad.Add("cn")
            search.PropertiesToLoad.Add(msproperty)
            Dim allUsers As SearchResultCollection = search.FindAll()
            If Not chkAllProperties.Checked Then
                If msproperty <> "" Then
                    Dim ADInfo As String = "USERS BW2 ACTIVE DIRECTORY"
                    For Each result As SearchResult In allUsers
                        If (result.Properties.Contains("cn") AndAlso result.Properties.Contains(msproperty)) Then
                            ADInfo = ADInfo + Environment.NewLine + result.Properties(msproperty)(0).ToString()
                        End If
                        txt_result.Text = ADInfo
                    Next
                End If
            Else
                'show all properties
                Dim ADInfo As String = "USERS BW2 ACTIVE DIRECTORY (ALL PROPERTIES)"
                For Each result As SearchResult In allUsers
                    For Each itemvprop As ICollection In result.Properties.Values
                        For Each item As String In itemvprop
                            'ADInfo = ADInfo  + Environment.NewLine
                            ADInfo = ADInfo + Environment.NewLine + item
                            ADInfo = ADInfo + "-------------------------------------" + Environment.NewLine
                        Next
                    Next
                    'ADInfo = ADInfo + Environment.NewLine + 
                    'If (result.Properties.Contains("cn") AndAlso result.Properties.Contains(msproperty)) Then
                    '    ADInfo = ADInfo + Environment.NewLine + result.Properties(msproperty)(0).ToString()
                    'End If
                    txt_result.Text = ADInfo
                Next
            End If

        Catch ex As Exception
            txt_result.Text = ex.Message
        End Try

    End Sub

    'create And return New LDAP connection with desired settings 
    'Private Shared Function createDirectoryEntry() As DirectoryEntry
    '    Dim ldapConnection As DirectoryEntry = New DirectoryEntry("LDAP://bw2dev.local", "raul.armas", "BW2.Raul")
    '    ldapConnection.Path = "LDAP://OU=Users,OU=Hosting,DC=bw2dev,DC=local"
    '    ldapConnection.AuthenticationType = AuthenticationTypes.Secure
    '    Return ldapConnection
    'End Function

    Private Function createDirectoryEntry(ByVal path As String, ByVal query As String) As DirectoryEntry
        Dim ldapConnection As DirectoryEntry
        If b_UseCredentials Then
            'ldapConnection = New DirectoryEntry(path, "raul.armas", "BW2.Raul")
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
        TxtQuery.Text = "LDAP://OU=Stellverstretungen,OU=Lehrpersonen,OU=Benutzer,DC=sekeinshoefe,DC=ch"
        txtPath.Text = "LDAP://seh.sekeinshoefe.ch"
    End Sub
End Class