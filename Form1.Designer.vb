<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pbMe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pbMe))
        Me.pbTop = New System.Windows.Forms.PictureBox()
        Me.pbBottom = New System.Windows.Forms.PictureBox()
        Me.pbLeft = New System.Windows.Forms.PictureBox()
        Me.pbRight = New System.Windows.Forms.PictureBox()
        Me.pbBox = New System.Windows.Forms.PictureBox()
        Me.MovementT = New System.Windows.Forms.Timer(Me.components)
        Me.downT = New System.Windows.Forms.Timer(Me.components)
        Me.pbBall1 = New System.Windows.Forms.PictureBox()
        Me.upT = New System.Windows.Forms.Timer(Me.components)
        Me.rightT = New System.Windows.Forms.Timer(Me.components)
        Me.leftT = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBall1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbTop
        '
        Me.pbTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbTop.Location = New System.Drawing.Point(4, -5)
        Me.pbTop.Name = "pbTop"
        Me.pbTop.Size = New System.Drawing.Size(917, 14)
        Me.pbTop.TabIndex = 0
        Me.pbTop.TabStop = False
        '
        'pbBottom
        '
        Me.pbBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbBottom.Location = New System.Drawing.Point(3, 257)
        Me.pbBottom.Name = "pbBottom"
        Me.pbBottom.Size = New System.Drawing.Size(917, 14)
        Me.pbBottom.TabIndex = 1
        Me.pbBottom.TabStop = False
        '
        'pbLeft
        '
        Me.pbLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbLeft.Location = New System.Drawing.Point(-11, 2)
        Me.pbLeft.Name = "pbLeft"
        Me.pbLeft.Size = New System.Drawing.Size(30, 269)
        Me.pbLeft.TabIndex = 2
        Me.pbLeft.TabStop = False
        '
        'pbRight
        '
        Me.pbRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbRight.Location = New System.Drawing.Point(890, 2)
        Me.pbRight.Name = "pbRight"
        Me.pbRight.Size = New System.Drawing.Size(30, 269)
        Me.pbRight.TabIndex = 3
        Me.pbRight.TabStop = False
        '
        'pbBox
        '
        Me.pbBox.Image = CType(resources.GetObject("pbBox.Image"), System.Drawing.Image)
        Me.pbBox.Location = New System.Drawing.Point(344, 171)
        Me.pbBox.Name = "pbBox"
        Me.pbBox.Size = New System.Drawing.Size(27, 44)
        Me.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBox.TabIndex = 4
        Me.pbBox.TabStop = False
        '
        'MovementT
        '
        Me.MovementT.Enabled = True
        Me.MovementT.Interval = 25
        '
        'downT
        '
        Me.downT.Interval = 25
        '
        'pbBall1
        '
        Me.pbBall1.BackColor = System.Drawing.Color.Red
        Me.pbBall1.Location = New System.Drawing.Point(659, 192)
        Me.pbBall1.Name = "pbBall1"
        Me.pbBall1.Size = New System.Drawing.Size(31, 23)
        Me.pbBall1.TabIndex = 5
        Me.pbBall1.TabStop = False
        '
        'upT
        '
        Me.upT.Interval = 25
        '
        'rightT
        '
        Me.rightT.Interval = 25
        '
        'leftT
        '
        Me.leftT.Enabled = True
        Me.leftT.Interval = 25
        '
        'pbMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 261)
        Me.Controls.Add(Me.pbBall1)
        Me.Controls.Add(Me.pbBox)
        Me.Controls.Add(Me.pbRight)
        Me.Controls.Add(Me.pbLeft)
        Me.Controls.Add(Me.pbBottom)
        Me.Controls.Add(Me.pbTop)
        Me.Name = "pbMe"
        Me.Text = "Form1"
        CType(Me.pbTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBall1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTop As System.Windows.Forms.PictureBox
    Friend WithEvents pbBottom As System.Windows.Forms.PictureBox
    Friend WithEvents pbLeft As System.Windows.Forms.PictureBox
    Friend WithEvents pbRight As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox As System.Windows.Forms.PictureBox
    Friend WithEvents MovementT As System.Windows.Forms.Timer
    Friend WithEvents downT As System.Windows.Forms.Timer
    Friend WithEvents pbBall1 As System.Windows.Forms.PictureBox
    Friend WithEvents upT As System.Windows.Forms.Timer
    Friend WithEvents rightT As System.Windows.Forms.Timer
    Friend WithEvents leftT As System.Windows.Forms.Timer

End Class
