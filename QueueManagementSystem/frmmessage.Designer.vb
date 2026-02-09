<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmessage
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
        Me.healderlayout = New DevComponents.DotNetBar.PanelEx()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.btnexit = New DevComponents.DotNetBar.ButtonX()
        Me.panelmessage = New DevComponents.DotNetBar.PanelEx()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.healderlayout.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'healderlayout
        '
        Me.healderlayout.CanvasColor = System.Drawing.SystemColors.Control
        Me.healderlayout.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.healderlayout.Controls.Add(Me.pic)
        Me.healderlayout.Controls.Add(Me.btnexit)
        Me.healderlayout.DisabledBackColor = System.Drawing.Color.Empty
        Me.healderlayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.healderlayout.Location = New System.Drawing.Point(0, 0)
        Me.healderlayout.Name = "healderlayout"
        Me.healderlayout.Size = New System.Drawing.Size(397, 30)
        Me.healderlayout.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.healderlayout.Style.BackColor1.Color = System.Drawing.Color.SteelBlue
        Me.healderlayout.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.healderlayout.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.healderlayout.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.healderlayout.Style.GradientAngle = 90
        Me.healderlayout.TabIndex = 18
        '
        'pic
        '
        Me.pic.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic.Location = New System.Drawing.Point(0, 0)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(30, 30)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        Me.pic.Visible = False
        '
        'btnexit
        '
        Me.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnexit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnexit.Location = New System.Drawing.Point(365, 0)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(32, 30)
        Me.btnexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnexit.Symbol = ""
        Me.btnexit.SymbolColor = System.Drawing.Color.Red
        Me.btnexit.SymbolSize = 16.0!
        Me.btnexit.TabIndex = 4
        Me.btnexit.TextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'panelmessage
        '
        Me.panelmessage.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelmessage.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelmessage.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelmessage.Location = New System.Drawing.Point(6, 30)
        Me.panelmessage.Name = "panelmessage"
        Me.panelmessage.Size = New System.Drawing.Size(385, 146)
        Me.panelmessage.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelmessage.Style.BackColor1.Color = System.Drawing.Color.Azure
        Me.panelmessage.Style.BackColor2.Color = System.Drawing.Color.Azure
        Me.panelmessage.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelmessage.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelmessage.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelmessage.Style.ForeColor.Color = System.Drawing.Color.Black
        Me.panelmessage.Style.GradientAngle = 90
        Me.panelmessage.Style.WordWrap = True
        Me.panelmessage.TabIndex = 19
        Me.panelmessage.Text = "Hello"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmmessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(397, 183)
        Me.Controls.Add(Me.panelmessage)
        Me.Controls.Add(Me.healderlayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmessage"
        Me.healderlayout.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents healderlayout As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnexit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panelmessage As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As Timer
End Class
