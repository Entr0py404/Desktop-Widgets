
Public Class Form_GroundPet
    Public TurnLeft As Boolean = True
    Dim Dragging As Boolean = False
    Public FollowCursor As Boolean = False
    Public Animation_Dragging As Bitmap
    Public Animation_Falling As Bitmap
    Public Animation_Idling As Bitmap

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

    Public CurrentAnimatedImage As Bitmap 'New Bitmap("Frog_WalkRight.gif")
    Public currentlyAnimating As Boolean = False
    'Form_GroundPet - Load
    Private Sub Form_GroundPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ScalePet(1)
        FollowCursorToolStripMenuItem.Checked = Form_Pets.CheckBox_FollowCursor.Checked
        Me.TopMost = Form_Pets.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Pets.CheckBox_TopMost.Checked

        ToolStripComboBox1.SelectedIndex = Form_Pets.TrackBar_ObjectScale.Value - 1

        'Me.Width = Animation_Walking_Left.Width * 4
        'Me.Height = Animation_Walking_Left.Height * 4 + PictureBox_Emote.Height

        Dim R As New Random
        Me.Location = New Point(R.Next(Me.Width, Screen.PrimaryScreen.WorkingArea.Right - Me.Width * 2), Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
        Console.WriteLine("Form_GroundPet_Load")

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'ScalePet()
    Public Sub ScalePet(val As Integer)
        Me.Width = Animation_Walking_Left.Width * val
        Me.Height = (Animation_Walking_Left.Height * val) + PixelBox_Emote.Height
        Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
        'Me.Width = PixelBox_Pet.Width
        'Me.Height = PixelBox_Pet.Height + PictureBox_Emote.Height

        'Me.Width = Animation_Walking_Left.Width
        'Me.Height = Animation_Walking_Left.Height + PictureBox_Emote.Height
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
            Dragging = False
        End If
    End Sub
    'Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick
        If Not ContextMenuStrip1.Visible Then
            If FollowCursor = False Then
                If TurnLeft = True Then
                    If Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X - 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If

                    End If
                Else
                    If Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
                        Me.Location = New Point(Me.Location.X + 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)

                        If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                            PixelBox_Pet.Image = Animation_Walking_Right
                            Console.WriteLine("Animation_Walking_Right")
                        End If

                    End If
                End If
            Else

                If Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
                    If Me.Location.X > MousePosition.X + 6 Then
                        TurnLeft = False
                        Me.Location = New Point(Me.Location.X - 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
                        If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                            PixelBox_Pet.Image = Animation_Walking_Left
                            Console.WriteLine("Animation_Walking_Left")
                        End If
                    ElseIf Me.Location.X < MousePosition.X - Me.Width - 6 Then
                        TurnLeft = True
                        Me.Location = New Point(Me.Location.X + 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
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
        If Dragging = False Then
            If Me.Location.Y < Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
                If Me.Location.Y + 5 >= Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
                    Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)


                    If TurnLeft = True Then
                        If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                            PixelBox_Pet.Image = Animation_Idling_Left
                            'CurrentAnimatedImage =
                            'PixelBox_Pet.Image =
                            Console.WriteLine("Animation_Idling_Left")
                        End If
                    Else
                        If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                            PixelBox_Pet.Image = Animation_Idling_Right
                            'CurrentAnimatedImage =
                            'PixelBox_Pet.Image =
                            Console.WriteLine("Animation_Idling_Right")
                        End If
                    End If
                Else
                    Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)
                    If PixelBox_Pet.Image IsNot Animation_Falling Then
                        PixelBox_Pet.Image = Animation_Falling
                        'CurrentAnimatedImage =
                        'PixelBox_Pet.Image =
                        Console.WriteLine("Animation_Falling")
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
        If Dragging = False Then

            Dim R As Integer = CInt(Rnd(1))
            If Me.Location.X > Screen.PrimaryScreen.WorkingArea.Width - Me.Width / 2 Then
                If R = 0 Then
                    TurnLeft = True
                Else
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y)
                End If
                Console.WriteLine("OVER RIGHT")
            End If

            If Me.Location.X < -Me.Width / 2 Then
                If R = 0 Then
                    TurnLeft = False
                Else
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - CInt(Me.Width / 2), Me.Location.Y)
                End If
                Console.WriteLine("OVER LEFT")
            End If
        Else

            If PixelBox_Pet.Image IsNot Animation_Dragging Then
                PixelBox_Pet.Image = Animation_Dragging
                'CurrentAnimatedImage = Animation_Dragging
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
            Console.WriteLine(R)
            If R = 0 Then
                Timer_Walking.Stop()

                If TurnLeft = True Then
                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                        PixelBox_Pet.Image = Animation_Idling_Left
                        'CurrentAnimatedImage = Animation_Idling_Left
                        'PixelBox_Pet.Image = CurrentAnimatedImage
                        Console.WriteLine("Animation_Idling_Left")
                    End If
                Else
                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                        PixelBox_Pet.Image = Animation_Idling_Right
                        'CurrentAnimatedImage = Animation_Idling_Right
                        Console.WriteLine("Animation_Idling_Right")
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
        If TurnLeft = True Then
            Poop.Location = New Point(Me.Location.X + Me.Width, Screen.PrimaryScreen.WorkingArea.Bottom - Poop.Height)
        Else
            Poop.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Poop.Height)
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
    'ToolStripComboBox1 - SelectedIndexChanged
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.SelectedIndex = 0 Then
            ScalePet(1)
        ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
            ScalePet(2)
        ElseIf ToolStripComboBox1.SelectedIndex = 2 Then
            ScalePet(3)
        ElseIf ToolStripComboBox1.SelectedIndex = 3 Then
            ScalePet(4)
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

    '
    Private Sub ContextMenuStrip1_Opened(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Opened
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
    End Sub
End Class