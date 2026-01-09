Public Class Registration
    Public Property RegistrationID As Integer
    Public Property EventID As Integer
    Public Property UserID As Integer
    Public Property RegistrationDate As DateTime
    Public Property Status As String
    Public Property Notes As String

    ' Constructor
    Public Sub New()
        RegistrationID = 0
        EventID = 0
        UserID = 0
        RegistrationDate = DateTime.Now
        Status = "Confirmed"
        Notes = ""
    End Sub

    ' Display method
    Public Overrides Function ToString() As String
        Return "Registration #" & RegistrationID & " - " & Status
    End Function
End Class