Public Class SplashScreen
' This method will simulate a loading process
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        ' Increment progress bar
        pbLoading.Increment(2)

        ' Update status text based on progress bar
        If pbLoading.Value = 20 Then
            lblStatus.Text = "Initializing modules..."
        ElseIf pbLoading.Value = 50 Then
            lblStatus.Text = "Connecting to database..."
        ElseIf pbLoading.Value = 80 Then
            lblStatus.Text = "Starting application..."
        End If

        ' When finished, open the Login form
        If pbLoading.Value >= 100 Then
            tmrLoading.Stop()
            
            ' Open Admin Login
            Dim login As New AdminLogin()
            login.Show()
            
            ' Hide Splash Screen
            Me.Hide()
        End If
    End Sub
End Class
