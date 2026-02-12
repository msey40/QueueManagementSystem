<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCounter
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pn1 = New System.Windows.Forms.Panel()
        Me.lblh = New System.Windows.Forms.Label()
        Me.btnCSave = New System.Windows.Forms.Button()
        Me.btnCClear = New System.Windows.Forms.Button()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.txtCCid = New System.Windows.Forms.TextBox()
        Me.lblCCid = New System.Windows.Forms.Label()
        Me.pn2 = New System.Windows.Forms.Panel()
        Me.dgvCount = New System.Windows.Forms.DataGridView()
        Me.colcid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ccid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsCounter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemDisable = New System.Windows.Forms.ToolStripMenuItem()
        Me.pn1.SuspendLayout()
        Me.pn2.SuspendLayout()
        CType(Me.dgvCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCounter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn1
        '
        Me.pn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn1.Controls.Add(Me.lblh)
        Me.pn1.Controls.Add(Me.btnCSave)
        Me.pn1.Controls.Add(Me.btnCClear)
        Me.pn1.Controls.Add(Me.txtCName)
        Me.pn1.Controls.Add(Me.lblCName)
        Me.pn1.Controls.Add(Me.txtCCid)
        Me.pn1.Controls.Add(Me.lblCCid)
        Me.pn1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn1.Location = New System.Drawing.Point(0, 0)
        Me.pn1.Name = "pn1"
        Me.pn1.Size = New System.Drawing.Size(316, 284)
        Me.pn1.TabIndex = 0
        '
        'lblh
        '
        Me.lblh.AutoSize = True
        Me.lblh.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.Location = New System.Drawing.Point(109, 13)
        Me.lblh.Name = "lblh"
        Me.lblh.Size = New System.Drawing.Size(116, 18)
        Me.lblh.TabIndex = 6
        Me.lblh.Text = "Manage Counter"
        '
        'btnCSave
        '
        Me.btnCSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCSave.Location = New System.Drawing.Point(190, 209)
        Me.btnCSave.Name = "btnCSave"
        Me.btnCSave.Size = New System.Drawing.Size(75, 30)
        Me.btnCSave.TabIndex = 5
        Me.btnCSave.Text = "Save"
        Me.btnCSave.UseVisualStyleBackColor = True
        '
        'btnCClear
        '
        Me.btnCClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCClear.Location = New System.Drawing.Point(58, 209)
        Me.btnCClear.Name = "btnCClear"
        Me.btnCClear.Size = New System.Drawing.Size(75, 30)
        Me.btnCClear.TabIndex = 4
        Me.btnCClear.Text = "Clear"
        Me.btnCClear.UseVisualStyleBackColor = True
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(37, 128)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(250, 20)
        Me.txtCName.TabIndex = 3
        '
        'lblCName
        '
        Me.lblCName.AutoSize = True
        Me.lblCName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.Location = New System.Drawing.Point(34, 108)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(89, 16)
        Me.lblCName.TabIndex = 2
        Me.lblCName.Text = "Counter Name"
        '
        'txtCCid
        '
        Me.txtCCid.Location = New System.Drawing.Point(37, 70)
        Me.txtCCid.Name = "txtCCid"
        Me.txtCCid.Size = New System.Drawing.Size(250, 20)
        Me.txtCCid.TabIndex = 1
        '
        'lblCCid
        '
        Me.lblCCid.AutoSize = True
        Me.lblCCid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCid.Location = New System.Drawing.Point(34, 50)
        Me.lblCCid.Name = "lblCCid"
        Me.lblCCid.Size = New System.Drawing.Size(68, 16)
        Me.lblCCid.TabIndex = 0
        Me.lblCCid.Text = "Counter ID"
        '
        'pn2
        '
        Me.pn2.BackColor = System.Drawing.SystemColors.Control
        Me.pn2.Controls.Add(Me.dgvCount)
        Me.pn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn2.Location = New System.Drawing.Point(316, 0)
        Me.pn2.Name = "pn2"
        Me.pn2.Size = New System.Drawing.Size(598, 284)
        Me.pn2.TabIndex = 1
        '
        'dgvCount
        '
        Me.dgvCount.AllowUserToAddRows = False
        Me.dgvCount.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.dgvCount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCount.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCount.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvCount.ColumnHeadersHeight = 35
        Me.dgvCount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcid, Me.colcno, Me.col_ccid, Me.colcname})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCount.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCount.EnableHeadersVisualStyles = False
        Me.dgvCount.Location = New System.Drawing.Point(0, 0)
        Me.dgvCount.Name = "dgvCount"
        Me.dgvCount.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCount.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvCount.RowHeadersVisible = False
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.dgvCount.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvCount.RowTemplate.Height = 30
        Me.dgvCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCount.Size = New System.Drawing.Size(598, 284)
        Me.dgvCount.TabIndex = 0
        '
        'colcid
        '
        Me.colcid.HeaderText = "ID"
        Me.colcid.Name = "colcid"
        Me.colcid.ReadOnly = True
        Me.colcid.Visible = False
        '
        'colcno
        '
        Me.colcno.HeaderText = "NO."
        Me.colcno.Name = "colcno"
        Me.colcno.ReadOnly = True
        Me.colcno.Width = 70
        '
        'col_ccid
        '
        Me.col_ccid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_ccid.HeaderText = "Counter ID"
        Me.col_ccid.Name = "col_ccid"
        Me.col_ccid.ReadOnly = True
        '
        'colcname
        '
        Me.colcname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colcname.HeaderText = "Counter Name"
        Me.colcname.Name = "colcname"
        Me.colcname.ReadOnly = True
        '
        'cmsCounter
        '
        Me.cmsCounter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemUpdate, Me.itemDelete, Me.itemDisable})
        Me.cmsCounter.Name = "cmsCounter"
        Me.cmsCounter.Size = New System.Drawing.Size(181, 92)
        '
        'itemUpdate
        '
        Me.itemUpdate.Name = "itemUpdate"
        Me.itemUpdate.Size = New System.Drawing.Size(180, 22)
        Me.itemUpdate.Text = "Update"
        '
        'itemDelete
        '
        Me.itemDelete.Name = "itemDelete"
        Me.itemDelete.Size = New System.Drawing.Size(180, 22)
        Me.itemDelete.Text = "Delete"
        '
        'itemDisable
        '
        Me.itemDisable.Name = "itemDisable"
        Me.itemDisable.Size = New System.Drawing.Size(112, 22)
        Me.itemDisable.Text = "Disable"
        '
        'frmCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 284)
        Me.Controls.Add(Me.pn2)
        Me.Controls.Add(Me.pn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCounter"
        Me.Text = "Counter"
        Me.pn1.ResumeLayout(False)
        Me.pn1.PerformLayout()
        Me.pn2.ResumeLayout(False)
        CType(Me.dgvCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCounter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn1 As Panel
    Friend WithEvents txtCName As TextBox
    Friend WithEvents lblCName As Label
    Friend WithEvents txtCCid As TextBox
    Friend WithEvents lblCCid As Label
    Friend WithEvents btnCClear As Button
    Friend WithEvents pn2 As Panel
    Friend WithEvents lblh As Label
    Friend WithEvents btnCSave As Button
    Friend WithEvents dgvCount As DataGridView
    Friend WithEvents colcid As DataGridViewTextBoxColumn
    Friend WithEvents colcno As DataGridViewTextBoxColumn
    Friend WithEvents col_ccid As DataGridViewTextBoxColumn
    Friend WithEvents colcname As DataGridViewTextBoxColumn
    Friend WithEvents cmsCounter As ContextMenuStrip
    Friend WithEvents itemUpdate As ToolStripMenuItem
    Friend WithEvents itemDelete As ToolStripMenuItem
    Friend WithEvents itemDisable As ToolStripMenuItem
End Class
