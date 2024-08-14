
Public Class Form_DesktopObjects
    Dim AssetPanel_Size As Integer = 98
    ' Form_DesktopObjects - Load
    Private Sub Form_DesktopObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        ComboBox_Display.BeginUpdate()
        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                ComboBox_Display.SelectedIndex = ComboBox_Display.Items.Count - 1
            Else
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next
        ComboBox_Display.EndUpdate()

        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\")
        End If

        If Not Directory.Exists(Application.StartupPath & "\Objects\All") Then
            Directory.CreateDirectory(Application.StartupPath & "\Objects\All")
        End If

        ComboBox_DesktopObjects.BeginUpdate()
        For Each dir As String In Directory.GetDirectories(Application.StartupPath & "\Objects")
            If Not Path.GetFileName(dir).ToLower = "all" Then
                ComboBox_DesktopObjects.Items.Add(Path.GetFileName(dir))
            End If
        Next
        ComboBox_DesktopObjects.Items.Add("All") ' Add all to the end of the list
        ComboBox_DesktopObjects.EndUpdate()
        ComboBox_DesktopObjects.SelectedIndex = 0
    End Sub
    ' LoadDesktopObjects()
    Private Sub LoadDesktopObjects(filepath As String)
        If Directory.Exists(filepath) Then
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.png", SearchOption.AllDirectories))
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.gif", SearchOption.AllDirectories))
            For Each item As String In FilesToCheck
                CreateNewPanel(item, Path.GetFileNameWithoutExtension(item))
            Next
            FlowLayoutPanel1.Visible = True
        End If
    End Sub
    ' Button_AllDesktopObjects - Click
    Private Sub Button_AllDesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_AllDesktopObjects.Click
        Dim FormListArray As Array = Form_Menu.FormList_DesktopObject.Keys.ToArray
        For Each item As String In FormListArray
            Form_Menu.FormList_DesktopObject(item).Close()
        Next
        Form_Menu.FormList_DesktopObject.Clear()
    End Sub
    ' ReloadToolStripMenuItem - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\")
        End If
    End Sub
    ' AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                Dim DesktopObject = New Form_DesktopObject
                Dim DesktopObjectFullPath As String = DirectCast(sender, PixelBox).Text.ToString
                DesktopObject.ObjectImage = New Bitmap(DesktopObjectFullPath)
                DesktopObject.PixelBox1.Image = DesktopObject.ObjectImage
                DesktopObject.Name = "DesktopObject"
                DesktopObject.Text = "Desktop Object - " & Path.GetFileNameWithoutExtension(DesktopObjectFullPath)
                Form_Menu.IDCounter_DesktopObject += 1
                Form_Menu.FormList_DesktopObject.Add(Form_Menu.IDCounter_DesktopObject.ToString, DesktopObject)
                DesktopObject.UniqueSessionID = Form_Menu.IDCounter_DesktopObject.ToString
                Form_Menu.FormList_DesktopObject(Form_Menu.IDCounter_DesktopObject.ToString).Show() ' DesktopObject.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms) 'Bitmap.FromStream(ms)
            Return img
        End Using
    End Function
    ' CreateNewPanel
    Private Sub CreateNewPanel(imagePath As String, assetObjectText As String)
        ' Panel
        Dim AssetPanel = New Panel
        AssetPanel.Size = New Size(AssetPanel_Size, AssetPanel_Size)
        AssetPanel.BackColor = Color.FromArgb(46, 49, 54)
        AssetPanel.Name = "AssetPanel1"

        ' Label
        Dim AssetLabel = New Label
        AssetLabel.AutoEllipsis = True
        AssetLabel.TextAlign = ContentAlignment.MiddleCenter
        AssetLabel.Dock = DockStyle.Bottom
        AssetLabel.Text = assetObjectText
        AssetLabel.ForeColor = Color.WhiteSmoke
        AssetLabel.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        AssetLabel.BackColor = Color.FromArgb(28, 30, 34)

        ' PixelBox
        Dim AssetPixelBox = New PixelBox
        AssetPixelBox.Dock = DockStyle.Fill
        AssetPixelBox.Image = Image.FromFile(imagePath) 'SafeImageFromFile(imagePath)
        AssetPixelBox.SizeMode = PictureBoxSizeMode.Zoom
        AssetPixelBox.Name = "PixelBox1"
        AssetPixelBox.Cursor = Cursors.Hand
        AssetPixelBox.Text = imagePath

        ' Add AssetLabel and AssetPixelBox to AssetPanel
        AssetPanel.Controls.Add(AssetPixelBox)
        AssetPanel.Controls.Add(AssetLabel)

        ' Add AssetPanel to FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Add(AssetPanel)

        AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
    End Sub
    ' Button1 - Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip2.Show(Button1, 4, 4)
    End Sub
    ' ResizePanels (sizeInt)
    Private Sub ResizePanels(sizeInt As Integer)
        AssetPanel_Size = sizeInt
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
    ' Small_ToolStripMenuItem - Click
    Private Sub Small_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Small_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = True
        ResizePanels(98)
    End Sub
    ' Medium_ToolStripMenuItem - Click
    Private Sub Medium_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Medium_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Medium_ToolStripMenuItem.Checked = True
        ResizePanels(128)
    End Sub
    ' MediumLarge_ToolStripMenuItem - Click
    Private Sub MediumLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        MediumLarge_ToolStripMenuItem.Checked = True
        ResizePanels(150)
    End Sub
    ' Large_ToolStripMenuItem - Click
    Private Sub Large_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Large_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Large_ToolStripMenuItem.Checked = True
        ResizePanels(182)
    End Sub
    ' ExtraLarge_ToolStripMenuItem - Click
    Private Sub ExtraLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        ExtraLarge_ToolStripMenuItem.Checked = True
        ResizePanels(229)
    End Sub
    ' UnCheckAllSizes
    Private Sub UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = False
        Medium_ToolStripMenuItem.Checked = False
        MediumLarge_ToolStripMenuItem.Checked = False
        Large_ToolStripMenuItem.Checked = False
        ExtraLarge_ToolStripMenuItem.Checked = False
    End Sub
    ' ComboBox_DesktopObjects - SelectedIndexChanged
    Private Sub ComboBox_DesktopObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DesktopObjects.SelectedIndexChanged
        If Not ComboBox_DesktopObjects.SelectedIndex = -1 Then
            If Not ComboBox_DesktopObjects.SelectedItem.ToString = "All" Then
                LoadDesktopObjects(Application.StartupPath & "\Objects\" & ComboBox_DesktopObjects.SelectedItem.ToString)
            Else
                LoadDesktopObjects(Application.StartupPath & "\Objects\")
            End If
        End If
    End Sub
End Class