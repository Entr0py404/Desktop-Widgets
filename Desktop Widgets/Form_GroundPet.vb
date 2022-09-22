Imports Microsoft.Win32

Public Class Form_GroundPet
    Public TurnLeft As Boolean = True
    Dim Dragging As Boolean = False
    Public FollowCursor As Boolean = False
    Public Animation_Dragging_Left As Bitmap
    Public Animation_Dragging_Right As Bitmap

    Public Animation_Falling_Left As Bitmap
    Public Animation_Falling_Right As Bitmap

    'Public Animation_Idling As Bitmap

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
    Public currentlyAnimating As Boolean = False

    Dim Display As Screen = Screen.PrimaryScreen
    Dim Rand As New Random
    Dim FormLoadLock As Boolean = True

    Dim BlockEvent_DisplayComboBox As Boolean = False

    'Form_GroundPet - Load
    Private Sub Form_GroundPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ScaleToolStripComboBox.SelectedIndex = Form_Pets.TrackBar_ObjectScale.Value - 1

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Timer_Walking.Enabled = True
        Timer_Falling.Enabled = True
        Timer_IdleDecision.Enabled = True
        Timer_TurningDecision.Enabled = True
        AddHandler SystemEvents.DisplaySettingsChanged, AddressOf DisplaySettingsChanged
        FormLoadLock = False

        Console.WriteLine("Form_GroundPet_Load")
    End Sub
    'ScalePet()
    Public Sub ScalePet(val As Integer)
        Me.Width = Animation_Walking_Left.Width * val
        Me.Height = (Animation_Walking_Left.Height * val) + PixelBox_Emote.Height
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
                    If Me.Location.X > MousePosition.X + 6 Then
                        TurnLeft = False
                        Me.Location = New Point(Me.Location.X - 1, Display.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If
                    ElseIf Me.Location.X < MousePosition.X - Me.Width - 6 Then
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
                If Me.Location.Y + 5 >= Display.WorkingArea.Bottom - Me.Height Then
                    Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)

                    If TurnLeft = True Then
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
                    Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)
                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Falling_Left Then
                            PixelBox_Pet.Image = Animation_Falling_Left
                            Console.WriteLine("Animation_Falling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Falling_Right Then
                            PixelBox_Pet.Image = Animation_Falling_Right
                            Console.WriteLine("Animation_Falling_Right")
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
    End Sub
    'Screen Warping & Edge Turn Around
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If Dragging = False And FormLoadLock = False Then
            ' Console.WriteLine("LocationChanged")
            Dim R As Integer = CInt(Rnd(1))
            'RIGHT
            If Me.Location.X > Display.WorkingArea.Right - Me.Width / 2 Then
                If R = 0 Then
                    TurnLeft = True 'TURNAROUND
                Else
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
                End If
                Console.WriteLine("OVER RIGHT")
            ElseIf Me.Location.X < Display.WorkingArea.Left - Me.Width / 2 Then 'LEFT
                If R = 0 Then
                    TurnLeft = False 'TURNAROUND
                Else
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
                End If
                Console.WriteLine("OVER LEFT")
            End If

        Else

            If TurnLeft = True Then
                If PixelBox_Pet.Image IsNot Animation_Dragging_Left Then
                    PixelBox_Pet.Image = Animation_Dragging_Left
                    'CurrentAnimatedImage = Animation_Dragging
                End If
            Else
                If PixelBox_Pet.Image IsNot Animation_Dragging_Right Then
                    PixelBox_Pet.Image = Animation_Dragging_Right
                    'CurrentAnimatedImage = Animation_Dragging
                End If
            End If

            'If TurnLeft = True Then
            'PictureBox_Pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            'End If
        End If
    End Sub
    'Timer_IdleDecision - Tick
    Private Sub Timer_IdleDecision_Tick(sender As Object, e As EventArgs) Handles Timer_IdleDecision.Tick
        If Not ContextMenuStrip1.Visible And Not Dragging Then
            Dim R As Integer = CInt(Rnd(1))
            'Console.WriteLine(R)
            If R = 0 Then
                Timer_Walking.Stop()

                If TurnLeft = True Then
                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                        PixelBox_Pet.Image = Animation_Idling_Left
                        'CurrentAnimatedImage = Animation_Idling_Left
                        'PixelBox_Pet.Image = CurrentAnimatedImage
                        'Console.WriteLine("Animation_Idling_Left")
                    End If
                Else
                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                        PixelBox_Pet.Image = Animation_Idling_Right
                        'CurrentAnimatedImage = Animation_Idling_Right
                        'Console.WriteLine("Animation_Idling_Right")
                    End If
                End If
            Else
                Timer_Walking.Start()
            End If
        End If
    End Sub
    'PoopToolStripMenuItem - Click
    Private Sub PoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoopToolStripMenuItem.Click
        Dim Poop As New Form_GroundPoop
        Poop.Show()
        Poop.ScaleObject(ScaleToolStripComboBox.SelectedIndex + 1)

        If TurnLeft = True Then
            Poop.Location = New Point(Me.Location.X + Me.Width - Poop.Width, Display.WorkingArea.Bottom - Poop.Height)
        Else
            Poop.Location = New Point(Me.Location.X + CInt(Poop.Width / 2), Display.WorkingArea.Bottom - Poop.Height)
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