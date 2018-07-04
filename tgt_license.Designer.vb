<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class tgt_license
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
 Public WithEvents logo_command As System.Windows.Forms.Button
	Public WithEvents ll_logo As System.Windows.Forms.PictureBox
	Public WithEvents license_pic As System.Windows.Forms.Panel
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tgt_license))
        Me.license_pic = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.logo_command = New System.Windows.Forms.Button()
        Me.ll_logo = New System.Windows.Forms.PictureBox()
        Me.license_pic.SuspendLayout()
        CType(Me.ll_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'license_pic
        '
        Me.license_pic.BackColor = System.Drawing.SystemColors.Control
        Me.license_pic.BackgroundImage = CType(resources.GetObject("license_pic.BackgroundImage"), System.Drawing.Image)
        Me.license_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.license_pic.Controls.Add(Me.LinkLabel1)
        Me.license_pic.Controls.Add(Me.logo_command)
        Me.license_pic.Controls.Add(Me.ll_logo)
        Me.license_pic.Cursor = System.Windows.Forms.Cursors.Default
        Me.license_pic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.license_pic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.license_pic.Location = New System.Drawing.Point(1, 0)
        Me.license_pic.Name = "license_pic"
        Me.license_pic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.license_pic.Size = New System.Drawing.Size(740, 640)
        Me.license_pic.TabIndex = 0
        Me.license_pic.TabStop = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(205, 584)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(220, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.liquiditylighthouse.com/source/"
        Me.LinkLabel1.UseCompatibleTextRendering = True
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'logo_command
        '
        Me.logo_command.BackColor = System.Drawing.SystemColors.Control
        Me.logo_command.Cursor = System.Windows.Forms.Cursors.Default
        Me.logo_command.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo_command.ForeColor = System.Drawing.SystemColors.ControlText
        Me.logo_command.Location = New System.Drawing.Point(624, 8)
        Me.logo_command.Name = "logo_command"
        Me.logo_command.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logo_command.Size = New System.Drawing.Size(81, 33)
        Me.logo_command.TabIndex = 1
        Me.logo_command.Text = "Close"
        Me.logo_command.UseCompatibleTextRendering = True
        Me.logo_command.UseVisualStyleBackColor = False
        '
        'll_logo
        '
        Me.ll_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ll_logo.Image = CType(resources.GetObject("ll_logo.Image"), System.Drawing.Image)
        Me.ll_logo.Location = New System.Drawing.Point(648, 532)
        Me.ll_logo.Name = "ll_logo"
        Me.ll_logo.Size = New System.Drawing.Size(81, 45)
        Me.ll_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ll_logo.TabIndex = 2
        Me.ll_logo.TabStop = False
        '
        'tgt_license
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(738, 643)
        Me.Controls.Add(Me.license_pic)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tgt_license"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FirstButton(tm)   License Agreement"
        Me.license_pic.ResumeLayout(False)
        Me.license_pic.PerformLayout()
        CType(Me.ll_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
 Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
#End Region 
End Class