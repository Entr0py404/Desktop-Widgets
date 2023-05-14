'Imports MadMilkman.Ini
Public Class Form_Pets
    Dim FlyingPetsCount As Integer = 0
    Dim GroundPetsCount As Integer = 0
    'Form_Pets - Load
    Private Sub Form_Pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        ContextMenuStrip_GroundPets.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_FlyingPets.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        LoadGroundPets("Pets\Ground")
        LoadFlyingPets("Pets\Flying")
        Label_AssetCount.Text = GroundPetsCount & " Pets"

        'ComboBox_Display.Items.Add("ALL")
        For Each displays In Screen.AllScreens
            ComboBox_Display.Items.Add(displays.DeviceName.Replace("\\.\", ""))
        Next

        If ComboBox_Display.Items.Count >= 2 Then
            ComboBox_Display.Items.Add("ALL")
        End If

        ComboBox_Display.SelectedIndex = 0
    End Sub
    'LoadGroundPets()
    Private Sub LoadGroundPets(path As String)
        If Directory.Exists(path) Then
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            'Label_AssetCount.Text = "Pets"
            'Label_AssetCount.Update()
            'Label_Status.Text = "Loading Files..."
            'Label_Status.Refresh()
            GroundPetsCount = 0
            Dim dir As New DirectoryInfo(path)
            Dim directories As DirectoryInfo() = dir.GetDirectories().ToArray()
            For Each directory As DirectoryInfo In directories
                If File.Exists(path & "\" & directory.Name & "\Walking Right.gif") Then
                    CreateNewPanel(FlowLayoutPanel1, path & "\" & directory.Name & "\Walking Right.gif", directory.Name, Color.WhiteSmoke)
                    GroundPetsCount += 1
                    'Pets_ImageList.Images.Add(Image.FromFile(path & "\" & directory.Name & "\Idling Left.gif"))
                    'pets_ListView.Items.Add(directory.Name, Pets_ImageList.Images.Count - 1)
                End If
            Next
            'Label_Status.Text = "Load Completed."
            FlowLayoutPanel1.Visible = True
        End If
    End Sub
    'LoadFlyingPets()
    Private Sub LoadFlyingPets(path As String)
        If Directory.Exists(path) Then
            FlowLayoutPanel2.Visible = False
            FlowLayoutPanel2.Controls.Clear()
            'Label_AssetCount.Text = "Pets"
            'Label_AssetCount.Update()
            'Label_Status.Text = "Loading Files..."
            'Label_Status.Refresh()
            FlyingPetsCount = 0
            Dim dir As New DirectoryInfo(path)
            Dim directories As DirectoryInfo() = dir.GetDirectories().ToArray()
            For Each directory As DirectoryInfo In directories
                If File.Exists(path & "\" & directory.Name & "\Flying Right.gif") Then
                    CreateNewPanel(FlowLayoutPanel2, path & "\" & directory.Name & "\Flying Right.gif", directory.Name, Color.WhiteSmoke)
                    FlyingPetsCount += 1
                    'Pets_ImageList.Images.Add(Image.FromFile(path & "\" & directory.Name & "\Flying Left.gif"))
                    'pets_ListView.Items.Add(directory.Name, Pets_ImageList.Images.Count - 1)
                End If
            Next
            'Label_Status.Text = "Load Completed."
            FlowLayoutPanel2.Visible = True
        End If
    End Sub
    'ReloadToolStripMenuItem_FlyingPets - Click
    Private Sub ReloadToolStripMenuItem_FlyingPets_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem_FlyingPets.Click
        LoadFlyingPets("Pets\Flying")
    End Sub
    'ReloadToolStripMenuItem_GroundPets - Click
    Private Sub ReloadToolStripMenuItem_GroundPets_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem_GroundPets.Click
        LoadGroundPets("Pets\Ground")
    End Sub

    'TrackBar_ObjectScale - ValueChanged
    Private Sub TrackBar_ObjectScale_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_ObjectScale.ValueChanged
        Label_Scale.Text = TrackBar_ObjectScale.Value.ToString & "x"
    End Sub
    'Button_CloseSelected - Click
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
    'CloseAllWindowsbyName()
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
    'GroundPetsToolStripMenuItem - Click
    Private Sub GroundPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroundPetsToolStripMenuItem.Click
        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel2.Visible = False
        Label_AssetCount.Text = GroundPetsCount & " Pets"
        ResetToolStripMenuItemBackGroundColors()
        GroundPetsToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'FlyingPetsTextToolStripMenuItem - Click
    Private Sub FlyingPetsTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlyingPetsTextToolStripMenuItem.Click
        FlowLayoutPanel1.Visible = False
        FlowLayoutPanel2.Visible = True
        Label_AssetCount.Text = FlyingPetsCount & " Pets"
        ResetToolStripMenuItemBackGroundColors()
        FlyingPetsTextToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'ResetToolStripMenuItemBackGroundColors()
    Private Sub ResetToolStripMenuItemBackGroundColors()
        GroundPetsToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        FlyingPetsTextToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
    'DisplaySettingsChanged
    Public Sub DisplaySettingsChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not ComboBox_Display.Items.Count = Screen.AllScreens.Count Then
            ComboBox_Display.Items.Clear()
            For Each Displays In Screen.AllScreens
                ComboBox_Display.Items.Add(Displays.DeviceName.Replace("\\.\", ""))
            Next

            If ComboBox_Display.Items.Count >= 2 Then
                ComboBox_Display.Items.Add("ALL")
            End If
        End If
    End Sub






    'AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                Dim Form_GroundPetNew = New Form_GroundPet

                'Ground
                Dim PetPath As String = Path.GetDirectoryName(DirectCast(sender, PixelBox).Text.ToString)
                Console.WriteLine(PetPath)

                'Walking
                If File.Exists(PetPath & "\Walking Left.gif") Then
                    Form_GroundPetNew.Animation_Walking_Left = New Bitmap(PetPath & "\Walking Left.gif")
                End If
                If File.Exists(PetPath & "\Walking Right.gif") Then
                    Form_GroundPetNew.Animation_Walking_Right = New Bitmap(PetPath & "\Walking Right.gif")
                End If

                'Idling
                If File.Exists(PetPath & "\Idling Left.gif") Then
                    Form_GroundPetNew.Animation_Idling_Left = Image.FromFile(PetPath & "\Idling Left.gif")
                    Form_GroundPetNew.PixelBox_Pet.Image = Form_GroundPetNew.Animation_Idling_Left
                End If
                If File.Exists(PetPath & "\Idling Right.gif") Then
                    Form_GroundPetNew.Animation_Idling_Right = Image.FromFile(PetPath & "\Idling Right.gif")
                End If

                'Idling Alt
                If File.Exists(PetPath & "\Idling Alt Left.gif") Then
                    Form_GroundPetNew.Animation_IdlingAlt_Left = New Bitmap(PetPath & "\Idling Alt Left.gif")
                End If
                If File.Exists(PetPath & "\Idling Alt Right.gif") Then
                    Form_GroundPetNew.Animation_IdlingAlt_Right = New Bitmap(PetPath & "\Idling Alt Right.gif")
                End If

                'Dragging
                If File.Exists(PetPath & "\Dragging Left.gif") Then
                    Form_GroundPetNew.Animation_Dragging_Left = New Bitmap(PetPath & "\Dragging Left.gif")
                End If
                If File.Exists(PetPath & "\Dragging Right.gif") Then
                    Form_GroundPetNew.Animation_Dragging_Right = New Bitmap(PetPath & "\Dragging Right.gif")
                End If

                'Falling
                If File.Exists(PetPath & "\Falling Left.gif") Then
                    Form_GroundPetNew.Animation_Falling_Left = New Bitmap(PetPath & "\Falling Left.gif")
                End If
                If File.Exists(PetPath & "\Falling Right.gif") Then
                    Form_GroundPetNew.Animation_Falling_Right = New Bitmap(PetPath & "\Falling Right.gif")
                End If

                Form_GroundPetNew.PetDir = PetPath

                Form_GroundPetNew.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'AssetPanel2 - Click
    Private Sub PixelBox2_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                Dim Form_FlyingPetNew = New Form_FlyingPet

                'Flying
                Dim PetPath As String = Path.GetDirectoryName(DirectCast(sender, PixelBox).Text.ToString)

                If File.Exists(PetPath & "\Flying Left.gif") Then
                    Form_FlyingPetNew.Animation_Flying_Left = Image.FromFile(PetPath & "\Flying Left.gif")
                    Form_FlyingPetNew.PixelBox_Pet.Image = Form_FlyingPetNew.Animation_Flying_Left
                End If
                If File.Exists(PetPath & "\Flying Right.gif") Then
                    Form_FlyingPetNew.Animation_Flying_Right = Image.FromFile(PetPath & "\Flying Right.gif")
                End If

                'Walking
                If File.Exists(PetPath & "\Walking Left.gif") Then
                    Form_FlyingPetNew.Animation_Walking_Left = Image.FromFile(PetPath & "\Walking Left.gif")
                    Form_FlyingPetNew.HasAnimation_Walking = True
                End If
                If File.Exists(PetPath & "\Walking Right.gif") Then
                    Form_FlyingPetNew.Animation_Walking_Right = Image.FromFile(PetPath & "\Walking Right.gif")
                End If

                'Idling
                If File.Exists(PetPath & "\Idling Left.gif") Then
                    Form_FlyingPetNew.Animation_Idling_Left = Image.FromFile(PetPath & "\Idling Left.gif")
                    Form_FlyingPetNew.HasAnimation_Idling = True
                End If
                If File.Exists(PetPath & "\Idling Right.gif") Then
                    Form_FlyingPetNew.Animation_Idling_Right = Image.FromFile(PetPath & "\Idling Right.gif")
                End If

                'Idling Alt
                If File.Exists(PetPath & "\Idling Alt Left.gif") Then
                    Form_FlyingPetNew.Animation_IdlingAlt_Left = Image.FromFile(PetPath & "\Idling Alt Left.gif")
                    Form_FlyingPetNew.HasAnimation_IdlingAlt = True
                End If
                If File.Exists(PetPath & "\Idling Alt Right.gif") Then
                    Form_FlyingPetNew.Animation_IdlingAlt_Right = Image.FromFile(PetPath & "\Idling Alt Right.gif")
                End If

                'Hovering
                'If File.Exists(PetPath & "\Hovering.gif") Then
                'Form_FlyingPetNew.Animation_Hovering = Image.FromFile(PetPath & "Hovering.gif")
                'End If
                'If File.Exists(PetPath & "\Hovering Right.gif") Then
                'Form_FlyingPetNew.Animation_Hovering_Right = Image.FromFile(PetPath & "\Hovering Right.gif")
                'End If

                'Dragging
                If File.Exists(PetPath & "\Dragging.gif") Then
                    Form_FlyingPetNew.Animation_Dragging = Image.FromFile(PetPath & "\Dragging.gif")
                Else
                    Form_FlyingPetNew.Animation_Dragging = Image.FromFile(PetPath & "\Flying Right.gif") 'Fallback Animation
                End If
                'If File.Exists(PetPath & "\Dragging Right.gif") Then
                'Form_FlyingPetNew.Animation_Dragging = Image.FromFile(PetPath & "\Dragging Right.gif")
                'End If

                Form_FlyingPetNew.PetDir = PetPath

                Form_FlyingPetNew.Show()
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
    Private Sub CreateNewPanel(flowLayout As FlowLayoutPanel, imagePath As String, assetObjectText As String, textColor As Color)
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
        flowLayout.Controls.Add(AssetPanel)

        If flowLayout Is FlowLayoutPanel1 Then
            AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
        Else
            AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox2_MouseClick
        End If
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