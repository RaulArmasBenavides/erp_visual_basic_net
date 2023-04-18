Imports System.IO
Imports System.Reflection
Imports System.Xml

Public Class CustomXMLReader
    Public ArchivoConfig As String = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)) & "\xmlConfig"
    Public ArchivoParam As String = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)) & "\xmlParam"
    Public Function GetConnectionStringFromXML(ByVal myfilepath As String) As String
        Dim xtr As XmlTextReader = New XmlTextReader(myfilepath)
        Dim constring = String.Empty
        While xtr.Read()
            If xtr.NodeType = XmlNodeType.Element AndAlso xtr.Name Is "codurl" Then
                constring = xtr.ReadElementContentAsString()
            End If
        End While
        Return constring
    End Function


    Public Shared Function GetRegistryValue(ByVal keyValue As String) As String
        Dim xtr As XmlTextReader = New XmlTextReader((Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)) & "\xmlConfig")
        Debug.Print((Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)))
        Dim constring = String.Empty
        While xtr.Read()
            If xtr.NodeType = XmlNodeType.Element AndAlso xtr.Name = keyValue Then
                constring = xtr.ReadElementContentAsString()
            End If
        End While
        Return constring
    End Function

    Public Function GetConnectionStringFromXML2(ByVal myfilepath As String) As String
        Dim xtr As XmlTextReader = New XmlTextReader(myfilepath)
        Dim constring = String.Empty
        While xtr.Read()
            If xtr.NodeType = XmlNodeType.Element AndAlso xtr.Name Is "codurl2" Then
                constring = xtr.ReadElementContentAsString()
            End If
        End While
        Return constring
    End Function

    Public Function LeerConfiguracionXML(ByVal psNombreArchivo As String, ByVal psTabla As String) As DataTable
        Try
            Dim dsConfig As DataSet = New DataSet()
            Dim dtConfig As DataTable = New DataTable()
            dsConfig.ReadXml(psNombreArchivo)
            dtConfig = dsConfig.Tables(psTabla)

            If dtConfig Is Nothing Then
                Return Nothing
            End If
            If dtConfig.Rows.Count <= 0 Then
                Return Nothing
            End If
            Return dtConfig
        Catch __unusedException1__ As Exception
            Return Nothing
        End Try
    End Function

    Public Sub ActualizarConfiguracionXML()
        Try
            If File.Exists(ArchivoConfig) Then
                File.Delete(ArchivoConfig)
            End If

            Dim Xml As XmlTextWriter = New XmlTextWriter(ArchivoConfig, Nothing)
            Xml.Indentation = 4
            Xml.IndentChar = " "c
            Xml.Formatting = CType(Xml.Indentation, Formatting)
            Xml.WriteStartDocument()
            Xml.WriteStartElement("Config")
            Xml.WriteStartElement("info")
            'Xml.WriteElementString("codurl", Configuracion.ConfigSistema.URL);
            'Xml.WriteElementString("serweb", Configuracion.ConfigSistema.SerWeb);
            '''Print Server
            'Xml.WriteElementString("impbob", Configuracion.ConfigSistema.PrintServerEtiquetaBobina);
            'Xml.WriteElementString("impcab", Configuracion.ConfigSistema.PrintServerEtiquetaCable);
            'Xml.WriteElementString("impposte", Configuracion.ConfigSistema.PrintServerEtiquetaPoste);
            'Xml.WriteElementString("impemp", Configuracion.ConfigSistema.PrintServerEtiquetaEmpaque);
            'Xml.WriteElementString("impind", Configuracion.ConfigSistema.PrintServerEtiquetaIndividual);
            'Xml.WriteElementString("impubi", Configuracion.ConfigSistema.PrintServerEtiquetaUbicacion);
            '''Impresoras
            'Xml.WriteElementString("impresoracab", Configuracion.ConfigSistema.ImpresoraEtiquetaCable);
            'Xml.WriteElementString("impresoraind", Configuracion.ConfigSistema.ImpresoraEtiquetaIndividual);
            'Xml.WriteElementString("impresoraposte", Configuracion.ConfigSistema.ImpresoraEtiquetaPoste);
            'Xml.WriteElementString("impresorabob", Configuracion.ConfigSistema.ImpresoraEtiquetaBobina);
            'Xml.WriteElementString("impresoraemp", Configuracion.ConfigSistema.ImpresoraEtiquetaEmpaque);
            'Xml.WriteElementString("impresoraubi", Configuracion.ConfigSistema.ImpresoraEtiquetaUbicacion);

            'Xml.WriteElementString("tmovil", Configuracion.ConfigSistema.TMovil);
            'Xml.WriteElementString("ultmod", Configuracion.ConfigSistema.UltMod);
            'Xml.WriteElementString("versionsma", Configuracion.ConfigSistema.VersionSMA);
            Xml.WriteEndElement()
            Xml.WriteEndElement()
            Xml.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'method using XmlTextReader
    Public Function leerConexion(ByVal tipo As Integer) As String
        If tipo = 1 Then
            Return GetConnectionStringFromXML(ArchivoConfig)
        Else
            Return GetConnectionStringFromXML2(ArchivoConfig)
        End If
    End Function

    'method using DataSet readXml
    Public Function leerConexion2() As String
        Dim con As String
        Dim dtConfig As DataTable = LeerConfiguracionXML(ArchivoConfig, "info")
        If dtConfig Is Nothing Then
            Return ""
        End If
        If dtConfig.Rows.Count <= 0 Then
            Return ""
        End If
        'con = dtConfig.Rows[0]["PRUEBA"].ToString().Trim();
        'ConfigSistema.URL = dtConfig.Rows[0]["codurl"].ToString().Trim();
        con = dtConfig.Rows(0)("codurl").ToString().Trim()
        Return con
    End Function
End Class
