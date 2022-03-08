Public Class FrmVenta
    Private DtDetalle As New DataTable
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(3).Width = 150
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 70
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnAnular.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
    Private Sub FormatoArticulos()
        DgvArticulos.Columns(0).Visible = False
        DgvArticulos.Columns(1).Visible = False
        DgvArticulos.Columns(2).Width = 100
        DgvArticulos.Columns(3).Width = 100
        DgvArticulos.Columns(4).Width = 150
        DgvArticulos.Columns(5).Width = 100
        DgvArticulos.Columns(6).Width = 100
        DgvArticulos.Columns(7).Width = 200
        DgvArticulos.Columns(8).Width = 100
        DgvArticulos.Columns(9).Width = 100

    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NVenta
            DgvListado.DataSource = Neg.Listar()
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NVenta
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        BtnInsertar.Visible = True
        TxtValor.Text = ""
        TxtId.Text = ""
        TxtCodigo.Text = ""
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
        TxtSerieComprobante.Text = ""
        TxtNumComprobante.Text = ""
        DtDetalle.Clear()
        TxtSubTotal.Text = 0
        TxtTotalImpuesto.Text = 0
        TxtTotal.Text = 0
    End Sub
    Private Sub CrearTablaDetalle()
        Me.DtDetalle = New DataTable("Detalle")
        Me.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.DtDetalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "CODIGO"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "ARTICULO"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "STOCK"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "PRECIO"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "DESCUENTO"
        DgvDetalle.Columns(6).Width = 100
        DgvDetalle.Columns(7).HeaderText = "IMPORTE"
        DgvDetalle.Columns(7).Width = 100

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(3).ReadOnly = True
        DgvDetalle.Columns(7).ReadOnly = True
    End Sub
    Private Sub AgregarDetalle(Fila As Entidades.Articulo)
        Dim Agregar As Boolean = True

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("idarticulo").Value) = Convert.ToInt32(Fila.IdArticulo)) Then
                Agregar = False
                MsgBox("El artículo ya ha sido agregado", vbOKOnly + vbCritical, "Error agregando detalles")
            End If
        Next
        If (Agregar) Then
            Dim Row As DataRow
            Row = Me.DtDetalle.NewRow()
            Row("idarticulo") = Convert.ToString(Fila.IdArticulo)
            Row("codigo") = Convert.ToString(Fila.Codigo)
            Row("articulo") = Convert.ToString(Fila.Nombre)
            Row("stock") = Convert.ToString(Fila.Stock)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Fila.PrecioVenta)
            Row("descuento") = Convert.ToString(0)
            Row("importe") = Convert.ToString(Fila.PrecioVenta)
            Me.DtDetalle.Rows.Add(Row)
            Me.CalcularTotales()
        End If
    End Sub
    Private Sub CalcularTotales()
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim TotalImpuesto As Decimal = 0

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            Total = Total + CDec(FilaTemp.Cells("importe").Value)
        Next

        SubTotal = Math.Round((Total / (1 + TxtImpuesto.Text)), 2)
        TxtTotal.Text = Total
        TxtSubTotal.Text = SubTotal
        TxtTotalImpuesto.Text = CStr(Total - SubTotal)

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FrmCliente_Venta.ShowDialog()
        TxtIdCliente.Text = Variables.IdCliente
        TxtNombreCliente.Text = Variables.NombreCliente
    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Dim Neg As New Negocio.NArticulo
                Dim Obj As New Entidades.Articulo
                Obj = Neg.BuscarCodigoVenta(TxtCodigo.Text)
                If (Obj Is Nothing) Then
                    MsgBox("No existe artículo con ese código de barras", vbOKOnly + vbCritical, "NO existe artículo")
                Else
                    Me.AgregarDetalle(Obj)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBuscarArticulos_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulos.Click
        PanelArticulos.Visible = True
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PanelArticulos.Visible = False
    End Sub

    Private Sub BtnBuscarArticulosDetalle_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulosDetalle.Click
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = TxtBuscarArticulos.Text
            DgvArticulos.DataSource = Neg.BuscarVenta(Valor)
            LblTotalArticulos.Text = "Total Artículos: " & DgvArticulos.DataSource.Rows.Count
            Me.FormatoArticulos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArticulos.CellDoubleClick
        Try
            Dim Obj As New Entidades.Articulo
            Obj.IdArticulo = DgvArticulos.SelectedCells.Item(0).Value
            Obj.Codigo = DgvArticulos.SelectedCells.Item(3).Value
            Obj.Nombre = DgvArticulos.SelectedCells.Item(4).Value
            Obj.PrecioVenta = DgvArticulos.SelectedCells.Item(5).Value
            Obj.Stock = DgvArticulos.SelectedCells.Item(6).Value
            Me.AgregarDetalle(Obj)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim Fila As DataGridViewRow = CType(DgvDetalle.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = Fila.Cells("precio").Value
        Dim Cantidad As Integer = Fila.Cells("cantidad").Value
        Dim Descuento As Decimal = Fila.Cells("descuento").Value
        Dim Stock As Integer = Fila.Cells("stock").Value
        Dim Articulo As String = Fila.Cells("articulo").Value

        If (Cantidad > Stock) Then
            Cantidad = Stock
            MsgBox("La cantidad de venta del artículo " & Articulo & " supera el stock disponible " & Stock, vbOKOnly + vbCritical, "Stock insuficiente")
        End If

        Fila.Cells("cantidad").Value = Cantidad
        Fila.Cells("importe").Value = (Precio * Cantidad) - Descuento
        Me.CalcularTotales()
    End Sub

    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotales()
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If (TxtIdCliente.Text <> "" And CboTipoComprobante.Text <> "" And TxtNumComprobante.Text <> "" And DtDetalle.Rows.Count > 0) Then
                Dim Obj As New Entidades.Venta
                Dim Neg As New Negocio.NVenta

                Obj.IdUsuario = Variables.IdUsuario
                Obj.IdCliente = TxtIdCliente.Text
                Obj.TipoComprobante = CboTipoComprobante.Text
                Obj.SerieComprobante = TxtSerieComprobante.Text
                Obj.NumComprobante = TxtNumComprobante.Text
                Obj.Impuesto = TxtImpuesto.Text
                Obj.Total = TxtTotal.Text

                If (Neg.Insertar(Obj, DtDetalle)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If

            Else
                MsgBox("Rellene todos los campos obligatorios, agregue al menos un detalle", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarM_Click(sender As Object, e As EventArgs) Handles BtnCerrarM.Click
        PanelMostrar.Visible = False
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.NVenta
            DgvMostrarDetalle.DataSource = Neg.ListarDetalle(DgvListado.SelectedCells.Item(1).Value)

            Dim Total As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0

            Total = DgvListado.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + DgvListado.SelectedCells.Item(9).Value), 2)
            TotalImpuesto = Total - SubTotal

            LblTotalM.Text = Total
            LblTotalImpuestoM.Text = TotalImpuesto
            LblSubTotalM.Text = SubTotal

            PanelMostrar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub
    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnAnular.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnAnular.Visible = False
        End If
    End Sub

    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If

    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If (MsgBox("Estas seguro de Anular las ventas seleccionados?", vbYesNo + vbQuestion, "Anular Ventas") = vbYes) Then
            Try
                Dim Neg As New Negocio.NVenta
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Anular(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CrearTablaDetalle()
    End Sub

    Private Sub BtnVerComprobante_Click(sender As Object, e As EventArgs) Handles BtnVerComprobante.Click
        Try
            Variables.IdVenta = DgvListado.SelectedCells.Item(1).Value
            FrmReporteComprobanteVenta.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class