<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.Button_DesktopPets = New System.Windows.Forms.Button()
        Me.Button_Nature = New System.Windows.Forms.Button()
        Me.Button_DesktopObjects = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_CloseSelected = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DesktopPetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopNatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_AnimationBuilder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button_MotionDesktop = New System.Windows.Forms.Button()
        Me.Button_DualBackgrounds = New System.Windows.Forms.Button()
        Me.PixelBox1 = New Desktop_Widgets.PixelBox()
        Me.ContextMenuStrip_Main.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_DesktopPets
        '
        Me.Button_DesktopPets.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_DesktopPets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DesktopPets.FlatAppearance.BorderSize = 0
        Me.Button_DesktopPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DesktopPets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DesktopPets.Location = New System.Drawing.Point(224, 8)
        Me.Button_DesktopPets.Name = "Button_DesktopPets"
        Me.Button_DesktopPets.Size = New System.Drawing.Size(144, 32)
        Me.Button_DesktopPets.TabIndex = 62
        Me.Button_DesktopPets.Text = "Desktop Pets"
        Me.Button_DesktopPets.UseVisualStyleBackColor = False
        '
        'Button_Nature
        '
        Me.Button_Nature.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Nature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Nature.FlatAppearance.BorderSize = 0
        Me.Button_Nature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Nature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Nature.Location = New System.Drawing.Point(224, 48)
        Me.Button_Nature.Name = "Button_Nature"
        Me.Button_Nature.Size = New System.Drawing.Size(144, 32)
        Me.Button_Nature.TabIndex = 63
        Me.Button_Nature.Text = "Desktop Nature"
        Me.Button_Nature.UseVisualStyleBackColor = False
        '
        'Button_DesktopObjects
        '
        Me.Button_DesktopObjects.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_DesktopObjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DesktopObjects.FlatAppearance.BorderSize = 0
        Me.Button_DesktopObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DesktopObjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DesktopObjects.Location = New System.Drawing.Point(224, 88)
        Me.Button_DesktopObjects.Name = "Button_DesktopObjects"
        Me.Button_DesktopObjects.Size = New System.Drawing.Size(144, 32)
        Me.Button_DesktopObjects.TabIndex = 64
        Me.Button_DesktopObjects.Text = "Desktop Objects"
        Me.Button_DesktopObjects.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All Pets", "Ground Pets", "Flying Pets", "Nature Objects", "Desktop Objects", "GDev Character"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 26)
        Me.ComboBox1.TabIndex = 66
        '
        'Button_CloseSelected
        '
        Me.Button_CloseSelected.BackColor = System.Drawing.Color.Tomato
        Me.Button_CloseSelected.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_CloseSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_CloseSelected.FlatAppearance.BorderSize = 0
        Me.Button_CloseSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CloseSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CloseSelected.Location = New System.Drawing.Point(136, 0)
        Me.Button_CloseSelected.Name = "Button_CloseSelected"
        Me.Button_CloseSelected.Size = New System.Drawing.Size(80, 26)
        Me.Button_CloseSelected.TabIndex = 68
        Me.Button_CloseSelected.Text = "Close"
        Me.Button_CloseSelected.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Test"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip_Main
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Desktop Pets"
        '
        'ContextMenuStrip_Main
        '
        Me.ContextMenuStrip_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip_Main.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolStripSeparator1, Me.DesktopPetsToolStripMenuItem, Me.DesktopNatureToolStripMenuItem, Me.DesktopObjectsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip_Main.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Main.Size = New System.Drawing.Size(188, 136)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'DesktopPetsToolStripMenuItem
        '
        Me.DesktopPetsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopPetsToolStripMenuItem.Name = "DesktopPetsToolStripMenuItem"
        Me.DesktopPetsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DesktopPetsToolStripMenuItem.Text = "Desktop Pets"
        '
        'DesktopNatureToolStripMenuItem
        '
        Me.DesktopNatureToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopNatureToolStripMenuItem.Name = "DesktopNatureToolStripMenuItem"
        Me.DesktopNatureToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DesktopNatureToolStripMenuItem.Text = "Desktop Nature"
        '
        'DesktopObjectsToolStripMenuItem
        '
        Me.DesktopObjectsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopObjectsToolStripMenuItem.Name = "DesktopObjectsToolStripMenuItem"
        Me.DesktopObjectsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DesktopObjectsToolStripMenuItem.Text = "Desktop Objects"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(184, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button_AnimationBuilder
        '
        Me.Button_AnimationBuilder.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_AnimationBuilder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_AnimationBuilder.FlatAppearance.BorderSize = 0
        Me.Button_AnimationBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AnimationBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AnimationBuilder.Location = New System.Drawing.Point(376, 88)
        Me.Button_AnimationBuilder.Name = "Button_AnimationBuilder"
        Me.Button_AnimationBuilder.Size = New System.Drawing.Size(144, 32)
        Me.Button_AnimationBuilder.TabIndex = 72
        Me.Button_AnimationBuilder.Text = "Animation Builder"
        Me.Button_AnimationBuilder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Button_CloseSelected)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 26)
        Me.Panel1.TabIndex = 73
        '
        'CheckBox1
        '
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(216, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(120, 26)
        Me.CheckBox1.TabIndex = 74
        Me.CheckBox1.Text = "Use Tray Icon"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button_MotionDesktop
        '
        Me.Button_MotionDesktop.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_MotionDesktop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MotionDesktop.FlatAppearance.BorderSize = 0
        Me.Button_MotionDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MotionDesktop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MotionDesktop.Location = New System.Drawing.Point(376, 8)
        Me.Button_MotionDesktop.Name = "Button_MotionDesktop"
        Me.Button_MotionDesktop.Size = New System.Drawing.Size(144, 32)
        Me.Button_MotionDesktop.TabIndex = 75
        Me.Button_MotionDesktop.Text = "Motion Desktop"
        Me.Button_MotionDesktop.UseVisualStyleBackColor = False
        '
        'Button_DualBackgrounds
        '
        Me.Button_DualBackgrounds.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_DualBackgrounds.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DualBackgrounds.FlatAppearance.BorderSize = 0
        Me.Button_DualBackgrounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DualBackgrounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DualBackgrounds.Location = New System.Drawing.Point(376, 48)
        Me.Button_DualBackgrounds.Name = "Button_DualBackgrounds"
        Me.Button_DualBackgrounds.Size = New System.Drawing.Size(144, 32)
        Me.Button_DualBackgrounds.TabIndex = 76
        Me.Button_DualBackgrounds.Text = "Dual Backgrounds"
        Me.Button_DualBackgrounds.UseVisualStyleBackColor = False
        '
        'PixelBox1
        '
        Me.PixelBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PixelBox1.Image = Global.Desktop_Widgets.My.Resources.Resources.four_squares
        Me.PixelBox1.Location = New System.Drawing.Point(0, 0)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.Size = New System.Drawing.Size(216, 129)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox1.TabIndex = 71
        Me.PixelBox1.TabStop = False
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(530, 155)
        Me.Controls.Add(Me.PixelBox1)
        Me.Controls.Add(Me.Button_DualBackgrounds)
        Me.Controls.Add(Me.Button_MotionDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_AnimationBuilder)
        Me.Controls.Add(Me.Button_DesktopObjects)
        Me.Controls.Add(Me.Button_Nature)
        Me.Controls.Add(Me.Button_DesktopPets)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip_Main.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_DesktopPets As Button
    Friend WithEvents Button_Nature As Button
    Friend WithEvents Button_DesktopObjects As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_CloseSelected As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip_Main As ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents Button_AnimationBuilder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DesktopNatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopPetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopObjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_MotionDesktop As Button
    Friend WithEvents Button_DualBackgrounds As Button
End Class
