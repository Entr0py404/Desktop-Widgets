<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DesktopObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DesktopObjects))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Label_DesktopObjects = New System.Windows.Forms.Label()
        Me.ComboBox_DesktopObjects = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox_TopMost = New System.Windows.Forms.CheckBox()
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.CheckBox_SnapToBar = New System.Windows.Forms.CheckBox()
        Me.ComboBox_Display = New System.Windows.Forms.ComboBox()
        Me.Label_Display = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Small_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medium_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Large_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_Side = New System.Windows.Forms.Panel()
        Me.NumericUpDown_ObjectScale = New System.Windows.Forms.NumericUpDown()
        Me.Panel_Bottom = New System.Windows.Forms.Panel()
        Me.Button_AllDesktopObjects = New System.Windows.Forms.Button()
        Me.Panel_Top.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_Side.SuspendLayout()
        CType(Me.NumericUpDown_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Bottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(496, 449)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Label_DesktopObjects)
        Me.Panel_Top.Controls.Add(Me.ComboBox_DesktopObjects)
        Me.Panel_Top.Controls.Add(Me.Button1)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(737, 40)
        Me.Panel_Top.TabIndex = 102
        '
        'Label_DesktopObjects
        '
        Me.Label_DesktopObjects.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_DesktopObjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DesktopObjects.Location = New System.Drawing.Point(40, 0)
        Me.Label_DesktopObjects.Name = "Label_DesktopObjects"
        Me.Label_DesktopObjects.Size = New System.Drawing.Size(128, 40)
        Me.Label_DesktopObjects.TabIndex = 97
        Me.Label_DesktopObjects.Text = "Desktop Objects"
        Me.Label_DesktopObjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_DesktopObjects
        '
        Me.ComboBox_DesktopObjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_DesktopObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DesktopObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_DesktopObjects.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_DesktopObjects.FormattingEnabled = True
        Me.ComboBox_DesktopObjects.Location = New System.Drawing.Point(176, 10)
        Me.ComboBox_DesktopObjects.Name = "ComboBox_DesktopObjects"
        Me.ComboBox_DesktopObjects.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_DesktopObjects.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "☰"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TopMost.Location = New System.Drawing.Point(0, 96)
        Me.CheckBox_TopMost.Name = "CheckBox_TopMost"
        Me.CheckBox_TopMost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_TopMost.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox_TopMost.TabIndex = 55
        Me.CheckBox_TopMost.Text = "Always On Top"
        Me.CheckBox_TopMost.UseVisualStyleBackColor = True
        '
        'Label_Scale
        '
        Me.Label_Scale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Scale.Location = New System.Drawing.Point(0, 56)
        Me.Label_Scale.Name = "Label_Scale"
        Me.Label_Scale.Size = New System.Drawing.Size(64, 21)
        Me.Label_Scale.TabIndex = 53
        Me.Label_Scale.Text = "Scale"
        Me.Label_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox_SnapToBar
        '
        Me.CheckBox_SnapToBar.Checked = True
        Me.CheckBox_SnapToBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_SnapToBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_SnapToBar.Location = New System.Drawing.Point(0, 136)
        Me.CheckBox_SnapToBar.Name = "CheckBox_SnapToBar"
        Me.CheckBox_SnapToBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_SnapToBar.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox_SnapToBar.TabIndex = 56
        Me.CheckBox_SnapToBar.Text = "Snap To Bar"
        Me.CheckBox_SnapToBar.UseVisualStyleBackColor = True
        '
        'ComboBox_Display
        '
        Me.ComboBox_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Display.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Display.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Display.FormattingEnabled = True
        Me.ComboBox_Display.Location = New System.Drawing.Point(72, 16)
        Me.ComboBox_Display.Name = "ComboBox_Display"
        Me.ComboBox_Display.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_Display.TabIndex = 58
        '
        'Label_Display
        '
        Me.Label_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Display.Location = New System.Drawing.Point(0, 16)
        Me.Label_Display.Name = "Label_Display"
        Me.Label_Display.Size = New System.Drawing.Size(64, 21)
        Me.Label_Display.TabIndex = 59
        Me.Label_Display.Text = "Display"
        Me.Label_Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel_Main
        '
        Me.Panel_Main.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel_Main.Controls.Add(Me.Panel_Side)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(737, 449)
        Me.Panel_Main.TabIndex = 61
        '
        'Panel_Side
        '
        Me.Panel_Side.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel_Side.Controls.Add(Me.NumericUpDown_ObjectScale)
        Me.Panel_Side.Controls.Add(Me.ComboBox_Display)
        Me.Panel_Side.Controls.Add(Me.Label_Display)
        Me.Panel_Side.Controls.Add(Me.Label_Scale)
        Me.Panel_Side.Controls.Add(Me.CheckBox_SnapToBar)
        Me.Panel_Side.Controls.Add(Me.CheckBox_TopMost)
        Me.Panel_Side.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Side.Location = New System.Drawing.Point(496, 0)
        Me.Panel_Side.Name = "Panel_Side"
        Me.Panel_Side.Size = New System.Drawing.Size(241, 449)
        Me.Panel_Side.TabIndex = 103
        '
        'NumericUpDown_ObjectScale
        '
        Me.NumericUpDown_ObjectScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_ObjectScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_ObjectScale.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_ObjectScale.Location = New System.Drawing.Point(72, 56)
        Me.NumericUpDown_ObjectScale.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_ObjectScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ObjectScale.Name = "NumericUpDown_ObjectScale"
        Me.NumericUpDown_ObjectScale.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_ObjectScale.TabIndex = 62
        Me.NumericUpDown_ObjectScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel_Bottom.Controls.Add(Me.Button_AllDesktopObjects)
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 489)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(737, 26)
        Me.Panel_Bottom.TabIndex = 63
        '
        'Button_AllDesktopObjects
        '
        Me.Button_AllDesktopObjects.BackColor = System.Drawing.Color.Tomato
        Me.Button_AllDesktopObjects.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_AllDesktopObjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_AllDesktopObjects.FlatAppearance.BorderSize = 0
        Me.Button_AllDesktopObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AllDesktopObjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AllDesktopObjects.Location = New System.Drawing.Point(0, 0)
        Me.Button_AllDesktopObjects.Name = "Button_AllDesktopObjects"
        Me.Button_AllDesktopObjects.Size = New System.Drawing.Size(96, 26)
        Me.Button_AllDesktopObjects.TabIndex = 57
        Me.Button_AllDesktopObjects.Text = "Close All"
        Me.Button_AllDesktopObjects.UseVisualStyleBackColor = False
        '
        'Form_DesktopObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 515)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Top)
        Me.Controls.Add(Me.Panel_Bottom)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DesktopObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Objects"
        Me.Panel_Top.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Side.ResumeLayout(False)
        CType(Me.NumericUpDown_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Bottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckBox_TopMost As CheckBox
    Private WithEvents Label_Scale As Label
    Friend WithEvents CheckBox_SnapToBar As CheckBox
    Friend WithEvents ComboBox_Display As ComboBox
    Private WithEvents Label_Display As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel_Top As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Small_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Medium_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Large_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtraLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents ComboBox_DesktopObjects As ComboBox
    Friend WithEvents NumericUpDown_ObjectScale As NumericUpDown
    Friend WithEvents Panel_Side As Panel
    Friend WithEvents Panel_Bottom As Panel
    Friend WithEvents Button_AllDesktopObjects As Button
    Friend WithEvents Label_DesktopObjects As Label
End Class
