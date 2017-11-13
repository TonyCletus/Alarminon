Public Class Alarminom
    Dim i As Integer
    Dim time As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Name As String
        Name = TextBox4.Text

        time = Date.Now.ToString.Split(" ")(1)
        Label1.Text$ = time

        If i + 1 And time.Substring(0, time.Length - 3) = TextBox1.Text$ & ":" & TextBox2.Text$ And
            time.Substring(time.Length - 2, 2) = "00" Then
            Timer1.Stop()
            Dim Sapi
            Sapi = CreateObject("Sapi.Spvoice")
            Sapi.Speak("Dear" & Name)
            Sapi.Speak("Your optimized Time has reached its equilibrium Testting IT.")
            'FACTS ABOUT TIME.........................................................
            Sapi.Speak("Facts you need to keep in mind about Time. okay, No Questions, listen up" & Name)
            Sapi.Speak("Time is one of God's precious gift to mankind,  make Judicious use of it,")
            Sapi.Speak("Learn to dedicate time for God, At work, school, home, sport, E T C,  Just have time for him,")
            Sapi.Speak("Don't give up when in confusion, time is the only difference to success,  put in more time,")
            Sapi.Speak("A stitch in time saves time they say, do the right things at the right time.")
            Sapi.Speak("learn to make time work for you, most wealthy people today use their time productively.")
            Sapi.Speak("Someone is sitting in the shed today because someone planted a tree a long time ago..")
            Sapi.Speak("They always say time changes things, but you always have to change them yourself.")
            Sapi.Speak("The time you feel lonely is the time you most need to be yourself")
            Sapi.Speak("You can always count on me when you need a reminder...")
            Sapi.Speak("Thanks for listening " & Name & "Do have a wonderful time")

            My.Computer.Audio.Play(My.Resources.button10, AudioPlayMode.BackgroundLoop)
            Me.WindowState = FormWindowState.Normal
            Dim p As New Point
            p.X = (Me.Width / 2) - (Label1.Width / 2)
            p.Y = Label1.Top
            If Not Label1.Text$ = vbNullString Then
                Label1.Location = p
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text$ = "Launch" Then
            Button1.Text$ = "Terminate"
            i = 1
        Else
            My.Computer.Audio.Stop()
            TextBox1.Clear()
            TextBox2.Clear()
            Timer1.Start()
            i = 0
            Button1.Text$ = "Launch"
        End If
    End Sub

    Private Sub Alarminom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class