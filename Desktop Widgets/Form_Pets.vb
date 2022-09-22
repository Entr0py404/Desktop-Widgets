'Imports MadMilkman.Ini
'Imports System.Speech.Synthesis
Public Class Form_Pets
    'Dim TTS As SpeechSynthesizer = New SpeechSynthesizer

    'Form_Pets - Load
    Private Sub Form_Pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TTS.Rate = -2
        'TTS.Volume = 65
        'TTS.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult)
        'TTS.SpeakAsync("Hello")
        ComboBox1.SelectedIndex = 0
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        Me.TabControl1.Region = New Region(New RectangleF(Me.TabPage_GroundPets.Left, Me.TabPage_GroundPets.Top, Me.TabPage_GroundPets.Width, Me.TabPage_GroundPets.Height))

        ContextMenuStrip_GroundPets.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_FlyingPets.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        LoadPets("Pets\Ground", ListView_GroundPets, ImageList_GroundPets)
        LoadPets("Pets\Flying", ListView_FlyingPets, ImageList_FlyingPets)

        'ComboBox_Display.Items.Add("ALL")
        For Each displays In Screen.AllScreens
            ComboBox_Display.Items.Add(displays.DeviceName.Replace("\\.\", ""))
        Next

        If ComboBox_Display.Items.Count >= 2 Then
            ComboBox_Display.Items.Add("ALL")
        End If

        ComboBox_Display.SelectedIndex = 0
    End Sub
    'LoadPets()
    Private Sub LoadPets(path As String, pets_ListView As ListView, Pets_ImageList As ImageList)
        If Directory.Exists(path) Then
            Pets_ImageList.Images.Clear()
            pets_ListView.Items.Clear()
            Dim dir As New DirectoryInfo(path)
            Dim directories As DirectoryInfo() = dir.GetDirectories().ToArray()
            For Each directory As DirectoryInfo In directories
                If path = "Pets\Ground" Then
                    If File.Exists(path & "\" & directory.Name & "\Walking Left.gif") Then
                        Pets_ImageList.Images.Add(Image.FromFile(path & "\" & directory.Name & "\Idling Left.gif"))
                        pets_ListView.Items.Add(directory.Name, Pets_ImageList.Images.Count - 1)
                    End If
                Else
                    If File.Exists(path & "\" & directory.Name & "\Flying Left.gif") Then
                        Pets_ImageList.Images.Add(Image.FromFile(path & "\" & directory.Name & "\Flying Left.gif"))
                        pets_ListView.Items.Add(directory.Name, Pets_ImageList.Images.Count - 1)
                    End If
                End If
            Next
        End If
    End Sub
    'CheckBox_FollowCursor - CheckedChanged
    Private Sub CheckBox_FollowCursor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_FollowCursor.CheckedChanged
        If CheckBox_FollowCursor.Checked Then
            'myForm.FollowCursor = True
            'myForm2.FollowCursor = True
        Else
            'myForm.FollowCursor = False
            'myForm2.FollowCursor = False
        End If
    End Sub
    'CheckBox1 - CheckedChanged
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_TopMost.CheckedChanged
        If CheckBox_TopMost.Checked Then
            'Form_GroundPet.TopMost = True
        Else
            'Form_GroundPet.TopMost = False
        End If
    End Sub
    'ListView_GroundPets - ItemActivate
    Private Sub ListView_GroundPets_ItemActivate(sender As Object, e As EventArgs) Handles ListView_GroundPets.ItemActivate
        Dim Form_GroundPetNew = New Form_GroundPet

        'Ground
        Dim PetPath As String = "Pets\Ground\" & ListView_GroundPets.SelectedItems.Item(0).Text

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

        Form_GroundPetNew.Show()
    End Sub
    'ListView_FlyingPets - ItemActivate
    Private Sub ListView_FlyingPets_ItemActivate(sender As Object, e As EventArgs) Handles ListView_FlyingPets.ItemActivate
        Dim Form_FlyingPetNew = New Form_FlyingPet

        'Flying
        Dim PetPath As String = "Pets\Flying\" & ListView_FlyingPets.SelectedItems.Item(0).Text

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
        Form_FlyingPetNew.Show()
    End Sub
    'ReloadToolStripMenuItem_FlyingPets - Click
    Private Sub ReloadToolStripMenuItem_FlyingPets_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem_FlyingPets.Click
        LoadPets("Pets\Flying", ListView_FlyingPets, ImageList_FlyingPets)
    End Sub
    'ReloadToolStripMenuItem_GroundPets - Click
    Private Sub ReloadToolStripMenuItem_GroundPets_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem_GroundPets.Click
        LoadPets("Pets\Ground", ListView_GroundPets, ImageList_GroundPets)
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
        TabControl1.SelectedTab = TabPage_GroundPets
        ResetToolStripMenuItemBackGroundColors()
        GroundPetsToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'FlyingPetsTextToolStripMenuItem - Click
    Private Sub FlyingPetsTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlyingPetsTextToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_FlyingPets
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
End Class