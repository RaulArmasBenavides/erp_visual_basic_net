Imports Sistema.Entidades
Imports Sistema.Negocio

Public Class FrmTeamsWU
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        GetTokenWU()
    End Sub

    Public Sub GetTokenWU()
        Dim cred As New AuthDto
        cred.UsuarioEmail = TxtUser.Text
        cred.Password = TxtPassword.Text
        cred.Client_secret = txtSecret.Text
        cred.TeamsClientId = txtClientID.Text
        Dim v As String = OauthHelper.GetTeamsAuthorization(cred)
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetToken()
    End Sub

    Public Sub GetToken()
        Dim cred As New AuthDto
        cred.Client_secret = txtSecret.Text.Trim()
        cred.TeamsClientId = txtClientID.Text.Trim()
        Dim v As String = OauthHelper.GetTeamsAuthorizationWOAsync(cred)
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtPath.Text = String.Empty
        'TxtUser.Text = String.Empty
        'TxtPassword.Text = String.Empty
        txt_result.Text = String.Empty
    End Sub
End Class