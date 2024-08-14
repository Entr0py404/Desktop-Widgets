
Public Class Form_Pets
    Dim FlyingPetsCount As Integer = 0
    Dim GroundPetsCount As Integer = 0
    Dim AssetPanel_Size As Integer = 98

    ' Form_Pets - Load
    Private Sub Form_Pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        LoadPetsDirs("Pets\Ground\", ComboBox_GroundPetObjects)
        LoadPetsDirs("Pets\Flying\", ComboBox_FlyingPetObjects)
        LoadGroundPets("Pets\Ground\" & ComboBox_GroundPetObjects.Text)

        ComboBox_Display.BeginUpdate()
        For Each Display As Display In Display.GetDisplays()
            If Display.IsGDIPrimary Then
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                ComboBox_Display.SelectedIndex = ComboBox_Display.Items.Count - 1
            Else
                ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
            End If
        Next

        If ComboBox_Display.Items.Count >= 2 Then
            ComboBox_Display.Items.Add("All")
        End If
        ComboBox_Display.EndUpdate()
    End Sub

    ' LoadPetsDirs()
    Private Sub LoadPetsDirs(Pet_Path As String, Artist_ComboBox As ComboBox)
        Artist_ComboBox.Items.Clear()
        Artist_ComboBox.BeginUpdate()
        For Each pet_directory As String In Directory.GetDirectories(Pet_Path)
            If Not Path.GetFileName(pet_directory).ToLower = "all" Then
                Artist_ComboBox.Items.Add(Path.GetFileName(pet_directory))
            End If
        Next
        Artist_ComboBox.Items.Add("All") ' Add all to the end of the list
        Artist_ComboBox.EndUpdate()
        Artist_ComboBox.SelectedIndex = 0
    End Sub

    ' LoadGroundPets()
    Private Sub LoadGroundPets(Pet_Path As String)
        If Directory.Exists(Pet_Path) Then
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            GroundPetsCount = 0
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(Pet_Path, "*.gif", SearchOption.AllDirectories))
            For Each Item As String In FilesToCheck
                If Path.GetFileName(Item) = "Idling Right.gif" Then
                    CreateNewPanel(FlowLayoutPanel1, Item, Path.GetFileName(Path.GetDirectoryName(Item)))
                    GroundPetsCount += 1
                End If
            Next
            If GroundPetsToolStripMenuItem.BackColor = Color.RoyalBlue Then
                FlowLayoutPanel1.Visible = True
            End If
        End If
    End Sub

    ' LoadFlyingPets()
    Private Sub LoadFlyingPets(Pet_Path As String)
        If Directory.Exists(Pet_Path) Then
            FlowLayoutPanel2.Visible = False
            FlowLayoutPanel2.Controls.Clear()
            FlyingPetsCount = 0
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(Pet_Path, "*.gif", SearchOption.AllDirectories))
            For Each Item As String In FilesToCheck
                If Path.GetFileName(Item) = "Flying Right.gif" Then
                    CreateNewPanel(FlowLayoutPanel2, Item, Path.GetFileName(Path.GetDirectoryName(Item)))
                    FlyingPetsCount += 1
                End If
            Next

            If FlyingPetsToolStripMenuItem.BackColor = Color.RoyalBlue Then
                FlowLayoutPanel2.Visible = True
            End If
        End If
    End Sub

    ' Button_CloseSelected - Click
    Private Sub Button_CloseSelected_Click(sender As Object, e As EventArgs) Handles Button_CloseSelected.Click
        If ComboBox1.SelectedItem.ToString = "All Pets" Then
            CloseAllWindowsByName("Form_GroundPet")
            CloseAllWindowsByName("Form_FlyingPet")
        ElseIf ComboBox1.SelectedItem.ToString = "Ground Pets" Then
            CloseAllWindowsByName("Form_GroundPet")
        ElseIf ComboBox1.SelectedItem.ToString = "Flying Pets" Then
            CloseAllWindowsByName("Form_FlyingPet")
        End If
    End Sub

    ' CloseAllWindowsbyName()
    Private Sub CloseAllWindowsByName(WindowName As String)
        Dim FormOpenCount As Integer = 0
        Dim lista As FormCollection = Application.OpenForms
        For Each a As Form In lista
            If a.Name = WindowName Then
                FormOpenCount += 1
            End If
        Next

        For i = 0 To FormOpenCount - 1
            My.Application.OpenForms.Item(WindowName).Close()
        Next
    End Sub

    ' GroundPetsToolStripMenuItem - Click
    Private Sub GroundPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroundPetsToolStripMenuItem.Click
        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel2.Visible = False
        ComboBox_GroundPetObjects.Visible = True
        ComboBox_FlyingPetObjects.Visible = False
        ResetToolStripMenuItemBackGroundColors()
        GroundPetsToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' FlyingPetsToolStripMenuItem - Click
    Private Sub FlyingPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlyingPetsToolStripMenuItem.Click
        FlowLayoutPanel1.Visible = False
        FlowLayoutPanel2.Visible = True
        ComboBox_GroundPetObjects.Visible = False
        ComboBox_FlyingPetObjects.Visible = True
        ResetToolStripMenuItemBackGroundColors()
        FlyingPetsToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' ResetToolStripMenuItemBackGroundColors()
    Private Sub ResetToolStripMenuItemBackGroundColors()
        GroundPetsToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        FlyingPetsToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub

    ' DisplaySettingsChanged
    Public Sub DisplaySettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not ComboBox_Display.Items.Count = Screen.AllScreens.Count Then ' Fix this because of All item!
            ComboBox_Display.Items.Clear()
            ComboBox_Display.BeginUpdate()
            For Each Display As Display In Display.GetDisplays()
                If Display.IsGDIPrimary Then
                    ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName & " (Primary)")
                    ComboBox_Display.SelectedIndex = ComboBox_Display.Items.Count - 1
                Else
                    ComboBox_Display.Items.Add(Display.ToPathDisplayTarget.FriendlyName)
                End If
            Next

            If ComboBox_Display.Items.Count >= 2 Then
                ComboBox_Display.Items.Add("All")
            End If
            ComboBox_Display.EndUpdate()
        End If
    End Sub

    ' AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                'Ground
                Dim Form_GroundPetNew = New Form_GroundPet
                Dim PetDir As String = Path.GetDirectoryName(DirectCast(sender, PixelBox).Text.ToString)
                Form_GroundPetNew.PetDir = PetDir
                Console.WriteLine(PetDir)
                Form_GroundPetNew.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' AssetPanel2 - Click
    Private Sub PixelBox2_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                'Flying
                Dim Form_FlyingPetNew = New Form_FlyingPet
                Dim PetDir As String = Path.GetDirectoryName(DirectCast(sender, PixelBox).Text.ToString)
                Form_FlyingPetNew.PetDir = PetDir
                Console.WriteLine(PetDir)
                Form_FlyingPetNew.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms) 'Bitmap.FromStream(ms) '
            Return img
        End Using
    End Function

    ' CreateNewPanel
    Private Sub CreateNewPanel(flowLayout As FlowLayoutPanel, imagePath As String, assetObjectText As String)
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
        flowLayout.Controls.Add(AssetPanel)

        If flowLayout Is FlowLayoutPanel1 Then
            AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
        Else
            AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox2_MouseClick
        End If
    End Sub

    ' Button1 - Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip2.Show(Button1, 4, 4)
    End Sub

    ' ResizePanels (sizeInt)
    Private Sub ResizePanels(sizeInt As Integer)
        'My.Settings.AssetPannelSize = sizeInt
        AssetPanel_Size = sizeInt
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Visible = False
        For Each oObj As Control In FlowLayoutPanel1.Controls
            Dim pPanel As Panel = CType(oObj, Panel)
            pPanel.Width = sizeInt
            pPanel.Height = sizeInt
        Next
        FlowLayoutPanel1.ResumeLayout()

        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel2.Visible = False
        For Each oObj As Control In FlowLayoutPanel2.Controls
            Dim pPanel As Panel = CType(oObj, Panel)
            pPanel.Width = sizeInt
            pPanel.Height = sizeInt
        Next
        FlowLayoutPanel2.ResumeLayout()

        If GroundPetsToolStripMenuItem.BackColor = Color.RoyalBlue Then
            FlowLayoutPanel1.Visible = True
        Else
            FlowLayoutPanel2.Visible = True
        End If
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

    ' ComboBox_GroundPetObjects - SelectedIndexChanged
    Private Sub ComboBox_GroundPetObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_GroundPetObjects.SelectedIndexChanged
        If Not ComboBox_GroundPetObjects.SelectedItem.ToString = "All" Then
            LoadGroundPets("Pets\Ground\" & ComboBox_GroundPetObjects.Text)
        Else
            LoadGroundPets("Pets\Ground\")
        End If
    End Sub

    ' ComboBox_FlyingPetObjects - SelectedIndexChanged
    Private Sub ComboBox_FlyingPetObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_FlyingPetObjects.SelectedIndexChanged
        If Not ComboBox_FlyingPetObjects.SelectedItem.ToString = "All" Then
            LoadFlyingPets("Pets\Flying\" & ComboBox_FlyingPetObjects.Text)
        Else
            LoadFlyingPets("Pets\Flying\")
        End If
    End Sub
End Class