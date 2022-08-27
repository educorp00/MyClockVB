
Imports Microsoft.Win32
Public Class Display

    Dim ET
    Dim ssreason As Integer = 8
    Private Sub secTimer_Tick(sender As Object, e As EventArgs) Handles secTimer.Tick

        If ssreason = 8 Then 'lock状態でないとき
            ET = ET + 1
            My.Settings.ET = ET

            If My.Settings.DAY.Date <> DateTime.Now.Date Then
                ET = 0
                My.Settings.DAY = Date.Now
            End If
            My.Settings.Save()
            SetDisplayTime()
        End If
    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sessionswitch reasonで実行ユーザーのlock/unlockを取得可能　ネットにあまり情報がない
        AddHandler SystemEvents.SessionSwitch, AddressOf SessionSwitch


        ET = My.Settings.ET
        'If My.Settings.DAY.Date <> DateTime.Now.Date Then
        'ET = 0
        'End If

        'SetDisplayTime()
    End Sub

    Private Sub SetDisplayTime()
        'timeNow.Text = DateTime.Now.ToString("HH時mm分 ss秒")
        Dim ts As TimeSpan = New TimeSpan(0, 0, ET)
        Dim Enddot As String
        If (ET Mod 2) = 0 Then
            Enddot = "."
        Else Enddot = " "
        End If
        Dim hms As String = ts.ToString("hh\:mm")
        timeNow.Text = " " & hms & " " & Enddot
        'My.Settings.DAY = Date.Now

    End Sub


    Private Sub SessionSwitch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        ssreason = e.Reason
    End Sub

    Private Sub timeNow_Click(sender As Object, e As EventArgs) Handles timeNow.Click

    End Sub
End Class



