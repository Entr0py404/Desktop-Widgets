<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DesktopObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DesktopObjects))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_AssetCount = New System.Windows.Forms.Label()
        Me.CheckBox_TopMost = New System.Windows.Forms.CheckBox()
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar_ObjectScale = New System.Windows.Forms.TrackBar()
        Me.CheckBox_SnapToBar = New System.Windows.Forms.CheckBox()
        Me.Button_AllDesktopObjects = New System.Windows.Forms.Button()
        Me.ComboBox_Display = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Small_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medium_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Large_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraLarge_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 32)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(666, 426)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label_AssetCount)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 32)
        Me.Panel2.TabIndex = 102
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
        Me.Label_AssetCount.Size = New System.Drawing.Size(666, 32)
        Me.Label_AssetCount.TabIndex = 101
        Me.Label_AssetCount.Text = "0 Desktop Objects"
        Me.Label_AssetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_TopMost.Location = New System.Drawing.Point(0, 72)
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
        Me.Label_Scale.Location = New System.Drawing.Point(448, 16)
        Me.Label_Scale.Name = "Label_Scale"
        Me.Label_Scale.Size = New System.Drawing.Size(48, 40)
        Me.Label_Scale.TabIndex = 54
        Me.Label_Scale.Text = "1x"
        Me.Label_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 40)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Scale"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar_ObjectScale
        '
        Me.TrackBar_ObjectScale.Location = New System.Drawing.Point(72, 16)
        Me.TrackBar_ObjectScale.Minimum = 1
        Me.TrackBar_ObjectScale.Name = "TrackBar_ObjectScale"
        Me.TrackBar_ObjectScale.Size = New System.Drawing.Size(376, 45)
        Me.TrackBar_ObjectScale.TabIndex = 52
        Me.TrackBar_ObjectScale.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar_ObjectScale.Value = 1
        '
        'CheckBox_SnapToBar
        '
        Me.CheckBox_SnapToBar.Checked = True
        Me.CheckBox_SnapToBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_SnapToBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_SnapToBar.Location = New System.Drawing.Point(136, 72)
        Me.CheckBox_SnapToBar.Name = "CheckBox_SnapToBar"
        Me.CheckBox_SnapToBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_SnapToBar.Size = New System.Drawing.Size(120, 24)
        Me.CheckBox_SnapToBar.TabIndex = 56
        Me.CheckBox_SnapToBar.Text = "Snap To Bar"
        Me.CheckBox_SnapToBar.UseVisualStyleBackColor = True
        '
        'Button_AllDesktopObjects
        '
        Me.Button_AllDesktopObjects.BackColor = System.Drawing.Color.Tomato
        Me.Button_AllDesktopObjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_AllDesktopObjects.FlatAppearance.BorderSize = 0
        Me.Button_AllDesktopObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AllDesktopObjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AllDesktopObjects.Location = New System.Drawing.Point(456, 64)
        Me.Button_AllDesktopObjects.Name = "Button_AllDesktopObjects"
        Me.Button_AllDesktopObjects.Size = New System.Drawing.Size(200, 32)
        Me.Button_AllDesktopObjects.TabIndex = 57
        Me.Button_AllDesktopObjects.Text = "Close All Desktop Objects"
        Me.Button_AllDesktopObjects.UseVisualStyleBackColor = False
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
        Me.ComboBox_Display.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Display"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_AllDesktopObjects)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TrackBar_ObjectScale)
        Me.Panel1.Controls.Add(Me.Label_Scale)
        Me.Panel1.Controls.Add(Me.CheckBox_TopMost)
        Me.Panel1.Controls.Add(Me.CheckBox_SnapToBar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox_Display)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 104)
        Me.Panel1.TabIndex = 60
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(666, 458)
        Me.Panel3.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 562)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(666, 33)
        Me.Panel4.TabIndex = 62
        '
        'Form_DesktopObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(666, 595)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DesktopObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Objects"
        Me.Panel2.ResumeLayout(False)
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckBox_TopMost As CheckBox
    Private WithEvents Label_Scale As Label
    Private WithEvents Label9 As Label
    Friend WithEvents TrackBar_ObjectScale As TrackBar
    Friend WithEvents CheckBox_SnapToBar As CheckBox
    Friend WithEvents Button_AllDesktopObjects As Button
    Friend WithEvents ComboBox_Display As ComboBox
    Private WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_AssetCount As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Small_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Medium_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Large_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtraLarge_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
