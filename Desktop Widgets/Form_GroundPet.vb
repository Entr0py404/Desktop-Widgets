
Public Class Form_GroundPet
    Dim Rand As New Random
    Dim Dragging As Boolean = False
    Dim FormLoadLock As Boolean = True
    Dim Display As Screen = Screen.PrimaryScreen
    Dim BlockEvent_DisplayComboBox As Boolean = False

    Public TurnLeft As Boolean = True
    Public FollowCursor As Boolean = False
    Public currentlyAnimating As Boolean = False
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
    Public Animation_Action_Left As Bitmap
    Public Animation_Action_Right As Bitmap
    Public Animation_ActionAlt_Left As Bitmap
    Public Animation_ActionAlt_Right As Bitmap
    Public Animation_Sleeping_Left As Bitmap
    Public Animation_Sleeping_Right As Bitmap
    Public Animation_Jumping_Left As Bitmap
    Public Animation_Jumping_Right As Bitmap
    Public CurrentAnimatedImage As Bitmap

    'Behavior settings
    Dim DefaultScale As Integer = 1
    Dim FollowCursor_StopingDistance_Px As Integer = 6
    Dim Falling_Movement_Px As Integer = 5

    Dim IdleDecision As Integer = 45
    Dim IdleAltDecision As Integer = 35
    Dim ScreenWarpingDecision As Integer = 60

    Dim Walking_Movement_Tick As Integer = 1
    Dim Falling_Movement_Tick As Integer = 1
    Dim TunringDecision_Min As Integer = 2500
    Dim TunringDecision_Max As Integer = 3500
    Dim IdleDecision_Min As Integer = 2500
    Dim IdleDecision_Max As Integer = 3500
    'Form_GroundPet - Load
    Private Sub Form_GroundPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Walking
        If File.Exists(PetDir & "\Walking Left.gif") Then
            Animation_Walking_Left = New Bitmap(PetDir & "\Walking Left.gif")
        End If
        If File.Exists(PetDir & "\Walking Right.gif") Then
            Animation_Walking_Right = New Bitmap(PetDir & "\Walking Right.gif")
        End If

        'Idling
        If File.Exists(PetDir & "\Idling Left.gif") Then
            Animation_Idling_Left = Image.FromFile(PetDir & "\Idling Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Right.gif") Then
            Animation_Idling_Right = Image.FromFile(PetDir & "\Idling Right.gif")
            PixelBox_Pet.Image = Animation_Idling_Right
        End If

        'Idling Alt
        If File.Exists(PetDir & "\Idling Alt Left.gif") Then
            Animation_IdlingAlt_Left = New Bitmap(PetDir & "\Idling Alt Left.gif")
        End If
        If File.Exists(PetDir & "\Idling Alt Right.gif") Then
            Animation_IdlingAlt_Right = New Bitmap(PetDir & "\Idling Alt Right.gif")
        End If

        'Dragging
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

        'Falling
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


        For Each Displays In Screen.AllScreens
            DisplayToolStripComboBox.Items.Add(Displays.DeviceName.Replace("\\.\", ""))
        Next

        If DisplayToolStripComboBox.Items.Count >= 2 Then
            DisplayToolStripComboBox.Items.Add("ALL")
        End If

        DisplayToolStripComboBox.SelectedIndex = Form_Pets.ComboBox_Display.SelectedIndex
        FollowCursorToolStripMenuItem.Checked = Form_Pets.CheckBox_FollowCursor.Checked
        Me.TopMost = Form_Pets.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Pets.CheckBox_TopMost.Checked
        ScaleToolStripComboBox.SelectedIndex = CInt(Form_Pets.NumericUpDown_ObjectScale.Value) - 1

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Timer_Walking.Enabled = True
        Timer_Falling.Enabled = True
        Timer_IdleDecision.Enabled = True
        Timer_TurningDecision.Enabled = True
        AddHandler Microsoft.Win32.SystemEvents.DisplaySettingsChanged, AddressOf DisplaySettingsChanged

        If File.Exists(Application.StartupPath & "\" & PetDir & "\Behavior.ini") Then
            Dim INI As New MadMilkman.Ini.IniFile()
            INI.Load(Application.StartupPath & "\" & PetDir & "\Behavior.ini")
            '[Settings]
            DefaultScale = CInt(INI.Sections("Settings").Keys("DefaultScale").Value)
            If DefaultScale = 0 Then
                DefaultScale = 1
            End If
            If DefaultScale > 1 Then
                ScalePet(1)
            End If

            FollowCursor_StopingDistance_Px = CInt(INI.Sections("Settings").Keys("FollowCursor_StopingDistance_Px").Value)
            Falling_Movement_Px = CInt(INI.Sections("Settings").Keys("Falling_Movement_Px").Value)

            '[Decisions]
            IdleDecision = CInt(INI.Sections("Decisions").Keys("IdleDecision").Value)
            IdleAltDecision = CInt(INI.Sections("Decisions").Keys("IdleAltDecision").Value)
            ScreenWarpingDecision = CInt(INI.Sections("Decisions").Keys("ScreenWarpingDecision").Value)

            '[Timers_Tick]
            Walking_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick").Value)
            Timer_Walking.Interval = Walking_Movement_Tick

            Falling_Movement_Tick = CInt(INI.Sections("Timers_Tick").Keys("Falling_Movement_Tick").Value)
            Timer_Falling.Interval = Falling_Movement_Tick

            '[Timers_Randomization]
            TunringDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("TunringDecision_Min").Value)
            TunringDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("TunringDecision_Max").Value)
            Timer_TurningDecision.Interval = Rand.Next(TunringDecision_Min, TunringDecision_Max + 1)

            IdleDecision_Min = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Min").Value)
            IdleDecision_Max = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Max").Value)
            Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
        Else
            Timer_TurningDecision.Interval = Rand.Next(TunringDecision_Min, TunringDecision_Max + 1)
            Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
        End If

        FormLoadLock = False

        Console.WriteLine("Form_GroundPet_Load")
    End Sub
    'Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick
        If Not ContextMenuStrip1.Visible Then
            If FollowCursor = False Then
                If TurnLeft = True Then
                    If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X - 1, Display.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If

                    End If
                Else
                    If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X + 1, Display.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            Console.WriteLine("Animation_Walking_Right")
                        End If

                    End If
                End If
            Else

                If Me.Location.Y = Display.WorkingArea.Bottom - Me.Height Then
                    If Me.Location.X > MousePosition.X + FollowCursor_StopingDistance_Px Then
                        TurnLeft = False
                        Me.Location = New Point(Me.Location.X - 1, Display.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If
                    ElseIf Me.Location.X < MousePosition.X - Me.Width - FollowCursor_StopingDistance_Px Then
                        TurnLeft = True
                        Me.Location = New Point(Me.Location.X + 1, Display.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            Console.WriteLine("Animation_Walking_Right")
                        End If
                    Else

                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Or PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            If TurnLeft = True Then
                                PixelBox_Pet.Image = Animation_Idling_Left
                                Console.WriteLine("Animation_Idling_Left")
                            Else
                                PixelBox_Pet.Image = Animation_Idling_Right
                                Console.WriteLine("Animation_Idling_Right")
                            End If
                        End If
                    End If

                End If
            End If
        End If
    End Sub
    'Timer_Falling - Tick
    Private Sub Timer_Falling_Tick(sender As Object, e As EventArgs) Handles Timer_Falling.Tick
        'Dim Display_Test As Screen
        If Dragging = False Then
            If Me.Location.Y < Display.WorkingArea.Bottom - Me.Height Then
                If Me.Location.Y + Falling_Movement_Px >= Display.WorkingArea.Bottom - Me.Height Then
                    Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)

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
    'Timer_TurningDecision - Tick
    Private Sub Timer_TurningDecision_Tick(sender As Object, e As EventArgs) Handles Timer_TurningDecision.Tick
        Dim R As Integer = CInt(Rnd(1))
        If R = 0 Then
            TurnLeft = True
        Else
            TurnLeft = False
        End If

        Timer_TurningDecision.Interval = Rand.Next(TunringDecision_Min, TunringDecision_Max + 1)
    End Sub
    'Timer_IdleDecision - Tick
    Private Sub Timer_IdleDecision_Tick(sender As Object, e As EventArgs) Handles Timer_IdleDecision.Tick
        If Not ContextMenuStrip1.Visible And Not Dragging Then
            If IdleDecision <= Rand.Next(0, 100 + 1) Then
                Timer_Walking.Stop()

                If TurnLeft = True Then
                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                        PixelBox_Pet.Image = Animation_Idling_Left
                    End If
                Else
                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                        PixelBox_Pet.Image = Animation_Idling_Right
                    End If
                End If
            Else
                Timer_Walking.Start()
            End If
        End If
        Timer_IdleDecision.Interval = Rand.Next(IdleDecision_Min, IdleDecision_Max + 1)
    End Sub
    'Screen Warping & Edge Turn Around
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If Dragging = False And FormLoadLock = False Then
            'RIGHT
            If Me.Location.X > Display.WorkingArea.Right - Me.Width / 2 Then
                If ScreenWarpingDecision <= Rand.Next(0, 100 + 1) Then
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
                            Me.Location = New Point(Display.WorkingArea.Left - CInt(Me.Width / 2), Display.WorkingArea.Bottom - Me.Height) 'Travel
                            Console.WriteLine("HasScreenOnRight")
                            Console.WriteLine("Travel")
                        Else
                            Display = TempDisplay_LOW
                            Me.Location = New Point(Display.WorkingArea.Left - CInt(Me.Width / 2), Display.WorkingArea.Bottom - Me.Height) 'WARP
                            Console.WriteLine("NOScreenOnRight")
                            Console.WriteLine("WARP")
                        End If

                    End If
                Else
                    TurnLeft = True 'TURNAROUND
                End If
                Console.WriteLine("OVER RIGHT")
            ElseIf Me.Location.X < Display.WorkingArea.Left - Me.Width / 2 Then 'LEFT
                If ScreenWarpingDecision <= Rand.Next(0, 100 + 1) Then
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
                            Me.Location = New Point(Display.WorkingArea.Right - CInt(Me.Width / 2), Display.WorkingArea.Bottom - Me.Height) 'Travel
                            Console.WriteLine("HasScreenOnLeft")
                            Console.WriteLine("Travel")

                        Else
                            Display = TempDisplay_HIGH
                            Me.Location = New Point(Display.WorkingArea.Right - CInt(Me.Width / 2), Display.WorkingArea.Bottom - Me.Height) 'WARP
                            Console.WriteLine("NOScreenOnLeft")
                            Console.WriteLine("WARP")
                        End If

                    End If
                Else
                    TurnLeft = False 'TURNAROUND
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
    End Sub
    'ScalePet()
    Public Sub ScalePet(val As Integer)
        val = val + DefaultScale - 1
        Me.Width = Animation_Walking_Left.Width * val
        Me.Height = Animation_Walking_Left.Height * val
        Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
    End Sub
    'PixelBox_Pet - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox_Pet.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dragging = True
            PixelBox_Pet.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            'Const WM_NCRBUTTONDOWN As Integer = &HA4S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)


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

            Dragging = False
        End If
    End Sub
    'FollowCursorToolStripMenuItem - CheckedChanged
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
    'CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'ScaleToolStripComboBox - SelectedIndexChanged
    Private Sub ScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScaleToolStripComboBox.SelectedIndexChanged
        If Not ScaleToolStripComboBox.SelectedIndex = -1 Then
            ScalePet(ScaleToolStripComboBox.SelectedIndex + 1)
        End If
    End Sub
    'PixelBox_Pet - Paint
    Private Sub PixelBox_Pet_Paint(sender As Object, e As PaintEventArgs) Handles PixelBox_Pet.Paint
        If CurrentAnimatedImage IsNot Nothing Then
            AnimateImage()
            ImageAnimator.UpdateFrames()
            If TurnLeft = False Then
                Dim tempImage As New Bitmap(CurrentAnimatedImage)
                tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                e.Graphics.DrawImage(tempImage, New Point(0, 0))
                tempImage.Dispose()
            Else
                e.Graphics.DrawImage(CurrentAnimatedImage, New Point(0, 0))
            End If
        End If
    End Sub
    'OnFrameChanged()
    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs)
        PixelBox_Pet.Invalidate()
    End Sub
    'AnimateImage()
    Sub AnimateImage()
        If Not currentlyAnimating Then
            ImageAnimator.Animate(CurrentAnimatedImage, New EventHandler(AddressOf Me.OnFrameChanged))
            currentlyAnimating = True
        End If
    End Sub
    'AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub
    'ContextMenuStrip1 - Opened
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
    'DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 And Not DisplayToolStripComboBox.SelectedItem.ToString = "ALL" Then
                Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                Me.Location = New Point(Rand.Next(Display.WorkingArea.Left, Display.WorkingArea.Right - Me.Width), Display.WorkingArea.Bottom - Me.Height)
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
            For Each Displays In Screen.AllScreens
                DisplayToolStripComboBox.Items.Add(Displays.DeviceName.Replace("\\.\", ""))
            Next

            If DisplayToolStripComboBox.Items.Count >= 2 Then
                DisplayToolStripComboBox.Items.Add("ALL")
            End If

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