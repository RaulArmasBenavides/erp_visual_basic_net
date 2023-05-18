Public Class FrmCliente_Venta
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(2).Width = 120
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 120
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 120

        DgvListado.Columns.Item("Seleccionar").Visible = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NPersona
            DgvListado.DataSource = Neg.ListarClientes()
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NPersona
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.BuscarClientes(Valor)
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Variables.IdCliente = DgvListado.SelectedCells.Item(1).Value
        Variables.NombreCliente = DgvListado.SelectedCells.Item(3).Value
        Me.Close()
    End Sub

    Private Sub FrmCliente_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class