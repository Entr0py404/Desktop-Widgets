<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_FlyingPet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_FlyingPet))
        Me.Timer_Walking = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TurningDecision = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_IdleDecision = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Flying = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowCursorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.PoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_ChangeModesDecision = New System.Windows.Forms.Timer(Me.components)
        Me.PixelBox_Pet = New Desktop_Widgets.PixelBox()
        Me.PixelBox_Emote = New Desktop_Widgets.PixelBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixelBox_Emote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer_Walking
        '
        Me.Timer_Walking.Interval = 10
        '
        'Timer_TurningDecision
        '
        Me.Timer_TurningDecision.Enabled = True
        Me.Timer_TurningDecision.Interval = 3500
        '
        'Timer_IdleDecision
        '
        Me.Timer_IdleDecision.Interval = 5000
        '
        'Timer_Flying
        '
        Me.Timer_Flying.Enabled = True
        Me.Timer_Flying.Interval = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem, Me.FollowCursorToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.PoopToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 130)
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
        'Timer_ChangeModesDecision
        '
        Me.Timer_ChangeModesDecision.Interval = 5000
        '
        'PixelBox_Pet
        '
        Me.PixelBox_Pet.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PixelBox_Pet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PixelBox_Pet.Location = New System.Drawing.Point(0, 38)
        Me.PixelBox_Pet.Name = "PixelBox_Pet"
        Me.PixelBox_Pet.Size = New System.Drawing.Size(76, 77)
        Me.PixelBox_Pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixelBox_Pet.TabIndex = 2
        Me.PixelBox_Pet.TabStop = False
        '
        'PixelBox_Emote
        '
        Me.PixelBox_Emote.Dock = System.Windows.Forms.DockStyle.Top
        Me.PixelBox_Emote.Location = New System.Drawing.Point(0, 0)
        Me.PixelBox_Emote.Name = "PixelBox_Emote"
        Me.PixelBox_Emote.Size = New System.Drawing.Size(76, 38)
        Me.PixelBox_Emote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PixelBox_Emote.TabIndex = 3
        Me.PixelBox_Emote.TabStop = False
        '
        'Form_FlyingPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(76, 115)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PixelBox_Pet)
        Me.Controls.Add(Me.PixelBox_Emote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_FlyingPet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Pet"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixelBox_Emote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer_Walking As Timer
    Friend WithEvents Timer_TurningDecision As Timer
    Friend WithEvents Timer_IdleDecision As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FollowCursorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PoopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_ChangeModesDecision As Timer
    Friend WithEvents Timer_Flying As Timer
    Friend WithEvents PixelBox_Pet As PixelBox
    Friend WithEvents PixelBox_Emote As PixelBox
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
End Class
