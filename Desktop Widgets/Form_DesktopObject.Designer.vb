<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DesktopObject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DesktopObject))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AllDesktopObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllAlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllScaleToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.StopAnimationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnapToBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PixelBox1 = New Desktop_Widgets.PixelBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllDesktopObjectsToolStripMenuItem, Me.ToolStripSeparator1, Me.StopAnimationToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.SnapToBarToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 206)
        '
        'AllDesktopObjectsToolStripMenuItem
        '
        Me.AllDesktopObjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllAlwaysOnTopToolStripMenuItem, Me.ScaleToolStripMenuItem1})
        Me.AllDesktopObjectsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AllDesktopObjectsToolStripMenuItem.Name = "AllDesktopObjectsToolStripMenuItem"
        Me.AllDesktopObjectsToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.AllDesktopObjectsToolStripMenuItem.Text = "All desktop objects"
        '
        'AllAlwaysOnTopToolStripMenuItem
        '
        Me.AllAlwaysOnTopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.AllAlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AllAlwaysOnTopToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AllAlwaysOnTopToolStripMenuItem.Name = "AllAlwaysOnTopToolStripMenuItem"
        Me.AllAlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AllAlwaysOnTopToolStripMenuItem.Text = "Always on top"
        '
        'ScaleToolStripMenuItem1
        '
        Me.ScaleToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ScaleToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllScaleToolStripComboBox})
        Me.ScaleToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ScaleToolStripMenuItem1.Name = "ScaleToolStripMenuItem1"
        Me.ScaleToolStripMenuItem1.Size = New System.Drawing.Size(172, 24)
        Me.ScaleToolStripMenuItem1.Text = "Scale"
        '
        'AllScaleToolStripComboBox
        '
        Me.AllScaleToolStripComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.AllScaleToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AllScaleToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllScaleToolStripComboBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AllScaleToolStripComboBox.Items.AddRange(New Object() {"1x", "2x", "3x", "4x", "5x", "6x", "7x", "8x", "9x", "10x"})
        Me.AllScaleToolStripComboBox.Name = "AllScaleToolStripComboBox"
        Me.AllScaleToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'StopAnimationToolStripMenuItem
        '
        Me.StopAnimationToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.StopAnimationToolStripMenuItem.Name = "StopAnimationToolStripMenuItem"
        Me.StopAnimationToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.StopAnimationToolStripMenuItem.Text = "Stop animation"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on top"
        '
        'SnapToBarToolStripMenuItem
        '
        Me.SnapToBarToolStripMenuItem.CheckOnClick = True
        Me.SnapToBarToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SnapToBarToolStripMenuItem.Name = "SnapToBarToolStripMenuItem"
        Me.SnapToBarToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.SnapToBarToolStripMenuItem.Text = "Snap to bar"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripComboBox})
        Me.DisplayToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
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
        Me.ScaleToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
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
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PixelBox1
        '
        Me.PixelBox1.BackColor = System.Drawing.Color.Fuchsia
        Me.PixelBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PixelBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PixelBox1.Location = New System.Drawing.Point(0, 0)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox1.Size = New System.Drawing.Size(233, 153)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PixelBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.PixelBox1.TabIndex = 3
        Me.PixelBox1.TabStop = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'Form_DesktopObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(233, 153)
        Me.Controls.Add(Me.PixelBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_DesktopObject"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Object"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnapToBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopAnimationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllDesktopObjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllScaleToolStripComboBox As ToolStripComboBox
    Friend WithEvents AllAlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
