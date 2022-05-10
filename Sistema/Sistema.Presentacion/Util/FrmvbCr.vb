Public Class FrmvbCr
    Private Sub btnJustifyText_Click(sender As Object, e As EventArgs) Handles btnJustifyText.Click
        MyRichTextControl.Text = JustifyText(MyRichTextControl.Text)
    End Sub

    Private Function JustifyText(ByVal Text As String) As String
        Dim s As String = Text
        s = Replace(s, "\'", "'")
        Dim lines As String() = Split(s, vbCrLf)
        Dim n As Integer = 0
        Dim pref As String = ""
        For i As Integer = 0 To lines.GetUpperBound(0)
            s = Trim(lines(i))
            If lines(i).StartsWith(" ") AndAlso s.StartsWith("* ") Then
                's = lines(i)
                pref = lines(i).Substring(0, lines(i).IndexOf("*"))
            Else
                pref = ""
            End If
            If s <> "" Then s = Replace(s, "  ", " ")
            If s <> "" Then
                Dim olen As Integer
                Do
                    olen = s.Length
                    s = Replace(s, "  ", " ")
                Loop While s.Length < olen
                s = Replace(s, vbTab, "  ")
            End If
            If pref <> "" Then lines(n) = pref & s Else lines(n) = s

            If lines(i) = "" AndAlso (n = 0 OrElse lines(n - 1) = "") Then
            Else
                n += 1
            End If
        Next
        If n = 0 Then Return ""
        ReDim Preserve lines(n - 1)
        s = Join(lines, vbCr)
        's = Replace(s, vbLf, "") & ""
        s = Replace(s, vbCr + vbCr, vbLf)
        s = Replace(s, vbCr, " ")
        s = Replace(s, vbLf, vbCrLf + vbCrLf)
        s = Replace(s, vbLf + " ", vbLf)
        's = Replace(s, "  ", " ")
        s = Trim(s)
        's = DoTextAction("TextReplaceQuotes", s)
        If s Is Nothing Then s = ""
        'Dim b As Byte() = System.Text.Encoding.Unicode.GetBytes(s)
        's = System.Text.Encoding.GetEncoding("iso-850").GetString(b)
        If s.StartsWith("(") Then
            s = vbCrLf & s
        End If
        Return s
    End Function
End Class