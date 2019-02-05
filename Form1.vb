'Fabio
'Dec 16, 2014
'A dodge ball game
Public Class pbMe
    Dim Upc As Boolean  'If key up is pressed
    Dim Downc As Boolean    '"" down
    Dim Leftc As Boolean    '"" Left
    Dim Rightc As Boolean   '"" Right
    Dim pbWalls(3) As PictureBox    'Array of picture boxes for the walls
    Dim ball As PictureBox
    Dim rdmDirection As Integer
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown  'If a key is pressed down
        If e.KeyCode = Keys.Up Then 'When the up key is pressed
            Upc = True  'Up = True 
        End If
        If e.KeyCode = Keys.Down Then   'If the down key is pressed
            Downc = True        'down = True
        End If
        If e.KeyCode = Keys.Right Then  'If the right key is pressed
            Rightc = True   'Right = True
            pbBox.Image = Image.FromFile("one(left).png")   'The direction the person is looking "He is looking left"
        End If
        If e.KeyCode = Keys.Left Then   'When left key is pressed
            Leftc = True
            pbBox.Image = Image.FromFile("one(right).png")  'The sprites is looking right
        End If
    End Sub

    Private Sub pbMe_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp   'When a key is realesed
        If e.KeyCode = Keys.Up Then 'if the up key was pressed and then realesed
            Upc = False 'Up = False
        End If
        If e.KeyCode = Keys.Down Then   'If the down key was pressed and then realesed
            Downc = False   'Down = False
        End If
        If e.KeyCode = Keys.Right Then  'If the right key was pressed and then realesed
            Rightc = False  'Right = False
        End If
        If e.KeyCode = Keys.Left Then   'When the left key is pressed
            Leftc = False   'left = False
        End If
    End Sub

    Private Sub MovementT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovementT.Tick 'For each time the tick changes the following will happen
        If Upc = True Then  'If up = True
            pbBox.Top -= 3  'Will move up 3 units until the key is realesed
            For index = 0 To 3 'Lopp throught all the walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If they touch one of the walls
                    pbBox.Top += 3  'Will stop moving
                End If
            Next
        End If
        If Downc = True Then    'If down = True
            pbBox.Top += 3  'Will move down 3
            For index = 0 To 3
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then 'If they hit a wall they will stop moving
                    pbBox.Top -= 3
                End If
            Next
        End If
        If Leftc = True Then    'If left key is pressed
            pbBox.Left -= 3 'Will move left 3 units
            For index = 0 To 3  'Loop through all they walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If they touch one of the walls
                    pbBox.Left += 3 'Will  stop moving
                End If
            Next
        End If
        If Rightc = True Then   'When right = True
            pbBox.Left += 3 'Will move right 3 units
            For index = 0 To 3  'Checking all the walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If one of the walls are touched
                    pbBox.Left -= 3  'Will stop moving
                End If
            Next
        End If
    End Sub

    Private Sub pbMe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbWalls(0) = Me.pbTop       'Assigning the arrays to their picture box
        pbWalls(1) = Me.pbLeft
        pbWalls(2) = Me.pbRight
        pbWalls(3) = Me.pbBottom
        ball = Me.pbBall1
    End Sub

    Private Sub upT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upT.Tick
        pbBall1.Top -= 3
        Randomize()
        rdmDirection = Int(Rnd() * 3) + 1
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top 
                upT.Enabled = False
                downT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    rightT.Enabled = False
                    leftT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = True
                    rightT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = True
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'If hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    rightT.Enabled = False
                    leftT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = True
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
                If rdmDirection = 1 Then
                    rightT.Enabled = False
                    leftT.Enabled = True
                    upT.Enabled = False
                    downT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    rightT.Enabled = False
                    leftT.Enabled = True
                    upT.Enabled = False
                    downT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    rightT.Enabled = False
                    leftT.Enabled = True
                    upT.Enabled = True
                    downT.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub downT_Tick(sender As System.Object, e As System.EventArgs) Handles downT.Tick
        pbBall1.Top += 3
        Randomize()
        rdmDirection = Int(Rnd() * 3) + 1
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
                If rdmDirection = 1 Then
                    leftT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = False
                    rightT.Enabled = True
                ElseIf rdmDirection = 2 Then
                    leftT.Enabled = False
                    downT.Enabled = False
                    rightT.Enabled = True
                    upT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    leftT.Enabled = False
                    rightT.Enabled = True
                    upT.Enabled = False
                    downT.Enabled = True
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'if hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
                If rdmDirection = 1 Then
                    rightT.Enabled = False
                    downT.Enabled = False
                    leftT.Enabled = True
                    upT.Enabled = True
                ElseIf rdmDirection = 2 Then
                    downT.Enabled = False
                    rightT.Enabled = False
                    upT.Enabled = False
                    leftT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    rightT.Enabled = False
                    upT.Enabled = False
                    leftT.Enabled = True
                    downT.Enabled = True

                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT.Enabled = False
                upT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = False
                    rightT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = True
                    rightT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    downT.Enabled = False
                    upT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub rightT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightT.Tick
        If rightT.Enabled = True And leftT.Enabled = False And downT.Enabled = False And upT.Enabled = False Then
            pbBall1.Left += 7
        Else
            pbBall1.Left += 3
        End If
        Randomize()
        rdmDirection = Int(Rnd() * 3) + 1
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT.Enabled = False
                downT.Enabled = True
                If rdmDirection = 1 Then
                    rightT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = True
                ElseIf rdmDirection = 2 Then
                    rightT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    rightT.Enabled = True
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
                If rdmDirection = 1 Then
                    leftT.Enabled = True
                    rightT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    rightT.Enabled = False
                    upT.Enabled = False
                    leftT.Enabled = True
                    downT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    rightT.Enabled = False
                    downT.Enabled = False
                    leftT.Enabled = True
                    upT.Enabled = True

                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'If bottom bottom wall
                downT.Enabled = False
                upT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    rightT.Enabled = False
                    leftT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = True
                    rightT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = False
                    rightT.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub leftT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftT.Tick
        If leftT.Enabled = True And rightT.Enabled = False And downT.Enabled = False And upT.Enabled = False Then
            pbBall1.Left -= 7
        Else
            pbBall1.Left -= 3
        End If
        Randomize()
        rdmDirection = Int(Rnd() * 3) + 1
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT.Enabled = False
                downT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    rightT.Enabled = True
                    leftT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = True
                ElseIf rdmDirection = 3 Then
                    upT.Enabled = False
                    downT.Enabled = True
                    leftT.Enabled = False
                    rightT.Enabled = False
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
                If rdmDirection = 1 Then
                    rightT.Enabled = True
                    leftT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    rightT.Enabled = True
                    leftT.Enabled = False
                    upT.Enabled = True
                    downT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    rightT.Enabled = True
                    leftT.Enabled = False
                    upT.Enabled = False
                    downT.Enabled = True
                End If
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT.Enabled = False
                upT.Enabled = True
                If rdmDirection = 1 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = False
                    rightT.Enabled = False
                ElseIf rdmDirection = 2 Then
                    upT.Enabled = True
                    rightT.Enabled = True
                    leftT.Enabled = False
                    downT.Enabled = False
                ElseIf rdmDirection = 3 Then
                    upT.Enabled = True
                    downT.Enabled = False
                    leftT.Enabled = True
                    rightT.Enabled = False
                End If
            End If
        Next
    End Sub
End Class
