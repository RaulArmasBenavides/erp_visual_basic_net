Imports System.IO
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Calendar.v3
Imports Google.Apis.Calendar.v3.Data
Imports Google.Apis.Services

Public Class GoogleMeetingCreator
    Private ReadOnly calendarService As CalendarService

    Public Sub New(credentialsFilePath As String)
        Dim credentials As GoogleCredential

        Using stream = New FileStream(credentialsFilePath, FileMode.Open, FileAccess.Read)
            credentials = GoogleCredential.FromStream(stream)
        End Using

        Dim initializer = New BaseClientService.Initializer() With {
      .HttpClientInitializer = credentials.CreateScoped(CalendarService.Scope.Calendar),
            .ApplicationName = "Google Meeting Creator"
        }

        calendarService = New CalendarService(initializer)
    End Sub

    Public Function CreateMeeting(summary As String, description As String, startTime As DateTime, endTime As DateTime, attendees As IList(Of EventAttendee)) As String
        Dim newMeeting = New Google.Apis.Calendar.v3.Data.Event() With {
            .Summary = summary,
            .Description = description,
            .Start = New EventDateTime() With {
                .DateTime = startTime,
                .TimeZone = "UTC"
            },
            .End = New EventDateTime() With {
                .DateTime = endTime,
                .TimeZone = "UTC"
            },
            .Attendees = attendees
        }

        Dim insertRequest = calendarService.Events.Insert(newMeeting, "primary")
        Dim createdMeeting = insertRequest.Execute()

        Return createdMeeting.Id
    End Function
End Class