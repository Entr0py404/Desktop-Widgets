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


    'ListBox_Phrases - MouseDoubleClick
    Private Sub ListBox_Phrases_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox_Phrases.MouseDoubleClick
        If Not ListBox_Phrases.SelectedIndex = -1 Then
            ListBox_Phrases.Items.RemoveAt(ListBox_Phrases.SelectedIndex)
        End If
    End Sub
    'TextBox_NewTag - KeyPress
    Private Sub TextBox_NewTag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NewPhrase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_NewPhrase.Text.Length > 0 Then
            If Not ListBox_Phrases.Items.Contains(TextBox_NewPhrase.Text.ToLower) Then
                e.Handled = True
                ListBox_Phrases.Items.Add(TextBox_NewPhrase.Text.ToLower)
                TextBox_NewPhrase.Clear()
            End If
        End If
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

    End Sub
End Class