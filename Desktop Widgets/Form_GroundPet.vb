Imports System.Drawing.Imaging

Public Class Form_GroundPet
    Dim Rand As New Random
    Dim Dragging As Boolean = False
    Dim FormLoadLock As Boolean = True
    Dim MYScreen As Screen
    Dim BlockEvent_DisplayComboBox As Boolean = False

    Public TurnLeft As Boolean = False
    Public FollowCursor As Boolean = False
    Public PetDir As String

    Public HasAnimation_Dragging As Boolean = False
    Public HasAnimation_IdlingAlt As Boolean = False
    Public HasAnimation_Sleeping As Boolean = False
    Public HasAnimation_Falling As Boolean = False
    Public HasAnimation_Land As Boolean = False
    Public HasAnimation_Pose As Boolean = False
    Public HasAnimation_Pose2 As Boolean = False
    Public HasAnimation_Pose3 As Boolean = False
    Public HasAnimation_Pose4 As Boolean = False
    Public HasAnimation_Pose5 As Boolean = False
    Dim Poses As New List(Of String)

    ' Behavior settings
    Dim DefaultScale As Integer = 1 '1x
    Dim FollowCursor_StoppingDistance_Px As Integer = 6 '6px
    Dim Falling_Movement_Px As Integer = 5 '5px

    Dim IdleDecision As Integer = 45 '45%
    Dim IdleAltDecision As Integer = 35 '35%
    Dim ScreenWarpingDecision As Integer = 60 '60%
    Dim PoseDecision As Integer = 35 '35%

    Dim Walking_Movement_Tick As Integer = 1
    Dim Falling_Movement_Tick As Integer = 1
    Dim TurningDecision_Min As Integer = 2500 '2.5 seconds
    Dim TurningDecision_Max As Integer = 3500 '3.5 seconds
    Dim IdleDecision_Min As Integer = 2500 '2.5 seconds
    Dim IdleDecision_Max As Integer = 3500 '3.5 seconds

    Dim SleepDecision As Integer = 15 '15%
    Dim Sleeping_Min As Integer = 90000 '1.5 minutes
    Dim Sleeping_Max As Integer = 150000 '2.5 minutes

    Private BehaviorForm As Form_Behavior = Nothing

    ' Dictionary to hold different animations.
    Private Animations As New Dictionary(Of String, AnimationSystem)()
    ' The currently active animation.
    Private CurrentAnimation As AnimationSystem

    ' Form_GroundPet - Load
    Private Sub Form_GroundPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Walking
        If File.Exists(PetDir & "\Walking.gif") Then
            Animations.Add("Walking", New AnimationSystem(PetDir & "\Walking.gif", "Walking", True, Me))
        End If

        ' Idling
        If File.Exists(PetDir & "\Idling.gif") Then
            Animations.Add("Idling", New AnimationSystem(PetDir & "\Idling.gif", "Idling", True, Me))
        End If

        ' Idling Alt
        If File.Exists(PetDir & "\Idling Alt.gif") Then
            Animations.Add("Idling Alt", New AnimationSystem(PetDir & "\Idling Alt.gif", "Idling Alt", True, Me))
            HasAnimation_IdlingAlt = True
        End If

        ' Sleeping
        If File.Exists(PetDir & "\Sleeping.gif") Then
            Animations.Add("Sleeping", New AnimationSystem(PetDir & "\Sleeping.gif", "Sleeping", True, Me))
            HasAnimation_Sleeping = True
        End If

        ' Dragging
        If File.Exists(PetDir & "\Dragging.gif") Then
            Animations.Add("Dragging", New AnimationSystem(PetDir & "\Dragging.gif", "Dragging", True, Me))
            HasAnimation_Dragging = True
        ElseIf File.Exists(PetDir & "\Dragging.png") Then
            Animations.Add("Dragging", New AnimationSystem(PetDir & "\Dragging.png", "Dragging", True, Me))
            HasAnimation_Dragging = True
        End If

        ' Falling
        If File.Exists(PetDir & "\Falling.gif") Then
            Animations.Add("Falling", New AnimationSystem(PetDir & "\Falling.gif", "Falling", True, Me))
            HasAnimation_Falling = True
        ElseIf File.Exists(PetDir & "\Falling.png") Then
            Animations.Add("Falling", New AnimationSystem(PetDir & "\Falling.png", "Falling", True, Me))
            HasAnimation_Falling = True
        End If

        ' Land
        If File.Exists(PetDir & "\Land.gif") Then
            Animations.Add("Land", New AnimationSystem(PetDir & "\Land.gif", "Land", False, Me))
            HasAnimation_Land = True
        End If

        ' Pose
        If File.Exists(PetDir & "\Pose.gif") Then
            Animations.Add("Pose", New AnimationSystem(PetDir & "\Pose.gif", "Pose", False, Me))
            HasAnimation_Pose = True
        End If

        ' Pose2
        If File.Exists(PetDir & "\Pose2.gif") Then
            Animations.Add("Pose2", New AnimationSystem(PetDir & "\Pose2.gif", "Pose2", False, Me))
            HasAnimation_Pose2 = True
        End If

        ' Pose3
        If File.Exists(PetDir & "\Pose3.gif") Then
            Animations.Add("Pose3", New AnimationSystem(PetDir & "\Pose3.gif", "Pose3", False, Me))
            HasAnimation_Pose3 = True
        End If

        ' Pose4
        If File.Exists(PetDir & "\Pose4.gif") Then
            Animations.Add("Pose4", New AnimationSystem(PetDir & "\Pose4.gif", "Pose4", False, Me))
            HasAnimation_Pose4 = True
        End If

        ' Pose5
        If File.Exists(PetDir & "\Pose5.gif") Then
            Animations.Add("Pose5", New AnimationSystem(PetDir & "\Pose5.gif", "Pose5", False, Me))
            HasAnimation_Pose5 = True
        End If

        If HasAnimation_Pose Then
            Poses.Add("Pose")
        End If
        If HasAnimation_Pose2 Then
            Poses.Add("Pose2")
        End If
        If HasAnimation_Pose3 Then
            Poses.Add("Pose3")
        End If
        If HasAnimation_Pose4 Then
            Poses.Add("Pose4")
        End If
        If HasAnimation_Pose5 Then
            Poses.Add("Pose5")
        End If

        ' Set the initial animation.
        SetAnimation("Idling")

        ' Set the form title.
        Me.Text = "Pet - " & Path.GetFileName(PetDir)


        Dim R As Integer = CInt(Rnd(1))
        If R = 0 Then
            TurnLeft = True
        Else
            TurnLeft = False
        End If


        ' Add the available displays to the DisplayToolStripComboBox.
        DisplayToolStripComboBox.BeginUpdate()
        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                DisplayToolStripComboBox.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                DisplayToolStripComboBox.SelectedIndex = DisplayToolStripComboBox.Items.Count - 1
            Else
                DisplayToolStripComboBox.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next
        ' Add All item
        If DisplayToolStripComboBox.Items.Count >= 2 Then
            DisplayToolStripComboBox.Items.Add("All")
        End If
        DisplayToolStripComboBox.EndUpdate()

        DisplayToolStripComboBox.SelectedIndex = Form_Pets.ComboBox_Display.SelectedIndex
        FollowCursorToolStripMenuItem.Checked = Form_Pets.CheckBox_FollowCursor.Checked
        Me.TopMost = Form_Pets.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Pets.CheckBox_TopMost.Checked

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Timer_Walking.Enabled = True
        Timer_Falling.Enabled = True
        Timer_IdleDecision.Enabled = True
        Timer_TurningDecision.Enabled = True

        'AddHandler Microsoft.Win32.SystemEvents.DisplaySettingsChanged, AddressOf DisplaySettingsChanged

        Dim iniFilePath As String = Application.StartupPath & "\" & PetDir & "\Behavior.ini"
        If File.Exists(iniFilePath) Then
            Try
                Dim INI As New MadMilkman.Ini.IniFile()
                INI.Load(iniFilePath)

                ' [Settings]
                If INI.Sections("Settings") IsNot Nothing Then
                    If INI.Sections("Settings").Keys("DefaultScale") IsNot Nothing Then
                        DefaultScale = CInt(INI.Sections("Settings").Keys("DefaultScale").Value)
                        'Console.WriteLine("DefaultScale = " & DefaultScale)
                        If DefaultScale <= 0 Then
                            DefaultScale = 1
                        End If
                    End If

                    If INI.Sections("Settings").Keys("FollowCursor_StoppingDistance_Px") IsNot Nothing Then
                        FollowCursor_StoppingDistance_Px = CInt(INI.Sections("Settings").Keys("FollowCursor_StoppingDistance_Px").Value)
                    End If

                    If INI.Sections("Settings").Keys("Falling_Movement_Px") IsNot Nothing Then
                        Falling_Movement_Px = CInt(INI.Sections("Settings").Keys("Falling_Movement_Px").Value)
                    End If

                    If INI.Sections("Settings").Keys("Opacity") IsNot Nothing Then
                        Me.Opacity = CDbl(INI.Sections("Settings").Keys("Opacity").Value)
                        Console.WriteLine("Opacity in ini used")
                    End If
                End If

                ' [Decisions]
                If INI.Sections("Decisions") IsNot Nothing Then
                    If INI.Sections("Decisions").Keys("IdleDecision") IsNot Nothing Then
                        IdleDecision = CInt(INI.Sections("Decisions").Keys("IdleDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("IdleAltDecision") IsNot Nothing Then
                        IdleAltDecision = CInt(INI.Sections("Decisions").Keys("IdleAltDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("ScreenWarpingDecision") IsNot Nothing Then
                        ScreenWarpingDecision = CInt(INI.Sections("Decisions").Keys("ScreenWarpingDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("SleepDecision") IsNot Nothing Then
                        SleepDecision = CInt(INI.Sections("Decisions").Keys("SleepDecision").Value)
                    End If
                End If

                ' [Timers_Tick]
                If INI.Sections("Timers_Tick") IsNot Nothing Then
                    If INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick") IsNot Nothing Then
                        Walking_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick").Value)
                        Timer_Walking.Interval = Walking_Movement_Tick
                    End If

                    If INI.Sections("Timers_Tick").Keys("Falling_Movement_Tick") IsNot Nothing Then
                        Falling_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Falling_Movement_Tick").Value)
                        Timer_Falling.Interval = Falling_Movement_Tick
                    End If
                End If

                ' [Timers_Randomization]
                If INI.Sections("Timers_Randomization") IsNot Nothing Then
                    If INI.Sections("Timers_Randomization").Keys("TurningDecision_Min") IsNot Nothing Then
                        TurningDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("TurningDecision_Max") IsNot Nothing Then
                        TurningDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Max").Value)
                    End If

                    If TurningDecision_Min <> 0 AndAlso TurningDecision_Max <> 0 Then
                        Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)
                    End If


                    If INI.Sections("Timers_Randomization").Keys("IdleDecision_Min") IsNot Nothing Then
                        IdleDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Min").Value)
                    End If
                    If INI.Sections("Timers_Randomization").Keys("IdleDecision_Max") IsNot Nothing Then
                        IdleDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Max").Value)
                    End If
                    If IdleDecision_Min <> 0 AndAlso IdleDecision_Max <> 0 Then
                        Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
                    End If


                    If INI.Sections("Timers_Randomization").Keys("SleepingDecision_Min") IsNot Nothing Then
                        Sleeping_Min = CInt(INI.Sections("Timers_Randomization").Keys("SleepingDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("SleepingDecision_Max") IsNot Nothing Then
                        Sleeping_Max = CInt(INI.Sections("Timers_Randomization").Keys("SleepingDecision_Max").Value)
                    End If

                    If Sleeping_Min <> 0 AndAlso Sleeping_Max <> 0 Then
                        Timer_Sleeping.Interval = Rand.Next(Sleeping_Min, Sleeping_Max + 1)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)
            Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
            Timer_Sleeping.Interval = Rand.Next(Sleeping_Min, Sleeping_Max + 1)
        End If

        ScaleToolStripComboBox.SelectedIndex = CInt(Form_Pets.NumericUpDown_ObjectScale.Value) - 1

        Console.WriteLine("Form_GroundPet is loading, Animations count: " & Animations.Count)
        FormLoadLock = False

    End Sub

    ' Timer tick event to update the PictureBox image with the current frame.
    Public Sub Timer_Animation_Tick(sender As Object, e As EventArgs) Handles Timer_Animation.Tick
        'Console.WriteLine("Timer_Animation.Tick")
        If CurrentAnimation IsNot Nothing Then
            ' Update the PictureBox image based on the current animation's frame.
            PixelBox_Pet.Image = CurrentAnimation.GetCurrentFrameImage(TurnLeft)

            ' Advance to the next frame.
            CurrentAnimation.AdvanceFrame(Timer_Animation)
        Else
            Console.WriteLine("Timer_Animation_Tick: CurrentAnimation is Nothing")
        End If
    End Sub

    ' Method to switch animations. This resets the frame index, updates the Timer interval,
    ' and stops the Timer if the animation contains only one frame.
    Public Sub SetAnimation(name As String)
        Console.WriteLine("SetAnimation: " & name)

        If Animations Is Nothing Then
            Console.WriteLine("ERROR: Animations is Nothing BEFORE setting animation!")
            Exit Sub
        End If
        If Animations.Count = 0 Then
            Console.WriteLine("ERROR: Animations is EMPTY BEFORE setting animation!")
            Exit Sub
        End If

        If Animations.ContainsKey(name) Then
            CurrentAnimation = Animations(name)
            CurrentAnimation.Reset()
            Timer_Animation.Interval = CurrentAnimation.FrameDelay
            Timer_Animation.Start()
            PixelBox_Pet.Image = CurrentAnimation.GetCurrentFrameImage(TurnLeft)
        Else
            Console.WriteLine("ERROR: Animation not found: " & name)
        End If

        ' Check again AFTER setting the animation
        If Animations Is Nothing Then
            Console.WriteLine("ERROR: Animations is Nothing AFTER setting animation!")
        ElseIf Animations.Count = 0 Then
            Console.WriteLine("ERROR: Animations is EMPTY AFTER setting animation!")
        End If
    End Sub

    ' Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick
        If Not ContextMenuStrip1.Visible Then
            If FollowCursor = False Then
                If TurnLeft = True Then
                    If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X - 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If Not CurrentAnimation.Name = "Walking" Then
                            SetAnimation("Walking")
                        End If
                    End If
                Else
                    If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X + 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If Not CurrentAnimation.Name = "Walking" Then
                            SetAnimation("Walking")
                        End If
                    End If
                End If

            Else

                If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then

                    If Me.Location.X > MousePosition.X + FollowCursor_StoppingDistance_Px Then
                        TurnLeft = True
                        Me.Location = New Point(Me.Location.X - 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If Not CurrentAnimation.Name = "Walking" Then
                            SetAnimation("Walking")
                        End If
                    ElseIf Me.Location.X < MousePosition.X - Me.Width - FollowCursor_StoppingDistance_Px Then
                        TurnLeft = False
                        Me.Location = New Point(Me.Location.X + 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If Not CurrentAnimation.Name = "Walking" Then
                            SetAnimation("Walking")
                        End If
                    Else
                        If Not CurrentAnimation.Name = "Idling" Then
                            SetAnimation("Idling")
                        End If
                    End If
                End If

            End If
        End If
    End Sub

    ' Timer_Falling - Tick
    Private Sub Timer_Falling_Tick(sender As Object, e As EventArgs) Handles Timer_Falling.Tick
        If Dragging = False Then
            If Me.Location.Y < MYScreen.WorkingArea.Bottom - Me.Height Then
                If Me.Location.Y + Falling_Movement_Px >= MYScreen.WorkingArea.Bottom - Me.Height Then
                    Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)

                    If HasAnimation_Land Then
                        If Not CurrentAnimation.Name = "Land" Then
                            SetAnimation("Land")
                        End If
                    Else
                        Timer_IdleDecision.Start()
                        Timer_TurningDecision.Start()
                        SetAnimation("Idling")
                    End If

                Else
                    Me.Location = New Point(Me.Location.X, Me.Location.Y + Falling_Movement_Px)

                    If HasAnimation_Falling Then
                        If Not CurrentAnimation.Name = "Falling" Then
                            SetAnimation("Falling")
                        End If
                    Else
                        If Not CurrentAnimation.Name = "Idling" Then
                            SetAnimation("Idling")
                        End If
                    End If

                End If
            End If
        End If
    End Sub

    ' Timer_TurningDecision - Tick
    Private Sub Timer_TurningDecision_Tick(sender As Object, e As EventArgs) Handles Timer_TurningDecision.Tick
        Dim R As Integer = CInt(Rnd(1))
        If R = 0 Then
            TurnLeft = True
        Else
            TurnLeft = False
        End If

        Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)
    End Sub

    ' Timer_IdleDecision - Tick
    Private Sub Timer_IdleDecision_Tick(sender As Object, e As EventArgs) Handles Timer_IdleDecision.Tick
        If Not ContextMenuStrip1.Visible And Not Dragging Then
            If Rand.Next(0, 100 + 1) <= IdleDecision Then
                Timer_Walking.Stop()

                If HasAnimation_Sleeping Then
                    If CurrentAnimation.Name = "Idling" Then
                        If Rand.Next(0, 100 + 1) <= SleepDecision Then
                            If Not CurrentAnimation.Name = "Sleeping" Then
                                SetAnimation("Sleeping")
                                Timer_Sleeping.Enabled = True
                                Timer_IdleDecision.Enabled = False
                                Timer_TurningDecision.Enabled = False
                            End If
                        End If
                    End If
                End If

                If HasAnimation_Pose Then
                    If CurrentAnimation.Name = "Idling" Or CurrentAnimation.Name = "Idling Alt" Then
                        If Rand.Next(0, 100 + 1) <= PoseDecision Then
                            SetAnimation(Poses(Rand.Next(0, Poses.Count)))
                        End If
                    End If
                End If

                If HasAnimation_IdlingAlt Then
                    If Rand.Next(0, 100 + 1) <= IdleAltDecision Then
                        If Not CurrentAnimation.Name = "Idling Alt" AndAlso Not Poses.Contains(CurrentAnimation.Name) Then
                            SetAnimation("Idling Alt")
                        End If
                    Else
                        If Not CurrentAnimation.Name = "Idling" AndAlso Not CurrentAnimation.Name = "Sleeping" AndAlso Not Poses.Contains(CurrentAnimation.Name) Then
                            SetAnimation("Idling")
                        End If
                    End If
                Else
                    If Not CurrentAnimation.Name = "Idling" AndAlso Not CurrentAnimation.Name = "Sleeping" AndAlso Not Poses.Contains(CurrentAnimation.Name) Then
                        SetAnimation("Idling")
                    End If
                End If

            Else
                Timer_Walking.Start()
            End If
        End If
        Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
    End Sub

    ' Screen Warping & Edge Turn Around
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Static lastLocation As Point = Me.Location

        If FormLoadLock = False Then
            If Dragging = False Then
                ' RIGHT & Left
                If Me.Location.X > MYScreen.WorkingArea.Right - Me.Width / 2 Then
                    If Rand.Next(0, 100 + 1) <= ScreenWarpingDecision Then
                        If Not DisplayToolStripComboBox.SelectedItem.ToString = "All" Then
                            Me.Location = New Point(MYScreen.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y) 'WARP
                        Else
                            Dim TempDisplay_LOW As Screen = MYScreen
                            Dim TempDisplay_Right As Screen = MYScreen
                            Dim HasScreenOnRight As Boolean = False
                            Dim location As Double = Me.Location.X + Me.Width / 2

                            ' SET TO SCREEN WITH LOWEST X
                            For Each Displays As Display In Display.GetDisplays()
                                If Not Displays.GetScreen.Bounds = MYScreen.Bounds Then
                                    If location >= Displays.GetScreen.Bounds.Left And location <= Displays.GetScreen.Bounds.Right Then
                                        TempDisplay_Right = Displays.GetScreen
                                        HasScreenOnRight = True
                                    End If
                                End If

                                If Displays.GetScreen.Bounds.X < MYScreen.Bounds.X Then
                                    TempDisplay_LOW = Displays.GetScreen
                                End If
                            Next

                            If HasScreenOnRight Then
                                MYScreen = TempDisplay_Right
                                Me.Location = New Point(MYScreen.WorkingArea.Left - CInt(Me.Width / 2), MYScreen.WorkingArea.Bottom - Me.Height) ' Travel
                                Console.WriteLine("HasScreenOnRight")
                                Console.WriteLine("Travel")
                            Else
                                MYScreen = TempDisplay_LOW
                                Me.Location = New Point(MYScreen.WorkingArea.Left - CInt(Me.Width / 2), MYScreen.WorkingArea.Bottom - Me.Height) ' WARP
                                Console.WriteLine("NOScreenOnRight")
                                Console.WriteLine("WARP")
                            End If
                        End If
                    Else
                        TurnLeft = True ' TURNAROUND
                    End If
                    Console.WriteLine("OVER RIGHT")
                ElseIf Me.Location.X < MYScreen.WorkingArea.Left - Me.Width / 2 Then ' LEFT
                    If Rand.Next(0, 100 + 1) <= ScreenWarpingDecision Then
                        If Not DisplayToolStripComboBox.SelectedItem.ToString = "All" Then
                            Me.Location = New Point(MYScreen.WorkingArea.Right - CInt(Me.Width / 2), Me.Location.Y) ' WARP
                        Else
                            Dim TempDisplay_HIGH As Screen = MYScreen
                            Dim TempDisplay_Left As Screen = MYScreen
                            Dim HasScreenOnLeft As Boolean = False
                            Dim location As Double = Me.Location.X + Me.Width / 2

                            ' SET TO SCREEN WITH HIGHEST X
                            For Each Displays As Display In Display.GetDisplays()
                                If Not Displays.GetScreen.Bounds = MYScreen.Bounds Then
                                    If location >= Displays.GetScreen.Bounds.Left And location <= Displays.GetScreen.Bounds.Right Then
                                        TempDisplay_Left = Displays.GetScreen
                                        HasScreenOnLeft = True
                                    End If
                                End If

                                If Displays.GetScreen.Bounds.X > MYScreen.Bounds.X Then
                                    TempDisplay_HIGH = Displays.GetScreen
                                End If
                            Next

                            If HasScreenOnLeft Then
                                MYScreen = TempDisplay_Left
                                Me.Location = New Point(MYScreen.WorkingArea.Right - CInt(Me.Width / 2), MYScreen.WorkingArea.Bottom - Me.Height) ' Travel
                                Console.WriteLine("HasScreenOnLeft")
                                Console.WriteLine("Travel")
                            Else
                                MYScreen = TempDisplay_HIGH
                                Me.Location = New Point(MYScreen.WorkingArea.Right - CInt(Me.Width / 2), MYScreen.WorkingArea.Bottom - Me.Height) ' WARP
                                Console.WriteLine("NOScreenOnLeft")
                                Console.WriteLine("WARP")
                            End If
                        End If
                    Else
                        TurnLeft = False ' TURNAROUND
                    End If
                    Console.WriteLine("OVER LEFT")
                End If
            Else
                ' Dragging Right
                If Me.Location.X > lastLocation.X Then
                    TurnLeft = False
                    'Console.WriteLine("Dragging Right")
                End If

                ' Dragging Left
                If Me.Location.X < lastLocation.X Then
                    TurnLeft = True
                    'Console.WriteLine("Dragging Left")
                End If

                If HasAnimation_Dragging = True Then
                    If Not CurrentAnimation.Name = "Dragging" Then
                        SetAnimation("Dragging")
                    End If
                Else
                    If Not CurrentAnimation.Name = "Idling" Then
                        SetAnimation("Idling")
                    End If
                End If
            End If
        End If

        lastLocation = Me.Location
    End Sub

    ' ScalePet()
    Public Sub ScalePet(val As Integer)
        val = val + DefaultScale - 1
        Me.Width = CurrentAnimation.Width * val
        Me.Height = CurrentAnimation.Height * val
        Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
    End Sub

    ' PixelBox_Pet - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox_Pet.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dragging = True

            Timer_Walking.Stop()
            Timer_IdleDecision.Stop()
            Timer_TurningDecision.Stop()
            Timer_Sleeping.Stop()

            PixelBox_Pet.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)

            BlockEvent_DisplayComboBox = True
            For Each Displays As Display In Display.GetDisplays()
                If Me.Location.X >= Displays.GetScreen.Bounds.Left And Me.Location.X <= Displays.GetScreen.Bounds.Right Then
                    MYScreen = Displays.GetScreen
                    Console.WriteLine("PixelBox_Pet - MouseDown, MYScreen = Displays.GetScreen")

                    If Not DisplayToolStripComboBox.Text = "All" Then
                        If Displays.IsGDIPrimary Then
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName & " (Primary)"
                        Else
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName
                        End If
                    End If

                End If

            Next
            BlockEvent_DisplayComboBox = False

            'OVER DOWN
            If Me.Location.Y > MYScreen.WorkingArea.Height - Me.Height Then
                Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)

                If HasAnimation_Land Then
                    If Not CurrentAnimation.Name = "Land" Then
                        SetAnimation("Land")
                    End If
                Else
                    Timer_IdleDecision.Start()
                    Timer_TurningDecision.Start()
                    If Not CurrentAnimation.Name = "Idling" Then
                        SetAnimation("Idling")
                    End If
                End If

                    Console.WriteLine("OVER DOWN")
            End If

            If Timer_Sleeping.Enabled = True Then
                Timer_Sleeping.Enabled = False
                Timer_Sleeping.Interval = Rand.Next(Sleeping_Min, Sleeping_Max + 1)
                Timer_IdleDecision.Enabled = True
            End If

            Dragging = False
        End If
    End Sub

    ' FollowCursorToolStripMenuItem - CheckedChanged
    Private Sub FollowCursorToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles FollowCursorToolStripMenuItem.CheckedChanged
        FollowCursor = FollowCursorToolStripMenuItem.Checked
        If FollowCursorToolStripMenuItem.Checked Then
            Timer_TurningDecision.Enabled = False
            Timer_IdleDecision.Enabled = False
            Timer_Walking.Enabled = True
        Else
            Timer_TurningDecision.Enabled = True
            Timer_IdleDecision.Enabled = True
            'Timer_Walking.Enabled = False
        End If
    End Sub

    ' CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' ScaleToolStripComboBox - SelectedIndexChanged
    Private Sub ScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScaleToolStripComboBox.SelectedIndexChanged
        If Not ScaleToolStripComboBox.SelectedIndex = -1 Then
            ScalePet(ScaleToolStripComboBox.SelectedIndex + 1)
        End If
    End Sub

    ' AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub

    ' ContextMenuStrip1 - Opened
    Private Sub ContextMenuStrip1_Opened(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Opened
        If Not CurrentAnimation.Name = "Idling" Then
            SetAnimation("Idling")
        End If
        'Timer_Walking.Start()
        'Timer_Walking.Stop()
        'Timer_Falling.Stop()
        'Timer_IdleDecision.Stop()
        'Timer_TurningDecision.Stop()
        'Timer_Sleeping.Stop()
    End Sub

    ' DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 And Not DisplayToolStripComboBox.SelectedItem.ToString = "All" Then
                MYScreen = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex).GetScreen
                Me.Location = New Point(Rand.Next(MYScreen.WorkingArea.Left, MYScreen.WorkingArea.Right - Me.Width), MYScreen.WorkingArea.Bottom - Me.Height)
                'Console.WriteLine("DisplayToolStripComboBox - SelectedIndexChanged")
            End If
        End If
    End Sub

    ' Timer_Sleeping - Tick
    Private Sub Timer_Sleeping_Tick(sender As Object, e As EventArgs) Handles Timer_Sleeping.Tick
        Timer_IdleDecision.Enabled = True
        Timer_TurningDecision.Enabled = True
        Timer_Sleeping.Enabled = False
        Timer_Sleeping.Interval = Rand.Next(Sleeping_Min, Sleeping_Max + 1)
    End Sub

    ' DisplaySettingsChanged
    Public Sub DisplaySettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim OldSelectedIndex As Integer = 0
        If Not DisplayToolStripComboBox.SelectedIndex = -1 Then
            OldSelectedIndex = DisplayToolStripComboBox.SelectedIndex
        End If

        If Not DisplayToolStripComboBox.Items.Count = Screen.AllScreens.Count Then ' Fix this because of All item!
            DisplayToolStripComboBox.Items.Clear()
            DisplayToolStripComboBox.BeginUpdate()

            If DisplayToolStripComboBox.Items.Count >= 2 Then
                DisplayToolStripComboBox.Items.Add("All")
            End If
            DisplayToolStripComboBox.EndUpdate()

            If DisplayToolStripComboBox.Items.Count > 0 Then
                If DisplayToolStripComboBox.Items.Count >= OldSelectedIndex Then
                    DisplayToolStripComboBox.SelectedIndex = OldSelectedIndex
                    MYScreen = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex).GetScreen
                    Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
                Else
                    DisplayToolStripComboBox.SelectedIndex = 0
                    MYScreen = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex).GetScreen
                    Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
                End If
            End If
        Else
            MYScreen = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex).GetScreen
            Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
        End If
    End Sub

    ' BehaviorToolStripMenuItem - Click
    Private Sub BehaviorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BehaviorToolStripMenuItem.Click
        ' Check if the form is already open
        If BehaviorForm IsNot Nothing AndAlso Not BehaviorForm.IsDisposed Then
            ' Bring the existing form to the front
            BehaviorForm.BringToFront()
        Else
            ' Create a new instance if the form is not open or was closed
            BehaviorForm = New Form_Behavior

            BehaviorForm.PetType = "Ground"
            BehaviorForm.PetDir = PetDir

            BehaviorForm.Text = "Behavior - " & Path.GetFileName(PetDir)

            BehaviorForm.Label_PetName.Text = Path.GetFileName(PetDir)
            BehaviorForm.PixelBox_PetPreview.Image = Image.FromFile(PetDir & "\Idling.gif") ' Replace this

            BehaviorForm.Label_TakeFlightDecision.Enabled = False
            BehaviorForm.NumericUpDown_TakeFlightDecision.Enabled = False

            BehaviorForm.Label_TakeFlightDecision2.Enabled = False
            BehaviorForm.NumericUpDown_TakeFlightDecision_Min.Enabled = False
            BehaviorForm.NumericUpDown_TakeFlightDecision_Max.Enabled = False

            BehaviorForm.Label_FlyingMovement_Tick.Enabled = False
            BehaviorForm.NumericUpDown_FlyingMovement_Tick.Enabled = False

            BehaviorForm.Label_LandingDecision.Enabled = False
            BehaviorForm.NumericUpDown_LandingDecision.Enabled = False

            ' Show the form
            BehaviorForm.Show()
        End If
    End Sub

    ' AnimationFinished
    Public Sub AnimationFinished(bla As Form_GroundPet)

        ' Prevent running if Animations is missing
        'If Animations Is Nothing Then
        'Console.WriteLine("ERROR: Animations disappeared!")
        'Exit Sub
        'End If
        ' Prevent running if CurrentAnimation is missing
        'If CurrentAnimation Is Nothing Then
        'Console.WriteLine("ERROR: CurrentAnimation is Nothing!")
        'Exit Sub
        'End If

        ' If Land animation finishes, transition back to Idling
        'If CurrentAnimation.Name = "Land" AndAlso Animations.ContainsKey("Idling") Then
        'bla.Timer_Walking.Start()
        bla.Timer_IdleDecision.Start()
        bla.Timer_TurningDecision.Start()
        bla.SetAnimation("Idling")

        'Else
        'Console.WriteLine("ERROR: 'Idling' animation is missing or Animations is gone!")
        'End If
    End Sub
End Class

' This class encapsulates an animation. It loads a GIF, extracts its frames,
' creates pre-flipped copies, and exposes methods for retrieving the current frame image,
' advancing the frame, and resetting the animation.
Public Class AnimationSystem
    Public Property Frames As List(Of Image)
    Public Property FlippedFrames As List(Of Image)
    Public Property FrameDelay As Integer = 10
    Public Property FrameCount As Integer
    Public Property CurrentFrame As Integer = 0
    Public Property Looped As Boolean
    Public Property Width As Integer = 0
    Public Property Height As Integer = 0
    Public Property Name As String = ""
    Public Property MyForm As Form_GroundPet

    ' Constructor that loads a GIF file and extracts its frames.
    Public Sub New(gifPath As String, gifName As String, loopAnimation As Boolean, bla As Form_GroundPet, Optional ByVal customFrameDelay As Integer = 0)
        Dim gifImage As Image = Image.FromFile(gifPath)
        Dim dimension As New FrameDimension(gifImage.FrameDimensionsList(0))
        FrameCount = gifImage.GetFrameCount(dimension)
        Me.Looped = loopAnimation

        Width = gifImage.Width
        Height = gifImage.Height
        Name = gifName
        MyForm = bla
        Frames = New List(Of Image)()
        FlippedFrames = New List(Of Image)()

        Dim frameDelays As New List(Of Integer)()

        ' Retrieve and process frame delay
        If Path.GetExtension(gifPath).ToLower() = ".gif" Then
            Dim propItem As PropertyItem = gifImage.GetPropertyItem(&H5100)
            Dim delays As Byte() = propItem.Value

            ' Extract each frame delay (stored as 4-byte integers)
            For i As Integer = 0 To FrameCount - 1
                Dim delay As Integer = BitConverter.ToInt32(delays, i * 4) * 10 ' Convert to milliseconds
                If delay <= 0 Then delay = 10 ' Prevent zero delays
                frameDelays.Add(delay)
            Next

            ' Determine if all delays are the same
            If frameDelays.All(Function(d) d = frameDelays(0)) Then
                FrameDelay = frameDelays(0) ' Use the first frame's delay
            Else
                ' Compute the average and round to the nearest 10
                Dim avgDelay As Integer = CInt(Math.Round(frameDelays.Average() / 10) * 10)
                FrameDelay = Math.Max(avgDelay, 10) ' Ensure a minimum of 10ms
            End If
        End If

        ' Override with custom delay if specified
        If customFrameDelay > 0 Then
            FrameDelay = customFrameDelay
        End If

        ' Extract frames and store flipped versions
        For i As Integer = 0 To FrameCount - 1
            gifImage.SelectActiveFrame(dimension, i)
            Dim frame As New Bitmap(gifImage.Width, gifImage.Height)
            Using g As Graphics = Graphics.FromImage(frame)
                g.DrawImage(gifImage, Point.Empty)
            End Using
            Frames.Add(frame)

            ' Create flipped version
            Dim flippedFrame As Image = DirectCast(frame.Clone(), Image)
            flippedFrame.RotateFlip(RotateFlipType.RotateNoneFlipX)
            FlippedFrames.Add(flippedFrame)
        Next

        gifImage.Dispose()
    End Sub

    ' Returns the current frame image. If flip is true, returns the flipped version.
    Public Function GetCurrentFrameImage(flip As Boolean) As Image
        If flip Then
            Return FlippedFrames(CurrentFrame)
        Else
            Return Frames(CurrentFrame)
        End If
    End Function

    ' Advance the frame counter, wrapping around to the first frame when necessary.
    Public Sub AdvanceFrame(bla As Timer)
        If Looped Then
            ' Loop back to the first frame
            CurrentFrame = (CurrentFrame + 1) Mod FrameCount
        Else
            ' Advance frame without looping
            If CurrentFrame < FrameCount - 1 Then
                CurrentFrame += 1
            Else
                bla.Stop()
                Form_GroundPet.AnimationFinished(MyForm)
            End If
        End If
    End Sub

    ' Reset the animation to the first frame.
    Public Sub Reset()
        CurrentFrame = 0
    End Sub
End Class