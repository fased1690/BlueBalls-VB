<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class High
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(High))
        Me.txtHigh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHigh
        '
        Me.txtHigh.Enabled = False
        Me.txtHigh.Font = New System.Drawing.Font("Engravers MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHigh.Location = New System.Drawing.Point(13, 12)
        Me.txtHigh.Multiline = True
        Me.txtHigh.Name = "txtHigh"
        Me.txtHigh.Size = New System.Drawing.Size(321, 180)
        Me.txtHigh.TabIndex = 0
        '
        'High
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 205)
        Me.Controls.Add(Me.txtHigh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "High"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HighScores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHigh As System.Windows.Forms.TextBox
End Class
