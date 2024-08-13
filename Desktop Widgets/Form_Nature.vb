
Public Class Form_Nature
    Dim randNum As New Random
    Dim MYDisplay As Display
    Dim AssetPanel_Size As Integer = 98

    Dim Flowers_Min As Integer = 6
    Dim Bushes_Min As Integer = 2
    Dim Trees_Min As Integer = 2
    Dim Rocks_Min As Integer = 3
    Dim Grass_Min As Integer = 5

    Dim Flowers_Max As Integer = 15
    Dim Bushes_Max As Integer = 4
    Dim Trees_Max As Integer = 5
    Dim Rocks_Max As Integer = 5
    Dim Grass_Max As Integer = 10
    Dim DefaultScale As Integer = 1
    'Form_Nature - Load
    Private Sub Form_Nature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip3.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        ComboBox_Display.BeginUpdate()
        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                ComboBox_Display.SelectedIndex = ComboBox_Display.Items.Count - 1
                'Console.WriteLine(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
            Else
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
                'Console.WriteLine(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next
        ComboBox_Display.EndUpdate()
        'Console.WriteLine()

        If Not Directory.Exists(Application.StartupPath & "\Nature\All") Then
            Directory.CreateDirectory(Application.StartupPath & "\Nature\All")
        End If

        ComboBox_Theme.BeginUpdate()
        For Each dir As String In Directory.GetDirectories(Application.StartupPath & "\Nature")
            If Not Path.GetFileName(dir).ToLower = "all" Then
                ComboBox_Theme.Items.Add(Path.GetFileName(dir))
            End If
        Next
        ComboBox_Theme.Items.Add("All") 'Add all to the end of the list
        ComboBox_Theme.EndUpdate()
        ComboBox_Theme.SelectedIndex = 0

        Button_Randomize.PerformClick()
    End Sub
    'Button_Randomize - Click
    Private Sub Button_Randomize_Click(sender As Object, e As EventArgs) Handles Button_Randomize.Click
        'Maximum
        NumericUpDown_Flowers_Min.Maximum = 100
        NumericUpDown_Bushes_Min.Maximum = 100
        NumericUpDown_Trees_Min.Maximum = 100
        NumericUpDown_Rocks_Min.Maximum = 100
        NumericUpDown_Grass_Min.Maximum = 100
        'Min
        NumericUpDown_Flowers_Min.Value = randNum.Next(Flowers_Min, Flowers_Max + 1)
        NumericUpDown_Bushes_Min.Value = randNum.Next(Bushes_Min, Bushes_Max + 1)
        NumericUpDown_Trees_Min.Value = randNum.Next(Trees_Min, Trees_Max + 1)
        NumericUpDown_Rocks_Min.Value = randNum.Next(Rocks_Min, Rocks_Max + 1)
        NumericUpDown_Grass_Min.Value = randNum.Next(Grass_Min, Grass_Max + 1)
        'Max
        NumericUpDown_Flowers_Max.Value = randNum.Next(CInt(NumericUpDown_Flowers_Min.Value), Flowers_Max + 1)
        NumericUpDown_Bushes_Max.Value = randNum.Next(CInt(NumericUpDown_Bushes_Min.Value), Bushes_Max + 1)
        NumericUpDown_Trees_Max.Value = randNum.Next(CInt(NumericUpDown_Trees_Min.Value), Trees_Max + 1)
        NumericUpDown_Rocks_Max.Value = randNum.Next(CInt(NumericUpDown_Rocks_Min.Value), Rocks_Max + 1)
        NumericUpDown_Grass_Max.Value = randNum.Next(CInt(NumericUpDown_Grass_Min.Value), Grass_Max + 1)
        'Maximum
        NumericUpDown_Flowers_Min.Maximum = NumericUpDown_Flowers_Max.Value
        NumericUpDown_Bushes_Min.Maximum = NumericUpDown_Bushes_Max.Value
        NumericUpDown_Trees_Min.Maximum = NumericUpDown_Trees_Max.Value
        NumericUpDown_Rocks_Min.Maximum = NumericUpDown_Rocks_Max.Value
        NumericUpDown_Grass_Min.Maximum = NumericUpDown_Grass_Max.Value
    End Sub
    'Button_Generate - Click
    Private Sub Button_Generate_Click(sender As Object, e As EventArgs) Handles Button_Generate.Click
        Dim NatureObjectPath As String = Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString
        'Main Grass
        'If File.Exists(NatureObjectPath & "\Grass.png") Then
        'Dim NatureObject = New Form_NatureObject
        'NatureObject.ObjectImage = New Bitmap(NatureObjectPath & "\Grass.png")
        'NatureObject.PixelBox1.BackgroundImage = NatureObject.ObjectImage
        'NatureObject.isMainGrass = True
        'NatureObject.Show()
        'ElseIf File.Exists(NatureObjectPath & "\Grass.gif") Then
        'Dim NatureObject = New Form_NatureObject
        'NatureObject.ObjectImage = New Bitmap(NatureObjectPath & "\Grass.gif")
        'NatureObject.PixelBox1.BackgroundImage = NatureObject.ObjectImage
        'NatureObject.isMainGrass = True
        'NatureObject.Show()
        'End If

        'Flowers
        GenerateNature("Flowers", CInt(NumericUpDown_Flowers_Min.Value), CInt(NumericUpDown_Flowers_Max.Value))
        'Bushes
        GenerateNature("Bushes", CInt(NumericUpDown_Bushes_Min.Value), CInt(NumericUpDown_Bushes_Max.Value))
        'Trees
        GenerateNature("Trees", CInt(NumericUpDown_Trees_Min.Value), CInt(NumericUpDown_Trees_Max.Value))
        'Rocks
        GenerateNature("Rocks", CInt(NumericUpDown_Rocks_Min.Value), CInt(NumericUpDown_Rocks_Max.Value))
        'Grass
        GenerateNature("Grass", CInt(NumericUpDown_Grass_Min.Value), CInt(NumericUpDown_Grass_Max.Value))

        Button_Generate.Enabled = False
    End Sub
    'GenerateNature()
    Private Sub GenerateNature(NatureFolder As String, randMin As Integer, randMax As Integer)
        If Directory.Exists(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString & "\" & NatureFolder) Then
            Dim FilesToCheck As New ArrayList()
            Dim NatureObjectPath As String = Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString
            FilesToCheck.Clear()
            FilesToCheck.AddRange(Directory.GetFiles(NatureObjectPath & "\" & NatureFolder, "*.png", SearchOption.TopDirectoryOnly))
            FilesToCheck.AddRange(Directory.GetFiles(NatureObjectPath & "\" & NatureFolder, "*.gif", SearchOption.TopDirectoryOnly))
            For i = 1 To randNum.Next(randMin, randMax)
                Dim NatureObject = New Form_NatureObject
                Dim NatureObjectFullPath As String = FilesToCheck.Item(randNum.Next(0, FilesToCheck.Count)).ToString
                NatureObject.ObjectImage = New Bitmap(NatureObjectFullPath)
                NatureObject.PixelBox1.Image = NatureObject.ObjectImage
                NatureObject.Name = "NatureObject"
                NatureObject.Text = "Nature Object - " & Path.GetFileNameWithoutExtension(NatureObjectFullPath)
                NatureObject.DefaultScale = DefaultScale
                Form_Menu.IDCounter_NatureObject += 1
                Form_Menu.FormList_NatureObject.Add(Form_Menu.IDCounter_NatureObject.ToString, NatureObject)
                NatureObject.UniqueSessionID = Form_Menu.IDCounter_NatureObject.ToString
                Form_Menu.FormList_NatureObject(Form_Menu.IDCounter_NatureObject.ToString).Show() 'NatureObject.Show()
            Next
        End If
    End Sub
    'Button_CloseAll - Click
    Private Sub Button_CloseAll_Click(sender As Object, e As EventArgs) Handles Button_CloseAll.Click
        Dim FormListArray As Array = Form_Menu.FormList_NatureObject.Keys.ToArray
        For Each item As String In FormListArray
            Form_Menu.FormList_NatureObject(item).Close()
        Next
        Form_Menu.FormList_NatureObject.Clear()
        Button_Generate.Enabled = True
    End Sub
    'ComboBox_Theme - SelectedIndexChanged
    Private Sub ComboBox_Theme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Theme.SelectedIndexChanged
        If Not ComboBox_Theme.SelectedIndex = -1 Then
            If Not ComboBox_Theme.SelectedItem.ToString = "All" Then
                LoadNatureObjects(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString)
                Button_Generate.Enabled = True
            Else
                LoadNatureObjects(Application.StartupPath & "\Nature\")
                Button_Generate.Enabled = False
            End If

            If File.Exists(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString & "\Theme.ini") Then
                Dim INI As New MadMilkman.Ini.IniFile()
                INI.Load(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString & "\Theme.ini")

                DefaultScale = CInt(INI.Sections("Settings").Keys("DefaultScale").Value)

                Flowers_Min = CInt(INI.Sections("Randomization_Min").Keys("Flowers").Value)
                Bushes_Min = CInt(INI.Sections("Randomization_Min").Keys("Bushes").Value)
                Trees_Min = CInt(INI.Sections("Randomization_Min").Keys("Trees").Value)
                Rocks_Min = CInt(INI.Sections("Randomization_Min").Keys("Rocks").Value)
                Grass_Min = CInt(INI.Sections("Randomization_Min").Keys("Grass").Value)

                Flowers_Max = CInt(INI.Sections("Randomization_Max").Keys("Flowers").Value)
                Bushes_Max = CInt(INI.Sections("Randomization_Max").Keys("Bushes").Value)
                Trees_Max = CInt(INI.Sections("Randomization_Max").Keys("Trees").Value)
                Rocks_Max = CInt(INI.Sections("Randomization_Max").Keys("Rocks").Value)
                Grass_Max = CInt(INI.Sections("Randomization_Max").Keys("Grass").Value)

                Button_Randomize.PerformClick()
            End If
        End If
    End Sub
    'LoadNatureObjects()
    Private Sub LoadNatureObjects(filepath As String)
        If Directory.Exists(filepath) Then
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            Label_AssetCount.Text = "0 Nature Objects"
            Label_AssetCount.Update()
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.png", SearchOption.AllDirectories))
            FilesToCheck.AddRange(Directory.GetFiles(filepath, "*.gif", SearchOption.AllDirectories))
            For Each item As String In FilesToCheck
                CreateNewPanel(item, Path.GetFileNameWithoutExtension(item))
            Next
            Label_AssetCount.Text = FilesToCheck.Count.ToString & " Nature Objects"
            FlowLayoutPanel1.Visible = True
        End If
    End Sub
    'AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                Dim NatureObject As New Form_NatureObject
                Dim NatureObjectFullPath As String = DirectCast(sender, PixelBox).Text.ToString
                NatureObject.ObjectImage = New Bitmap(DirectCast(sender, PixelBox).Text.ToString)
                NatureObject.PixelBox1.Image = NatureObject.ObjectImage
                NatureObject.Name = "NatureObject"
                NatureObject.Text = "Nature Object - " & Path.GetFileNameWithoutExtension(NatureObjectFullPath)
                Form_Menu.IDCounter_NatureObject += 1
                Form_Menu.FormList_NatureObject.Add(Form_Menu.IDCounter_NatureObject.ToString, NatureObject)
                NatureObject.UniqueSessionID = Form_Menu.IDCounter_NatureObject.ToString
                Form_Menu.FormList_NatureObject(Form_Menu.IDCounter_NatureObject.ToString).Show() 'NatureObject.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function
    'CreateNewPanel
    Private Sub CreateNewPanel(imagePath As String, assetObjectText As String)
        'Panel
        Dim AssetPanel = New Panel
        AssetPanel.Size = New Size(AssetPanel_Size, AssetPanel_Size)
        AssetPanel.BackColor = Color.FromArgb(46, 49, 54)
        AssetPanel.Name = "AssetPanel1"

        'Label
        Dim AssetLabel = New Label
        AssetLabel.AutoEllipsis = True
        AssetLabel.TextAlign = ContentAlignment.MiddleCenter
        AssetLabel.Dock = DockStyle.Bottom
        AssetLabel.Text = assetObjectText
        AssetLabel.ForeColor = Color.WhiteSmoke
        AssetLabel.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        AssetLabel.BackColor = Color.FromArgb(28, 30, 34)

        'PixelBox
        Dim AssetPixelBox = New PixelBox
        AssetPixelBox.Dock = DockStyle.Fill
        AssetPixelBox.Image = Image.FromFile(imagePath) 'SafeImageFromFile(imagePath)
        AssetPixelBox.SizeMode = PictureBoxSizeMode.Zoom
        AssetPixelBox.Name = "PixelBox1"
        AssetPixelBox.Cursor = Cursors.Hand
        AssetPixelBox.Text = imagePath

        'Add AssetLabel and AssetPixelBox to AssetPanel
        AssetPanel.Controls.Add(AssetPixelBox)
        AssetPanel.Controls.Add(AssetLabel)

        'Add AssetPanel to FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Add(AssetPanel)

        AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
    End Sub
    'Button1 - Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip3.Show(Button1, 4, 4)
    End Sub
    'ResizePanels (sizeInt)
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
    'NumericUpDown_Flowers_Max - ValueChanged
    Private Sub NumericUpDown_Flowers_Max_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Flowers_Max.ValueChanged
        NumericUpDown_Flowers_Min.Maximum = NumericUpDown_Flowers_Max.Value
    End Sub
    'NumericUpDown_Bushes_Max - ValueChanged
    Private Sub NumericUpDown_Bushes_Max_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Bushes_Max.ValueChanged
        NumericUpDown_Bushes_Min.Maximum = NumericUpDown_Bushes_Max.Value
    End Sub
    'NumericUpDown_Trees_Max_ValueChanged
    Private Sub NumericUpDown_Trees_Max_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Trees_Max.ValueChanged
        NumericUpDown_Trees_Min.Maximum = NumericUpDown_Trees_Max.Value
    End Sub
    'NumericUpDown_Rocks_Max - ValueChanged
    Private Sub NumericUpDown_Rocks_Max_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Rocks_Max.ValueChanged
        NumericUpDown_Rocks_Min.Maximum = NumericUpDown_Rocks_Max.Value
    End Sub
    'NumericUpDown_Grass_Max - ValueChanged
    Private Sub NumericUpDown_Grass_Max_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Grass_Max.ValueChanged
        NumericUpDown_Grass_Min.Maximum = NumericUpDown_Grass_Max.Value
    End Sub
End Class