<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Pets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Pets))
        Me.CheckBox_FollowCursor = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TopMost = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip_GroundPets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem_GroundPets = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_FlyingPets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem_FlyingPets = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar_ObjectScale = New System.Windows.Forms.TrackBar()
        Me.Button_CloseSelected = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroundPetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlyingPetsTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Display = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_AssetCount = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Small_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medium_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Large_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_GroundPets.SuspendLayout()
        Me.ContextMenuStrip_FlyingPets.SuspendLayout()
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox_FollowCursor
        '
        Me.CheckBox_FollowCursor.AutoSize = True
        Me.CheckBox_FollowCursor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_FollowCursor.Location = New System.Drawing.Point(36, 62)
        Me.CheckBox_FollowCursor.Name = "CheckBox_FollowCursor"
        Me.CheckBox_FollowCursor.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox_FollowCursor.TabIndex = 3
        Me.CheckBox_FollowCursor.Text = "Follow Cursor"
        Me.CheckBox_FollowCursor.UseVisualStyleBackColor = True
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.AutoSize = True
        Me.CheckBox_TopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TopMost.Location = New System.Drawing.Point(156, 62)
        Me.CheckBox_TopMost.Name = "CheckBox_TopMost"
        Me.CheckBox_TopMost.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox_TopMost.TabIndex = 4
        Me.CheckBox_TopMost.Text = "Always On Top"
        Me.CheckBox_TopMost.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip_GroundPets
        '
        Me.ContextMenuStrip_GroundPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip_GroundPets.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_GroundPets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem_GroundPets})
        Me.ContextMenuStrip_GroundPets.Name = "ContextMenuStrip_GroundPets"
        Me.ContextMenuStrip_GroundPets.ShowImageMargin = False
        Me.ContextMenuStrip_GroundPets.Size = New System.Drawing.Size(101, 28)
        '
        'ReloadToolStripMenuItem_GroundPets
        '
        Me.ReloadToolStripMenuItem_GroundPets.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem_GroundPets.Name = "ReloadToolStripMenuItem_GroundPets"
        Me.ReloadToolStripMenuItem_GroundPets.Size = New System.Drawing.Size(100, 24)
        Me.ReloadToolStripMenuItem_GroundPets.Text = "Reload"
        '
        'ContextMenuStrip_FlyingPets
        '
        Me.ContextMenuStrip_FlyingPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip_FlyingPets.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_FlyingPets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem_FlyingPets})
        Me.ContextMenuStrip_FlyingPets.Name = "ContextMenuStrip_FlyingPets"
        Me.ContextMenuStrip_FlyingPets.ShowImageMargin = False
        Me.ContextMenuStrip_FlyingPets.Size = New System.Drawing.Size(101, 28)
        '
        'ReloadToolStripMenuItem_FlyingPets
        '
        Me.ReloadToolStripMenuItem_FlyingPets.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem_FlyingPets.Name = "ReloadToolStripMenuItem_FlyingPets"
        Me.ReloadToolStripMenuItem_FlyingPets.Size = New System.Drawing.Size(100, 24)
        Me.ReloadToolStripMenuItem_FlyingPets.Text = "Reload"
        '
        'Label_Scale
        '
        Me.Label_Scale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Scale.Location = New System.Drawing.Point(464, 8)
        Me.Label_Scale.Name = "Label_Scale"
        Me.Label_Scale.Size = New System.Drawing.Size(56, 40)
        Me.Label_Scale.TabIndex = 52
        Me.Label_Scale.Text = "1x"
        Me.Label_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 40)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Scale"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar_ObjectScale
        '
        Me.TrackBar_ObjectScale.Location = New System.Drawing.Point(72, 8)
        Me.TrackBar_ObjectScale.Minimum = 1
        Me.TrackBar_ObjectScale.Name = "TrackBar_ObjectScale"
        Me.TrackBar_ObjectScale.Size = New System.Drawing.Size(392, 45)
        Me.TrackBar_ObjectScale.TabIndex = 50
        Me.TrackBar_ObjectScale.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar_ObjectScale.Value = 1
        '
        'Button_CloseSelected
        '
        Me.Button_CloseSelected.BackColor = System.Drawing.Color.Tomato
        Me.Button_CloseSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_CloseSelected.FlatAppearance.BorderSize = 0
        Me.Button_CloseSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CloseSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CloseSelected.Location = New System.Drawing.Point(216, 8)
        Me.Button_CloseSelected.Name = "Button_CloseSelected"
        Me.Button_CloseSelected.Size = New System.Drawing.Size(88, 32)
        Me.Button_CloseSelected.TabIndex = 71
        Me.Button_CloseSelected.Text = "Close"
        Me.Button_CloseSelected.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Close All"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All Pets", "Ground Pets", "Flying Pets"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 69
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroundPetsToolStripMenuItem, Me.FlyingPetsTextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 29)
        Me.MenuStrip1.TabIndex = 119
        '
        'GroundPetsToolStripMenuItem
        '
        Me.GroundPetsToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroundPetsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroundPetsToolStripMenuItem.Name = "GroundPetsToolStripMenuItem"
        Me.GroundPetsToolStripMenuItem.Size = New System.Drawing.Size(107, 25)
        Me.GroundPetsToolStripMenuItem.Text = "Ground Pets"
        '
        'FlyingPetsTextToolStripMenuItem
        '
        Me.FlyingPetsTextToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlyingPetsTextToolStripMenuItem.Name = "FlyingPetsTextToolStripMenuItem"
        Me.FlyingPetsTextToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.FlyingPetsTextToolStripMenuItem.Text = "Flying Pets"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 32)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(537, 301)
        Me.FlowLayoutPanel1.TabIndex = 121
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 32)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(537, 301)
        Me.FlowLayoutPanel2.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Display"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_Display
        '
        Me.ComboBox_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Display.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Display.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Display.FormattingEnabled = True
        Me.ComboBox_Display.Location = New System.Drawing.Point(352, 60)
        Me.ComboBox_Display.Name = "ComboBox_Display"
        Me.ComboBox_Display.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox_Display.TabIndex = 121
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button_CloseSelected)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 42)
        Me.Panel1.TabIndex = 123
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.CheckBox_FollowCursor)
        Me.Panel2.Controls.Add(Me.CheckBox_TopMost)
        Me.Panel2.Controls.Add(Me.TrackBar_ObjectScale)
        Me.Panel2.Controls.Add(Me.Label_Scale)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox_Display)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(537, 91)
        Me.Panel2.TabIndex = 124
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 333)
        Me.Panel3.TabIndex = 125
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Label_AssetCount)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(537, 32)
        Me.Panel6.TabIndex = 122
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "☰"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label_AssetCount
        '
        Me.Label_AssetCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_AssetCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_AssetCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AssetCount.Location = New System.Drawing.Point(0, 0)
        Me.Label_AssetCount.Name = "Label_AssetCount"
        Me.Label_AssetCount.Size = New System.Drawing.Size(537, 32)
        Me.Label_AssetCount.TabIndex = 101
        Me.Label_AssetCount.Text = "0 Pets"
        Me.Label_AssetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Small_ToolStripMenuItem, Me.Medium_ToolStripMenuItem, Me.MediumLarge_ToolStripMenuItem, Me.Large_ToolStripMenuItem, Me.ExtraLarge_ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.ShowCheckMargin = True
        Me.ContextMenuStrip2.ShowImageMargin = False
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(175, 124)
        '
        'Small_ToolStripMenuItem
        '
        Me.Small_ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Small_ToolStripMenuItem.Name = "Small_ToolStripMenuItem"
        Me.Small_ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.Small_ToolStripMenuItem.Text = "Small"
        '
        'Medium_ToolStripMenuItem
        '
        Me.Medium_ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Medium_ToolStripMenuItem.Name = "Medium_ToolStripMenuItem"
        Me.Medium_ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.Medium_ToolStripMenuItem.Text = "Medium"
        '
        'MediumLarge_ToolStripMenuItem
        '
        Me.MediumLarge_ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MediumLarge_ToolStripMenuItem.Name = "MediumLarge_ToolStripMenuItem"
        Me.MediumLarge_ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.MediumLarge_ToolStripMenuItem.Text = "Medium Large"
        '
        'Large_ToolStripMenuItem
        '
        Me.Large_ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Large_ToolStripMenuItem.Name = "Large_ToolStripMenuItem"
        Me.Large_ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.Large_ToolStripMenuItem.Text = "Large"
        '
        'ExtraLarge_ToolStripMenuItem
        '
        Me.ExtraLarge_ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExtraLarge_ToolStripMenuItem.Name = "ExtraLarge_ToolStripMenuItem"
        Me.ExtraLarge_ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.ExtraLarge_ToolStripMenuItem.Text = "Extra Large"
        '
        'Form_Pets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 495)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Pets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Pets"
        Me.ContextMenuStrip_GroundPets.ResumeLayout(False)
        Me.ContextMenuStrip_FlyingPets.ResumeLayout(False)
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox_FollowCursor As CheckBox
    Friend WithEvents CheckBox_TopMost As CheckBox
    Friend WithEvents ContextMenuStrip_FlyingPets As ContextMenuStrip
    Friend WithEvents ContextMenuStrip_GroundPets As ContextMenuStrip
    Friend WithEvents ReloadToolStripMenuItem_GroundPets As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem_FlyingPets As ToolStripMenuItem
    Private WithEvents Label_Scale As Label
    Private WithEvents Label9 As Label
    Friend WithEvents TrackBar_ObjectScale As TrackBar
    Friend WithEvents Button_CloseSelected As Button
    Private WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroundPetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlyingPetsTextToolStripMenuItem As ToolStripMenuItem
    Private WithEvents Label2 As Label
    Friend WithEvents ComboBox_Display As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Small_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Medium_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Large_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtraLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_AssetCount As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
