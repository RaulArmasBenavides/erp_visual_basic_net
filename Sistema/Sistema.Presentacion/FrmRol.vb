Public Class FrmRol
    Private Sub Formato()
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 150
        DgvListado.Columns(0).HeaderText = "ID"
        DgvListado.Columns(1).HeaderText = "Nombre"
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NRol
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class