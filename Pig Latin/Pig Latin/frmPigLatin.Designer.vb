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
        Me.lblEnglishInput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPigLatinOutputText = New System.Windows.Forms.Label()
        Me.cmbSampleSelection = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtWordInput
        '
        Me.txtWordInput.Location = New System.Drawing.Point(12, 29)
        Me.txtWordInput.Multiline = True
        Me.txtWordInput.Name = "txtWordInput"
        Me.txtWordInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWordInput.Size = New System.Drawing.Size(637, 129)
        Me.txtWordInput.TabIndex = 0
        '
        'txtConversionOutput
        '
        Me.txtConversionOutput.Location = New System.Drawing.Point(12, 229)
        Me.txtConversionOutput.Multiline = True
        Me.txtConversionOutput.Name = "txtConversionOutput"
        Me.txtConversionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversionOutput.Size = New System.Drawing.Size(637, 129)
        Me.txtConversionOutput.TabIndex = 1
        '
        'btnClearInputText
        '
        Me.btnClearInputText.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearInputText.Location = New System.Drawing.Point(16, 174)
        Me.btnClearInputText.Name = "btnClearInputText"
        Me.btnClearInputText.Size = New System.Drawing.Size(94, 30)
        Me.btnClearInputText.TabIndex = 2
        Me.btnClearInputText.Text = "Clear"
        Me.btnClearInputText.UseVisualStyleBackColor = True
        '
        'btnConvertText
        '
        Me.btnConvertText.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvertText.Location = New System.Drawing.Point(180, 174)
        Me.btnConvertText.Name = "btnConvertText"
        Me.btnConvertText.Size = New System.Drawing.Size(94, 30)
        Me.btnConvertText.TabIndex = 3
        Me.btnConvertText.Text = "Convert"
        Me.btnConvertText.UseVisualStyleBackColor = True
        '
        'lblEnglishInput
        '
        Me.lblEnglishInput.AutoSize = True
        Me.lblEnglishInput.Location = New System.Drawing.Point(13, 13)
        Me.lblEnglishInput.Name = "lblEnglishInput"
        Me.lblEnglishInput.Size = New System.Drawing.Size(71, 13)
        Me.lblEnglishInput.TabIndex = 4
        Me.lblEnglishInput.Text = "English Input:"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(344, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPigLatinOutputText
        '
        Me.lblPigLatinOutputText.AutoSize = True
        Me.lblPigLatinOutputText.Location = New System.Drawing.Point(13, 213)
        Me.lblPigLatinOutputText.Name = "lblPigLatinOutputText"
        Me.lblPigLatinOutputText.Size = New System.Drawing.Size(135, 13)
        Me.lblPigLatinOutputText.TabIndex = 6
        Me.lblPigLatinOutputText.Text = "Pig-Latin translation output:"
        '
        'cmbSampleSelection
        '
        Me.cmbSampleSelection.FormattingEnabled = True
        Me.cmbSampleSelection.Items.AddRange(New Object() {"Sample 1", "Sample 2", "Sample 3", "Sample 4", "Sample 5"})
        Me.cmbSampleSelection.Location = New System.Drawing.Point(497, 180)
        Me.cmbSampleSelection.Name = "cmbSampleSelection"
        Me.cmbSampleSelection.Size = New System.Drawing.Size(121, 21)
        Me.cmbSampleSelection.TabIndex = 7
        Me.cmbSampleSelection.Text = "Select a sample"
        '
        'frmPigLatin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 368)
        Me.Controls.Add(Me.cmbSampleSelection)
        Me.Controls.Add(Me.lblPigLatinOutputText)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnglishInput)
        Me.Controls.Add(Me.btnConvertText)
        Me.Controls.Add(Me.btnClearInputText)
        Me.Controls.Add(Me.txtConversionOutput)
        Me.Controls.Add(Me.txtWordInput)
        Me.Name = "frmPigLatin"
        Me.Text = "Pig-Latin Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWordInput As TextBox
    Friend WithEvents txtConversionOutput As TextBox
    Friend WithEvents btnClearInputText As Button
    Friend WithEvents btnConvertText As Button
    Friend WithEvents lblEnglishInput As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPigLatinOutputText As Label
    Friend WithEvents cmbSampleSelection As ComboBox
End Class
