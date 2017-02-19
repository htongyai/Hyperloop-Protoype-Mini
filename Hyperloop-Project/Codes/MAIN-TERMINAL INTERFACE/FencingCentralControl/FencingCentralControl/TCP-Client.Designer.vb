<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCP_Client
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.mt = New System.Windows.Forms.Label()
        Me.ms = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sst = New System.Windows.Forms.Label()
        Me.sss = New System.Windows.Forms.Label()
        Me.mst = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TCPToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoiceRecognitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TCPServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TCPClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(353, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 147)
        Me.ListBox1.TabIndex = 45
        '
        'mt
        '
        Me.mt.AutoSize = True
        Me.mt.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mt.Location = New System.Drawing.Point(4, 214)
        Me.mt.Name = "mt"
        Me.mt.Size = New System.Drawing.Size(99, 108)
        Me.mt.TabIndex = 44
        Me.mt.Text = "0"
        '
        'ms
        '
        Me.ms.AutoSize = True
        Me.ms.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ms.Location = New System.Drawing.Point(86, 214)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(99, 108)
        Me.ms.TabIndex = 43
        Me.ms.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(173, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 108)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(393, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 108)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = ":"
        '
        'sst
        '
        Me.sst.AutoSize = True
        Me.sst.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sst.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.sst.Location = New System.Drawing.Point(235, 214)
        Me.sst.Name = "sst"
        Me.sst.Size = New System.Drawing.Size(99, 108)
        Me.sst.TabIndex = 40
        Me.sst.Text = "0"
        '
        'sss
        '
        Me.sss.AutoSize = True
        Me.sss.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sss.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.sss.Location = New System.Drawing.Point(317, 214)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(99, 108)
        Me.sss.TabIndex = 39
        Me.sss.Text = "0"
        '
        'mst
        '
        Me.mst.AutoSize = True
        Me.mst.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mst.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mst.Location = New System.Drawing.Point(451, 214)
        Me.mst.Name = "mst"
        Me.mst.Size = New System.Drawing.Size(99, 108)
        Me.mst.TabIndex = 38
        Me.mst.Text = "0"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TimerLabel.Location = New System.Drawing.Point(531, 214)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(99, 108)
        Me.TimerLabel.TabIndex = 37
        Me.TimerLabel.Text = "0"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 151)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "hit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(28, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "IP"
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Picture.Location = New System.Drawing.Point(16, 33)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(36, 50)
        Me.Picture.TabIndex = 34
        Me.Picture.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(5, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Recieve"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(58, 135)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(58, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(58, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(13, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Send"
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.TCPToolsToolStripMenuItem, Me.VoiceRecognitionToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.InformationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IPFilesToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'TCPToolsToolStripMenuItem
        '
        Me.TCPToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TCPServerToolStripMenuItem, Me.TCPClientToolStripMenuItem})
        Me.TCPToolsToolStripMenuItem.Name = "TCPToolsToolStripMenuItem"
        Me.TCPToolsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.TCPToolsToolStripMenuItem.Text = "TCP Tools"
        '
        'VoiceRecognitionToolStripMenuItem
        '
        Me.VoiceRecognitionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogToolStripMenuItem, Me.ControlsToolStripMenuItem})
        Me.VoiceRecognitionToolStripMenuItem.Name = "VoiceRecognitionToolStripMenuItem"
        Me.VoiceRecognitionToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.VoiceRecognitionToolStripMenuItem.Text = "Voice Recognition"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'IPFilesToolStripMenuItem
        '
        Me.IPFilesToolStripMenuItem.Name = "IPFilesToolStripMenuItem"
        Me.IPFilesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IPFilesToolStripMenuItem.Text = "IP Files"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TCPServerToolStripMenuItem
        '
        Me.TCPServerToolStripMenuItem.Name = "TCPServerToolStripMenuItem"
        Me.TCPServerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TCPServerToolStripMenuItem.Text = "TCP Server"
        '
        'TCPClientToolStripMenuItem
        '
        Me.TCPClientToolStripMenuItem.Name = "TCPClientToolStripMenuItem"
        Me.TCPClientToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TCPClientToolStripMenuItem.Text = "TCP Client"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'TCP_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(676, 358)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.mt)
        Me.Controls.Add(Me.ms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sst)
        Me.Controls.Add(Me.sss)
        Me.Controls.Add(Me.mst)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TCP_Client"
        Me.Text = "TCP_Client"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents mt As Label
    Friend WithEvents ms As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sst As Label
    Friend WithEvents sss As Label
    Friend WithEvents mst As Label
    Friend WithEvents TimerLabel As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Picture As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerClock As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TCPToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoiceRecognitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IPFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TCPServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TCPClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
End Class
