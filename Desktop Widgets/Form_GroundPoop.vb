Public Class Form_GroundPoop
    'Form_Poop - Load
    Private Sub Form_Poop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'ScaleObject()
    Public Sub ScaleObject(val As Integer)
        Me.Width = My.Resources.Poop.Width * val
        Me.Height = My.Resources.Poop.Height * val
    End Sub
    'PixelBox1 - Click [Clean up poop]
    Private Sub PixelBox1_Click(sender As Object, e As EventArgs) Handles PixelBox1.Click
        Me.Opacity -= 0.3
        If Me.Opacity <= 0.6 Then
            Me.Close()
        End If
    End Sub
End Class