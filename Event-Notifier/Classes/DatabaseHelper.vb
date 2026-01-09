'Imports Npgsql
'Imports System.Configuration

'Public Class DatabaseHelper
'    ' Variable to hold the connection string internally
'    Private Shared cs As String = "Host=aws-1-eu-west-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.zezzswjjdyoaeyunasue;Password='Ki_tsune@254';SSL Mode=Require;Trust Server Certificate=true"

'    ' Test method to verify database connectivity
'    Public Shared Sub TestConnection()

'        Using conn As New NpgsqlConnection(cs)
'            Try
'                conn.Open() ' Attempt to open the connection
'                MsgBox("Connected to supabase successfully")
'                'Return True ' If we get here, it worked!
'            Catch ex As Exception
'                ' If it fails, print the error to the Output
'                MsgBox("Connection Error: " & ex.Message)
'                'System.Diagnostics.Debug.WriteLine("Connection Error: " & ex.Message)
'                'Return False
'            End Try
'        End Using ' "Using" automatically closes the connection here

'    End Sub



'End Class
Imports System.Configuration
Imports System.Data
Imports Microsoft.Extensions.Logging
Imports Npgsql
Imports System.IO
Imports System.Net.Http


Public Class DatabaseHelper
    Private connectionString As String

    ' Constructor
    Public Sub New()
        ' Load connection string from App.config
        connectionString = "Host=aws-1-eu-west-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.zezzswjjdyoaeyunasue;Password='Ki_tsune@254';SSL Mode=Require;Trust Server Certificate=true"
    End Sub

    ' Get database connection
    Public Function GetConnection() As NpgsqlConnection
        Return New NpgsqlConnection(connectionString)
    End Function

    ' Execute non-query (INSERT, UPDATE, DELETE)
    Public Function ExecuteNonQuery(query As String, ParamArray parameters() As NpgsqlParameter) As Boolean
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error")
            Return False
        End Try
    End Function

    ' Execute query and return DataTable
    Public Function ExecuteQuery(query As String, ParamArray parameters() As NpgsqlParameter) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    Using adapter As New NpgsqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Query error: " & ex.Message, "Error")
        End Try
        Return dt
    End Function

    ' Execute scalar (return single value)
    Public Function ExecuteScalar(query As String, ParamArray parameters() As NpgsqlParameter) As Object
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Scalar query error: " & ex.Message, "Error")
            Return Nothing
        End Try
    End Function

    ' EVENT FUNCTIONS

    Public Function CreateEvent(ev As Events) As Integer
        Try
            Dim query As String = "INSERT INTO Events (EventName, Description, CategoryID, EventDate, EventTime, 
                                   Venue, OrganiserName, OrganiserContact, MaxParticipants, ImageData, 
                                   ImageFileName, ImageContentType, CreatedByAdminID, IsActive) 
                                   VALUES (@EventName, @Description, @CategoryID, @EventDate, @EventTime, 
                                   @Venue, @OrganiserName, @OrganiserContact, @MaxParticipants, @ImageData, 
                                   @ImageFileName, @ImageContentType, @CreatedByAdminID, @IsActive) 
                                   RETURNING EventID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName)
                    cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrEmpty(ev.Description), DBNull.Value, ev.Description))
                    cmd.Parameters.AddWithValue("@CategoryID", ev.CategoryID)
                    cmd.Parameters.AddWithValue("@EventDate", ev.EventDate)
                    cmd.Parameters.AddWithValue("@EventTime", ev.EventTime)
                    cmd.Parameters.AddWithValue("@Venue", ev.Venue)
                    cmd.Parameters.AddWithValue("@OrganiserName", ev.OrganiserName)
                    cmd.Parameters.AddWithValue("@OrganiserContact", If(String.IsNullOrEmpty(ev.OrganiserContact), DBNull.Value, ev.OrganiserContact))
                    cmd.Parameters.AddWithValue("@MaxParticipants", ev.MaxParticipants)
                    cmd.Parameters.AddWithValue("@ImageData", If(ev.ImageData Is Nothing, DBNull.Value, ev.ImageData))
                    cmd.Parameters.AddWithValue("@ImageFileName", If(String.IsNullOrEmpty(ev.ImageFileName), DBNull.Value, ev.ImageFileName))
                    cmd.Parameters.AddWithValue("@ImageContentType", If(String.IsNullOrEmpty(ev.ImageContentType), DBNull.Value, ev.ImageContentType))
                    cmd.Parameters.AddWithValue("@CreatedByAdminID", ev.CreatedByAdminID)
                    cmd.Parameters.AddWithValue("@IsActive", ev.IsActive)

                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating event: " & ex.Message, "Error")
            Return -1
        End Try
    End Function

    Public Function UpdateEvent(ev As Events) As Boolean
        Try
            Dim query As String = "UPDATE Events SET EventName = @EventName, Description = @Description, 
                                   CategoryID = @CategoryID, EventDate = @EventDate, EventTime = @EventTime, 
                                   Venue = @Venue, OrganiserName = @OrganiserName, OrganiserContact = @OrganiserContact, 
                                   MaxParticipants = @MaxParticipants, ImageData = @ImageData, 
                                   ImageFileName = @ImageFileName, ImageContentType = @ImageContentType, 
                                   IsActive = @IsActive 
                                   WHERE EventID = @EventID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventID", ev.EventID)
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName)
                    cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrEmpty(ev.Description), DBNull.Value, ev.Description))
                    cmd.Parameters.AddWithValue("@CategoryID", ev.CategoryID)
                    cmd.Parameters.AddWithValue("@EventDate", ev.EventDate)
                    cmd.Parameters.AddWithValue("@EventTime", ev.EventTime)
                    cmd.Parameters.AddWithValue("@Venue", ev.Venue)
                    cmd.Parameters.AddWithValue("@OrganiserName", ev.OrganiserName)
                    cmd.Parameters.AddWithValue("@OrganiserContact", If(String.IsNullOrEmpty(ev.OrganiserContact), DBNull.Value, ev.OrganiserContact))
                    cmd.Parameters.AddWithValue("@MaxParticipants", ev.MaxParticipants)
                    cmd.Parameters.AddWithValue("@ImageData", If(ev.ImageData Is Nothing, DBNull.Value, ev.ImageData))
                    cmd.Parameters.AddWithValue("@ImageFileName", If(String.IsNullOrEmpty(ev.ImageFileName), DBNull.Value, ev.ImageFileName))
                    cmd.Parameters.AddWithValue("@ImageContentType", If(String.IsNullOrEmpty(ev.ImageContentType), DBNull.Value, ev.ImageContentType))
                    cmd.Parameters.AddWithValue("@IsActive", ev.IsActive)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating event: " & ex.Message, "Error")
            Return False
        End Try
    End Function

    Public Function DeleteEvent(eventId As Integer) As Boolean
        ' Soft delete - set IsActive to false(Doesn't delete from the database)
        Dim query As String = "UPDATE Events SET IsActive = FALSE WHERE EventID = @EventID"
        Return ExecuteNonQuery(query, New NpgsqlParameter("@EventID", eventId))
    End Function

    Public Function GetEventById(eventId As Integer) As Events
        Try
            Dim query As String = "SELECT * FROM Events WHERE EventID = @EventID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EventID", eventId)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return MapReaderToEvent(reader)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving event: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    Public Function GetAllEvents() As DataTable
        Dim query As String = "SELECT e.EventID, e.EventName, c.CategoryName, e.EventDate, e.EventTime, 
                               e.Venue, e.MaxParticipants, e.IsActive, 
                               COUNT(er.RegistrationID) AS RegisteredCount 
                               FROM Events e 
                               LEFT JOIN EventCategories c ON e.CategoryID = c.CategoryID 
                               LEFT JOIN EventRegistrations er ON e.EventID = er.EventID AND er.Status = 'Confirmed' 
                               WHERE e.IsActive = TRUE 
                               GROUP BY e.EventID, c.CategoryName 
                               ORDER BY e.EventDate DESC"
        Return ExecuteQuery(query)
    End Function

    Public Function GetEventsByCategory(categoryId As Integer) As DataTable
        Dim query As String = "SELECT e.*, c.CategoryName, 
                               COUNT(er.RegistrationID) AS RegisteredCount 
                               FROM Events e 
                               LEFT JOIN EventCategories c ON e.CategoryID = c.CategoryID 
                               LEFT JOIN EventRegistrations er ON e.EventID = er.EventID AND er.Status = 'Confirmed' 
                               WHERE e.CategoryID = @CategoryID AND e.IsActive = TRUE AND e.EventDate >= CURRENT_DATE 
                               GROUP BY e.EventID, c.CategoryName 
                               ORDER BY e.EventDate"
        Return ExecuteQuery(query, New NpgsqlParameter("@CategoryID", categoryId))
    End Function

    Public Function SearchEvents(searchTerm As String) As DataTable
        Dim query As String = "SELECT e.*, c.CategoryName 
                               FROM Events e 
                               LEFT JOIN EventCategories c ON e.CategoryID = c.CategoryID 
                               WHERE e.IsActive = TRUE AND (
                                   LOWER(e.EventName) LIKE LOWER(@SearchTerm) OR 
                                   LOWER(e.Description) LIKE LOWER(@SearchTerm) OR 
                                   LOWER(e.Venue) LIKE LOWER(@SearchTerm) OR 
                                   LOWER(e.OrganiserName) LIKE LOWER(@SearchTerm) 
                               ) 
                               ORDER BY e.EventDate"
        Return ExecuteQuery(query, New NpgsqlParameter("@SearchTerm", "%" & searchTerm & "%"))
    End Function

    ' USER FUNCTIONS

    Public Function CreateUser(usr As User) As Integer
        Try
            Dim query As String = "INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, 
                                   StudentID_StaffID, Department, UserType) 
                                   VALUES (@FirstName, @LastName, @Email, @PhoneNumber, 
                                   @StudentID_StaffID, @Department, @UserType) 
                                   RETURNING UserID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", usr.FirstName)
                    cmd.Parameters.AddWithValue("@LastName", usr.LastName)
                    cmd.Parameters.AddWithValue("@Email", usr.Email)
                    cmd.Parameters.AddWithValue("@PhoneNumber", If(String.IsNullOrEmpty(usr.PhoneNumber), DBNull.Value, usr.PhoneNumber))
                    cmd.Parameters.AddWithValue("@StudentID_StaffID", usr.StudentID_StaffID)
                    cmd.Parameters.AddWithValue("@Department", If(String.IsNullOrEmpty(usr.Department), DBNull.Value, usr.Department))
                    cmd.Parameters.AddWithValue("@UserType", usr.UserType)

                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating user: " & ex.Message, "Error")
            Return -1
        End Try
    End Function

    Public Function GetUserByEmail(email As String) As User
        Try
            Dim query As String = "SELECT * FROM Users WHERE Email = @Email"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", email)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return MapReaderToUser(reader)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving user: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    Public Function GetUserById(userId As Integer) As User
        Try
            Dim query As String = "SELECT * FROM Users WHERE UserID = @UserID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", userId)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return MapReaderToUser(reader)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving user: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    ' REGISTRATION FUNCTIONS

    Public Function RegisterUserForEvent(eventId As Integer, userId As Integer, Optional notes As String = "") As Boolean
        Try
            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()

                Using transaction As NpgsqlTransaction = conn.BeginTransaction()
                    Try
                        ' Check if already registered
                        Dim checkQuery As String = "SELECT COUNT(*) FROM EventRegistrations 
                                                   WHERE EventID = @EventID AND UserID = @UserID"
                        Using checkCmd As New NpgsqlCommand(checkQuery, conn, transaction)
                            checkCmd.Parameters.AddWithValue("@EventID", eventId)
                            checkCmd.Parameters.AddWithValue("@UserID", userId)

                            If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                                MessageBox.Show("You are already registered for this event!", "Already Registered")
                                Return False
                            End If
                        End Using

                        ' Check capacity
                        Dim capacityQuery As String = "SELECT e.MaxParticipants, COUNT(er.RegistrationID) AS CurrentCount 
                                                      FROM Events e 
                                                      LEFT JOIN EventRegistrations er ON e.EventID = er.EventID AND er.Status = 'Confirmed' 
                                                      WHERE e.EventID = @EventID 
                                                      GROUP BY e.MaxParticipants"

                        Using capacityCmd As New NpgsqlCommand(capacityQuery, conn, transaction)
                            capacityCmd.Parameters.AddWithValue("@EventID", eventId)

                            Using reader As NpgsqlDataReader = capacityCmd.ExecuteReader()
                                If reader.Read() Then
                                    Dim maxParticipants As Integer = reader.GetInt32(0)
                                    Dim currentCount As Integer = If(reader.IsDBNull(1), 0, reader.GetInt32(1))

                                    If maxParticipants > 0 AndAlso currentCount >= maxParticipants Then
                                        MessageBox.Show("Sorry, this event is full!", "Event Full")
                                        Return False
                                    End If
                                End If
                            End Using
                        End Using

                        ' Create registration
                        Dim insertQuery As String = "INSERT INTO EventRegistrations (EventID, UserID, Status, Notes) 
                                                    VALUES (@EventID, @UserID, 'Confirmed', @Notes)"

                        Using insertCmd As New NpgsqlCommand(insertQuery, conn, transaction)
                            insertCmd.Parameters.AddWithValue("@EventID", eventId)
                            insertCmd.Parameters.AddWithValue("@UserID", userId)
                            insertCmd.Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(notes), DBNull.Value, notes))
                            insertCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        Return True

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration error: " & ex.Message, "Error")
            Return False
        End Try
    End Function

    Public Function IsUserRegistered(eventId As Integer, userId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM EventRegistrations 
                               WHERE EventID = @EventID AND UserID = @UserID AND Status = 'Confirmed'"
        Dim count As Object = ExecuteScalar(query,
            New NpgsqlParameter("@EventID", eventId),
            New NpgsqlParameter("@UserID", userId))
        Return If(count IsNot Nothing, Convert.ToInt32(count) > 0, False)
    End Function

    Public Function GetEventRegistrations(eventId As Integer) As DataTable
        Dim query As String = "SELECT u.*, er.RegistrationDate, er.Status, er.Notes 
                               FROM EventRegistrations er 
                               JOIN Users u ON er.UserID = u.UserID 
                               WHERE er.EventID = @EventID 
                               ORDER BY er.RegistrationDate DESC"
        Return ExecuteQuery(query, New NpgsqlParameter("@EventID", eventId))
    End Function

    Public Function GetUserRegistrations(userId As Integer) As DataTable
        Dim query As String = "SELECT e.*, c.CategoryName, er.RegistrationDate, er.Status 
                               FROM EventRegistrations er 
                               JOIN Events e ON er.EventID = e.EventID 
                               JOIN EventCategories c ON e.CategoryID = c.CategoryID 
                               WHERE er.UserID = @UserID 
                               ORDER BY e.EventDate DESC"
        Return ExecuteQuery(query, New NpgsqlParameter("@UserID", userId))
    End Function

    Public Function GetRegistrationCount(eventId As Integer) As Integer
        Dim query As String = "SELECT COUNT(*) FROM EventRegistrations 
                               WHERE EventID = @EventID AND Status = 'Confirmed'"
        Dim count As Object = ExecuteScalar(query, New NpgsqlParameter("@EventID", eventId))
        Return If(count IsNot Nothing, Convert.ToInt32(count), 0)
    End Function

    ' ADMIN FUNCTIONS

    Public Function ValidateAdmin(username As String, password As String) As Admin
        Try
            Dim query As String = "SELECT * FROM Admins WHERE Username = @Username"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("PasswordHash").ToString()

                            ' Verify password using BCrypt
                            If (password.Equals(storedHash)) Then
                                Return New Admin With {
                                    .AdminID = reader.GetInt32(0),
                                    .Username = reader.GetString(1),
                                    .Email = reader.GetString(3),
                                    .FullName = reader.GetString(4)
                                }
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    'Public Function CreateAdmin(adm As Admin, password As String) As Boolean
    '    Try
    '        ' Hash password using BCrypt
    '        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(password)

    '        Dim query As String = "INSERT INTO Admins (Username, PasswordHash, Email, FullName) 
    '                               VALUES (@Username, @PasswordHash, @Email, @FullName)"

    '        Return ExecuteNonQuery(query,
    '            New NpgsqlParameter("@Username", adm.Username),
    '            New NpgsqlParameter("@PasswordHash", passwordHash),
    '            New NpgsqlParameter("@Email", adm.Email),
    '            New NpgsqlParameter("@FullName", adm.FullName))
    '    Catch ex As Exception
    '        MessageBox.Show("Error creating admin: " & ex.Message, "Error")
    '        Return False
    '    End Try
    'End Function

    'Public Function UpdateAdminPassword(adminId As Integer, newPassword As String) As Boolean
    '    Try
    '        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(newPassword)
    '        Dim query As String = "UPDATE Admins SET PasswordHash = @PasswordHash WHERE AdminID = @AdminID"

    '        Return ExecuteNonQuery(query,
    '            New NpgsqlParameter("@PasswordHash", passwordHash),
    '            New NpgsqlParameter("@AdminID", adminId))
    '    Catch ex As Exception
    '        MessageBox.Show("Error updating password: " & ex.Message, "Error")
    '        Return False
    '    End Try
    'End Function

    ' CATEGORY FUNCTIONS

    Public Function GetAllCategories() As DataTable
        Dim query As String = "SELECT * FROM EventCategories ORDER BY CategoryName"
        Return ExecuteQuery(query)
    End Function

    Public Function GetCategoryById(categoryId As Integer) As EventCategory
        Try
            Dim query As String = "SELECT * FROM EventCategories WHERE CategoryID = @CategoryID"

            Using conn As New NpgsqlConnection(connectionString)
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New EventCategory With {
                                .CategoryID = reader.GetInt32(0),
                                .CategoryName = reader.GetString(1),
                                .Description = If(reader.IsDBNull(2), "", reader.GetString(2))
                            }
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving category: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    ' IMAGE FUNCTIONS

    'Public Function SaveEventImage(eventId As Integer, imageData As Byte(), fileName As String, contentType As String) As Boolean
    '    Try
    '        Dim query As String = "UPDATE Events SET ImageData = @ImageData, ImageFileName = @FileName, 
    '                               ImageContentType = @ContentType WHERE EventID = @EventID"

    '        Return ExecuteNonQuery(query,
    '            New NpgsqlParameter("@ImageData", imageData),
    '            New NpgsqlParameter("@FileName", fileName),
    '            New NpgsqlParameter("@ContentType", contentType),
    '            New NpgsqlParameter("@EventID", eventId))
    '    Catch ex As Exception
    '        MessageBox.Show("Error saving image: " & ex.Message, "Error")
    '        Return False
    '    End Try
    'End Function
    Public Shared Async Function UploadImage() As Task
        Dim filePath As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.png;*.jpg;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then
            filePath = ofd.FileName
        Else
            MessageBox.Show("Choose a file!!!")
        End If

        Dim supabaseUrl As String = "https://zezzswjjdyoaeyunasue.supabase.co"
        Dim anonKey As String = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Inplenpzd2pqZHlvYWV5dW5hc3VlIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjcxMDQ3MzksImV4cCI6MjA4MjY4MDczOX0.l7cyJXIT0SdV00AcxLd0Bu2ozbc_ZQd_NkMuR-QU3KY"

        Dim bucket As String = "VB"
        Dim fileName As String = Path.GetFileName(filePath)
        Dim uploadUrl As String = $"{supabaseUrl}/storage/v1/object/{bucket}/{fileName}"

        Dim client As New HttpClient()
        client.DefaultRequestHeaders.Add("Authorization", "Bearer" & anonKey)
        client.DefaultRequestHeaders.Add("apikey", anonKey)

        Dim bytes = File.ReadAllBytes(filePath)
        Dim content As New ByteArrayContent(bytes)
        content.Headers.ContentType = New Headers.MediaTypeHeaderValue("image/jpeg" Or "image/png" Or "image/jpg")

        Dim response = Await client.PostAsync(uploadUrl, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Upload Successful!")
        Else
            MessageBox.Show("Upload failed")
        End If
    End Function

    Public Function GetEventImage(eventId As Integer) As Byte()
        Try
            Dim query As String = "SELECT ImageData FROM Events WHERE EventID = @EventID"
            Dim imageData As Object = ExecuteScalar(query, New NpgsqlParameter("@EventID", eventId))

            If imageData IsNot Nothing AndAlso Not IsDBNull(imageData) Then
                Return CType(imageData, Byte())
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error")
        End Try
        Return Nothing
    End Function

    ' REMINDER FUNCTIONS

    Public Function CreateReminder(eventId As Integer, userId As Integer, reminderDate As DateTime, reminderType As String) As Boolean
        Try
            Dim query As String = "INSERT INTO Reminders (EventID, UserID, ReminderDate, ReminderType) 
                                   VALUES (@EventID, @UserID, @ReminderDate, @ReminderType)"

            Return ExecuteNonQuery(query,
                New NpgsqlParameter("@EventID", eventId),
                New NpgsqlParameter("@UserID", userId),
                New NpgsqlParameter("@ReminderDate", reminderDate),
                New NpgsqlParameter("@ReminderType", reminderType))
        Catch ex As Exception
            MessageBox.Show("Error creating reminder: " & ex.Message, "Error")
            Return False
        End Try
    End Function

    Public Function GetPendingReminders() As DataTable
        Dim query As String = "SELECT r.*, e.EventName, e.EventDate, e.EventTime, e.Venue, 
                               u.FirstName, u.LastName, u.Email 
                               FROM Reminders r 
                               JOIN Events e ON r.EventID = e.EventID 
                               JOIN Users u ON r.UserID = u.UserID 
                               WHERE r.ReminderSent = FALSE AND r.ReminderDate <= CURRENT_TIMESTAMP 
                               AND e.EventDate > CURRENT_DATE 
                               ORDER BY r.ReminderDate"
        Return ExecuteQuery(query)
    End Function

    Public Function MarkReminderSent(reminderId As Integer) As Boolean
        Dim query As String = "UPDATE Reminders SET ReminderSent = TRUE, DateSent = CURRENT_TIMESTAMP 
                               WHERE ReminderID = @ReminderID"
        Return ExecuteNonQuery(query, New NpgsqlParameter("@ReminderID", reminderId))
    End Function

    ' HELPER FUNCTIONS

    Private Function MapReaderToEvent(reader As NpgsqlDataReader) As Events
        Return New Events With {
            .EventID = reader.GetInt32(0),
            .EventName = reader.GetString(1),
            .Description = If(reader.IsDBNull(2), "", reader.GetString(2)),
            .CategoryID = reader.GetInt32(3),
            .EventDate = reader.GetDateTime(4),
            .EventTime = reader.GetTimeSpan(5),
            .Venue = reader.GetString(6),
            .OrganiserName = reader.GetString(7),
            .OrganiserContact = If(reader.IsDBNull(8), "", reader.GetString(8)),
            .MaxParticipants = reader.GetInt32(9),
            .ImageData = If(reader.IsDBNull(10), Nothing, CType(reader(10), Byte())),
            .ImageFileName = If(reader.IsDBNull(11), "", reader.GetString(11)),
            .ImageContentType = If(reader.IsDBNull(12), "", reader.GetString(12)),
            .DateCreated = reader.GetDateTime(13),
            .CreatedByAdminID = reader.GetInt32(14),
            .IsActive = reader.GetBoolean(15)
        }
    End Function

    Private Function MapReaderToUser(reader As NpgsqlDataReader) As User
        Return New User With {
            .UserID = reader.GetInt32(0),
            .FirstName = reader.GetString(1),
            .LastName = reader.GetString(2),
            .Email = reader.GetString(3),
            .PhoneNumber = If(reader.IsDBNull(4), "", reader.GetString(4)),
            .StudentID_StaffID = reader.GetString(5),
            .Department = If(reader.IsDBNull(6), "", reader.GetString(6)),
            .UserType = reader.GetString(7),
            .DateRegistered = reader.GetDateTime(8)
        }
    End Function
End Class
