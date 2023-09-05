Imports Sistema.Negocio

Public Class FrmSophos


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        GetSMPTProfiles()
    End Sub


    Public Sub GetSMPTProfiles()
        Dim v As String = SophosClientAPI.GetSMPTProfiles()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

End Class