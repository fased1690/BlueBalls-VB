<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class difficulty
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
        Me.rbEasy = New System.Windows.Forms.RadioButton()
        Me.rbNorm = New System.Windows.Forms.RadioButton()
        Me.rbHard = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbEasy
        '
        Me.rbEasy.AutoSize = True
        Me.rbEasy.Location = New System.Drawing.Point(12, 12)
        Me.rbEasy.Name = "rbEasy"
        Me.rbEasy.Size = New System.Drawing.Size(48, 17)
        Me.rbEasy.TabIndex = 1
        Me.rbEasy.TabStop = True
        Me.rbEasy.Text = "Easy"
        Me.rbEasy.UseVisualStyleBackColor = True
        '
        'rbNorm
        '
        Me.rbNorm.AutoSize = True
        Me.rbNorm.Location = New System.Drawing.Point(12, 36)
        Me.rbNorm.Name = "rbNorm"
        Me.rbNorm.Size = New System.Drawing.Size(58, 17)
        Me.rbNorm.TabIndex = 0
        Me.rbNorm.TabStop = True
        Me.rbNorm.Text = "Normal"
        Me.rbNorm.UseVisualStyleBackColor = True
        '
        'rbHard
        '
        Me.rbHard.AutoSize = True
        Me.rbHard.Location = New System.Drawing.Point(12, 60)
        Me.rbHard.Name = "rbHard"
        Me.rbHard.Size = New System.Drawing.Size(48, 17)
        Me.rbHard.TabIndex = 2
        Me.rbHard.TabStop = True
        Me.rbHard.Text = "Hard"
        Me.rbHard.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(76, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 34)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back to Game"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'difficulty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 85)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rbHard)
        Me.Controls.Add(Me.rbNorm)
        Me.Controls.Add(Me.rbEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "difficulty"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "difficulty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbEasy As System.Windows.Forms.RadioButton
    Friend WithEvents rbNorm As System.Windows.Forms.RadioButton
    Friend WithEvents rbHard As System.Windows.Forms.RadioButton
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
