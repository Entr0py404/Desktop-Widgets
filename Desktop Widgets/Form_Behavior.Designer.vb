<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Behavior
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Behavior))
        Me.Panel_PetPreview = New System.Windows.Forms.Panel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_PetPreview = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_PetName = New System.Windows.Forms.Label()
        Me.NumericUpDown_DefaultScale = New System.Windows.Forms.NumericUpDown()
        Me.Label_DefaultScale = New System.Windows.Forms.Label()
        Me.NumericUpDown_FollowCursorStoppingDistance_Px = New System.Windows.Forms.NumericUpDown()
        Me.Label_FollowCursorStoppingDistance_Px = New System.Windows.Forms.Label()
        Me.NumericUpDown_Opacity = New System.Windows.Forms.NumericUpDown()
        Me.Label_Opacity = New System.Windows.Forms.Label()
        Me.NumericUpDown_FallingMovement_Px = New System.Windows.Forms.NumericUpDown()
        Me.Label_FallingMovement_Px = New System.Windows.Forms.Label()
        Me.NumericUpDown_ScreenWarpingDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_ScreenWarpingDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_IdleAltDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_IdleAltDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_IdleDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_IdleDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_SleepDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_SleepDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_FallingMovement_Tick = New System.Windows.Forms.NumericUpDown()
        Me.Label_FallingMovement_Tick = New System.Windows.Forms.Label()
        Me.NumericUpDown_FlyingMovement_Tick = New System.Windows.Forms.NumericUpDown()
        Me.Label_FlyingMovement_Tick = New System.Windows.Forms.Label()
        Me.NumericUpDown_WalkingMovement_Tick = New System.Windows.Forms.NumericUpDown()
        Me.Label_WalkingMovement_Tick = New System.Windows.Forms.Label()
        Me.NumericUpDown_SleepingDecision_Min = New System.Windows.Forms.NumericUpDown()
        Me.Label_SleepingDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_TakeFlightDecision_Min = New System.Windows.Forms.NumericUpDown()
        Me.Label_TakeFlightDecision2 = New System.Windows.Forms.Label()
        Me.NumericUpDown_IdleDecision_Min = New System.Windows.Forms.NumericUpDown()
        Me.Label_IdleDecision2 = New System.Windows.Forms.Label()
        Me.NumericUpDown_TurningDecision_Min = New System.Windows.Forms.NumericUpDown()
        Me.Label_TurningDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_TakeFlightDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_TakeFlightDecision = New System.Windows.Forms.Label()
        Me.NumericUpDown_LandingDecision = New System.Windows.Forms.NumericUpDown()
        Me.Label_LandingDecision = New System.Windows.Forms.Label()
        Me.GroupBox_Settings = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Decisions = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Timers = New System.Windows.Forms.GroupBox()
        Me.GroupBox_TimersRandomization = New System.Windows.Forms.GroupBox()
        Me.Label_TimersRandomization_Max = New System.Windows.Forms.Label()
        Me.NumericUpDown_TurningDecision_Max = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_SleepingDecision_Max = New System.Windows.Forms.NumericUpDown()
        Me.Label_TimersRandomization_Min = New System.Windows.Forms.Label()
        Me.NumericUpDown_TakeFlightDecision_Max = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_IdleDecision_Max = New System.Windows.Forms.NumericUpDown()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.PixelBox_PetPreview = New Desktop_Widgets.PixelBox()
        Me.Panel_PetPreview.SuspendLayout()
        CType(Me.NumericUpDown_DefaultScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FollowCursorStoppingDistance_Px, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Opacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FallingMovement_Px, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_ScreenWarpingDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_IdleAltDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_IdleDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SleepDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FallingMovement_Tick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FlyingMovement_Tick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_WalkingMovement_Tick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SleepingDecision_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_TakeFlightDecision_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_IdleDecision_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_TurningDecision_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_TakeFlightDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LandingDecision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Settings.SuspendLayout()
        Me.GroupBox_Decisions.SuspendLayout()
        Me.GroupBox_Timers.SuspendLayout()
        Me.GroupBox_TimersRandomization.SuspendLayout()
        CType(Me.NumericUpDown_TurningDecision_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SleepingDecision_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_TakeFlightDecision_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_IdleDecision_Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixelBox_PetPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_PetPreview
        '
        Me.Panel_PetPreview.Controls.Add(Me.PixelBox_PetPreview)
        Me.Panel_PetPreview.Controls.Add(Me.ShapeContainer2)
        Me.Panel_PetPreview.Location = New System.Drawing.Point(15, 37)
        Me.Panel_PetPreview.Name = "Panel_PetPreview"
        Me.Panel_PetPreview.Size = New System.Drawing.Size(142, 143)
        Me.Panel_PetPreview.TabIndex = 86
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_PetPreview})
        Me.ShapeContainer2.Size = New System.Drawing.Size(142, 143)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape_PetPreview
        '
        Me.RectangleShape_PetPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_PetPreview.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_PetPreview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_PetPreview.CornerRadius = 3
        Me.RectangleShape_PetPreview.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_PetPreview.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_PetPreview.Location = New System.Drawing.Point(2, 2)
        Me.RectangleShape_PetPreview.Name = "RectangleShape_PetPreview"
        Me.RectangleShape_PetPreview.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_PetPreview.Size = New System.Drawing.Size(135, 135)
        '
        'Label_PetName
        '
        Me.Label_PetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PetName.Location = New System.Drawing.Point(12, 9)
        Me.Label_PetName.Name = "Label_PetName"
        Me.Label_PetName.Size = New System.Drawing.Size(145, 22)
        Me.Label_PetName.TabIndex = 87
        Me.Label_PetName.Text = "Pet Name"
        Me.Label_PetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown_DefaultScale
        '
        Me.NumericUpDown_DefaultScale.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_DefaultScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_DefaultScale.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_DefaultScale.Location = New System.Drawing.Point(207, 19)
        Me.NumericUpDown_DefaultScale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_DefaultScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_DefaultScale.Name = "NumericUpDown_DefaultScale"
        Me.NumericUpDown_DefaultScale.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_DefaultScale.TabIndex = 81
        Me.NumericUpDown_DefaultScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_DefaultScale
        '
        Me.Label_DefaultScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DefaultScale.Location = New System.Drawing.Point(113, 19)
        Me.Label_DefaultScale.Name = "Label_DefaultScale"
        Me.Label_DefaultScale.Size = New System.Drawing.Size(88, 20)
        Me.Label_DefaultScale.TabIndex = 82
        Me.Label_DefaultScale.Text = "Default Scale:"
        Me.Label_DefaultScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_FollowCursorStoppingDistance_Px
        '
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Location = New System.Drawing.Point(207, 71)
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Name = "NumericUpDown_FollowCursorStoppingDistance_Px"
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.TabIndex = 83
        Me.NumericUpDown_FollowCursorStoppingDistance_Px.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label_FollowCursorStoppingDistance_Px
        '
        Me.Label_FollowCursorStoppingDistance_Px.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FollowCursorStoppingDistance_Px.Location = New System.Drawing.Point(6, 71)
        Me.Label_FollowCursorStoppingDistance_Px.Name = "Label_FollowCursorStoppingDistance_Px"
        Me.Label_FollowCursorStoppingDistance_Px.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_FollowCursorStoppingDistance_Px.Size = New System.Drawing.Size(195, 20)
        Me.Label_FollowCursorStoppingDistance_Px.TabIndex = 84
        Me.Label_FollowCursorStoppingDistance_Px.Text = "Follow Cursor Stopping Distance:"
        Me.Label_FollowCursorStoppingDistance_Px.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_Opacity
        '
        Me.NumericUpDown_Opacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_Opacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_Opacity.DecimalPlaces = 1
        Me.NumericUpDown_Opacity.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_Opacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Opacity.Location = New System.Drawing.Point(207, 45)
        Me.NumericUpDown_Opacity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_Opacity.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Opacity.Name = "NumericUpDown_Opacity"
        Me.NumericUpDown_Opacity.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_Opacity.TabIndex = 85
        Me.NumericUpDown_Opacity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_Opacity
        '
        Me.Label_Opacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Opacity.Location = New System.Drawing.Point(147, 45)
        Me.Label_Opacity.Name = "Label_Opacity"
        Me.Label_Opacity.Size = New System.Drawing.Size(54, 20)
        Me.Label_Opacity.TabIndex = 86
        Me.Label_Opacity.Text = "Opacity:"
        Me.Label_Opacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_FallingMovement_Px
        '
        Me.NumericUpDown_FallingMovement_Px.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FallingMovement_Px.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_FallingMovement_Px.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FallingMovement_Px.Location = New System.Drawing.Point(207, 97)
        Me.NumericUpDown_FallingMovement_Px.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_FallingMovement_Px.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FallingMovement_Px.Name = "NumericUpDown_FallingMovement_Px"
        Me.NumericUpDown_FallingMovement_Px.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_FallingMovement_Px.TabIndex = 87
        Me.NumericUpDown_FallingMovement_Px.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_FallingMovement_Px
        '
        Me.Label_FallingMovement_Px.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FallingMovement_Px.Location = New System.Drawing.Point(91, 97)
        Me.Label_FallingMovement_Px.Name = "Label_FallingMovement_Px"
        Me.Label_FallingMovement_Px.Size = New System.Drawing.Size(110, 20)
        Me.Label_FallingMovement_Px.TabIndex = 88
        Me.Label_FallingMovement_Px.Text = "Falling Movement:"
        Me.Label_FallingMovement_Px.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_ScreenWarpingDecision
        '
        Me.NumericUpDown_ScreenWarpingDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_ScreenWarpingDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_ScreenWarpingDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_ScreenWarpingDecision.Location = New System.Drawing.Point(207, 71)
        Me.NumericUpDown_ScreenWarpingDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ScreenWarpingDecision.Name = "NumericUpDown_ScreenWarpingDecision"
        Me.NumericUpDown_ScreenWarpingDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_ScreenWarpingDecision.TabIndex = 87
        Me.NumericUpDown_ScreenWarpingDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_ScreenWarpingDecision
        '
        Me.Label_ScreenWarpingDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ScreenWarpingDecision.Location = New System.Drawing.Point(46, 71)
        Me.Label_ScreenWarpingDecision.Name = "Label_ScreenWarpingDecision"
        Me.Label_ScreenWarpingDecision.Size = New System.Drawing.Size(155, 20)
        Me.Label_ScreenWarpingDecision.TabIndex = 88
        Me.Label_ScreenWarpingDecision.Text = "Screen Warping Decision:"
        Me.Label_ScreenWarpingDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_IdleAltDecision
        '
        Me.NumericUpDown_IdleAltDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_IdleAltDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_IdleAltDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_IdleAltDecision.Location = New System.Drawing.Point(207, 45)
        Me.NumericUpDown_IdleAltDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_IdleAltDecision.Name = "NumericUpDown_IdleAltDecision"
        Me.NumericUpDown_IdleAltDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_IdleAltDecision.TabIndex = 85
        Me.NumericUpDown_IdleAltDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_IdleAltDecision
        '
        Me.Label_IdleAltDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdleAltDecision.Location = New System.Drawing.Point(97, 45)
        Me.Label_IdleAltDecision.Name = "Label_IdleAltDecision"
        Me.Label_IdleAltDecision.Size = New System.Drawing.Size(104, 20)
        Me.Label_IdleAltDecision.TabIndex = 86
        Me.Label_IdleAltDecision.Text = "Idle Alt Decision:"
        Me.Label_IdleAltDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_IdleDecision
        '
        Me.NumericUpDown_IdleDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_IdleDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_IdleDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_IdleDecision.Location = New System.Drawing.Point(207, 19)
        Me.NumericUpDown_IdleDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_IdleDecision.Name = "NumericUpDown_IdleDecision"
        Me.NumericUpDown_IdleDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_IdleDecision.TabIndex = 83
        Me.NumericUpDown_IdleDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_IdleDecision
        '
        Me.Label_IdleDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdleDecision.Location = New System.Drawing.Point(116, 19)
        Me.Label_IdleDecision.Name = "Label_IdleDecision"
        Me.Label_IdleDecision.Size = New System.Drawing.Size(85, 20)
        Me.Label_IdleDecision.TabIndex = 84
        Me.Label_IdleDecision.Text = "Idle Decision:"
        Me.Label_IdleDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_SleepDecision
        '
        Me.NumericUpDown_SleepDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_SleepDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_SleepDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_SleepDecision.Location = New System.Drawing.Point(207, 97)
        Me.NumericUpDown_SleepDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SleepDecision.Name = "NumericUpDown_SleepDecision"
        Me.NumericUpDown_SleepDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_SleepDecision.TabIndex = 81
        Me.NumericUpDown_SleepDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_SleepDecision
        '
        Me.Label_SleepDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SleepDecision.Location = New System.Drawing.Point(105, 97)
        Me.Label_SleepDecision.Name = "Label_SleepDecision"
        Me.Label_SleepDecision.Size = New System.Drawing.Size(96, 20)
        Me.Label_SleepDecision.TabIndex = 82
        Me.Label_SleepDecision.Text = "Sleep Decision:"
        Me.Label_SleepDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_FallingMovement_Tick
        '
        Me.NumericUpDown_FallingMovement_Tick.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FallingMovement_Tick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_FallingMovement_Tick.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FallingMovement_Tick.Location = New System.Drawing.Point(207, 71)
        Me.NumericUpDown_FallingMovement_Tick.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_FallingMovement_Tick.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FallingMovement_Tick.Name = "NumericUpDown_FallingMovement_Tick"
        Me.NumericUpDown_FallingMovement_Tick.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_FallingMovement_Tick.TabIndex = 85
        Me.NumericUpDown_FallingMovement_Tick.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_FallingMovement_Tick
        '
        Me.Label_FallingMovement_Tick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FallingMovement_Tick.Location = New System.Drawing.Point(91, 71)
        Me.Label_FallingMovement_Tick.Name = "Label_FallingMovement_Tick"
        Me.Label_FallingMovement_Tick.Size = New System.Drawing.Size(110, 20)
        Me.Label_FallingMovement_Tick.TabIndex = 86
        Me.Label_FallingMovement_Tick.Text = "Falling Movement:"
        Me.Label_FallingMovement_Tick.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_FlyingMovement_Tick
        '
        Me.NumericUpDown_FlyingMovement_Tick.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FlyingMovement_Tick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_FlyingMovement_Tick.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FlyingMovement_Tick.Location = New System.Drawing.Point(207, 45)
        Me.NumericUpDown_FlyingMovement_Tick.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_FlyingMovement_Tick.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FlyingMovement_Tick.Name = "NumericUpDown_FlyingMovement_Tick"
        Me.NumericUpDown_FlyingMovement_Tick.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_FlyingMovement_Tick.TabIndex = 83
        Me.NumericUpDown_FlyingMovement_Tick.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label_FlyingMovement_Tick
        '
        Me.Label_FlyingMovement_Tick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FlyingMovement_Tick.Location = New System.Drawing.Point(95, 45)
        Me.Label_FlyingMovement_Tick.Name = "Label_FlyingMovement_Tick"
        Me.Label_FlyingMovement_Tick.Size = New System.Drawing.Size(106, 20)
        Me.Label_FlyingMovement_Tick.TabIndex = 84
        Me.Label_FlyingMovement_Tick.Text = "Flying Movement:"
        Me.Label_FlyingMovement_Tick.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_WalkingMovement_Tick
        '
        Me.NumericUpDown_WalkingMovement_Tick.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_WalkingMovement_Tick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_WalkingMovement_Tick.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_WalkingMovement_Tick.Location = New System.Drawing.Point(207, 19)
        Me.NumericUpDown_WalkingMovement_Tick.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_WalkingMovement_Tick.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_WalkingMovement_Tick.Name = "NumericUpDown_WalkingMovement_Tick"
        Me.NumericUpDown_WalkingMovement_Tick.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_WalkingMovement_Tick.TabIndex = 81
        Me.NumericUpDown_WalkingMovement_Tick.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label_WalkingMovement_Tick
        '
        Me.Label_WalkingMovement_Tick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_WalkingMovement_Tick.Location = New System.Drawing.Point(82, 19)
        Me.Label_WalkingMovement_Tick.Name = "Label_WalkingMovement_Tick"
        Me.Label_WalkingMovement_Tick.Size = New System.Drawing.Size(119, 20)
        Me.Label_WalkingMovement_Tick.TabIndex = 82
        Me.Label_WalkingMovement_Tick.Text = "Walking Movement:"
        Me.Label_WalkingMovement_Tick.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_SleepingDecision_Min
        '
        Me.NumericUpDown_SleepingDecision_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_SleepingDecision_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_SleepingDecision_Min.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_SleepingDecision_Min.Location = New System.Drawing.Point(145, 117)
        Me.NumericUpDown_SleepingDecision_Min.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_SleepingDecision_Min.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SleepingDecision_Min.Name = "NumericUpDown_SleepingDecision_Min"
        Me.NumericUpDown_SleepingDecision_Min.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_SleepingDecision_Min.TabIndex = 87
        Me.NumericUpDown_SleepingDecision_Min.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_SleepingDecision
        '
        Me.Label_SleepingDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SleepingDecision.Location = New System.Drawing.Point(26, 115)
        Me.Label_SleepingDecision.Name = "Label_SleepingDecision"
        Me.Label_SleepingDecision.Size = New System.Drawing.Size(113, 20)
        Me.Label_SleepingDecision.TabIndex = 88
        Me.Label_SleepingDecision.Text = "Sleeping Decision:"
        Me.Label_SleepingDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_TakeFlightDecision_Min
        '
        Me.NumericUpDown_TakeFlightDecision_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TakeFlightDecision_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_TakeFlightDecision_Min.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TakeFlightDecision_Min.Location = New System.Drawing.Point(145, 91)
        Me.NumericUpDown_TakeFlightDecision_Min.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_TakeFlightDecision_Min.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TakeFlightDecision_Min.Name = "NumericUpDown_TakeFlightDecision_Min"
        Me.NumericUpDown_TakeFlightDecision_Min.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_TakeFlightDecision_Min.TabIndex = 85
        Me.NumericUpDown_TakeFlightDecision_Min.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_TakeFlightDecision2
        '
        Me.Label_TakeFlightDecision2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TakeFlightDecision2.Location = New System.Drawing.Point(11, 91)
        Me.Label_TakeFlightDecision2.Name = "Label_TakeFlightDecision2"
        Me.Label_TakeFlightDecision2.Size = New System.Drawing.Size(128, 20)
        Me.Label_TakeFlightDecision2.TabIndex = 86
        Me.Label_TakeFlightDecision2.Text = "Take Flight Decision:"
        Me.Label_TakeFlightDecision2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_IdleDecision_Min
        '
        Me.NumericUpDown_IdleDecision_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_IdleDecision_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_IdleDecision_Min.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_IdleDecision_Min.Location = New System.Drawing.Point(145, 65)
        Me.NumericUpDown_IdleDecision_Min.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_IdleDecision_Min.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_IdleDecision_Min.Name = "NumericUpDown_IdleDecision_Min"
        Me.NumericUpDown_IdleDecision_Min.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_IdleDecision_Min.TabIndex = 83
        Me.NumericUpDown_IdleDecision_Min.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_IdleDecision2
        '
        Me.Label_IdleDecision2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IdleDecision2.Location = New System.Drawing.Point(54, 65)
        Me.Label_IdleDecision2.Name = "Label_IdleDecision2"
        Me.Label_IdleDecision2.Size = New System.Drawing.Size(85, 20)
        Me.Label_IdleDecision2.TabIndex = 84
        Me.Label_IdleDecision2.Text = "Idle Decision:"
        Me.Label_IdleDecision2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_TurningDecision_Min
        '
        Me.NumericUpDown_TurningDecision_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TurningDecision_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_TurningDecision_Min.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TurningDecision_Min.Location = New System.Drawing.Point(145, 39)
        Me.NumericUpDown_TurningDecision_Min.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_TurningDecision_Min.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TurningDecision_Min.Name = "NumericUpDown_TurningDecision_Min"
        Me.NumericUpDown_TurningDecision_Min.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_TurningDecision_Min.TabIndex = 81
        Me.NumericUpDown_TurningDecision_Min.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_TurningDecision
        '
        Me.Label_TurningDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TurningDecision.Location = New System.Drawing.Point(32, 39)
        Me.Label_TurningDecision.Name = "Label_TurningDecision"
        Me.Label_TurningDecision.Size = New System.Drawing.Size(107, 20)
        Me.Label_TurningDecision.TabIndex = 82
        Me.Label_TurningDecision.Text = "Turning Decision:"
        Me.Label_TurningDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_TakeFlightDecision
        '
        Me.NumericUpDown_TakeFlightDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TakeFlightDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_TakeFlightDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TakeFlightDecision.Location = New System.Drawing.Point(207, 123)
        Me.NumericUpDown_TakeFlightDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TakeFlightDecision.Name = "NumericUpDown_TakeFlightDecision"
        Me.NumericUpDown_TakeFlightDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_TakeFlightDecision.TabIndex = 89
        Me.NumericUpDown_TakeFlightDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_TakeFlightDecision
        '
        Me.Label_TakeFlightDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TakeFlightDecision.Location = New System.Drawing.Point(73, 123)
        Me.Label_TakeFlightDecision.Name = "Label_TakeFlightDecision"
        Me.Label_TakeFlightDecision.Size = New System.Drawing.Size(128, 20)
        Me.Label_TakeFlightDecision.TabIndex = 90
        Me.Label_TakeFlightDecision.Text = "Take Flight Decision:"
        Me.Label_TakeFlightDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_LandingDecision
        '
        Me.NumericUpDown_LandingDecision.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_LandingDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_LandingDecision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_LandingDecision.Location = New System.Drawing.Point(207, 149)
        Me.NumericUpDown_LandingDecision.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_LandingDecision.Name = "NumericUpDown_LandingDecision"
        Me.NumericUpDown_LandingDecision.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_LandingDecision.TabIndex = 91
        Me.NumericUpDown_LandingDecision.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_LandingDecision
        '
        Me.Label_LandingDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LandingDecision.Location = New System.Drawing.Point(90, 149)
        Me.Label_LandingDecision.Name = "Label_LandingDecision"
        Me.Label_LandingDecision.Size = New System.Drawing.Size(109, 20)
        Me.Label_LandingDecision.TabIndex = 92
        Me.Label_LandingDecision.Text = "Landing Decision:"
        Me.Label_LandingDecision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox_Settings
        '
        Me.GroupBox_Settings.Controls.Add(Me.NumericUpDown_FallingMovement_Px)
        Me.GroupBox_Settings.Controls.Add(Me.Label_FallingMovement_Px)
        Me.GroupBox_Settings.Controls.Add(Me.NumericUpDown_DefaultScale)
        Me.GroupBox_Settings.Controls.Add(Me.Label_DefaultScale)
        Me.GroupBox_Settings.Controls.Add(Me.NumericUpDown_FollowCursorStoppingDistance_Px)
        Me.GroupBox_Settings.Controls.Add(Me.Label_FollowCursorStoppingDistance_Px)
        Me.GroupBox_Settings.Controls.Add(Me.NumericUpDown_Opacity)
        Me.GroupBox_Settings.Controls.Add(Me.Label_Opacity)
        Me.GroupBox_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Settings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox_Settings.Location = New System.Drawing.Point(173, 37)
        Me.GroupBox_Settings.Name = "GroupBox_Settings"
        Me.GroupBox_Settings.Size = New System.Drawing.Size(270, 127)
        Me.GroupBox_Settings.TabIndex = 106
        Me.GroupBox_Settings.TabStop = False
        Me.GroupBox_Settings.Text = "Settings"
        '
        'GroupBox_Decisions
        '
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_LandingDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_IdleDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_LandingDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_IdleDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_TakeFlightDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_SleepDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_TakeFlightDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_SleepDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_ScreenWarpingDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_IdleAltDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.Label_ScreenWarpingDecision)
        Me.GroupBox_Decisions.Controls.Add(Me.NumericUpDown_IdleAltDecision)
        Me.GroupBox_Decisions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Decisions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox_Decisions.Location = New System.Drawing.Point(173, 170)
        Me.GroupBox_Decisions.Name = "GroupBox_Decisions"
        Me.GroupBox_Decisions.Size = New System.Drawing.Size(270, 176)
        Me.GroupBox_Decisions.TabIndex = 107
        Me.GroupBox_Decisions.TabStop = False
        Me.GroupBox_Decisions.Text = "Decisions"
        '
        'GroupBox_Timers
        '
        Me.GroupBox_Timers.Controls.Add(Me.NumericUpDown_FallingMovement_Tick)
        Me.GroupBox_Timers.Controls.Add(Me.NumericUpDown_WalkingMovement_Tick)
        Me.GroupBox_Timers.Controls.Add(Me.Label_FallingMovement_Tick)
        Me.GroupBox_Timers.Controls.Add(Me.Label_WalkingMovement_Tick)
        Me.GroupBox_Timers.Controls.Add(Me.NumericUpDown_FlyingMovement_Tick)
        Me.GroupBox_Timers.Controls.Add(Me.Label_FlyingMovement_Tick)
        Me.GroupBox_Timers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Timers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox_Timers.Location = New System.Drawing.Point(449, 37)
        Me.GroupBox_Timers.Name = "GroupBox_Timers"
        Me.GroupBox_Timers.Size = New System.Drawing.Size(270, 127)
        Me.GroupBox_Timers.TabIndex = 108
        Me.GroupBox_Timers.TabStop = False
        Me.GroupBox_Timers.Text = "Timers"
        '
        'GroupBox_TimersRandomization
        '
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_TimersRandomization_Max)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_TurningDecision_Max)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_SleepingDecision_Max)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_TurningDecision)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_TimersRandomization_Min)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_TurningDecision_Min)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_SleepingDecision_Min)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_IdleDecision2)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_SleepingDecision)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_IdleDecision_Min)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_TakeFlightDecision_Max)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_IdleDecision_Max)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.NumericUpDown_TakeFlightDecision_Min)
        Me.GroupBox_TimersRandomization.Controls.Add(Me.Label_TakeFlightDecision2)
        Me.GroupBox_TimersRandomization.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_TimersRandomization.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox_TimersRandomization.Location = New System.Drawing.Point(449, 170)
        Me.GroupBox_TimersRandomization.Name = "GroupBox_TimersRandomization"
        Me.GroupBox_TimersRandomization.Size = New System.Drawing.Size(270, 176)
        Me.GroupBox_TimersRandomization.TabIndex = 109
        Me.GroupBox_TimersRandomization.TabStop = False
        Me.GroupBox_TimersRandomization.Text = "Timers Randomization"
        '
        'Label_TimersRandomization_Max
        '
        Me.Label_TimersRandomization_Max.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TimersRandomization_Max.Location = New System.Drawing.Point(207, 20)
        Me.Label_TimersRandomization_Max.Name = "Label_TimersRandomization_Max"
        Me.Label_TimersRandomization_Max.Size = New System.Drawing.Size(56, 16)
        Me.Label_TimersRandomization_Max.TabIndex = 111
        Me.Label_TimersRandomization_Max.Text = "Max"
        Me.Label_TimersRandomization_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown_TurningDecision_Max
        '
        Me.NumericUpDown_TurningDecision_Max.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TurningDecision_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_TurningDecision_Max.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TurningDecision_Max.Location = New System.Drawing.Point(207, 39)
        Me.NumericUpDown_TurningDecision_Max.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_TurningDecision_Max.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TurningDecision_Max.Name = "NumericUpDown_TurningDecision_Max"
        Me.NumericUpDown_TurningDecision_Max.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_TurningDecision_Max.TabIndex = 81
        Me.NumericUpDown_TurningDecision_Max.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDown_SleepingDecision_Max
        '
        Me.NumericUpDown_SleepingDecision_Max.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_SleepingDecision_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_SleepingDecision_Max.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_SleepingDecision_Max.Location = New System.Drawing.Point(207, 117)
        Me.NumericUpDown_SleepingDecision_Max.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_SleepingDecision_Max.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_SleepingDecision_Max.Name = "NumericUpDown_SleepingDecision_Max"
        Me.NumericUpDown_SleepingDecision_Max.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_SleepingDecision_Max.TabIndex = 87
        Me.NumericUpDown_SleepingDecision_Max.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label_TimersRandomization_Min
        '
        Me.Label_TimersRandomization_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TimersRandomization_Min.Location = New System.Drawing.Point(145, 21)
        Me.Label_TimersRandomization_Min.Name = "Label_TimersRandomization_Min"
        Me.Label_TimersRandomization_Min.Size = New System.Drawing.Size(56, 16)
        Me.Label_TimersRandomization_Min.TabIndex = 82
        Me.Label_TimersRandomization_Min.Text = "Min"
        Me.Label_TimersRandomization_Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown_TakeFlightDecision_Max
        '
        Me.NumericUpDown_TakeFlightDecision_Max.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TakeFlightDecision_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_TakeFlightDecision_Max.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TakeFlightDecision_Max.Location = New System.Drawing.Point(207, 91)
        Me.NumericUpDown_TakeFlightDecision_Max.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_TakeFlightDecision_Max.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TakeFlightDecision_Max.Name = "NumericUpDown_TakeFlightDecision_Max"
        Me.NumericUpDown_TakeFlightDecision_Max.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_TakeFlightDecision_Max.TabIndex = 85
        Me.NumericUpDown_TakeFlightDecision_Max.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDown_IdleDecision_Max
        '
        Me.NumericUpDown_IdleDecision_Max.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_IdleDecision_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown_IdleDecision_Max.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_IdleDecision_Max.Location = New System.Drawing.Point(207, 65)
        Me.NumericUpDown_IdleDecision_Max.Maximum = New Decimal(New Integer() {900000000, 0, 0, 0})
        Me.NumericUpDown_IdleDecision_Max.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_IdleDecision_Max.Name = "NumericUpDown_IdleDecision_Max"
        Me.NumericUpDown_IdleDecision_Max.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown_IdleDecision_Max.TabIndex = 83
        Me.NumericUpDown_IdleDecision_Max.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(15, 185)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(138, 32)
        Me.Button_Save.TabIndex = 110
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'PixelBox_PetPreview
        '
        Me.PixelBox_PetPreview.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_PetPreview.Location = New System.Drawing.Point(6, 6)
        Me.PixelBox_PetPreview.Name = "PixelBox_PetPreview"
        Me.PixelBox_PetPreview.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox_PetPreview.Size = New System.Drawing.Size(128, 128)
        Me.PixelBox_PetPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PetPreview.TabIndex = 27
        Me.PixelBox_PetPreview.TabStop = False
        '
        'Form_Behavior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 361)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.GroupBox_TimersRandomization)
        Me.Controls.Add(Me.GroupBox_Timers)
        Me.Controls.Add(Me.GroupBox_Decisions)
        Me.Controls.Add(Me.GroupBox_Settings)
        Me.Controls.Add(Me.Label_PetName)
        Me.Controls.Add(Me.Panel_PetPreview)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Behavior"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Behavior"
        Me.Panel_PetPreview.ResumeLayout(False)
        CType(Me.NumericUpDown_DefaultScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FollowCursorStoppingDistance_Px, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Opacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FallingMovement_Px, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_ScreenWarpingDecision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_IdleAltDecision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_IdleDecision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SleepDecision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FallingMovement_Tick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FlyingMovement_Tick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_WalkingMovement_Tick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SleepingDecision_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_TakeFlightDecision_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_IdleDecision_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_TurningDecision_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_TakeFlightDecision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LandingDecision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Settings.ResumeLayout(False)
        Me.GroupBox_Decisions.ResumeLayout(False)
        Me.GroupBox_Timers.ResumeLayout(False)
        Me.GroupBox_TimersRandomization.ResumeLayout(False)
        CType(Me.NumericUpDown_TurningDecision_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SleepingDecision_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_TakeFlightDecision_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_IdleDecision_Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixelBox_PetPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_PetPreview As Panel
    Friend WithEvents PixelBox_PetPreview As PixelBox
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape_PetPreview As RectangleShape
    Friend WithEvents Label_PetName As Label
    Friend WithEvents NumericUpDown_DefaultScale As NumericUpDown
    Friend WithEvents Label_DefaultScale As Label
    Friend WithEvents NumericUpDown_Opacity As NumericUpDown
    Friend WithEvents Label_Opacity As Label
    Friend WithEvents NumericUpDown_FollowCursorStoppingDistance_Px As NumericUpDown
    Friend WithEvents Label_FollowCursorStoppingDistance_Px As Label
    Friend WithEvents NumericUpDown_FallingMovement_Px As NumericUpDown
    Friend WithEvents Label_FallingMovement_Px As Label
    Friend WithEvents NumericUpDown_ScreenWarpingDecision As NumericUpDown
    Friend WithEvents Label_ScreenWarpingDecision As Label
    Friend WithEvents NumericUpDown_IdleAltDecision As NumericUpDown
    Friend WithEvents Label_IdleAltDecision As Label
    Friend WithEvents NumericUpDown_IdleDecision As NumericUpDown
    Friend WithEvents Label_IdleDecision As Label
    Friend WithEvents NumericUpDown_SleepDecision As NumericUpDown
    Friend WithEvents Label_SleepDecision As Label
    Friend WithEvents NumericUpDown_FallingMovement_Tick As NumericUpDown
    Friend WithEvents Label_FallingMovement_Tick As Label
    Friend WithEvents NumericUpDown_FlyingMovement_Tick As NumericUpDown
    Friend WithEvents Label_FlyingMovement_Tick As Label
    Friend WithEvents NumericUpDown_WalkingMovement_Tick As NumericUpDown
    Friend WithEvents Label_WalkingMovement_Tick As Label
    Friend WithEvents NumericUpDown_SleepingDecision_Min As NumericUpDown
    Friend WithEvents Label_SleepingDecision As Label
    Friend WithEvents NumericUpDown_TakeFlightDecision_Min As NumericUpDown
    Friend WithEvents Label_TakeFlightDecision2 As Label
    Friend WithEvents NumericUpDown_IdleDecision_Min As NumericUpDown
    Friend WithEvents Label_IdleDecision2 As Label
    Friend WithEvents NumericUpDown_TurningDecision_Min As NumericUpDown
    Friend WithEvents Label_TurningDecision As Label
    Friend WithEvents NumericUpDown_LandingDecision As NumericUpDown
    Friend WithEvents Label_LandingDecision As Label
    Friend WithEvents NumericUpDown_TakeFlightDecision As NumericUpDown
    Friend WithEvents Label_TakeFlightDecision As Label
    Friend WithEvents GroupBox_Settings As GroupBox
    Friend WithEvents GroupBox_Decisions As GroupBox
    Friend WithEvents GroupBox_Timers As GroupBox
    Friend WithEvents GroupBox_TimersRandomization As GroupBox
    Friend WithEvents NumericUpDown_SleepingDecision_Max As NumericUpDown
    Friend WithEvents NumericUpDown_TakeFlightDecision_Max As NumericUpDown
    Friend WithEvents NumericUpDown_IdleDecision_Max As NumericUpDown
    Friend WithEvents NumericUpDown_TurningDecision_Max As NumericUpDown
    Friend WithEvents Label_TimersRandomization_Min As Label
    Friend WithEvents Label_TimersRandomization_Max As Label
    Friend WithEvents Button_Save As Button
End Class
