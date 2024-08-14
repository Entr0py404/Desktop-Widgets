
Public Class Form_Phrase
    Dim randNum As New Random

    ' Form_Phrase - Load
    Private Sub Form_Phrase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        'Label_Phrase.Font = Form_Gdev.FontDialog1.Font
    End Sub

    ' Label_Phrase - TextChanged
    Private Sub Label_Phrase_TextChanged(sender As Object, e As EventArgs) Handles Label_Phrase.TextChanged
        Timer_AutoHide.Start()
    End Sub

    ' Timer_AutoHide - Tick
    Private Sub Timer_AutoHide_Tick(sender As Object, e As EventArgs) Handles Timer_AutoHide.Tick
        Timer_AutoHide.Stop()
        Label_Phrase.Text = ""
        Me.Opacity = 0 'Me.Visible = False
    End Sub
End Class