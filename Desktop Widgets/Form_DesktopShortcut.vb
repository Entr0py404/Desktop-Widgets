Imports System.ComponentModel

Public Class Form_DesktopShortcut
    Dim fileD As New OpenFileDialog()
    Dim folderD As New FolderBrowserDialog()
    Dim CustomPath As Boolean = True
    Public DesktopObjectFormRef As Form_DesktopObject

    'Form_DesktopShortcut - Load
    Private Sub Form_DesktopShortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileD.Title = "Open File Dialog"
        fileD.InitialDirectory = "C:\"
        fileD.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fileD.FilterIndex = 2
        fileD.RestoreDirectory = True

        folderD.ShowNewFolderButton = False
        folderD.RootFolder = Environment.SpecialFolder.MyComputer
    End Sub

    ' Button_File - Click
    Private Sub Button_File_Click(sender As Object, e As EventArgs) Handles Button_File.Click
        If fileD.ShowDialog() = DialogResult.OK Then
            DesktopObjectFormRef.DesktopShortcutPath = fileD.FileName
            CustomPath = False
            Me.Close()
        End If
    End Sub

    ' Button_Folder - Click
    Private Sub Button_Folder_Click(sender As Object, e As EventArgs) Handles Button_Folder.Click
        If folderD.ShowDialog() = DialogResult.OK Then
            DesktopObjectFormRef.DesktopShortcutPath = folderD.SelectedPath
            DesktopObjectFormRef.ToolTip1.SetToolTip(DesktopObjectFormRef.PixelBox_DesktopObject, folderD.SelectedPath)
            CustomPath = False
            Me.Close()
        End If
    End Sub

    'Form_DesktopShortcut - Closing
    Private Sub Form_DesktopShortcut_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CustomPath = True Then
            DesktopObjectFormRef.DesktopShortcutPath = TextBox_ShortcutPath.Text
        End If
    End Sub
End Class