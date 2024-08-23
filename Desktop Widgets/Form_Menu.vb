
Public Class Form_Menu
    Friend FormList_DesktopObject As New Dictionary(Of String, Form_DesktopObject)
    Friend FormList_NatureObject As New Dictionary(Of String, Form_NatureObject)
    Public IDCounter_DesktopObject As Integer = 0
    Public IDCounter_NatureObject As Integer = 0

    ' Form_Menu - Load
    Private Sub Form_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ContextMenuStrip_Main.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub

    ' Button_DesktopPets - Click
    Private Sub Button_DesktopPets_Click(sender As Object, e As EventArgs) Handles Button_DesktopPets.Click
        Form_Pets.Show()
        If Form_Pets.WindowState = FormWindowState.Minimized Then
            Form_Pets.WindowState = FormWindowState.Normal
        End If
        Form_Pets.BringToFront()
    End Sub

    ' Button_Nature - Click
    Private Sub Button_Nature_Click(sender As Object, e As EventArgs) Handles Button_Nature.Click
        Form_Nature.Show()
        If Form_Nature.WindowState = FormWindowState.Minimized Then
            Form_Nature.WindowState = FormWindowState.Normal
        End If
        Form_Nature.BringToFront()
    End Sub

    ' Button_DesktopObjects - Click
    Private Sub Button_DesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_DesktopObjects.Click
        Form_DesktopObjects.Show()
        If Form_DesktopObjects.WindowState = FormWindowState.Minimized Then
            Form_DesktopObjects.WindowState = FormWindowState.Normal
        End If
        Form_DesktopObjects.BringToFront()
    End Sub

    ' Button_Phrases - Click
    Private Sub Button_Phrases_Click(sender As Object, e As EventArgs)
        Form_PhraseManager.Show()
        If Form_PhraseManager.WindowState = FormWindowState.Minimized Then
            Form_PhraseManager.WindowState = FormWindowState.Normal
        End If
        Form_PhraseManager.BringToFront()
    End Sub

    ' Button_PetBuilder - Click
    Private Sub Button_AnimationBuilder_Click(sender As Object, e As EventArgs) Handles Button_AnimationBuilder.Click
        Form_AnimationBuilder.Show()
        If Form_AnimationBuilder.WindowState = FormWindowState.Minimized Then
            Form_AnimationBuilder.WindowState = FormWindowState.Normal
        End If
        Form_AnimationBuilder.BringToFront()
    End Sub

    ' DesktopPets (ToolStripMenuItem) - Click
    Private Sub DesktopPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopPetsToolStripMenuItem.Click
        Form_Pets.Show()
        If Form_Pets.WindowState = FormWindowState.Minimized Then
            Form_Pets.WindowState = FormWindowState.Normal
        End If
        Form_Pets.BringToFront()
    End Sub

    ' Nature (ToolStripMenuItem) - Click
    Private Sub DesktopNatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopNatureToolStripMenuItem.Click
        Form_Nature.Show()
        If Form_Nature.WindowState = FormWindowState.Minimized Then
            Form_Nature.WindowState = FormWindowState.Normal
        End If
        Form_Nature.BringToFront()
    End Sub

    ' DesktopObjects (ToolStripMenuItem) - Click
    Private Sub DesktopObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopObjectsToolStripMenuItem.Click
        Form_DesktopObjects.Show()
        If Form_DesktopObjects.WindowState = FormWindowState.Minimized Then
            Form_DesktopObjects.WindowState = FormWindowState.Normal
        End If
        Form_DesktopObjects.BringToFront()
    End Sub

    ' Button_CloseSelected - Click
    Private Sub Button_CloseSelected_Click(sender As Object, e As EventArgs) Handles Button_CloseSelected.Click
        If ComboBox1.SelectedItem.ToString = "All Pets" Then
            CloseAllWindowsByName("Form_GroundPet")
            CloseAllWindowsByName("Form_FlyingPet")
        ElseIf ComboBox1.SelectedItem.ToString = "Ground Pets" Then
            CloseAllWindowsByName("Form_GroundPet")
        ElseIf ComboBox1.SelectedItem.ToString = "Flying Pets" Then
            CloseAllWindowsByName("Form_FlyingPet")
        ElseIf ComboBox1.SelectedItem.ToString = "Nature Objects" Then
            Dim FormListArray As Array = FormList_NatureObject.Keys.ToArray
            For Each item As String In FormListArray
                FormList_NatureObject(item).Close()
            Next
            FormList_NatureObject.Clear()
            Form_Nature.Button_Generate.Enabled = True
        ElseIf ComboBox1.SelectedItem.ToString = "Desktop Objects" Then
            Dim FormListArray As Array = FormList_DesktopObject.Keys.ToArray
            For Each item As String In FormListArray
                FormList_DesktopObject(item).Close()
            Next
            FormList_DesktopObject.Clear()
        End If
    End Sub

    ' MenuToolStripMenuItem - Click
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        If Not Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.BringToFront()
        End If
    End Sub

    ' ExitToolStripMenuItem - Click
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' CloseAllWindowsbyName()
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

    ' Form_Menu - FormClosing
    Private Sub Form_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms.Count > 1 Then
            If MessageBox.Show("Multiple windows open, Close the application?", "Desktop Widgets", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    ' CheckBox_UseTrayIcon - CheckedChanged
    Private Sub CheckBox_UseTrayIcon_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_UseTrayIcon.CheckedChanged
        If CheckBox_UseTrayIcon.Checked Then
            NotifyIcon1.Visible = True
            Me.ShowInTaskbar = False
        Else
            NotifyIcon1.Visible = False
            Me.ShowInTaskbar = True
        End If
    End Sub

    ' Form_Menu - Resize
    Private Sub Form_Menu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            If CheckBox_UseTrayIcon.Checked Then
                Me.Visible = False
            Else
                Me.Visible = True
            End If
        End If
    End Sub

    ' NotifyIcon1 - MouseClick
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Left Then
            If Not Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Minimized
            Else
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                Me.BringToFront()
            End If
        End If
    End Sub
End Class