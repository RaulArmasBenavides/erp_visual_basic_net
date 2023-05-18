<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalendarGoogle2
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
        Me.txt_result = New System.Windows.Forms.RichTextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(113, 99)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(999, 272)
        Me.txt_result.TabIndex = 52
        Me.txt_result.Tag = ""
        Me.txt_result.Text = ""
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(113, 48)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 20)
        Me.btnConnect.TabIndex = 51
        Me.btnConnect.Text = "Read with user"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'FrmCalendarGoogle2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 626)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "FrmCalendarGoogle2"
        Me.Text = "FrmCalendarGoogle2"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txt_result As RichTextBox
    Private WithEvents btnConnect As Button
End Class
