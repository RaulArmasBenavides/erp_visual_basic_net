<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCSV
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
        Me.Read = New System.Windows.Forms.Button()
        Me.myRichTextBoxResult = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyRichTextControl
        '
        Me.MyRichTextControl.Location = New System.Drawing.Point(41, 30)
        Me.MyRichTextControl.Name = "MyRichTextControl"
        Me.MyRichTextControl.Size = New System.Drawing.Size(1262, 319)
        Me.MyRichTextControl.TabIndex = 0
        Me.MyRichTextControl.Text = ""
        '
        'Read
        '
        Me.Read.Location = New System.Drawing.Point(1320, 30)
        Me.Read.Name = "Read"
        Me.Read.Size = New System.Drawing.Size(75, 23)
        Me.Read.TabIndex = 1
        Me.Read.Text = "Read"
        Me.Read.UseVisualStyleBackColor = True
        '
        'myRichTextBoxResult
        '
        Me.myRichTextBoxResult.Location = New System.Drawing.Point(41, 390)
        Me.myRichTextBoxResult.Name = "myRichTextBoxResult"
        Me.myRichTextBoxResult.Size = New System.Drawing.Size(777, 319)
        Me.myRichTextBoxResult.TabIndex = 2
        Me.myRichTextBoxResult.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(836, 390)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(777, 319)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 374)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "JSON result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(833, 374)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1320, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Move"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 919)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.myRichTextBoxResult)
        Me.Controls.Add(Me.Read)
        Me.Controls.Add(Me.MyRichTextControl)
        Me.Name = "FrmCSV"
        Me.Text = "Reading CSV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyRichTextControl As RichTextBox
    Friend WithEvents Read As Button
    Friend WithEvents myRichTextBoxResult As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
