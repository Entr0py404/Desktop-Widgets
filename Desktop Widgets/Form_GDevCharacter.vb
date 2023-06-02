Imports System.Speech.Synthesis
Public Class Form_GDevCharacter
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

    'Comments
    Dim Comment_Random As String() = {"It’s a-me", "Would you kindly…", "Hey!", "Look!", "Listen!", "Stay awhile and listen!", "The cake is a lie.", "It’s Super Effective!", "Lemons!", "Fun for everyone.", "Bring me that pizza!"}
    Dim Comment_GDevelop_Open As String() = {"Whatcha making!?", "I see you are busy.", "This game is looking fun!", "You making a level?", "Yay, GDevelop!", "I see you are using GDevelop.", "Game development!", "Juice it up!", "I see you're making games.", "I see GDevelop!", "I love games!", "This looks fun.", "Game is looking good.", "Putt me in your game."}
    Dim Comment_GDevelop_NotOpen As String() = {"You could be making games.", "No GDevelop open makes me sad.", "You don't have GDevelop open."}

    Dim Comment_Calc_Open As String() = {"Math is hard.", "Hey is that a calculator!", "Yeah math!", "I see that calculator."}

    Dim Comment_PublicRoadmap As String() = {""}
    Dim Comment_Extensions As String() = {""}
    Dim Comment_Assets As String() = {""}
    Dim Comment_Documentation As String() = {""}

    Dim Comment_Expressions As String() = {"Wiki!", "Knowledge!", "Expressions are powerful.", "I can't even express how important expressions are.", "This page is so useful."}
    Dim Comment_Wiki As String() = {"Wiki!", "Knowledge!"}
    Dim Comment_WebApp As String() = {""}
    Dim Comment_Examples As String() = {"Knowledge!", "I'm in one of those.", "I like the I was in.", "This page is so useful."}
    Dim Comment_JSDocumentation As String() = {"Wiki!", "Knowledge!", "This page is so useful."}
    Dim Comment_Dragged As String() = {"I'm in space!", "Do a barrel roll!", "Where are we going?", "Hey put me down!", "Hey put me back down!", "Whoa!", "Weee!", "I'm afraid of heights!", "Okay but, don't drop me..", "I was about to do my thing."}
    Dim Comment_Droped As String() = {"Weee!", "You dropped me..", "Coming in for a landing.", "Free falling!", "Watch me ace this landing.", "Look out below!"}

    Dim randNum As New Random
    Dim synth As New SpeechSynthesizer
    'Public TTSVolume As Integer = 0
    'Public TTSGender As VoiceGender = VoiceGender.Female

    'Form_GDevCharacter - Load
    Private Sub Form_GDevCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_Phrase.Show()
        'Form_Phrase.Visible = False

        Timer_Speak.Interval = randNum.Next(3500, 5500) '3.5 to 5.5 sec
        'synth.Rate = 3
        'synth.Rate = -2

        Form_Phrase.FontDialog1.Font = Form_Gdev.FontDialog1.Font

        FollowCursorToolStripMenuItem.Checked = Form_Gdev.CheckBox_FollowCursor.Checked

        Me.TopMost = Form_Gdev.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Gdev.CheckBox_TopMost.Checked
        Form_Phrase.TopMost = AlwaysOnTopToolStripMenuItem.Checked

        ToolStripComboBox1.SelectedIndex = Form_Gdev.TrackBar_ObjectScale.Value - 1

        'Me.Width = Animation_Walking_Left.Width * 4
        'Me.Height = Animation_Walking_Left.Height * 4 + PictureBox_Emote.Height

        Dim R As New Random
        Me.Location = New Point(R.Next(Me.Width, Screen.PrimaryScreen.WorkingArea.Right - Me.Width * 2), Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
        Console.WriteLine("Form_GDevCharacter_Load")

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

            ' If randNum.Next(0, 100) < 75 Then
            Comment("Dragged")
            ' End If
            Console.WriteLine("Dragged")
            PixelBox_Pet.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            'Const WM_NCRBUTTONDOWN As Integer = &HA4S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
            Dragging = False
            PixelBox_Emote.Image = Nothing
            ' If randNum.Next(0, 100) < 75 Then
            Comment("Droped")
            ' End If
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
    'Form_GDevCharacter - LocationChanged (Screen Warping & Edge Turn Around)
    Private Sub Form_GDevCharacter_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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

        '
        Form_Phrase.Location = New Point(Me.Location.X + CInt(Me.Width / 2) - CInt(Form_Phrase.Width / 2), Me.Location.Y - Form_Phrase.Height)
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
        'Dim Poop As New Form_GroundPoop
        'Poop.Show()
        'If TurnLeft = True Then
        'Poop.Location = New Point(Me.Location.X + Me.Width, Screen.PrimaryScreen.WorkingArea.Bottom - Poop.Height)
        'Else
        'Poop.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Poop.Height)
        'End If
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
        If Not ToolStripComboBox1.SelectedIndex = -1 Then
            ScalePet(ToolStripComboBox1.SelectedIndex + 1)
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
    '
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
        Form_Phrase.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub
    'Form_GDevCharacter - FormClosing
    Private Sub Form_GDevCharacter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form_Gdev.Button_Spawn.Enabled = True
        Form_Phrase.Close()
    End Sub
    'PublicRoadmapToolStripMenuItem - Click
    Private Sub PublicRoadmapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicRoadmapToolStripMenuItem.Click
        Process.Start("https://trello.com/b/qf0lM7k8/gdevelop-public-roadmap")
        Comment("PublicRoadmap")
    End Sub
    'ExtensionsToolStripMenuItem - Click
    Private Sub ExtensionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtensionsToolStripMenuItem.Click
        Process.Start("https://trello.com/b/AftjL2v1/gdevelop-extensions")
        Comment("Extensions")
    End Sub
    'AssetsToolStripMenuItem - Click
    Private Sub AssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetsToolStripMenuItem.Click
        Process.Start("https://trello.com/b/xoOCKFOf/gdevelop-assets")
        Comment("Assets")
    End Sub
    'DocumentationToolStripMenuItem - Click
    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Process.Start("https://trello.com/b/3D1PXrga/gdevelop-documentation")
        Comment("Documentation")
    End Sub
    'ExpressionsToolStripMenuItem - Click
    Private Sub ExpressionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpressionsToolStripMenuItem.Click
        Process.Start("https://wiki.gdevelop.io/gdevelop5/all-features/expressions-reference")
        Comment("Expressions")
    End Sub
    'WikiToolStripMenuItem - Click
    Private Sub WikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WikiToolStripMenuItem.Click
        Process.Start("https://wiki.gdevelop.io/gdevelop5/start")
        Comment("Wiki")
    End Sub
    'WebAppToolStripMenuItem - Click
    Private Sub WebAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebAppToolStripMenuItem.Click
        Process.Start("https://editor.gdevelop-app.com/")
        Comment("WebApp")
    End Sub
    'ExamplesToolStripMenuItem - Click
    Private Sub ExamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamplesToolStripMenuItem.Click
        Process.Start("https://gdevelop.io/game-example")
        Comment("Examples")
    End Sub
    'JSDocumentationToolStripMenuItem - Click
    Private Sub JSDocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JSDocumentationToolStripMenuItem.Click
        Process.Start("https://docs.gdevelop.io/GDJS%20Runtime%20Documentation/index.html")
        Comment("JSDocumentation")
    End Sub

    'CheckIfProcessesNameIsRunning
    Private Function CheckIfProcessIsRunning(ProcessesName As String) As Boolean
        Dim MyProcess() As Process
        MyProcess = Process.GetProcessesByName(ProcessesName)
        If MyProcess.Count > 0 Then
            If MyProcess(0).Threads(0).ThreadState = ThreadState.Running Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'Comment
    Private Sub Comment(topic As String)
        Dim phrase As String = ""
        If topic = "" Then

            If randNum.Next(0, 100) < 60 Then

                If randNum.Next(0, 100) < 60 Then
                    If CheckIfProcessIsRunning("GDevelop") = True Then
                        phrase = Comment_GDevelop_Open(randNum.Next(0, Comment_GDevelop_Open.Length))
                    Else
                        phrase = Comment_GDevelop_NotOpen(randNum.Next(0, Comment_GDevelop_NotOpen.Length))
                    End If
                Else
                    If CheckIfProcessIsRunning("Calculator") = True Then
                        phrase = Comment_Calc_Open(randNum.Next(0, Comment_Calc_Open.Length))
                    End If
                End If

            Else
                phrase = Comment_Random(randNum.Next(0, Comment_Random.Length))
            End If

        ElseIf topic = "Dragged" Then
            phrase = Comment_Dragged(randNum.Next(0, Comment_Dragged.Length))
        ElseIf topic = "Droped" Then
            phrase = Comment_Droped(randNum.Next(0, Comment_Droped.Length))
        ElseIf topic = "PublicRoadmap" Then
            phrase = Comment_PublicRoadmap(randNum.Next(0, Comment_PublicRoadmap.Length))
        ElseIf topic = "Extensions" Then
            phrase = Comment_Extensions(randNum.Next(0, Comment_Extensions.Length))
        ElseIf topic = "Assets" Then
            phrase = Comment_Assets(randNum.Next(0, Comment_Assets.Length))
        ElseIf topic = "Documentation" Then
            phrase = Comment_Documentation(randNum.Next(0, Comment_Documentation.Length))
        ElseIf topic = "Expressions" Then
            phrase = Comment_Expressions(randNum.Next(0, Comment_Expressions.Length))
        ElseIf topic = "Wiki" Then
            phrase = Comment_Wiki(randNum.Next(0, Comment_Wiki.Length))
        ElseIf topic = "WebApp" Then
            phrase = Comment_WebApp(randNum.Next(0, Comment_WebApp.Length))
        ElseIf topic = "Examples" Then
            phrase = Comment_Examples(randNum.Next(0, Comment_Examples.Length))
        ElseIf topic = "JSDocumentation" Then
            phrase = Comment_GDevelop_Open(randNum.Next(0, Comment_JSDocumentation.Length))
        End If

        If Not phrase = "" Then
            'Dim tempval As Integer = CInt(PixelBox_Pet.Width / 2)
            'Form_Main.NotifyIcon1.ShowBalloonTip(5000)

            If Form_Gdev.RadioButton_TTSFemale.Checked Then
                synth.SelectVoiceByHints(VoiceGender.Female)
            Else
                synth.SelectVoiceByHints(VoiceGender.Male)
            End If

            Form_Phrase.Label_Phrase.Text = phrase
            Form_Phrase.Location = New Point(Me.Location.X + CInt(Me.Width / 2) - CInt(Form_Phrase.Width / 2), Me.Location.Y - Form_Phrase.Height)
            Form_Phrase.Opacity = 0.85 'Form_Phrase.Visible = True

            synth.Volume = Form_Gdev.TrackBar_TSSVolume.Value
            'synth.SpeakAsync(phrase)
        End If
    End Sub
    'FemaleToolStripMenuItem - Click
    Private Sub FemaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemaleToolStripMenuItem.Click
        If FemaleToolStripMenuItem.Checked Then
            MaleToolStripMenuItem.Checked = False
        End If
    End Sub
    'MaleToolStripMenuItem - Click
    Private Sub MaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaleToolStripMenuItem.Click
        If MaleToolStripMenuItem.Checked Then
            FemaleToolStripMenuItem.Checked = False
        End If
    End Sub
    'Timer_Speak - Tick
    Private Sub Timer_Speak_Tick(sender As Object, e As EventArgs) Handles Timer_Speak.Tick
        If Not ContextMenuStrip1.Visible And Not Dragging And Form_Phrase.Label_Phrase.Text = "" Then
            If randNum.Next(0, 100) < 50 Then
                Comment("")
            End If
        End If
        Timer_Speak.Interval = randNum.Next(3500, 5500) '3.5 to 5.5 sec
    End Sub
    '
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

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
    'SpeechFontToolStripMenuItem - Click
    Private Sub SpeechFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeechFontToolStripMenuItem.Click
        If Form_Phrase.FontDialog1.ShowDialog() = DialogResult.OK Then
            Form_Phrase.Label_Phrase.Font = Form_Phrase.FontDialog1.Font
            Form_Gdev.FontDialog1.Font = Form_Phrase.FontDialog1.Font
        End If
    End Sub
End Class