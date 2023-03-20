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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.TxtQuery = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAllProperties = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelCredentials = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkCredentials = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCredentials.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(59, 299)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(1221, 501)
        Me.txt_result.TabIndex = 7
        Me.txt_result.Text = ""
        '
        'txtProperty
        '
        Me.txtProperty.Location = New System.Drawing.Point(127, 263)
        Me.txtProperty.Name = "txtProperty"
        Me.txtProperty.Size = New System.Drawing.Size(326, 20)
        Me.txtProperty.TabIndex = 12
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(1124, 46)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 20)
        Me.btnConnect.TabIndex = 11
        Me.btnConnect.Text = "Read"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'TxtQuery
        '
        Me.TxtQuery.Location = New System.Drawing.Point(127, 72)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(949, 20)
        Me.TxtQuery.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Query LDAP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(127, 46)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(949, 20)
        Me.txtPath.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1124, 72)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 20)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 266)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Property"
        '
        'chkAllProperties
        '
        Me.chkAllProperties.AutoSize = True
        Me.chkAllProperties.Location = New System.Drawing.Point(59, 236)
        Me.chkAllProperties.Name = "chkAllProperties"
        Me.chkAllProperties.Size = New System.Drawing.Size(114, 17)
        Me.chkAllProperties.TabIndex = 19
        Me.chkAllProperties.Text = "Read all properties"
        Me.chkAllProperties.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "User"
        '
        'PanelCredentials
        '
        Me.PanelCredentials.Controls.Add(Me.TxtPassword)
        Me.PanelCredentials.Controls.Add(Me.TxtUser)
        Me.PanelCredentials.Controls.Add(Me.Label5)
        Me.PanelCredentials.Controls.Add(Me.Label4)
        Me.PanelCredentials.Location = New System.Drawing.Point(59, 130)
        Me.PanelCredentials.Name = "PanelCredentials"
        Me.PanelCredentials.Size = New System.Drawing.Size(394, 100)
        Me.PanelCredentials.TabIndex = 21
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(160, 55)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(216, 20)
        Me.TxtPassword.TabIndex = 23
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(160, 21)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(216, 20)
        Me.TxtUser.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Password"
        '
        'chkCredentials
        '
        Me.chkCredentials.AutoSize = True
        Me.chkCredentials.Location = New System.Drawing.Point(59, 107)
        Me.chkCredentials.Name = "chkCredentials"
        Me.chkCredentials.Size = New System.Drawing.Size(100, 17)
        Me.chkCredentials.TabIndex = 22
        Me.chkCredentials.Text = "Use Credentials"
        Me.chkCredentials.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Connection vía LDAP"
        '
        'FrmAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 852)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkCredentials)
        Me.Controls.Add(Me.PanelCredentials)
        Me.Controls.Add(Me.chkAllProperties)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.txtProperty)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txt_result)
        Me.Name = "FrmAD"
        Me.Text = "FrmAD"
        Me.PanelCredentials.ResumeLayout(False)
        Me.PanelCredentials.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_result As RichTextBox
    Friend WithEvents txtProperty As TextBox
    Private WithEvents btnConnect As Button
    Friend WithEvents TxtQuery As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPath As TextBox
    Private WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents chkAllProperties As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelCredentials As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkCredentials As CheckBox
    Friend WithEvents Label6 As Label
End Class
