
Public Class Form_FlyingPet
    Dim MoveLeft As Boolean = True
    Dim MoveUp As Boolean = True
    Dim Dragging As Boolean = False
    Public FollowCursor As Boolean = False
    Public Animation_Dragging As Image
    Public Animation_Falling As Image

    Public Animation_Flying_Left As Image
    Public Animation_Flying_Right As Image

    Public Animation_Walking_Left As Image
    Public Animation_Walking_Right As Image

    Public Animation_Idling_Left As Image
    Public Animation_Idling_Right As Image

    Public Animation_IdlingAlt_Left As Image
    Public Animation_IdlingAlt_Right As Image

    'Public Animation_Action_Left As Image
    'Public Animation_Action_Right As Image

    'Public Animation_Hovering_Left As Image
    'Public Animation_Hovering_Right As Image

    Dim Flying_Mode As Boolean = True
    Dim Ground_Mode As Boolean = False

    Public HasAnimation_Idling As Boolean = False
    Public HasAnimation_IdlingAlt As Boolean = False
    Public HasAnimation_Walking As Boolean = False

    'Dim Incoming As String

    'Form_FlyingPet_Load
    Private Sub Form_FlyingPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Width = PixelBox_Pet.Width
        'Me.Height = PixelBox_Pet.Height + PixelBox_Emote.Height

        'ScalePet(1)
        FollowCursorToolStripMenuItem.Checked = Form_Pets.CheckBox_FollowCursor.Checked
        Me.TopMost = Form_Pets.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Pets.CheckBox_TopMost.Checked

        ToolStripComboBox1.SelectedIndex = Form_Pets.TrackBar_ObjectScale.Value - 1

        Me.Location = New Point(GenerateRandomNumber(Me.Width, Screen.PrimaryScreen.WorkingArea.Right - Me.Width * 2), GenerateRandomNumber(Me.Height, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height * 2))

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'ScalePet()
    Public Sub ScalePet(val As Integer)
        Me.Width = Animation_Flying_Left.Width * val
        Me.Height = (Animation_Flying_Left.Height * val) + PixelBox_Emote.Height

        Me.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height) '- PixelBox_Emote.Height
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
            PixelBox_Emote.Image = Nothing

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
    'Timer_Flying - Tick
    Private Sub Timer_Flying_Tick(sender As Object, e As EventArgs) Handles Timer_Flying.Tick
        If Not ContextMenuStrip1.Visible Then
            If Dragging = False Then
                If FollowCursor = False Then
                    If MoveLeft = True Then
                        Me.Location = New Point(Me.Location.X - 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Left Then
                            PixelBox_Pet.Image = Animation_Flying_Left
                            Console.WriteLine("Animation_Flying_Left")
                        End If
                    Else
                        Me.Location = New Point(Me.Location.X + 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Right Then
                            PixelBox_Pet.Image = Animation_Flying_Right
                            Console.WriteLine("Animation_Flying_Right")
                        End If
                    End If

                    If MoveUp = True Then
                        Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)
                    Else
                        Me.Location = New Point(Me.Location.X, Me.Location.Y + 1)
                    End If

                Else
                    '
                    If Me.Location.X > MousePosition.X + 6 Then
                        MoveLeft = True
                        Me.Location = New Point(Me.Location.X - 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Left Then
                            PixelBox_Pet.Image = Animation_Flying_Left
                            Console.WriteLine("Animation_Flying_Left")
                        End If
                    End If
                    '
                    If Me.Location.X < MousePosition.X - Me.Width - 6 Then
                        MoveLeft = False
                        Me.Location = New Point(Me.Location.X + 1, Me.Location.Y)
                        If PixelBox_Pet.Image IsNot Animation_Flying_Right Then
                            PixelBox_Pet.Image = Animation_Flying_Right
                            Console.WriteLine("Animation_Flying_Right")
                        End If
                    End If
                    '
                    If Me.Location.Y > MousePosition.Y + 6 Then
                        MoveUp = True
                        Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)
                    End If
                    '
                    If Me.Location.Y < MousePosition.Y - Me.Height - 6 Then
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
    'Timer_Walking - Tick
    Private Sub Timer_Walking_Tick(sender As Object, e As EventArgs) Handles Timer_Walking.Tick
        If Not ContextMenuStrip1.Visible Then
            If Dragging = False Then
                If FollowCursor = False Then
                    If MoveLeft = True Then
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
                            MoveLeft = False
                            Me.Location = New Point(Me.Location.X - 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
                            If PixelBox_Pet.Image IsNot Animation_Walking_Left Then
                                PixelBox_Pet.Image = Animation_Walking_Left
                                Console.WriteLine("Animation_Walking_Left")
                            End If
                        ElseIf Me.Location.X < MousePosition.X - Me.Width - 6 Then
                            MoveLeft = True
                            Me.Location = New Point(Me.Location.X + 1, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
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

    'Timer_Falling - Tick
    'Private Sub Timer_Falling_Tick(sender As Object, e As EventArgs) 'Handles Timer_Falling.Tick
    'If Dragging = False Then
    'If Me.Location.Y < Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
    'If Me.Location.Y + 5 > Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height Then
    'Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
    'If PictureBox_Pet.Image IsNot Animation_Idling Then
    'PictureBox_Pet.Image = Animation_Idling
    'Console.WriteLine("Animation_Idling")
    'End If
    'Else
    'Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)
    'If PixelBox_Pet.Image IsNot Animation_Falling Then
    'PixelBox_Pet.Image = Animation_Falling
    'Console.WriteLine("Animation_Falling")
    'End If
    'End If
    'End If
    'End If
    'End Sub

    'Timer_TurningDecision - Tick
    Private Sub Timer_TurningDecision_Tick(sender As Object, e As EventArgs) Handles Timer_TurningDecision.Tick
        'Left & Right
        If GenerateRandomNumber(0, 100) >= 50 Then
            MoveLeft = True
        Else
            MoveLeft = False
        End If
        'Up & Down
        If GenerateRandomNumber(0, 100) >= 50 Then
            MoveUp = True
        Else
            MoveUp = False
        End If
    End Sub
    'Screen Warping & Edge Turn Around
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If Dragging = False Then

            'OVER RIGHT
            If Me.Location.X > Screen.PrimaryScreen.WorkingArea.Width - Me.Width / 2 Then
                If GenerateRandomNumber(0, 100) > 60 Then
                    MoveLeft = True
                    Me.Location = New Point(Location.X - 1, Location.Y)
                Else
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Left - CInt(Me.Width / 2), Me.Location.Y)
                End If
                Console.WriteLine("OVER RIGHT")
            End If
            'OVER LEFT
            If Me.Location.X < -Me.Width / 2 Then
                If GenerateRandomNumber(0, 100) > 60 Then
                    MoveLeft = False
                    Me.Location = New Point(Location.X + 1, Location.Y)
                Else
                    Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - CInt(Me.Width / 2), Me.Location.Y)
                End If
                Console.WriteLine("OVER LEFT")
            End If

            'OVER DOWN No Wrap
            If Me.Location.Y > Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then

                If HasAnimation_Walking = True Or HasAnimation_Idling = True Then
                    If GenerateRandomNumber(0, 100) >= 80 Then
                        MoveUp = True
                        Me.Location = New Point(Location.X, Location.Y - 1)
                    Else
                        Flying_Mode = False
                        Ground_Mode = True
                        Timer_ChangeModesDecision.Enabled = True
                        Timer_Flying.Enabled = False

                        Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)

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
                                    Console.WriteLine("Animation_Walking_Left")
                                End If
                            Else
                                If HasAnimation_Idling = True Then
                                    If PixelBox_Pet.Image IsNot Animation_Idling_Left Then
                                        PixelBox_Pet.Image = Animation_Idling_Left
                                        Console.WriteLine("Animation_Idling_Left")
                                    End If
                                End If
                            End If

                        Else

                            If HasAnimation_Walking = True Then
                                If PixelBox_Pet.Image IsNot Animation_Walking_Right Then
                                    PixelBox_Pet.Image = Animation_Walking_Right
                                    Console.WriteLine("Animation_Walking_Right")
                                End If
                            Else
                                If HasAnimation_Idling = True Then
                                    If PixelBox_Pet.Image IsNot Animation_Idling_Right Then
                                        PixelBox_Pet.Image = Animation_Idling_Right
                                        Console.WriteLine("Animation_Idling_Right")
                                    End If
                                End If
                            End If

                        End If

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
            If PixelBox_Pet.Image IsNot Animation_Dragging Then
                PixelBox_Pet.Image = Animation_Dragging
            End If

            If PixelBox_Emote.Image IsNot My.Resources.Heart_Emote_Style_5 Then
                PixelBox_Emote.Image = My.Resources.Heart_Emote_Style_5
            End If
            'If MoveLeft = True Then
            'PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            'End If
        End If
    End Sub
    'Timer_IdleDecision - Tick
    Private Sub Timer_IdleDecision_Tick(sender As Object, e As EventArgs) Handles Timer_IdleDecision.Tick
        If GenerateRandomNumber(0, 100) >= 65 Then
            Timer_Walking.Stop()

            If GenerateRandomNumber(0, 100) >= 70 Then
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
            If HasAnimation_Walking = True Then
                Timer_Walking.Start()
            End If
        End If
        Timer_IdleDecision.Interval = GenerateRandomNumber(2500, 3500)
    End Sub
    'PoopToolStripMenuItem - Click
    Private Sub PoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoopToolStripMenuItem.Click
        Dim Poop As New Form_GroundPoop
        Poop.Show()
        If MoveLeft = True Then
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
    'CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'GenerateRandomNumber
    Function GenerateRandomNumber(Min As Integer, Max As Integer) As Integer
        Static Random_Number As New Random()
        Return Random_Number.Next(Min, Max)
    End Function
    'Timer_ChangeModesDecision - Tick
    Private Sub Timer_ChangeModesDecision_Tick(sender As Object, e As EventArgs) Handles Timer_ChangeModesDecision.Tick
        If GenerateRandomNumber(0, 100) >= 40 Then
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
    'AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub
End Class