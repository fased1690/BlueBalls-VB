'Fabio
'jan, 2, 2015
'The rules form

Public Class Rules  'Rules form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()       'Hides the form when the button isw clicked
    End Sub

    Private Sub Rules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRules.Text = "  Rules" & vbCrLf _
             & "- Use the arrow keys to move the player" & vbCrLf _
             & "- Do not touch any of the balls. (Making contact with the balls will cause failure of game)" & vbCrLf _
             & "- The longer you last the more balls will spawn" & vbCrLf _
             & "- There is a timer located in the top left corner"      'Writes the rules onto the form
    End Sub

    Private Sub lblRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRules.Click

    End Sub
End Class