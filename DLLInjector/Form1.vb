Public Class Form1


	Public Declare Function VirtualAllocEx Lib "kernel32" (ByVal hProcess As Integer, ByVal lpAddress As Integer, ByVal dwSize As Integer, ByVal flAllocationType As Integer, ByVal flProtect As Integer) As Integer
	Public Const MEM_COMMIT = 4096, PAGE_EXECUTE_READWRITE = &H40
	Public Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal lpBuffer As Byte(), ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
	Public Declare Function GetProcAddress Lib "kernel32" (ByVal hModule As Integer, ByVal lpProcName As String) As Integer
	Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (ByVal lpModuleName As String) As Integer
	Public Declare Function CreateRemoteThread Lib "kernel32" (ByVal hProcess As Integer, ByVal lpThreadAttributes As Integer, ByVal dwStackSize As Integer, ByVal lpStartAddress As Integer, ByVal lpParameter As Integer, ByVal dwCreationFlags As Integer, ByRef lpThreadId As Integer) As Integer
	Public DllPath As String

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Label1.AutoSize = True
		Label2.AutoSize = True
		Timer1.Start()
		DownloadBGMusic()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		If Label1.Right < 0 Then
			Label1.Left = Me.ClientSize.Width
		Else
			Label1.Left -= 5
		End If
		If Label2.Right < 0 Then
			Label2.Left = Me.ClientSize.Width
		Else
			Label2.Left -= 5
		End If
	End Sub

	Private Sub MephButton2_Click_1(sender As Object, e As EventArgs) Handles MephButton2.Click
		OpenFileDialog1.Title = "Select a DLL File to Inject"
		OpenFileDialog1.Filter = "Injectable Files|*.dll"
		OpenFileDialog1.FileName = ""
		OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			DllLocationBox.Text = OpenFileDialog1.FileName
			DllPath = OpenFileDialog1.FileName
		End If
	End Sub

	Private Sub ButtonClick() Handles MephButton1.Click
		If (Process.GetProcessesByName(MephComboBox1.Text).Length = 0) Then
			MsgBox("Process " + MephComboBox1.Text + "not found!")
			MephTextBox1.Text = "Process Not Found!"
			MephProgressBar1.Value = "0"
			MephProgressBar1.ShowPercentage = False
			Exit Sub
		End If
		Dim TargetHandle As IntPtr = Process.GetProcessesByName(MephComboBox1.Text)(0).Handle
		If (TargetHandle.Equals(IntPtr.Zero)) Then
			MsgBox("Process " + MephComboBox1.Text + " Open behavior failed.")
			MephTextBox1.Text = "Process Error"
			MephProgressBar1.Value = "0"
			MephProgressBar1.ShowPercentage = False
			Exit Sub
		End If
		Dim GetAdrOfLLBA As IntPtr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
		If (GetAdrOfLLBA.Equals(IntPtr.Zero)) Then
			MsgBox("Failed to get the LoadLibrary API function base address.")
			MephTextBox1.Text = "API Error"
			MephProgressBar1.Value = "0"
			MephProgressBar1.ShowPercentage = False
			Exit Sub
		End If
		Dim OperaChar As Byte() = System.Text.Encoding.Default.GetBytes(DllPath)
		Dim DllMemPathAdr = VirtualAllocEx(TargetHandle, 0&, &H64, MEM_COMMIT, PAGE_EXECUTE_READWRITE)
		If (DllMemPathAdr.Equals(IntPtr.Zero)) Then
			MephProgressBar1.ShowPercentage = False
			MsgBox("An error occurred while applying for space.\nTry Again.")
			MephTextBox1.Text = "Space Error"
			MephProgressBar1.Value = "0"
			Exit Sub
		End If
		If (WriteProcessMemory(TargetHandle, DllMemPathAdr, OperaChar, OperaChar.Length, 0) = False) Then
			MsgBox("An error occurred while writing to the memory!")
			MephTextBox1.Text = "Write Error"
			MephProgressBar1.Value = "0"
			MephProgressBar1.ShowPercentage = False
			Exit Sub
		End If
		MephProgressBar1.ShowPercentage = True
		MephProgressBar1.Value = "70"
		CreateRemoteThread(TargetHandle, 0, 0, GetAdrOfLLBA, DllMemPathAdr, 0, 0)
		MsgBox("Injection Completed")
		MephTextBox1.Text = "Injection Completed"
		MephProgressBar1.Value = "100"
	End Sub

	Sub DownloadBGMusic()

		If System.IO.File.Exists("C:\Users\Public\Downloads\injector-music.wav") Then
			PlayLoopingBackgroundSoundResource()
		Else
			My.Computer.Network.DownloadFile(
	"http://server.jyles.pw/files/music/wav/ReloadedLauncher%2310.wav",
	"C:\Users\Public\Downloads\injector-music.wav")
			PlayLoopingBackgroundSoundResource()
		End If
	End Sub

	Sub PlayLoopingBackgroundSoundResource()

		If System.IO.File.Exists("C:\Users\Public\Downloads\injector-music.wav") Then
			My.Computer.Audio.Play("C:\Users\Public\Downloads\injector-music.wav",
			AudioPlayMode.BackgroundLoop)
		Else
			PlayLoopingBackgroundSoundResource()
		End If
	End Sub

	Sub StopBackgroundSound()
		My.Computer.Audio.Stop()
	End Sub

	Private Sub MephButton3_Click(sender As Object, e As EventArgs) Handles MephButton3.Click
		StopBackgroundSound()
	End Sub

	Private Sub ComboBoxDropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MephComboBox1.DropDown
		CType(sender, ComboBox).Items.Clear()
		For Each p As Process In Process.GetProcesses
			CType(sender, ComboBox).Items.Add(p.ProcessName)
		Next
	End Sub
End Class
