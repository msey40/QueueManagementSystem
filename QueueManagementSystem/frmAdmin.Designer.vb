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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.cmbCounter = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
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
        Me.dgvAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssignments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAssignments.ColumnHeadersHeight = 45
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssignments.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAssignments.EnableHeadersVisualStyles = False
        Me.dgvAssignments.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgvAssignments.Location = New System.Drawing.Point(0, 98)
        Me.dgvAssignments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssignments.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAssignments.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgvAssignments.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAssignments.RowTemplate.Height = 50
        Me.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssignments.Size = New System.Drawing.Size(1571, 473)
        Me.dgvAssignments.TabIndex = 0
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.Controls.Add(Me.btnAddUser)
        Me.pnlControls.Controls.Add(Me.lblService)
        Me.pnlControls.Controls.Add(Me.lblCounter)
        Me.pnlControls.Controls.Add(Me.cmbService)
        Me.pnlControls.Controls.Add(Me.cmbCounter)
        Me.pnlControls.Controls.Add(Me.btnAdd)
        Me.pnlControls.Controls.Add(Me.btnRemove)
        Me.pnlControls.Controls.Add(Me.btnRefresh)
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(1571, 86)
        Me.pnlControls.TabIndex = 1
        '
        'btnAddUser
        '
        Me.btnAddUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Image = Global.QueueManagementSystem.My.Resources.Resources.plus
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(1441, 18)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Padding = New System.Windows.Forms.Padding(2)
        Me.btnAddUser.Size = New System.Drawing.Size(105, 49)
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
        Me.lblService.Location = New System.Drawing.Point(369, 22)
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
        Me.lblCounter.Location = New System.Drawing.Point(20, 22)
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
        Me.cmbService.Location = New System.Drawing.Point(435, 18)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(239, 24)
        Me.cmbService.TabIndex = 3
        '
        'cmbCounter
        '
        Me.cmbCounter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounter.Location = New System.Drawing.Point(99, 18)
        Me.cmbCounter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCounter.Name = "cmbCounter"
        Me.cmbCounter.Size = New System.Drawing.Size(239, 24)
        Me.cmbCounter.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(689, 17)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 49)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Assignment"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(857, 18)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(160, 49)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(1035, 18)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(160, 49)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 10000
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1597, 640)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Manage Counter & Services"
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
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
End Class