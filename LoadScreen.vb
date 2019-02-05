'Fabio
'Dec 25, 2014
'loading screen
Public Class LoadScreen 'The load screen

    Private Sub LoadScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadT.Start()   'Timer starts
        Me.Show()   'Shows the form
    End Sub

    Private Sub loadT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadT.Tick
        LoadBar.Increment(2)    ' The bar will go up by 1 each tick
        If LoadBar.Value = LoadBar.Maximum Then 'If hits the end of the bar
            Me.Hide()   'This window will close
            form1.Show()    'Game will show
            loadT.Start()    'makes it so the form doesn't show again
        End If
    End Sub
End Class