Imports System.Text
Imports AnimatedGif

Public Class Form_AnimationBuilder
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim Flipped As Boolean = False

    ' Form_AnimationBuilder - Load
    Private Sub Form_AnimationBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory)
        Console.WriteLine(Application.StartupPath)
        'Optimization Tools
    End Sub

    ' Panel_Main - DragDrop
    Private Sub Panel_Main_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_Main.DragDrop
        Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                ClearAllUIObjects()
                ListBox_Images.BeginUpdate()
                For Each item As String In files
                    ListBox_Images.Items.Add(item)
                Next
                ListBox_Images.EndUpdate()
                Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
                CreateAnimatedGifs()
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Panel_Image - DragEnter
    Private Sub Panel_Image_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_Main.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedIamgeFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' CreateAnimatedGifs()
    Private Sub CreateAnimatedGifs()
        Dim MyMemoryStream1 As New MemoryStream
        Dim MyMemoryStream2 As New MemoryStream
        Dim MyAnimatedGif1 As New AnimatedGifCreator(MyMemoryStream1, CInt(NumericUpDown_Delay.Value), 0)
        Dim MyAnimatedGif2 As New AnimatedGifCreator(MyMemoryStream2, CInt(NumericUpDown_Delay.Value), 0)

        For Each item As String In ListBox_Images.Items
            MyAnimatedGif1.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)

            Dim tempImage As Image
            tempImage = Image.FromFile(item)
            tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)

            MyAnimatedGif2.AddFrame(tempImage, delay:=-1, quality:=GifQuality.Bit8)
        Next

        If Flipped = True Then
            PixelBox_Left.Image = Image.FromStream(MyMemoryStream1)
            PixelBox_Right.Image = Image.FromStream(MyMemoryStream2)
        Else
            PixelBox_Right.Image = Image.FromStream(MyMemoryStream1)
            PixelBox_Left.Image = Image.FromStream(MyMemoryStream2)
        End If

    End Sub

    ' NumericUpDown_Delay - ValueChanged
    Private Sub NumericUpDown_Delay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Delay.ValueChanged
        If ListBox_Images.Items.Count > 0 Then
            CreateAnimatedGifs()
        End If
    End Sub

    ' LoadDirs
    Private Sub LoadDirs(DirPath As String)
        ComboBox_Artist.Items.Clear()
        ComboBox_Artist.BeginUpdate()
        For Each PetDir As String In Directory.GetDirectories(DirPath)
            If Not Path.GetFileName(PetDir).ToLower = "all" Then
                ComboBox_Artist.Items.Add(Path.GetFileName(PetDir))
            End If
        Next
        ComboBox_Artist.Items.Add("All")
        ComboBox_Artist.EndUpdate()
    End Sub

    ' LoadDirs
    Private Sub LoadFiles(DirPath As String)
        ComboBox_Name.Items.Clear()
        ComboBox_Name.BeginUpdate()
        For Each PetFile As String In Directory.GetFiles(DirPath)
            ComboBox_Name.Items.Add(Path.GetFileNameWithoutExtension(PetFile))
        Next
        ComboBox_Name.EndUpdate()
    End Sub

    ' RadioButton_TypeGroundPet - CheckedChanged
    Private Sub RadioButton_PetTypeGround_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeGroundPet.CheckedChanged
        If RadioButton_TypeGroundPet.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Animation.Enabled = True
            ComboBox_Animation.BeginUpdate()
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
            ComboBox_Animation.Items.Add("Falling")
            ComboBox_Animation.Items.Add("Sleeping")
            ComboBox_Animation.EndUpdate()
            ComboBox_Animation.SelectedIndex = 0
            CheckBox_NonDirectional.Visible = False
            Panel_Right.Visible = True
            Label_Left.Visible = True
            ComboBox_Name.Text = ""
            ComboBox_Name.Items.Clear()
            Label_Artist.Text = "Artist:"
            Label_Animation.Text = "Animation:"
            LoadDirs(Application.StartupPath & "\Pets\Ground")
            Button_OptimizePNGs.Enabled = False
        End If
    End Sub

    ' RadioButton_TypeFlyingPet - CheckedChanged
    Private Sub RadioButton_TypeFlyingPet_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeFlyingPet.CheckedChanged
        If RadioButton_TypeFlyingPet.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Animation.Enabled = True
            ComboBox_Animation.BeginUpdate()
            ComboBox_Animation.Items.Add("Flying")
            ComboBox_Animation.Items.Add("Walking")
            ComboBox_Animation.Items.Add("Idling")
            ComboBox_Animation.Items.Add("Idling Alt")
            ComboBox_Animation.Items.Add("Dragging")
            ComboBox_Animation.EndUpdate()
            ComboBox_Animation.SelectedIndex = 0
            CheckBox_NonDirectional.Visible = False
            Panel_Right.Visible = True
            Label_Left.Visible = True
            ComboBox_Name.Text = ""
            ComboBox_Name.Items.Clear()
            Label_Artist.Text = "Artist:"
            Label_Animation.Text = "Animation:"
            LoadDirs(Application.StartupPath & "\Pets\Flying")
            Button_OptimizePNGs.Enabled = False
        End If
    End Sub

    ' RadioButton_TypeObject - CheckedChanged
    Private Sub RadioButton_TypeObject_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeObject.CheckedChanged
        If RadioButton_TypeObject.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Name.Text = ""
            ComboBox_Name.Items.Clear()
            ComboBox_Artist.Items.Clear()
            ComboBox_Animation.Enabled = False
            CheckBox_NonDirectional.Visible = False
            Panel_Right.Visible = False
            Label_Left.Visible = False
            Label_Artist.Text = "Objects:"
            Label_Animation.Text = "Animation:"
            LoadDirs(Application.StartupPath & "\Objects")
            Button_OptimizePNGs.Enabled = True
        End If
    End Sub

    ' RadioButton_TypeNature - CheckedChanged
    Private Sub RadioButton_TypeNature_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_TypeNature.CheckedChanged
        If RadioButton_TypeNature.Checked Then
            ComboBox_Animation.Items.Clear()
            ComboBox_Name.Text = ""
            ComboBox_Name.Items.Clear()
            ComboBox_Artist.Items.Clear()
            ComboBox_Animation.Enabled = True
            CheckBox_NonDirectional.Visible = False
            Panel_Right.Visible = False
            Label_Left.Visible = False
            Label_Artist.Text = "Theme:"
            Label_Animation.Text = "Type:"
            LoadDirs(Application.StartupPath & "\Nature")
            Button_OptimizePNGs.Enabled = True
        End If
    End Sub

    ' NumericUpDown_Delay - KeyDown
    Private Sub NumericUpDown_Delay_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown_Delay.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Clear (ToolStripMenuItem) - Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearAllUIObjects()
    End Sub

    ' ClearAllUIObjects()
    Public Sub ClearAllUIObjects()
        PixelBox_Left.Image = Nothing
        PixelBox_Right.Image = Nothing
        ListBox_Images.Items.Clear()
        Label_Animation_Frame_Count.Text = "Animation Frame Count: "
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If ListBox_Images.Items.Count > 0 Then
            If RadioButton_TypeGroundPet.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 And ComboBox_Animation.Text.Length > 0 Then
                    ' Create Dir if needed
                    If Not Directory.Exists(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text) Then
                        Directory.CreateDirectory(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
                    End If

                    If RadioButton_TypeFlyingPet.Checked Or RadioButton_TypeGroundPet.Checked And ComboBox_Animation.Text = "Dragging" Then
                        If CheckBox_NonDirectional.Checked Then
                            PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
                        Else
                            PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                            PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                        End If
                    Else
                        PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                        PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                    End If

                    ' Clear for Next
                    ClearAllUIObjects()
                End If
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 And ComboBox_Animation.Text.Length > 0 Then
                    ' Create Dir if needed
                    If Not Directory.Exists(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text) Then
                        Directory.CreateDirectory(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
                    End If

                    If RadioButton_TypeFlyingPet.Checked Or RadioButton_TypeGroundPet.Checked And ComboBox_Animation.Text = "Dragging" Then
                        If CheckBox_NonDirectional.Checked Then
                            PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
                        Else
                            PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                            PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                        End If
                    Else
                        PixelBox_Left.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Left.gif", Imaging.ImageFormat.Gif)
                        PixelBox_Right.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & " Right.gif", Imaging.ImageFormat.Gif)
                    End If

                    ' Clear for Next
                    ClearAllUIObjects()
                End If

            ElseIf RadioButton_TypeObject.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 Then
                    Console.WriteLine(Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & ".gif")
                    PixelBox_Left.Image.Save(Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    ' Clear for Next
                    ClearAllUIObjects()
                End If

            ElseIf RadioButton_TypeNature.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 And ComboBox_Animation.Text.Length > 0 Then
                    PixelBox_Left.Image.Save(Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Animation.Text & "\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    ' Clear for Next
                    ClearAllUIObjects()
                End If
            End If

        End If
    End Sub

    ' Button_Flip_Click
    Private Sub Button_Flip_Click(sender As Object, e As EventArgs) Handles Button_Flip.Click
        If ListBox_Images.Items.Count > 0 Then
            If Flipped Then
                Flipped = False
            Else
                Flipped = True
            End If
            CreateAnimatedGifs()
        End If
    End Sub

    ' ComboBox_Artist - SelectedIndexChanged
    Private Sub ComboBox_Artist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Artist.SelectedIndexChanged
        Dim PetDirFullPath As String = ""
        If RadioButton_TypeGroundPet.Checked Or RadioButton_TypeFlyingPet.Checked Then
            If RadioButton_TypeGroundPet.Checked Then
                PetDirFullPath = Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text
            End If

            If RadioButton_TypeFlyingPet.Checked Then
                PetDirFullPath = Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text
            End If

            ComboBox_Name.Text = ""
            ComboBox_Name.Items.Clear()
            ComboBox_Name.BeginUpdate()
            For Each PetDir As String In Directory.GetDirectories(PetDirFullPath)
                ComboBox_Name.Items.Add(Path.GetFileName(PetDir))
            Next
            ComboBox_Name.EndUpdate()
        End If

        If RadioButton_TypeObject.Checked Then
            PetDirFullPath = Application.StartupPath & "\Objects\" & ComboBox_Artist.Text
            LoadFiles(Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        End If

        If RadioButton_TypeNature.Checked Then
            PetDirFullPath = Application.StartupPath & "\Nature\" & ComboBox_Artist.Text
            ComboBox_Animation.Text = ""
            ComboBox_Animation.Items.Clear()
            ComboBox_Animation.BeginUpdate()
            For Each PetDir As String In Directory.GetDirectories(PetDirFullPath)
                ComboBox_Animation.Items.Add(Path.GetFileName(PetDir))
            Next
            ComboBox_Animation.EndUpdate()
        End If

    End Sub

    ' ComboBox_Animation - SelectedIndexChanged
    Private Sub ComboBox_Animation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Animation.SelectedIndexChanged
        If RadioButton_TypeNature.Checked Then
            LoadFiles(Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Animation.Text)
        End If

        CheckBox_NonDirectional.Visible = False
        If RadioButton_TypeFlyingPet.Checked Or RadioButton_TypeGroundPet.Checked Then
            If ComboBox_Animation.Text = "Dragging" Then
                CheckBox_NonDirectional.Visible = True
            Else
                CheckBox_NonDirectional.Checked = False
            End If
        End If
    End Sub

    ' CheckBox_NonDirectional - CheckedChanged
    Private Sub CheckBox_NonDirectional_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_NonDirectional.CheckedChanged
        If CheckBox_NonDirectional.Checked Then
            Panel_Right.Visible = False
            Label_Left.Visible = False
        Else
            Panel_Right.Visible = True
            Label_Left.Visible = True
        End If
    End Sub

    ' 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PetDirFullPath As String = ""
        If RadioButton_TypeGroundPet.Checked Then
            PetDirFullPath = Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeFlyingPet.Checked Then
            PetDirFullPath = Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeObject.Checked Then
            PetDirFullPath = Application.StartupPath & "\Objects\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeNature.Checked Then
            PetDirFullPath = Application.StartupPath & "\Nature\" & ComboBox_Artist.Text
        End If
        Try
            If Directory.Exists(PetDirFullPath) Then
                Process.Start(PetDirFullPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ComboBox_Artist.Text = "" And Not ComboBox_Name.Text = "" Then
            Dim PetDirFullPath As String = ""
            If RadioButton_TypeGroundPet.Checked Then
                PetDirFullPath = Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                PetDirFullPath = Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeObject.Checked Then
                PetDirFullPath = Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeNature.Checked Then
                PetDirFullPath = Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            End If
            Try
                If Directory.Exists(PetDirFullPath) Then
                    Process.Start(PetDirFullPath)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Button_AnimationInfo - Click
    Private Sub Button_AnimationInfo_Click(sender As Object, e As EventArgs) Handles Button_AnimationInfo.Click
        Dim AnimationInfoForm = New Form_AnimationInfo
        AnimationInfoForm.Show()
        If AnimationInfoForm.WindowState = FormWindowState.Minimized Then
            AnimationInfoForm.WindowState = FormWindowState.Normal
        End If
        AnimationInfoForm.BringToFront()
    End Sub

    ' Button_OptimizeGIFs - Click
    Private Sub Button_OptimizeGIFs_Click(sender As Object, e As EventArgs) Handles Button_OptimizeGIFs.Click
        If Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeObject.Checked Then
            RunoptimizationScript("GIFs", Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        ElseIf Not ComboBox_Artist.SelectedIndex = -1 AndAlso Not ComboBox_Artist.SelectedIndex = -1 Then
            If RadioButton_TypeGroundPet.Checked Then
                RunoptimizationScript("GIFs", Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                RunoptimizationScript("GIFs", Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeNature.Checked Then
                RunoptimizationScript("GIFs", Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            End If
        End If
    End Sub

    ' Button_OptimizePNGs - Click
    Private Sub Button_OptimizePNGs_Click(sender As Object, e As EventArgs) Handles Button_OptimizePNGs.Click
        If Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeObject.Checked Then
            RunoptimizationScript("PNGs", Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        ElseIf Not ComboBox_Artist.SelectedIndex = -1 AndAlso Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeNature.Checked Then
            RunoptimizationScript("PNGs", Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Animation.Text)
        End If
    End Sub

    ' OptimizeAllGifsInFolder
    Public Sub OptimizeAllGifsInFolder(folderPath As String)
        ' Get the path to gifsicle.exe (next to executable)
        Dim gifsiclePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gifsicle.exe")

        ' Validate gifsicle exists
        If Not File.Exists(gifsiclePath) Then
            MsgBox("gifsicle.exe not found next to executable!", MsgBoxStyle.Critical, "Desktop Widgets")
            Return
        End If

        ' Get all GIF files
        Dim gifFiles = Directory.GetFiles(folderPath, "*.gif")
        If gifFiles.Length = 0 Then
            MsgBox("No GIF files found in directory.", MsgBoxStyle.Information, "Desktop Widgets")
            Return
        End If

        ' Build command arguments for ALL files
        Dim arguments As New StringBuilder("-b --optimize=1")
        For Each file In gifFiles
            arguments.Append($" ""{file}""") ' Quote paths with spaces
        Next

        Try
            Using process As New Process()
                process.StartInfo.FileName = gifsiclePath
                process.StartInfo.Arguments = arguments.ToString()
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                process.StartInfo.CreateNoWindow = True
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True

                ' Start process
                process.Start()

                ' Capture output (important to prevent hangs)
                Dim output = process.StandardOutput.ReadToEnd()
                Dim errors = process.StandardError.ReadToEnd()

                process.WaitForExit()

                ' Report results
                If process.ExitCode = 0 Then
                    MsgBox("Successfully optimized GIF files", MsgBoxStyle.Information, "Desktop Widgets")
                Else
                    MsgBox($"Error (code {process.ExitCode}): {errors}", MsgBoxStyle.Critical, "Desktop Widgets")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Desktop Widgets")
        End Try
    End Sub

    ' RunoptimizationScript
    Public Sub RunoptimizationScript(ImageType As String, folderPath As String)
        Try
            ' Create a new ProcessStartInfo instance
            Dim processStartInfo As New ProcessStartInfo()

            ' Set the file name to the batch file
            If ImageType = "GIFs" Then
                processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory & "Optimization Tools\" & "GIFs.bat"
            ElseIf ImageType = "PNGs" Then
                processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory & "Optimization Tools\" & "PNGs.bat"
            End If

            ' Set the argument to the file path
            processStartInfo.Arguments = """" & folderPath & """"

            ' Configure the process to open normally
            processStartInfo.UseShellExecute = True ' Use the shell to execute the process
            processStartInfo.CreateNoWindow = True ' Show the command prompt window
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal ' Set the window style to normal

            ' Create and start the process
            Dim process As New Process()
            process.StartInfo = processStartInfo
            process.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Desktop Widgets")
        End Try
    End Sub
End Class