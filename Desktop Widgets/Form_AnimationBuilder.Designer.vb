<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AnimationBuilder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AnimationBuilder))
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox_Images = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.PixelBox_Left = New Desktop_Widgets.PixelBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.NumericUpDown_Delay = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton_FacingLeft = New System.Windows.Forms.RadioButton()
        Me.RadioButton_FacingRight = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Animation = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton_TypeNature = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton_TypeObject = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TypeFlyingPet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TypeGroundPet = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PixelBox_Right = New Desktop_Widgets.PixelBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown_FPS = New System.Windows.Forms.NumericUpDown()
        Me.Label_Animation_Frame_Count = New System.Windows.Forms.Label()
        Me.ComboBox_Name = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        CType(Me.PixelBox_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        CType(Me.PixelBox_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.NumericUpDown_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(32, 376)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(192, 40)
        Me.Button_Save.TabIndex = 74
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Left"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox_Images
        '
        Me.ListBox_Images.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ListBox_Images.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Images.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox_Images.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Images.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_Images.FormattingEnabled = True
        Me.ListBox_Images.HorizontalScrollbar = True
        Me.ListBox_Images.Location = New System.Drawing.Point(0, 24)
        Me.ListBox_Images.Name = "ListBox_Images"
        Me.ListBox_Images.Size = New System.Drawing.Size(635, 538)
        Me.ListBox_Images.TabIndex = 77
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(88, 28)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(144, 144)
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Controls.Add(Me.ListBox_Images)
        Me.Panel1.Controls.Add(Me.Label_Animation_Frame_Count)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(440, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 582)
        Me.Panel1.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(635, 24)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Drag Drop Images Here!"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Left
        '
        Me.Panel_Left.Controls.Add(Me.Label1)
        Me.Panel_Left.Controls.Add(Me.PixelBox_Left)
        Me.Panel_Left.Controls.Add(Me.ShapeContainer3)
        Me.Panel_Left.Location = New System.Drawing.Point(56, 8)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(160, 176)
        Me.Panel_Left.TabIndex = 80
        '
        'PixelBox_Left
        '
        Me.PixelBox_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_Left.Location = New System.Drawing.Point(16, 32)
        Me.PixelBox_Left.Name = "PixelBox_Left"
        Me.PixelBox_Left.Size = New System.Drawing.Size(128, 128)
        Me.PixelBox_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_Left.TabIndex = 75
        Me.PixelBox_Left.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(160, 176)
        Me.ShapeContainer3.TabIndex = 76
        Me.ShapeContainer3.TabStop = False
        '
        'NumericUpDown_Delay
        '
        Me.NumericUpDown_Delay.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_Delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_Delay.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_Delay.Location = New System.Drawing.Point(80, 8)
        Me.NumericUpDown_Delay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_Delay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Delay.Name = "NumericUpDown_Delay"
        Me.NumericUpDown_Delay.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_Delay.TabIndex = 81
        Me.NumericUpDown_Delay.Value = New Decimal(New Integer() {33, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Delay:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton_FacingLeft
        '
        Me.RadioButton_FacingLeft.Location = New System.Drawing.Point(80, 8)
        Me.RadioButton_FacingLeft.Name = "RadioButton_FacingLeft"
        Me.RadioButton_FacingLeft.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton_FacingLeft.TabIndex = 83
        Me.RadioButton_FacingLeft.Text = "Left"
        Me.RadioButton_FacingLeft.UseVisualStyleBackColor = True
        '
        'RadioButton_FacingRight
        '
        Me.RadioButton_FacingRight.Checked = True
        Me.RadioButton_FacingRight.Location = New System.Drawing.Point(144, 8)
        Me.RadioButton_FacingRight.Name = "RadioButton_FacingRight"
        Me.RadioButton_FacingRight.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton_FacingRight.TabIndex = 84
        Me.RadioButton_FacingRight.TabStop = True
        Me.RadioButton_FacingRight.Text = "Right"
        Me.RadioButton_FacingRight.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Animation:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_Animation
        '
        Me.ComboBox_Animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Animation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Animation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Animation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Animation.FormattingEnabled = True
        Me.ComboBox_Animation.Location = New System.Drawing.Point(80, 8)
        Me.ComboBox_Animation.Name = "ComboBox_Animation"
        Me.ComboBox_Animation.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox_Animation.TabIndex = 87
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton_TypeNature)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.RadioButton_TypeObject)
        Me.Panel3.Controls.Add(Me.RadioButton_TypeFlyingPet)
        Me.Panel3.Controls.Add(Me.RadioButton_TypeGroundPet)
        Me.Panel3.Location = New System.Drawing.Point(0, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 40)
        Me.Panel3.TabIndex = 88
        '
        'RadioButton_TypeNature
        '
        Me.RadioButton_TypeNature.AutoSize = True
        Me.RadioButton_TypeNature.Location = New System.Drawing.Point(312, 8)
        Me.RadioButton_TypeNature.Name = "RadioButton_TypeNature"
        Me.RadioButton_TypeNature.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton_TypeNature.TabIndex = 102
        Me.RadioButton_TypeNature.Text = "Nature"
        Me.RadioButton_TypeNature.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Type:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton_TypeObject
        '
        Me.RadioButton_TypeObject.AutoSize = True
        Me.RadioButton_TypeObject.Location = New System.Drawing.Point(248, 8)
        Me.RadioButton_TypeObject.Name = "RadioButton_TypeObject"
        Me.RadioButton_TypeObject.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_TypeObject.TabIndex = 101
        Me.RadioButton_TypeObject.Text = "Object"
        Me.RadioButton_TypeObject.UseVisualStyleBackColor = True
        '
        'RadioButton_TypeFlyingPet
        '
        Me.RadioButton_TypeFlyingPet.AutoSize = True
        Me.RadioButton_TypeFlyingPet.Location = New System.Drawing.Point(168, 8)
        Me.RadioButton_TypeFlyingPet.Name = "RadioButton_TypeFlyingPet"
        Me.RadioButton_TypeFlyingPet.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton_TypeFlyingPet.TabIndex = 86
        Me.RadioButton_TypeFlyingPet.Text = "Flying Pet"
        Me.RadioButton_TypeFlyingPet.UseVisualStyleBackColor = True
        '
        'RadioButton_TypeGroundPet
        '
        Me.RadioButton_TypeGroundPet.AutoSize = True
        Me.RadioButton_TypeGroundPet.Checked = True
        Me.RadioButton_TypeGroundPet.Location = New System.Drawing.Point(80, 8)
        Me.RadioButton_TypeGroundPet.Name = "RadioButton_TypeGroundPet"
        Me.RadioButton_TypeGroundPet.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton_TypeGroundPet.TabIndex = 85
        Me.RadioButton_TypeGroundPet.TabStop = True
        Me.RadioButton_TypeGroundPet.Text = "Ground Pet"
        Me.RadioButton_TypeGroundPet.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Facing:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RadioButton_FacingLeft)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.RadioButton_FacingRight)
        Me.Panel4.Location = New System.Drawing.Point(0, 272)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 40)
        Me.Panel4.TabIndex = 90
        '
        'Panel_Right
        '
        Me.Panel_Right.Controls.Add(Me.Label3)
        Me.Panel_Right.Controls.Add(Me.PixelBox_Right)
        Me.Panel_Right.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Right.Location = New System.Drawing.Point(216, 8)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(160, 176)
        Me.Panel_Right.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Right"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PixelBox_Right
        '
        Me.PixelBox_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_Right.Location = New System.Drawing.Point(16, 32)
        Me.PixelBox_Right.Name = "PixelBox_Right"
        Me.PixelBox_Right.Size = New System.Drawing.Size(128, 128)
        Me.PixelBox_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_Right.TabIndex = 75
        Me.PixelBox_Right.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(160, 176)
        Me.ShapeContainer1.TabIndex = 76
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape3.Name = "RectangleShape1"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(144, 144)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(120, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = " Milliseconds      or"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 21)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Name:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ComboBox_Name)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Location = New System.Drawing.Point(0, 232)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(232, 40)
        Me.Panel6.TabIndex = 98
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.ComboBox_Animation)
        Me.Panel7.Location = New System.Drawing.Point(232, 232)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 40)
        Me.Panel7.TabIndex = 99
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.NumericUpDown_FPS)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.NumericUpDown_Delay)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Location = New System.Drawing.Point(0, 312)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(392, 32)
        Me.Panel8.TabIndex = 100
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "FPS:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_FPS
        '
        Me.NumericUpDown_FPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_FPS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FPS.Location = New System.Drawing.Point(296, 8)
        Me.NumericUpDown_FPS.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown_FPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FPS.Name = "NumericUpDown_FPS"
        Me.NumericUpDown_FPS.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_FPS.TabIndex = 94
        Me.NumericUpDown_FPS.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label_Animation_Frame_Count
        '
        Me.Label_Animation_Frame_Count.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_Animation_Frame_Count.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_Animation_Frame_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Animation_Frame_Count.Location = New System.Drawing.Point(0, 562)
        Me.Label_Animation_Frame_Count.Name = "Label_Animation_Frame_Count"
        Me.Label_Animation_Frame_Count.Size = New System.Drawing.Size(635, 20)
        Me.Label_Animation_Frame_Count.TabIndex = 101
        Me.Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Me.Label_Animation_Frame_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_Name
        '
        Me.ComboBox_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Name.FormattingEnabled = True
        Me.ComboBox_Name.Location = New System.Drawing.Point(80, 8)
        Me.ComboBox_Name.Name = "ComboBox_Name"
        Me.ComboBox_Name.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox_Name.TabIndex = 102
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel_Left)
        Me.Panel9.Controls.Add(Me.Button_Save)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Controls.Add(Me.Panel3)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Controls.Add(Me.Panel4)
        Me.Panel9.Controls.Add(Me.Panel6)
        Me.Panel9.Controls.Add(Me.Panel_Right)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(440, 582)
        Me.Panel9.TabIndex = 101
        '
        'Form_AnimationBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1075, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_AnimationBuilder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animation Builder"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Left.ResumeLayout(False)
        CType(Me.PixelBox_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel_Right.ResumeLayout(False)
        CType(Me.PixelBox_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.NumericUpDown_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Save As Button
    Friend WithEvents PixelBox_Left As PixelBox
    Private WithEvents Label1 As Label
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_Left As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents NumericUpDown_Delay As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton_FacingLeft As RadioButton
    Friend WithEvents RadioButton_FacingRight As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_Animation As ComboBox
    Private WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton_TypeFlyingPet As RadioButton
    Friend WithEvents RadioButton_TypeGroundPet As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel_Right As Panel
    Private WithEvents Label3 As Label
    Friend WithEvents PixelBox_Right As PixelBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton_TypeNature As RadioButton
    Friend WithEvents RadioButton_TypeObject As RadioButton
    Friend WithEvents NumericUpDown_FPS As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label_Animation_Frame_Count As Label
    Friend WithEvents ComboBox_Name As ComboBox
    Friend WithEvents Panel9 As Panel
End Class
