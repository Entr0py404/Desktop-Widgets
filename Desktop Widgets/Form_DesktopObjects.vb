Public Class Form_DesktopObjects
    'Form_DesktopObjects - Load
    Private Sub Form_DesktopObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\", ListView_Objects, ImageList_Objects)
        End If
    End Sub
    'ListView_Objects - ItemActivate
    Private Sub ListView_NatureObjects_ItemActivate(sender As Object, e As EventArgs) Handles ListView_Objects.ItemActivate
        Dim DesktopObject = New Form_DesktopObject
        DesktopObject.ObjectImage = New Bitmap(ListView_Objects.SelectedItems(0).Name)
        DesktopObject.PixelBox1.Image = DesktopObject.ObjectImage
        DesktopObject.Show()
    End Sub
    'TrackBar_ObjectScale - ValueChanged
    Private Sub TrackBar_ObjectScale_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_ObjectScale.ValueChanged
        Label_Scale.Text = TrackBar_ObjectScale.Value.ToString & "x"
    End Sub
    'LoadDesktopObjects()
    Private Sub LoadDesktopObjects(path As String, DesktopObjects_ListView As ListView, DesktopObjects_ImageList As ImageList)
        If Directory.Exists(path) Then
            DesktopObjects_ImageList.Images.Clear()
            DesktopObjects_ListView.Items.Clear()
            Dim FilesToCheck As New ArrayList()
            FilesToCheck.AddRange(Directory.GetFiles(path, "*.png", SearchOption.AllDirectories))
            FilesToCheck.AddRange(Directory.GetFiles(path, "*.gif", SearchOption.AllDirectories))
            For Each item As String In FilesToCheck
                DesktopObjects_ImageList.Images.Add(Image.FromFile(item))
                DesktopObjects_ListView.Items.Add(item, "", DesktopObjects_ImageList.Images.Count - 1)
            Next
        End If
    End Sub
    'CloseAllWindowsbyName
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
    'Button_AllDesktopObjects - Click
    Private Sub Button_AllDesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_AllDesktopObjects.Click
        CloseAllWindowsByName("Form_DesktopObject")
    End Sub
    'ReloadToolStripMenuItem - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\", ListView_Objects, ImageList_Objects)
        End If
    End Sub
End Class