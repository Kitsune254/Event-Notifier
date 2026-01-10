Imports University_EventPlatform.Classes
Imports Npgsql

Public Class SplashScreen
' This method will simulate a loading process
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        ' Increment progress bar
        pbLoading.Increment(2)

        ' Update status text based on progress bar
        If pbLoading.Value = 20 Then
            lblStatus.Text = "Initializing modules..."
            CreateTestAdmin()
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
' TEMPORARY: Run this once to create your first admin
Private Sub CreateTestAdmin()
    Dim db As New DatabaseHelper()

    ' 1. Check if an admin named 'admin' already exists
    Dim checkQuery As String = "SELECT COUNT(*) FROM Admins WHERE Username = 'admin'"
    Dim count As Object = db.ExecuteScalar(checkQuery)

    If Convert.ToInt32(count) = 0 Then
        ' 2. If not, create one with password 'admin123'
        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword("admin123")
        Dim insertQuery As String = "INSERT INTO Admins (Username, PasswordHash, Email, FullName) VALUES (@U, @P, @E, @F)"

        Dim success As Boolean = db.ExecuteNonQuery(insertQuery,
            New NpgsqlParameter("@U", "admin"),
            New NpgsqlParameter("@P", passwordHash),
            New NpgsqlParameter("@E", "admin@university.edu"),
            New NpgsqlParameter("@F", "System Administrator"))

        If success Then
            MessageBox.Show("Test Admin Created! Username: 'admin', Password: 'admin123'")
        End If
    End If
End Sub
End Class
