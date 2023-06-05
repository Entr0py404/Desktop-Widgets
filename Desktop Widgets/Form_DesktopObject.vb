'Imports System.ComponentModel

Public Class Form_DesktopObject
    Public UniqueSessionID As String
    Public ObjectImage As Image
    Dim Dragging As Boolean = False
    Dim FrameDimension As Imaging.FrameDimension
    Dim StaticImage As Bitmap
    Dim FormLoadLock As Boolean = True
    Dim Display As Screen
    Dim Rand As New Random
    Dim BlockEvent_DisplayComboBox As Boolean = False

    'Form_DesktopObject - Load
    Private Sub Form_DesktopObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrameDimension = New Imaging.FrameDimension(PixelBox1.Image.FrameDimensionsList()(0))

        If PixelBox1.Image.GetFrameCount(FrameDimension) = 1 Then
            StopAnimationToolStripMenuItem.Enabled = False
        Else
            StaticImage = New Bitmap(ObjectImage)
            Console.WriteLine("StaticImage")
        End If

        DisplayToolStripComboBox.BeginUpdate()
        For Each Display In Screen.AllScreens
            DisplayToolStripComboBox.Items.Add(Display.DeviceName.Replace("\\.\", ""))
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

        FormLoadLock = False
    End Sub
    'ScaleObject()
    Public Sub ScaleObject(val As Integer)
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val

        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
        End If
    End Sub
    'PixelBox1 - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dragging = True
            PixelBox1.Capture = False
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

            BlockEvent_DisplayComboBox = True
            DisplayToolStripComboBox.Text = Display.DeviceName.Replace("\\.\", "")
            BlockEvent_DisplayComboBox = False

            If SnapToBarToolStripMenuItem.Checked Then
                Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
            End If

            Dragging = False
        End If
    End Sub
    'ToolStripComboBox1 - SelectedIndexChanged
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScaleToolStripComboBox.SelectedIndexChanged
        If Not ScaleToolStripComboBox.SelectedIndex = -1 Then
            ScaleObject(ScaleToolStripComboBox.SelectedIndex + 1)
        End If
    End Sub
    'CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub
    'SnapToBarToolStripMenuItem - Click
    Private Sub SnapToBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnapToBarToolStripMenuItem.Click
        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, Display.WorkingArea.Bottom - Me.Height)
        End If
    End Sub
    'PauseAnimationToolStripMenuItem - Click
    Private Sub PauseAnimationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopAnimationToolStripMenuItem.Click
        If StopAnimationToolStripMenuItem.Text = "Stop animation" Then
            StopAnimationToolStripMenuItem.Text = "Resume animation"
            PixelBox1.Image = StaticImage
            PixelBox1.Invalidate()
        Else
            StopAnimationToolStripMenuItem.Text = "Stop animation"
            PixelBox1.Image = ObjectImage
            PixelBox1.Invalidate()
        End If
    End Sub
    'Form_DesktopObject - Closing
    Private Sub Form_DesktopObject_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Form_Menu.FormList_DesktopObject.Remove(UniqueSessionID)
    End Sub
    'AllAlwaysOnTopToolStripMenuItem - Click
    Private Sub AllAlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllAlwaysOnTopToolStripMenuItem.Click
        For Each item In Form_Menu.FormList_DesktopObject.Keys
            Form_Menu.FormList_DesktopObject(item).AlwaysOnTopToolStripMenuItem.Checked = AllAlwaysOnTopToolStripMenuItem.Checked
            Form_Menu.FormList_DesktopObject(item).TopMost = AllAlwaysOnTopToolStripMenuItem.Checked
        Next
    End Sub
    'AllScaleToolStripComboBox - SelectedIndexChanged
    Private Sub AllScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllScaleToolStripComboBox.SelectedIndexChanged
        If Not AllScaleToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
            For Each item In Form_Menu.FormList_DesktopObject.Keys
                'Form_Menu.FormList_DesktopObject(item).ScaleObject(AllScaleToolStripComboBox.SelectedIndex + 1)
                Form_Menu.FormList_DesktopObject(item).ScaleToolStripComboBox.SelectedIndex = AllScaleToolStripComboBox.SelectedIndex
            Next
        End If
    End Sub
    'DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 Then
                Display = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                Me.Location = New Point(Rand.Next(Display.WorkingArea.Left, Display.WorkingArea.Right - Me.Width), Display.WorkingArea.Bottom - Me.Height)
            End If
        End If
    End Sub
End Class