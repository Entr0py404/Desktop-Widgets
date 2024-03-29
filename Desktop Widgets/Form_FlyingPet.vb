﻿
Public Class Form_FlyingPet
    Dim R As Integer = 0
    Dim Display As Screen = Screen.PrimaryScreen
    Dim BlockEvent_DisplayComboBox As Boolean = False
    Dim Rand As New Random
    Dim FormLoadLock As Boolean = True
    Dim MoveLeft As Boolean = True
    Dim MoveUp As Boolean = True
    Dim Dragging As Boolean = False
    Dim Flying_Mode As Boolean = True
    Dim Ground_Mode As Boolean = False

    Public FollowCursor As Boolean = False
    Public HasAnimation_Idling As Boolean = False
    Public HasAnimation_IdlingAlt As Boolean = False
    Public HasAnimation_Walking As Boolean = False
    Public PetDir As String

    Public Animation_Dragging As Image
    Public Animation_Dragging_Left As Image
    Public Animation_Dragging_Right As Image
    Public HasAnimation_Dragging As Boolean = False

    Public Animation_Falling As Image
    Public Animation_Flying_Left As Image
    Public Animation_Flying_Right As Image
    Public Animation_Walking_Left As Image
    Public Animation_Walking_Right As Image
    Public Animation_Idling_Left As Image
    Public Animation_Idling_Right As Image
    Public Animation_IdlingAlt_Left As Image
    Public Animation_IdlingAlt_Right As Image

    'Behavior settings
    Dim DefaultScale As Integer = 1
    Dim FollowCursor_StoppingDistance_Px As Integer = 6

    Dim IdleDecision As Integer = 45
    Dim IdleAltDecision As Integer = 35
    Dim TakeFlightDecision As Integer = 60
    Dim ScreenWarpingDecision As Integer = 60
    Dim LandingDecision As Integer = 45

    Dim Flying_Movement_Tick As Integer = 1
    Dim Walking_Movement_Tick As Integer = 1

    Dim TurningDecision_Min As Integer = 2500
    Dim TurningDecision_Max As Integer = 3500
    Dim IdleDecision_Min As Integer = 2500
    Dim IdleDecision_Max As Integer = 3500
    Dim TakeFlightDecision_Min As Integer = 3500
    Dim TakeFlightDecision_Max As Integer = 5000

    ' Form_FlyingPet_Load
    Private Sub Form_FlyingPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(PetDir & "\Flying Left.gif") Then
            Animation_Flying_Left = Image.FromFile(PetDir & "\Flying Left.gif")
            PixelBox_Pet.Image = Animation_Flying_Left
        End If
        If File.Exists(PetDir & "\Flying Right.gif") Then
            Animation_Flying_Right = Image.FromFile(PetDir & "\Flying Right.gif")
        End If

        'Walking
        If File.Exists(PetDir & "\Walking Left.gif") Then
            Animation_Walking_Left = Image.FromFile(PetDir & "\Walking Left.gif")
        End If
        If File.Exists(PetDir & "\Walking Right.gif") Then
            Animation_Walking_Right = Image.FromFile(PetDir & "\Walking Right.gif")
            HasAnimation_Walking = True
        End If

        'Idling
        If File.Exists(PetDir & "\Idling Left.gif") Then
            Animation_Idling_Left = Image.FromFile(PetDir & "\Idling Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Right.gif") Then
            Animation_Idling_Right = Image.FromFile(PetDir & "\Idling Right.gif")
            HasAnimation_Idling = True
        End If

        'Idling Alt
        If File.Exists(PetDir & "\Idling Alt Left.gif") Then
            Animation_IdlingAlt_Left = Image.FromFile(PetDir & "\Idling Alt Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Alt Right.gif") Then
            Animation_IdlingAlt_Right = Image.FromFile(PetDir & "\Idling Alt Right.gif")
            HasAnimation_IdlingAlt = True
        End If

        'Dragging
        If File.Exists(PetDir & "\Dragging.gif") Then
            Animation_Dragging = Image.FromFile(PetDir & "\Dragging.gif")
            HasAnimation_Dragging = True
        Else
            HasAnimation_Dragging = False
        End If

        'Dragging Left
        If File.Exists(PetDir & "\Dragging Left.gif") Then
            Animation_Dragging_Left = Image.FromFile(PetDir & "\Dragging Left.gif")
        ElseIf File.Exists(PetDir & "\Idling Left.gif") Then
            Animation_Dragging_Left = Image.FromFile(PetDir & "\Idling Left.gif")
        ElseIf File.Exists(PetDir & "\Flying Left.gif") Then
            Animation_Dragging_Left = Image.FromFile(PetDir & "\Flying Left.gif")
        End If

        'Dragging Right
        If File.Exists(PetDir & "\Dragging Right.gif") Then
            Animation_Dragging_Right = Image.FromFile(PetDir & "\Dragging Right.gif")
        ElseIf File.Exists(PetDir & "\Idling Right.gif") Then
            Animation_Dragging_Right = Image.FromFile(PetDir & "\Idling Right.gif")
        ElseIf File.Exists(PetDir & "\Flying Right.gif") Then
            Animation_Dragging_Right = Image.FromFile(PetDir & "\Flying Right.gif")
        End If

        Me.Text = "Pet - " & Path.GetFileName(PetDir)

        Dim R As Integer = CInt(Rnd(1))
        If R = 0 Then
            MoveLeft = True
        Else
            MoveLeft = False
        End If
        R = CInt(Rnd(1))
        If R = 0 Then
            MoveUp = True
        Else
            MoveUp = False
        End If

        'Me.Width = PixelBox_Pet.Width
        'Me.Height = PixelBox_Pet.Height + PixelBox_Emote.Height
        DisplayToolStripComboBox.BeginUpdate()
        For Each Display In Screen.AllScreens
            DisplayToolStripComboBox.Items.Add(Display.DeviceName.Replace("\\.\", ""))
        Next

        If DisplayToolStripComboBox.Items.Count >= 2 Then
            DisplayToolStripComboBox.Items.Add("ALL")
        End If

        DisplayToolStripComboBox.EndUpdate()
        DisplayToolStripComboBox.SelectedIndex = Form_Pets.ComboBox_Display.SelectedIndex

        FollowCursorToolStripMenuItem.Checked = Form_Pets.CheckBox_FollowCursor.Checked
        Me.TopMost = Form_Pets.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Pets.CheckBox_TopMost.Checked

        ScaleToolStripComboBox.SelectedIndex = CInt(Form_Pets.NumericUpDown_ObjectScale.Value) - 1

        'Me.Location = New Point(GenerateRandomNumber(Me.Width, Display.WorkingArea.Right - Me.Width), GenerateRandomNumber(Me.Height, Display.WorkingArea.Bottom - Me.Height))

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        AddHandler Microsoft.Win32.SystemEvents.DisplaySettingsChanged, AddressOf DisplaySettingsChanged

        If File.Exists(Application.StartupPath & "\" & PetDir & "\Behavior.ini") Then
            Dim INI As New MadMilkman.Ini.IniFile()
            INI.Load(Application.StartupPath & "\" & PetDir & "\Behavior.ini")
            '[Settings]
            DefaultScale = CInt(INI.Sections("Settings").Keys("DefaultScale").Value)

            If DefaultScale <= 0 Then
                DefaultScale = 1
            End If
            If DefaultScale > 1 Then
                ScalePet(1)
            End If

            FollowCursor_StoppingDistance_Px = CInt(INI.Sections("Settings").Keys("FollowCursor_StoppingDistance_Px").Value)

            '[Decisions]
            IdleDecision = CInt(INI.Sections("Decisions").Keys("IdleDecision").Value)
            IdleAltDecision = CInt(INI.Sections("Decisions").Keys("IdleAltDecision").Value)
            TakeFlightDecision = CInt(INI.Sections("Decisions").Keys("TakeFlightDecision").Value)

            ScreenWarpingDecision = CInt(INI.Sections("Decisions").Keys("ScreenWarpingDecision").Value)
            LandingDecision = CInt(INI.Sections("Decisions").Keys("LandingDecision").Value)

            '[Timers_Tick]
            Flying_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Flying_Movement_Tick").Value)
            Timer_Flying.Interval = Flying_Movement_Tick

            Walking_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick").Value)
            Timer_Walking.Interval = Walking_Movement_Tick

            '[Timers_Randomization]
            TurningDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Min").Value)
            TurningDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Max").Value)
            Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)

            IdleDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Min").Value)
            IdleDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Max").Value)
            Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)

            TakeFlightDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Min").Value)
            TakeFlightDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Max").Value)
            Timer_ChangeModesDecision.Interval = Rand.Next(TakeFlightDecision_Min, TakeFlightDecision_Max + 1)
        Else
            Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)
            Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
            Timer_ChangeModesDecision.Interval = Rand.Next(TakeFlightDecision_Min, TakeFlightDecision_Max + 1)
        End If

        FormLoadLock = False
    End Sub

    ' Timer_Flying - Tick
    Private Sub Timer_Flying_Tick(sender As Object, e As EventArgs) Handles Timer_Flying.Tick
        If Not ContextMenuStrip1.Visible Then
            If Dragging = False Then
                If FollowCursor = False Then
                    If MoveLeft = True Then

                        Me.Location = New Point(Me.Location.X - 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Left Then
                            PixelBox_Pet.Image = Animation_Flying_Left
                            'Console.WriteLine("Animation_Flying_Left")
                        End If
                    Else
                        Me.Location = New Point(Me.Location.X + 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Right Then
                            PixelBox_Pet.Image = Animation_Flying_Right
                            'Console.WriteLine("Animation_Flying_Right")
                        End If
                    End If

                    If MoveUp = True Then
                        Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)
                    Else
                        Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
                    End If

                Else
                    '
                    If Me.Location.X > MousePosition.X + FollowCursor_StoppingDistance_Px Then
                        MoveLeft = True
                        Me.Location = New Point(Me.Location.X - 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Left Then
                            PixelBox_Pet.Image = Animation_Flying_Left
                            'Console.WriteLine("Animation_Flying_Left")
                        End If
                    End If
                    '
                    If Me.Location.X < MousePosition.X - Me.Width - FollowCursor_StoppingDistance_Px Then
                        MoveLeft = False
                        Me.Location = New Point(Me.Location.X + 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Right Then
                            PixelBox_Pet.Image = Animation_Flying_Right
                            'Console.WriteLine("Animation_Flying_Right")
                        End If
                    End If
                    '
                    If Me.Location.Y > MousePosition.Y + FollowCursor_StoppingDistance_Px Then
                        MoveUp = True
                        Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)
                    End If
                    '
                    If Me.Location.Y < MousePosition.Y - Me.Height - FollowCursor_StoppingDistance_Px Then
                        MoveUp = False
                        Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
                    End If

                    'If PictureBox1.Image IsNot Animation_Idling And Animation_Idling IsNot Nothing Then
                    'PictureBox1.Image = Animation_Idling
                    'Console.WriteLine("Animation_Idling")
                    'End If
                End If
            End If
        End If
    End Sub

    ' Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick
        If Not ContextMenuStrip1.Visible Then
            If Dragging = False Then
                If FollowCursor = False Then
                    If MoveLeft = True Then
                        'If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X - 1, Display.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If

                        'End If
                    Else
                        'If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X + 1, Display.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            Console.WriteLine("Animation_Walking_Right")
                            'End If

                        End If
                    End If
                Else

                    If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                        If Me.Location.X > MousePosition.X + FollowCursor_StoppingDistance_Px Then
                            MoveLeft = False
                            Me.Location = New Point(Me.Location.X - 1, Display.WorkingArea.Bottom - Me.Height)
                            If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                                PixelBox_Pet.Image = Animation_Walking_Left
                                Console.WriteLine("Animation_Walking_Left")
                            End If
                        ElseIf Me.Location.X < MousePosition.X - Me.Width - FollowCursor_StoppingDistance_Px Then
                            MoveLeft = True
                            Me.Location = New Point(Me.Location.X + 1, Display.WorkingArea.Bottom - Me.Height)
                            If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                                PixelBox_Pet.Image = Animation_Walking_Right
                                Console.WriteLine("Animation_Walking_Right")
                            End If
                        Else

                            'If PictureBox_Pet.Image IsNot Animation_Idling Then
                            'PictureBox_Pet.Image = Animation_Idling
                            'Console.WriteLine("Animation_Idling")
                            'End If

                        End If
                    End If


                End If
            End If
        End If
        'Console.WriteLine("Timer_Walking - Tick")
    End Sub

    ' Timer_TurningDecision - Tick
    Private Sub Timer_TurningDecision_Tick(sender As Object, e As EventArgs) Handles Timer_TurningDecision.Tick
        'Left & Right
        R = CInt(Rnd(1))
        If R >= 1 Then
            MoveLeft = True
        Else
            MoveLeft = False
        End If

        R = CInt(Rnd(1))
        'Up & Down
        If R >= 1 Then
            MoveUp = True
        Else
            MoveUp = False
        End If

        Timer_TurningDecision.Interval = Rand.Next(TurningDecision_Min, TurningDecision_Max + 1)
    End Sub

    ' Timer_IdleDecision - Tick
    Private Sub Timer_IdleDecision_Tick(sender As Object, e As EventArgs) Handles Timer_IdleDecision.Tick
        If Rand.Next(0, 100 + 1) <= IdleDecision Then
            Timer_Walking.Stop()

            If HasAnimation_IdlingAlt Then
                If Rand.Next(0, 100 + 1) <= IdleAltDecision Then
                    If MoveLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                            PixelBox_Pet.Image = Animation_Idling_Left
                            Console.WriteLine("Animation_Idling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            PixelBox_Pet.Image = Animation_Idling_Right
                            Console.WriteLine("Animation_Idling_Right")
                        End If
                    End If
                Else
                    If MoveLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_IdlingAlt_Left Then
                            PixelBox_Pet.Image = Animation_IdlingAlt_Left
                            Console.WriteLine("Animation_IdlingAlt_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_IdlingAlt_Right Then
                            PixelBox_Pet.Image = Animation_IdlingAlt_Right
                            Console.WriteLine("Animation_IdlingAlt_Right")
                        End If
                    End If
                End If
            Else
                If MoveLeft = True Then
                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                        PixelBox_Pet.Image = Animation_Idling_Left
                        Console.WriteLine("Animation_Idling_Left")
                    End If
                Else
                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                        PixelBox_Pet.Image = Animation_Idling_Right
                        Console.WriteLine("Animation_Idling_Right")
                    End If
                End If
            End If

        Else
            If HasAnimation_Walking = True Then
                Timer_Walking.Start()
            End If
        End If
        Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
    End Sub

    ' Timer_ChangeModesDecision - Tick
    Private Sub Timer_ChangeModesDecision_Tick(sender As Object, e As EventArgs) Handles Timer_ChangeModesDecision.Tick
        If Rand.Next(0, 100 + 1) <= TakeFlightDecision Then
            Flying_Mode = True
            Ground_Mode = False
            Timer_ChangeModesDecision.Enabled = False
            Timer_Flying.Enabled = True
            Timer_Walking.Enabled = False
            Timer_IdleDecision.Enabled = False
            MoveUp = True
            Console.WriteLine("Flying_Mode")
        End If
        Console.WriteLine("Timer_ChangeModesDecision_Tick")

        Timer_ChangeModesDecision.Interval = Rand.Next(TakeFlightDecision_Min, TakeFlightDecision_Max + 1)
    End Sub

    ' Screen Warping & Edge Turn Around
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If Dragging = False And FormLoadLock = False Then

            'RIGHT & Left
            If Me.Location.X > Display.WorkingArea.Right - Me.Width / 2 Then
                If Rand.Next(0, 100 + 1) <= ScreenWarpingDecision Then
                    If Not DisplayToolStripComboBox.SelectedItem.ToString = "ALL" Then
                        Me.Location = New Point(Display.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y) 'WARP
                    Else

                        Dim TempDisplay_LOW As Screen = Display
                        Dim TempDisplay_Right As Screen = Display
                        Dim HasScreenOnRight As Boolean = False
                        Dim location As Double = Me.Location.X + Me.Width / 2

                        'SET TO SCREEN WITH LOWEST X
                        For Each Displays As Screen In Screen.AllScreens

                            If Not Displays.Bounds = Display.Bounds Then
                                If location >= Displays.Bounds.Left And location <= Displays.Bounds.Right Then
                                    TempDisplay_Right = Displays
                                    HasScreenOnRight = True
                                End If
                            End If

                            If Displays.Bounds.X < Display.Bounds.X Then
                                TempDisplay_LOW = Displays
                            End If

                        Next

                        If HasScreenOnRight Then
                            Display = TempDisplay_Right
                            Me.Location = New Point(Display.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y) 'Travel
                            Console.WriteLine("HasScreenOnRight")
                            Console.WriteLine("Travel")
                        Else
                            Display = TempDisplay_LOW
                            Me.Location = New Point(Display.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y) 'WARP
                            Console.WriteLine("NOScreenOnRight")
                            Console.WriteLine("WARP")
                        End If

                    End If
                Else
                    MoveLeft = True 'TURNAROUND
                End If
                Console.WriteLine("OVER RIGHT")
            ElseIf Me.Location.X < Display.WorkingArea.Left - Me.Width / 2 Then 'LEFT
                If Rand.Next(0, 100 + 1) <= ScreenWarpingDecision Then
                    If Not DisplayToolStripComboBox.SelectedItem.ToString = "ALL" Then
                        Me.Location = New Point(Display.WorkingArea.Right - CInt(Me.Width / 2), Me.Location.Y) 'WARP
                    Else

                        Dim TempDisplay_HIGH As Screen = Display
                        Dim TempDisplay_Left As Screen = Display
                        Dim HasScreenOnLeft As Boolean = False
                        Dim location As Double = Me.Location.X + Me.Width / 2

                        'SET TO SCREEN WITH HIGHEST X
                        For Each Displays As Screen In Screen.AllScreens

                            If Not Displays.Bounds = Display.Bounds Then
                                If location >= Displays.Bounds.Left And location <= Displays.Bounds.Right Then
                                    TempDisplay_Left = Displays
                                    HasScreenOnLeft = True
                                End If
                            End If

                            If Displays.Bounds.X > Display.Bounds.X Then
                                TempDisplay_HIGH = Displays
                            End If

                        Next

                        If HasScreenOnLeft Then
                            Display = TempDisplay_Left
                            Me.Location = New Point(Display.WorkingArea.Right - CInt(Me.Width / 2), Me.Location.Y) 'Travel
                            Console.WriteLine("HasScreenOnLeft")
                            Console.WriteLine("Travel")

                        Else
                            Display = TempDisplay_HIGH
                            Me.Location = New Point(Display.WorkingArea.Right - CInt(Me.Width / 2), Me.Location.Y) 'WARP
                            Console.WriteLine("NOScreenOnLeft")
                            Console.WriteLine("WARP")
                        End If

                    End If
                Else
                    MoveLeft = False 'TURNAROUND
                End If
                Console.WriteLine("OVER LEFT")
            End If








            'OVER DOWN No Wrap
            If Me.Location.Y > Display.WorkingArea.Height - Me.Height Then

                If HasAnimation_Walking = True Or HasAnimation_Idling = True Then
                    If Rand.Next(0, 100 + 1) <= LandingDecision Then
                        Flying_Mode = False
                        Ground_Mode = True
                        Timer_ChangeModesDecision.Enabled = True
                        Timer_Flying.Enabled = False

                        Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)

                        If HasAnimation_Idling = True Then
                            Timer_IdleDecision.Enabled = True
                        Else
                            Timer_IdleDecision.Enabled = False
                        End If

                        If HasAnimation_Walking Then
                            Timer_Walking.Enabled = True
                        Else
                            Timer_Walking.Enabled = False
                        End If

                        Console.WriteLine("Ground_Mode")

                        If MoveLeft = True Then

                            If HasAnimation_Walking = True Then
                                If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                                    PixelBox_Pet.Image = Animation_Walking_Left
                                    'Console.WriteLine("Animation_Walking_Left")
                                End If
                            Else
                                If HasAnimation_Idling = True Then
                                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                                        PixelBox_Pet.Image = Animation_Idling_Left
                                        'Console.WriteLine("Animation_Idling_Left")
                                    End If
                                End If
                            End If

                        Else

                            If HasAnimation_Walking = True Then
                                If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                                    PixelBox_Pet.Image = Animation_Walking_Right
                                    'Console.WriteLine("Animation_Walking_Right")
                                End If
                            Else
                                If HasAnimation_Idling = True Then
                                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                                        PixelBox_Pet.Image = Animation_Idling_Right
                                        'Console.WriteLine("Animation_Idling_Right")
                                    End If
                                End If
                            End If

                        End If

                    Else
                        MoveUp = True
                        Me.Location = New Point(Location.X, Location.Y - 1)
                    End If

                Else
                    MoveUp = True
                    Me.Location = New Point(Location.X, Location.Y - 1)
                End If

                Console.WriteLine("OVER DOWN")
            End If

            'OVER UP No Wrap
            If Me.Location.Y < -Me.Height / 2 Then
                MoveUp = False
                Me.Location = New Point(Location.X, Location.Y + 1)
                Console.WriteLine("OVER UP")
            End If

        Else
            If HasAnimation_Dragging = True Then
                If PixelBox_Pet.Image IsNot Animation_Dragging Then
                    PixelBox_Pet.Image = Animation_Dragging
                End If
            Else
                If MoveLeft = True Then
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
    End Sub

    ' ScalePet()
    Public Sub ScalePet(val As Integer)
        val = val + DefaultScale - 1
        'Dim oldLocation As Point = Me.Location
        Me.Width = Animation_Flying_Left.Width * val
        Me.Height = Animation_Flying_Left.Height * val
        'Me.Location = oldLocation
    End Sub

    ' PixelBox_Pet - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox_Pet.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dragging = True
            PixelBox_Pet.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            'Const WM_NCRBUTTONDOWN As Integer = &HA4S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
            Dragging = False

            Dim TempDisplay As Screen = Display
            For Each Displays As Screen In Screen.AllScreens
                If Me.Location.X >= Displays.Bounds.Left And Me.Location.X <= Displays.Bounds.Right Then
                    TempDisplay = Displays
                End If
            Next

            Display = TempDisplay

            If Not DisplayToolStripComboBox.Text = "ALL" Then
                BlockEvent_DisplayComboBox = True
                DisplayToolStripComboBox.Text = Display.DeviceName.Replace("\\.\", "")
                BlockEvent_DisplayComboBox = False
            End If


            If Ground_Mode = True Then
                Flying_Mode = True
                Ground_Mode = False
                Timer_ChangeModesDecision.Enabled = False
                Timer_Flying.Enabled = True
                Timer_Walking.Enabled = False
                Timer_IdleDecision.Enabled = False
                MoveUp = True
                Console.WriteLine("Flying_Mode")
            End If

            Console.WriteLine("PixelBox_Pet_MouseDown")
        End If
    End Sub

    ' FollowCursorToolStripMenuItem - CheckedChanged
    Private Sub FollowCursorToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles FollowCursorToolStripMenuItem.CheckedChanged
        FollowCursor = FollowCursorToolStripMenuItem.Checked
        If FollowCursorToolStripMenuItem.Checked Then
            Timer_TurningDecision.Enabled = False
            Timer_IdleDecision.Enabled = False
            Timer_Flying.Enabled = True
        Else
            Timer_TurningDecision.Enabled = True
            If Ground_Mode = True Then
                If HasAnimation_Idling = True Then
                    Timer_IdleDecision.Enabled = True
                End If
                If HasAnimation_Walking = True Then
                    Timer_Walking.Enabled = False
                End If
            End If
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

    ' DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 And Not DisplayToolStripComboBox.SelectedItem.ToString = "ALL" Then
                Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                Me.Location = New Point(Rand.Next(Display.WorkingArea.Left, Display.WorkingArea.Right - Me.Width), Rand.Next(Display.WorkingArea.Top, Display.WorkingArea.Bottom - Me.Height))
                Console.WriteLine("DisplayToolStripComboBox - SelectedIndexChanged")
            End If
        End If
    End Sub

    'DisplaySettingsChanged
    Public Sub DisplaySettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
        Console.WriteLine("HERE!: DisplaySettingsChanging()")
        'Console.WriteLine("HERE!: " & DisplayToolStripComboBox.Items.Count)
        'Console.WriteLine("HERE!: " & Screen.AllScreens.Count)
        Dim OldSelectedIndex As Integer = 0
        If Not DisplayToolStripComboBox.SelectedIndex = -1 Then
            OldSelectedIndex = DisplayToolStripComboBox.SelectedIndex
        End If

        If Not DisplayToolStripComboBox.Items.Count = Screen.AllScreens.Count Then
            DisplayToolStripComboBox.Items.Clear()
            DisplayToolStripComboBox.BeginUpdate()
            For Each Displays In Screen.AllScreens
                DisplayToolStripComboBox.Items.Add(Displays.DeviceName.Replace("\\.\", ""))
            Next

            If DisplayToolStripComboBox.Items.Count >= 2 Then
                DisplayToolStripComboBox.Items.Add("ALL")
            End If
            DisplayToolStripComboBox.EndUpdate()

            If DisplayToolStripComboBox.Items.Count > 0 Then
                If DisplayToolStripComboBox.Items.Count >= OldSelectedIndex Then
                    DisplayToolStripComboBox.SelectedIndex = OldSelectedIndex
                    Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                    Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
                    'Console.WriteLine("HERE! 1")
                Else
                    DisplayToolStripComboBox.SelectedIndex = 0
                    Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                    Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
                    'Console.WriteLine("HERE! 2")
                End If
            End If
        Else
            Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
            Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
            'Console.WriteLine("HERE! 3")
        End If
    End Sub
End Class