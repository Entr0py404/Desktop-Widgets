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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView_GroundPets = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip_GroundPets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem_GroundPets = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_GroundPets = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListView_FlyingPets = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip_FlyingPets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem_FlyingPets = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_FlyingPets = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar_ObjectScale = New System.Windows.Forms.TrackBar()
        Me.Button_CloseSelected = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroundPetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlyingPetsTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_GroundPets = New System.Windows.Forms.TabPage()
        Me.TabPage_FlyingPets = New System.Windows.Forms.TabPage()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip_GroundPets.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip_FlyingPets.SuspendLayout()
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_GroundPets.SuspendLayout()
        Me.TabPage_FlyingPets.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox_FollowCursor
        '
        Me.CheckBox_FollowCursor.AutoSize = True
        Me.CheckBox_FollowCursor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_FollowCursor.Location = New System.Drawing.Point(8, 104)
        Me.CheckBox_FollowCursor.Name = "CheckBox_FollowCursor"
        Me.CheckBox_FollowCursor.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox_FollowCursor.TabIndex = 3
        Me.CheckBox_FollowCursor.Text = "Follow Cursor"
        Me.CheckBox_FollowCursor.UseVisualStyleBackColor = True
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.AutoSize = True
        Me.CheckBox_TopMost.Checked = True
        Me.CheckBox_TopMost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TopMost.Location = New System.Drawing.Point(120, 104)
        Me.CheckBox_TopMost.Name = "CheckBox_TopMost"
        Me.CheckBox_TopMost.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox_TopMost.TabIndex = 4
        Me.CheckBox_TopMost.Text = "Always On Top"
        Me.CheckBox_TopMost.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView_GroundPets)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 320)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ground Pets"
        '
        'ListView_GroundPets
        '
        Me.ListView_GroundPets.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView_GroundPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListView_GroundPets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_GroundPets.ContextMenuStrip = Me.ContextMenuStrip_GroundPets
        Me.ListView_GroundPets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_GroundPets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_GroundPets.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView_GroundPets.HideSelection = False
        Me.ListView_GroundPets.LabelWrap = False
        Me.ListView_GroundPets.LargeImageList = Me.ImageList_GroundPets
        Me.ListView_GroundPets.Location = New System.Drawing.Point(3, 18)
        Me.ListView_GroundPets.MultiSelect = False
        Me.ListView_GroundPets.Name = "ListView_GroundPets"
        Me.ListView_GroundPets.Size = New System.Drawing.Size(380, 299)
        Me.ListView_GroundPets.SmallImageList = Me.ImageList_GroundPets
        Me.ListView_GroundPets.TabIndex = 35
        Me.ListView_GroundPets.UseCompatibleStateImageBehavior = False
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
        'ImageList_GroundPets
        '
        Me.ImageList_GroundPets.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList_GroundPets.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList_GroundPets.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListView_FlyingPets)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(386, 320)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Flying Pets"
        '
        'ListView_FlyingPets
        '
        Me.ListView_FlyingPets.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView_FlyingPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListView_FlyingPets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_FlyingPets.ContextMenuStrip = Me.ContextMenuStrip_FlyingPets
        Me.ListView_FlyingPets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_FlyingPets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_FlyingPets.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView_FlyingPets.HideSelection = False
        Me.ListView_FlyingPets.LabelWrap = False
        Me.ListView_FlyingPets.LargeImageList = Me.ImageList_FlyingPets
        Me.ListView_FlyingPets.Location = New System.Drawing.Point(3, 18)
        Me.ListView_FlyingPets.MultiSelect = False
        Me.ListView_FlyingPets.Name = "ListView_FlyingPets"
        Me.ListView_FlyingPets.Size = New System.Drawing.Size(380, 299)
        Me.ListView_FlyingPets.SmallImageList = Me.ImageList_FlyingPets
        Me.ListView_FlyingPets.TabIndex = 34
        Me.ListView_FlyingPets.UseCompatibleStateImageBehavior = False
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
        'ImageList_FlyingPets
        '
        Me.ImageList_FlyingPets.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList_FlyingPets.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList_FlyingPets.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label_Scale
        '
        Me.Label_Scale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Scale.Location = New System.Drawing.Point(344, 48)
        Me.Label_Scale.Name = "Label_Scale"
        Me.Label_Scale.Size = New System.Drawing.Size(56, 40)
        Me.Label_Scale.TabIndex = 52
        Me.Label_Scale.Text = "1x"
        Me.Label_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 48)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Scale"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar_ObjectScale
        '
        Me.TrackBar_ObjectScale.Location = New System.Drawing.Point(72, 48)
        Me.TrackBar_ObjectScale.Maximum = 4
        Me.TrackBar_ObjectScale.Minimum = 1
        Me.TrackBar_ObjectScale.Name = "TrackBar_ObjectScale"
        Me.TrackBar_ObjectScale.Size = New System.Drawing.Size(272, 45)
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
        Me.Button_CloseSelected.Location = New System.Drawing.Point(240, 472)
        Me.Button_CloseSelected.Name = "Button_CloseSelected"
        Me.Button_CloseSelected.Size = New System.Drawing.Size(88, 32)
        Me.Button_CloseSelected.TabIndex = 71
        Me.Button_CloseSelected.Text = "Close"
        Me.Button_CloseSelected.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 472)
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
        Me.ComboBox1.Location = New System.Drawing.Point(80, 472)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 29)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_GroundPets)
        Me.TabControl1.Controls.Add(Me.TabPage_FlyingPets)
        Me.TabControl1.Location = New System.Drawing.Point(0, 112)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(400, 352)
        Me.TabControl1.TabIndex = 120
        '
        'TabPage_GroundPets
        '
        Me.TabPage_GroundPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TabPage_GroundPets.Controls.Add(Me.GroupBox3)
        Me.TabPage_GroundPets.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_GroundPets.Name = "TabPage_GroundPets"
        Me.TabPage_GroundPets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_GroundPets.Size = New System.Drawing.Size(392, 326)
        Me.TabPage_GroundPets.TabIndex = 0
        Me.TabPage_GroundPets.Text = "Ground Pets"
        '
        'TabPage_FlyingPets
        '
        Me.TabPage_FlyingPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TabPage_FlyingPets.Controls.Add(Me.GroupBox4)
        Me.TabPage_FlyingPets.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_FlyingPets.Name = "TabPage_FlyingPets"
        Me.TabPage_FlyingPets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_FlyingPets.Size = New System.Drawing.Size(392, 326)
        Me.TabPage_FlyingPets.TabIndex = 1
        Me.TabPage_FlyingPets.Text = "Flying Pets"
        '
        'Form_Pets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 513)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button_CloseSelected)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label_Scale)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TrackBar_ObjectScale)
        Me.Controls.Add(Me.CheckBox_TopMost)
        Me.Controls.Add(Me.CheckBox_FollowCursor)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Pets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Pets"
        Me.GroupBox3.ResumeLayout(False)
        Me.ContextMenuStrip_GroundPets.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ContextMenuStrip_FlyingPets.ResumeLayout(False)
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_GroundPets.ResumeLayout(False)
        Me.TabPage_FlyingPets.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox_FollowCursor As CheckBox
    Friend WithEvents CheckBox_TopMost As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListView_FlyingPets As ListView
    Friend WithEvents ImageList_FlyingPets As ImageList
    Friend WithEvents ImageList_GroundPets As ImageList
    Friend WithEvents ListView_GroundPets As ListView
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_GroundPets As TabPage
    Friend WithEvents TabPage_FlyingPets As TabPage
End Class
