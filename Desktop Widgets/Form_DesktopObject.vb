
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_DesktopObject
    Public UniqueSessionID As String
    Public ObjectImage As Image
    Dim Dragging As Boolean = False
    Dim StaticImage As Bitmap
    Dim FormLoadLock As Boolean = True
    Dim MYScreen As Screen
    Dim Rand As New Random
    Dim BlockEvent_DisplayComboBox As Boolean = False
    Dim HorizontallyFlipped As Boolean = False
    Public DesktopShortcutPath As String = ""
    Dim newToolTipFont As New Font("Segoe UI", 9, FontStyle.Regular)

    ' Form_DesktopObject - Load
    Private Sub Form_DesktopObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FrameDimension = New Imaging.FrameDimension(PixelBox_DesktopObject.Image.FrameDimensionsList()(0))

        If PixelBox_DesktopObject.Image.GetFrameCount(FrameDimension) = 1 Then
            StopAnimationToolStripMenuItem.Enabled = False
        Else
            FlipHorizontallyToolStripMenuItem.Enabled = False
            StaticImage = New Bitmap(ObjectImage)
            'Console.WriteLine("StaticImage")
        End If

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
        DisplayToolStripComboBox.SelectedIndex = Form_DesktopObjects.ComboBox_Display.SelectedIndex

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Me.TopMost = Form_DesktopObjects.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_DesktopObjects.CheckBox_TopMost.Checked
        AllAlwaysOnTopToolStripMenuItem.Checked = Form_DesktopObjects.CheckBox_TopMost.Checked
        SnapToBarToolStripMenuItem.Checked = Form_DesktopObjects.CheckBox_SnapToBar.Checked
        ScaleToolStripComboBox.SelectedIndex = CInt(Form_DesktopObjects.NumericUpDown_ObjectScale.Value) - 1
        AllScaleToolStripComboBox.SelectedIndex = CInt(Form_DesktopObjects.NumericUpDown_ObjectScale.Value) - 1

        Me.Location = New Point(Rand.Next(MYScreen.WorkingArea.Left, MYScreen.WorkingArea.Right - Me.Width), MYScreen.WorkingArea.Bottom - Me.Height)

        FormLoadLock = False
    End Sub

    ' ScaleObject()
    Public Sub ScaleObject(val As Integer)
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val

        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
        End If
    End Sub

    ' PixelBox_DesktopObject - MouseDown
    Private Sub PixelBox_DesktopObject_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox_DesktopObject.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not DesktopShortcutPath = "" Then
                If e.Clicks = 2 Then
                    LaunchPath(DesktopShortcutPath)
                Else
                    MouseDown_PixelBox()
                End If
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                MouseDown_PixelBox()
            End If
        End If
    End Sub

    Public Sub LaunchPath(path As String)
        Try
            ' Check if the path is a URL
            If path.StartsWith("http://") OrElse path.StartsWith("https://") Then
                Process.Start(New ProcessStartInfo(path) With {.UseShellExecute = True})
                Return
            End If

            ' Check if the path is a file or folder
            If File.Exists(path) OrElse Directory.Exists(path) Then
                Process.Start(New ProcessStartInfo(path) With {.UseShellExecute = True})
                Return
            End If

            ' Check if the path is a command with parameters
            Dim startInfo As New ProcessStartInfo("cmd.exe", "/c " & path)
            startInfo.UseShellExecute = True
            Process.Start(startInfo)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    ' MouseDown_PixelBox_DesktopObject()
    Private Sub MouseDown_PixelBox()
        Dragging = True
        PixelBox_DesktopObject.Capture = False
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

        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
        End If

        Dragging = False
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

    ' SnapToBarToolStripMenuItem - Click
    Private Sub SnapToBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnapToBarToolStripMenuItem.Click
        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
        End If
    End Sub

    ' PauseAnimationToolStripMenuItem - Click
    Private Sub PauseAnimationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopAnimationToolStripMenuItem.Click
        If StopAnimationToolStripMenuItem.Text = "Stop animation" Then
            StopAnimationToolStripMenuItem.Text = "Resume animation"
            PixelBox_DesktopObject.Image = StaticImage
            PixelBox_DesktopObject.Invalidate()
        Else
            StopAnimationToolStripMenuItem.Text = "Stop animation"
            PixelBox_DesktopObject.Image = ObjectImage
            PixelBox_DesktopObject.Invalidate()
        End If
    End Sub

    ' Form_DesktopObject - Closing
    Private Sub Form_DesktopObject_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Form_Menu.FormList_DesktopObject.Remove(UniqueSessionID)
    End Sub

    ' AllAlwaysOnTopToolStripMenuItem - Click
    Private Sub AllAlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllAlwaysOnTopToolStripMenuItem.Click
        For Each item In Form_Menu.FormList_DesktopObject.Keys
            Form_Menu.FormList_DesktopObject(item).AlwaysOnTopToolStripMenuItem.Checked = AllAlwaysOnTopToolStripMenuItem.Checked
            Form_Menu.FormList_DesktopObject(item).TopMost = AllAlwaysOnTopToolStripMenuItem.Checked
        Next
    End Sub

    ' AllScaleToolStripComboBox - SelectedIndexChanged
    Private Sub AllScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllScaleToolStripComboBox.SelectedIndexChanged
        If Not AllScaleToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
            For Each item In Form_Menu.FormList_DesktopObject.Keys
                'Form_Menu.FormList_DesktopObject(item).ScaleObject(AllScaleToolStripComboBox.SelectedIndex + 1)
                Form_Menu.FormList_DesktopObject(item).ScaleToolStripComboBox.SelectedIndex = AllScaleToolStripComboBox.SelectedIndex
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
        PixelBox_DesktopObject.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PixelBox_DesktopObject.Refresh()
        If HorizontallyFlipped = False Then
            HorizontallyFlipped = True
        Else
            HorizontallyFlipped = False
        End If
    End Sub

    ' SetShortcutToolStripMenuItem - Click
    Private Sub SetShortcutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetShortcutToolStripMenuItem.Click
        Form_DesktopShortcut.DesktopObjectFormRef = Me
        Me.AddOwnedForm(Form_DesktopShortcut)
        Form_DesktopShortcut.TextBox_ShortcutPath.Text = DesktopShortcutPath
        Form_DesktopShortcut.Show()
    End Sub

    ' ToolTip1 - Draw
    Private Sub ToolTip1_Draw(sender As Object, e As DrawToolTipEventArgs) Handles ToolTip1.Draw
        ' Set custom background color
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(54, 57, 62)), e.Bounds)

        ' Set custom text color and draw the text
        TextRenderer.DrawText(e.Graphics, e.ToolTipText, newToolTipFont, e.Bounds, Color.WhiteSmoke)
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        ' Measure the text size
        Dim textSize As Size = TextRenderer.MeasureText(ToolTip1.GetToolTip(e.AssociatedControl), newToolTipFont)

        ' Define padding (in pixels)
        Dim paddingWidth As Integer = 10 ' Horizontal padding
        Dim paddingHeight As Integer = 10 ' Vertical padding

        ' Adjust the size of the tooltip to include padding
        e.ToolTipSize = New Size(textSize.Width + paddingWidth, textSize.Height + paddingHeight)
    End Sub
End Class