'Fabio
'Dec 14, 2014
'Highscores are shown on this form
Public Class High   'Highscore page

    Private Sub High_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load   'Text for high scores

        txtHigh.Text = "Easy highscore: " & vbTab & form1.easyHigh _
            & vbCrLf & vbCrLf & "Normal highscore: " & vbTab & form1.normHigh _
            & vbCrLf & vbCrLf & "Hard highscore: " & vbTab & form1.hardHigh     'Shows thew highscores
    End Sub
End Class