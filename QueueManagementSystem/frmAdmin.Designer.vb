<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnSService = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.cmbCounter = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.cmsSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOthers = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.cmsSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(16, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(497, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin - Manage Counter Services"
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.dgvAssignments)
        Me.pnlMain.Controls.Add(Me.pnlControls)
        Me.pnlMain.Location = New System.Drawing.Point(16, 74)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1571, 575)
        Me.pnlMain.TabIndex = 1
        '
        'dgvAssignments
        '
        Me.dgvAssignments.AllowUserToAddRows = False
        Me.dgvAssignments.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dgvAssignments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssignments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAssignments.ColumnHeadersHeight = 45
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssignments.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAssignments.EnableHeadersVisualStyles = False
        Me.dgvAssignments.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgvAssignments.Location = New System.Drawing.Point(0, 98)
        Me.dgvAssignments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignments.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAssignments.RowHeadersVisible = False
        Me.dgvAssignments.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvAssignments.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAssignments.RowTemplate.Height = 50
        Me.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssignments.Size = New System.Drawing.Size(1571, 473)
        Me.dgvAssignments.TabIndex = 0
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.btnCount)
        Me.pnlControls.Controls.Add(Me.btnSService)
        Me.pnlControls.Controls.Add(Me.btnAddUser)
        Me.pnlControls.Controls.Add(Me.lblService)
        Me.pnlControls.Controls.Add(Me.lblCounter)
        Me.pnlControls.Controls.Add(Me.cmbService)
        Me.pnlControls.Controls.Add(Me.cmbCounter)
        Me.pnlControls.Controls.Add(Me.btnAdd)
        Me.pnlControls.Controls.Add(Me.btnRemove)
        Me.pnlControls.Controls.Add(Me.btnRefresh)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(1571, 86)
        Me.pnlControls.TabIndex = 1
        '
        'btnCount
        '
        Me.btnCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCount.Image = CType(resources.GetObject("btnCount.Image"), System.Drawing.Image)
        Me.btnCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCount.Location = New System.Drawing.Point(1300, 14)
        Me.btnCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(120, 49)
        Me.btnCount.TabIndex = 9
        Me.btnCount.Text = "Counter"
        Me.btnCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCount.UseVisualStyleBackColor = False
        '
        'btnSService
        '
        Me.btnSService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSService.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSService.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSService.Image = CType(resources.GetObject("btnSService.Image"), System.Drawing.Image)
        Me.btnSService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSService.Location = New System.Drawing.Point(1159, 14)
        Me.btnSService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSService.Name = "btnSService"
        Me.btnSService.Size = New System.Drawing.Size(120, 49)
        Me.btnSService.TabIndex = 8
        Me.btnSService.Text = "Service"
        Me.btnSService.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSService.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddUser.Image = Global.QueueManagementSystem.My.Resources.Resources.plus
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(1440, 14)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddUser.Size = New System.Drawing.Size(107, 49)
        Me.btnAddUser.TabIndex = 7
        Me.btnAddUser.Text = "User"
        Me.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'lblService
        '
        Me.lblService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(357, 22)
        Me.lblService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(56, 16)
        Me.lblService.TabIndex = 1
        Me.lblService.Text = "Service:"
        '
        'lblCounter
        '
        Me.lblCounter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(8, 22)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(56, 16)
        Me.lblCounter.TabIndex = 0
        Me.lblCounter.Text = "Counter:"
        '
        'cmbService
        '
        Me.cmbService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbService.Location = New System.Drawing.Point(423, 18)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(239, 37)
        Me.cmbService.TabIndex = 3
        '
        'cmbCounter
        '
        Me.cmbCounter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCounter.Location = New System.Drawing.Point(87, 18)
        Me.cmbCounter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCounter.Name = "cmbCounter"
        Me.cmbCounter.Size = New System.Drawing.Size(239, 37)
        Me.cmbCounter.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(677, 11)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 49)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Assignment"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(819, 11)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(133, 49)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(960, 11)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(133, 49)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 10000
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSettings.ContextMenuStrip = Me.cmsSettings
        Me.btnSettings.Image = Global.QueueManagementSystem.My.Resources.Resources.setting1
        Me.btnSettings.Location = New System.Drawing.Point(1456, 15)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(60, 49)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'cmsSettings
        '
        Me.cmsSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsSettings.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDevice, Me.mnuOthers})
        Me.cmsSettings.Name = "cmsSettings"
        Me.cmsSettings.Size = New System.Drawing.Size(139, 60)
        '
        'mnuDevice
        '
        Me.mnuDevice.CheckOnClick = True
        Me.mnuDevice.Name = "mnuDevice"
        Me.mnuDevice.Size = New System.Drawing.Size(138, 28)
        Me.mnuDevice.Text = "Devices"
        '
        'mnuOthers
        '
        Me.mnuOthers.Name = "mnuOthers"
        Me.mnuOthers.Size = New System.Drawing.Size(138, 28)
        Me.mnuOthers.Text = "Others"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1597, 640)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Manage Counter & Services"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        Me.cmsSettings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbCounter As ComboBox
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblService As Label
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnSService As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents cmsSettings As ContextMenuStrip
    Friend WithEvents mnuDevice As ToolStripMenuItem
    Friend WithEvents mnuOthers As ToolStripMenuItem
End Class