Public Class FrmReporteArticulos

    Private Sub FrmReporteArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema21.articulo_listar' table. You can move, or remove it, as needed.
        Me.articulo_listarTableAdapter.Fill(Me.DsSistema21.articulo_listar)
        Me.Articulo_listarTableAdapter1.Fill(Me.DsSistema211.articulo_listar)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class