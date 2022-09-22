Public Class Form_DesktopObjects

    'Form_DesktopObjects - Load
    Private Sub Form_DesktopObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\", ListView_Objects, ImageList_Objects)
        End If

        For Each display In Screen.AllScreens
            ComboBox_Display.Items.Add(display.DeviceName.Replace("\\.\", ""))
        Next

        ComboBox_Display.SelectedIndex = 0
    End Sub
    'ListView_Objects - ItemActivate
    Private Sub ListView_NatureObjects_ItemActivate(sender As Object, e As EventArgs) Handles ListView_Objects.ItemActivate
        Dim DesktopObject = New Form_DesktopObject
        DesktopObject.ObjectImage = New Bitmap(ListView_Objects.SelectedItems(0).Name)
        DesktopObject.PixelBox1.Image = DesktopObject.ObjectImage
        DesktopObject.Name = "DesktopObject"
        Form_Menu.IDCounter_DesktopObject += 1
        Form_Menu.FormList_DesktopObject.Add(Form_Menu.IDCounter_DesktopObject.ToString, DesktopObject)
        DesktopObject.UniqueSessionID = Form_Menu.IDCounter_DesktopObject.ToString
        Form_Menu.FormList_DesktopObject(Form_Menu.IDCounter_DesktopObject.ToString).Show() 'DesktopObject.Show()
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
    'Button_AllDesktopObjects - Click
    Private Sub Button_AllDesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_AllDesktopObjects.Click
        Dim FormListArray As Array = Form_Menu.FormList_DesktopObject.Keys.ToArray
        For Each item As String In FormListArray
            Form_Menu.FormList_DesktopObject(item).Close()
        Next
        Form_Menu.FormList_DesktopObject.Clear()
    End Sub
    'ReloadToolStripMenuItem - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If Directory.Exists(Application.StartupPath & "\Objects\") Then
            LoadDesktopObjects(Application.StartupPath & "\Objects\", ListView_Objects, ImageList_Objects)
        End If
    End Sub
End Class