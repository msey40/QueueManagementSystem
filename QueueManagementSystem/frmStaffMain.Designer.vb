<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffMain
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.dgvQueue = New System.Windows.Forms.DataGridView()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.checkedListServices = New System.Windows.Forms.CheckedListBox()
        Me.btnConfirmServices = New System.Windows.Forms.Button()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbCounter = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCallNext = New System.Windows.Forms.Button()
        Me.btnServed = New System.Windows.Forms.Button()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblUser)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1021, 49)
        Me.pnlHeader.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(517, 19)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(105, 19)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Logged in: User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Staff Counter Panel"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.dgvQueue)
        Me.pnlMain.Controls.Add(Me.pnlControls)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 49)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1021, 491)
        Me.pnlMain.TabIndex = 1
        '
        'dgvQueue
        '
        Me.dgvQueue.AllowUserToAddRows = False
        Me.dgvQueue.AllowUserToDeleteRows = False
        Me.dgvQueue.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvQueue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvQueue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQueue.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvQueue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQueue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvQueue.ColumnHeadersHeight = 45
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvQueue.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvQueue.EnableHeadersVisualStyles = False
        Me.dgvQueue.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvQueue.Location = New System.Drawing.Point(3, 156)
        Me.dgvQueue.MultiSelect = False
        Me.dgvQueue.Name = "dgvQueue"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQueue.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvQueue.RowHeadersVisible = False
        Me.dgvQueue.RowHeadersWidth = 70
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvQueue.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvQueue.RowTemplate.Height = 50
        Me.dgvQueue.RowTemplate.ReadOnly = True
        Me.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQueue.Size = New System.Drawing.Size(1018, 319)
        Me.dgvQueue.TabIndex = 2
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlControls.Controls.Add(Me.Panel2)
        Me.pnlControls.Controls.Add(Me.Panel1)
        Me.pnlControls.Location = New System.Drawing.Point(15, 8)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(991, 142)
        Me.pnlControls.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.checkedListServices)
        Me.Panel2.Controls.Add(Me.btnConfirmServices)
        Me.Panel2.Controls.Add(Me.lblServices)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.cmbCounter)
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.lblCounter)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 135)
        Me.Panel2.TabIndex = 12
        '
        'checkedListServices
        '
        Me.checkedListServices.CheckOnClick = True
        Me.checkedListServices.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.checkedListServices.Location = New System.Drawing.Point(155, 37)
        Me.checkedListServices.Name = "checkedListServices"
        Me.checkedListServices.Size = New System.Drawing.Size(211, 84)
        Me.checkedListServices.TabIndex = 9
        '
        'btnConfirmServices
        '
        Me.btnConfirmServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnConfirmServices.FlatAppearance.BorderSize = 0
        Me.btnConfirmServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmServices.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmServices.ForeColor = System.Drawing.Color.White
        Me.btnConfirmServices.Location = New System.Drawing.Point(409, 14)
        Me.btnConfirmServices.Name = "btnConfirmServices"
        Me.btnConfirmServices.Size = New System.Drawing.Size(150, 37)
        Me.btnConfirmServices.TabIndex = 7
        Me.btnConfirmServices.Text = "Confirm Services"
        Me.btnConfirmServices.UseVisualStyleBackColor = False
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblServices.Location = New System.Drawing.Point(29, 37)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(99, 19)
        Me.lblServices.TabIndex = 8
        Me.lblServices.Text = "Select Services:"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(409, 79)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 37)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh Queue"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'cmbCounter
        '
        Me.cmbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCounter.FormattingEnabled = True
        Me.cmbCounter.Location = New System.Drawing.Point(155, 7)
        Me.cmbCounter.Name = "cmbCounter"
        Me.cmbCounter.Size = New System.Drawing.Size(211, 25)
        Me.cmbCounter.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblStatus.Location = New System.Drawing.Point(29, 79)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 6
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCounter.Location = New System.Drawing.Point(29, 9)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(101, 19)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "Select Counter:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCallNext)
        Me.Panel1.Controls.Add(Me.btnServed)
        Me.Panel1.Location = New System.Drawing.Point(690, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 136)
        Me.Panel1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Show 2nd Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCallNext
        '
        Me.btnCallNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCallNext.FlatAppearance.BorderSize = 0
        Me.btnCallNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallNext.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCallNext.ForeColor = System.Drawing.Color.White
        Me.btnCallNext.Location = New System.Drawing.Point(17, 50)
        Me.btnCallNext.Name = "btnCallNext"
        Me.btnCallNext.Size = New System.Drawing.Size(120, 37)
        Me.btnCallNext.TabIndex = 3
        Me.btnCallNext.Text = "Call Next"
        Me.btnCallNext.UseVisualStyleBackColor = False
        '
        'btnServed
        '
        Me.btnServed.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnServed.FlatAppearance.BorderSize = 0
        Me.btnServed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServed.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnServed.ForeColor = System.Drawing.Color.White
        Me.btnServed.Location = New System.Drawing.Point(159, 50)
        Me.btnServed.Name = "btnServed"
        Me.btnServed.Size = New System.Drawing.Size(120, 37)
        Me.btnServed.TabIndex = 4
        Me.btnServed.Text = "Mark Served"
        Me.btnServed.UseVisualStyleBackColor = False
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 5000
        '
        'frmStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 540)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStaffMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Counter - Queue Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents dgvQueue As DataGridView
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnServed As Button
    Friend WithEvents btnCallNext As Button
    Friend WithEvents cmbCounter As ComboBox
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents btnConfirmServices As Button
    Friend WithEvents lblServices As Label
    Friend WithEvents checkedListServices As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class