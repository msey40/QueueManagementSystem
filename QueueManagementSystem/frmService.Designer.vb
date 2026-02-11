<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkS = New System.Windows.Forms.CheckBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lbldecs = New System.Windows.Forms.Label()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.dgvServ = New System.Windows.Forms.DataGridView()
        Me.colsid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNservice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmsService = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvServ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsService.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.chkS)
        Me.Panel1.Controls.Add(Me.txtDesc)
        Me.Panel1.Controls.Add(Me.lbldecs)
        Me.Panel1.Controls.Add(Me.txtSName)
        Me.Panel1.Controls.Add(Me.lblService)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 113)
        Me.Panel1.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(677, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(575, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.Location = New System.Drawing.Point(420, 77)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(56, 17)
        Me.chkS.TabIndex = 6
        Me.chkS.Text = "Stutus"
        Me.chkS.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(267, 37)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(209, 20)
        Me.txtDesc.TabIndex = 5
        '
        'lbldecs
        '
        Me.lbldecs.AutoSize = True
        Me.lbldecs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldecs.Location = New System.Drawing.Point(267, 18)
        Me.lbldecs.Name = "lbldecs"
        Me.lbldecs.Size = New System.Drawing.Size(70, 16)
        Me.lbldecs.TabIndex = 4
        Me.lbldecs.Text = "Description"
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(11, 37)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(209, 20)
        Me.txtSName.TabIndex = 3
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(11, 18)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(86, 16)
        Me.lblService.TabIndex = 2
        Me.lblService.Text = "Service Name"
        '
        'dgvServ
        '
        Me.dgvServ.AllowUserToAddRows = False
        Me.dgvServ.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvServ.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServ.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvServ.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServ.ColumnHeadersHeight = 35
        Me.dgvServ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colsid, Me.colsNo, Me.colNservice, Me.coldesc, Me.colCreate, Me.colStatus})
        Me.dgvServ.ContextMenuStrip = Me.cmsService
        Me.dgvServ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServ.EnableHeadersVisualStyles = False
        Me.dgvServ.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvServ.Location = New System.Drawing.Point(0, 113)
        Me.dgvServ.MultiSelect = False
        Me.dgvServ.Name = "dgvServ"
        Me.dgvServ.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServ.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServ.RowHeadersVisible = False
        Me.dgvServ.RowHeadersWidth = 45
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.dgvServ.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServ.RowTemplate.Height = 35
        Me.dgvServ.RowTemplate.ReadOnly = True
        Me.dgvServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServ.Size = New System.Drawing.Size(914, 408)
        Me.dgvServ.TabIndex = 1
        '
        'colsid
        '
        Me.colsid.HeaderText = "ID"
        Me.colsid.Name = "colsid"
        Me.colsid.ReadOnly = True
        Me.colsid.Visible = False
        '
        'colsNo
        '
        Me.colsNo.HeaderText = "NO."
        Me.colsNo.Name = "colsNo"
        Me.colsNo.ReadOnly = True
        Me.colsNo.Width = 70
        '
        'colNservice
        '
        Me.colNservice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNservice.HeaderText = "Service Name"
        Me.colNservice.Name = "colNservice"
        Me.colNservice.ReadOnly = True
        '
        'coldesc
        '
        Me.coldesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldesc.HeaderText = "Description"
        Me.coldesc.Name = "coldesc"
        Me.coldesc.ReadOnly = True
        Me.coldesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colCreate
        '
        Me.colCreate.HeaderText = "Create Date"
        Me.colCreate.Name = "colCreate"
        Me.colCreate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cmsService
        '
        Me.cmsService.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDelete})
        Me.cmsService.Name = "ContextMenuStrip1"
        Me.cmsService.Size = New System.Drawing.Size(117, 26)
        '
        'mnuDelete
        '
        Me.mnuDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDelete.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(116, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'frmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 521)
        Me.Controls.Add(Me.dgvServ)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Setup"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvServ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsService.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvServ As DataGridView
    Friend WithEvents colsid As DataGridViewTextBoxColumn
    Friend WithEvents colsNo As DataGridViewTextBoxColumn
    Friend WithEvents colNservice As DataGridViewTextBoxColumn
    Friend WithEvents coldesc As DataGridViewTextBoxColumn
    Friend WithEvents colCreate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewCheckBoxColumn
    Friend WithEvents cmsService As ContextMenuStrip
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents lblService As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents chkS As CheckBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lbldecs As Label
    Friend WithEvents txtSName As TextBox
    Friend WithEvents btnClear As Button
End Class
