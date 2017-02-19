'****************************
'*Client Side
'*TCP
'*Hariras Tongyai
'*Design & Build
'****************************
Imports System.Net

Public Class Form1

    Dim TCPClientz As Sockets.TcpClient
    Dim TCPClientStream As Sockets.NetworkStream

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(TextBox2.Text)
        TCPClientz.Client.Send(sendbytes)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TCPClientz = New Sockets.TcpClient(TextBox1.Text, 1000)
        Timer1.Enabled = True
        TCPClientStream = TCPClientz.GetStream()
        Picture.BackColor = Color.DarkGreen
        ListBox1.Items.Add("Connection Establish ")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If TCPClientStream.DataAvailable = True Then
            Dim rcvbytes(TCPClientz.ReceiveBufferSize) As Byte
            TCPClientStream.Read(rcvbytes, 0, CInt(TCPClientz.ReceiveBufferSize))
            TextBox3.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
            ListBox1.Items.Add("Action: " + TextBox3.Text)
            If TextBox3.Text = "start" Then
                TimerClock.Enabled = True
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes("hit")
        TCPClientz.Client.Send(sendbytes)
        TimerClock.Enabled = False
        Dim totaltime = mt.Text + ms.Text + ":" + sst.Text + sss.Text + ":" + mst.Text + TimerLabel.Text
        ListBox1.Items.Add(totaltime)
        sendbytes = System.Text.Encoding.ASCII.GetBytes(totaltime)
        TCPClientz.Client.Send(sendbytes)
        restall()
    End Sub

    Public Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        TimerLabel.Text += 1

        If TimerLabel.Text > 9 Then
            mst.Text += 1
            TimerLabel.Text = 0
        ElseIf mst.Text > 9 Then
            sss.Text += 1
            mst.Text = 0
        ElseIf sss.Text > 9 Then
            sst.Text += 1
            sss.Text = 0
        ElseIf sst.Text > 9 Then

        End If


    End Sub
    Public Sub restall()
        TimerLabel.Text = 0
        mst.Text = 0
        sss.Text = 0
        sst.Text = 0

    End Sub
End Class


