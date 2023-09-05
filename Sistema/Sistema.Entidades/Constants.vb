Imports System.Configuration

Public Class Constants


    Public Shared timerLastPortalValidationHours As String = ConfigurationManager.AppSettings("timerLastPortalValidationHours")
    Public Shared SophosAPIUrl As String = ConfigurationManager.AppSettings("SophosAPIUrl")
    Public Shared SophosUser As String = ConfigurationManager.AppSettings("SophosUser")
    Public Shared SophosPassword As String = ConfigurationManager.AppSettings("SophosPassword")

End Class