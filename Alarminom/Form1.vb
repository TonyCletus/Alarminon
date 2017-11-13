Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            RectangleShape2.Width += 1
            If (RectangleShape2.Width >= 354) Then
                Label2.Text$ = "Completed..."
                Timer1.Stop()
                Alarminom.Show()
                Me.Hide()
            Else
                Label2.Text$ = "Starting......"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click

    End Sub
End Class
