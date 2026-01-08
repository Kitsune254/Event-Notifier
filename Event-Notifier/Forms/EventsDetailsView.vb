Imports Npgsql
Imports System.Text

Public Class EventsDetailsView

    ' This variable receives the category name from dashboard
    Public CurrentCategory As String = ""

    ' Database Config
    Private connString As String = "Host=localhost;Username=postgres;Password=yourpassword;Database=yourdb"


    Private Async Sub EventsDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Title
        Me.Text = CurrentCategory & " Events"


        ' Enable scrollbars on the Form 
        Me.AutoScroll = True

        ' Ensure the label can grow vertically
        lbldata.AutoSize = True

        ' 3. Show loading status
        lbldata.Text = "Fetching " & CurrentCategory & " information..."

        ' 4. Fetch the data from the database
        Dim result As String = Await GetScheduleDataAsync(CurrentCategory)

        ' 5. Display the result
        lbldata.Text = result
    End Sub

    ' CLOSE BUTTON
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' DB
    Private Async Function GetScheduleDataAsync(category As String) As Task(Of String)
        Dim sb As New StringBuilder()

        Try
            Using conn As New NpgsqlConnection(connString)
                Await conn.OpenAsync()

                ' SQL: Selects data where the 'main_category' matches the button clicked
                Dim sql As String = "SELECT sport_category, match_time, match_details " &
                                    "FROM event_schedule " &
                                    "WHERE main_category = @cat " &
                                    "ORDER BY sport_category"

                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cat", category)

                    Using reader As NpgsqlDataReader = Await cmd.ExecuteReaderAsync()
                        Dim currentSubCat As String = ""

                        While Await reader.ReadAsync()
                            Dim subCat As String = reader("sport_category").ToString()
                            Dim timeVal As String = reader("match_time").ToString()
                            Dim details As String = reader("match_details").ToString()

                            ' Grouping Logic (Header formatting)
                            If subCat <> currentSubCat Then
                                If sb.Length > 0 Then sb.AppendLine()
                                sb.AppendLine(subCat.ToUpper())
                                sb.AppendLine("----------------")
                                currentSubCat = subCat
                            End If

                            ' Append the details
                            sb.AppendLine(timeVal & " - " & details)
                            sb.AppendLine()
                        End While
                    End Using
                End Using
            End Using

            ' Handle empty results
            If sb.Length = 0 Then Return "No upcoming events found for " & category

        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try

        Return sb.ToString()
    End Function


End Class