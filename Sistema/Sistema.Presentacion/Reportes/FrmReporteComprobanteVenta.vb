Public Class FrmReporteComprobanteVenta
    Private Sub FrmReporteComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_comprobante' table. You can move, or remove it, as needed.
        ' Me.venta_comprobanteTableAdapter.Fill('Me.DsSistema21.venta_comprobante, Variables.IdVenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class