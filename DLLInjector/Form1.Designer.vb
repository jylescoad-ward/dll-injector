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
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.InjectorWindow = New DLLInjector.MephTheme()
		Me.MephTextBox1 = New DLLInjector.MephTextBox()
		Me.MephProgressBar1 = New DLLInjector.MephProgressBar()
		Me.DllLocationBox = New DLLInjector.MephTextBox()
		Me.MephComboBox1 = New DLLInjector.MephComboBox()
		Me.MephButton2 = New DLLInjector.MephButton()
		Me.MephButton1 = New DLLInjector.MephButton()
		Me.InjectorWindow.SuspendLayout()
		Me.SuspendLayout()
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'InjectorWindow
		'
		Me.InjectorWindow.AccentColor = System.Drawing.Color.Maroon
		Me.InjectorWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
		Me.InjectorWindow.Controls.Add(Me.MephTextBox1)
		Me.InjectorWindow.Controls.Add(Me.MephProgressBar1)
		Me.InjectorWindow.Controls.Add(Me.DllLocationBox)
		Me.InjectorWindow.Controls.Add(Me.MephComboBox1)
		Me.InjectorWindow.Controls.Add(Me.MephButton2)
		Me.InjectorWindow.Controls.Add(Me.MephButton1)
		Me.InjectorWindow.Dock = System.Windows.Forms.DockStyle.Fill
		Me.InjectorWindow.Location = New System.Drawing.Point(0, 0)
		Me.InjectorWindow.Name = "InjectorWindow"
		Me.InjectorWindow.Size = New System.Drawing.Size(343, 394)
		Me.InjectorWindow.SubHeader = "created by a8764 [http://jyles.pw]"
		Me.InjectorWindow.TabIndex = 0
		Me.InjectorWindow.Text = "s1mple injektor"
		'
		'MephTextBox1
		'
		Me.MephTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.MephTextBox1.ForeColor = System.Drawing.Color.Silver
		Me.MephTextBox1.Location = New System.Drawing.Point(13, 362)
		Me.MephTextBox1.MaxLength = 32767
		Me.MephTextBox1.MultiLine = False
		Me.MephTextBox1.Name = "MephTextBox1"
		Me.MephTextBox1.Size = New System.Drawing.Size(135, 24)
		Me.MephTextBox1.TabIndex = 5
		Me.MephTextBox1.Text = "Status"
		Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
		Me.MephTextBox1.UseSystemPasswordChar = False
		Me.MephTextBox1.WordWrap = False
		'
		'MephProgressBar1
		'
		Me.MephProgressBar1.BackColor = System.Drawing.Color.Transparent
		Me.MephProgressBar1.Location = New System.Drawing.Point(12, 332)
		Me.MephProgressBar1.Maximum = 100
		Me.MephProgressBar1.Name = "MephProgressBar1"
		Me.MephProgressBar1.ShowPercentage = True
		Me.MephProgressBar1.Size = New System.Drawing.Size(319, 23)
		Me.MephProgressBar1.TabIndex = 4
		Me.MephProgressBar1.Text = "MephProgressBar1"
		Me.MephProgressBar1.Value = 0
		'
		'DllLocationBox
		'
		Me.DllLocationBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.DllLocationBox.ForeColor = System.Drawing.Color.Silver
		Me.DllLocationBox.Location = New System.Drawing.Point(12, 109)
		Me.DllLocationBox.MaxLength = 32767
		Me.DllLocationBox.MultiLine = False
		Me.DllLocationBox.Name = "DllLocationBox"
		Me.DllLocationBox.Size = New System.Drawing.Size(181, 24)
		Me.DllLocationBox.TabIndex = 3
		Me.DllLocationBox.Text = "DLL Location"
		Me.DllLocationBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
		Me.DllLocationBox.UseSystemPasswordChar = False
		Me.DllLocationBox.WordWrap = False
		'
		'MephComboBox1
		'
		Me.MephComboBox1.BackColor = System.Drawing.Color.Transparent
		Me.MephComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.MephComboBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
		Me.MephComboBox1.ForeColor = System.Drawing.Color.Silver
		Me.MephComboBox1.FormattingEnabled = True
		Me.MephComboBox1.ItemHeight = 16
		Me.MephComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
		Me.MephComboBox1.Location = New System.Drawing.Point(12, 177)
		Me.MephComboBox1.Name = "MephComboBox1"
		Me.MephComboBox1.Size = New System.Drawing.Size(319, 22)
		Me.MephComboBox1.Sorted = True
		Me.MephComboBox1.StartIndex = 0
		Me.MephComboBox1.TabIndex = 2
		'
		'MephButton2
		'
		Me.MephButton2.BackColor = System.Drawing.Color.Transparent
		Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
		Me.MephButton2.Location = New System.Drawing.Point(199, 110)
		Me.MephButton2.Name = "MephButton2"
		Me.MephButton2.Size = New System.Drawing.Size(132, 23)
		Me.MephButton2.TabIndex = 1
		Me.MephButton2.Text = "Select DLL Location"
		'
		'MephButton1
		'
		Me.MephButton1.BackColor = System.Drawing.Color.Transparent
		Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
		Me.MephButton1.Location = New System.Drawing.Point(13, 205)
		Me.MephButton1.Name = "MephButton1"
		Me.MephButton1.Size = New System.Drawing.Size(318, 23)
		Me.MephButton1.TabIndex = 0
		Me.MephButton1.Text = "Inject to Process"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(343, 394)
		Me.Controls.Add(Me.InjectorWindow)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.TransparencyKey = System.Drawing.Color.Fuchsia
		Me.InjectorWindow.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents InjectorWindow As MephTheme
	Friend WithEvents DllLocationBox As MephTextBox
	Friend WithEvents MephComboBox1 As MephComboBox
	Friend WithEvents MephButton2 As MephButton
	Friend WithEvents MephButton1 As MephButton
	Friend WithEvents MephProgressBar1 As MephProgressBar
	Friend WithEvents MephTextBox1 As MephTextBox
End Class
