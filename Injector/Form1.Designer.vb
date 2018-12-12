<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.DllLocationBox = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(12, 111)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(252, 21)
		Me.ComboBox1.TabIndex = 0
		Me.ComboBox1.Text = "Choose a Process"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 138)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(111, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Inject DLL"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(270, 62)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(102, 23)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Select DLL"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'DllLocationBox
		'
		Me.DllLocationBox.Location = New System.Drawing.Point(12, 65)
		Me.DllLocationBox.Name = "DllLocationBox"
		Me.DllLocationBox.Size = New System.Drawing.Size(252, 20)
		Me.DllLocationBox.TabIndex = 3
		Me.DllLocationBox.Text = "No DLL Selected"
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(85, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(209, 30)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(321, 166)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(51, 13)
		Me.LinkLabel1.TabIndex = 5
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "by a8764"
		Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Blue
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 179)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
		Me.StatusStrip1.TabIndex = 6
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
		Me.ToolStripStatusLabel1.Text = "Status:"
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(26, 17)
		Me.ToolStripStatusLabel2.Text = "Idle"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(384, 201)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.DllLocationBox)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ComboBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "s1mple injektor"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents DllLocationBox As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents LinkLabel1 As LinkLabel
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
