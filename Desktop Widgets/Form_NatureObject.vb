Public Class Form_NatureObject
    Public ObjectImage As Image
    Public isMainGrass As Boolean = False
    Dim Dragging As Boolean = False
    'Form_NatureObject - Load
    Private Sub Form_NatureObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Me.TopMost = Form_Nature.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Nature.CheckBox_TopMost.Checked
        If isMainGrass = False Then
            'ScaleObject(1)
            ToolStripComboBox1.SelectedIndex = Form_Nature.TrackBar_ObjectScale.Value - 1
            Dim R As New Random
            Me.Location = New Point(R.Next(Me.Width, Screen.PrimaryScreen.WorkingArea.Right - Me.Width * 2), Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
        Else
            Me.Width = Screen.PrimaryScreen.WorkingArea.Width
            Me.Height = ObjectImage.Height
            Me.Location = New Point(0, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
        End If
    End Sub
    'ScaleObject()
    Public Sub ScaleObject(val As Integer)
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val
        Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
    End Sub
    'PixelBox1 - MouseDown
    Private Sub PixelBox_Pet_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox1.MouseDown
        If isMainGrass = False Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dragging = True
                PixelBox1.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                'Const WM_NCRBUTTONDOWN As Integer = &HA4S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
                Me.Location = New Point(Me.Location.X, Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height)
                Dragging = False
            End If
        End If
    End Sub
    '
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
        'Console.WriteLine("ToolStripComboBox1_SelectedIndexChanged")
    End Sub
    'CloseToolStripMenuItem - Click
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'AlwaysOnTopToolStripMenuItem - Click
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked
    End Sub
End Class