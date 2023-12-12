<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAdbPath = New System.Windows.Forms.Label()
        Me.txtAdbPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdbPath = New System.Windows.Forms.Button()
        Me.btnApkPath = New System.Windows.Forms.Button()
        Me.txtApk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnRefreshlist = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 286)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(100, 19)
        Me.ToolStripStatusLabel1.Text = "Version"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(60, 19)
        Me.ToolStripStatusLabel2.Text = "Copyright"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdbPath
        '
        Me.lblAdbPath.AutoSize = True
        Me.lblAdbPath.Location = New System.Drawing.Point(12, 18)
        Me.lblAdbPath.Name = "lblAdbPath"
        Me.lblAdbPath.Size = New System.Drawing.Size(54, 13)
        Me.lblAdbPath.TabIndex = 0
        Me.lblAdbPath.Text = "ADB-Path"
        '
        'txtAdbPath
        '
        Me.txtAdbPath.Location = New System.Drawing.Point(72, 15)
        Me.txtAdbPath.Name = "txtAdbPath"
        Me.txtAdbPath.Size = New System.Drawing.Size(345, 20)
        Me.txtAdbPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usually found under:  C:\Program\android-sdk\platform-tools"
        '
        'btnAdbPath
        '
        Me.btnAdbPath.Location = New System.Drawing.Point(432, 13)
        Me.btnAdbPath.Name = "btnAdbPath"
        Me.btnAdbPath.Size = New System.Drawing.Size(75, 23)
        Me.btnAdbPath.TabIndex = 2
        Me.btnAdbPath.Text = "Browse"
        Me.btnAdbPath.UseVisualStyleBackColor = True
        '
        'btnApkPath
        '
        Me.btnApkPath.Location = New System.Drawing.Point(432, 76)
        Me.btnApkPath.Name = "btnApkPath"
        Me.btnApkPath.Size = New System.Drawing.Size(75, 23)
        Me.btnApkPath.TabIndex = 6
        Me.btnApkPath.Text = "Browse"
        Me.btnApkPath.UseVisualStyleBackColor = True
        '
        'txtApk
        '
        Me.txtApk.Location = New System.Drawing.Point(72, 78)
        Me.txtApk.Name = "txtApk"
        Me.txtApk.Size = New System.Drawing.Size(345, 20)
        Me.txtApk.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "APK"
        '
        'btnInstall
        '
        Me.btnInstall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstall.Location = New System.Drawing.Point(432, 140)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(75, 39)
        Me.btnInstall.TabIndex = 12
        Me.btnInstall.Text = "&Install"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(432, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(68, 105)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(309, 13)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "The selected app is installed on all selected connected devices."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 56)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Selected device for install"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(75, 141)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(234, 124)
        Me.CheckedListBox1.TabIndex = 9
        '
        'btnRefreshlist
        '
        Me.btnRefreshlist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshlist.Location = New System.Drawing.Point(315, 141)
        Me.btnRefreshlist.Name = "btnRefreshlist"
        Me.btnRefreshlist.Size = New System.Drawing.Size(75, 38)
        Me.btnRefreshlist.TabIndex = 10
        Me.btnRefreshlist.Text = "Refresh device list"
        Me.btnRefreshlist.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(519, 310)
        Me.Controls.Add(Me.btnRefreshlist)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.btnApkPath)
        Me.Controls.Add(Me.txtApk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdbPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAdbPath)
        Me.Controls.Add(Me.lblAdbPath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APK-Installer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblAdbPath As System.Windows.Forms.Label
    Friend WithEvents txtAdbPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdbPath As System.Windows.Forms.Button
    Friend WithEvents btnApkPath As System.Windows.Forms.Button
    Friend WithEvents txtApk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnRefreshlist As System.Windows.Forms.Button

End Class
