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
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblName.Location = New System.Drawing.Point(19, 50)
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
        Me.lblpw.Location = New System.Drawing.Point(26, 107)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(79, 33)
        Me.lblpw.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.lblpw.TabIndex = 1
        Me.lblpw.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(123, 59)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(208, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(123, 116)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(208, 20)
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
        Me.lblRole.Location = New System.Drawing.Point(26, 166)
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
        Me.cboRole.Location = New System.Drawing.Point(123, 170)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(127, 21)
        Me.cboRole.TabIndex = 6
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_name, Me.user_pw, Me.status})
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvUser.Location = New System.Drawing.Point(352, 0)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.Size = New System.Drawing.Size(448, 450)
        Me.dgvUser.TabIndex = 7
        '
        'cbST
        '
        Me.cbST.AutoSize = True
        Me.cbST.Location = New System.Drawing.Point(123, 213)
        Me.cbST.Name = "cbST"
        Me.cbST.Size = New System.Drawing.Size(56, 17)
        Me.cbST.TabIndex = 8
        Me.cbST.Text = "Status"
        Me.cbST.UseVisualStyleBackColor = True
        '
        'user_name
        '
        Me.user_name.HeaderText = "Username"
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        '
        'user_pw
        '
        Me.user_pw.HeaderText = "Password"
        Me.user_pw.Name = "user_pw"
        Me.user_pw.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbST)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblpw)
        Me.Controls.Add(Me.lblName)
        Me.MaximizeBox = False
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Form"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
