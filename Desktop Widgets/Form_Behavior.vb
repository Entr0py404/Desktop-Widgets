Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form_Behavior
    Public PetType As String
    Public PetDir As String
    ' Form_Behavior - Load
    Private Sub Form_Behavior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "\" & PetDir & "\Behavior.ini") Then
            Try
                Dim INI As New MadMilkman.Ini.IniFile()
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
            If PetType = "Flying" Then
                'load default values for Flying pets
            Else
                'load default values for Ground pets
            End If
        End If
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If PetType = "Flying" Then

        Else

        End If
    End Sub
End Class