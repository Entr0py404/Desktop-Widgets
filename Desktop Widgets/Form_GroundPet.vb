﻿
Public Class Form_GroundPet
    Dim Rand As New Random
    Dim Dragging As Boolean = False
    Dim FormLoadLock As Boolean = True
    Dim MYScreen As Screen
    Dim BlockEvent_DisplayComboBox As Boolean = False

    Public TurnLeft As Boolean = True
    Public FollowCursor As Boolean = False
    Public PetDir As String

    Public Animation_Dragging As Image
    Public HasAnimation_Dragging As Boolean = False
    Public Animation_Dragging_Left As Bitmap
    Public Animation_Dragging_Right As Bitmap
    Public Animation_Falling_Left As Bitmap
    Public Animation_Falling_Right As Bitmap
    Public Animation_Walking_Left As Image
    Public Animation_Walking_Right As Image
    Public Animation_Idling_Left As Image
    Public Animation_Idling_Right As Image
    Public Animation_IdlingAlt_Left As Bitmap
    Public Animation_IdlingAlt_Right As Bitmap
    Public HasAnimation_IdlingAlt As Boolean = False
    Public Animation_Action_Left As Bitmap
    Public Animation_Action_Right As Bitmap
    Public Animation_ActionAlt_Left As Bitmap
    Public Animation_ActionAlt_Right As Bitmap
    Public Animation_Sleeping_Left As Bitmap
    Public Animation_Sleeping_Right As Bitmap
    Public Animation_Jumping_Left As Bitmap
    Public Animation_Jumping_Right As Bitmap

    ' Behavior settings
    Dim DefaultScale As Integer = 1
    Dim FollowCursor_StoppingDistance_Px As Integer = 6
    Dim Falling_Movement_Px As Integer = 5

    Dim IdleDecision As Integer = 45
    Dim IdleAltDecision As Integer = 35
    Dim ScreenWarpingDecision As Integer = 60

    Dim Walking_Movement_Tick As Integer = 1
    Dim Falling_Movement_Tick As Integer = 1
    Dim TurningDecision_Min As Integer = 2500
    Dim TurningDecision_Max As Integer = 3500
    Dim IdleDecision_Min As Integer = 2500
    Dim IdleDecision_Max As Integer = 3500

    Dim SleepDecision As Integer = 5
    Dim Sleeping_Min As Integer = 90000
    Dim Sleeping_Max As Integer = 150000
    Dim HasAnimation_Sleeping As Boolean = False

    Private BehaviorForm As Form_Behavior = Nothing

    ' Form_GroundPet - Load
    Private Sub Form_GroundPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Walking
        If File.Exists(PetDir & "\Walking Left.gif") Then
            Animation_Walking_Left = New Bitmap(PetDir & "\Walking Left.gif")
        End If
        If File.Exists(PetDir & "\Walking Right.gif") Then
            Animation_Walking_Right = New Bitmap(PetDir & "\Walking Right.gif")
        End If

        ' Idling
        If File.Exists(PetDir & "\Idling Left.gif") Then
            Animation_Idling_Left = Image.FromFile(PetDir & "\Idling Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Right.gif") Then
            Animation_Idling_Right = Image.FromFile(PetDir & "\Idling Right.gif")
            PixelBox_Pet.Image = Animation_Idling_Right
        End If

        ' Idling Alt
        If File.Exists(PetDir & "\Idling Alt Left.gif") Then
            Animation_IdlingAlt_Left = New Bitmap(PetDir & "\Idling Alt Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Alt Right.gif") Then
            Animation_IdlingAlt_Right = New Bitmap(PetDir & "\Idling Alt Right.gif")
            HasAnimation_IdlingAlt = True
        End If

        ' Sleeping
        If File.Exists(PetDir & "\Sleeping Left.gif") Then
            Animation_Sleeping_Left = New Bitmap(PetDir & "\Sleeping Left.gif")
        End If
        If File.Exists(PetDir & "\Sleeping Right.gif") Then
            Animation_Sleeping_Right = New Bitmap(PetDir & "\Sleeping Right.gif")
            HasAnimation_Sleeping = True
        End If

        ' Dragging
        If File.Exists(PetDir & "\Dragging.gif") Then
            Animation_Dragging = New Bitmap(PetDir & "\Dragging.gif")
            HasAnimation_Dragging = True
        End If
        If File.Exists(PetDir & "\Dragging Left.gif") Then
            Animation_Dragging_Left = New Bitmap(PetDir & "\Dragging Left.gif")
        Else
            Animation_Dragging_Left = New Bitmap(PetDir & "\Idling Left.gif")
        End If
        If File.Exists(PetDir & "\Dragging Right.gif") Then
            Animation_Dragging_Right = New Bitmap(PetDir & "\Dragging Right.gif")
        Else
            Animation_Dragging_Right = New Bitmap(PetDir & "\Idling Right.gif")
        End If

        ' Falling
        If File.Exists(PetDir & "\Falling Left.gif") Then
            Animation_Falling_Left = New Bitmap(PetDir & "\Falling Left.gif")
        Else
            Animation_Falling_Left = New Bitmap(PetDir & "\Idling Left.gif")
        End If
        If File.Exists(PetDir & "\Falling Right.gif") Then
            Animation_Falling_Right = New Bitmap(PetDir & "\Falling Right.gif")
        Else
            Animation_Falling_Right = New Bitmap(PetDir & "\Idling Right.gif")
        End If

        Me.Text = "Pet - " & Path.GetFileName(PetDir)

        Dim R As Integer = CInt(Rnd(1))
        If R = 0 Then
            TurnLeft = True
        Else
            TurnLeft = False
        End If

        DisplayToolStripComboBox.BeginUpdate()
        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                DisplayToolStripComboBox.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                DisplayToolStripComboBox.SelectedIndex = DisplayToolStripComboBox.Items.Count - 1
            Else
                DisplayToolStripComboBox.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next

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

        FormLoadLock = False

        'Console.WriteLine("Form_GroundPet_Load")
    End Sub

    ' Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick

        If Not ContextMenuStrip1.Visible Then
            If FollowCursor = False Then
                If TurnLeft = True Then
                    If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X - 1, MYScreen.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            'Console.WriteLine("Animation_Walking_Left")
                        End If

                    End If
                Else
                    If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X + 1, MYScreen.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            'Console.WriteLine("Animation_Walking_Right")
                        End If

                    End If
                End If
            Else

                If Me.Location.Y = MYScreen.WorkingArea.Bottom - Me.Height Then
                    If Me.Location.X > MousePosition.X + FollowCursor_StoppingDistance_Px Then
                        TurnLeft = False
                        Me.Location = New Point(Me.Location.X - 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            'Console.WriteLine("Animation_Walking_Left")
                        End If
                    ElseIf Me.Location.X < MousePosition.X - Me.Width - FollowCursor_StoppingDistance_Px Then
                        TurnLeft = True
                        Me.Location = New Point(Me.Location.X + 1, MYScreen.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            'Console.WriteLine("Animation_Walking_Right")
                        End If
                    Else

                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Or PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            If TurnLeft = True Then
                                PixelBox_Pet.Image = Animation_Idling_Left
                                'Console.WriteLine("Animation_Idling_Left")
                            Else
                                PixelBox_Pet.Image = Animation_Idling_Right
                                'Console.WriteLine("Animation_Idling_Right")
                            End If
                        End If
                    End If

                End If
            End If
        End If
    End Sub

    ' Timer_Falling - Tick
    Private Sub Timer_Falling_Tick(sender As Object, e As EventArgs) Handles Timer_Falling.Tick
        'Dim Display_Test As Screen
        If Dragging = False Then
            If Me.Location.Y < MYScreen.WorkingArea.Bottom - Me.Height Then
                If Me.Location.Y + Falling_Movement_Px >= MYScreen.WorkingArea.Bottom - Me.Height Then
                    Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)

                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                            PixelBox_Pet.Image = Animation_Idling_Left
                            'Console.WriteLine("Animation_Idling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            PixelBox_Pet.Image = Animation_Idling_Right
                            'Console.WriteLine("Animation_Idling_Right")
                        End If
                    End If
                Else
                    Me.Location = New Point(Me.Location.X, Me.Location.Y + Falling_Movement_Px)
                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Falling_Left Then
                            PixelBox_Pet.Image = Animation_Falling_Left
                            'Console.WriteLine("Animation_Falling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Falling_Right Then
                            PixelBox_Pet.Image = Animation_Falling_Right
                            'Console.WriteLine("Animation_Falling_Right")
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

                If HasAnimation_IdlingAlt Then
                    If Rand.Next(0, 100 + 1) <= IdleAltDecision Then
                        If TurnLeft = True Then
                            If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                                PixelBox_Pet.Image = Animation_Idling_Left
                                'Console.WriteLine("Animation_Idling_Left")
                            End If
                        Else
                            If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                                PixelBox_Pet.Image = Animation_Idling_Right
                                'Console.WriteLine("Animation_Idling_Right")
                            End If
                        End If
                    Else
                        If TurnLeft = True Then
                            If PixelBox_Pet.Image IsNot Animation_IdlingAlt_Left Then
                                PixelBox_Pet.Image = Animation_IdlingAlt_Left
                                'Console.WriteLine("Animation_IdlingAlt_Left")
                            End If
                        Else
                            If PixelBox_Pet.Image IsNot Animation_IdlingAlt_Right Then
                                PixelBox_Pet.Image = Animation_IdlingAlt_Right
                                'Console.WriteLine("Animation_IdlingAlt_Right")
                            End If
                        End If
                    End If
                Else
                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                            PixelBox_Pet.Image = Animation_Idling_Left
                            'Console.WriteLine("Animation_Idling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            PixelBox_Pet.Image = Animation_Idling_Right
                            'Console.WriteLine("Animation_Idling_Right")
                        End If
                    End If
                End If


                ' Console.WriteLine(Rand.Next(0, 100 + 1))

                If HasAnimation_Sleeping Then
                    If Rand.Next(0, 100 + 1) <= SleepDecision Then
                        If TurnLeft = True Then
                            If PixelBox_Pet.Image IsNot Animation_Sleeping_Left Then
                                PixelBox_Pet.Image = Animation_Sleeping_Left
                                'Console.WriteLine("Animation_Sleeping_Left")
                            End If
                        Else
                            If PixelBox_Pet.Image IsNot Animation_Sleeping_Right Then
                                PixelBox_Pet.Image = Animation_Sleeping_Right
                                'Console.WriteLine("Animation_Sleeping_Right")
                            End If
                        End If
                        Timer_Sleeping.Enabled = True
                        Timer_IdleDecision.Enabled = False
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
                If HasAnimation_Dragging = True Then
                    If PixelBox_Pet.Image IsNot Animation_Dragging Then
                        PixelBox_Pet.Image = Animation_Dragging
                    End If
                Else
                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Dragging_Left Then
                            PixelBox_Pet.Image = Animation_Dragging_Left
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Dragging_Right Then
                            PixelBox_Pet.Image = Animation_Dragging_Right
                        End If
                    End If
                End If

            End If

        End If
    End Sub

    ' ScalePet()
    Public Sub ScalePet(val As Integer)
        val = val + DefaultScale - 1
        Me.Width = Animation_Walking_Left.Width * val
        Me.Height = Animation_Walking_Left.Height * val
        Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
    End Sub

    ' PixelBox_Pet - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox_Pet.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dragging = True
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
        If TurnLeft = True Then
            If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                PixelBox_Pet.Image = Animation_Idling_Left
                'Console.WriteLine("Animation_Idling_Left")
            End If
        Else
            If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                PixelBox_Pet.Image = Animation_Idling_Right
                'Console.WriteLine("Animation_Idling_Right")
            End If
        End If
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
            BehaviorForm.PixelBox_PetPreview.Image = Animation_Idling_Right

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
End Class