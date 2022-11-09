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
        Me.btnRetrieveLists = New System.Windows.Forms.Button()
        Me.RichResultTextBox = New System.Windows.Forms.RichTextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRetrieveLists2 = New System.Windows.Forms.Button()
        Me.btnRetrieveLists3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyRichTextControl
        '
        Me.MyRichTextControl.Location = New System.Drawing.Point(68, 49)
        Me.MyRichTextControl.Name = "MyRichTextControl"
        Me.MyRichTextControl.Size = New System.Drawing.Size(1047, 180)
        Me.MyRichTextControl.TabIndex = 1
        Me.MyRichTextControl.Text = ""
        '
        'btnJustifyText
        '
        Me.btnJustifyText.Location = New System.Drawing.Point(1121, 49)
        Me.btnJustifyText.Name = "btnJustifyText"
        Me.btnJustifyText.Size = New System.Drawing.Size(75, 23)
        Me.btnJustifyText.TabIndex = 2
        Me.btnJustifyText.Text = "Justify Text"
        Me.btnJustifyText.UseVisualStyleBackColor = True
        '
        'btnRetrieveLists
        '
        Me.btnRetrieveLists.Location = New System.Drawing.Point(1121, 78)
        Me.btnRetrieveLists.Name = "btnRetrieveLists"
        Me.btnRetrieveLists.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrieveLists.TabIndex = 3
        Me.btnRetrieveLists.Text = "Leer Listas"
        Me.btnRetrieveLists.UseVisualStyleBackColor = True
        '
        'RichResultTextBox
        '
        Me.RichResultTextBox.Location = New System.Drawing.Point(68, 246)
        Me.RichResultTextBox.Name = "RichResultTextBox"
        Me.RichResultTextBox.Size = New System.Drawing.Size(1047, 180)
        Me.RichResultTextBox.TabIndex = 4
        Me.RichResultTextBox.Text = ""
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(1121, 107)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRetrieveLists2
        '
        Me.btnRetrieveLists2.Location = New System.Drawing.Point(1202, 78)
        Me.btnRetrieveLists2.Name = "btnRetrieveLists2"
        Me.btnRetrieveLists2.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrieveLists2.TabIndex = 6
        Me.btnRetrieveLists2.Text = "Leer Listas 2"
        Me.btnRetrieveLists2.UseVisualStyleBackColor = True
        '
        'btnRetrieveLists3
        '
        Me.btnRetrieveLists3.Location = New System.Drawing.Point(1283, 78)
        Me.btnRetrieveLists3.Name = "btnRetrieveLists3"
        Me.btnRetrieveLists3.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrieveLists3.TabIndex = 7
        Me.btnRetrieveLists3.Text = "Leer Listas 3"
        Me.btnRetrieveLists3.UseVisualStyleBackColor = True
        '
        'FrmvbCr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 527)
        Me.Controls.Add(Me.btnRetrieveLists3)
        Me.Controls.Add(Me.btnRetrieveLists2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.RichResultTextBox)
        Me.Controls.Add(Me.btnRetrieveLists)
        Me.Controls.Add(Me.btnJustifyText)
        Me.Controls.Add(Me.MyRichTextControl)
        Me.Name = "FrmvbCr"
        Me.Text = "FrmvbCr"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyRichTextControl As RichTextBox
    Friend WithEvents btnJustifyText As Button
    Friend WithEvents btnRetrieveLists As Button
    Friend WithEvents RichResultTextBox As RichTextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRetrieveLists2 As Button
    Friend WithEvents btnRetrieveLists3 As Button
End Class
