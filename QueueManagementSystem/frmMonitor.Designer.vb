<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonitor
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(243, 41)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(609, 106)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "NOW SERVING"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplay
        '
        Me.lblDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplay.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblDisplay.ForeColor = System.Drawing.Color.Lime
        Me.lblDisplay.Location = New System.Drawing.Point(75, 146)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(930, 488)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "-----"
        '
        'lblWaiting
        '
        Me.lblWaiting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lblWaiting.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblWaiting.Location = New System.Drawing.Point(75, 325)
        Me.lblWaiting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(876, 86)
        Me.lblWaiting.TabIndex = 2
        Me.lblWaiting.Text = "Waiting for next customer..."
        Me.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWaiting.Visible = False
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 2000
        '
        'frmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 731)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Queue Monitor Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblWaiting As Label
    Friend WithEvents TimerRefresh As Timer

End Class