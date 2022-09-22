Public Class Form_Gdev

    'Form_GDev - Load
    Private Sub Form_GDev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each display In Screen.AllScreens
            ComboBox_Display.Items.Add(display.DeviceName.Replace("\\.\", ""))
        Next

        ComboBox_Display.SelectedIndex = 0
    End Sub
    'Button_Spawn - Click
    Private Sub Button_Spawn_Click(sender As Object, e As EventArgs) Handles Button_Spawn.Click
        Form_Phrase.Close()
        'Dim GDevCharacter = New Form_GDevCharacter

        'Ground
        'Dim PetPath As String = "Gdev Character"

        'Walking
        If File.Exists("Gdev Character\Walking Left.gif") Then
            Form_GDevCharacter.Animation_Walking_Left = New Bitmap("Gdev Character\Walking Left.gif")
        End If
        If File.Exists("Gdev Character\Walking Right.gif") Then
            Form_GDevCharacter.Animation_Walking_Right = New Bitmap("Gdev Character\Walking Right.gif")
        End If

        'Idling
        If File.Exists("Gdev Character\Idling Left.gif") Then
            Form_GDevCharacter.Animation_Idling_Left = Image.FromFile("Gdev Character\Idling Left.gif")
            Form_GDevCharacter.PixelBox_Pet.Image = Form_GDevCharacter.Animation_Idling_Left
        End If
        If File.Exists("Gdev Character\Idling Right.gif") Then
            Form_GDevCharacter.Animation_Idling_Right = Image.FromFile("Gdev Character\Idling Right.gif")
        End If

        'Idling Alt
        If File.Exists("Gdev Character\Idling Alt Left.gif") Then
            Form_GDevCharacter.Animation_IdlingAlt_Left = New Bitmap("Gdev Character\Idling Alt Left.gif")
        End If
        If File.Exists("Gdev Character\Idling Alt Right.gif") Then
            Form_GDevCharacter.Animation_IdlingAlt_Right = New Bitmap("Gdev Character\Idling Alt Right.gif")
        End If

        'Dragging
        If File.Exists("Gdev Character\Dragging.gif") Then
            Form_GDevCharacter.Animation_Dragging = New Bitmap("Gdev Character\Dragging.gif")
        Else
            Form_GDevCharacter.Animation_Dragging = New Bitmap("Gdev Character\Walking Right.gif") 'Fallback Animation
        End If

        'Falling
        If File.Exists("Gdev Character\Falling.gif") Then
            Form_GDevCharacter.Animation_Falling = New Bitmap("Gdev Character\Falling.gif")
        Else
            Form_GDevCharacter.Animation_Falling = New Bitmap("Gdev Character\Walking Right.gif") 'Fallback Animation
        End If

        Form_GDevCharacter.Show()

        Button_Spawn.Enabled = False
    End Sub
    'Button_Close - Click
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Form_GDevCharacter.Close()
        Form_Phrase.Close()
    End Sub
    'TrackBar_ObjectScale - ValueChanged
    Private Sub TrackBar_ObjectScale_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_ObjectScale.ValueChanged
        Label_Scale.Text = TrackBar_ObjectScale.Value.ToString & "x"
    End Sub
    'TrackBar_TSSVolume - ValueChanged
    Private Sub TrackBar_TSSVolume_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_TSSVolume.ValueChanged
        Label_TSSVolume.Text = TrackBar_TSSVolume.Value.ToString & "%"
    End Sub
    '
    Private Sub TrackBar_TSSVolume_Scroll(sender As Object, e As EventArgs) Handles TrackBar_TSSVolume.Scroll
        'Form_GDevCharacter.synth.Volume = TrackBar_TSSVolume.Value
        'If Form_GDevCharacter.Visible = True Then
        'Form_GDevCharacter.synth.Volume = TrackBar_TSSVolume.Value
        'End If
    End Sub
    'Button_SpeechFont_Click
    Private Sub Button_SpeechFont_Click(sender As Object, e As EventArgs) Handles Button_SpeechFont.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Form_Phrase.Label_Phrase.Font = FontDialog1.Font
            Form_Phrase.FontDialog1.Font = FontDialog1.Font
        End If
    End Sub
End Class