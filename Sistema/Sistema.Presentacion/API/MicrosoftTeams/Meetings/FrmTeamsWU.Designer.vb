<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTeamsWU
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
        Me.txt_result = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCredentials = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtSecret = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelCredentials.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(104, 292)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(999, 272)
        Me.txt_result.TabIndex = 50
        Me.txt_result.Tag = ""
        Me.txt_result.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Cliend ID"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(104, 111)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(949, 20)
        Me.txtClientID.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(289, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Connection to Zoom API ( Server to Server Authentication ) "
        '
        'PanelCredentials
        '
        Me.PanelCredentials.Controls.Add(Me.TxtPassword)
        Me.PanelCredentials.Controls.Add(Me.TxtUser)
        Me.PanelCredentials.Controls.Add(Me.Label5)
        Me.PanelCredentials.Controls.Add(Me.Label4)
        Me.PanelCredentials.Location = New System.Drawing.Point(104, 163)
        Me.PanelCredentials.Name = "PanelCredentials"
        Me.PanelCredentials.Size = New System.Drawing.Size(417, 100)
        Me.PanelCredentials.TabIndex = 46
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(101, 50)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(286, 20)
        Me.TxtPassword.TabIndex = 23
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(101, 20)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(286, 20)
        Me.TxtUser.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Password "
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
        Me.Button2.Location = New System.Drawing.Point(1074, 126)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 20)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(104, 66)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(949, 20)
        Me.txtPath.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Uri"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(1074, 66)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 20)
        Me.btnConnect.TabIndex = 40
        Me.btnConnect.Text = "Read with user"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtSecret
        '
        Me.txtSecret.Location = New System.Drawing.Point(104, 137)
        Me.txtSecret.Name = "txtSecret"
        Me.txtSecret.Size = New System.Drawing.Size(949, 20)
        Me.txtSecret.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "secret"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1074, 94)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 20)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Read without user"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmTeamsWU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 600)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSecret)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelCredentials)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "FrmTeamsWU"
        Me.Text = "FrmTeamsWOU"
        Me.PanelCredentials.ResumeLayout(False)
        Me.PanelCredentials.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_result As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelCredentials As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents Button2 As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents btnConnect As Button
    Friend WithEvents txtSecret As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents Button1 As Button
End Class
