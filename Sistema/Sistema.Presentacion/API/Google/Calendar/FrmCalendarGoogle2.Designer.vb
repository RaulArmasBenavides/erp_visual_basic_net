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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRestApiGoogleAuth = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(201, 245)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(1000, 117)
        Me.txt_result.TabIndex = 52
        Me.txt_result.Tag = ""
        Me.txt_result.Text = ""
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(1221, 287)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(135, 20)
        Me.btnConnect.TabIndex = 51
        Me.btnConnect.Text = "Read with user"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(201, 104)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1000, 99)
        Me.RichTextBox1.TabIndex = 53
        Me.RichTextBox1.Tag = ""
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Token with HTTP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "JSON credentials"
        '
        'btnRestApiGoogleAuth
        '
        Me.btnRestApiGoogleAuth.Location = New System.Drawing.Point(1221, 152)
        Me.btnRestApiGoogleAuth.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestApiGoogleAuth.Name = "btnRestApiGoogleAuth"
        Me.btnRestApiGoogleAuth.Size = New System.Drawing.Size(135, 20)
        Me.btnRestApiGoogleAuth.TabIndex = 56
        Me.btnRestApiGoogleAuth.Text = "Read with REST API"
        Me.btnRestApiGoogleAuth.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 413)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 20)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Create Meeting"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCalendarGoogle2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRestApiGoogleAuth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "FrmCalendarGoogle2"
        Me.Text = "FrmCalendarGoogle2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_result As RichTextBox
    Private WithEvents btnConnect As Button
    Private WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents btnRestApiGoogleAuth As Button
    Private WithEvents Button1 As Button
End Class
