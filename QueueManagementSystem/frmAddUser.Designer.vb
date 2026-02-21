<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUser
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.lblName = New DevComponents.DotNetBar.LabelX()
        Me.lblpw = New DevComponents.DotNetBar.LabelX()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.lblRole = New DevComponents.DotNetBar.LabelX()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_pw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ckSt = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbldesUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        '
        '
        '
        Me.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(16, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(86, 33)
        Me.lblName.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Username : "
        '
        'lblpw
        '
        '
        '
        '
        Me.lblpw.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblpw.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpw.Location = New System.Drawing.Point(24, 115)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(79, 33)
        Me.lblpw.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblpw.TabIndex = 1
        Me.lblpw.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(108, 67)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(217, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(108, 124)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(217, 20)
        Me.txtpw.TabIndex = 3
        '
        'lblRole
        '
        '
        '
        '
        Me.lblRole.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRole.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRole.Location = New System.Drawing.Point(24, 174)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(79, 22)
        Me.lblRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Role :"
        Me.lblRole.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(108, 178)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(127, 21)
        Me.cboRole.TabIndex = 6
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUser.ColumnHeadersHeight = 30
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.no, Me.user_name, Me.user_pw, Me.user_role, Me.status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvUser.EnableHeadersVisualStyles = False
        Me.dgvUser.Location = New System.Drawing.Point(350, 0)
        Me.dgvUser.Name = "dgvUser"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 60
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvUser.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUser.RowTemplate.Height = 30
        Me.dgvUser.RowTemplate.ReadOnly = True
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(498, 450)
        Me.dgvUser.TabIndex = 7
        '
        'colid
        '
        Me.colid.HeaderText = "ID"
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        '
        'no
        '
        Me.no.FillWeight = 37.23164!
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        '
        'user_name
        '
        Me.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_name.FillWeight = 141.8833!
        Me.user_name.HeaderText = "Username"
        Me.user_name.MinimumWidth = 6
        Me.user_name.Name = "user_name"
        '
        'user_pw
        '
        Me.user_pw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_pw.FillWeight = 170.399!
        Me.user_pw.HeaderText = "Password"
        Me.user_pw.MinimumWidth = 6
        Me.user_pw.Name = "user_pw"
        '
        'user_role
        '
        Me.user_role.FillWeight = 76.14212!
        Me.user_role.HeaderText = "Role"
        Me.user_role.MinimumWidth = 6
        Me.user_role.Name = "user_role"
        '
        'status
        '
        Me.status.FalseValue = "0"
        Me.status.FillWeight = 74.34384!
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.status.TrueValue = "1"
        '
        'ckSt
        '
        Me.ckSt.AutoSize = True
        Me.ckSt.Location = New System.Drawing.Point(132, 244)
        Me.ckSt.Name = "ckSt"
        Me.ckSt.Size = New System.Drawing.Size(56, 17)
        Me.ckSt.TabIndex = 8
        Me.ckSt.Text = "Status"
        Me.ckSt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.btnClear.Location = New System.Drawing.Point(16, 309)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.btnUpdate.Location = New System.Drawing.Point(132, 309)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 37)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(249, 309)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 37)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbldesUser
        '
        Me.lbldesUser.AutoSize = True
        Me.lbldesUser.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesUser.Location = New System.Drawing.Point(124, 15)
        Me.lbldesUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldesUser.Name = "lbldesUser"
        Me.lbldesUser.Size = New System.Drawing.Size(94, 13)
        Me.lbldesUser.TabIndex = 12
        Me.lbldesUser.Text = "User Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cboRole)
        Me.Panel1.Controls.Add(Me.lbldesUser)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lblpw)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.txtpw)
        Me.Panel1.Controls.Add(Me.ckSt)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 450)
        Me.Panel1.TabIndex = 13
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblpw As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents lblRole As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents ckSt As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lbldesUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colid As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents user_pw As DataGridViewTextBoxColumn
    Friend WithEvents user_role As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewCheckBoxColumn
End Class
