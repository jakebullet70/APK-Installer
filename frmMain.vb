' *****************************************************
' Name: APK-Installer
' *****************************************************
' 31.01.14  v1.0.0.0    1)  Erstellt.
'
' 27.10.16  v1.0.0.1    1)  Die Anwendung kann auch als Commandozeile von B4a gestartet werden.
'
' 28.01.14  v1.0.0.2    1)  Fehler behoben. Der Suchpath für Apk's war fest eingetragen.
'
' https://www.b4x.com/android/forum/threads/ide-feature-usb-install.157815/
'
' Dec - 2023 v1.0.0.3 )  Conterted to VS2023 and .NET 4.
' *****************************************************

Imports System
Imports System.IO
Imports System.Reflection
Imports System.Threading

Public Class frmMain
    Private StartupPath As String
    Private CurrentDirectory As DirectoryInfo
    Private ConfigFile As String

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        File.WriteAllText(StartupPath & "\" & ConfigFile, txtAdbPath.Text & ";" & txtApk.Text)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim args() As String = Environment.GetCommandLineArgs
        StartupPath = Application.StartupPath
        ConfigFile = Path.GetFileName(args(0).Replace(".exe", ".ini"))

        CurrentDirectory = New DirectoryInfo(Directory.GetCurrentDirectory())
        Dim ApkFile As FileInfo() = CurrentDirectory.GetFiles("*.apk")

        If args.Length = 2 And ApkFile.Length > 0 Then

            txtAdbPath.Text = args(1)
            txtApk.Text = ApkFile(0).FullName

            If File.Exists(txtAdbPath.Text) And File.Exists(txtApk.Text) Then
                SearchAllDevice()
                AutoInstall()
                Me.Close()
            Else
                MsgBox("ADB-Path or APK-Path not exist!", MsgBoxStyle.Exclamation Or MsgBoxStyle.MsgBoxSetForeground)
            End If
        Else
            If File.Exists(StartupPath & "\" & ConfigFile) Then

                Dim strSplit() As String = File.ReadAllText(StartupPath & "\" & ConfigFile).Split(";")
                txtAdbPath.Text = strSplit(0)
                txtApk.Text = strSplit(1)

                If txtAdbPath.Text <> "" AndAlso File.Exists(txtAdbPath.Text) Then
                    SearchAllDevice()
                End If
            End If
        End If

        'Version-Info anzeigen
        ToolStripStatusLabel1.Text = "Version " & Assembly.GetExecutingAssembly.GetName.Version.ToString(4)
        ToolStripStatusLabel2.Text = My.Application.Info.Copyright

    End Sub

    Private Function BrowserDialog(ByVal Description As String, ByVal SelectedPath As String) As String
        Dim SelectedDir As String = ""
        With New FolderBrowserDialog
            .Description = Description
            .SelectedPath = SelectedPath
            '.RootFolder = Environment.SpecialFolder.MyComputer
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                SelectedDir = .SelectedPath()
            End If
        End With
        Return SelectedDir
    End Function

    Private Function FileDialog(ByVal Filter As String, ByVal InitialDirectory As String) As String
        Dim SelectedFile As String = ""
        With OpenFileDialog1
            .Filter = Filter
            .InitialDirectory = InitialDirectory
            .CheckFileExists = True
            .RestoreDirectory = True
            .FileName = ""
        End With

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SelectedFile = OpenFileDialog1.FileName
        End If

        Return SelectedFile
    End Function

    Private Sub btnAdbPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdbPath.Click
        Dim InitialDirectory As String = ""
        If txtAdbPath.Text <> "" Then
            InitialDirectory = txtAdbPath.Text.Substring(0, txtAdbPath.Text.LastIndexOf("\"))
        End If
        Dim AdbPath As String = FileDialog("ADB-File(adb.exe)|adb.exe", InitialDirectory)
        If AdbPath <> "" Then txtAdbPath.Text = AdbPath
    End Sub

    Private Sub btnApkPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApkPath.Click
        Dim InitialDirectory As String = ""
        If txtApk.Text <> "" Then
            InitialDirectory = txtApk.Text.Substring(0, txtApk.Text.LastIndexOf("\"))
        End If
        Dim Apk As String = FileDialog("APK-File(*.apk)|*.apk", InitialDirectory)
        If Apk <> "" Then txtApk.Text = Apk
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnInstall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInstall.Click
        If Not File.Exists(txtAdbPath.Text) Then
            MsgBox("ADB-File not selected!", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxSetForeground, "ERROR")
        ElseIf Not File.Exists(txtApk.Text) Then
            MsgBox("APK-File not selected!", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxSetForeground, "ERROR")
        ElseIf CheckedListBox1.CheckedItems.Count = 0 Then
            MsgBox("No device selected!", MsgBoxStyle.Exclamation Or MsgBoxStyle.MsgBoxSetForeground, "ERROR")
        Else
            For Each itemChecked In CheckedListBox1.CheckedItems
                InstallDevice(itemChecked.ToString)
            Next
        End If
    End Sub

    Private Sub AutoInstall()
        If Not File.Exists(txtAdbPath.Text) Then
            MsgBox("ADB-File not selected!", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxSetForeground, "ERROR")
        ElseIf Not File.Exists(txtApk.Text) Then
            MsgBox("APK-File not selected!", MsgBoxStyle.Critical Or MsgBoxStyle.MsgBoxSetForeground, "ERROR")
        Else
            For Each device In CheckedListBox1.Items
                InstallDevice(device.ToString)
            Next
        End If
    End Sub

    'K:\Programme\android-sdk\platform-tools>adb -s emulator-5554 install -r K:\Programmieren\Android\StopWatch4All-Pro\v-.--_inarbeit\Objects\StopWatch4All_pro.apk
    'K:\Programme\android-sdk\platform-tools>adb -s emulator-5554 shell am start -n fg.StopWatch4all_pro/.main

    Private Sub InstallDevice(ByVal Device As String)
        Dim batFile As String
        batFile = "@ECHO OFF" & vbCrLf
        batFile = batFile & txtAdbPath.Text.Substring(0, txtAdbPath.Text.IndexOf(":") + 1) & vbCrLf
        batFile = batFile & "cd " & txtAdbPath.Text.Substring(0, txtAdbPath.Text.LastIndexOf("\")) & vbCrLf
        batFile = batFile & "adb.exe -s " & Device & " install -r " & Chr(34) & txtApk.Text & Chr(34) & vbCrLf
        batFile = batFile & "adb.exe -s " & Device & " shell am start -n " & getPackageName() & "/.main" & vbCrLf

        File.WriteAllText(StartupPath & "\Install.bat", batFile)

        Dim AdbProcess As ProcessStartInfo
        AdbProcess = New ProcessStartInfo(StartupPath & "\Install.bat")
        Dim pp As Process = Process.Start(AdbProcess)
        pp.WaitForExit()

        File.Delete(StartupPath & "\Install.bat")
    End Sub

    Private Sub SearchAllDevice()
        Dim Device As String
        Dim batFile As String
        batFile = "@ECHO OFF" & vbCrLf
        batFile = batFile & txtAdbPath.Text.Substring(0, txtAdbPath.Text.IndexOf(":") + 1) & vbCrLf
        batFile = batFile & "cd " & txtAdbPath.Text.Substring(0, txtAdbPath.Text.LastIndexOf("\")) & vbCrLf
        batFile = batFile & "adb.exe devices > " & Chr(34) & StartupPath & "\device.tmp" & Chr(34) & vbCrLf

        File.WriteAllText(StartupPath & "\batFile.bat", batFile)

        Dim AdbProcess As ProcessStartInfo
        AdbProcess = New ProcessStartInfo(StartupPath & "\batFile.bat")
        Dim pp As Process = Process.Start(AdbProcess)
        pp.WaitForExit()

        If File.Exists(StartupPath & "\device.tmp") Then
            Dim strTemp() As String = File.ReadAllText(StartupPath & "\device.tmp").Split(vbCrLf)
            File.Delete(StartupPath & "\device.tmp")
            File.Delete(StartupPath & "\batFile.bat")

            CheckedListBox1.Items.Clear()

            For i As Integer = 0 To strTemp.Length - 1
                Device = strTemp(i).Trim
                If Device.EndsWith("device") Then
                    Device = Device.Substring(0, Device.IndexOf(vbTab))
                    CheckedListBox1.Items.Add(Device)
                End If
            Next
        End If
    End Sub

    Private Function getPackageName() As String
        Dim strTmp As String
        Dim PackageName As String = ""
        Dim strSplit() As String = File.ReadAllText(txtApk.Text.Substring(0, txtApk.Text.LastIndexOf("\")) & "\AndroidManifest.xml").Split(Chr(10))

        For i As Integer = 0 To strSplit.Length - 1
            strTmp = strSplit(i).Trim
            If strTmp.StartsWith("package") Then
                PackageName = strTmp.Substring(strTmp.IndexOf("=") + 1)
                PackageName = PackageName.Replace(Chr(34), "")
                Exit For
            End If
        Next
        Return PackageName
    End Function

    Private Sub btnRefreshlist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefreshlist.Click
        If txtAdbPath.Text <> "" AndAlso File.Exists(txtAdbPath.Text) Then
            SearchAllDevice()
        End If
    End Sub
End Class
