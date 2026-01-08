Imports Npgsql
Imports System.Text

Public Class UserDashboard
    ' --- CONFIGURATION ---
    Private connString As String = "Host=localhost;Username=postgres;Password=yourpassword;Database=yourdb"

    ' --- SHARED HOVER LOGIC ---
    ' This sub moves the panel and loads the specific data
    Private Async Sub ShowPopup(btn As Button, categoryFilter As String)
        ' 1. Move the panel to the specific button being hovered
        pnlDisplay.Location = New Point(btn.Location.X, btn.Location.Y + btn.Height)

        ' 2. Ensure it is on top
        pnlDisplay.BringToFront()
        pnlDisplay.Visible = True

        lblContent.Text = "Loading " & categoryFilter & "..."

        ' 3. Fetch data specifically for this category
        Dim result As String = Await GetScheduleDataAsync(categoryFilter)
        lblContent.Text = result
    End Sub

    ' --- BUTTON EVENTS ---

    ' 1. EVENTS BUTTON (Formerly Sports)
    ' We still fetch "Sports" from DB, assuming that's how you categorized them in the table
    Private Sub btnEvents_MouseEnter(sender As Object, e As EventArgs) Handles btnEvents.MouseEnter
        ShowPopup(btnEvents, "Sports")
    End Sub

    ' 2. CONCERTS BUTTON
    Private Sub btnConcerts_MouseEnter(sender As Object, e As EventArgs) Handles btnConcerts.MouseEnter
        ShowPopup(btnConcerts, "Concerts")
    End Sub

    ' 3. ACADEMICS BUTTON (Formerly Academic)
    Private Sub btnAcademics_MouseEnter(sender As Object, e As EventArgs) Handles btnacademics.MouseEnter
        ShowPopup(btnacademics, "Academic")
    End Sub

    ' 4. FESTIVALS BUTTON (New)
    Private Sub btnFestivals_MouseEnter(sender As Object, e As EventArgs) Handles btnfestivals.MouseEnter
        ShowPopup(btnfestivals, "Festivals")
    End Sub

    ' --- SHARED MOUSE LEAVE ---
    ' This handles hiding the panel for ALL 4 buttons
    Private Sub AllButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnEvents.MouseLeave, btnConcerts.MouseLeave, btnacademics.MouseLeave, btnfestivals.MouseLeave
        pnlDisplay.Visible = False
    End Sub

    ' --- DATABASE LOGIC ---
    Private Async Function GetScheduleDataAsync(category As String) As Task(Of String)
        Dim sb As New StringBuilder()

        Try
            Using conn As New NpgsqlConnection(connString)
                Await conn.OpenAsync()

                ' SQL: Selects data where the 'main_category' matches the button you hovered
                Dim sql As String = "SELECT sport_category, match_time, match_details " &
                                    "FROM event_schedule " &
                                    "WHERE main_category = @cat " &
                                    "ORDER BY sport_category"

                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cat", category)

                    Using reader As NpgsqlDataReader = Await cmd.ExecuteReaderAsync()
                        Dim currentSubCat As String = ""

                        While Await reader.ReadAsync()
                            ' We treat 'sport_category' as the sub-header (e.g. Football, Jazz, Math, Food)
                            Dim subCat As String = reader("sport_category").ToString()
                            Dim timeVal As String = reader("match_time").ToString()
                            Dim details As String = reader("match_details").ToString()

                            ' Grouping Logic
                            If subCat <> currentSubCat Then
                                If sb.Length > 0 Then sb.AppendLine()
                                sb.AppendLine(subCat.ToUpper())
                                sb.AppendLine("----------------")
                                currentSubCat = subCat
                            End If

                            sb.AppendLine(timeVal)
                            sb.AppendLine(details)
                            sb.AppendLine()
                        End While
                    End Using
                End Using
            End Using

            If sb.Length = 0 Then Return "No upcoming events found for " & category

        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try

        Return sb.ToString()
    End Function

    Private Sub btnDasboard_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        ' 1. Create a new instance of the form you want to open
        Dim nextPage As New Form2()

        ' 2. Show the new form
        nextPage.Show()

        ' 3. (Optional) Hide the current form so it looks like a page swap
        Me.Hide()
    End Sub

    Private Sub btnevtregistration_Click(sender As Object, e As EventArgs) Handles btnevtregistration.Click

        ' 1. Create a new instance of the form you want to open
        Dim nextPage As New Form2()

        ' 2. Show the new form
        nextPage.Show()

        ' 3. (Optional) Hide the current form so it looks like a page swap
        Me.Hide()
    End Sub


    End Sub
End Class