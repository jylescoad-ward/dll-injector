Public Class Form1
	Public Declare Function VirtualAllocEx Lib "kernel32" (ByVal hProcess As Integer, ByVal lpAddress As Integer, ByVal dwSize As Integer, ByVal flAllocationType As Integer, ByVal flProtect As Integer) As Integer
	Public Const MEM_COMMIT = 4096, PAGE_EXECUTE_READWRITE = &H40
	Public Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal lpBuffer As Byte(), ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
	Public Declare Function GetProcAddress Lib "kernel32" (ByVal hModule As Integer, ByVal lpProcName As String) As Integer
	Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (ByVal lpModuleName As String) As Integer
	Public Declare Function CreateRemoteThread Lib "kernel32" (ByVal hProcess As Integer, ByVal lpThreadAttributes As Integer, ByVal dwStackSize As Integer, ByVal lpStartAddress As Integer, ByVal lpParameter As Integer, ByVal dwCreationFlags As Integer, ByRef lpThreadId As Integer) As Integer
	Public DllPath As String

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		OpenFileDialog1.Title = "Select a DLL File to Inject"
		OpenFileDialog1.Filter = "Injectable Files|*.dll"
		OpenFileDialog1.FileName = ""
		OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			DllLocationBox.Text = OpenFileDialog1.FileName
			DllPath = OpenFileDialog1.FileName
		End If

	End Sub

	Private Sub ButtonClick() Handles Button1.Click
		If (Process.GetProcessesByName(ComboBox1.Text).Length = 0) Then
			MsgBox("Process " + ComboBox1.Text + "not found!")
			ToolStripStatusLabel2.Text = "Process Not Found!"
			Exit Sub
		End If
		Dim TargetHandle As IntPtr = Process.GetProcessesByName(ComboBox1.Text)(0).Handle
		If (TargetHandle.Equals(IntPtr.Zero)) Then
			MsgBox("Process " + ComboBox1.Text + " Open behavior failed.")
			ToolStripStatusLabel2.Text = "Process Error"
			Exit Sub
		End If
		Dim GetAdrOfLLBA As IntPtr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
		If (GetAdrOfLLBA.Equals(IntPtr.Zero)) Then
			MsgBox("Failed to get the LoadLibrary API function base address.")
			ToolStripStatusLabel2.Text = "API Error"
			Exit Sub
		End If
		Dim OperaChar As Byte() = System.Text.Encoding.Default.GetBytes(DllPath)
		Dim DllMemPathAdr = VirtualAllocEx(TargetHandle, 0&, &H64, MEM_COMMIT, PAGE_EXECUTE_READWRITE)
		If (DllMemPathAdr.Equals(IntPtr.Zero)) Then
			MsgBox("An error occurred while applying for space.\nTry Again.")
			ToolStripStatusLabel2.Text = "Space Error"
			Exit Sub
		End If
		If (WriteProcessMemory(TargetHandle, DllMemPathAdr, OperaChar, OperaChar.Length, 0) = False) Then
			MsgBox("An error occurred while writing to the memory!")
			ToolStripStatusLabel2.Text = "Write Error"
			Exit Sub
		End If
		CreateRemoteThread(TargetHandle, 0, 0, GetAdrOfLLBA, DllMemPathAdr, 0, 0)
		MsgBox("Injection Completed")
		ToolStripStatusLabel2.Text = "Injection Completed"
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Process.Start("http://jyles.pw")
	End Sub

	Private Sub ComboBoxDropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
		CType(sender, ComboBox).Items.Clear()
		For Each p As Process In Process.GetProcesses
			CType(sender, ComboBox).Items.Add(p.ProcessName)
		Next
	End Sub
End Class
