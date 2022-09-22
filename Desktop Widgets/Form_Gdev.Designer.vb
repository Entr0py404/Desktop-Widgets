<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Gdev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Gdev))
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar_ObjectScale = New System.Windows.Forms.TrackBar()
        Me.CheckBox_TopMost = New System.Windows.Forms.CheckBox()
        Me.CheckBox_FollowCursor = New System.Windows.Forms.CheckBox()
        Me.Button_Spawn = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.CheckBox_TTS = New System.Windows.Forms.CheckBox()
        Me.RadioButton_TTSMale = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TTSFemale = New System.Windows.Forms.RadioButton()
        Me.Label_TSSVolume = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar_TSSVolume = New System.Windows.Forms.TrackBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_Flowers_Min = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_SpeechFont = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_Display = New System.Windows.Forms.ComboBox()
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_TSSVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Flowers_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Scale
        '
        Me.Label_Scale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Scale.Location = New System.Drawing.Point(392, 16)
        Me.Label_Scale.Name = "Label_Scale"
        Me.Label_Scale.Size = New System.Drawing.Size(48, 40)
        Me.Label_Scale.TabIndex = 57
        Me.Label_Scale.Text = "1x"
        Me.Label_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 40)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Scale"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar_ObjectScale
        '
        Me.TrackBar_ObjectScale.Location = New System.Drawing.Point(64, 16)
        Me.TrackBar_ObjectScale.Minimum = 1
        Me.TrackBar_ObjectScale.Name = "TrackBar_ObjectScale"
        Me.TrackBar_ObjectScale.Size = New System.Drawing.Size(328, 45)
        Me.TrackBar_ObjectScale.TabIndex = 55
        Me.TrackBar_ObjectScale.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar_ObjectScale.Value = 1
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.AutoSize = True
        Me.CheckBox_TopMost.Checked = True
        Me.CheckBox_TopMost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TopMost.Location = New System.Drawing.Point(144, 72)
        Me.CheckBox_TopMost.Name = "CheckBox_TopMost"
        Me.CheckBox_TopMost.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox_TopMost.TabIndex = 54
        Me.CheckBox_TopMost.Text = "Always On Top"
        Me.CheckBox_TopMost.UseVisualStyleBackColor = True
        '
        'CheckBox_FollowCursor
        '
        Me.CheckBox_FollowCursor.AutoSize = True
        Me.CheckBox_FollowCursor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_FollowCursor.Location = New System.Drawing.Point(32, 72)
        Me.CheckBox_FollowCursor.Name = "CheckBox_FollowCursor"
        Me.CheckBox_FollowCursor.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox_FollowCursor.TabIndex = 53
        Me.CheckBox_FollowCursor.Text = "Follow Cursor"
        Me.CheckBox_FollowCursor.UseVisualStyleBackColor = True
        '
        'Button_Spawn
        '
        Me.Button_Spawn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Spawn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Spawn.FlatAppearance.BorderSize = 0
        Me.Button_Spawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Spawn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Spawn.Location = New System.Drawing.Point(296, 232)
        Me.Button_Spawn.Name = "Button_Spawn"
        Me.Button_Spawn.Size = New System.Drawing.Size(120, 32)
        Me.Button_Spawn.TabIndex = 58
        Me.Button_Spawn.Text = "Spawn"
        Me.Button_Spawn.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.Tomato
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Close.FlatAppearance.BorderSize = 0
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(32, 232)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(120, 32)
        Me.Button_Close.TabIndex = 59
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = False
        '
        'CheckBox_TTS
        '
        Me.CheckBox_TTS.AutoSize = True
        Me.CheckBox_TTS.Checked = True
        Me.CheckBox_TTS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TTS.Location = New System.Drawing.Point(32, 104)
        Me.CheckBox_TTS.Name = "CheckBox_TTS"
        Me.CheckBox_TTS.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox_TTS.TabIndex = 60
        Me.CheckBox_TTS.Text = "TTS"
        Me.CheckBox_TTS.UseVisualStyleBackColor = True
        '
        'RadioButton_TTSMale
        '
        Me.RadioButton_TTSMale.AutoSize = True
        Me.RadioButton_TTSMale.Location = New System.Drawing.Point(160, 104)
        Me.RadioButton_TTSMale.Name = "RadioButton_TTSMale"
        Me.RadioButton_TTSMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_TTSMale.TabIndex = 61
        Me.RadioButton_TTSMale.Text = "Male"
        Me.RadioButton_TTSMale.UseVisualStyleBackColor = True
        '
        'RadioButton_TTSFemale
        '
        Me.RadioButton_TTSFemale.AutoSize = True
        Me.RadioButton_TTSFemale.Checked = True
        Me.RadioButton_TTSFemale.Location = New System.Drawing.Point(88, 104)
        Me.RadioButton_TTSFemale.Name = "RadioButton_TTSFemale"
        Me.RadioButton_TTSFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_TTSFemale.TabIndex = 62
        Me.RadioButton_TTSFemale.TabStop = True
        Me.RadioButton_TTSFemale.Text = "Female"
        Me.RadioButton_TTSFemale.UseVisualStyleBackColor = True
        '
        'Label_TSSVolume
        '
        Me.Label_TSSVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TSSVolume.Location = New System.Drawing.Point(392, 136)
        Me.Label_TSSVolume.Name = "Label_TSSVolume"
        Me.Label_TSSVolume.Size = New System.Drawing.Size(48, 40)
        Me.Label_TSSVolume.TabIndex = 65
        Me.Label_TSSVolume.Text = "50%"
        Me.Label_TSSVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 48)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "TSS Volume"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar_TSSVolume
        '
        Me.TrackBar_TSSVolume.Location = New System.Drawing.Point(104, 136)
        Me.TrackBar_TSSVolume.Maximum = 100
        Me.TrackBar_TSSVolume.Name = "TrackBar_TSSVolume"
        Me.TrackBar_TSSVolume.Size = New System.Drawing.Size(288, 45)
        Me.TrackBar_TSSVolume.TabIndex = 63
        Me.TrackBar_TSSVolume.TickFrequency = 10
        Me.TrackBar_TSSVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar_TSSVolume.Value = 50
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(32, 192)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(193, 17)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Reminder to get up from desk"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown_Flowers_Min
        '
        Me.NumericUpDown_Flowers_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_Flowers_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_Flowers_Min.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_Flowers_Min.Location = New System.Drawing.Point(232, 192)
        Me.NumericUpDown_Flowers_Min.Name = "NumericUpDown_Flowers_Min"
        Me.NumericUpDown_Flowers_Min.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_Flowers_Min.TabIndex = 67
        Me.NumericUpDown_Flowers_Min.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Minutes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_SpeechFont
        '
        Me.Button_SpeechFont.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SpeechFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SpeechFont.FlatAppearance.BorderSize = 0
        Me.Button_SpeechFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SpeechFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SpeechFont.Location = New System.Drawing.Point(168, 232)
        Me.Button_SpeechFont.Name = "Button_SpeechFont"
        Me.Button_SpeechFont.Size = New System.Drawing.Size(120, 32)
        Me.Button_SpeechFont.TabIndex = 70
        Me.Button_SpeechFont.Text = "Speech Font"
        Me.Button_SpeechFont.UseVisualStyleBackColor = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Display"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_Display
        '
        Me.ComboBox_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Display.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Display.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Display.FormattingEnabled = True
        Me.ComboBox_Display.Location = New System.Drawing.Point(336, 72)
        Me.ComboBox_Display.Name = "ComboBox_Display"
        Me.ComboBox_Display.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox_Display.TabIndex = 71
        '
        'Form_Gdev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 274)
        Me.Controls.Add(Me.Label_Scale)
        Me.Controls.Add(Me.Label_TSSVolume)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_Display)
        Me.Controls.Add(Me.Button_SpeechFont)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown_Flowers_Min)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar_TSSVolume)
        Me.Controls.Add(Me.RadioButton_TTSFemale)
        Me.Controls.Add(Me.RadioButton_TTSMale)
        Me.Controls.Add(Me.CheckBox_TTS)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Spawn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TrackBar_ObjectScale)
        Me.Controls.Add(Me.CheckBox_TopMost)
        Me.Controls.Add(Me.CheckBox_FollowCursor)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Gdev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDev Hero"
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_TSSVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Flowers_Min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label_Scale As Label
    Private WithEvents Label9 As Label
    Friend WithEvents TrackBar_ObjectScale As TrackBar
    Friend WithEvents CheckBox_TopMost As CheckBox
    Friend WithEvents CheckBox_FollowCursor As CheckBox
    Friend WithEvents Button_Spawn As Button
    Friend WithEvents Button_Close As Button
    Friend WithEvents CheckBox_TTS As CheckBox
    Friend WithEvents RadioButton_TTSMale As RadioButton
    Friend WithEvents RadioButton_TTSFemale As RadioButton
    Private WithEvents Label_TSSVolume As Label
    Private WithEvents Label2 As Label
    Friend WithEvents TrackBar_TSSVolume As TrackBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NumericUpDown_Flowers_Min As NumericUpDown
    Private WithEvents Label3 As Label
    Friend WithEvents Button_SpeechFont As Button
    Friend WithEvents FontDialog1 As FontDialog
    Private WithEvents Label1 As Label
    Friend WithEvents ComboBox_Display As ComboBox
End Class
