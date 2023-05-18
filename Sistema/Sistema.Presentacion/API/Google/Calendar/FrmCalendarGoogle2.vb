Imports Sistema.Negocio

Public Class FrmCalendarGoogle2
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim v As String = OauthHelper.GetGoogleAuthorizationFile()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub
End Class