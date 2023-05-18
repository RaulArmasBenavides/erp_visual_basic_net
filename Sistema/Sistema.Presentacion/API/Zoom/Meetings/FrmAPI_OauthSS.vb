Imports Sistema.Negocio

Public Class FrmAPI_OauthSS
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        GetToken()
    End Sub


    Public Sub GetToken()
        'For async :  Dim v As String = Await OauthHelper.GetTokenOauthServerToServer() 'async method , it forces to make async this method
        'Dim oa As New OauthHelper  'with delegate
        Dim v As String = OauthHelper.GetTokenOauthServerToServer()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PanelCredentials_Paint(sender As Object, e As PaintEventArgs) Handles PanelCredentials.Paint

    End Sub

    Private Sub txtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtQuery_TextChanged(sender As Object, e As EventArgs) Handles TxtQuery.TextChanged

    End Sub

    Private Sub txt_result_TextChanged(sender As Object, e As EventArgs) Handles txt_result.TextChanged

    End Sub
End Class