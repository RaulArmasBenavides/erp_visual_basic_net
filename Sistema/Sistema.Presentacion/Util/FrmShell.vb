Imports System.IO
Imports System.Xml

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

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        ReadXML1("")
        ReadXML2("")
        ReadXMLList("")
        'ConvertToFormatNewML("")
    End Sub

    Public Class PUBTinfo
        Public newsServiceName As String = ""
        Public transmissionID As String = ""
        Public newsItemID As String = ""
        Public country As String = ""
        Public countryValue As String = ""
        Public DateAndTime As String = ""
        Public isin As String = ""
        Public wire As String = ""
        Public language As String = ""
        Public providerID As String = ""
        Public provider As String = ""
        Public publicIdentifier As String = ""
        Public source As String = ""
        Public headline As String = ""
        Public revisionId As String = ""
        Public firstcreated As String = ""
        Public thisrevisioncreated As String = ""
        Public urgency As String = ""
        Public status As String = ""
        Public subject As String = ""
        Public scheme As String = String.Empty
        Public charactervers As String = String.Empty
    End Class
    ' Protected xmldoc As Xml.XmlDocument
    Public Function GetXmlValue(ByVal node As Xml.XmlNode, ByVal tag As String, ByVal defaultValue As String) As String
        If node Is Nothing Then Return defaultValue
        node = node.SelectSingleNode(tag)
        If node Is Nothing Then Return defaultValue
        Return node.InnerText
    End Function

    'Public Function GetFirstElementByTagName(ByVal tag As String) As Xml.XmlNode
    '    Dim nodelist As Xml.XmlNodeList = xmldoc.DocumentElement.GetElementsByTagName(tag)
    '    If nodelist Is Nothing OrElse nodelist.Count = 0 Then Return Nothing
    '    Return nodelist(0)
    'End Function

    Public Function GetInnerXml(ByVal tag As String, ByVal defaultValue As String, ByVal xmldoc As Xml.XmlDocument) As String
        Dim node As Xml.XmlNode = xmldoc.DocumentElement
        If node Is Nothing Then Return defaultValue
        node = node.SelectSingleNode(tag)
        If node Is Nothing Then Return defaultValue
        Return node.InnerXml
    End Function

    Public Sub ReadXML1(ByVal text As String)
        Debug.Print("METHOD WITH SelectSingleNode")
        Dim xmldoc As New Xml.XmlDocument
        Dim reader As XmlReader
        Dim nodeList As XmlNodeList
        reader = XmlReader.Create("C:\Users\raula\Downloads\move1\test.xml")
        xmldoc.Load(reader)
        Dim node As Xml.XmlNode = xmldoc.DocumentElement.SelectSingleNode("NewsEnvelope/DateAndTime")
        Debug.Print("resultado" + node.InnerText)
    End Sub

    Public Sub ReadXML2(ByVal text As String)
        Debug.Print("METHOD WITH GetElementsByTagName ")
        Dim xmldoc As New Xml.XmlDocument
        Dim reader As XmlReader
        Dim nodeList As XmlNodeList
        reader = XmlReader.Create("C:\Users\raula\Downloads\move1\test.xml")
        xmldoc.Load(reader)

        Dim node As Xml.XmlNode ' = xmldoc.DocumentElement.SelectSingleNode("//NewsEnvelope/DateAndTime")
        Dim nodelist2 As Xml.XmlNodeList = xmldoc.DocumentElement.GetElementsByTagName("DateAndTime")
        node = nodelist2(0)
        Debug.Print("resultado" + node.InnerText)
    End Sub

    Public Sub ReadXMLList(ByVal text As String)
        Dim xmldoc As New Xml.XmlDocument
        Dim reader As XmlReader
        Dim nodeList As XmlNodeList
        reader = XmlReader.Create("C:\Users\raula\Downloads\move1\test.xml")
        xmldoc.Load(reader)
        nodeList = xmldoc.DocumentElement.SelectNodes("//book/name")
        For Each node As XmlNode In nodeList
            Debug.Print(node.FirstChild.Value)
        Next
    End Sub

    Public Shared Function ConvertToFormatNewML(ByVal text As String) As XmlDocument
        Dim xmldoc As New Xml.XmlDocument
        Dim TempPath As String = "C:\Users\raula\Downloads\move1"
        Dim p As New PUBTinfo
        p.DateAndTime = "20220113T060513+0200"
        p.provider = "AWP"
        p.newsServiceName = "PUBT"
        p.source = "PUBT"
        p.newsItemID = "60213474"
        p.providerID = "pubt.news"
        p.revisionId = "1"
        p.publicIdentifier = "urn:newsml:pubt.news:20220113T060513+0200:60213474:1"
        p.headline = "Geberit AG - Umsatzdetails 2021 (nur in Englisch verfÃŒgbar) (202,48 kB)"
        p.language = "en"
        p.subject = "ERN"
        p.countryValue = "CH"
        p.scheme = "IptcFormat"
        p.charactervers = "3.1"

        'Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        'p = GetPUBTInfo(text)
        Using w As XmlWriter = XmlWriter.Create("Employees7.xml", settings)
            w.WriteStartElement("NewsML")
#Region "NewsEnvelope"
            w.WriteStartElement("NewsEnvelope")
            w.WriteElementString("DateAndTime", p.DateAndTime)
            w.WriteStartElement("NewsService")
            w.WriteAttributeString("FormalName", "PUBT")
            w.WriteEndElement()
            w.WriteElementString("TransmissionID", p.newsItemID)
            w.WriteEndElement() 'NewsEnvelope
#End Region

#Region "NewsItem"
            w.WriteStartElement("NewsItem")

            w.WriteStartElement("Identification")
            w.WriteStartElement("NewsIdentifier")
            w.WriteElementString("ProviderId", p.providerID)
            w.WriteElementString("DateId", p.DateAndTime)
            w.WriteElementString("NewsItemId", p.newsItemID)
            w.WriteStartElement("RevisionId")
            w.WriteAttributeString("PreviousRevision", "0")
            w.WriteAttributeString("Update", "N")
            w.WriteString(p.revisionId)
            w.WriteEndElement()
            w.WriteElementString("PublicIdentifier", p.publicIdentifier)
            w.WriteEndElement() 'NewsIdentifier
            w.WriteEndElement() 'Identification

            w.WriteStartElement("NewsManagement")

            w.WriteStartElement("NewsItemType")
            w.WriteAttributeString("FormalName", "News")
            w.WriteEndElement() 'NewsItemType
            w.WriteElementString("FirstCreated", p.DateAndTime)
            w.WriteElementString("ThisRevisionCreated", p.DateAndTime)
            w.WriteStartElement("Status")
            w.WriteAttributeString("FormalName", "Usable")
            w.WriteEndElement() 'Status
            w.WriteStartElement("Urgency")
            w.WriteAttributeString("FormalName", "3")
            w.WriteEndElement() 'Urgency
            w.WriteEndElement() 'NewsManagement

            w.WriteStartElement("NewsComponent")

            w.WriteStartElement("NewsLines")
            w.WriteElementString("HeadLine", p.headline)
            w.WriteStartElement("NewsLine")
            w.WriteStartElement("NewsLineType")
            w.WriteAttributeString("FormalName", "StoryType")
            w.WriteEndElement() 'NewsLineType
            w.WriteElementString("NewsLineText", "Insert_Storytype")
            w.WriteEndElement() 'NewsLine
            w.WriteEndElement() 'NewsLines

            w.WriteStartElement("AdministrativeMetadata")
            w.WriteStartElement("Provider")
            w.WriteStartElement("Party")
            w.WriteAttributeString("FormalName", p.provider)
            w.WriteEndElement() 'Party
            w.WriteEndElement() 'Provider
            w.WriteStartElement("Source")
            w.WriteStartElement("Party")
            w.WriteAttributeString("FormalName", p.source)
            w.WriteEndElement() 'Party
            w.WriteEndElement() 'Source
            w.WriteEndElement() 'AdministrativeMetadata


            w.WriteStartElement("DescriptiveMetadata")
            w.WriteStartElement("Language")
            w.WriteAttributeString("FormalName", p.language)
            w.WriteEndElement() 'Language


            w.WriteStartElement("Location")
            w.WriteStartElement("Property")
            w.WriteAttributeString("FormalName", "Country")
            w.WriteAttributeString("Value", p.countryValue)
            w.WriteEndElement() 'Property
            w.WriteEndElement() 'Location

            'Company relations
            w.WriteStartElement("Property")
            w.WriteAttributeString("FormalName", "ISIN")
            w.WriteAttributeString("Value", p.isin)
            w.WriteEndElement() 'Property

            'Relations
            w.WriteStartElement("Property")
            w.WriteAttributeString("FormalName", "Wire")
            w.WriteAttributeString("Value", "O")
            w.WriteStartElement("Property")
            w.WriteAttributeString("FormalName", "Subject")
            w.WriteAttributeString("Value", p.subject)
            w.WriteEndElement() 'Property
            w.WriteEndElement() 'Property



            w.WriteEndElement() 'DescriptiveMetadata

            w.WriteStartElement("ContentItem")
            w.WriteStartElement("Format")
            w.WriteAttributeString("Scheme", p.scheme)
            w.WriteAttributeString("FormalName", "NITF")
            w.WriteEndElement() 'Format
            w.WriteStartElement("Characteristics")
            w.WriteStartElement("Property")
            w.WriteAttributeString("FormalName", "FormatVersion")
            w.WriteAttributeString("Value", p.charactervers)
            w.WriteEndElement() 'Property
            w.WriteEndElement() 'Characteristics

            w.WriteStartElement("DataContent")
            w.WriteStartElement("nitf")
            w.WriteStartElement("body")
            w.WriteElementString("body.content", "")
            w.WriteEndElement() 'body
            w.WriteEndElement() 'nitf

            w.WriteEndElement() 'DataContent
            w.WriteEndElement() 'ContentItem

            w.WriteEndElement() 'NewsComponent
            w.WriteEndElement() 'NewsItem
#End Region
            w.WriteEndElement() 'NewsML
        End Using
        Return xmldoc
    End Function


    Private Shared Function GetPUBTInfo(text As String) As PUBTinfo
        Throw New NotImplementedException()
    End Function
End Class