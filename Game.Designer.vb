<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.pbTop = New System.Windows.Forms.PictureBox()
        Me.pbBottom = New System.Windows.Forms.PictureBox()
        Me.pbLeft = New System.Windows.Forms.PictureBox()
        Me.pbRight = New System.Windows.Forms.PictureBox()
        Me.pbBox = New System.Windows.Forms.PictureBox()
        Me.MovementT = New System.Windows.Forms.Timer(Me.components)
        Me.downT = New System.Windows.Forms.Timer(Me.components)
        Me.upT = New System.Windows.Forms.Timer(Me.components)
        Me.rightT = New System.Windows.Forms.Timer(Me.components)
        Me.leftT = New System.Windows.Forms.Timer(Me.components)
        Me.DeathAnime = New System.Windows.Forms.Timer(Me.components)
        Me.DeathAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pbBall1 = New System.Windows.Forms.PictureBox()
        Me.pbBall2 = New System.Windows.Forms.PictureBox()
        Me.upT2 = New System.Windows.Forms.Timer(Me.components)
        Me.downT2 = New System.Windows.Forms.Timer(Me.components)
        Me.leftT2 = New System.Windows.Forms.Timer(Me.components)
        Me.rightT2 = New System.Windows.Forms.Timer(Me.components)
        Me.pbDead = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pbBall3 = New System.Windows.Forms.PictureBox()
        Me.upT3 = New System.Windows.Forms.Timer(Me.components)
        Me.downT3 = New System.Windows.Forms.Timer(Me.components)
        Me.leftT3 = New System.Windows.Forms.Timer(Me.components)
        Me.rightT3 = New System.Windows.Forms.Timer(Me.components)
        Me.upT4 = New System.Windows.Forms.Timer(Me.components)
        Me.leftT4 = New System.Windows.Forms.Timer(Me.components)
        Me.rightT4 = New System.Windows.Forms.Timer(Me.components)
        Me.downT4 = New System.Windows.Forms.Timer(Me.components)
        Me.pbBall4 = New System.Windows.Forms.PictureBox()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnDiff = New System.Windows.Forms.Button()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.pbTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbTop
        '
        Me.pbTop.BackColor = System.Drawing.Color.White
        Me.pbTop.Location = New System.Drawing.Point(8, 10)
        Me.pbTop.Name = "pbTop"
        Me.pbTop.Size = New System.Drawing.Size(615, 13)
        Me.pbTop.TabIndex = 0
        Me.pbTop.TabStop = False
        '
        'pbBottom
        '
        Me.pbBottom.BackColor = System.Drawing.Color.White
        Me.pbBottom.Location = New System.Drawing.Point(7, 275)
        Me.pbBottom.Name = "pbBottom"
        Me.pbBottom.Size = New System.Drawing.Size(616, 14)
        Me.pbBottom.TabIndex = 1
        Me.pbBottom.TabStop = False
        '
        'pbLeft
        '
        Me.pbLeft.BackColor = System.Drawing.Color.White
        Me.pbLeft.Location = New System.Drawing.Point(-6, 12)
        Me.pbLeft.Name = "pbLeft"
        Me.pbLeft.Size = New System.Drawing.Size(30, 283)
        Me.pbLeft.TabIndex = 2
        Me.pbLeft.TabStop = False
        '
        'pbRight
        '
        Me.pbRight.BackColor = System.Drawing.Color.White
        Me.pbRight.Location = New System.Drawing.Point(594, 11)
        Me.pbRight.Name = "pbRight"
        Me.pbRight.Size = New System.Drawing.Size(30, 283)
        Me.pbRight.TabIndex = 3
        Me.pbRight.TabStop = False
        '
        'pbBox
        '
        Me.pbBox.Image = CType(resources.GetObject("pbBox.Image"), System.Drawing.Image)
        Me.pbBox.Location = New System.Drawing.Point(323, 156)
        Me.pbBox.Name = "pbBox"
        Me.pbBox.Size = New System.Drawing.Size(27, 46)
        Me.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBox.TabIndex = 4
        Me.pbBox.TabStop = False
        '
        'MovementT
        '
        Me.MovementT.Interval = 27
        '
        'downT
        '
        Me.downT.Interval = 16
        '
        'upT
        '
        Me.upT.Enabled = True
        Me.upT.Interval = 16
        '
        'rightT
        '
        Me.rightT.Enabled = True
        Me.rightT.Interval = 16
        '
        'leftT
        '
        Me.leftT.Interval = 16
        '
        'DeathAnime
        '
        Me.DeathAnime.Interval = 25
        '
        'DeathAnimation
        '
        Me.DeathAnimation.Interval = 25
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Blue
        Me.btnStart.Location = New System.Drawing.Point(635, 10)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 34)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(599, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 304)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(-7, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(636, 53)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox3.Location = New System.Drawing.Point(-13, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(642, 20)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox4.Location = New System.Drawing.Point(-10, -3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 304)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'pbBall1
        '
        Me.pbBall1.Image = CType(resources.GetObject("pbBall1.Image"), System.Drawing.Image)
        Me.pbBall1.Location = New System.Drawing.Point(116, 156)
        Me.pbBall1.Name = "pbBall1"
        Me.pbBall1.Size = New System.Drawing.Size(30, 30)
        Me.pbBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBall1.TabIndex = 11
        Me.pbBall1.TabStop = False
        '
        'pbBall2
        '
        Me.pbBall2.Image = CType(resources.GetObject("pbBall2.Image"), System.Drawing.Image)
        Me.pbBall2.Location = New System.Drawing.Point(278, 105)
        Me.pbBall2.Name = "pbBall2"
        Me.pbBall2.Size = New System.Drawing.Size(30, 30)
        Me.pbBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBall2.TabIndex = 12
        Me.pbBall2.TabStop = False
        '
        'upT2
        '
        Me.upT2.Interval = 16
        '
        'downT2
        '
        Me.downT2.Enabled = True
        Me.downT2.Interval = 16
        '
        'leftT2
        '
        Me.leftT2.Enabled = True
        Me.leftT2.Interval = 16
        '
        'rightT2
        '
        Me.rightT2.Interval = 16
        '
        'pbDead
        '
        Me.pbDead.BackColor = System.Drawing.Color.White
        Me.pbDead.Location = New System.Drawing.Point(6, 331)
        Me.pbDead.Name = "pbDead"
        Me.pbDead.Size = New System.Drawing.Size(616, 10)
        Me.pbDead.TabIndex = 13
        Me.pbDead.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.Blue
        Me.btnRestart.Location = New System.Drawing.Point(635, 50)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(91, 34)
        Me.btnRestart.TabIndex = 14
        Me.btnRestart.Text = "Reset"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Blue
        Me.btnClose.Location = New System.Drawing.Point(635, 130)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 34)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GameTime
        '
        Me.GameTime.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(26, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 23)
        Me.lblTime.TabIndex = 17
        '
        'pbBall3
        '
        Me.pbBall3.BackColor = System.Drawing.Color.Transparent
        Me.pbBall3.Image = CType(resources.GetObject("pbBall3.Image"), System.Drawing.Image)
        Me.pbBall3.Location = New System.Drawing.Point(404, 172)
        Me.pbBall3.Name = "pbBall3"
        Me.pbBall3.Size = New System.Drawing.Size(30, 30)
        Me.pbBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBall3.TabIndex = 18
        Me.pbBall3.TabStop = False
        '
        'upT3
        '
        Me.upT3.Enabled = True
        Me.upT3.Interval = 16
        '
        'downT3
        '
        Me.downT3.Interval = 16
        '
        'leftT3
        '
        Me.leftT3.Enabled = True
        Me.leftT3.Interval = 16
        '
        'rightT3
        '
        Me.rightT3.Interval = 16
        '
        'upT4
        '
        Me.upT4.Interval = 16
        '
        'leftT4
        '
        Me.leftT4.Interval = 16
        '
        'rightT4
        '
        Me.rightT4.Interval = 16
        '
        'downT4
        '
        Me.downT4.Interval = 16
        '
        'pbBall4
        '
        Me.pbBall4.Location = New System.Drawing.Point(30, 239)
        Me.pbBall4.Name = "pbBall4"
        Me.pbBall4.Size = New System.Drawing.Size(30, 30)
        Me.pbBall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBall4.TabIndex = 19
        Me.pbBall4.TabStop = False
        '
        'btnRules
        '
        Me.btnRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRules.ForeColor = System.Drawing.Color.Blue
        Me.btnRules.Location = New System.Drawing.Point(635, 170)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(91, 34)
        Me.btnRules.TabIndex = 20
        Me.btnRules.Text = "Rules"
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'btnDiff
        '
        Me.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiff.ForeColor = System.Drawing.Color.Blue
        Me.btnDiff.Location = New System.Drawing.Point(635, 90)
        Me.btnDiff.Name = "btnDiff"
        Me.btnDiff.Size = New System.Drawing.Size(91, 34)
        Me.btnDiff.TabIndex = 21
        Me.btnDiff.Text = "Difficulty"
        Me.btnDiff.UseVisualStyleBackColor = True
        '
        'btnHigh
        '
        Me.btnHigh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHigh.ForeColor = System.Drawing.Color.Blue
        Me.btnHigh.Location = New System.Drawing.Point(635, 210)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(91, 57)
        Me.btnHigh.TabIndex = 22
        Me.btnHigh.Text = "High scores"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(201, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(247, 250)
        Me.lblTitle.TabIndex = 23
        Me.lblTitle.Text = "Welcome To Blue Balls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Created By: Fabio Sedki" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 302)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.btnDiff)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.pbBall3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pbBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.pbDead)
        Me.Controls.Add(Me.pbBall2)
        Me.Controls.Add(Me.pbBall1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pbRight)
        Me.Controls.Add(Me.pbLeft)
        Me.Controls.Add(Me.pbBottom)
        Me.Controls.Add(Me.pbTop)
        Me.Controls.Add(Me.pbBall4)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        CType(Me.pbTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTop As System.Windows.Forms.PictureBox
    Friend WithEvents pbBottom As System.Windows.Forms.PictureBox
    Friend WithEvents pbLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox As System.Windows.Forms.PictureBox
    Friend WithEvents MovementT As System.Windows.Forms.Timer
    Friend WithEvents downT As System.Windows.Forms.Timer
    Friend WithEvents upT As System.Windows.Forms.Timer
    Friend WithEvents rightT As System.Windows.Forms.Timer
    Friend WithEvents leftT As System.Windows.Forms.Timer
    Friend WithEvents DeathAnime As System.Windows.Forms.Timer
    Friend WithEvents DeathAnimation As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBall1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBall2 As System.Windows.Forms.PictureBox
    Friend WithEvents upT2 As System.Windows.Forms.Timer
    Friend WithEvents downT2 As System.Windows.Forms.Timer
    Friend WithEvents leftT2 As System.Windows.Forms.Timer
    Friend WithEvents rightT2 As System.Windows.Forms.Timer
    Friend WithEvents pbDead As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GameTime As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents pbBall3 As System.Windows.Forms.PictureBox
    Friend WithEvents upT3 As System.Windows.Forms.Timer
    Friend WithEvents downT3 As System.Windows.Forms.Timer
    Friend WithEvents leftT3 As System.Windows.Forms.Timer
    Friend WithEvents rightT3 As System.Windows.Forms.Timer
    Friend WithEvents upT4 As System.Windows.Forms.Timer
    Friend WithEvents leftT4 As System.Windows.Forms.Timer
    Friend WithEvents rightT4 As System.Windows.Forms.Timer
    Friend WithEvents downT4 As System.Windows.Forms.Timer
    Friend WithEvents pbBall4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRules As System.Windows.Forms.Button
    Friend WithEvents btnDiff As System.Windows.Forms.Button
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
