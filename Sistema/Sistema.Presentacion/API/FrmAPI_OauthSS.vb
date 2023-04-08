Imports Sistema.Negocio

Public Class FrmAPI_OauthSS
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        GetToken()
    End Sub


    Public Async Sub GetToken()
        Dim v As String = Await OauthHelper.GetTokenOauthServerToServer()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class