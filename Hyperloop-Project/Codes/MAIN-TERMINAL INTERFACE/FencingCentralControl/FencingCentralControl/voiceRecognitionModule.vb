Imports System.Speech

Public Class voiceRecognitionModule
    Dim count = 0
    Dim listenState = True
    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Private Sub voiceRecognitionModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reco.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim speechRule As New Recognition.SrgsGrammar.SrgsRule("color")

        Dim speechList As New Recognition.SrgsGrammar.SrgsOneOf("Start")

        speechRule.Add(speechList)

        gram.Rules.Add(speechRule)

        gram.Root = speechRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()
    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select Case e.Result.Text

            Case "Start"
                If listenState = True Then
                    listenState = False
                    log("listenState: False")
                    voiceTimer.Enabled = True
                    log("Voice Delay Timer: ON")
                    Form1.initiate()
                    log("TCP: Sent")
                    Form1.ListBox1.Items.Add("System: Voice Detected")
                    Form1.ListBox1.Items.Add("Action:Start")

                End If

        End Select

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub SetColor(ByVal color As System.Drawing.Color)

        Dim synth As New Synthesis.SpeechSynthesizer

        'synth.SpeakAsync("Start Match")


    End Sub

    Private Sub voiceTimer_Tick(sender As Object, e As EventArgs) Handles voiceTimer.Tick
        count += 1
        If count = 5 Then
            Me.BackColor = Color.Black
            listenState = True
            log("listenstate: True")
            voiceTimer.Enabled = False
            log("Voice Delay Timer: OFF")
            count = 0
        End If
    End Sub

    Public Sub log(activity)
        ListBox1.Items.Add(activity)
    End Sub

End Class