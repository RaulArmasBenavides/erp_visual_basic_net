Imports Google.Apis.Calendar.v3
Imports Google.Apis.Calendar.v3.Data
Imports Sistema.Negocio

Public Class FrmCalendarGoogle2
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim v As String = OauthHelper.GetGoogleAuthorizationFile()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub btnRestApiGoogleAuth_Click(sender As Object, e As EventArgs) Handles btnRestApiGoogleAuth.Click
        Dim v As String = OauthHelper.GetGoogleAuthorization()
        Dim oauth_token As String = v
        txt_result.Text = oauth_token
    End Sub

    Private Sub CreateGoogleMeeting()
        Dim creator = New GoogleMeetingCreator("C://credenciales2.json")
        Dim summary = "Título de la reunión"
        Dim description = "Descripción de la reunión"
        Dim startTime = DateTime.Now.AddHours(1) ' Hora de inicio de la reunión (1 hora en el futuro)
        Dim endTime = startTime.AddHours(2) ' Hora de finalización de la reunión (2 horas después de la hora de inicio)

        Dim attendees = New List(Of EventAttendee)() From {
        New EventAttendee() With {.Email = "dev@bw2workspace.com"}
        }

        Dim meetingId = creator.CreateMeeting(summary, description, startTime, endTime, attendees)
        txt_result.Text = "La reunión ha sido creada exitosamente. ID de la reunión: " & meetingId
        'Console.WriteLine("La reunión ha sido creada exitosamente. ID de la reunión: " & meetingId)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateGoogleMeeting()
    End Sub
End Class