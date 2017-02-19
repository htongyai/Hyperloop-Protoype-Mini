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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mt = New System.Windows.Forms.Label()
        Me.ms = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sst = New System.Windows.Forms.Label()
        Me.sss = New System.Windows.Forms.Label()
        Me.mst = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(66, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(66, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(66, 109)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(66, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Connect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Picture.Location = New System.Drawing.Point(24, 7)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(36, 50)
        Me.Picture.TabIndex = 15
        Me.Picture.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(13, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Recieve"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(21, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(36, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "IP"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(172, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 151)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "hit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mt
        '
        Me.mt.AutoSize = True
        Me.mt.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mt.Location = New System.Drawing.Point(12, 188)
        Me.mt.Name = "mt"
        Me.mt.Size = New System.Drawing.Size(99, 108)
        Me.mt.TabIndex = 25
        Me.mt.Text = "0"
        '
        'ms
        '
        Me.ms.AutoSize = True
        Me.ms.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ms.Location = New System.Drawing.Point(94, 188)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(99, 108)
        Me.ms.TabIndex = 24
        Me.ms.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(181, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 108)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(401, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 108)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = ":"
        '
        'sst
        '
        Me.sst.AutoSize = True
        Me.sst.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sst.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.sst.Location = New System.Drawing.Point(243, 188)
        Me.sst.Name = "sst"
        Me.sst.Size = New System.Drawing.Size(99, 108)
        Me.sst.TabIndex = 21
        Me.sst.Text = "0"
        '
        'sss
        '
        Me.sss.AutoSize = True
        Me.sss.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sss.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.sss.Location = New System.Drawing.Point(325, 188)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(99, 108)
        Me.sss.TabIndex = 20
        Me.sss.Text = "0"
        '
        'mst
        '
        Me.mst.AutoSize = True
        Me.mst.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mst.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mst.Location = New System.Drawing.Point(459, 188)
        Me.mst.Name = "mst"
        Me.mst.Size = New System.Drawing.Size(99, 108)
        Me.mst.TabIndex = 19
        Me.mst.Text = "0"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TimerLabel.Location = New System.Drawing.Point(539, 188)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(99, 108)
        Me.TimerLabel.TabIndex = 18
        Me.TimerLabel.Text = "0"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(361, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 147)
        Me.ListBox1.TabIndex = 26
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(664, 318)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "TCP Client"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Picture As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents mt As Label
    Friend WithEvents ms As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sst As Label
    Friend WithEvents sss As Label
    Friend WithEvents mst As Label
    Friend WithEvents TimerLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TimerClock As Timer
End Class
