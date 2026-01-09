Imports Npgsql
Imports System.Data

Public Class UserDashboard
    ' --- DATABASE HELPER ---
    Private _dbHelper As New DatabaseHelper()

    ' TODO: The current user's ID should be set after login.
    Private _currentUserId As Integer = 1 ' Hardcoded for now.

    ' --- SHARED HOVER LOGIC ---
    ' This sub moves the panel and loads the specific data
    Private Async Sub ShowPopup(btn As Button, categoryFilter As String)
        ' 1. Move the panel to the specific button being hovered
        pnlDisplay.Location = New Point(btn.Location.X, btn.Location.Y + btn.Height)

        ' 2. Ensure it is on top
        pnlDisplay.BringToFront()
        pnlDisplay.Visible = True

        lstEvents.Items.Clear()
        lstEvents.Items.Add("Loading...")

        ' 3. Fetch data specifically for this category
        Dim result As List(Of KeyValuePair(Of Integer, String)) = Await GetScheduleDataAsync(categoryFilter)

        lstEvents.Items.Clear()
        If result IsNot Nothing AndAlso result.Count > 0 Then
            lstEvents.DataSource = result
            lstEvents.DisplayMember = "Value"
            lstEvents.ValueMember = "Key"
        Else
            lstEvents.Items.Add("No events found.")
        End If
    End Sub

    ' --- BUTTON EVENTS ---

    ' 1. EVENTS BUTTON
    Private Sub btnEvents_MouseEnter(sender As Object, e As EventArgs) Handles btnEvents.MouseEnter
        ShowPopup(btnEvents, "Sports")
    End Sub

    ' 2. ACADEMICS BUTTON 
    Private Sub btnAcademics_MouseEnter(sender As Object, e As EventArgs) Handles btnAcademics.MouseEnter
        ShowPopup(btnAcademics, "Academic")
    End Sub

    ' 3. CULTURE BUTTON 
    Private Sub btnCulture_MouseEnter(sender As Object, e As EventArgs) Handles btnCulture.MouseEnter
        ShowPopup(btnCulture, "Culture")
    End Sub

    ' 4. ADMINISTRATIVE BUTTON 
    Private Sub btnAdministrative_MouseEnter(sender As Object, e As EventArgs) Handles btnAdministrative.MouseEnter
        ShowPopup(btnAdministrative, "Administrative")
    End Sub

    ' 5. CAREER BUTTON 
    Private Sub btnCareer_MouseEnter(sender As Object, e As EventArgs) Handles btnCareer.MouseEnter
        ShowPopup(btnCareer, "Career")
    End Sub

    ' 6. SOCIAL BUTTON 
    Private Sub btnSocial_MouseEnter(sender As Object, e As EventArgs) Handles btnSocial.MouseEnter
        ShowPopup(btnSocial, "Social")
    End Sub

    ' --- SHARED MOUSE LEAVE ---
    ' Updated to handle hiding the panel for the buttons
    Private Sub AllButtons_MouseLeave(sender As Object, e As EventArgs) Handles _
        btnEvents.MouseLeave,
        btnAcademics.MouseLeave,
        btnCulture.MouseLeave,
        btnAdministrative.MouseLeave,
        btnCareer.MouseLeave,
        btnSocial.MouseLeave

        pnlDisplay.Visible = False
    End Sub

    ' --- DATABASE LOGIC ---
    Private Async Function GetScheduleDataAsync(categoryName As String) As Task(Of List(Of KeyValuePair(Of Integer, String)))
        Return Await Task.Run(Function()
                                  Dim events As New List(Of KeyValuePair(Of Integer, String))
                                  Try
                                      ' Step 1: Get the category ID from its name from the EventCategories table.
                                      Dim categoryIdQuery As String = "SELECT CategoryID FROM EventCategories WHERE CategoryName = @CategoryName"
                                      Dim categoryIdObj As Object = _dbHelper.ExecuteScalar(categoryIdQuery, New NpgsqlParameter("@CategoryName", categoryName))

                                      If categoryIdObj IsNot Nothing AndAlso Not IsDBNull(categoryIdObj) Then
                                          Dim categoryId As Integer = Convert.ToInt32(categoryIdObj)

                                          ' Step 2: Use the existing helper function to get events for the found category ID.
                                          Dim dt As DataTable = _dbHelper.GetEventsByCategory(categoryId)

                                          ' Process the DataTable returned by the helper function.
                                          ' Column names are based on the query in GetEventsByCategory.
                                          For Each row As DataRow In dt.Rows
                                              Dim eventId As Integer = Convert.ToInt32(row("EventID"))
                                              Dim eventName As String = row("EventName").ToString()
                                              events.Add(New KeyValuePair(Of Integer, String)(eventId, eventName))
                                          Next
                                      End If
                                  Catch ex As Exception
                                      ' Handle exception, maybe log it.
                                      MessageBox.Show("An error occurred while fetching events: " & ex.Message)
                                  End Try
                                  Return events
                              End Function)
    End Function


    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        ' 1. Create a new instance of the form you want to open
        Dim nextPage As New AdminLogin()

        ' 2. Show the new form
        nextPage.Show()

        ' 3. (Optional) Hide the current form so it looks like a page swap
        Me.Hide()
    End Sub

    Private Sub btnevtregistration_Click(sender As Object, e As EventArgs) Handles btnevtregistration.Click

        If lstEvents.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event from the list.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedEvent As KeyValuePair(Of Integer, String) = CType(lstEvents.SelectedItem, KeyValuePair(Of Integer, String))
        Dim eventId As Integer = selectedEvent.Key

        ' 1. Create a new instance of the form you want to open
        Dim nextPage As New EventRegistrationForm(eventId, _currentUserId)

        ' 2. Show the new form
        nextPage.Show()

        ' 3. (Optional) Hide the current form so it looks like a page swap
        Me.Hide()
    End Sub

    Private Sub btnConcerts_Click(sender As Object, e As EventArgs) Handles btnCulture.Click

    End Sub
End Class