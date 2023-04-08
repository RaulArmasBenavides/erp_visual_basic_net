<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAPI_JWT
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCredentials = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtQuery = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_result = New System.Windows.Forms.RichTextBox()
        Me.PanelCredentials.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Connection to Zoom API ( JWT Authentication ) "
        '
        'PanelCredentials
        '
        Me.PanelCredentials.Controls.Add(Me.TxtPassword)
        Me.PanelCredentials.Controls.Add(Me.TxtUser)
        Me.PanelCredentials.Controls.Add(Me.Label5)
        Me.PanelCredentials.Controls.Add(Me.Label4)
        Me.PanelCredentials.Location = New System.Drawing.Point(144, 185)
        Me.PanelCredentials.Name = "PanelCredentials"
        Me.PanelCredentials.Size = New System.Drawing.Size(338, 100)
        Me.PanelCredentials.TabIndex = 34
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(99, 50)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(216, 20)
        Me.TxtPassword.TabIndex = 23
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(99, 16)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(216, 20)
        Me.TxtUser.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "User"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1141, 92)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 20)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(144, 66)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(949, 20)
        Me.txtPath.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Uri"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "grant type"
        '
        'TxtQuery
        '
        Me.TxtQuery.Location = New System.Drawing.Point(144, 92)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(949, 20)
        Me.TxtQuery.TabIndex = 27
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(1141, 66)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 20)
        Me.btnConnect.TabIndex = 25
        Me.btnConnect.Text = "Read"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(949, 20)
        Me.TextBox1.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "account id"
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(144, 310)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(997, 278)
        Me.txt_result.TabIndex = 40
        Me.txt_result.Tag = ""
        Me.txt_result.Text = ""
        '
        'FrmAPI_JWT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 687)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelCredentials)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "FrmAPI_JWT"
        Me.Text = "JWT"
        Me.PanelCredentials.ResumeLayout(False)
        Me.PanelCredentials.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents PanelCredentials As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents Button2 As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtQuery As TextBox
    Private WithEvents btnConnect As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents txt_result As RichTextBox
End Class
