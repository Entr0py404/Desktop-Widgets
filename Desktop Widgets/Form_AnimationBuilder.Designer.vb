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
        Me.ListBox_Images = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderneathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndOfListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleShape_Left = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_ClearFrames = New System.Windows.Forms.Button()
        Me.Button_RemoveSelectedFrame = New System.Windows.Forms.Button()
        Me.Button_DuplicateEndOfList = New System.Windows.Forms.Button()
        Me.Button_DuplicateUnderneath = New System.Windows.Forms.Button()
        Me.Button_MoveFrameDown = New System.Windows.Forms.Button()
        Me.Button_MoveFrameUp = New System.Windows.Forms.Button()
        Me.Label_DragDropHere = New System.Windows.Forms.Label()
        Me.Label_Animation_Frame_Count = New System.Windows.Forms.Label()
        Me.Label_AnimationPreview = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.ComboBox_Name = New System.Windows.Forms.ComboBox()
        Me.Label_Milliseconds = New System.Windows.Forms.Label()
        Me.Panel_Artist = New System.Windows.Forms.Panel()
        Me.Label_Artist = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox_Artist = New System.Windows.Forms.ComboBox()
        Me.Panel_Animation = New System.Windows.Forms.Panel()
        Me.Panel_Side = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_SelectedFrame = New System.Windows.Forms.Label()
        Me.Button_UnoptimizeGIFs = New System.Windows.Forms.Button()
        Me.Button_OptimizePNGs = New System.Windows.Forms.Button()
        Me.Button_OptimizeGIFs = New System.Windows.Forms.Button()
        Me.Button_AnimationInfo = New System.Windows.Forms.Button()
        Me.Panel_Delay = New System.Windows.Forms.Panel()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Flip = New System.Windows.Forms.Button()
        Me.PixelBox_Animation = New Desktop_Widgets.PixelBox()
        Me.PixelBox_SelectedFrame = New Desktop_Widgets.PixelBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Type.SuspendLayout()
        Me.Panel_Name.SuspendLayout()
        Me.Panel_Artist.SuspendLayout()
        Me.Panel_Animation.SuspendLayout()
        Me.Panel_Side.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel_Delay.SuspendLayout()
        CType(Me.PixelBox_Animation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixelBox_SelectedFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox_Images
        '
        Me.ListBox_Images.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ListBox_Images.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Images.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox_Images.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Images.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Images.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_Images.FormattingEnabled = True
        Me.ListBox_Images.HorizontalScrollbar = True
        Me.ListBox_Images.ItemHeight = 15
        Me.ListBox_Images.Location = New System.Drawing.Point(0, 24)
        Me.ListBox_Images.Name = "ListBox_Images"
        Me.ListBox_Images.Size = New System.Drawing.Size(477, 486)
        Me.ListBox_Images.TabIndex = 77
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.SelectedFrameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 52)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SelectedFrameToolStripMenuItem
        '
        Me.SelectedFrameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicateToolStripMenuItem, Me.ToolStripSeparator1, Me.MoveUpToolStripMenuItem, Me.MoveDownToolStripMenuItem, Me.ToolStripSeparator2, Me.RemoveToolStripMenuItem})
        Me.SelectedFrameToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SelectedFrameToolStripMenuItem.Name = "SelectedFrameToolStripMenuItem"
        Me.SelectedFrameToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.SelectedFrameToolStripMenuItem.Text = "Selected frame"
        '
        'DuplicateToolStripMenuItem
        '
        Me.DuplicateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DuplicateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnderneathToolStripMenuItem, Me.EndOfListToolStripMenuItem})
        Me.DuplicateToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem"
        Me.DuplicateToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.DuplicateToolStripMenuItem.Text = "Duplicate to"
        '
        'UnderneathToolStripMenuItem
        '
        Me.UnderneathToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.UnderneathToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UnderneathToolStripMenuItem.Name = "UnderneathToolStripMenuItem"
        Me.UnderneathToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.UnderneathToolStripMenuItem.Text = "Underneath"
        '
        'EndOfListToolStripMenuItem
        '
        Me.EndOfListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.EndOfListToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EndOfListToolStripMenuItem.Name = "EndOfListToolStripMenuItem"
        Me.EndOfListToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.EndOfListToolStripMenuItem.Text = "End of list"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'MoveUpToolStripMenuItem
        '
        Me.MoveUpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MoveUpToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MoveUpToolStripMenuItem.Name = "MoveUpToolStripMenuItem"
        Me.MoveUpToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.MoveUpToolStripMenuItem.Text = "Move up"
        '
        'MoveDownToolStripMenuItem
        '
        Me.MoveDownToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MoveDownToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MoveDownToolStripMenuItem.Name = "MoveDownToolStripMenuItem"
        Me.MoveDownToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.MoveDownToolStripMenuItem.Text = "Move down"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.RemoveToolStripMenuItem.Text = "Remove"
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
        Me.Panel_Main.Controls.Add(Me.Panel2)
        Me.Panel_Main.Controls.Add(Me.Label_DragDropHere)
        Me.Panel_Main.Controls.Add(Me.Label_Animation_Frame_Count)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(545, 530)
        Me.Panel_Main.TabIndex = 79
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button_ClearFrames)
        Me.Panel2.Controls.Add(Me.Button_RemoveSelectedFrame)
        Me.Panel2.Controls.Add(Me.Button_DuplicateEndOfList)
        Me.Panel2.Controls.Add(Me.Button_DuplicateUnderneath)
        Me.Panel2.Controls.Add(Me.Button_MoveFrameDown)
        Me.Panel2.Controls.Add(Me.Button_MoveFrameUp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(477, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(68, 486)
        Me.Panel2.TabIndex = 102
        '
        'Button_ClearFrames
        '
        Me.Button_ClearFrames.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Button_ClearFrames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_ClearFrames.FlatAppearance.BorderSize = 0
        Me.Button_ClearFrames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ClearFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearFrames.Image = Global.Desktop_Widgets.My.Resources.Resources.Trash
        Me.Button_ClearFrames.Location = New System.Drawing.Point(15, 280)
        Me.Button_ClearFrames.Name = "Button_ClearFrames"
        Me.Button_ClearFrames.Size = New System.Drawing.Size(42, 42)
        Me.Button_ClearFrames.TabIndex = 114
        Me.Button_ClearFrames.UseVisualStyleBackColor = False
        '
        'Button_RemoveSelectedFrame
        '
        Me.Button_RemoveSelectedFrame.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Button_RemoveSelectedFrame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_RemoveSelectedFrame.FlatAppearance.BorderSize = 0
        Me.Button_RemoveSelectedFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_RemoveSelectedFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_RemoveSelectedFrame.Image = Global.Desktop_Widgets.My.Resources.Resources.Remove
        Me.Button_RemoveSelectedFrame.Location = New System.Drawing.Point(15, 222)
        Me.Button_RemoveSelectedFrame.Name = "Button_RemoveSelectedFrame"
        Me.Button_RemoveSelectedFrame.Size = New System.Drawing.Size(42, 42)
        Me.Button_RemoveSelectedFrame.TabIndex = 113
        Me.Button_RemoveSelectedFrame.UseVisualStyleBackColor = False
        '
        'Button_DuplicateEndOfList
        '
        Me.Button_DuplicateEndOfList.BackColor = System.Drawing.Color.DarkViolet
        Me.Button_DuplicateEndOfList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DuplicateEndOfList.FlatAppearance.BorderSize = 0
        Me.Button_DuplicateEndOfList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DuplicateEndOfList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DuplicateEndOfList.Image = Global.Desktop_Widgets.My.Resources.Resources.Copy2
        Me.Button_DuplicateEndOfList.Location = New System.Drawing.Point(15, 161)
        Me.Button_DuplicateEndOfList.Name = "Button_DuplicateEndOfList"
        Me.Button_DuplicateEndOfList.Size = New System.Drawing.Size(42, 42)
        Me.Button_DuplicateEndOfList.TabIndex = 112
        Me.Button_DuplicateEndOfList.UseVisualStyleBackColor = False
        '
        'Button_DuplicateUnderneath
        '
        Me.Button_DuplicateUnderneath.BackColor = System.Drawing.Color.DarkViolet
        Me.Button_DuplicateUnderneath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_DuplicateUnderneath.FlatAppearance.BorderSize = 0
        Me.Button_DuplicateUnderneath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_DuplicateUnderneath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DuplicateUnderneath.Image = Global.Desktop_Widgets.My.Resources.Resources.Copy
        Me.Button_DuplicateUnderneath.Location = New System.Drawing.Point(15, 113)
        Me.Button_DuplicateUnderneath.Name = "Button_DuplicateUnderneath"
        Me.Button_DuplicateUnderneath.Size = New System.Drawing.Size(42, 42)
        Me.Button_DuplicateUnderneath.TabIndex = 111
        Me.Button_DuplicateUnderneath.UseVisualStyleBackColor = False
        '
        'Button_MoveFrameDown
        '
        Me.Button_MoveFrameDown.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_MoveFrameDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MoveFrameDown.FlatAppearance.BorderSize = 0
        Me.Button_MoveFrameDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MoveFrameDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MoveFrameDown.Image = Global.Desktop_Widgets.My.Resources.Resources.Down
        Me.Button_MoveFrameDown.Location = New System.Drawing.Point(15, 58)
        Me.Button_MoveFrameDown.Name = "Button_MoveFrameDown"
        Me.Button_MoveFrameDown.Size = New System.Drawing.Size(42, 42)
        Me.Button_MoveFrameDown.TabIndex = 110
        Me.Button_MoveFrameDown.UseVisualStyleBackColor = False
        '
        'Button_MoveFrameUp
        '
        Me.Button_MoveFrameUp.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_MoveFrameUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MoveFrameUp.FlatAppearance.BorderSize = 0
        Me.Button_MoveFrameUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MoveFrameUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MoveFrameUp.Image = Global.Desktop_Widgets.My.Resources.Resources.Up
        Me.Button_MoveFrameUp.Location = New System.Drawing.Point(15, 10)
        Me.Button_MoveFrameUp.Name = "Button_MoveFrameUp"
        Me.Button_MoveFrameUp.Size = New System.Drawing.Size(42, 42)
        Me.Button_MoveFrameUp.TabIndex = 109
        Me.Button_MoveFrameUp.UseVisualStyleBackColor = False
        '
        'Label_DragDropHere
        '
        Me.Label_DragDropHere.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_DragDropHere.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_DragDropHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DragDropHere.Location = New System.Drawing.Point(0, 0)
        Me.Label_DragDropHere.Name = "Label_DragDropHere"
        Me.Label_DragDropHere.Size = New System.Drawing.Size(545, 24)
        Me.Label_DragDropHere.TabIndex = 79
        Me.Label_DragDropHere.Text = "Drag Drop Images Here!"
        Me.Label_DragDropHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Animation_Frame_Count
        '
        Me.Label_Animation_Frame_Count.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_Animation_Frame_Count.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_Animation_Frame_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Animation_Frame_Count.Location = New System.Drawing.Point(0, 510)
        Me.Label_Animation_Frame_Count.Name = "Label_Animation_Frame_Count"
        Me.Label_Animation_Frame_Count.Size = New System.Drawing.Size(545, 20)
        Me.Label_Animation_Frame_Count.TabIndex = 101
        Me.Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Me.Label_Animation_Frame_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_AnimationPreview
        '
        Me.Label_AnimationPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AnimationPreview.Location = New System.Drawing.Point(8, 0)
        Me.Label_AnimationPreview.Name = "Label_AnimationPreview"
        Me.Label_AnimationPreview.Size = New System.Drawing.Size(144, 24)
        Me.Label_AnimationPreview.TabIndex = 76
        Me.Label_AnimationPreview.Text = "Animation Preview"
        Me.Label_AnimationPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.NumericUpDown_Delay.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_Delay.Name = "NumericUpDown_Delay"
        Me.NumericUpDown_Delay.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_Delay.TabIndex = 81
        Me.NumericUpDown_Delay.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_Delay
        '
        Me.Label_Delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delay.Location = New System.Drawing.Point(5, 8)
        Me.Label_Delay.Name = "Label_Delay"
        Me.Label_Delay.Size = New System.Drawing.Size(59, 20)
        Me.Label_Delay.TabIndex = 82
        Me.Label_Delay.Text = "Delay:"
        Me.Label_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Animation
        '
        Me.Label_Animation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Animation.Location = New System.Drawing.Point(3, 8)
        Me.Label_Animation.Name = "Label_Animation"
        Me.Label_Animation.Size = New System.Drawing.Size(69, 21)
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
        Me.Panel_Type.Size = New System.Drawing.Size(462, 39)
        Me.Panel_Type.TabIndex = 88
        '
        'RadioButton_TypeNature
        '
        Me.RadioButton_TypeNature.AutoSize = True
        Me.RadioButton_TypeNature.Location = New System.Drawing.Point(297, 12)
        Me.RadioButton_TypeNature.Name = "RadioButton_TypeNature"
        Me.RadioButton_TypeNature.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton_TypeNature.TabIndex = 102
        Me.RadioButton_TypeNature.Text = "Nature"
        Me.RadioButton_TypeNature.UseVisualStyleBackColor = True
        '
        'Label_Type
        '
        Me.Label_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Type.Location = New System.Drawing.Point(9, 8)
        Me.Label_Type.Name = "Label_Type"
        Me.Label_Type.Size = New System.Drawing.Size(56, 21)
        Me.Label_Type.TabIndex = 87
        Me.Label_Type.Text = "Type:"
        Me.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton_TypeObject
        '
        Me.RadioButton_TypeObject.AutoSize = True
        Me.RadioButton_TypeObject.Location = New System.Drawing.Point(235, 12)
        Me.RadioButton_TypeObject.Name = "RadioButton_TypeObject"
        Me.RadioButton_TypeObject.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_TypeObject.TabIndex = 101
        Me.RadioButton_TypeObject.Text = "Object"
        Me.RadioButton_TypeObject.UseVisualStyleBackColor = True
        '
        'RadioButton_TypeFlyingPet
        '
        Me.RadioButton_TypeFlyingPet.AutoSize = True
        Me.RadioButton_TypeFlyingPet.Location = New System.Drawing.Point(158, 12)
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
        Me.RadioButton_TypeGroundPet.Location = New System.Drawing.Point(73, 12)
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
        Me.Label_Facing.Location = New System.Drawing.Point(260, 283)
        Me.Label_Facing.Name = "Label_Facing"
        Me.Label_Facing.Size = New System.Drawing.Size(66, 21)
        Me.Label_Facing.TabIndex = 89
        Me.Label_Facing.Text = "Facing:"
        Me.Label_Facing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Name
        '
        Me.Panel_Name.Controls.Add(Me.Button2)
        Me.Panel_Name.Controls.Add(Me.Label_Name)
        Me.Panel_Name.Controls.Add(Me.ComboBox_Name)
        Me.Panel_Name.Location = New System.Drawing.Point(1, 271)
        Me.Panel_Name.Name = "Panel_Name"
        Me.Panel_Name.Size = New System.Drawing.Size(253, 40)
        Me.Panel_Name.TabIndex = 90
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Desktop_Widgets.My.Resources.Resources.Folder
        Me.Button2.Location = New System.Drawing.Point(222, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 21)
        Me.Button2.TabIndex = 105
        Me.Button2.UseVisualStyleBackColor = False
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
        'Label_Milliseconds
        '
        Me.Label_Milliseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Milliseconds.Location = New System.Drawing.Point(136, 8)
        Me.Label_Milliseconds.Name = "Label_Milliseconds"
        Me.Label_Milliseconds.Size = New System.Drawing.Size(92, 20)
        Me.Label_Milliseconds.TabIndex = 92
        Me.Label_Milliseconds.Text = " Milliseconds"
        Me.Label_Milliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Artist
        '
        Me.Panel_Artist.Controls.Add(Me.Label_Artist)
        Me.Panel_Artist.Controls.Add(Me.Button1)
        Me.Panel_Artist.Controls.Add(Me.ComboBox_Artist)
        Me.Panel_Artist.Location = New System.Drawing.Point(1, 231)
        Me.Panel_Artist.Name = "Panel_Artist"
        Me.Panel_Artist.Size = New System.Drawing.Size(253, 40)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Desktop_Widgets.My.Resources.Resources.Folder
        Me.Button1.Location = New System.Drawing.Point(222, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 21)
        Me.Button1.TabIndex = 104
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Panel_Animation.Location = New System.Drawing.Point(254, 231)
        Me.Panel_Animation.Name = "Panel_Animation"
        Me.Panel_Animation.Size = New System.Drawing.Size(208, 40)
        Me.Panel_Animation.TabIndex = 99
        '
        'Panel_Side
        '
        Me.Panel_Side.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel_Side.Controls.Add(Me.Panel1)
        Me.Panel_Side.Controls.Add(Me.Panel3)
        Me.Panel_Side.Controls.Add(Me.Button_UnoptimizeGIFs)
        Me.Panel_Side.Controls.Add(Me.Button_OptimizePNGs)
        Me.Panel_Side.Controls.Add(Me.Button_OptimizeGIFs)
        Me.Panel_Side.Controls.Add(Me.Button_AnimationInfo)
        Me.Panel_Side.Controls.Add(Me.Panel_Artist)
        Me.Panel_Side.Controls.Add(Me.Panel_Type)
        Me.Panel_Side.Controls.Add(Me.Panel_Name)
        Me.Panel_Side.Controls.Add(Me.Panel_Delay)
        Me.Panel_Side.Controls.Add(Me.Label_Facing)
        Me.Panel_Side.Controls.Add(Me.Button_Save)
        Me.Panel_Side.Controls.Add(Me.Panel_Animation)
        Me.Panel_Side.Controls.Add(Me.Button_Flip)
        Me.Panel_Side.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Side.Location = New System.Drawing.Point(545, 0)
        Me.Panel_Side.Name = "Panel_Side"
        Me.Panel_Side.Size = New System.Drawing.Size(463, 530)
        Me.Panel_Side.TabIndex = 101
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_AnimationPreview)
        Me.Panel1.Controls.Add(Me.PixelBox_Animation)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(247, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 176)
        Me.Panel1.TabIndex = 110
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(160, 176)
        Me.ShapeContainer1.TabIndex = 76
        Me.ShapeContainer1.TabStop = False
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
        Me.RectangleShape1.Name = "RectangleShape_Left"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(144, 144)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_SelectedFrame)
        Me.Panel3.Controls.Add(Me.PixelBox_SelectedFrame)
        Me.Panel3.Controls.Add(Me.ShapeContainer3)
        Me.Panel3.Location = New System.Drawing.Point(69, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 176)
        Me.Panel3.TabIndex = 109
        '
        'Label_SelectedFrame
        '
        Me.Label_SelectedFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SelectedFrame.Location = New System.Drawing.Point(8, 0)
        Me.Label_SelectedFrame.Name = "Label_SelectedFrame"
        Me.Label_SelectedFrame.Size = New System.Drawing.Size(144, 24)
        Me.Label_SelectedFrame.TabIndex = 76
        Me.Label_SelectedFrame.Text = "Selected Frame"
        Me.Label_SelectedFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_UnoptimizeGIFs
        '
        Me.Button_UnoptimizeGIFs.BackColor = System.Drawing.Color.DarkViolet
        Me.Button_UnoptimizeGIFs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_UnoptimizeGIFs.FlatAppearance.BorderSize = 0
        Me.Button_UnoptimizeGIFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_UnoptimizeGIFs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_UnoptimizeGIFs.Location = New System.Drawing.Point(282, 442)
        Me.Button_UnoptimizeGIFs.Name = "Button_UnoptimizeGIFs"
        Me.Button_UnoptimizeGIFs.Size = New System.Drawing.Size(172, 32)
        Me.Button_UnoptimizeGIFs.TabIndex = 107
        Me.Button_UnoptimizeGIFs.Text = "Unoptimize GIFs"
        Me.Button_UnoptimizeGIFs.UseVisualStyleBackColor = False
        Me.Button_UnoptimizeGIFs.Visible = False
        '
        'Button_OptimizePNGs
        '
        Me.Button_OptimizePNGs.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Button_OptimizePNGs.Enabled = False
        Me.Button_OptimizePNGs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_OptimizePNGs.FlatAppearance.BorderSize = 0
        Me.Button_OptimizePNGs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OptimizePNGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OptimizePNGs.Location = New System.Drawing.Point(282, 404)
        Me.Button_OptimizePNGs.Name = "Button_OptimizePNGs"
        Me.Button_OptimizePNGs.Size = New System.Drawing.Size(172, 32)
        Me.Button_OptimizePNGs.TabIndex = 106
        Me.Button_OptimizePNGs.Text = "Optimize PNGs"
        Me.Button_OptimizePNGs.UseVisualStyleBackColor = False
        Me.Button_OptimizePNGs.Visible = False
        '
        'Button_OptimizeGIFs
        '
        Me.Button_OptimizeGIFs.BackColor = System.Drawing.Color.DarkViolet
        Me.Button_OptimizeGIFs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_OptimizeGIFs.FlatAppearance.BorderSize = 0
        Me.Button_OptimizeGIFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OptimizeGIFs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OptimizeGIFs.Location = New System.Drawing.Point(282, 366)
        Me.Button_OptimizeGIFs.Name = "Button_OptimizeGIFs"
        Me.Button_OptimizeGIFs.Size = New System.Drawing.Size(172, 32)
        Me.Button_OptimizeGIFs.TabIndex = 105
        Me.Button_OptimizeGIFs.Text = "Optimize GIFs"
        Me.Button_OptimizeGIFs.UseVisualStyleBackColor = False
        Me.Button_OptimizeGIFs.Visible = False
        '
        'Button_AnimationInfo
        '
        Me.Button_AnimationInfo.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_AnimationInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_AnimationInfo.FlatAppearance.BorderSize = 0
        Me.Button_AnimationInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AnimationInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AnimationInfo.Image = Global.Desktop_Widgets.My.Resources.Resources.Info
        Me.Button_AnimationInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AnimationInfo.Location = New System.Drawing.Point(282, 319)
        Me.Button_AnimationInfo.Name = "Button_AnimationInfo"
        Me.Button_AnimationInfo.Size = New System.Drawing.Size(172, 32)
        Me.Button_AnimationInfo.TabIndex = 104
        Me.Button_AnimationInfo.Text = "Animation Info"
        Me.Button_AnimationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AnimationInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_AnimationInfo.UseVisualStyleBackColor = False
        '
        'Panel_Delay
        '
        Me.Panel_Delay.Controls.Add(Me.Label_Milliseconds)
        Me.Panel_Delay.Controls.Add(Me.NumericUpDown_Delay)
        Me.Panel_Delay.Controls.Add(Me.Label_Delay)
        Me.Panel_Delay.Location = New System.Drawing.Point(1, 311)
        Me.Panel_Delay.Name = "Panel_Delay"
        Me.Panel_Delay.Size = New System.Drawing.Size(253, 40)
        Me.Panel_Delay.TabIndex = 101
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Image = Global.Desktop_Widgets.My.Resources.Resources.Save
        Me.Button_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Save.Location = New System.Drawing.Point(73, 366)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_Save.Size = New System.Drawing.Size(144, 32)
        Me.Button_Save.TabIndex = 74
        Me.Button_Save.Text = "Save"
        Me.Button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Button_Flip
        '
        Me.Button_Flip.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Flip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Flip.FlatAppearance.BorderSize = 0
        Me.Button_Flip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Flip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Flip.Image = Global.Desktop_Widgets.My.Resources.Resources.Flip
        Me.Button_Flip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Flip.Location = New System.Drawing.Point(334, 277)
        Me.Button_Flip.Name = "Button_Flip"
        Me.Button_Flip.Size = New System.Drawing.Size(120, 32)
        Me.Button_Flip.TabIndex = 102
        Me.Button_Flip.Text = "Flip"
        Me.Button_Flip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Flip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_Flip.UseVisualStyleBackColor = False
        '
        'PixelBox_Animation
        '
        Me.PixelBox_Animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_Animation.Location = New System.Drawing.Point(16, 32)
        Me.PixelBox_Animation.Name = "PixelBox_Animation"
        Me.PixelBox_Animation.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.PixelBox_Animation.Size = New System.Drawing.Size(128, 128)
        Me.PixelBox_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_Animation.TabIndex = 75
        Me.PixelBox_Animation.TabStop = False
        '
        'PixelBox_SelectedFrame
        '
        Me.PixelBox_SelectedFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_SelectedFrame.Location = New System.Drawing.Point(16, 32)
        Me.PixelBox_SelectedFrame.Name = "PixelBox_SelectedFrame"
        Me.PixelBox_SelectedFrame.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.PixelBox_SelectedFrame.Size = New System.Drawing.Size(128, 128)
        Me.PixelBox_SelectedFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_SelectedFrame.TabIndex = 75
        Me.PixelBox_SelectedFrame.TabStop = False
        '
        'Form_AnimationBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 530)
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
        Me.Panel2.ResumeLayout(False)
        CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Type.ResumeLayout(False)
        Me.Panel_Type.PerformLayout()
        Me.Panel_Name.ResumeLayout(False)
        Me.Panel_Artist.ResumeLayout(False)
        Me.Panel_Animation.ResumeLayout(False)
        Me.Panel_Side.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel_Delay.ResumeLayout(False)
        CType(Me.PixelBox_Animation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixelBox_SelectedFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Save As Button
    Friend WithEvents PixelBox_Animation As PixelBox
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents RectangleShape_Left As RectangleShape
    Friend WithEvents Panel_Main As Panel
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_AnimationInfo As Button
    Friend WithEvents Button_OptimizeGIFs As Button
    Friend WithEvents Button_OptimizePNGs As Button
    Friend WithEvents Button_UnoptimizeGIFs As Button
    Private WithEvents Label_AnimationPreview As Label
    Private WithEvents Label_SelectedFrame As Label
    Friend WithEvents PixelBox_SelectedFrame As PixelBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents SelectedFrameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DuplicateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnderneathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndOfListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_MoveFrameUp As Button
    Friend WithEvents Button_ClearFrames As Button
    Friend WithEvents Button_RemoveSelectedFrame As Button
    Friend WithEvents Button_DuplicateEndOfList As Button
    Friend WithEvents Button_DuplicateUnderneath As Button
    Friend WithEvents Button_MoveFrameDown As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
