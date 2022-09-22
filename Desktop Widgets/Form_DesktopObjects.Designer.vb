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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView_Objects = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList_Objects = New System.Windows.Forms.ImageList(Me.components)
        Me.CheckBox_TopMost = New System.Windows.Forms.CheckBox()
        Me.Label_Scale = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar_ObjectScale = New System.Windows.Forms.TrackBar()
        Me.CheckBox_SnapToBar = New System.Windows.Forms.CheckBox()
        Me.Button_AllDesktopObjects = New System.Windows.Forms.Button()
        Me.ComboBox_Display = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView_Objects)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 344)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objects"
        '
        'ListView_Objects
        '
        Me.ListView_Objects.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView_Objects.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListView_Objects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView_Objects.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView_Objects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Objects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Objects.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView_Objects.HideSelection = False
        Me.ListView_Objects.LabelWrap = False
        Me.ListView_Objects.LargeImageList = Me.ImageList_Objects
        Me.ListView_Objects.Location = New System.Drawing.Point(3, 18)
        Me.ListView_Objects.MultiSelect = False
        Me.ListView_Objects.Name = "ListView_Objects"
        Me.ListView_Objects.Size = New System.Drawing.Size(482, 323)
        Me.ListView_Objects.SmallImageList = Me.ImageList_Objects
        Me.ListView_Objects.TabIndex = 35
        Me.ListView_Objects.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 28)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ImageList_Objects
        '
        Me.ImageList_Objects.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList_Objects.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList_Objects.TransparentColor = System.Drawing.Color.Transparent
        '
        'CheckBox_TopMost
        '
        Me.CheckBox_TopMost.Checked = True
        Me.CheckBox_TopMost.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.Button_AllDesktopObjects.Location = New System.Drawing.Point(8, 456)
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
        'Form_DesktopObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 497)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_Display)
        Me.Controls.Add(Me.Button_AllDesktopObjects)
        Me.Controls.Add(Me.CheckBox_SnapToBar)
        Me.Controls.Add(Me.CheckBox_TopMost)
        Me.Controls.Add(Me.Label_Scale)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TrackBar_ObjectScale)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_DesktopObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Objects"
        Me.GroupBox3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TrackBar_ObjectScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListView_Objects As ListView
    Friend WithEvents CheckBox_TopMost As CheckBox
    Private WithEvents Label_Scale As Label
    Private WithEvents Label9 As Label
    Friend WithEvents TrackBar_ObjectScale As TrackBar
    Friend WithEvents ImageList_Objects As ImageList
    Friend WithEvents CheckBox_SnapToBar As CheckBox
    Friend WithEvents Button_AllDesktopObjects As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox_Display As ComboBox
    Private WithEvents Label1 As Label
End Class
