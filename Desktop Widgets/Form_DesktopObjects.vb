Public Class Form_DesktopObjects
    'Form_DesktopObjects - Load
    Private Sub Form_DesktopObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\")
        End If

        For Each display In Screen.AllScreens
            ComboBox_Display.Items.Add(display.DeviceName.Replace("\\.\", ""))
        Next

        ComboBox_Display.SelectedIndex = 0
    End Sub
    'ListView_Objects - ItemActivate
    Private Sub ListView_NatureObjects_ItemActivate(sender As Object, e As EventArgs)
        'Dim DesktopObject = New Form_DesktopObject
        'DesktopObject.ObjectImage = New Bitmap(ListView_Objects.SelectedItems(0).Name)
        'DesktopObject.PixelBox1.Image = DesktopObject.ObjectImage
        'DesktopObject.Name = "DesktopObject"
        'Form_Menu.IDCounter_DesktopObject += 1
        'Form_Menu.FormList_DesktopObject.Add(Form_Menu.IDCounter_DesktopObject.ToString, DesktopObject)
        'DesktopObject.UniqueSessionID = Form_Menu.IDCounter_DesktopObject.ToString
        'Form_Menu.FormList_DesktopObject(Form_Menu.IDCounter_DesktopObject.ToString).Show() 'DesktopObject.Show()
    End Sub
    'TrackBar_ObjectScale - ValueChanged
    Private Sub TrackBar_ObjectScale_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_ObjectScale.ValueChanged
        Label_Scale.Text = TrackBar_ObjectScale.Value.ToString & "x"
    End Sub
    'LoadDesktopObjects()
    Private Sub LoadDesktopObjects(filepath As String)
        If Directory.Exists(filepath) Then
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            Label_AssetCount.Text = "Desktop Objects"
            Label_AssetCount.Update()
            'Label_Status.Text = "Loading Files..."
            'Label_Status.Refresh()
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.png", SearchOption.AllDirectories))
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.gif", SearchOption.AllDirectories)) 'Fix gifs

            For Each item As String In FilesToCheck
                CreateNewPanel(item, Path.GetFileNameWithoutExtension(item), Color.WhiteSmoke)
                'DesktopObjects_ImageList.Images.Add(Image.FromFile(item))
                'DesktopObjects_ListView.Items.Add(item, "", DesktopObjects_ImageList.Images.Count - 1)
            Next

            Label_AssetCount.Text = FilesToCheck.Count.ToString & " Desktop Objects"

            'Label_Status.Text = "Load Completed."
            FlowLayoutPanel1.Visible = True
        End If
    End Sub
    'Button_AllDesktopObjects - Click
    Private Sub Button_AllDesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_AllDesktopObjects.Click
        Dim FormListArray As Array = Form_Menu.FormList_DesktopObject.Keys.ToArray
        For Each item As String In FormListArray
            Form_Menu.FormList_DesktopObject(item).Close()
        Next
        Form_Menu.FormList_DesktopObject.Clear()
    End Sub
    'ReloadToolStripMenuItem - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\")
        End If
    End Sub
    'AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                Dim DesktopObject = New Form_DesktopObject
                DesktopObject.ObjectImage = New Bitmap(DirectCast(sender, PixelBox).Text.ToString)
                DesktopObject.PixelBox1.Image = DesktopObject.ObjectImage
                DesktopObject.Name = "DesktopObject"
                Form_Menu.IDCounter_DesktopObject += 1
                Form_Menu.FormList_DesktopObject.Add(Form_Menu.IDCounter_DesktopObject.ToString, DesktopObject)
                DesktopObject.UniqueSessionID = Form_Menu.IDCounter_DesktopObject.ToString
                Form_Menu.FormList_DesktopObject(Form_Menu.IDCounter_DesktopObject.ToString).Show() 'DesktopObject.Show()


                'AssetInfo.LoadAsset(DirectCast(sender, PixelBox).Text.ToString)
                'AssetInfo.Show()
                'AssetInfo.BringToFront()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms) 'Bitmap.FromStream(ms) '
            Return img
        End Using
    End Function
    'CreateNewPanel
    Private Sub CreateNewPanel(imagePath As String, assetObjectText As String, textColor As Color)
        'Panel
        Dim AssetPanel = New Panel
        AssetPanel.Size = New Size(98, 98)
        AssetPanel.BackColor = Color.FromArgb(46, 49, 54)
        AssetPanel.Name = "AssetPanel1"

        'Label
        Dim AssetLabel = New Label
        AssetLabel.AutoEllipsis = True
        AssetLabel.TextAlign = ContentAlignment.MiddleCenter
        AssetLabel.Dock = DockStyle.Bottom
        AssetLabel.Text = assetObjectText
        AssetLabel.ForeColor = textColor
        AssetLabel.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        AssetLabel.BackColor = Color.FromArgb(28, 30, 34)
        'ToolTip1.SetToolTip(AssetLabel, imagePath)

        'PixelBox
        Dim AssetPixelBox = New PixelBox
        AssetPixelBox.Dock = DockStyle.Fill
        AssetPixelBox.Image = Image.FromFile(imagePath) 'SafeImageFromFile(imagePath)
        AssetPixelBox.SizeMode = PictureBoxSizeMode.Zoom
        AssetPixelBox.Name = "PixelBox1"
        AssetPixelBox.Cursor = Cursors.Hand
        AssetPixelBox.Text = imagePath
        'AssetPixelBox.ContextMenuStrip = ContextMenuStrip1

        'Add AssetLabel and AssetPixelBox to AssetPanel
        AssetPanel.Controls.Add(AssetPixelBox)
        AssetPanel.Controls.Add(AssetLabel)

        'Add AssetPanel to FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Add(AssetPanel)

        AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip2.Show(Button1, 4, 4)
    End Sub
    'ResizePanels (sizeInt)
    Private Sub ResizePanels(sizeInt As Integer)
        'My.Settings.AssetPannelSize = sizeInt

        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Visible = False
        For Each oObj As Control In FlowLayoutPanel1.Controls
            Dim pPanel As Panel = CType(oObj, Panel)
            pPanel.Width = sizeInt
            pPanel.Height = sizeInt
        Next
        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel1.ResumeLayout()
    End Sub
    'Small_ToolStripMenuItem - Click
    Private Sub Small_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Small_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = True
        ResizePanels(98)
    End Sub
    'Medium_ToolStripMenuItem - Click
    Private Sub Medium_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Medium_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Medium_ToolStripMenuItem.Checked = True
        ResizePanels(128)
    End Sub
    'MediumLarge_ToolStripMenuItem - Click
    Private Sub MediumLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        MediumLarge_ToolStripMenuItem.Checked = True
        ResizePanels(150)
    End Sub
    'Large_ToolStripMenuItem - Click
    Private Sub Large_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Large_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Large_ToolStripMenuItem.Checked = True
        ResizePanels(182)
    End Sub
    'ExtraLarge_ToolStripMenuItem - Click
    Private Sub ExtraLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        ExtraLarge_ToolStripMenuItem.Checked = True
        ResizePanels(229)
    End Sub
    'UnCheckAllSizes
    Private Sub UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = False
        Medium_ToolStripMenuItem.Checked = False
        MediumLarge_ToolStripMenuItem.Checked = False
        Large_ToolStripMenuItem.Checked = False
        ExtraLarge_ToolStripMenuItem.Checked = False
    End Sub
End Class