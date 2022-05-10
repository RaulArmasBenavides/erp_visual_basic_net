Imports System.IO
Imports System.Text
Imports System.Web

Public Class FrmCSV


    Public Class ItemChart
        Public Property arg As Integer
        Public Property val As Integer
    End Class
    Private Sub LoadCSV(ByVal ficheroCSV As String, ByVal separador As Char, ByVal primeraLineaTitulo As Boolean, ByVal separadorCampos As String)

        Dim dbTabla As DataTable
        Dim tablaDatos As New DataTable
        ' dbTabla.Rows.Clear()
        Dim inicioFila As Integer = 0
        Dim lineas As String()
        Dim valor As String
        Dim etiquetaTitulos As String()
        Dim primelaLinea As String
        Dim dataGridS As DataRow
        Dim objPopulationList As New List(Of ItemChart)()
        Dim obj1 As ItemChart

        File.WriteAllText(Path.GetTempPath + "doc1", MyRichTextControl.Text.Replace("\n", "\r\n"))
        lineas = File.ReadAllLines(Path.GetTempPath + "doc1")
        If lineas.Length > 0 Then
            'Si la primea línea contiene el título  
            Dim etiquetaTitulosFinal As String()
            If primeraLineaTitulo Then
                primelaLinea = lineas(0)
                etiquetaTitulos = primelaLinea.Split(separador)
                Dim lista As New List(Of String)
                For Each campoActual As String In etiquetaTitulos
                    valor = campoActual
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    tablaDatos.Columns.Add(New DataColumn(valor))
                    lista.Add(valor)
                Next
                etiquetaTitulosFinal = lista.ToArray()
            Else
                primelaLinea = lineas(0)
                etiquetaTitulos = primelaLinea.Split(separador)
                Dim numero As Integer = 0
                Dim lista As New List(Of String)
                For Each campoActual As String In etiquetaTitulos
                    valor = "C" + Convert.ToString(numero)
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    tablaDatos.Columns.Add(New DataColumn(valor))
                    lista.Add(valor)
                    numero = numero + 1
                Next
                etiquetaTitulosFinal = lista.ToArray()
            End If

            'Resto de filas de datos
            If primeraLineaTitulo Then
                inicioFila = 1
            End If
            Dim Index As Integer = 0
            Dim columnIndex As Integer
            Dim filasDatos As String()

            For Index = inicioFila To lineas.Length
                If Index < lineas.Length Then
                    filasDatos = lineas(Index).Split(separador)
                End If

                dataGridS = tablaDatos.NewRow()
                columnIndex = 0
                For Each campoActual As String In etiquetaTitulosFinal
                    valor = filasDatos(columnIndex)
                    columnIndex = columnIndex + 1
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    dataGridS(campoActual) = valor
                Next
                obj1 = New ItemChart()
                obj1.arg = dataGridS(0)
                obj1.val = dataGridS(1)
                objPopulationList.Add(obj1)
                'tablaDatos.Rows.Add(dataGridS)
            Next
        End If
        'If (tablaDatos.Rows.Count > 0) Then
        '    'dbTabla.DataSource = tablaDatos
        'End If
        Dim objJSSerializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim strJSON As String
        Dim DataGlobal As String
        'Serialization .NET Object to JSON
        strJSON = objJSSerializer.Serialize(objPopulationList)
        DataGlobal = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(strJSON))
        myRichTextBoxResult.Text = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(DataGlobal))
    End Sub

    Private Sub ReadCSVContent(ByVal Richtext As String, ByVal separador As Char, ByVal primeraLineaTitulo As Boolean, ByVal separadorCampos As String)

        Dim tablaDatos As New DataTable
        Dim inicioFila As Integer = 0
        Dim lineas As String()
        Dim valor As String
        Dim etiquetaTitulos As String()
        Dim primelaLinea As String
        Dim dataGridS As DataRow
        Dim objPopulationList As New List(Of ItemChart)()
        Dim obj1 As ItemChart
        File.WriteAllText(Path.GetTempPath + "doc1", Richtext)
        lineas = File.ReadAllLines(Path.GetTempPath + "doc1")
        If lineas.Length > 0 Then
            'Si la primea línea contiene el título  
            Dim etiquetaTitulosFinal As String()
            If primeraLineaTitulo Then
                primelaLinea = lineas(0)
                etiquetaTitulos = primelaLinea.Split(separador)
                Dim lista As New List(Of String)
                For Each campoActual As String In etiquetaTitulos
                    valor = campoActual
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    tablaDatos.Columns.Add(New DataColumn(valor))
                    lista.Add(valor)
                Next
                etiquetaTitulosFinal = lista.ToArray()
            Else
                primelaLinea = lineas(0)
                etiquetaTitulos = primelaLinea.Split(separador)
                Dim numero As Integer = 0
                Dim lista As New List(Of String)
                For Each campoActual As String In etiquetaTitulos
                    valor = "C" + Convert.ToString(numero)
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    tablaDatos.Columns.Add(New DataColumn(valor))
                    lista.Add(valor)
                    numero = numero + 1
                Next
                etiquetaTitulosFinal = lista.ToArray()
            End If

            'Resto de filas de datos
            If primeraLineaTitulo Then
                inicioFila = 1
            End If
            Dim Index As Integer = 0
            Dim columnIndex As Integer
            Dim filasDatos As String()

            For Index = inicioFila To lineas.Length
                If Index < lineas.Length Then
                    filasDatos = lineas(Index).Split(separador)
                End If

                dataGridS = tablaDatos.NewRow()
                columnIndex = 0
                For Each campoActual As String In etiquetaTitulosFinal
                    valor = filasDatos(columnIndex)
                    columnIndex = columnIndex + 1
                    'Quitamos el posible carácter de inicio y fin de valor
                    If separadorCampos <> "" Then
                        valor = valor.TrimEnd(Convert.ToChar(separadorCampos))
                        valor = valor.TrimStart(Convert.ToChar(separadorCampos))
                    End If
                    dataGridS(campoActual) = valor
                Next
                obj1 = New ItemChart()
                obj1.arg = dataGridS(0)
                obj1.val = dataGridS(1)
                objPopulationList.Add(obj1)
            Next
        End If

        Dim objJSSerializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim strJSON As String
        Dim DataGlobal As String
        'Serialization .NET Object to JSON
        strJSON = objJSSerializer.Serialize(objPopulationList)
        DataGlobal = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(strJSON))
        myRichTextBoxResult.Text = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(DataGlobal))
    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        Try
            ReadCSVContent(MyRichTextControl.Text.Replace("\n", "\r\n"), ",", False, ",")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class