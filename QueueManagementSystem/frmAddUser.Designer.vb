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
        Me.lblName = New DevComponents.DotNetBar.LabelX()
        Me.lblpw = New DevComponents.DotNetBar.LabelX()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.lblRole = New DevComponents.DotNetBar.LabelX()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.cbST = New System.Windows.Forms.CheckBox()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_pw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblName.Location = New System.Drawing.Point(22, 72)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(115, 41)
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
        Me.lblpw.Location = New System.Drawing.Point(32, 142)
        Me.lblpw.Margin = New System.Windows.Forms.Padding(4)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(105, 41)
        Me.lblpw.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblpw.TabIndex = 1
        Me.lblpw.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(144, 83)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(288, 22)
        Me.txtUsername.TabIndex = 2
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(144, 153)
        Me.txtpw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(288, 22)
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
        Me.lblRole.Location = New System.Drawing.Point(32, 214)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(105, 27)
        Me.lblRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Role :"
        Me.lblRole.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(144, 219)
        Me.cboRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(168, 24)
        Me.cboRole.TabIndex = 6
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_name, Me.user_pw, Me.user_role, Me.status})
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvUser.Location = New System.Drawing.Point(466, 0)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.Size = New System.Drawing.Size(664, 554)
        Me.dgvUser.TabIndex = 7
        '
        'cbST
        '
        Me.cbST.AutoSize = True
        Me.cbST.Location = New System.Drawing.Point(161, 297)
        Me.cbST.Margin = New System.Windows.Forms.Padding(4)
        Me.cbST.Name = "cbST"
        Me.cbST.Size = New System.Drawing.Size(66, 20)
        Me.cbST.TabIndex = 8
        Me.cbST.Text = "Status"
        Me.cbST.UseVisualStyleBackColor = True
        '
        'user_name
        '
        Me.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_name.HeaderText = "Username"
        Me.user_name.MinimumWidth = 6
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        '
        'user_pw
        '
        Me.user_pw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_pw.HeaderText = "Password"
        Me.user_pw.MinimumWidth = 6
        Me.user_pw.Name = "user_pw"
        Me.user_pw.ReadOnly = True
        '
        'user_role
        '
        Me.user_role.HeaderText = "Role"
        Me.user_role.MinimumWidth = 6
        Me.user_role.Name = "user_role"
        Me.user_role.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.btnClear.Location = New System.Drawing.Point(22, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 45)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.btnUpdate.Location = New System.Drawing.Point(176, 380)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 45)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(332, 380)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 45)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbldesUser
        '
        Me.lbldesUser.AutoSize = True
        Me.lbldesUser.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesUser.Location = New System.Drawing.Point(165, 19)
        Me.lbldesUser.Name = "lbldesUser"
        Me.lbldesUser.Size = New System.Drawing.Size(111, 16)
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
        Me.Panel1.Controls.Add(Me.cbST)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 554)
        Me.Panel1.TabIndex = 13
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvUser)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents cbST As CheckBox
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents user_pw As DataGridViewTextBoxColumn
    Friend WithEvents user_role As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lbldesUser As Label
    Friend WithEvents Panel1 As Panel
End Class
