Imports Sistema.Negocio

Public Class FrmGoogleCalendar

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        GetToken()
    End Sub


    Public Sub GetToken()
        Dim v As String = JWTHelper.GetZoomAuthorization()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

End Class