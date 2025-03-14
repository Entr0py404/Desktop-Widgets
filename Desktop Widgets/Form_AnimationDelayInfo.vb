﻿Imports AnimatedGif

Public Class Form_AnimationInfo
    Dim GIF_FrameDimension As Imaging.FrameDimension
    Dim GIF_FrameCount As Integer = 1
    ' Form1 - DragDrop
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                PixelBox1.Image = Nothing
                PixelBox1.Refresh()
                PixelBox1.Image = Image.FromFile(files(0))
                GIF_FrameDimension = New Imaging.FrameDimension(PixelBox1.Image.FrameDimensionsList()(0))
                GIF_FrameCount = PixelBox1.Image.GetFrameCount(GIF_FrameDimension)
                Label_FramesCount.Text = "Frames: " & GIF_FrameCount
                Label_Delay.Text = "Delay: " & GetFirstFrameDelay(files(0))
                Label_AnimationInfo.Text = ""
                GetGifInfo(files(0))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    ' Form1 - DragEnter
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)).ToLower = ".gif" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    ' GetFirstFrameDelay()
    Public Shared Function GetFirstFrameDelay(gifPath As String) As Integer
        Using gifImage As Image = Image.FromFile(gifPath)
            ' Property tag for frame delay in a GIF is 0x5100 (20736)
            Dim delayPropertyId As Integer = 20736

            ' Check if the delay property exists and retrieve the first frame delay
            If gifImage.PropertyIdList.Contains(delayPropertyId) Then
                Dim frameDelays As Byte() = gifImage.GetPropertyItem(delayPropertyId).Value
                ' First frame delay is stored as two bytes (in hundredths of a second)
                Dim delay As Integer = BitConverter.ToInt32(frameDelays, 0) * 10 ' Convert to milliseconds
                Return delay
            Else
                Throw New Exception("Frame delay not found in GIF.")
            End If
        End Using
    End Function

    Private Sub GetGifInfo(inputGif As String)
        ' Create a new ProcessStartInfo object
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory & "Optimization Tools\gifsicle.exe"
        processStartInfo.Arguments = $"""{inputGif}"" --info" ' Use quotes for paths with spaces
        processStartInfo.RedirectStandardOutput = True ' Redirect standard output
        processStartInfo.UseShellExecute = False ' Required to redirect output
        processStartInfo.CreateNoWindow = True ' Prevent a new window from opening

        ' Create and start the process
        Dim process As New Process()
        process.StartInfo = processStartInfo
        process.Start()

        ' Read the standard output
        Dim output As String = process.StandardOutput.ReadToEnd()

        ' Wait for the process to exit
        process.WaitForExit()

        ' Display the output
        Console.WriteLine(output)
        Label_AnimationInfo.Text = output
    End Sub
End Class