<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAD
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
        Me.txtProperty = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(59, 129)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(1222, 626)
        Me.txt_result.TabIndex = 7
        Me.txt_result.Text = ""
        '
        'txtProperty
        '
        Me.txtProperty.Location = New System.Drawing.Point(59, 77)
        Me.txtProperty.Name = "txtProperty"
        Me.txtProperty.Size = New System.Drawing.Size(148, 20)
        Me.txtProperty.TabIndex = 12
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(222, 77)
        Me.button1.Margin = New System.Windows.Forms.Padding(2)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(156, 31)
        Me.button1.TabIndex = 11
        Me.button1.Text = "LDAP"
        Me.button1.UseVisualStyleBackColor = True
        '
        'FrmAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 852)
        Me.Controls.Add(Me.txtProperty)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txt_result)
        Me.Name = "FrmAD"
        Me.Text = "FrmAD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_result As RichTextBox
    Friend WithEvents txtProperty As TextBox
    Private WithEvents button1 As Button
End Class
