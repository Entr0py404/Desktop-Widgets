<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Import
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Import))
        Me.Button_Import = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_DesktopObject = New System.Windows.Forms.TabPage()
        Me.PixelBox1 = New Desktop_Widgets.PixelBox()
        Me.TabPage_NatureObject = New System.Windows.Forms.TabPage()
        Me.TabPage_DesktopPets = New System.Windows.Forms.TabPage()
        Me.PixelBox2 = New Desktop_Widgets.PixelBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DesktopObjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NatureObjectTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopPetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_DesktopObject.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_DesktopPets.SuspendLayout()
        CType(Me.PixelBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Import
        '
        Me.Button_Import.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Import.FlatAppearance.BorderSize = 0
        Me.Button_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Import.Location = New System.Drawing.Point(320, 320)
        Me.Button_Import.Name = "Button_Import"
        Me.Button_Import.Size = New System.Drawing.Size(120, 32)
        Me.Button_Import.TabIndex = 59
        Me.Button_Import.Text = "Import"
        Me.Button_Import.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_DesktopObject)
        Me.TabControl1.Controls.Add(Me.TabPage_NatureObject)
        Me.TabControl1.Controls.Add(Me.TabPage_DesktopPets)
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 280)
        Me.TabControl1.TabIndex = 62
        '
        'TabPage_DesktopObject
        '
        Me.TabPage_DesktopObject.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TabPage_DesktopObject.Controls.Add(Me.PixelBox1)
        Me.TabPage_DesktopObject.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_DesktopObject.Name = "TabPage_DesktopObject"
        Me.TabPage_DesktopObject.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DesktopObject.Size = New System.Drawing.Size(432, 254)
        Me.TabPage_DesktopObject.TabIndex = 0
        Me.TabPage_DesktopObject.Text = "Desktop Object"
        '
        'PixelBox1
        '
        Me.PixelBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PixelBox1.Location = New System.Drawing.Point(16, 16)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.Size = New System.Drawing.Size(64, 64)
        Me.PixelBox1.TabIndex = 0
        Me.PixelBox1.TabStop = False
        '
        'TabPage_NatureObject
        '
        Me.TabPage_NatureObject.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TabPage_NatureObject.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_NatureObject.Name = "TabPage_NatureObject"
        Me.TabPage_NatureObject.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_NatureObject.Size = New System.Drawing.Size(432, 254)
        Me.TabPage_NatureObject.TabIndex = 1
        Me.TabPage_NatureObject.Text = "Nature Object"
        '
        'TabPage_DesktopPets
        '
        Me.TabPage_DesktopPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TabPage_DesktopPets.Controls.Add(Me.PixelBox2)
        Me.TabPage_DesktopPets.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_DesktopPets.Name = "TabPage_DesktopPets"
        Me.TabPage_DesktopPets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_DesktopPets.Size = New System.Drawing.Size(432, 254)
        Me.TabPage_DesktopPets.TabIndex = 2
        Me.TabPage_DesktopPets.Text = "Desktop Pets"
        '
        'PixelBox2
        '
        Me.PixelBox2.Location = New System.Drawing.Point(16, 16)
        Me.PixelBox2.Name = "PixelBox2"
        Me.PixelBox2.Size = New System.Drawing.Size(64, 64)
        Me.PixelBox2.TabIndex = 62
        Me.PixelBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopObjectToolStripMenuItem, Me.NatureObjectTextToolStripMenuItem, Me.DesktopPetsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 29)
        Me.MenuStrip1.TabIndex = 118
        '
        'DesktopObjectToolStripMenuItem
        '
        Me.DesktopObjectToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.DesktopObjectToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopObjectToolStripMenuItem.Name = "DesktopObjectToolStripMenuItem"
        Me.DesktopObjectToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.DesktopObjectToolStripMenuItem.Text = "Desktop Object"
        '
        'NatureObjectTextToolStripMenuItem
        '
        Me.NatureObjectTextToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NatureObjectTextToolStripMenuItem.Name = "NatureObjectTextToolStripMenuItem"
        Me.NatureObjectTextToolStripMenuItem.Size = New System.Drawing.Size(119, 25)
        Me.NatureObjectTextToolStripMenuItem.Text = "Nature Object"
        '
        'DesktopPetsToolStripMenuItem
        '
        Me.DesktopPetsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DesktopPetsToolStripMenuItem.Name = "DesktopPetsToolStripMenuItem"
        Me.DesktopPetsToolStripMenuItem.Size = New System.Drawing.Size(111, 25)
        Me.DesktopPetsToolStripMenuItem.Text = "Desktop Pets"
        '
        'Form_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 362)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button_Import)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_DesktopObject.ResumeLayout(False)
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_DesktopPets.ResumeLayout(False)
        CType(Me.PixelBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents Button_Import As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_DesktopObject As TabPage
    Friend WithEvents TabPage_NatureObject As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DesktopObjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NatureObjectTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopPetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage_DesktopPets As TabPage
    Friend WithEvents PixelBox2 As PixelBox
End Class
