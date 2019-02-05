'Fabio
'Dec 16, 2014
'Dodge ball game
'Rules:
'Use arrow keys to move
'don't touch the balls
'See how long you can last
Public Class form1
    Dim Upc As Boolean  'If key up is pressed
    Dim Downc As Boolean    '"" down
    Dim Leftc As Boolean    '"" Left
    Dim Rightc As Boolean   '"" Right
    Dim pbWalls(3) As PictureBox    'Array of picture boxes for the walls=
    Dim pbBall(3) As PictureBox
    Dim gameTimer As Integer = 0    'Game timer
    Dim ballnum As Integer
    Public playerSpeed As Integer
    Dim infile As System.IO.StreamReader        'File reader
    Dim scoreWriter As System.IO.StreamWriter   'File writer
    Public hardHigh As Integer      'The high scores
    Public normHigh As Integer
    Public easyHigh As Integer
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

    Private Sub form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp   'When a key is realesed
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
            pbBox.Top -= playerSpeed  'Will move up 3 units until the key is realesed
            For index = 0 To 3 'Lopp throught all the walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If they touch one of the walls
                    pbBox.Top += playerSpeed  'Will stop moving
                End If
            Next
        End If
        If Downc = True Then    'If down = True
            pbBox.Top += playerSpeed  'Will move down 3
            For index = 0 To 3
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then 'If they hit a wall they will stop moving
                    pbBox.Top -= playerSpeed
                End If
            Next
        End If
        If Leftc = True Then    'If left key is pressed
            pbBox.Left -= playerSpeed 'Will move left 3 units
            For index = 0 To 3  'Loop through all they walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If they touch one of the walls
                    pbBox.Left += playerSpeed 'Will  stop moving
                End If
            Next
        End If
        If Rightc = True Then   'When right = True
            pbBox.Left += playerSpeed 'Will move right 3 units
            For index = 0 To 3  'Checking all the walls
                If Me.pbBox.Bounds.IntersectsWith(pbWalls(index).Bounds) Then   'If one of the walls are touched
                    pbBox.Left -= playerSpeed  'Will stop moving
                End If
            Next
        End If
    End Sub
    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbWalls(0) = Me.pbTop       'Assigning the arrays to their picture box
        pbWalls(1) = Me.pbLeft
        pbWalls(2) = Me.pbRight
        pbWalls(3) = Me.pbBottom
        pbBall(0) = Me.pbBall1  'Assintion for balls
        pbBall(1) = Me.pbBall2
        pbBall(2) = Me.pbBall3
        pbBall(3) = Me.pbBall4
        playerSpeed = 4     'Default player speed
        difficulty.rbNorm.Checked = True 'Auto sets the game to normal
        ballnum = 2 'Ball counter for balls getiing added over time
        Me.Hide()   'When the game starts
        LoadScreen.Show()
        btnRestart.Enabled = False  'Has these buttons disabled
        btnClose.Enabled = True
        My.Computer.Audio.Play(My.Resources.Ben_Howard___Promise, AudioPlayMode.BackgroundLoop) 'Song
        infile = New System.IO.StreamReader("highScore.txt") 'Reads the file
        hardHigh = infile.ReadLine      'Reads the 3 lines
        easyHigh = infile.ReadLine
        normHigh = infile.ReadLine
        infile.Close()
    End Sub

    Private Sub upT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upT.Tick 'Ball goes up
        pbBall1.Top -= 3
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top 
                upT.Enabled = False
                downT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
            End If
        Next
    End Sub

    Private Sub downT_Tick(sender As System.Object, e As System.EventArgs) Handles downT.Tick
        pbBall1.Top += 3
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then ' if hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wal
                downT.Enabled = False
                upT.Enabled = True
            End If
        Next
    End Sub

    Private Sub rightT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightT.Tick
        pbBall1.Left += 4
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT.Enabled = False
                downT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT.Enabled = False
                leftT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'If bottom bottom wall
                downT.Enabled = False
                upT.Enabled = True
            End If
        Next
    End Sub

    Private Sub leftT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftT.Tick
        pbBall1.Left -= 4
        For index = 0 To 3
            If Me.pbBall1.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT.Enabled = False
                downT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT.Enabled = False
                rightT.Enabled = True
            ElseIf Me.pbBall1.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT.Enabled = False
                upT.Enabled = True
            End If
        Next
    End Sub

    Private Sub DeathAnime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeathAnime.Tick
        Dim deathCountAnime As Single = 0 'For death animation
        
        For ball = 0 To ballnum
            If Me.pbBox.Bounds.IntersectsWith(pbBall(ball).Bounds) Then  'If player hits ball
                MovementT.Enabled = False       'Movement of player will stop
                upT.Enabled = False         'Ball stops moving
                downT.Enabled = False
                leftT.Enabled = False
                rightT.Enabled = False
                upT2.Enabled = False         'Ball stops moving
                downT2.Enabled = False       ' "  the same all the way to the up arrow"
                leftT2.Enabled = False
                rightT2.Enabled = False
                upT3.Enabled = False
                downT3.Enabled = False
                leftT3.Enabled = False
                rightT3.Enabled = False
                upT4.Enabled = False
                downT4.Enabled = False
                leftT4.Enabled = False
                rightT4.Enabled = False             ' "  ^  "
                GameTime.Enabled = False
                Upc = False             'Player stops moving
                Downc = False
                Leftc = False
                Rightc = False
                My.Computer.Audio.Stop()  'Stops music
                My.Computer.Audio.Play(My.Resources.Ben_Howard___Promise, AudioPlayMode.BackgroundLoop)
                Do Until deathCountAnime = 2        'Player will move up a little for the death animation
                    deathCountAnime = deathCountAnime + 0.25
                    pbBox.Top -= 3
                Loop
                DeathAnime.Enabled = False  'Death annimation will stop
                DeathAnimation.Enabled = True   'Player will then move down
            End If
        Next
    End Sub

    Private Sub DeathAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeathAnimation.Tick
        pbBox.Top += 9
        If Me.pbBox.Bounds.IntersectsWith(pbDead.Bounds) Then   'So they dont keep going off the scren it will hit barier and stop
            pbBox.Top -= 9
            DeathAnimation.Enabled = False  'Stops the movement
            Me.Hide()
            btnRestart.Enabled = True   'Enables these buttons
            btnClose.Enabled = True
            btnRules.Enabled = True
            btnHigh.Enabled = True
            If difficulty.rbHard.Checked = True Then    'If the diffuculty is high
                If gameTimer > hardHigh Then
                    hardHigh = gameTimer
                End If
            ElseIf difficulty.rbEasy.Checked = True Then    'if the diffuculty is easy
                If gameTimer > easyHigh Then
                    easyHigh = gameTimer
                End If
            Else                    'It defaults to normal
                If gameTimer > normHigh Then
                    normHigh = gameTimer
                End If
            End If
        End If
        scoreWriter = New System.IO.StreamWriter("highScore.txt")   'Writes to file
        scoreWriter.WriteLine(hardHigh) 'writes the 3 lines
        scoreWriter.WriteLine(easyHigh)
        scoreWriter.WriteLine(normHigh)
        scoreWriter.Close()     'Close file
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        DeathAnime.Enabled = True  'Starts timers
        btnStart.Enabled = False    'Disables button
        MovementT.Enabled = True        'Allows movement to begin
        GameTime.Enabled = True         'Timer starts
        btnRules.Enabled = False    'Disabled these button
        btnClose.Enabled = False
        btnDiff.Enabled = False
        btnHigh.Enabled = False
        My.Computer.Audio.Stop()    'Stops old music
        My.Computer.Audio.Play(My.Resources.Darude___Sandstorm, AudioPlayMode.BackgroundLoop)   'Starts game music
        lblTitle.Text = Nothing
    End Sub

    Private Sub upT2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upT2.Tick
        pbBall2.Top -= 4
        For index = 0 To 3
            If Me.pbBall2.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top 
                upT2.Enabled = False
                downT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT2.Enabled = False
                leftT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT2.Enabled = False
                rightT2.Enabled = True
            End If
        Next
    End Sub

    Private Sub downT2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downT2.Tick
        pbBall2.Top += 4
        For index = 0 To 3
            If Me.pbBall2.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT2.Enabled = False
                rightT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(2).Bounds) Then ' if hits right wall
                rightT2.Enabled = False
                leftT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wal
                downT2.Enabled = False
                upT2.Enabled = True
            End If
        Next
    End Sub

    Private Sub leftT2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftT2.Tick
        pbBall2.Left -= 3
        For index = 0 To 3
            If Me.pbBall2.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT2.Enabled = False
                downT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT2.Enabled = False
                rightT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT2.Enabled = False
                upT2.Enabled = True
            End If
        Next
    End Sub

    Private Sub rightT2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightT2.Tick
        pbBall2.Left += 3
        For index = 0 To 3
            If Me.pbBall2.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT2.Enabled = False
                downT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT2.Enabled = False
                leftT2.Enabled = True
            ElseIf Me.pbBall2.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'If bottom bottom wall
                downT2.Enabled = False
                upT2.Enabled = True
            End If
        Next
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        gameTimer = 0
        Me.Close()  'Restarts the program   (restarts the program because if the laod bar is full it will load this form again
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End 'Ends the program
    End Sub

    Private Sub GameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTime.Tick
        gameTimer += 1  'Game timer being added up
        lblTime.Text = "Score: " & gameTimer    'Game timer printed
        If gameTimer = 15 Then      'When the game hits 15 seconds another ball is added
            pbBall4.Image = Image.FromFile("blueBall.png")
            upT4.Enabled = True
            rightT4.Enabled = True
            ballnum = 3         'Changes the collision control variable
        End If
    End Sub

    Private Sub upT3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upT3.Tick 'Up movement
        pbBall3.Top -= 3        'Will move up 3
        For index = 0 To 3
            If Me.pbBall3.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top 
                upT3.Enabled = False
                downT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT3.Enabled = False
                leftT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT3.Enabled = False
                rightT3.Enabled = True
            End If
        Next
    End Sub

    Private Sub downT3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downT3.Tick 'Down movement for ball 3
        pbBall3.Top += 3        'Will move down 3
        For index = 0 To 3
            If Me.pbBall3.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT3.Enabled = False
                rightT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(2).Bounds) Then ' if hits right wall
                rightT3.Enabled = False
                leftT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wal
                downT3.Enabled = False
                upT3.Enabled = True
            End If
        Next
    End Sub

    Private Sub leftT3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftT3.Tick 'Left movement
        pbBall3.Left -= 4       'Will move left 4
        For index = 0 To 3
            If Me.pbBall3.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT3.Enabled = False
                downT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT3.Enabled = False
                rightT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT3.Enabled = False
                upT3.Enabled = True
            End If
        Next
    End Sub

    Private Sub rightT3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightT3.Tick   'Right movement
        pbBall3.Left += 4       'Will move right 4
        For index = 0 To 3
            If Me.pbBall3.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT3.Enabled = False
                downT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT3.Enabled = False
                leftT3.Enabled = True
            ElseIf Me.pbBall3.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'If bottom bottom wall
                downT3.Enabled = False
                upT3.Enabled = True
            End If
        Next
    End Sub

    Private Sub upT4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upT4.Tick 'Up timer for ball4
        pbBall4.Top -= 4
        For index = 0 To 3
            If Me.pbBall4.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top 
                upT4.Enabled = False
                downT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT4.Enabled = False
                leftT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT4.Enabled = False
                rightT4.Enabled = True
            End If
        Next
    End Sub
    Private Sub downT4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downT4.Tick 'downt for ball 4
        pbBall4.Top += 4
        For index = 0 To 3
            If Me.pbBall4.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT4.Enabled = False
                rightT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(2).Bounds) Then ' if hits right wall
                rightT4.Enabled = False
                leftT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wal
                downT4.Enabled = False
                upT4.Enabled = True
            End If
        Next
    End Sub

    Private Sub leftT4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leftT4.Tick 'leftT for ball 4
        pbBall4.Left -= 3
        For index = 0 To 3
            If Me.pbBall4.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT4.Enabled = False
                downT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(1).Bounds) Then 'if hits left wall
                leftT4.Enabled = False
                rightT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'if hits bottom wall
                downT4.Enabled = False
                upT4.Enabled = True
            End If
        Next
    End Sub

    Private Sub rightT4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rightT4.Tick   'RightT for ball4
        pbBall4.Left += 3
        For index = 0 To 3
            If Me.pbBall4.Bounds.IntersectsWith(pbWalls(0).Bounds) Then 'If hits top wall
                upT4.Enabled = False
                downT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(2).Bounds) Then 'If hits right wall
                rightT4.Enabled = False
                leftT4.Enabled = True
            ElseIf Me.pbBall4.Bounds.IntersectsWith(pbWalls(3).Bounds) Then 'If bottom bottom wall
                downT4.Enabled = False
                upT4.Enabled = True
            End If
        Next
    End Sub

    Private Sub btnRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRules.Click
        Rules.ShowDialog()      'Will show the game rules form
    End Sub

    Private Sub btnDiff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiff.Click
        difficulty.ShowDialog() 'For diffuculty selection
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        High.ShowDialog()   'To show the high scores
    End Sub
End Class
