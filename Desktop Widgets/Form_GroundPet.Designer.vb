<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_GroundPet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GroundPet))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowCursorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_Walking = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Falling = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TurningDecision = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_IdleDecision = New System.Windows.Forms.Timer(Me.components)
        Me.PixelBox_Pet = New Desktop_Widgets.PixelBox()
        Me.Timer_Sleeping = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem, Me.FollowCursorToolStripMenuItem, Me.BehaviorToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 176)
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on top"
        '
        'FollowCursorToolStripMenuItem
        '
        Me.FollowCursorToolStripMenuItem.CheckOnClick = True
        Me.FollowCursorToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FollowCursorToolStripMenuItem.Name = "FollowCursorToolStripMenuItem"
        Me.FollowCursorToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.FollowCursorToolStripMenuItem.Text = "Follow cursor"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripComboBox})
        Me.DisplayToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'DisplayToolStripComboBox
        '
        Me.DisplayToolStripComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DisplayToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayToolStripComboBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DisplayToolStripComboBox.Name = "DisplayToolStripComboBox"
        Me.DisplayToolStripComboBox.Size = New System.Drawing.Size(200, 28)
        '
        'ScaleToolStripMenuItem
        '
        Me.ScaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScaleToolStripComboBox})
        Me.ScaleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        Me.ScaleToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ScaleToolStripMenuItem.Text = "Scale"
        '
        'ScaleToolStripComboBox
        '
        Me.ScaleToolStripComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ScaleToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScaleToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScaleToolStripComboBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ScaleToolStripComboBox.Items.AddRange(New Object() {"1x", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.ScaleToolStripComboBox.Name = "ScaleToolStripComboBox"
        Me.ScaleToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Timer_Walking
        '
        Me.Timer_Walking.Interval = 10
        '
        'Timer_Falling
        '
        Me.Timer_Falling.Interval = 1
        '
        'Timer_TurningDecision
        '
        Me.Timer_TurningDecision.Interval = 3500
        '
        'Timer_IdleDecision
        '
        Me.Timer_IdleDecision.Interval = 5000
        '
        'PixelBox_Pet
        '
        Me.PixelBox_Pet.BackColor = System.Drawing.Color.Fuchsia
        Me.PixelBox_Pet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PixelBox_Pet.Location = New System.Drawing.Point(0, 0)
        Me.PixelBox_Pet.Name = "PixelBox_Pet"
        Me.PixelBox_Pet.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox_Pet.Size = New System.Drawing.Size(32, 32)
        Me.PixelBox_Pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixelBox_Pet.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.PixelBox_Pet.TabIndex = 2
        Me.PixelBox_Pet.TabStop = False
        '
        'Timer_Sleeping
        '
        Me.Timer_Sleeping.Interval = 5000
        '
        'BehaviorToolStripMenuItem
        '
        Me.BehaviorToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BehaviorToolStripMenuItem.Name = "BehaviorToolStripMenuItem"
        Me.BehaviorToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.BehaviorToolStripMenuItem.Text = "Behavior"
        '
        'Form_GroundPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PixelBox_Pet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_GroundPet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Pet"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PixelBox_Pet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Timer_Falling As Timer
    Friend WithEvents Timer_TurningDecision As Timer
    Friend WithEvents Timer_IdleDecision As Timer
    Friend WithEvents FollowCursorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_Walking As Timer
    Friend WithEvents PixelBox_Pet As PixelBox
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripComboBox As ToolStripComboBox
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripComboBox As ToolStripComboBox
    Friend WithEvents Timer_Sleeping As Timer
    Friend WithEvents BehaviorToolStripMenuItem As ToolStripMenuItem
End Class
