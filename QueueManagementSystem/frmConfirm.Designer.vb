<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirm
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
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblcfName = New System.Windows.Forms.Label()
        Me.txtcfName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtcfPw = New System.Windows.Forms.TextBox()
        Me.lblcfPw = New System.Windows.Forms.Label()
        Me.btncfExit = New System.Windows.Forms.Button()
        Me.btncfSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.Control
        Me.lblExit.Location = New System.Drawing.Point(350, 3)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(27, 30)
        Me.lblExit.TabIndex = 0
        Me.lblExit.Text = "X"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.lblConfirm.Location = New System.Drawing.Point(170, 3)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(62, 25)
        Me.lblConfirm.TabIndex = 1
        Me.lblConfirm.Text = "Login"
        '
        'lblcfName
        '
        Me.lblcfName.AutoSize = True
        Me.lblcfName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcfName.Location = New System.Drawing.Point(24, 110)
        Me.lblcfName.Name = "lblcfName"
        Me.lblcfName.Size = New System.Drawing.Size(65, 16)
        Me.lblcfName.TabIndex = 2
        Me.lblcfName.Text = "Username"
        '
        'txtcfName
        '
        Me.txtcfName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcfName.Location = New System.Drawing.Point(100, 103)
        Me.txtcfName.Name = "txtcfName"
        Me.txtcfName.Size = New System.Drawing.Size(221, 23)
        Me.txtcfName.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.lblConfirm)
        Me.Panel1.Controls.Add(Me.lblExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 35)
        Me.Panel1.TabIndex = 4
        '
        'txtcfPw
        '
        Me.txtcfPw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcfPw.Location = New System.Drawing.Point(100, 163)
        Me.txtcfPw.Name = "txtcfPw"
        Me.txtcfPw.Size = New System.Drawing.Size(221, 23)
        Me.txtcfPw.TabIndex = 6
        Me.txtcfPw.UseSystemPasswordChar = True
        '
        'lblcfPw
        '
        Me.lblcfPw.AutoSize = True
        Me.lblcfPw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcfPw.Location = New System.Drawing.Point(24, 163)
        Me.lblcfPw.Name = "lblcfPw"
        Me.lblcfPw.Size = New System.Drawing.Size(62, 16)
        Me.lblcfPw.TabIndex = 5
        Me.lblcfPw.Text = "Password"
        '
        'btncfExit
        '
        Me.btncfExit.BackColor = System.Drawing.Color.IndianRed
        Me.btncfExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncfExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btncfExit.Location = New System.Drawing.Point(100, 235)
        Me.btncfExit.Name = "btncfExit"
        Me.btncfExit.Size = New System.Drawing.Size(100, 40)
        Me.btncfExit.TabIndex = 8
        Me.btncfExit.Text = "Exit"
        Me.btncfExit.UseVisualStyleBackColor = False
        '
        'btncfSave
        '
        Me.btncfSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncfSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncfSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btncfSave.Location = New System.Drawing.Point(221, 235)
        Me.btncfSave.Name = "btncfSave"
        Me.btncfSave.Size = New System.Drawing.Size(100, 40)
        Me.btncfSave.TabIndex = 9
        Me.btncfSave.Text = "Save"
        Me.btncfSave.UseVisualStyleBackColor = False
        '
        'frmConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 341)
        Me.Controls.Add(Me.btncfSave)
        Me.Controls.Add(Me.btncfExit)
        Me.Controls.Add(Me.txtcfPw)
        Me.Controls.Add(Me.lblcfPw)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcfName)
        Me.Controls.Add(Me.lblcfName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfirm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExit As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblcfName As Label
    Friend WithEvents txtcfName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtcfPw As TextBox
    Friend WithEvents lblcfPw As Label
    Friend WithEvents btncfExit As Button
    Friend WithEvents btncfSave As Button
End Class
