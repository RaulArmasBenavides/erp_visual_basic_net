<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteArticulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.articulo_listarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSistema21 = New Sistema.Presentacion.DsSistema21()
        Me.Articulo_listarTableAdapter1 = New Sistema.Presentacion.DsSistema21TableAdapters.articulo_listarTableAdapter()
        Me.DsSistema211 = New Sistema.Presentacion.DsSistema21()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.articulo_listarTableAdapter = New Sistema.Presentacion.DsSistema21TableAdapters.articulo_listarTableAdapter()
        CType(Me.articulo_listarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSistema21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSistema211, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'articulo_listarBindingSource
        '
        Me.articulo_listarBindingSource.DataMember = "articulo_listar"
        Me.articulo_listarBindingSource.DataSource = Me.DsSistema21
        '
        'DsSistema21
        '
        Me.DsSistema21.DataSetName = "DsSistema21"
        Me.DsSistema21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Articulo_listarTableAdapter1
        '
        Me.Articulo_listarTableAdapter1.ClearBeforeFill = True
        '
        'DsSistema211
        '
        Me.DsSistema211.DataSetName = "DsSistema21"
        Me.DsSistema211.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DsArticulo"
        ReportDataSource1.Value = Me.articulo_listarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.RptArticulos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(893, 510)
        Me.ReportViewer1.TabIndex = 0
        '
        'articulo_listarTableAdapter
        '
        Me.articulo_listarTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 644)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmReporteArticulos"
        Me.Text = "Reporte de artículos"
        CType(Me.articulo_listarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSistema21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSistema211, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Articulo_listarTableAdapter1 As DsSistema21TableAdapters.articulo_listarTableAdapter
    Friend WithEvents DsSistema211 As DsSistema21
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents articulo_listarBindingSource As BindingSource
    Friend WithEvents DsSistema21 As DsSistema21
    Friend WithEvents articulo_listarTableAdapter As DsSistema21TableAdapters.articulo_listarTableAdapter
End Class
