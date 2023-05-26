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
        Me.Button_GDev = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_CloseSelected = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopPetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GDevCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetBuilderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Phrases = New System.Windows.Forms.Button()
        Me.Button_AnimationBuilder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Button_DesktopPets.Location = New System.Drawing.Point(272, 16)
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
        Me.Button_Nature.Location = New System.Drawing.Point(272, 56)
        Me.Button_Nature.Name = "Button_Nature"
        Me.Button_Nature.Size = New System.Drawing.Size(144, 32)
        Me.Button_Nature.TabIndex = 63
        Me.Button_Nature.Text = "Nature"
        Me.Button_Nature.UseVisualStyleBackColor = False
        '
        'Button_DesktopObjects
        '
        Me.Button_DesktopObjects.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_DesktopObjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DesktopObjects.FlatAppearance.BorderSize = 0
        Me.Button_DesktopObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DesktopObjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DesktopObjects.Location = New System.Drawing.Point(272, 96)
        Me.Button_DesktopObjects.Name = "Button_DesktopObjects"
        Me.Button_DesktopObjects.Size = New System.Drawing.Size(144, 32)
        Me.Button_DesktopObjects.TabIndex = 64
        Me.Button_DesktopObjects.Text = "Desktop Objects"
        Me.Button_DesktopObjects.UseVisualStyleBackColor = False
        '
        'Button_GDev
        '
        Me.Button_GDev.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_GDev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_GDev.FlatAppearance.BorderSize = 0
        Me.Button_GDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GDev.Location = New System.Drawing.Point(272, 136)
        Me.Button_GDev.Name = "Button_GDev"
        Me.Button_GDev.Size = New System.Drawing.Size(144, 32)
        Me.Button_GDev.TabIndex = 65
        Me.Button_GDev.Text = "GDev Character"
        Me.Button_GDev.UseVisualStyleBackColor = False
        Me.Button_GDev.Visible = False
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
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip_Main
        '
        Me.ContextMenuStrip_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip_Main.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip_Main.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Main.Size = New System.Drawing.Size(116, 82)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopPetsToolStripMenuItem, Me.NatureToolStripMenuItem, Me.DesktopObjectsToolStripMenuItem, Me.GDevCharacterToolStripMenuItem, Me.PetBuilderToolStripMenuItem})
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DesktopPetsToolStripMenuItem
        '
        Me.DesktopPetsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DesktopPetsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopPetsToolStripMenuItem.Name = "DesktopPetsToolStripMenuItem"
        Me.DesktopPetsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DesktopPetsToolStripMenuItem.Text = "Desktop Pets"
        '
        'NatureToolStripMenuItem
        '
        Me.NatureToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NatureToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NatureToolStripMenuItem.Name = "NatureToolStripMenuItem"
        Me.NatureToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.NatureToolStripMenuItem.Text = "Nature"
        '
        'DesktopObjectsToolStripMenuItem
        '
        Me.DesktopObjectsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DesktopObjectsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopObjectsToolStripMenuItem.Name = "DesktopObjectsToolStripMenuItem"
        Me.DesktopObjectsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DesktopObjectsToolStripMenuItem.Text = "Desktop Objects"
        '
        'GDevCharacterToolStripMenuItem
        '
        Me.GDevCharacterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GDevCharacterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GDevCharacterToolStripMenuItem.Name = "GDevCharacterToolStripMenuItem"
        Me.GDevCharacterToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.GDevCharacterToolStripMenuItem.Text = "GDev Character"
        '
        'PetBuilderToolStripMenuItem
        '
        Me.PetBuilderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PetBuilderToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PetBuilderToolStripMenuItem.Name = "PetBuilderToolStripMenuItem"
        Me.PetBuilderToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.PetBuilderToolStripMenuItem.Text = "Pet Builder"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(112, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button_Phrases
        '
        Me.Button_Phrases.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Phrases.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Phrases.FlatAppearance.BorderSize = 0
        Me.Button_Phrases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Phrases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Phrases.Location = New System.Drawing.Point(272, 176)
        Me.Button_Phrases.Name = "Button_Phrases"
        Me.Button_Phrases.Size = New System.Drawing.Size(144, 32)
        Me.Button_Phrases.TabIndex = 70
        Me.Button_Phrases.Text = "Phrases"
        Me.Button_Phrases.UseVisualStyleBackColor = False
        Me.Button_Phrases.Visible = False
        '
        'Button_AnimationBuilder
        '
        Me.Button_AnimationBuilder.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_AnimationBuilder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_AnimationBuilder.FlatAppearance.BorderSize = 0
        Me.Button_AnimationBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AnimationBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AnimationBuilder.Location = New System.Drawing.Point(272, 216)
        Me.Button_AnimationBuilder.Name = "Button_AnimationBuilder"
        Me.Button_AnimationBuilder.Size = New System.Drawing.Size(144, 32)
        Me.Button_AnimationBuilder.TabIndex = 72
        Me.Button_AnimationBuilder.Text = "Animation Builder"
        Me.Button_AnimationBuilder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button_CloseSelected)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 26)
        Me.Panel1.TabIndex = 73
        '
        'PixelBox1
        '
        Me.PixelBox1.Image = Global.Desktop_Widgets.My.Resources.Resources.four_squares
        Me.PixelBox1.Location = New System.Drawing.Point(8, 8)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.Size = New System.Drawing.Size(256, 256)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox1.TabIndex = 71
        Me.PixelBox1.TabStop = False
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 298)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_AnimationBuilder)
        Me.Controls.Add(Me.Button_Phrases)
        Me.Controls.Add(Me.Button_GDev)
        Me.Controls.Add(Me.Button_DesktopObjects)
        Me.Controls.Add(Me.Button_Nature)
        Me.Controls.Add(Me.Button_DesktopPets)
        Me.Controls.Add(Me.PixelBox1)
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
    Friend WithEvents Button_GDev As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button_CloseSelected As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip_Main As ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopPetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopObjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GDevCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Phrases As Button
    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents Button_AnimationBuilder As Button
    Friend WithEvents PetBuilderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
