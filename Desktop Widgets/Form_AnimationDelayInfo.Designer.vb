﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AnimationInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AnimationInfo))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_AnimationInfo = New System.Windows.Forms.Label()
        Me.Label_Delay = New System.Windows.Forms.Label()
        Me.Label_FramesCount = New System.Windows.Forms.Label()
        Me.PixelBox1 = New Desktop_Widgets.PixelBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label_Delay)
        Me.Panel2.Controls.Add(Me.Label_FramesCount)
        Me.Panel2.Controls.Add(Me.PixelBox1)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(8, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 304)
        Me.Panel2.TabIndex = 85
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(1, 1)
        Me.Panel1.Controls.Add(Me.Label_AnimationInfo)
        Me.Panel1.Location = New System.Drawing.Point(264, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 280)
        Me.Panel1.TabIndex = 87
        '
        'Label_AnimationInfo
        '
        Me.Label_AnimationInfo.AutoSize = True
        Me.Label_AnimationInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AnimationInfo.ForeColor = System.Drawing.Color.Turquoise
        Me.Label_AnimationInfo.Location = New System.Drawing.Point(8, 8)
        Me.Label_AnimationInfo.Name = "Label_AnimationInfo"
        Me.Label_AnimationInfo.Size = New System.Drawing.Size(0, 15)
        Me.Label_AnimationInfo.TabIndex = 86
        '
        'Label_Delay
        '
        Me.Label_Delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delay.Location = New System.Drawing.Point(128, 264)
        Me.Label_Delay.Name = "Label_Delay"
        Me.Label_Delay.Size = New System.Drawing.Size(120, 32)
        Me.Label_Delay.TabIndex = 86
        Me.Label_Delay.Text = "Delay: "
        Me.Label_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_FramesCount
        '
        Me.Label_FramesCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_FramesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FramesCount.Location = New System.Drawing.Point(8, 264)
        Me.Label_FramesCount.Name = "Label_FramesCount"
        Me.Label_FramesCount.Size = New System.Drawing.Size(120, 32)
        Me.Label_FramesCount.TabIndex = 26
        Me.Label_FramesCount.Text = "Frames:"
        Me.Label_FramesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PixelBox1
        '
        Me.PixelBox1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox1.Location = New System.Drawing.Point(8, 8)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        Me.PixelBox1.Size = New System.Drawing.Size(256, 256)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox1.TabIndex = 27
        Me.PixelBox1.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(672, 304)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(664, 296)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(661, 22)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Drag && Drop GIF Here"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_AnimationInfo
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 336)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_AnimationInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animation Info"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_FramesCount As Label
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Delay As Label
    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents Label_AnimationInfo As Label
    Friend WithEvents Panel1 As Panel
End Class
