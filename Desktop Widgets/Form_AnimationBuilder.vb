Imports AnimatedGif

Public Class Form_AnimationBuilder
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}

    'Form2 - Load
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        NumericUpDown_Delay.Controls.RemoveAt(0)
    End Sub
    'Panel1 - DragDrop
    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                ClearAllUIObjects()
                'Dim MyMemoryStream1 As New MemoryStream
                'Dim MyMemoryStream2 As New MemoryStream
                'Dim MyAnimatedGif_Left As New AnimatedGifCreator(MyMemoryStream1, CInt(NumericUpDown_Delay.Value), 0)
                'Dim MyAnimatedGif_Right As New AnimatedGifCreator(MyMemoryStream2, CInt(NumericUpDown_Delay.Value), 0)
                ListBox_Images.BeginUpdate()
                ''Using gif = AnimatedGif.AnimatedGif.Create("mygif.gif", 33)
                For Each item As String In files
                    ListBox_Images.Items.Add(item)
                    'gif.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)
                    'MyAnimatedGif_Left.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)
                    'Dim tempImage As Image
                    'tempImage = Image.FromFile(item)
                    'tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    'MyAnimatedGif_Right.AddFrame(tempImage, delay:=-1, quality:=GifQuality.Bit8)
                Next
                ''End Using
                ListBox_Images.EndUpdate()
                Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
                CreateAnimatedGifs()
                'PixelBox_Left.Image = Image.FromStream(MyMemoryStream1)
                'PixelBox_Right.Image = Image.FromStream(MyMemoryStream2)
                ''PixelBox1.Image = Image.FromFile("mygif.gif")
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_Image - DragEnter
    Private Sub Panel_Image_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedIamgeFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'CreateAnimatedGifs()
    Private Sub CreateAnimatedGifs()
        Dim MyMemoryStream1 As New MemoryStream
        Dim MyMemoryStream2 As New MemoryStream
        Dim MyAnimatedGif1 As New AnimatedGifCreator(MyMemoryStream1, CInt(NumericUpDown_Delay.Value), 0)
        Dim MyAnimatedGif2 As New AnimatedGifCreator(MyMemoryStream2, CInt(NumericUpDown_Delay.Value), 0)

        'Using gif = AnimatedGif.AnimatedGif.Create("mygif.gif", 33)
        For Each item As String In ListBox_Images.Items
            'gif.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)
            MyAnimatedGif1.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)

            Dim tempImage As Image
            tempImage = Image.FromFile(item)
            tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)

            MyAnimatedGif2.AddFrame(tempImage, delay:=-1, quality:=GifQuality.Bit8)
        Next
        'End Using

        If RadioButton_FacingRight.Checked Then
            PixelBox_Left.Image = Image.FromStream(MyMemoryStream2)
            PixelBox_Right.Image = Image.FromStream(MyMemoryStream1)
        Else
            PixelBox_Left.Image = Image.FromStream(MyMemoryStream1)
            PixelBox_Right.Image = Image.FromStream(MyMemoryStream2)
        End If

        'PixelBox1.Image = Image.FromFile("mygif.gif")
    End Sub
    'NumericUpDown_Delay - ValueChanged
    Private Sub NumericUpDown_Delay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Delay.ValueChanged
        If ListBox_Images.Items.Count > 0 Then
            CreateAnimatedGifs()
        End If
    End Sub
    'Button_SetDelay - Click
    Private Sub Button_SetDelay_Click(sender As Object, e As EventArgs)
        If ListBox_Images.Items.Count > 0 Then
            CreateAnimatedGifs()
        End If
    End Sub
    'RadioButton_TypeGroundPet - CheckedChanged
    Private Sub RadioButton_PetTypeGround_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeGroundPet.CheckedChanged
        If RadioButton_TypeGroundPet.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Animation.Enabled = True
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
            ComboBox_Animation.Items.Add("Falling")
            ComboBox_Animation.SelectedIndex = 0
            Panel_Left.Visible = True
            ComboBox_Name.Items.Clear()
            ComboBox_Name.BeginUpdate()
            For Each PetDir As String In Directory.GetDirectories(Application.StartupPath & "\Pets\Ground")
                ComboBox_Name.Items.Add(Path.GetFileName(PetDir))
            Next
            ComboBox_Name.EndUpdate()
        End If
    End Sub
    'RadioButton_TypeFlyingPet - CheckedChanged
    Private Sub RadioButton_TypeFlyingPet_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeFlyingPet.CheckedChanged
        If RadioButton_TypeFlyingPet.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Animation.Enabled = True
            ComboBox_Animation.Items.Add("Flying")
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
            ComboBox_Animation.SelectedIndex = 0
            Panel_Left.Visible = True
            ComboBox_Name.Items.Clear()
            ComboBox_Name.BeginUpdate()
            For Each PetDir As String In Directory.GetDirectories(Application.StartupPath & "\Pets\Flying")
                ComboBox_Name.Items.Add(Path.GetFileName(PetDir))
            Next
            ComboBox_Name.EndUpdate()
        End If
    End Sub
    'RadioButton_TypeObject - CheckedChanged
    Private Sub RadioButton_TypeObject_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeObject.CheckedChanged
        If RadioButton_TypeObject.Checked Then
            ComboBox_Animation.Enabled = False
            Panel_Left.Visible = False
        End If
    End Sub
    'RadioButton_TypeNature - CheckedChanged
    Private Sub RadioButton_TypeNature_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeNature.CheckedChanged
        If RadioButton_TypeNature.Checked Then
            ComboBox_Animation.Enabled = False
            Panel_Left.Visible = False
        End If
    End Sub
    'RadioButton_FacingLeft - CheckedChanged
    Private Sub RadioButton_FacingLeft_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_FacingLeft.CheckedChanged
        If ListBox_Images.Items.Count > 0 Then
            CreateAnimatedGifs()
        End If
    End Sub
    'NumericUpDown_Delay - KeyDown
    Private Sub NumericUpDown_Delay_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_Delay.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    'Clear (ToolStripMenuItem) - Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearAllUIObjects()
    End Sub
    'ClearAllUIObjects()
    Public Sub ClearAllUIObjects()
        PixelBox_Left.Image = Nothing
        PixelBox_Right.Image = Nothing
        ListBox_Images.Items.Clear()
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If PixelBox_Left.Image IsNot Nothing And ListBox_Images.Items.Count > 0 And ComboBox_Name.Text.Length > 0 Then
            If RadioButton_TypeGroundPet.Checked Then
                'Create Dir if needed
                If Not Directory.Exists(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text) Then
                    Directory.CreateDirectory(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text)
                End If

                PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                Console.WriteLine(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif")
                Console.WriteLine(Application.StartupPath & "\Pets\Ground\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif")
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                'Create Dir if needed
                If Not Directory.Exists(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text) Then
                    Directory.CreateDirectory(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text)
                End If

                PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                Console.WriteLine(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif")
                Console.WriteLine(Application.StartupPath & "\Pets\Flying\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif")
            ElseIf RadioButton_TypeObject.Checked Then

                If RadioButton_FacingRight.Checked Then
                    PixelBox_Right.Image.Save(Application.StartupPath & "\Objects\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    'savegif1(Application.StartupPath & "\Objects\" & ComboBox_Name.Text & ".gif")
                    'Else
                    'PixelBox_Left.Image.Save(Application.StartupPath & "\Objects\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    'savegif2(Application.StartupPath & "\Objects\" & ComboBox_Name.Text & ".gif")
                End If

            ElseIf RadioButton_TypeNature.Checked Then

                If RadioButton_FacingRight.Checked Then
                    PixelBox_Right.Image.Save(Application.StartupPath & "\Nature\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    'Else
                    'PixelBox_Left.Image.Save(Application.StartupPath & "\Nature\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                End If

            End If
            'Clear for Next
            ClearAllUIObjects()
        End If
    End Sub
    'savegif1
    Private Sub savegif1(filePath As String)
        Using gif = AnimatedGif.AnimatedGif.Create(filePath, CInt(NumericUpDown_Delay.Value), 0)
            For Each item As String In ListBox_Images.Items
                gif.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)
            Next
        End Using
    End Sub
    'savegif2
    Private Sub savegif2(filePath As String)
        Using gif = AnimatedGif.AnimatedGif.Create(filePath, CInt(NumericUpDown_Delay.Value), 0)
            For Each item As String In ListBox_Images.Items
                Dim tempImage As Image
                tempImage = Image.FromFile(item)
                tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                gif.AddFrame(tempImage, delay:=-1, quality:=GifQuality.Bit8)
            Next
        End Using
    End Sub

    Private Sub NumericUpDown_FPS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_FPS.ValueChanged
        If NumericUpDown_FPS.Focused Then
            Console.WriteLine(Int(1 / NumericUpDown_FPS.Value * 1000))
            NumericUpDown_Delay.Value = Int(1 / NumericUpDown_FPS.Value * 1000)
        End If
    End Sub
End Class