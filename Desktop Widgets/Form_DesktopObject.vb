Public Class Form_DesktopObject
    Public ObjectImage As Image
    Dim Dragging As Boolean = False
    Dim fd1 As Imaging.FrameDimension
    Dim StaticImage As Bitmap
    'Form_DesktopObject - Load
    Private Sub Form_DesktopObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fd1 = New Imaging.FrameDimension(PixelBox1.Image.FrameDimensionsList()(0))

        If PixelBox1.Image.GetFrameCount(fd1) = 1 Then
            StopAnimationToolStripMenuItem.Enabled = False
        Else
            StaticImage = New Bitmap(ObjectImage)
            Console.WriteLine("StaticImage")
        End If

        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Me.TopMost = Form_DesktopObjects.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_DesktopObjects.CheckBox_TopMost.Checked
        SnapToBarToolStripMenuItem.Checked = Form_DesktopObjects.CheckBox_SnapToBar.Checked
        ToolStripComboBox1.SelectedIndex = Form_DesktopObjects.TrackBar_ObjectScale.Value - 1
        Dim R As New Random
        Me.Location = New Point(R.Next(Me.Width, Screen.PrimaryScreen.WorkingArea.Right - Me.Width * 2), Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
    End Sub
    'ScaleObject()
    Public Sub ScaleObject(val As Integer)
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val

        If SnapToBarToolStripMenuItem.Checked Then
            Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
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
            If SnapToBarToolStripMenuItem.Checked Then
                Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
            End If
            Dragging = False
        End If
    End Sub
    'ToolStripComboBox1 - SelectedIndexChanged
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.SelectedIndex = 0 Then
            ScaleObject(1)
        ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
            ScaleObject(2)
        ElseIf ToolStripComboBox1.SelectedIndex = 2 Then
            ScaleObject(3)
        ElseIf ToolStripComboBox1.SelectedIndex = 3 Then
            ScaleObject(4)
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
            Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
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
End Class