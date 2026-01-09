Public Class Events
    Public Property EventID As Integer
    Public Property EventName As String
    Public Property Description As String
    Public Property CategoryID As Integer
    Public Property EventDate As Date
    Public Property EventTime As TimeSpan
    Public Property Venue As String
    Public Property OrganiserName As String
    Public Property OrganiserContact As String
    Public Property MaxParticipants As Integer
    Public Property ImageData As Byte()
    Public Property ImageFileName As String
    Public Property ImageContentType As String
    Public Property DateCreated As DateTime
    Public Property CreatedByAdminID As Integer
    Public Property IsActive As Boolean

    ' Constructor
    Public Sub New()
        EventID = 0
        EventName = ""
        Description = ""
        CategoryID = 0
        EventDate = Date.Today
        EventTime = New TimeSpan(0, 0, 0)
        Venue = ""
        OrganiserName = ""
        OrganiserContact = ""
        MaxParticipants = 0
        ImageData = Nothing
        ImageFileName = ""
        ImageContentType = ""
        DateCreated = DateTime.Now
        CreatedByAdminID = 0
        IsActive = True
    End Sub

    ' Validation method
    Public Function Validate() As List(Of String)
        Dim errors As New List(Of String)

        If String.IsNullOrWhiteSpace(EventName) Then
            errors.Add("Event name is required")
        ElseIf EventName.Length < 5 Then
            errors.Add("Event name must be at least 5 characters")
        End If

        If EventDate < Date.Today Then
            errors.Add("Event date cannot be in the past")
        End If

        If String.IsNullOrWhiteSpace(Venue) Then
            errors.Add("Venue is required")
        End If

        If String.IsNullOrWhiteSpace(OrganiserName) Then
            errors.Add("Organiser name is required")
        End If

        If MaxParticipants < 0 Then
            errors.Add("Maximum participants cannot be negative")
        End If

        If CategoryID <= 0 Then
            errors.Add("Please select a category")
        End If

        Return errors
    End Function

    ' Display method
    Public Overrides Function ToString() As String
        Return EventName & " - " & EventDate.ToShortDateString()
    End Function
End Class