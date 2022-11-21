Imports System.IO
Imports System.Text.RegularExpressions
Imports Aspose.Cells
Public Class FrmvbCr
    Private Sub btnJustifyText_Click(sender As Object, e As EventArgs) Handles btnJustifyText.Click
        MyRichTextControl.Text = JustifyText(MyRichTextControl.Text)
    End Sub


    Private Function ParseList(ByRef Text As String) As String
        Dim matches, matches2 As MatchCollection
        Dim text2 As String = String.Empty
        Dim text3 As String = String.Empty
        Dim text4 As String = String.Empty
        Dim text5 As String = String.Empty
        matches = Regex.Matches(Text, "<li>(.*?)</li>", RegexOptions.IgnoreCase)
        If matches.Count > 0 Then
            For Each item As Match In matches
                If item.Value.Contains("<ul>") Then
                    text4 = Regex.Matches(item.Value.ToString(), "<li>(.*?)<ul>", RegexOptions.IgnoreCase)(0).Value.ToString()
                    text2 &= text4
                    text2 = text2.Replace("<li>", vbCrLf & " -")
                    text2 = text2.Replace("<ul>", "")
                    'Text = Replace(Text, Regex.Matches(item.Value.ToString(), "<li>(.*?)<ul>", RegexOptions.IgnoreCase)(0).Value.ToString(), vbCrLf & "-" & text4)
                    matches2 = Regex.Matches(item.Value.ToString(), "<ul>(.*?)</li>", RegexOptions.IgnoreCase)
                    If matches2.Count > 0 Then
                        text3 = ParseList(matches2(0).Value.ToString())
                        text2 &= " " & text3
                        text2 = text2.Replace("<ul>", "")
                        text2 = text2.Replace("<li>", "   -")
                        text2 = text2.Replace("</li>", "")
                        text3 = text3.Replace("</li>", "")
                        ' Text = Replace(Text, matches2(0).Value, "   -" & text3)
                    End If
                ElseIf item.Value.Contains("</ul>") Then
                    text2 = text2.Replace("</li>", "")
                    text2 = text2.Replace("</li>", "")
                    text2 = text2.Replace("<ul>", vbCrLf & "   -")
                Else
                    text2 &= " " & item.Value.Replace("<li>", vbCrLf & "   -")
                    text2 = text2.Replace("</li>", "")
                    text5 = text5.Replace("</li>", "")
                    'Text = Replace(Text, item.Value, item.Value.Replace("<li>", vbCrLf & "   -"))
                End If
            Next
        End If
        Return text2
    End Function


    Private Function ParseList3(Text As String) As String
        Dim matches, matches2 As MatchCollection
        Dim text2 As String = String.Empty

        matches = Regex.Matches(Text, "<li>(.*?)</li>", RegexOptions.IgnoreCase)
        If matches.Count > 0 Then
            For Each item As Match In matches
                If item.Value.Contains("<ul>") Then
                    text2 &= Regex.Matches(item.Value.ToString(), "<li>(.*?)<ul>", RegexOptions.IgnoreCase)(0).Value.ToString()
                    text2 = text2.Replace("<li>", vbCrLf & "-")
                    text2 = text2.Replace("<ul>", "")
                    matches2 = Regex.Matches(item.Value.ToString(), "<ul>(.*?)</li>", RegexOptions.IgnoreCase)
                    If matches2.Count > 0 Then
                        text2 &= " " & ParseList(matches2(0).Value.ToString())
                        text2 = text2.Replace("<ul>", "")
                        text2 = text2.Replace("<li>", "   -")
                        text2 = text2.Replace("</li>", "")
                    End If
                Else
                    text2 &= " " & item.Value.Replace("<li>", vbCrLf & "   -")
                    text2 = text2.Replace("</li>", "")
                End If
            Next
        End If
        Return text2
    End Function

    Private Function ParseList2(ByRef Text As String) As String
        Dim matches, matches2 As MatchCollection
        Dim text2 As String = String.Empty

        matches = Regex.Matches(Text, "<ul>(.*?)</ul>", RegexOptions.IgnoreCase)
        If matches.Count > 0 Then
            For Each item As Match In matches
                If item.Value.Contains("<ul>") Then
                    text2 &= Regex.Matches(item.Value.ToString(), "<li>(.*?)<ul>", RegexOptions.IgnoreCase)(0).Value.ToString()
                    text2 = text2.Replace("<li>", vbCrLf & "-")
                    text2 = text2.Replace("<ul>", "")
                    Replace(Text, Regex.Matches(item.Value.ToString(), "<li>(.*?)<ul>", RegexOptions.IgnoreCase)(0).Value.ToString(), text2)
                    matches2 = Regex.Matches(item.Value.ToString(), "<ul>(.*?)</li>", RegexOptions.IgnoreCase)
                    If matches2.Count > 0 Then
                        text2 &= " " & ParseList(matches2(0).Value.ToString())
                        text2 = text2.Replace("<ul>", "")
                        text2 = text2.Replace("<li>", "   -")
                        text2 = text2.Replace("</li>", "")
                        Replace(Text, matches2(0).Value, text2)
                    End If
                Else
                    text2 &= " " & item.Value.Replace("<li>", vbCrLf & "   -")
                    text2 = text2.Replace("</li>", "")
                    Replace(Text, item.Value, text2)
                End If
            Next
        End If
        Return Text
    End Function



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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'MyRichTextControl.Text = String.Empty
        RichResultTextBox.Text = String.Empty
    End Sub

    Private Sub btnRetrieveLists_Click(sender As Object, e As EventArgs) Handles btnRetrieveLists.Click
        If MyRichTextControl.Text <> String.Empty Then
            RichResultTextBox.Text = ParseList(MyRichTextControl.Text)
        End If
    End Sub

    Private Sub btnRetrieveLists2_Click(sender As Object, e As EventArgs) Handles btnRetrieveLists2.Click
        If MyRichTextControl.Text <> String.Empty Then
            ParseList2(MyRichTextControl.Text)
            RichResultTextBox.Text = MyRichTextControl.Text
        End If
    End Sub

    Private Sub btnRetrieveLists3_Click(sender As Object, e As EventArgs) Handles btnRetrieveLists3.Click

        Dim matches1 As MatchCollection
        Dim cont As String = MyRichTextControl.Text
        cont = Replace(cont, vbLf, "")
        cont = Replace(cont, vbTab, "")
        matches1 = Regex.Matches(cont, "<ul>(.*?)</ul>", RegexOptions.IgnoreCase)
        For Each item As Match In matches1
            If Not String.IsNullOrEmpty(ParseList(item.Value.ToString())) Then
                cont = Replace(cont, item.Value.ToString(), ParseList(item.Value.ToString()))
            End If
        Next
        If cont <> String.Empty Then
            RichResultTextBox.Text = cont 'ParseList3(MyRichTextControl.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportListAspose()
    End Sub


    Private Sub ExportListAspose()
        'Create empty workbook.
        Dim workbook As Workbook = New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets(0)
        Dim list As List(Of String) = New List(Of String)
        ' Workbook workbook = New Workbook();
        Dim path As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) & "\"
        'Put some value in cell C4
        Dim cell As Cell = worksheet.Cells("A1")
        cell.PutValue("This is XLSX format generated by Aspose.Cells API.")
        'THis way you can create range on runtime
        Dim rn As Range = worksheet.Cells.CreateRange("A2:D" + list.Count.ToString())

        'Iterate all the cells in your range, print their names And values
        Dim e As IEnumerator = rn.GetEnumerator()

        While e.MoveNext()
            Dim c As Cell = e.Current
        End While

        'While (e.MoveNext())
        '{
        ' cell c = (cell)e.Current;
        ' Console.WriteLine(c.Name + ": " + c.StringValue);

        'Set value to 0
        'c.PutValue(0);
        '}
        'FileStream fs = File.Open(path + "book1_out.xls", FileMode.Open, FileAccess.ReadWrite);
        ' Save file And send to client browser using selected format
        workbook.Save(path & "book1_out.xlsx", SaveFormat.Xlsx)
        'workbook.Save(HttpContext.Current.Response, "outputSaveToXLSX.xlsx", ContentDisposition.Attachment, New OoxmlSaveOptions(SaveFormat.Xlsx))
    End Sub
End Class