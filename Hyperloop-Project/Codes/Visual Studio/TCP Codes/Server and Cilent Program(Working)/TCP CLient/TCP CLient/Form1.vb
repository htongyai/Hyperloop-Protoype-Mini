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

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If TCPClientStream.DataAvailable = True Then
            Dim rcvbytes(TCPClientz.ReceiveBufferSize) As Byte
            TCPClientStream.Read(rcvbytes, 0, CInt(TCPClientz.ReceiveBufferSize))
            TextBox3.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


