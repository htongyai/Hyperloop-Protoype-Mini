Imports System.Speech

Public Class Form1

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Private Sub SetColor(ByVal color As System.Drawing.Color)

        Dim synth As New Synthesis.SpeechSynthesizer

        synth.SpeakAsync("Start Match")

        Me.BackColor = color

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select Case e.Result.Text

            Case "Start"

                SetColor(Color.Red)

            Case "green"

                SetColor(Color.Green)

            Case "blue"

                SetColor(Color.Blue)

        End Select

    End Sub

End Class