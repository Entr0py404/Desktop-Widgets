<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DesktopShortcut
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
        Me.Button_File = New System.Windows.Forms.Button()
        Me.Button_Folder = New System.Windows.Forms.Button()
        Me.TextBox_ShortcutPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'Button_File
        '
        Me.Button_File.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_File.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_File.FlatAppearance.BorderSize = 0
        Me.Button_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_File.Location = New System.Drawing.Point(96, 56)
        Me.Button_File.Name = "Button_File"
        Me.Button_File.Size = New System.Drawing.Size(128, 32)
        Me.Button_File.TabIndex = 63
        Me.Button_File.Text = "File"
        Me.Button_File.UseVisualStyleBackColor = False
        '
        'Button_Folder
        '
        Me.Button_Folder.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Folder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Folder.FlatAppearance.BorderSize = 0
        Me.Button_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Folder.Location = New System.Drawing.Point(240, 56)
        Me.Button_Folder.Name = "Button_Folder"
        Me.Button_Folder.Size = New System.Drawing.Size(128, 32)
        Me.Button_Folder.TabIndex = 64
        Me.Button_Folder.Text = "Folder"
        Me.Button_Folder.UseVisualStyleBackColor = False
        '
        'TextBox_ShortcutPath
        '
        Me.TextBox_ShortcutPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ShortcutPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ShortcutPath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ShortcutPath.Location = New System.Drawing.Point(104, 24)
        Me.TextBox_ShortcutPath.Name = "TextBox_ShortcutPath"
        Me.TextBox_ShortcutPath.Size = New System.Drawing.Size(464, 13)
        Me.TextBox_ShortcutPath.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Shortcut path"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(96, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(480, 24)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(585, 97)
        Me.ShapeContainer1.TabIndex = 74
        Me.ShapeContainer1.TabStop = False
        '
        'Form_DesktopShortcut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(585, 97)
        Me.Controls.Add(Me.TextBox_ShortcutPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Folder)
        Me.Controls.Add(Me.Button_File)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form_DesktopShortcut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop Shortcut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_File As Button
    Friend WithEvents Button_Folder As Button
    Friend WithEvents TextBox_ShortcutPath As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents ShapeContainer1 As ShapeContainer
End Class
