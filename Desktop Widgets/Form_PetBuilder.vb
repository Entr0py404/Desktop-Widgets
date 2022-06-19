Imports AnimatedGif

Public Class Form_PetBuilder
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}

    'Form2 - Load
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown_Delay.Controls.RemoveAt(0)
    End Sub
    'Panel1 - DragDrop
    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
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
    Private Sub Button_SetDelay_Click(sender As Object, e As EventArgs) Handles Button_SetDelay.Click
        If ListBox_Images.Items.Count > 0 Then
            CreateAnimatedGifs()
        End If
    End Sub
    'RadioButton_PetTypeGround - CheckedChanged
    Private Sub RadioButton_PetTypeGround_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_PetTypeGround.CheckedChanged
        ComboBox_Animation.Items.Clear()
        If RadioButton_PetTypeGround.Checked Then
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
            ComboBox_Animation.Items.Add("Falling")
        Else
            ComboBox_Animation.Items.Add("Flying")
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
        End If
        ComboBox_Animation.SelectedIndex = 0
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
        If PixelBox_Left.Image IsNot Nothing And ListBox_Images.Items.Count > 0 And TextBox_Name.Text.Length > 0 Then
            If RadioButton_PetTypeGround.Checked Then
                'Create Dir if needed
                If Not Directory.Exists(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text) Then
                    Directory.CreateDirectory(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text)
                End If

                PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                Console.WriteLine(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif")
                Console.WriteLine(Application.StartupPath & "\Pets\Ground\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif")
            Else
                'Create Dir if needed
                If Not Directory.Exists(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text) Then
                    Directory.CreateDirectory(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text)
                End If

                PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                Console.WriteLine(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif")
                Console.WriteLine(Application.StartupPath & "\Pets\Flying\" & TextBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif")
            End If
            'Clear for Next
            ClearAllUIObjects()
        End If
    End Sub
End Class