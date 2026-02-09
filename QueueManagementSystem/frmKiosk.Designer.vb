<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKiosk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.btnGetTicket = New System.Windows.Forms.Button()
        Me.pnlTicket = New System.Windows.Forms.Panel()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.lblYourTicket = New System.Windows.Forms.Label()
        Me.TimerReset = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlTicket.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(162, 49)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(733, 65)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Our Service Center"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstruction
        '
        Me.lblInstruction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblInstruction.ForeColor = System.Drawing.Color.LightGray
        Me.lblInstruction.Location = New System.Drawing.Point(231, 146)
        Me.lblInstruction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(519, 32)
        Me.lblInstruction.TabIndex = 1
        Me.lblInstruction.Text = "Please select your service and press 'Get Ticket'"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbService
        '
        Me.cmbService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbService.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.cmbService.FormattingEnabled = True
        Me.cmbService.Location = New System.Drawing.Point(225, 228)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(601, 53)
        Me.cmbService.TabIndex = 2
        '
        'btnGetTicket
        '
        Me.btnGetTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetTicket.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGetTicket.FlatAppearance.BorderSize = 0
        Me.btnGetTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetTicket.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold)
        Me.btnGetTicket.ForeColor = System.Drawing.Color.White
        Me.btnGetTicket.Location = New System.Drawing.Point(309, 333)
        Me.btnGetTicket.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGetTicket.Name = "btnGetTicket"
        Me.btnGetTicket.Size = New System.Drawing.Size(450, 78)
        Me.btnGetTicket.TabIndex = 3
        Me.btnGetTicket.Text = "GET TICKET"
        Me.btnGetTicket.UseVisualStyleBackColor = False
        '
        'pnlTicket
        '
        Me.pnlTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTicket.Controls.Add(Me.lblThanks)
        Me.pnlTicket.Controls.Add(Me.lblTicketNumber)
        Me.pnlTicket.Controls.Add(Me.lblYourTicket)
        Me.pnlTicket.Location = New System.Drawing.Point(44, 445)
        Me.pnlTicket.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTicket.Name = "pnlTicket"
        Me.pnlTicket.Size = New System.Drawing.Size(1003, 372)
        Me.pnlTicket.TabIndex = 4
        Me.pnlTicket.Visible = False
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Segoe UI", 28.0!)
        Me.lblThanks.ForeColor = System.Drawing.Color.LightGray
        Me.lblThanks.Location = New System.Drawing.Point(210, 308)
        Me.lblThanks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(693, 51)
        Me.lblThanks.TabIndex = 2
        Me.lblThanks.Text = "Please wait for your number to be called"
        '
        'lblTicketNumber
        '
        Me.lblTicketNumber.AutoSize = True
        Me.lblTicketNumber.Font = New System.Drawing.Font("Segoe UI", 100.0!, System.Drawing.FontStyle.Bold)
        Me.lblTicketNumber.ForeColor = System.Drawing.Color.Lime
        Me.lblTicketNumber.Location = New System.Drawing.Point(225, 130)
        Me.lblTicketNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTicketNumber.Name = "lblTicketNumber"
        Me.lblTicketNumber.Size = New System.Drawing.Size(345, 177)
        Me.lblTicketNumber.TabIndex = 1
        Me.lblTicketNumber.Text = "-----"
        '
        'lblYourTicket
        '
        Me.lblYourTicket.AutoSize = True
        Me.lblYourTicket.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblYourTicket.ForeColor = System.Drawing.Color.White
        Me.lblYourTicket.Location = New System.Drawing.Point(206, 49)
        Me.lblYourTicket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYourTicket.Name = "lblYourTicket"
        Me.lblYourTicket.Size = New System.Drawing.Size(478, 65)
        Me.lblYourTicket.TabIndex = 0
        Me.lblYourTicket.Text = "Your Ticket Number"
        '
        'TimerReset
        '
        Me.TimerReset.Interval = 8000
        '
        'frmKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 818)
        Me.Controls.Add(Me.pnlTicket)
        Me.Controls.Add(Me.btnGetTicket)
        Me.Controls.Add(Me.cmbService)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmKiosk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Self-Service Kiosk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTicket.ResumeLayout(False)
        Me.pnlTicket.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents btnGetTicket As Button
    Friend WithEvents pnlTicket As Panel
    Friend WithEvents lblYourTicket As Label
    Friend WithEvents lblTicketNumber As Label
    Friend WithEvents lblThanks As Label
    Friend WithEvents TimerReset As Timer
    Friend WithEvents BindingSource1 As BindingSource
End Class