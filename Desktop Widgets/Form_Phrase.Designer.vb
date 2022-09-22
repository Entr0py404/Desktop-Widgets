<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Phrase
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Phrase))
        Me.Label_Phrase = New System.Windows.Forms.Label()
        Me.Timer_AutoHide = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'Label_Phrase
        '
        Me.Label_Phrase.AutoSize = True
        Me.Label_Phrase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Phrase.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Phrase.ForeColor = System.Drawing.Color.Black
        Me.Label_Phrase.Location = New System.Drawing.Point(0, 0)
        Me.Label_Phrase.Name = "Label_Phrase"
        Me.Label_Phrase.Size = New System.Drawing.Size(66, 23)
        Me.Label_Phrase.TabIndex = 0
        Me.Label_Phrase.Text = "Phrase"
        Me.Label_Phrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_AutoHide
        '
        Me.Timer_AutoHide.Interval = 5000
        '
        'Form_Phrase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(174, 29)
        Me.Controls.Add(Me.Label_Phrase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Phrase"
        Me.Opacity = 0.85R
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Phrase As Label
    Friend WithEvents Timer_AutoHide As Timer
    Friend WithEvents FontDialog1 As FontDialog
End Class
