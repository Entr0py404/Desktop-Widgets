Public Class Form_Menu

    'Form_Menu - Load
    Private Sub Form_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ContextMenuStrip_Main.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'Button_DesktopPets - Click
    Private Sub Button_DesktopPets_Click(sender As Object, e As EventArgs) Handles Button_DesktopPets.Click
        Form_Pets.Show()
        If Form_Pets.WindowState = FormWindowState.Minimized Then
            Form_Pets.WindowState = FormWindowState.Normal
        End If
        Form_Pets.BringToFront()
    End Sub
    'Button_Nature - Click
    Private Sub Button_Nature_Click(sender As Object, e As EventArgs) Handles Button_Nature.Click
        Form_Nature.Show()
        If Form_Nature.WindowState = FormWindowState.Minimized Then
            Form_Nature.WindowState = FormWindowState.Normal
        End If
        Form_Nature.BringToFront()
    End Sub
    'Button_DesktopObjects - Click
    Private Sub Button_DesktopObjects_Click(sender As Object, e As EventArgs) Handles Button_DesktopObjects.Click
        Form_DesktopObjects.Show()
        If Form_DesktopObjects.WindowState = FormWindowState.Minimized Then
            Form_DesktopObjects.WindowState = FormWindowState.Normal
        End If
        Form_DesktopObjects.BringToFront()
    End Sub
    'Button_GDev - Click
    Private Sub Button_GDev_Click(sender As Object, e As EventArgs) Handles Button_GDev.Click
        Form_Gdev.Show()
        If Form_Gdev.WindowState = FormWindowState.Minimized Then
            Form_Gdev.WindowState = FormWindowState.Normal
        End If
        Form_Gdev.BringToFront()
    End Sub

    'Button_Import - Click
    'Private Sub Button_Import_Click(sender As Object, e As EventArgs)
    'Form_Import.Show()
    'If Form_Import.WindowState = FormWindowState.Minimized Then
    'Form_Import.WindowState = FormWindowState.Normal
    'End If
    'Form_Import.BringToFront()
    'End Sub

    'Button_Phrases - Click
    Private Sub Button_Phrases_Click(sender As Object, e As EventArgs) Handles Button_Phrases.Click
        Form_PhraseManager.Show()
        If Form_PhraseManager.WindowState = FormWindowState.Minimized Then
            Form_PhraseManager.WindowState = FormWindowState.Normal
        End If
        Form_PhraseManager.BringToFront()
    End Sub
    'Button_PetBuilder - Click
    Private Sub Button_PetBuilder_Click(sender As Object, e As EventArgs) Handles Button_PetBuilder.Click
        Form_PhraseManager.Show()
        If Form_PhraseManager.WindowState = FormWindowState.Minimized Then
            Form_PhraseManager.WindowState = FormWindowState.Normal
        End If
        Form_PhraseManager.BringToFront()
    End Sub
    'DesktopPets (ToolStripMenuItem) - Click
    Private Sub DesktopPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopPetsToolStripMenuItem.Click
        Button_DesktopPets.PerformClick()
    End Sub
    'Nature (ToolStripMenuItem) - Click
    Private Sub NatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NatureToolStripMenuItem.Click
        Button_Nature.PerformClick()
    End Sub
    'DesktopObjects (ToolStripMenuItem) - Click
    Private Sub DesktopObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopObjectsToolStripMenuItem.Click
        Button_DesktopObjects.PerformClick()
    End Sub
    'GDevCharacter (ToolStripMenuItem) - Click
    Private Sub GDevCharacterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GDevCharacterToolStripMenuItem.Click
        Button_GDev.PerformClick()
    End Sub

    'Import (ToolStripMenuItem) - Click
    'Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
    'End Sub

    'PetBuilder (ToolStripMenuItem) - Click
    Private Sub PetBuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetBuilderToolStripMenuItem.Click
        Button_PetBuilder.PerformClick()
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
        ElseIf ComboBox1.SelectedItem.ToString = "Nature Objects" Then
            CloseAllWindowsByName("Form_NatureObject")
        ElseIf ComboBox1.SelectedItem.ToString = "Desktop Objects" Then
            CloseAllWindowsByName("Form_DesktopObject")
        ElseIf ComboBox1.SelectedItem.ToString = "GDev Character" Then
            Form_GDevCharacter.Close()
        End If
    End Sub
    'MenuToolStripMenuItem - Click
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        If Not Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    'ExitToolStripMenuItem - Click
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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
    'Form_Menu - FormClosing
    Private Sub Form_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms.Count > 1 Then
            If MessageBox.Show("Multiple windows open, Close the application?", "Desktop Widgets", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class