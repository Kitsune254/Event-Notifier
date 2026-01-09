Public Class User
    Public Property UserID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property StudentID_StaffID As String
    Public Property Department As String
    Public Property UserType As String
    Public Property DateRegistered As DateTime

    Public Sub New()
        UserID = 0
        FirstName = ""
        LastName = ""
        Email = ""
        PhoneNumber = ""
        StudentID_StaffID = ""
        Department = ""
        UserType = ""
        DateRegistered = DateTime.Now
    End Sub

    'get the fullname
    Public ReadOnly Property FullName As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

    ' checking if all required data is entered
    Public Function Validate() As List(Of String)
        Dim errors As New List(Of String)

        If String.IsNullOrWhiteSpace(FirstName) Then
            errors.Add("First name is required")
        End If

        If String.IsNullOrWhiteSpace(LastName) Then
            errors.Add("Last name is required")
        End If

        If Not IsValidEmail(Email) Then
            errors.Add("Please enter a valid email address")
        End If

        If String.IsNullOrWhiteSpace(StudentID_StaffID) Then
            errors.Add("Student ID / Staff ID is required")
        End If

        Return errors
    End Function

    ' e-mail validation
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    ' display 
    Public Overrides Function ToString() As String
        Return FullName
    End Function


End Class