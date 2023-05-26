
Public Class Form_NatureObject
    Public UniqueSessionID As String
    Public ObjectImage As Image
    Public isMainGrass As Boolean = False
    Dim FormLoadLock As Boolean = True
    Public MYScreen As Screen
    Public MYDisplay As Display
    Dim Rand As New Random
    Dim BlockEvent_DisplayComboBox As Boolean = False
    Public DefaultScale As Integer = 1
    'Form_NatureObject - Load
    Private Sub Form_NatureObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        Me.TopMost = Form_Nature.CheckBox_TopMost.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Form_Nature.CheckBox_TopMost.Checked
        AllAlwaysOnTopToolStripMenuItem.Checked = Form_Nature.CheckBox_TopMost.Checked

        'Dim TempScreen As Screen = MYScreen
        'MYDisplay_Test.GetScreen().AllScreens
        For Each Displays As Display In Display.GetDisplays()
            If Displays.IsGDIPrimary Then
                DisplayToolStripComboBox.Items.Add(Displays.ToPathDisplayTarget.FriendlyName & " (Primary)")
                MYScreen = Displays.GetScreen
            Else
                DisplayToolStripComboBox.Items.Add(Displays.ToPathDisplayTarget.FriendlyName)
            End If
        Next

        DisplayToolStripComboBox.SelectedIndex = Form_Nature.ComboBox_Display.SelectedIndex
        'DisplayToolStripComboBox.SelectedItem = Form_Nature.ComboBox_Display.SelectedItem

        'MYScreen = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
        'MYDisplay = MYDisplay_Test.GetScreen().AllScreens(Form_Nature.ComboBox_Display.SelectedIndex)

        'For Each target In PathDisplayTarget.GetDisplayTargets()
        'DisplayToolStripComboBox.Items.Add(target.FriendlyName & " - " & target.ToDisplayDevice.DisplayName.Replace("\\.\", ""))
        'Next

        'For Each Display In Screen.AllScreens
        'DisplayToolStripComboBox.Items.Add(Display.DeviceName.Replace("\\.\", ""))
        'Next

        'DisplayToolStripComboBox.SelectedIndex = Form_Nature.ComboBox_Display.SelectedIndex

        If isMainGrass = False Then
            ScaleToolStripComboBox.SelectedIndex = CInt(Form_Nature.NumericUpDown_ObjectScale.Value) - 1
            AllScaleToolStripComboBox.SelectedIndex = CInt(Form_Nature.NumericUpDown_ObjectScale.Value) - 1
        Else
            'Me.Width = Screen.PrimaryScreen.WorkingArea.Width
            'Me.Height = ObjectImage.Height
            'Me.Location = New Point(Display.WorkingArea.Left, Display.WorkingArea.Bottom - Me.Height)
        End If

        Dim MyDisplay As WindowsDisplayAPI.Display = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex)
        Me.Location = New Point(Rand.Next(MyDisplay.GetScreen.WorkingArea.Left, MyDisplay.GetScreen.WorkingArea.Right - Me.Width), MyDisplay.GetScreen.WorkingArea.Bottom - Me.Height)

        FormLoadLock = False
    End Sub
    'ScaleObject()
    Public Sub ScaleObject(val As Integer)
        val = val + DefaultScale - 1
        Me.Width = ObjectImage.Width * val
        Me.Height = ObjectImage.Height * val
        Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)
    End Sub
    'PixelBox1 - MouseDown
    Private Sub PixelBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PixelBox1.MouseDown
        If isMainGrass = False Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                PixelBox1.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                'Const WM_NCRBUTTONDOWN As Integer = &HA4S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)


                'Dim tempval As Integer = -1
                'For Each Displays As Screen In Screen.AllScreens
                'If Me.Location.X >= Displays.Bounds.Left And Me.Location.X <= Displays.Bounds.Right Then
                'TempDisplay = Displays
                'End If
                'Next


                BlockEvent_DisplayComboBox = True
                Dim TempScreen As Screen = MYScreen
                For Each Displays As Display In Display.GetDisplays()
                    If Me.Location.X >= Displays.GetScreen.Bounds.Left And Me.Location.X <= Displays.GetScreen.Bounds.Right Then
                        TempScreen = Displays.GetScreen
                        If Displays.IsGDIPrimary Then
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName & " (Primary)"
                        Else
                            DisplayToolStripComboBox.Text = Displays.ToPathDisplayTarget.FriendlyName
                        End If
                    End If
                Next
                BlockEvent_DisplayComboBox = False
                MYScreen = TempScreen

                Me.Location = New Point(Me.Location.X, MYScreen.WorkingArea.Bottom - Me.Height)


                'TempDisplay
                'DisplayToolStripComboBox.Text = MYDisplay.ToPathDisplayTarget.GetDisplayTargets(tempval).FriendlyName 'MYScreen.DeviceName.Replace("\\.\", "")
                'Console.WriteLine("HERE: " & bla.ToPathDisplayTarget.FriendlyName)
                'Console.WriteLine(tempval)
                'MYDisplay = MYScreen
                'MYDisplay = 
                'MYDisplay.ToPathDisplayTarget.FriendlyName

                'Dragging = False
            End If
        End If
    End Sub
    'ScaleToolStripComboBox - SelectedIndexChanged
    Private Sub ScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScaleToolStripComboBox.SelectedIndexChanged
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
    'Form_NatureObject - Closing
    Private Sub Form_NatureObject_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Form_Menu.FormList_NatureObject.Remove(UniqueSessionID)
    End Sub
    'AllAlwaysOnTopToolStripMenuItem - Click
    Private Sub AllAlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllAlwaysOnTopToolStripMenuItem.Click
        For Each item In Form_Menu.FormList_NatureObject.Keys
            Form_Menu.FormList_NatureObject(item).AlwaysOnTopToolStripMenuItem.Checked = AllAlwaysOnTopToolStripMenuItem.Checked
            Form_Menu.FormList_NatureObject(item).TopMost = AllAlwaysOnTopToolStripMenuItem.Checked
        Next
    End Sub
    'AllScaleToolStripComboBox - SelectedIndexChanged
    Private Sub AllScaleToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllScaleToolStripComboBox.SelectedIndexChanged
        If Not AllScaleToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
            For Each item In Form_Menu.FormList_NatureObject.Keys
                Form_Menu.FormList_NatureObject(item).ScaleToolStripComboBox.SelectedIndex = AllScaleToolStripComboBox.SelectedIndex
            Next
        End If
    End Sub
    'DisplayToolStripComboBox - SelectedIndexChanged
    Private Sub DisplayToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayToolStripComboBox.SelectedIndexChanged
        If BlockEvent_DisplayComboBox = False Then
            If Not DisplayToolStripComboBox.SelectedIndex = -1 And FormLoadLock = False Then
                Dim MyDisplay As WindowsDisplayAPI.Display = Display.GetDisplays(DisplayToolStripComboBox.SelectedIndex)
                MYScreen = Screen.AllScreens(DisplayToolStripComboBox.SelectedIndex)
                Me.Location = New Point(Rand.Next(MyDisplay.GetScreen.WorkingArea.Left, MyDisplay.GetScreen.WorkingArea.Right - Me.Width), MyDisplay.GetScreen.WorkingArea.Bottom - Me.Height)
                'Console.WriteLine("DisplayToolStripComboBox_SelectedIndexChanged")
            End If
        End If
    End Sub
End Class