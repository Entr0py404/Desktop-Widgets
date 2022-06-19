Public Class Form_Import

    'Form_Import - Load
    Private Sub Form_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Region = New Region(New RectangleF(Me.TabPage_DesktopObject.Left, Me.TabPage_DesktopObject.Top, Me.TabPage_DesktopObject.Width, Me.TabPage_DesktopObject.Height))
    End Sub
    'DesktopObjectToolStripMenuItem - Click
    Private Sub DesktopObjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopObjectToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_DesktopObject
        ResetToolStripMenuItemBackGroundColors()
        DesktopObjectToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'NatureObjectTextToolStripMenuItem - Click
    Private Sub NatureObjectTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NatureObjectTextToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_NatureObject
        ResetToolStripMenuItemBackGroundColors()
        NatureObjectTextToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'DesktopPetsToolStripMenuItem - Click
    Private Sub DesktopPetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopPetsToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_DesktopPets
        ResetToolStripMenuItemBackGroundColors()
        DesktopPetsToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'ResetToolStripMenuItemBackGroundColors()
    Private Sub ResetToolStripMenuItemBackGroundColors()
        DesktopObjectToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        NatureObjectTextToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        DesktopPetsToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
End Class