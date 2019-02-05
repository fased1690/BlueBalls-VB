'Fabio
'Dec 12, 2014
'To change to different diffuculties
Public Class difficulty 'Diffuculty selection
    Private Sub difficulty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        If rbNorm.Checked = True Then   'If norm is checked
            form1.upT.Interval = 16         'All ball mvement timers are set to 16
            form1.upT2.Interval = 16
            form1.upT3.Interval = 16
            form1.upT4.Interval = 16
            form1.downT.Interval = 16
            form1.downT2.Interval = 16
            form1.downT3.Interval = 16
            form1.downT4.Interval = 16
            form1.leftT.Interval = 16
            form1.leftT2.Interval = 16
            form1.leftT3.Interval = 16
            form1.leftT4.Interval = 16
            form1.rightT.Interval = 16
            form1.rightT2.Interval = 16
            form1.rightT3.Interval = 16
            form1.rightT4.Interval = 16
        ElseIf rbEasy.Checked = True Then
            form1.upT.Interval = 25         'If easy all ball timer movements are set to 25
            form1.upT2.Interval = 25
            form1.upT3.Interval = 25
            form1.upT4.Interval = 25
            form1.downT.Interval = 25
            form1.downT2.Interval = 25
            form1.downT3.Interval = 25
            form1.downT4.Interval = 25
            form1.leftT.Interval = 25
            form1.leftT2.Interval = 25
            form1.leftT3.Interval = 25
            form1.leftT4.Interval = 25
            form1.rightT.Interval = 25
            form1.rightT2.Interval = 25
            form1.rightT3.Interval = 25
            form1.rightT4.Interval = 25
        ElseIf rbHard.Checked = True Then
            form1.upT.Interval = 15 'If hard, all ball movement tiemrs are set to 15
            form1.upT2.Interval = 15
            form1.upT3.Interval = 15
            form1.upT4.Interval = 15
            form1.downT.Interval = 15
            form1.downT2.Interval = 15
            form1.downT3.Interval = 15
            form1.downT4.Interval = 15
            form1.leftT.Interval = 15
            form1.leftT2.Interval = 15
            form1.leftT3.Interval = 15
            form1.leftT4.Interval = 15
            form1.rightT.Interval = 15
            form1.rightT2.Interval = 15
            form1.rightT3.Interval = 15
            form1.rightT4.Interval = 15
            form1.playerSpeed = 6       'Player speed also goes up
        End If
        Me.Hide()
    End Sub
End Class