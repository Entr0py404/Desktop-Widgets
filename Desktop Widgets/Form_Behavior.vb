Imports MadMilkman.Ini

Public Class Form_Behavior
    Public PetType As String
    Public PetDir As String
    ' [Settings]
    Dim Default_DefaultScale As Integer = 1
    Dim Default_FollowCursor_StoppingDistance_Px As Integer = 6
    Dim Default_Falling_Movement_Px As Integer = 5
    Dim Default_Opacity As Integer = 1
    ' [Decisions]
    Dim Default_IdleDecision As Integer = 45
    Dim Default_IdleAltDecision As Integer = 35
    Dim Default_TakeFlightDecision As Integer = 60
    Dim Default_ScreenWarpingDecision As Integer = 60
    Dim Default_LandingDecision As Integer = 45
    Dim Default_SleepDecision As Integer = 5
    ' [Timers_Tick]
    Dim Default_Flying_Movement_Tick As Integer = 1
    Dim Default_Walking_Movement_Tick As Integer = 1
    Dim Default_Falling_Movement_Tick As Integer = 1
    ' [Timers_Randomization]
    Dim Default_TurningDecision_Min As Integer = 2500
    Dim Default_TurningDecision_Max As Integer = 3500
    Dim Default_IdleDecision_Min As Integer = 2500
    Dim Default_IdleDecision_Max As Integer = 3500
    Dim Default_TakeFlightDecision_Min As Integer = 3500
    Dim Default_TakeFlightDecision_Max As Integer = 5000
    Dim Default_SleepingDecision_Min As Integer = 90000
    Dim Default_SleepingDecision_Max As Integer = 150000

    ' Form_Behavior - Load
    Private Sub Form_Behavior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        If File.Exists(Application.StartupPath & "\" & PetDir & "\Behavior.ini") Then
            Try
                Dim INI As New IniFile()
                INI.Load(Application.StartupPath & "\" & PetDir & "\Behavior.ini")

                ' [Settings]
                If INI.Sections("Settings") IsNot Nothing Then
                    If INI.Sections("Settings").Keys("DefaultScale") IsNot Nothing Then
                        NumericUpDown_DefaultScale.Value = CInt(INI.Sections("Settings").Keys("DefaultScale").Value)
                    End If

                    If INI.Sections("Settings").Keys("FollowCursor_StoppingDistance_Px") IsNot Nothing Then
                        NumericUpDown_FollowCursorStoppingDistance_Px.Value = CInt(INI.Sections("Settings").Keys("FollowCursor_StoppingDistance_Px").Value)
                    End If

                    If INI.Sections("Settings").Keys("Falling_Movement_Px") IsNot Nothing Then
                        NumericUpDown_FallingMovement_Px.Value = CInt(INI.Sections("Settings").Keys("Falling_Movement_Px").Value)
                    End If

                    If INI.Sections("Settings").Keys("Opacity") IsNot Nothing Then
                        NumericUpDown_Opacity.Value = CDec(INI.Sections("Settings").Keys("Opacity").Value)
                    End If
                End If

                ' [Decisions]
                If INI.Sections("Decisions") IsNot Nothing Then
                    If INI.Sections("Decisions").Keys("IdleDecision") IsNot Nothing Then
                        NumericUpDown_IdleDecision.Value = CInt(INI.Sections("Decisions").Keys("IdleDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("IdleAltDecision") IsNot Nothing Then
                        NumericUpDown_IdleAltDecision.Value = CInt(INI.Sections("Decisions").Keys("IdleAltDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("TakeFlightDecision") IsNot Nothing Then
                        NumericUpDown_TakeFlightDecision.Value = CInt(INI.Sections("Decisions").Keys("TakeFlightDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("ScreenWarpingDecision") IsNot Nothing Then
                        NumericUpDown_ScreenWarpingDecision.Value = CInt(INI.Sections("Decisions").Keys("ScreenWarpingDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("LandingDecision") IsNot Nothing Then
                        NumericUpDown_LandingDecision.Value = CInt(INI.Sections("Decisions").Keys("LandingDecision").Value)
                    End If

                    If INI.Sections("Decisions").Keys("SleepDecision") IsNot Nothing Then
                        NumericUpDown_SleepDecision.Value = CInt(INI.Sections("Decisions").Keys("SleepDecision").Value)
                    End If
                End If

                ' [Timers_Tick]
                If INI.Sections("Timers_Tick") IsNot Nothing Then
                    If INI.Sections("Timers_Tick").Keys("Flying_Movement_Tick") IsNot Nothing Then
                        NumericUpDown_FlyingMovement_Tick.Value = CInt(INI.Sections("Timers_Tick").Keys("Flying_Movement_Tick").Value)
                    End If

                    If INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick") IsNot Nothing Then
                        NumericUpDown_WalkingMovement_Tick.Value = CInt(INI.Sections("Timers_Tick").Keys("Walking_Movement_Tick").Value)
                    End If

                    If INI.Sections("Timers_Tick").Keys("Falling_Movement_Tick") IsNot Nothing Then
                        NumericUpDown_FallingMovement_Tick.Value = CInt(INI.Sections("Timers_Tick").Keys("Falling_Movement_Tick").Value)
                    End If
                End If

                ' [Timers_Randomization]
                If INI.Sections("Timers_Randomization") IsNot Nothing Then
                    If INI.Sections("Timers_Randomization").Keys("TurningDecision_Min") IsNot Nothing Then
                        NumericUpDown_TurningDecision_Min.Value = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("TurningDecision_Max") IsNot Nothing Then
                        NumericUpDown_TurningDecision_Max.Value = CInt(INI.Sections("Timers_Randomization").Keys("TurningDecision_Max").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("IdleDecision_Min") IsNot Nothing Then
                        NumericUpDown_IdleDecision_Min.Value = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("IdleDecision_Max") IsNot Nothing Then
                        NumericUpDown_IdleDecision_Max.Value = CInt(INI.Sections("Timers_Randomization").Keys("IdleDecision_Max").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Min") IsNot Nothing Then
                        NumericUpDown_TakeFlightDecision_Min.Value = CInt(INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Max") IsNot Nothing Then
                        NumericUpDown_TakeFlightDecision_Max.Value = CInt(INI.Sections("Timers_Randomization").Keys("TakeFlightDecision_Max").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("SleepingDecision_Min") IsNot Nothing Then
                        NumericUpDown_SleepingDecision_Min.Value = CInt(INI.Sections("Timers_Randomization").Keys("SleepingDecision_Min").Value)
                    End If

                    If INI.Sections("Timers_Randomization").Keys("SleepingDecision_Max") IsNot Nothing Then
                        NumericUpDown_SleepingDecision_Max.Value = CInt(INI.Sections("Timers_Randomization").Keys("SleepingDecision_Max").Value)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            ' [Settings]
            NumericUpDown_DefaultScale.Value = Default_DefaultScale
            NumericUpDown_FollowCursorStoppingDistance_Px.Value = Default_FollowCursor_StoppingDistance_Px
            NumericUpDown_FallingMovement_Px.Value = Default_Falling_Movement_Px
            NumericUpDown_Opacity.Value = Default_Opacity

            ' [Decisions]
            NumericUpDown_IdleDecision.Value = Default_IdleDecision
            NumericUpDown_IdleAltDecision.Value = Default_IdleAltDecision
            NumericUpDown_TakeFlightDecision.Value = Default_TakeFlightDecision
            NumericUpDown_ScreenWarpingDecision.Value = Default_ScreenWarpingDecision
            NumericUpDown_LandingDecision.Value = Default_LandingDecision
            NumericUpDown_SleepDecision.Value = Default_SleepDecision

            ' [Timers_Tick]
            NumericUpDown_FlyingMovement_Tick.Value = Default_Flying_Movement_Tick
            NumericUpDown_WalkingMovement_Tick.Value = Default_Walking_Movement_Tick
            NumericUpDown_FallingMovement_Tick.Value = Default_Falling_Movement_Tick

            ' [Timers_Randomization]
            NumericUpDown_TurningDecision_Min.Value = Default_TurningDecision_Min
            NumericUpDown_TurningDecision_Max.Value = Default_TurningDecision_Max
            NumericUpDown_IdleDecision_Min.Value = Default_IdleDecision_Min
            NumericUpDown_IdleDecision_Max.Value = Default_IdleDecision_Max
            NumericUpDown_TakeFlightDecision_Min.Value = Default_TakeFlightDecision_Min
            NumericUpDown_TakeFlightDecision_Max.Value = Default_TakeFlightDecision_Max
            NumericUpDown_SleepingDecision_Min.Value = Default_SleepingDecision_Min
            NumericUpDown_SleepingDecision_Max.Value = Default_SleepingDecision_Max
        End If
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If PetType = "Flying" Then
            Dim iniOptions As New IniOptions()
            iniOptions.KeySpaceAroundDelimiter = True
            Dim Behavior_inifile As New IniFile(iniOptions)

            ' [Settings]
            Dim Section_settings As IniSection = Behavior_inifile.Sections.Add("Settings")
            Section_settings.Keys.Add("DefaultScale", NumericUpDown_DefaultScale.Value.ToString)
            Section_settings.Keys.Add("FollowCursor_StoppingDistance_Px", NumericUpDown_FollowCursorStoppingDistance_Px.Value.ToString)
            Section_settings.Keys.Add("Opacity", NumericUpDown_Opacity.Value.ToString)


            ' [Decisions]
            Dim Section_decisions As IniSection = Behavior_inifile.Sections.Add("Decisions")


            ' [Timers_Tick]
            Dim Section_timers_tick As IniSection = Behavior_inifile.Sections.Add("Timers_Tick")


            ' [Timers_Randomization]
            Dim Section_timers_randomization As IniSection = Behavior_inifile.Sections.Add("Timers_Randomization")


            ' Save file.
            Behavior_inifile.Save(Application.StartupPath & "\" & PetDir & "\Behavior.ini")
        Else
            Dim iniOptions As New IniOptions()
            iniOptions.KeySpaceAroundDelimiter = True
            Dim Behavior_inifile As New IniFile(iniOptions)

            ' [Settings]
            Dim Section_settings As IniSection = Behavior_inifile.Sections.Add("Settings")
            Section_settings.Keys.Add("DefaultScale", NumericUpDown_DefaultScale.Value.ToString)
            Section_settings.Keys.Add("FollowCursor_StoppingDistance_Px", NumericUpDown_FollowCursorStoppingDistance_Px.Value.ToString)
            Section_settings.Keys.Add("Falling_Movement_Px", NumericUpDown_FallingMovement_Px.Value.ToString)
            Section_settings.Keys.Add("Opacity", NumericUpDown_Opacity.Value.ToString)

            ' [Decisions]
            Dim Section_decisions As IniSection = Behavior_inifile.Sections.Add("Decisions")


            ' [Timers_Tick]
            Dim Section_timers_tick As IniSection = Behavior_inifile.Sections.Add("Timers_Tick")


            ' [Timers_Randomization]
            Dim Section_timers_randomization As IniSection = Behavior_inifile.Sections.Add("Timers_Randomization")


            ' Save file.
            Behavior_inifile.Save(Application.StartupPath & "\" & PetDir & "\Behavior.ini")
        End If
    End Sub

    'ResetToDefaultToolStripMenuItem - Click
    Private Sub ResetToDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToDefaultToolStripMenuItem.Click
        Dim sourceControl As Control = ContextMenuStrip1.SourceControl

        If sourceControl IsNot Nothing Then
            ' [Settings]
            If sourceControl.Name = "NumericUpDown_DefaultScale" Then
                NumericUpDown_DefaultScale.Value = Default_DefaultScale
            ElseIf sourceControl.Name = "NumericUpDown_Opacity" Then
                NumericUpDown_Opacity.Value = Default_Opacity
            ElseIf sourceControl.Name = "NumericUpDown_FollowCursorStoppingDistance_Px" Then
                NumericUpDown_FollowCursorStoppingDistance_Px.Value = Default_FollowCursor_StoppingDistance_Px
            ElseIf sourceControl.Name = "NumericUpDown_FallingMovement_Px" Then
                NumericUpDown_FallingMovement_Px.Value = Default_Falling_Movement_Px

                ' [Decisions]
            ElseIf sourceControl.Name = "NumericUpDown_IdleDecision" Then
                NumericUpDown_IdleDecision.Value = Default_IdleDecision
            ElseIf sourceControl.Name = "NumericUpDown_IdleAltDecision" Then
                NumericUpDown_IdleAltDecision.Value = Default_IdleAltDecision
            ElseIf sourceControl.Name = "NumericUpDown_ScreenWarpingDecision" Then
                NumericUpDown_ScreenWarpingDecision.Value = Default_ScreenWarpingDecision
            ElseIf sourceControl.Name = "NumericUpDown_SleepDecision" Then
                NumericUpDown_SleepDecision.Value = Default_SleepDecision
            ElseIf sourceControl.Name = "NumericUpDown_TakeFlightDecision" Then
                NumericUpDown_TakeFlightDecision.Value = Default_TakeFlightDecision
            ElseIf sourceControl.Name = "NumericUpDown_LandingDecision" Then
                NumericUpDown_LandingDecision.Value = Default_LandingDecision

                ' [Timers_Tick]
            ElseIf sourceControl.Name = "NumericUpDown_WalkingMovement_Tick" Then
                NumericUpDown_WalkingMovement_Tick.Value = Default_Walking_Movement_Tick
            ElseIf sourceControl.Name = "NumericUpDown_FlyingMovement_Tick" Then
                NumericUpDown_FlyingMovement_Tick.Value = Default_Flying_Movement_Tick
            ElseIf sourceControl.Name = "NumericUpDown_FallingMovement_Tick" Then
                NumericUpDown_FallingMovement_Tick.Value = Default_Falling_Movement_Tick

                ' [Timers_Randomization]
            ElseIf sourceControl.Name = "NumericUpDown_TurningDecision_Min" Then
                NumericUpDown_TurningDecision_Min.Value = Default_TurningDecision_Min
            ElseIf sourceControl.Name = "NumericUpDown_TurningDecision_Max" Then
                NumericUpDown_TurningDecision_Max.Value = Default_TurningDecision_Max
            ElseIf sourceControl.Name = "NumericUpDown_IdleDecision_Min" Then
                NumericUpDown_IdleDecision_Min.Value = Default_IdleDecision_Min
            ElseIf sourceControl.Name = "NumericUpDown_IdleDecision_Max" Then
                NumericUpDown_IdleDecision_Max.Value = Default_IdleDecision_Max
            ElseIf sourceControl.Name = "NumericUpDown_TakeFlightDecision_Min" Then
                NumericUpDown_TakeFlightDecision_Min.Value = Default_TakeFlightDecision_Min
            ElseIf sourceControl.Name = "NumericUpDown_TakeFlightDecision_Max" Then
                NumericUpDown_TakeFlightDecision_Max.Value = Default_TakeFlightDecision_Max
            ElseIf sourceControl.Name = "NumericUpDown_SleepingDecision_Min" Then
                NumericUpDown_SleepingDecision_Min.Value = Default_SleepingDecision_Min
            ElseIf sourceControl.Name = "NumericUpDown_SleepingDecision_Max" Then
                NumericUpDown_SleepingDecision_Max.Value = Default_SleepingDecision_Max
            End If
            Console.WriteLine("Right-clicked on: " & sourceControl.Name)
        End If
    End Sub
End Class