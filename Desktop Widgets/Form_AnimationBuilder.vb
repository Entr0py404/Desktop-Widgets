Imports System.ComponentModel
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
                'ClearAllUIObjects()
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
        Dim MyAnimatedGif1 As New AnimatedGifCreator(MyMemoryStream1, CInt(NumericUpDown_Delay.Value), 0)

        For Each item As String In ListBox_Images.Items
            If Flipped = False Then
                MyAnimatedGif1.AddFrame(Image.FromFile(item), delay:=-1, quality:=GifQuality.Bit8)
            Else
                Dim tempImage As Image
                tempImage = Image.FromFile(item)
                tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                MyAnimatedGif1.AddFrame(tempImage, delay:=-1, quality:=GifQuality.Bit8)
            End If
        Next

        PixelBox_Animation.Image = Image.FromStream(MyMemoryStream1)
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

    ' LoadFiles
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
            ComboBox_Animation.Items.Add("Land")
            ComboBox_Animation.Items.Add("Pose")
            ComboBox_Animation.Items.Add("Pose2")
            ComboBox_Animation.Items.Add("Pose3")
            ComboBox_Animation.Items.Add("Pose4")
            ComboBox_Animation.Items.Add("Pose5")
            ComboBox_Animation.EndUpdate()
            ComboBox_Animation.SelectedIndex = 0
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

    ' ClearAllUIObjects()
    Public Sub ClearAllUIObjects()
        PixelBox_SelectedFrame.Image = Nothing
        PixelBox_Animation.Image = Nothing
        ListBox_Images.Items.Clear()
        Label_Animation_Frame_Count.Text = "Animation Frame Count: "
        Flipped = False
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
                        PixelBox_Animation.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
                    Else
                        PixelBox_Animation.Image.Save(Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
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
                        PixelBox_Animation.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
                    Else
                        PixelBox_Animation.Image.Save(Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & "\" & ComboBox_Animation.SelectedItem.ToString & ".gif", Imaging.ImageFormat.Gif)
                    End If

                    ' Clear for Next
                    ClearAllUIObjects()
                End If

            ElseIf RadioButton_TypeObject.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 Then
                    Console.WriteLine(Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & ".gif")
                    PixelBox_Animation.Image.Save(Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
                    ' Clear for Next
                    ClearAllUIObjects()
                End If

            ElseIf RadioButton_TypeNature.Checked Then
                If ComboBox_Artist.Text.Length > 0 And ComboBox_Name.Text.Length > 0 And ComboBox_Animation.Text.Length > 0 Then
                    PixelBox_Animation.Image.Save(Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Animation.Text & "\" & ComboBox_Name.Text & ".gif", Imaging.ImageFormat.Gif)
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
    End Sub

    ' 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DirFullPath As String = ""
        If RadioButton_TypeGroundPet.Checked Then
            DirFullPath = Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeFlyingPet.Checked Then
            DirFullPath = Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeObject.Checked Then
            DirFullPath = Application.StartupPath & "\Objects\" & ComboBox_Artist.Text
        ElseIf RadioButton_TypeNature.Checked Then
            DirFullPath = Application.StartupPath & "\Nature\" & ComboBox_Artist.Text
        End If
        Try
            If Directory.Exists(DirFullPath) Then
                Process.Start(DirFullPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ComboBox_Artist.Text = "" And Not ComboBox_Name.Text = "" Then
            Dim DirFullPath As String = ""
            If RadioButton_TypeGroundPet.Checked Then
                DirFullPath = Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                DirFullPath = Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeObject.Checked Then
                DirFullPath = Application.StartupPath & "\Objects\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            ElseIf RadioButton_TypeNature.Checked Then
                DirFullPath = Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text
            End If
            Try
                If Directory.Exists(DirFullPath) Then
                    Process.Start(DirFullPath)
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
            RunOptimizationScript("GIFs", Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        ElseIf Not ComboBox_Artist.SelectedIndex = -1 AndAlso Not ComboBox_Artist.SelectedIndex = -1 Then
            If RadioButton_TypeGroundPet.Checked Then
                RunOptimizationScript("GIFs", Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                RunOptimizationScript("GIFs", Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeNature.Checked Then
                RunOptimizationScript("GIFs", Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            End If
        End If
    End Sub

    ' Button_OptimizePNGs - Click
    Private Sub Button_OptimizePNGs_Click(sender As Object, e As EventArgs) Handles Button_OptimizePNGs.Click
        If Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeObject.Checked Then
            RunOptimizationScript("PNGs", Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        ElseIf Not ComboBox_Artist.SelectedIndex = -1 AndAlso Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeNature.Checked Then
            RunOptimizationScript("PNGs", Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Animation.Text)
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

    ' RunOptimizationScript
    Public Sub RunOptimizationScript(ImageType As String, folderPath As String)
        Try
            ' Create a new ProcessStartInfo instance
            Dim processStartInfo As New ProcessStartInfo()

            ' Set the file name to the batch file
            If ImageType = "GIFs" Then
                processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory & "Optimization Tools\" & "GIFsOP.bat"
            ElseIf ImageType = "UnGIFs" Then
                processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory & "Optimization Tools\" & "GIFsUNOP.bat"
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

    ' Button_UnoptimizeGIFs - Click
    Private Sub Button_UnoptimizeGIFs_Click(sender As Object, e As EventArgs) Handles Button_UnoptimizeGIFs.Click
        If Not ComboBox_Artist.SelectedIndex = -1 AndAlso RadioButton_TypeObject.Checked Then
            RunOptimizationScript("UnGIFs", Application.StartupPath & "\Objects\" & ComboBox_Artist.Text)
        ElseIf Not ComboBox_Artist.SelectedIndex = -1 AndAlso Not ComboBox_Artist.SelectedIndex = -1 Then
            If RadioButton_TypeGroundPet.Checked Then
                RunOptimizationScript("UnGIFs", Application.StartupPath & "\Pets\Ground\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeFlyingPet.Checked Then
                RunOptimizationScript("UnGIFs", Application.StartupPath & "\Pets\Flying\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            ElseIf RadioButton_TypeNature.Checked Then
                RunOptimizationScript("UnGIFs", Application.StartupPath & "\Nature\" & ComboBox_Artist.Text & "\" & ComboBox_Name.Text)
            End If
        End If
    End Sub

    ' ListBox_Images - SelectedIndexChanged
    Private Sub ListBox_Images_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Images.SelectedIndexChanged
        If Not ListBox_Images.SelectedIndex = -1 Then
            PixelBox_SelectedFrame.Image = Image.FromFile(ListBox_Images.SelectedItem.ToString)
        Else
            PixelBox_SelectedFrame.Image = Nothing
        End If
    End Sub

    ' ContextMenuStrip1 - Opened
    Private Sub ContextMenuStrip1_Opened(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Opened
        If Not ListBox_Images.SelectedIndex = -1 Then
            SelectedFrameToolStripMenuItem.Enabled = True
        Else
            SelectedFrameToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' Button_MoveFrameUp - Click
    Private Sub Button_MoveFrameUp_Click(sender As Object, e As EventArgs) Handles Button_MoveFrameUp.Click
        If ListBox_Images.SelectedIndex > 0 Then

            Dim selectedItem As Object = ListBox_Images.SelectedItem
            Dim selectedIndex As Integer = ListBox_Images.SelectedIndex

            ListBox_Images.Items.RemoveAt(selectedIndex)
            ListBox_Images.Items.Insert(selectedIndex - 1, selectedItem)
            ListBox_Images.SelectedIndex = selectedIndex - 1

            CreateAnimatedGifs()
        End If
    End Sub

    ' Button_MoveFrameDown - Click
    Private Sub Button_MoveFrameDown_Click(sender As Object, e As EventArgs) Handles Button_MoveFrameDown.Click
        If ListBox_Images.SelectedIndex < ListBox_Images.Items.Count - 1 AndAlso ListBox_Images.SelectedIndex <> -1 Then
            Dim selectedItem As Object = ListBox_Images.SelectedItem
            Dim selectedIndex As Integer = ListBox_Images.SelectedIndex

            ListBox_Images.Items.RemoveAt(selectedIndex)
            ListBox_Images.Items.Insert(selectedIndex + 1, selectedItem)
            ListBox_Images.SelectedIndex = selectedIndex + 1

            CreateAnimatedGifs()
        End If
    End Sub

    ' Button_DuplicateUnderneath - Click
    Private Sub Button_DuplicateUnderneath_Click(sender As Object, e As EventArgs) Handles Button_DuplicateUnderneath.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.Insert(ListBox_Images.SelectedIndex + 1, ListBox_Images.SelectedItem)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' Button_DuplicateEndOfList - Click
    Private Sub Button_DuplicateEndOfList_Click(sender As Object, e As EventArgs) Handles Button_DuplicateEndOfList.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.Add(ListBox_Images.SelectedItem)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' Button_RemoveSelectedFrame - Click
    Private Sub Button_RemoveSelectedFrame_Click(sender As Object, e As EventArgs) Handles Button_RemoveSelectedFrame.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.RemoveAt(ListBox_Images.SelectedIndex)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' Button_ClearFrames - Click
    Private Sub Button_ClearFrames_Click(sender As Object, e As EventArgs) Handles Button_ClearFrames.Click
        ClearAllUIObjects()
    End Sub

    ' RemoveToolStripMenuItem - Click
    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.RemoveAt(ListBox_Images.SelectedIndex)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' MoveUpToolStripMenuItem - Click
    Private Sub MoveUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveUpToolStripMenuItem.Click
        If ListBox_Images.SelectedIndex > 0 Then

            Dim selectedItem As Object = ListBox_Images.SelectedItem
            Dim selectedIndex As Integer = ListBox_Images.SelectedIndex

            ListBox_Images.Items.RemoveAt(selectedIndex)
            ListBox_Images.Items.Insert(selectedIndex - 1, selectedItem)
            ListBox_Images.SelectedIndex = selectedIndex - 1

            CreateAnimatedGifs()
        End If
    End Sub

    ' MoveDownToolStripMenuItem - Click
    Private Sub MoveDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem.Click
        If ListBox_Images.SelectedIndex < ListBox_Images.Items.Count - 1 AndAlso ListBox_Images.SelectedIndex <> -1 Then
            Dim selectedItem As Object = ListBox_Images.SelectedItem
            Dim selectedIndex As Integer = ListBox_Images.SelectedIndex

            ListBox_Images.Items.RemoveAt(selectedIndex)
            ListBox_Images.Items.Insert(selectedIndex + 1, selectedItem)
            ListBox_Images.SelectedIndex = selectedIndex + 1

            CreateAnimatedGifs()
        End If
    End Sub

    ' UnderneathToolStripMenuItem - Click
    Private Sub UnderneathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderneathToolStripMenuItem.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.Insert(ListBox_Images.SelectedIndex + 1, ListBox_Images.SelectedItem)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' EndOfListToolStripMenuItem - Click
    Private Sub EndOfListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndOfListToolStripMenuItem.Click
        If Not ListBox_Images.SelectedIndex = -1 Then
            ListBox_Images.Items.Add(ListBox_Images.SelectedItem)
            Label_Animation_Frame_Count.Text = "Animation Frame Count: " & ListBox_Images.Items.Count
            CreateAnimatedGifs()
        End If
    End Sub

    ' Clear (ToolStripMenuItem) - Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearAllUIObjects()
    End Sub
End Class