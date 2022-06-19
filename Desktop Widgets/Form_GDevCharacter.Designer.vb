<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_GDevCharacter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GDevCharacter))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicRoadmapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtensionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpressionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JSDocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowCursorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.TTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Walking = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Falling = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TurningDecision = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_IdleDecision = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Speak = New System.Windows.Forms.Timer(Me.components)
        Me.SpeechFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PixelBox_Pet = New Desktop_Widgets.PixelBox()
        Me.PixelBox_Emote = New Desktop_Widgets.PixelBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixelBox_Emote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinksToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.FollowCursorToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.SpeechFontToolStripMenuItem, Me.TTSToolStripMenuItem, Me.PoopToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 202)
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrelloToolStripMenuItem, Me.WikiToolStripMenuItem, Me.WebAppToolStripMenuItem, Me.ExamplesToolStripMenuItem, Me.ExpressionsToolStripMenuItem, Me.JSDocumentationToolStripMenuItem})
        Me.LinksToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'TrelloToolStripMenuItem
        '
        Me.TrelloToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TrelloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PublicRoadmapToolStripMenuItem, Me.ExtensionsToolStripMenuItem, Me.AssetsToolStripMenuItem, Me.DocumentationToolStripMenuItem})
        Me.TrelloToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TrelloToolStripMenuItem.Name = "TrelloToolStripMenuItem"
        Me.TrelloToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.TrelloToolStripMenuItem.Text = "Trello"
        '
        'PublicRoadmapToolStripMenuItem
        '
        Me.PublicRoadmapToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PublicRoadmapToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PublicRoadmapToolStripMenuItem.Name = "PublicRoadmapToolStripMenuItem"
        Me.PublicRoadmapToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.PublicRoadmapToolStripMenuItem.Text = "Public roadmap"
        '
        'ExtensionsToolStripMenuItem
        '
        Me.ExtensionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ExtensionsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExtensionsToolStripMenuItem.Name = "ExtensionsToolStripMenuItem"
        Me.ExtensionsToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.ExtensionsToolStripMenuItem.Text = "Extensions"
        '
        'AssetsToolStripMenuItem
        '
        Me.AssetsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.AssetsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AssetsToolStripMenuItem.Name = "AssetsToolStripMenuItem"
        Me.AssetsToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.AssetsToolStripMenuItem.Text = "Assets"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DocumentationToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'WikiToolStripMenuItem
        '
        Me.WikiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.WikiToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WikiToolStripMenuItem.Name = "WikiToolStripMenuItem"
        Me.WikiToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.WikiToolStripMenuItem.Text = "Wiki"
        '
        'WebAppToolStripMenuItem
        '
        Me.WebAppToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.WebAppToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WebAppToolStripMenuItem.Name = "WebAppToolStripMenuItem"
        Me.WebAppToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.WebAppToolStripMenuItem.Text = "Web app"
        '
        'ExamplesToolStripMenuItem
        '
        Me.ExamplesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ExamplesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExamplesToolStripMenuItem.Name = "ExamplesToolStripMenuItem"
        Me.ExamplesToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ExamplesToolStripMenuItem.Text = "Examples"
        '
        'ExpressionsToolStripMenuItem
        '
        Me.ExpressionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ExpressionsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExpressionsToolStripMenuItem.Name = "ExpressionsToolStripMenuItem"
        Me.ExpressionsToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ExpressionsToolStripMenuItem.Text = "Expressions"
        '
        'JSDocumentationToolStripMenuItem
        '
        Me.JSDocumentationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.JSDocumentationToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.JSDocumentationToolStripMenuItem.Name = "JSDocumentationToolStripMenuItem"
        Me.JSDocumentationToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.JSDocumentationToolStripMenuItem.Text = "JS Documentation"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on top"
        '
        'FollowCursorToolStripMenuItem
        '
        Me.FollowCursorToolStripMenuItem.CheckOnClick = True
        Me.FollowCursorToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FollowCursorToolStripMenuItem.Name = "FollowCursorToolStripMenuItem"
        Me.FollowCursorToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.FollowCursorToolStripMenuItem.Text = "Follow cursor"
        '
        'ScaleToolStripMenuItem
        '
        Me.ScaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.ScaleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        Me.ScaleToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ScaleToolStripMenuItem.Text = "Scale"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"1x", "2x", "3x", "4x"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'TTSToolStripMenuItem
        '
        Me.TTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.GenderToolStripMenuItem})
        Me.TTSToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TTSToolStripMenuItem.Name = "TTSToolStripMenuItem"
        Me.TTSToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.TTSToolStripMenuItem.Text = "TTS"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.EnabledToolStripMenuItem.CheckOnClick = True
        Me.EnabledToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.EnabledToolStripMenuItem.Text = "Enabled"
        '
        'GenderToolStripMenuItem
        '
        Me.GenderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FemaleToolStripMenuItem, Me.MaleToolStripMenuItem})
        Me.GenderToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GenderToolStripMenuItem.Name = "GenderToolStripMenuItem"
        Me.GenderToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.GenderToolStripMenuItem.Text = "Gender"
        '
        'FemaleToolStripMenuItem
        '
        Me.FemaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FemaleToolStripMenuItem.CheckOnClick = True
        Me.FemaleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FemaleToolStripMenuItem.Name = "FemaleToolStripMenuItem"
        Me.FemaleToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.FemaleToolStripMenuItem.Text = "Female"
        '
        'MaleToolStripMenuItem
        '
        Me.MaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MaleToolStripMenuItem.CheckOnClick = True
        Me.MaleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MaleToolStripMenuItem.Name = "MaleToolStripMenuItem"
        Me.MaleToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.MaleToolStripMenuItem.Text = "Male"
        '
        'PoopToolStripMenuItem
        '
        Me.PoopToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PoopToolStripMenuItem.Name = "PoopToolStripMenuItem"
        Me.PoopToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.PoopToolStripMenuItem.Text = "Poop!"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Timer_Walking
        '
        Me.Timer_Walking.Enabled = True
        Me.Timer_Walking.Interval = 10
        '
        'Timer_Falling
        '
        Me.Timer_Falling.Enabled = True
        Me.Timer_Falling.Interval = 1
        '
        'Timer_TurningDecision
        '
        Me.Timer_TurningDecision.Enabled = True
        Me.Timer_TurningDecision.Interval = 3500
        '
        'Timer_IdleDecision
        '
        Me.Timer_IdleDecision.Enabled = True
        Me.Timer_IdleDecision.Interval = 5000
        '
        'Timer_Speak
        '
        Me.Timer_Speak.Enabled = True
        Me.Timer_Speak.Interval = 5000
        '
        'SpeechFontToolStripMenuItem
        '
        Me.SpeechFontToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpeechFontToolStripMenuItem.Name = "SpeechFontToolStripMenuItem"
        Me.SpeechFontToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.SpeechFontToolStripMenuItem.Text = "Speech Font"
        '
        'PixelBox_Pet
        '
        Me.PixelBox_Pet.BackColor = System.Drawing.Color.Fuchsia
        Me.PixelBox_Pet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PixelBox_Pet.Location = New System.Drawing.Point(0, 38)
        Me.PixelBox_Pet.Name = "PixelBox_Pet"
        Me.PixelBox_Pet.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox_Pet.Size = New System.Drawing.Size(156, 108)
        Me.PixelBox_Pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixelBox_Pet.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.PixelBox_Pet.TabIndex = 2
        Me.PixelBox_Pet.TabStop = False
        '
        'PixelBox_Emote
        '
        Me.PixelBox_Emote.BackColor = System.Drawing.Color.Fuchsia
        Me.PixelBox_Emote.Dock = System.Windows.Forms.DockStyle.Top
        Me.PixelBox_Emote.Location = New System.Drawing.Point(0, 0)
        Me.PixelBox_Emote.Name = "PixelBox_Emote"
        Me.PixelBox_Emote.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox_Emote.Size = New System.Drawing.Size(156, 38)
        Me.PixelBox_Emote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PixelBox_Emote.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.PixelBox_Emote.TabIndex = 3
        Me.PixelBox_Emote.TabStop = False
        '
        'Form_GDevCharacter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(156, 146)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PixelBox_Pet)
        Me.Controls.Add(Me.PixelBox_Emote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_GDevCharacter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDev Character"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixelBox_Emote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Timer_Falling As Timer
    Friend WithEvents Timer_TurningDecision As Timer
    Friend WithEvents Timer_IdleDecision As Timer
    Friend WithEvents FollowCursorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PoopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_Walking As Timer
    Friend WithEvents PixelBox_Pet As PixelBox
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents PixelBox_Emote As PixelBox
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrelloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublicRoadmapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtensionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpressionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WikiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamplesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JSDocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FemaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_Speak As Timer
    Friend WithEvents SpeechFontToolStripMenuItem As ToolStripMenuItem
End Class
