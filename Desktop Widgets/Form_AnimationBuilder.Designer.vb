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
        Me.Label_Left = New System.Windows.Forms.Label()
        Me.ListBox_Images = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleShape_Left = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Label_Animation_Frame_Count = New System.Windows.Forms.Label()
        Me.Label_DragDropHere = New System.Windows.Forms.Label()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.NumericUpDown_Delay = New System.Windows.Forms.NumericUpDown()
        Me.Label_Delay = New System.Windows.Forms.Label()
        Me.Label_Animation = New System.Windows.Forms.Label()
        Me.ComboBox_Animation = New System.Windows.Forms.ComboBox()
        Me.Panel_Type = New System.Windows.Forms.Panel()
        Me.RadioButton_TypeNature = New System.Windows.Forms.RadioButton()
        Me.Label_Type = New System.Windows.Forms.Label()
        Me.RadioButton_TypeObject = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TypeFlyingPet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_TypeGroundPet = New System.Windows.Forms.RadioButton()
        Me.Label_Facing = New System.Windows.Forms.Label()
        Me.Panel_Name = New System.Windows.Forms.Panel()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.ComboBox_Name = New System.Windows.Forms.ComboBox()
        Me.Button_Flip = New System.Windows.Forms.Button()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Label_Right = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Right = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_Milliseconds = New System.Windows.Forms.Label()
        Me.Panel_Artist = New System.Windows.Forms.Panel()
        Me.Label_Artist = New System.Windows.Forms.Label()
        Me.ComboBox_Artist = New System.Windows.Forms.ComboBox()
        Me.Panel_Animation = New System.Windows.Forms.Panel()
        Me.Panel_Side = New System.Windows.Forms.Panel()
        Me.CheckBox_NonDirectional = New System.Windows.Forms.CheckBox()
        Me.Panel_Delay = New System.Windows.Forms.Panel()
        Me.PixelBox_Left = New Desktop_Widgets.PixelBox()
        Me.PixelBox_Right = New Desktop_Widgets.PixelBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Type.SuspendLayout()
        Me.Panel_Name.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        Me.Panel_Artist.SuspendLayout()
        Me.Panel_Animation.SuspendLayout()
        Me.Panel_Side.SuspendLayout()
        Me.Panel_Delay.SuspendLayout()
        CType(Me.PixelBox_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixelBox_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(72, 368)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(144, 32)
        Me.Button_Save.TabIndex = 74
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Label_Left
        '
        Me.Label_Left.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Left.Location = New System.Drawing.Point(8, 0)
        Me.Label_Left.Name = "Label_Left"
        Me.Label_Left.Size = New System.Drawing.Size(144, 24)
        Me.Label_Left.TabIndex = 76
        Me.Label_Left.Text = "Left"
        Me.Label_Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ListBox_Images.Size = New System.Drawing.Size(457, 422)
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
        'RectangleShape_Left
        '
        Me.RectangleShape_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Left.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Left.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Left.CornerRadius = 3
        Me.RectangleShape_Left.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Left.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Left.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape_Left.Name = "RectangleShape_Left"
        Me.RectangleShape_Left.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Left.Size = New System.Drawing.Size(144, 144)
        '
        'Panel_Main
        '
        Me.Panel_Main.AllowDrop = True
        Me.Panel_Main.Controls.Add(Me.ListBox_Images)
        Me.Panel_Main.Controls.Add(Me.Label_Animation_Frame_Count)
        Me.Panel_Main.Controls.Add(Me.Label_DragDropHere)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(457, 466)
        Me.Panel_Main.TabIndex = 79
        '
        'Label_Animation_Frame_Count
        '
        Me.Label_Animation_Frame_Count.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_Animation_Frame_Count.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_Animation_Frame_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Animation_Frame_Count.Location = New System.Drawing.Point(0, 446)
        Me.Label_Animation_Frame_Count.Name = "Label_Animation_Frame_Count"
        Me.Label_Animation_Frame_Count.Size = New System.Drawing.Size(457, 20)
        Me.Label_Animation_Frame_Count.TabIndex = 101
        Me.Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Me.Label_Animation_Frame_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_DragDropHere
        '
        Me.Label_DragDropHere.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_DragDropHere.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_DragDropHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DragDropHere.Location = New System.Drawing.Point(0, 0)
        Me.Label_DragDropHere.Name = "Label_DragDropHere"
        Me.Label_DragDropHere.Size = New System.Drawing.Size(457, 24)
        Me.Label_DragDropHere.TabIndex = 79
        Me.Label_DragDropHere.Text = "Drag Drop Images Here!"
        Me.Label_DragDropHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Left
        '
        Me.Panel_Left.Controls.Add(Me.Label_Left)
        Me.Panel_Left.Controls.Add(Me.PixelBox_Left)
        Me.Panel_Left.Controls.Add(Me.ShapeContainer3)
        Me.Panel_Left.Location = New System.Drawing.Point(56, 8)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(160, 176)
        Me.Panel_Left.TabIndex = 80
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Left})
        Me.ShapeContainer3.Size = New System.Drawing.Size(160, 176)
        Me.ShapeContainer3.TabIndex = 76
        Me.ShapeContainer3.TabStop = False
        '
        'NumericUpDown_Delay
        '
        Me.NumericUpDown_Delay.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_Delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_Delay.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_Delay.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_Delay.Location = New System.Drawing.Point(72, 8)
        Me.NumericUpDown_Delay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_Delay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Delay.Name = "NumericUpDown_Delay"
        Me.NumericUpDown_Delay.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_Delay.TabIndex = 81
        Me.NumericUpDown_Delay.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_Delay
        '
        Me.Label_Delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delay.Location = New System.Drawing.Point(0, 8)
        Me.Label_Delay.Name = "Label_Delay"
        Me.Label_Delay.Size = New System.Drawing.Size(64, 20)
        Me.Label_Delay.TabIndex = 82
        Me.Label_Delay.Text = "Delay:"
        Me.Label_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Animation
        '
        Me.Label_Animation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Animation.Location = New System.Drawing.Point(0, 8)
        Me.Label_Animation.Name = "Label_Animation"
        Me.Label_Animation.Size = New System.Drawing.Size(72, 21)
        Me.Label_Animation.TabIndex = 86
        Me.Label_Animation.Text = "Animation:"
        Me.Label_Animation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.ComboBox_Animation.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox_Animation.TabIndex = 87
        '
        'Panel_Type
        '
        Me.Panel_Type.Controls.Add(Me.RadioButton_TypeNature)
        Me.Panel_Type.Controls.Add(Me.Label_Type)
        Me.Panel_Type.Controls.Add(Me.RadioButton_TypeObject)
        Me.Panel_Type.Controls.Add(Me.RadioButton_TypeFlyingPet)
        Me.Panel_Type.Controls.Add(Me.RadioButton_TypeGroundPet)
        Me.Panel_Type.Location = New System.Drawing.Point(0, 192)
        Me.Panel_Type.Name = "Panel_Type"
        Me.Panel_Type.Size = New System.Drawing.Size(448, 40)
        Me.Panel_Type.TabIndex = 88
        '
        'RadioButton_TypeNature
        '
        Me.RadioButton_TypeNature.AutoSize = True
        Me.RadioButton_TypeNature.Location = New System.Drawing.Point(320, 8)
        Me.RadioButton_TypeNature.Name = "RadioButton_TypeNature"
        Me.RadioButton_TypeNature.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton_TypeNature.TabIndex = 102
        Me.RadioButton_TypeNature.Text = "Nature"
        Me.RadioButton_TypeNature.UseVisualStyleBackColor = True
        '
        'Label_Type
        '
        Me.Label_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Type.Location = New System.Drawing.Point(8, 8)
        Me.Label_Type.Name = "Label_Type"
        Me.Label_Type.Size = New System.Drawing.Size(56, 21)
        Me.Label_Type.TabIndex = 87
        Me.Label_Type.Text = "Type:"
        Me.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.RadioButton_TypeGroundPet.Location = New System.Drawing.Point(72, 8)
        Me.RadioButton_TypeGroundPet.Name = "RadioButton_TypeGroundPet"
        Me.RadioButton_TypeGroundPet.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton_TypeGroundPet.TabIndex = 85
        Me.RadioButton_TypeGroundPet.TabStop = True
        Me.RadioButton_TypeGroundPet.Text = "Ground Pet"
        Me.RadioButton_TypeGroundPet.UseVisualStyleBackColor = True
        '
        'Label_Facing
        '
        Me.Label_Facing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Facing.Location = New System.Drawing.Point(245, 280)
        Me.Label_Facing.Name = "Label_Facing"
        Me.Label_Facing.Size = New System.Drawing.Size(72, 21)
        Me.Label_Facing.TabIndex = 89
        Me.Label_Facing.Text = "Facing:"
        Me.Label_Facing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Name
        '
        Me.Panel_Name.Controls.Add(Me.Button2)
        Me.Panel_Name.Controls.Add(Me.Label_Name)
        Me.Panel_Name.Controls.Add(Me.ComboBox_Name)
        Me.Panel_Name.Location = New System.Drawing.Point(0, 272)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(239, 40)
        Me.Panel_Name.TabIndex = 90
        '
        'Label_Name
        '
        Me.Label_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(8, 8)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(56, 21)
        Me.Label_Name.TabIndex = 95
        Me.Label_Name.Text = "Name:"
        Me.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_Name
        '
        Me.ComboBox_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Name.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Name.FormattingEnabled = True
        Me.ComboBox_Name.Location = New System.Drawing.Point(72, 8)
        Me.ComboBox_Name.Name = "ComboBox_Name"
        Me.ComboBox_Name.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox_Name.TabIndex = 102
        '
        'Button_Flip
        '
        Me.Button_Flip.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Flip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Flip.FlatAppearance.BorderSize = 0
        Me.Button_Flip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Flip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Flip.Location = New System.Drawing.Point(325, 280)
        Me.Button_Flip.Name = "Button_Flip"
        Me.Button_Flip.Size = New System.Drawing.Size(120, 24)
        Me.Button_Flip.TabIndex = 102
        Me.Button_Flip.Text = "Flip"
        Me.Button_Flip.UseVisualStyleBackColor = False
        '
        'Panel_Right
        '
        Me.Panel_Right.Controls.Add(Me.Label_Right)
        Me.Panel_Right.Controls.Add(Me.PixelBox_Right)
        Me.Panel_Right.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Right.Location = New System.Drawing.Point(216, 8)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(160, 176)
        Me.Panel_Right.TabIndex = 91
        '
        'Label_Right
        '
        Me.Label_Right.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Right.Location = New System.Drawing.Point(8, 0)
        Me.Label_Right.Name = "Label_Right"
        Me.Label_Right.Size = New System.Drawing.Size(144, 24)
        Me.Label_Right.TabIndex = 76
        Me.Label_Right.Text = "Right"
        Me.Label_Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Right})
        Me.ShapeContainer1.Size = New System.Drawing.Size(160, 176)
        Me.ShapeContainer1.TabIndex = 76
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape_Right
        '
        Me.RectangleShape_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Right.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Right.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Right.CornerRadius = 3
        Me.RectangleShape_Right.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Right.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Right.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape_Right.Name = "RectangleShape_Right"
        Me.RectangleShape_Right.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Right.Size = New System.Drawing.Size(144, 144)
        '
        'Label_Milliseconds
        '
        Me.Label_Milliseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Milliseconds.Location = New System.Drawing.Point(136, 8)
        Me.Label_Milliseconds.Name = "Label_Milliseconds"
        Me.Label_Milliseconds.Size = New System.Drawing.Size(88, 20)
        Me.Label_Milliseconds.TabIndex = 92
        Me.Label_Milliseconds.Text = " Milliseconds"
        Me.Label_Milliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Artist
        '
        Me.Panel_Artist.Controls.Add(Me.Label_Artist)
        Me.Panel_Artist.Controls.Add(Me.Button1)
        Me.Panel_Artist.Controls.Add(Me.ComboBox_Artist)
        Me.Panel_Artist.Location = New System.Drawing.Point(0, 232)
        Me.Panel_Artist.Name = "Panel_Artist"
        Me.Panel_Artist.Size = New System.Drawing.Size(239, 40)
        Me.Panel_Artist.TabIndex = 98
        '
        'Label_Artist
        '
        Me.Label_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Artist.Location = New System.Drawing.Point(8, 8)
        Me.Label_Artist.Name = "Label_Artist"
        Me.Label_Artist.Size = New System.Drawing.Size(56, 24)
        Me.Label_Artist.TabIndex = 122
        Me.Label_Artist.Text = "Artist:"
        Me.Label_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox_Artist
        '
        Me.ComboBox_Artist.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Artist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Artist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Artist.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Artist.FormattingEnabled = True
        Me.ComboBox_Artist.ItemHeight = 13
        Me.ComboBox_Artist.Location = New System.Drawing.Point(72, 8)
        Me.ComboBox_Artist.Name = "ComboBox_Artist"
        Me.ComboBox_Artist.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox_Artist.TabIndex = 123
        '
        'Panel_Animation
        '
        Me.Panel_Animation.Controls.Add(Me.Label_Animation)
        Me.Panel_Animation.Controls.Add(Me.ComboBox_Animation)
        Me.Panel_Animation.Location = New System.Drawing.Point(240, 232)
        Me.Panel_Animation.Name = "Panel_Animation"
        Me.Panel_Animation.Size = New System.Drawing.Size(208, 40)
        Me.Panel_Animation.TabIndex = 99
        '
        'Panel_Side
        '
        Me.Panel_Side.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel_Side.Controls.Add(Me.Button3)
        Me.Panel_Side.Controls.Add(Me.CheckBox_NonDirectional)
        Me.Panel_Side.Controls.Add(Me.Label_Facing)
        Me.Panel_Side.Controls.Add(Me.Button_Flip)
        Me.Panel_Side.Controls.Add(Me.Panel_Delay)
        Me.Panel_Side.Controls.Add(Me.Panel_Left)
        Me.Panel_Side.Controls.Add(Me.Button_Save)
        Me.Panel_Side.Controls.Add(Me.Panel_Type)
        Me.Panel_Side.Controls.Add(Me.Panel_Animation)
        Me.Panel_Side.Controls.Add(Me.Panel_Name)
        Me.Panel_Side.Controls.Add(Me.Panel_Artist)
        Me.Panel_Side.Controls.Add(Me.Panel_Right)
        Me.Panel_Side.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Side.Location = New System.Drawing.Point(457, 0)
        Me.Panel_Side.Name = "Panel_Side"
        Me.Panel_Side.Size = New System.Drawing.Size(452, 466)
        Me.Panel_Side.TabIndex = 101
        '
        'CheckBox_NonDirectional
        '
        Me.CheckBox_NonDirectional.AutoSize = True
        Me.CheckBox_NonDirectional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_NonDirectional.Location = New System.Drawing.Point(327, 323)
        Me.CheckBox_NonDirectional.Name = "CheckBox_NonDirectional"
        Me.CheckBox_NonDirectional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox_NonDirectional.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox_NonDirectional.TabIndex = 103
        Me.CheckBox_NonDirectional.Text = "Non Directional"
        Me.CheckBox_NonDirectional.UseVisualStyleBackColor = True
        Me.CheckBox_NonDirectional.Visible = False
        '
        'Panel_Delay
        '
        Me.Panel_Delay.Controls.Add(Me.Label_Milliseconds)
        Me.Panel_Delay.Controls.Add(Me.NumericUpDown_Delay)
        Me.Panel_Delay.Controls.Add(Me.Label_Delay)
        Me.Panel_Delay.Location = New System.Drawing.Point(0, 312)
        Me.Panel_Delay.Name = "Panel_Delay"
        Me.Panel_Delay.Size = New System.Drawing.Size(224, 40)
        Me.Panel_Delay.TabIndex = 101
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(222, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(12, 21)
        Me.Button1.TabIndex = 104
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(222, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(12, 21)
        Me.Button2.TabIndex = 105
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(276, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 32)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "Animation Delay Info"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form_AnimationBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 466)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Side)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form_AnimationBuilder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animation Builder"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Left.ResumeLayout(False)
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Type.ResumeLayout(False)
        Me.Panel_Type.PerformLayout()
        Me.Panel_Name.ResumeLayout(False)
        Me.Panel_Right.ResumeLayout(False)
        Me.Panel_Artist.ResumeLayout(False)
        Me.Panel_Animation.ResumeLayout(False)
        Me.Panel_Side.ResumeLayout(False)
        Me.Panel_Side.PerformLayout()
        Me.Panel_Delay.ResumeLayout(False)
        CType(Me.PixelBox_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixelBox_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Save As Button
    Friend WithEvents PixelBox_Left As PixelBox
    Private WithEvents Label_Left As Label
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents RectangleShape_Left As RectangleShape
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_Left As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents NumericUpDown_Delay As NumericUpDown
    Friend WithEvents Label_Delay As Label
    Friend WithEvents Label_Animation As Label
    Friend WithEvents ComboBox_Animation As ComboBox
    Private WithEvents Label_DragDropHere As Label
    Friend WithEvents Panel_Type As Panel
    Friend WithEvents RadioButton_TypeFlyingPet As RadioButton
    Friend WithEvents RadioButton_TypeGroundPet As RadioButton
    Friend WithEvents Label_Type As Label
    Friend WithEvents Label_Facing As Label
    Friend WithEvents Panel_Name As Panel
    Friend WithEvents Panel_Right As Panel
    Private WithEvents Label_Right As Label
    Friend WithEvents PixelBox_Right As PixelBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape_Right As RectangleShape
    Friend WithEvents Label_Milliseconds As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Panel_Artist As Panel
    Friend WithEvents Panel_Animation As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton_TypeNature As RadioButton
    Friend WithEvents RadioButton_TypeObject As RadioButton
    Friend WithEvents Label_Animation_Frame_Count As Label
    Friend WithEvents ComboBox_Name As ComboBox
    Friend WithEvents Panel_Side As Panel
    Friend WithEvents Panel_Delay As Panel
    Friend WithEvents Button_Flip As Button
    Friend WithEvents Label_Artist As Label
    Friend WithEvents ComboBox_Artist As ComboBox
    Friend WithEvents CheckBox_NonDirectional As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
