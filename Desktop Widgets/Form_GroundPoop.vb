Public Class Form_GroundPoop
    'Form_Poop - Load
    Private Sub Form_Poop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = PixelBox1.Width
        Me.Height = PixelBox1.Height
    End Sub
    'PixelBox1 - Click [Clean up poop]
    Private Sub PixelBox1_Click(sender As Object, e As EventArgs) Handles PixelBox1.Click
        Me.Opacity -= 0.3
        If Me.Opacity <= 0.6 Then
            Me.Close()
        End If
    End Sub
End Class