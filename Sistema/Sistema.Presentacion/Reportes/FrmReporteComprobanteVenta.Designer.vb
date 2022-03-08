<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteComprobanteVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsSistema21 = New Sistema.Presentacion.DsSistema21()
        Me.venta_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.venta_comprobanteTableAdapter = New Sistema.Presentacion.DsSistema21TableAdapters.venta_comprobanteTableAdapter()
        CType(Me.DsSistema21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venta_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsComprobanteVenta"
        ReportDataSource1.Value = Me.venta_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.RptComprobanteVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1379, 761)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsSistema21
        '
        Me.DsSistema21.DataSetName = "DsSistema21"
        Me.DsSistema21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venta_comprobanteBindingSource
        '
        Me.venta_comprobanteBindingSource.DataMember = "venta_comprobante"
        Me.venta_comprobanteBindingSource.DataSource = Me.DsSistema21
        '
        'venta_comprobanteTableAdapter
        '
        ' Me.venta_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteComprobanteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 761)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteComprobanteVenta"
        Me.Text = "Comprobante de venta"
        CType(Me.DsSistema21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venta_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venta_comprobanteBindingSource As BindingSource
    Friend WithEvents DsSistema21 As DsSistema21
    'Friend WithEvents venta_comprobanteTableAdapter As DsSistema21TableAdapters.venta_comprobanteTableAdapter
End Class
