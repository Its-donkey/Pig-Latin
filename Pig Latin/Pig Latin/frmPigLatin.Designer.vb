<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPigLatin
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
        Me.txtWordInput = New System.Windows.Forms.TextBox()
        Me.txtConversionOutput = New System.Windows.Forms.TextBox()
        Me.btnClearInputText = New System.Windows.Forms.Button()
        Me.btnConvertText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWordInput
        '
        Me.txtWordInput.Location = New System.Drawing.Point(13, 13)
        Me.txtWordInput.Multiline = True
        Me.txtWordInput.Name = "txtWordInput"
        Me.txtWordInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWordInput.Size = New System.Drawing.Size(637, 129)
        Me.txtWordInput.TabIndex = 0
        Me.txtWordInput.Text = "one two three four five"
        '
        'txtConversionOutput
        '
        Me.txtConversionOutput.Location = New System.Drawing.Point(12, 339)
        Me.txtConversionOutput.Multiline = True
        Me.txtConversionOutput.Name = "txtConversionOutput"
        Me.txtConversionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversionOutput.Size = New System.Drawing.Size(637, 129)
        Me.txtConversionOutput.TabIndex = 1
        '
        'btnClearInputText
        '
        Me.btnClearInputText.Location = New System.Drawing.Point(163, 221)
        Me.btnClearInputText.Name = "btnClearInputText"
        Me.btnClearInputText.Size = New System.Drawing.Size(75, 23)
        Me.btnClearInputText.TabIndex = 2
        Me.btnClearInputText.Text = "Clear"
        Me.btnClearInputText.UseVisualStyleBackColor = True
        '
        'btnConvertText
        '
        Me.btnConvertText.Location = New System.Drawing.Point(287, 221)
        Me.btnConvertText.Name = "btnConvertText"
        Me.btnConvertText.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertText.TabIndex = 3
        Me.btnConvertText.Text = "Convert"
        Me.btnConvertText.UseVisualStyleBackColor = True
        '
        'frmPigLatin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 480)
        Me.Controls.Add(Me.btnConvertText)
        Me.Controls.Add(Me.btnClearInputText)
        Me.Controls.Add(Me.txtConversionOutput)
        Me.Controls.Add(Me.txtWordInput)
        Me.Name = "frmPigLatin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWordInput As TextBox
    Friend WithEvents txtConversionOutput As TextBox
    Friend WithEvents btnClearInputText As Button
    Friend WithEvents btnConvertText As Button
End Class
