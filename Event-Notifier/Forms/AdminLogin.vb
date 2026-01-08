'Imports Event-Notifier.Classes 'We should ensure this matches the project name otherwise errors

Public Class AdminLogin
    ' Creating a Variable to count failed attempts
    Private loginAttempts As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Basic Validation: Checks if fields are empty 
        If String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblError.Text = "Please enter both username and password."
            lblError.Visible = True
            Return
        End If

        ' 2. Checks for temporary lockout (Security) 
        If loginAttempts >= 3 Then
            MessageBox.Show("Too many failed attempts. Please restart the application.", "Security Lockout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnLogin.Enabled = False
            Return
        End If

        Try
            ' 3. Call the database helper to validate credentials 
            Dim db As New DatabaseHelper()
            Dim adminUser As Admin = db.ValidateAdmin(txtUsername.Text.Trim(), txtPassword.Text)

If adminUser IsNot Nothing Then
    ' SUCCESS: Login worked
    MessageBox.Show("Welcome, " & adminUser.FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    
    ' Clear the password field for security
    txtPassword.Clear()
    
    ' OPEN DASHBOARD
    Dim dashboard As New AdminDashboard()
    dashboard.Show()
    Me.Hide() ' Hides the login form
Else
    ' FAILURE code remains the same...
                
                loginAttempts += 1
                lblError.Text = "Invalid username or password. Attempt " & loginAttempts & "/3"
                lblError.ForeColor = Color.Red
                lblError.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub
End Class
