<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmvbCr
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
        Me.MyRichTextControl = New System.Windows.Forms.RichTextBox()
        Me.btnJustifyText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyRichTextControl
        '
        Me.MyRichTextControl.Location = New System.Drawing.Point(68, 49)
        Me.MyRichTextControl.Name = "MyRichTextControl"
        Me.MyRichTextControl.Size = New System.Drawing.Size(1025, 293)
        Me.MyRichTextControl.TabIndex = 1
        Me.MyRichTextControl.Text = ""
        '
        'btnJustifyText
        '
        Me.btnJustifyText.Location = New System.Drawing.Point(1018, 369)
        Me.btnJustifyText.Name = "btnJustifyText"
        Me.btnJustifyText.Size = New System.Drawing.Size(75, 23)
        Me.btnJustifyText.TabIndex = 2
        Me.btnJustifyText.Text = "Justify Text"
        Me.btnJustifyText.UseVisualStyleBackColor = True
        '
        'FrmvbCr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 437)
        Me.Controls.Add(Me.btnJustifyText)
        Me.Controls.Add(Me.MyRichTextControl)
        Me.Name = "FrmvbCr"
        Me.Text = "FrmvbCr"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyRichTextControl As RichTextBox
    Friend WithEvents btnJustifyText As Button
End Class
