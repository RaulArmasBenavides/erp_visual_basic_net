Imports System.IO

Public Class FrmShell

    Public MyFilePath As String
    Public MyFilePathOpen As String
    Public startInfo As ProcessStartInfo
    Private Sub btnShell1_Click(sender As Object, e As EventArgs) Handles btnShell1.Click
        MyFilePath = "C:\Users\raula\Downloads\test3.xlsx"
        Dim fi As New FileInfo(Me.MyFilePath)
        Shell("Explorer.exe /e,/root,""" & fi.DirectoryName & """,/select,""" & fi.FullName & """", AppWinStyle.NormalFocus, False)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim Browse As New System.Windows.Forms.OpenFileDialog
        Browse.Title = "Test"
        Browse.DereferenceLinks = True
        Browse.CheckFileExists = True
        Browse.Multiselect = False
        Browse.DefaultExt = "vcf"
        Browse.Filter = "vCard Files (*.vcf)|*.vcf"
        If Browse.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            MyFilePathOpen = Browse.FileName
        End If
    End Sub


    Private Sub GetListVerbs(ByVal x As String)
        startInfo = New ProcessStartInfo(x)

        If (File.Exists(x)) Then

            Dim i As Integer = 0
            For Each verb In startInfo.Verbs
                Console.WriteLine("  {0}. {1}", i.ToString(), verb)
                i += 1
            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyFilePath = "C:\Users\raula\Downloads\test3.xlsx"
        GetListVerbs(MyFilePath)
    End Sub
End Class