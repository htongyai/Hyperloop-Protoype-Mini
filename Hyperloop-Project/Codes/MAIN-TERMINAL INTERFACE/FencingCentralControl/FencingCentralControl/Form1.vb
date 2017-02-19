Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim TCPServer As Socket
    Dim TCPListenerz As TcpListener
    Dim wait = 0
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ServerTimer_Tick(sender As Object, e As EventArgs) Handles ServerTimer.Tick
        Try
            Dim rcvbytes(TCPServer.ReceiveBufferSize) As Byte
            TCPServer.Receive(rcvbytes)
            server_Recieve.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)

            If (server_Recieve.Text = "hit") Then
                ListBox1.Items.Add("Action: " + server_Recieve.Text)

            Else
                ListBox1.Items.Add("Time: " + server_Recieve.Text)
                score.Text += 1
                body_Box.BackColor = Color.Red
                hit_diagram.Enabled = True
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub server_Send_Click(sender As Object, e As EventArgs) Handles server_Send.Click
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(sever_Send.Text)
        TCPServer.Send(sendbytes)
    End Sub

    Private Sub server_Connect_Click(sender As Object, e As EventArgs) Handles server_Connect.Click

        TCPListenerz = New TcpListener(IPAddress.Any, 1000)
        TCPListenerz.Start()
        TCPServer = TCPListenerz.AcceptSocket()
        TCPServer.Blocking = False
        ServerTimer.Enabled = True
        server_Box.BackColor = Color.DarkGreen
        server_Status.Text = "CONNECTED"
        ListBox1.Items.Add("Connection Establish ")
    End Sub

    Private Sub hit_diagram_Tick(sender As Object, e As EventArgs) Handles hit_diagram.Tick

        wait = wait + 1
        colorReset.Text = wait
        If (wait = 1) Then
            body_Box.BackColor = Color.White
            hit_diagram.Enabled = False
            wait = 0
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes("start")
        TCPServer.Send(sendbytes)
    End Sub
    Public Sub initiate()
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes("start")
        TCPServer.Send(sendbytes)
    End Sub

    Private Sub TCPClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCPClientToolStripMenuItem.Click
        TCP_Client.Show()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        voiceRecognitionModule.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetIPAddress()
    End Sub
    Private Sub GetIPAddress()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        ipAddress1.Text = (strIPAddress)
        hotName.Text = (strHostName)

    End Sub


End Class
