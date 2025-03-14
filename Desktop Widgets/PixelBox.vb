﻿Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class PixelBox
    Inherits PictureBox

    <Category("Behavior")>
    <DefaultValue(InterpolationMode.NearestNeighbor)>
    Public Property InterpolationMode As InterpolationMode = InterpolationMode.NearestNeighbor

    <Category("Behavior")>
    <DefaultValue(PixelOffsetMode.Half)>
    Public Property PixelOffsetMode As PixelOffsetMode = PixelOffsetMode.Half

    <Category("Behavior")>
    <DefaultValue(SmoothingMode.Default)>
    Public Property SmoothingMode As SmoothingMode = SmoothingMode.Default

    <Category("Behavior")>
    <DefaultValue(CompositingQuality.Default)>
    Public Property CompositingQuality As CompositingQuality = CompositingQuality.Default

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Try
            e.Graphics.InterpolationMode = Me.InterpolationMode
            e.Graphics.PixelOffsetMode = Me.PixelOffsetMode
            e.Graphics.SmoothingMode = Me.SmoothingMode
            e.Graphics.CompositingQuality = Me.CompositingQuality
            MyBase.OnPaint(e)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    ' Disposes of the Image and other disposable fields.
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            ' Dispose of the Image if it exists.
            If Me.Image IsNot Nothing Then
                Me.Image.Dispose()
                Me.Image = Nothing
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
End Class