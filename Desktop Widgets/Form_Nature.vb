Public Class Form_Nature
    Dim randNum As New Random
    Dim MYDisplay As Display
    'Form_Nature - Load
    Private Sub Form_Nature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                ComboBox_Display.SelectedIndex = ComboBox_Display.Items.Count - 1
                Console.WriteLine(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
            Else
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
                Console.WriteLine(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next
        Console.WriteLine()
        'For Each target In PathDisplayTarget.GetDisplayTargets()
        'ComboBox_Display.Items.Add(target.FriendlyName & " - " & target.ToDisplayDevice.DisplayName.Replace("\\.\", ""))
        'Next
        'ComboBox_Display.SelectedIndex = 0

        For Each display In Screen.AllScreens
            'ComboBox_Display.Items.Add(display.DeviceName.Replace("\\.\", ""))
            Console.WriteLine(display.DeviceName.Replace("\\.\", ""))
        Next

        Console.WriteLine()
        'For Each target In PathDisplayTarget.GetDisplayTargets()
        'Console.WriteLine(target.FriendlyName & " - " & target.ToDisplayDevice.DisplayName.Replace("\\.\", ""))
        'Next

        Dim dir As New DirectoryInfo(Application.StartupPath & "\Nature")
        Dim directories As DirectoryInfo() = dir.GetDirectories().ToArray()
        ComboBox_Theme.Items.AddRange(directories)
        If ComboBox_Theme.Items.Count > 0 Then
            ComboBox_Theme.SelectedIndex = 0
        End If

        If ComboBox_Theme.Items.Count > 0 Then
            ComboBox_Theme.Items.Add("All")
        End If

        Button_Randomize.PerformClick()
    End Sub
    'Button_Randomize - Click
    Private Sub Button_Randomize_Click(sender As Object, e As EventArgs) Handles Button_Randomize.Click
        'Min
        NumericUpDown_Flowers_Min.Value = randNum.Next(6, 15)
        NumericUpDown_Bushes_Min.Value = randNum.Next(2, 3)
        NumericUpDown_Trees_Min.Value = randNum.Next(2, 5)
        NumericUpDown_Rocks_Min.Value = randNum.Next(3, 5)
        NumericUpDown_Grass_Min.Value = randNum.Next(5, 10)
        'Max
        NumericUpDown_Flowers_Max.Value = randNum.Next(CInt(NumericUpDown_Flowers_Min.Value), 15)
        NumericUpDown_Bushes_Max.Value = randNum.Next(CInt(NumericUpDown_Bushes_Min.Value), 3)
        NumericUpDown_Trees_Max.Value = randNum.Next(CInt(NumericUpDown_Trees_Min.Value), 5)
        NumericUpDown_Rocks_Max.Value = randNum.Next(CInt(NumericUpDown_Rocks_Min.Value), 5)
        NumericUpDown_Grass_Max.Value = randNum.Next(CInt(NumericUpDown_Grass_Min.Value), 10)
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
                NatureObject.ObjectImage = New Bitmap(FilesToCheck.Item(randNum.Next(0, FilesToCheck.Count)).ToString)
                NatureObject.PixelBox1.Image = NatureObject.ObjectImage
                NatureObject.Name = "NatureObject"
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
    'TrackBar_ObjectScale - ValueChanged
    Private Sub TrackBar_ObjectScale_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_ObjectScale.ValueChanged
        Label_Scale.Text = TrackBar_ObjectScale.Value.ToString & "x"
    End Sub
    'ComboBox_Theme - SelectedIndexChanged
    Private Sub ComboBox_Theme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Theme.SelectedIndexChanged
        If Not ComboBox_Theme.SelectedIndex = -1 Then
            If Not ComboBox_Theme.SelectedItem.ToString = "All" Then
                LoadNatureObjects(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString, ListView_NatureObjects, ImageList_NatureObjects)
                Button_Generate.Enabled = True
            Else
                LoadNatureObjects(Application.StartupPath & "\Nature\", ListView_NatureObjects, ImageList_NatureObjects)
                Button_Generate.Enabled = False
            End If
        End If
    End Sub
    'LoadNatureObjects()
    Private Sub LoadNatureObjects(path As String, NatureObjects_ListView As ListView, NatureObjects_ImageList As ImageList)
        If Directory.Exists(path) Then
            NatureObjects_ImageList.Images.Clear()
            NatureObjects_ListView.Items.Clear()
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(path, "*.png", SearchOption.AllDirectories))
            FilesToCheck.AddRange(Directory.GetFiles(path, "*.gif", SearchOption.AllDirectories))
            For Each item As String In FilesToCheck
                NatureObjects_ImageList.Images.Add(Image.FromFile(item))
                NatureObjects_ListView.Items.Add(item, "", NatureObjects_ImageList.Images.Count - 1)
            Next
        End If
    End Sub
    'ListView_NatureObjects - ItemActivate
    Private Sub ListView_NatureObjects_ItemActivate(sender As Object, e As EventArgs) Handles ListView_NatureObjects.ItemActivate
        Dim NatureObject As New Form_NatureObject
        NatureObject.ObjectImage = New Bitmap(ListView_NatureObjects.SelectedItems(0).Name)
        NatureObject.PixelBox1.Image = NatureObject.ObjectImage
        NatureObject.Name = "NatureObject"
        NatureObject.MYScreen = MYDisplay.GetScreen().AllScreens(ComboBox_Display.SelectedIndex)
        Form_Menu.IDCounter_NatureObject += 1
        Form_Menu.FormList_NatureObject.Add(Form_Menu.IDCounter_NatureObject.ToString, NatureObject)
        NatureObject.UniqueSessionID = Form_Menu.IDCounter_NatureObject.ToString
        Form_Menu.FormList_NatureObject(Form_Menu.IDCounter_NatureObject.ToString).Show() 'NatureObject.Show()
    End Sub
    'ReloadToolStripMenuItem - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If Not ComboBox_Theme.SelectedIndex = -1 Then
            If Directory.Exists(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString) Then
                LoadNatureObjects(Application.StartupPath & "\Nature\" & ComboBox_Theme.SelectedItem.ToString, ListView_NatureObjects, ImageList_NatureObjects)
            End If
        End If
    End Sub
    'ToolStripMenuItem1 - Click
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ComboBox_Theme.Items.Clear()
        Dim dir As New DirectoryInfo(Application.StartupPath & "\Nature")
        Dim directories As DirectoryInfo() = dir.GetDirectories().ToArray()
        ComboBox_Theme.Items.AddRange(directories)
        If ComboBox_Theme.Items.Count > 0 Then
            ComboBox_Theme.SelectedIndex = 0
        End If
    End Sub
End Class