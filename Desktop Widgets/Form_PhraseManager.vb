Public Class Form_PhraseManager
    'Form_Phrases - Load
    Private Sub Form_Phrases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox_Topic.Items.Count > 0 Then
            ComboBox_Topic.SelectedIndex = 0
        End If
    End Sub
    'ComboBox_Topic - SelectedIndexChanged
    Private Sub ComboBox_Topic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Topic.SelectedIndexChanged

    End Sub
    'ComboBox_Topic - SelectedValueChanged
    Private Sub ComboBox_Topic_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Topic.SelectedValueChanged

    End Sub
    'ListBox_Phrases - MouseClick
    Private Sub ListBox_Phrases_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox_Phrases.MouseClick

    End Sub
    'ListBox_Phrases - MouseDoubleClick
    Private Sub ListBox_Phrases_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox_Phrases.MouseDoubleClick

    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

    End Sub
End Class