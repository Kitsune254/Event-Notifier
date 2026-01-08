'Imports Event-Notifier.classes
Public Class AdminDashboard

 ' This method will run automatically when the form opens
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
    End Sub

    ' Custom method to fetch data from the database
    Private Sub LoadDashboardStats()
        Try
            ' We will use the helper to get data (DatabaseHelper needs updates for this later)
            ' For now, we set default values to prevent errors until DB is populated
            lblTotalEvents.Text = "0"
            lblTotalRegistrations.Text = "0"
            
            ' Placeholder: Update status bar
            lblStatus.Text = "Dashboard loaded successfully."
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    ' Menu: Account -> Logout
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Ask user if they are sure
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Show the login form again
            Dim loginForm As New AdminLogin()
            loginForm.Show()
            ' Close this dashboard
            Me.Close()
        End If
    End Sub

    ' Menu: File -> Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Button: Create Event
    Private Sub btnCreateEvent_Click(sender As Object, e As EventArgs) Handles btnCreateEvent.Click
        ' We will uncomment this when we build the EventInputForm
        ' Dim eventForm As New EventInputForm()
        ' eventForm.ShowDialog()
        MessageBox.Show("Event Creation Form coming soon!", "Placeholder") 
    End Sub
' LOGIC: Handles "View All Events" menu click
    Private Sub ViewAllEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllEventsToolStripMenuItem.Click
        MessageBox.Show("Event List View coming in Module 4.", "Navigation")
    End Sub

    ' LOGIC: Handles "View Registrations" menu click
    Private Sub ViewRegistrationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRegistrationsToolStripMenuItem.Click
        MessageBox.Show("Registration Management coming in Module 5.", "Navigation")
    End Sub
End Class
