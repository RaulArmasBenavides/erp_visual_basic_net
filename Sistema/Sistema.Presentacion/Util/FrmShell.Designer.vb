<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShell
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
        Me.btnShell1 = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShell1
        '
        Me.btnShell1.Location = New System.Drawing.Point(943, 56)
        Me.btnShell1.Name = "btnShell1"
        Me.btnShell1.Size = New System.Drawing.Size(100, 23)
        Me.btnShell1.TabIndex = 3
        Me.btnShell1.Text = "Shell"
        Me.btnShell1.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(44, 37)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(837, 20)
        Me.TxtEmail.TabIndex = 4
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(943, 85)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(100, 23)
        Me.btnOpen.TabIndex = 5
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(943, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print Process"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(943, 143)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 23)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar XML"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'FrmShell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 553)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.btnShell1)
        Me.Name = "FrmShell"
        Me.Text = "FrmShell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShell1 As Button
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGenerar As Button
End Class
