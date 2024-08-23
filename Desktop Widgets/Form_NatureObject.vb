
Public Class Form_NatureObject
    Public UniqueSessionID As String
    Public ObjectImage As Image
    Public isMainGrass As Boolean = False
    Dim FormLoadLock As Boolean = True
    Dim MYScreen As Screen
    Dim Rand As New Random
    Dim BlockEvent_DisplayComboBox As Boolean = False
    Public DefaultScale As Integer = 1
    Dim HorizontallyFlipped As Boolean = False

    ' Form_NatureObject - Load
    Private Sub Form_NatureObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        Me.TopMost = Form_Nature.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Nature.CheckBox_TopMost.Checked
        AllAlwaysOnTopToolStripMenuItem.Checked = Form_Nature.CheckBox_TopMost.Checked

        DisplayToolStripComboBox.BeginUpdate()
        For Each Displays As Display In Display.GetDisplays()
            If Displays.IsGDIPrimary Then
                DisplayToolStripComboBox.Items.Add(Displays.ToPathDisplayTarget.FriendlyName & " (Primary)")
                MYScreen = Displays.GetScreen
            Else
                DisplayToolStripComboBox.Items.Add(Displays.ToPathDisplayTarget.FriendlyName)
            End If
        Next
        DisplayToolStripComboBox.EndUpdate()
        DisplayToolStripComboBox.SelectedIndex = Form_Nature.ComboBox_Display.SelectedIndex

        If isMainGrass = False Then
            ScaleToolStripComboBox.SelectedIndex = CInt(Form_Nature.NumericUpDown_ObjectScale.Value) - 1
            AllScaleToolStripComboBox.SelectedIndex = CInt(Form_Nature.NumericUpDown_ObjectScale.Value) - 1
        Else
            'Me.Width = Screen.PrimaryScreen.WorkingArea.Width
            'Me.Height = ObjectImage.Height
            'Me.Location = New Point(MYScreen.WorkingArea.Left, MYScreen.WorkingArea.Bottom - Me.Height)
        End If

        Dim FrameDimension = New Imaging.FrameDimension(PixelBox1.Image.FrameDimensionsList()(0))
        If PixelBox1.Image.GetFrameCount(FrameDimension) > 1 Then
            FlipHorizontallyToolStripMenuItem.Enabled = False
        Else
            Dim R As Integer = CInt(Rnd(1))
            If R = 0 Then
                PixelBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                PixelBox1.Refresh()
                HorizontallyFlipped = True
                End If
        End If

        Me.Location = New Point(Rand.Next(MYScreen.WorkingArea.Left, MYScreen.WorkingArea.Right - Me.Width), MYScreen.WorkingArea.Bottom - Me.Height)

        FormLoadLock = False
    End Sub

    ' ScaleObject()
    Public Sub ScaleObject(val As Integer)
        val = val + DefaultScale - 1
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val
        Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
    End Sub

    ' PixelBox1 - MouseDown
    Private Sub PixelBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox1.MouseDown
        If isMainGrass = False Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                PixelBox1.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)

                BlockEvent_DisplayComboBox = True
                For Each Displays As Display In Display.GetDisplays()
                    If Me.Location.X >= Displays.GetScreen.Bounds.Left And Me.Location.X <= Displays.GetScreen.Bounds.Right Then
                        MYScreen = Displays.GetScreen
                        If Displays.IsGDIPrimary Then
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName & " (Primary)"
                        Else
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName
                        End If
                    End If
                Next
                BlockEvent_DisplayComboBox = False

                Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
            End If
        End If
    End Sub

    ' ScaleToolStripComboBox - SelectedIndexChanged
    Private Sub ScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScaleToolStripComboBox.SelectedIndexChanged
        If Not ScaleToolStripComboBox.SelectedIndex = -1 Then
            ScaleObject(ScaleToolStripComboBox.SelectedIndex + 1)
        End If
    End Sub

    ' CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub

    ' Form_NatureObject - Closing
    Private Sub Form_NatureObject_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Form_Menu.FormList_NatureObject.Remove(UniqueSessionID)
    End Sub

    ' AllAlwaysOnTopToolStripMenuItem - Click
    Private Sub AllAlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllAlwaysOnTopToolStripMenuItem.Click
        For Each item In Form_Menu.FormList_NatureObject.Keys
            Form_Menu.FormList_NatureObject(item).AlwaysOnTopToolStripMenuItem.Checked = AllAlwaysOnTopToolStripMenuItem.Checked
            Form_Menu.FormList_NatureObject(item).TopMost = AllAlwaysOnTopToolStripMenuItem.Checked
        Next
    End Sub

    ' AllScaleToolStripComboBox - SelectedIndexChanged
    Private Sub AllScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllScaleToolStripComboBox.SelectedIndexChanged
        If Not AllScaleToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
            For Each item In Form_Menu.FormList_NatureObject.Keys
                Form_Menu.FormList_NatureObject(item).ScaleToolStripComboBox.SelectedIndex = AllScaleToolStripComboBox.SelectedIndex
            Next
        End If
    End Sub

    ' DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
                MYScreen = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex).GetScreen
                Me.Location = New Point(Rand.Next(MYScreen.WorkingArea.Left, MYScreen.WorkingArea.Right - Me.Width), MYScreen.WorkingArea.Bottom - Me.Height)
            End If
        End If
    End Sub

    ' FlipHorizontallyToolStripMenuItem - Click
    Private Sub FlipHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontallyToolStripMenuItem.Click
        PixelBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PixelBox1.Refresh()
        If HorizontallyFlipped = False Then
            HorizontallyFlipped = True
        Else
            HorizontallyFlipped = False
        End If
    End Sub
End Class