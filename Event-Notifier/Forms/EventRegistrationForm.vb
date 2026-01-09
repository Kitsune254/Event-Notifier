Imports Npgsql

Public Class EventRegistrationForm

    Private _eventId As Integer
    Private _userId As Integer
    Private _dbHelper As New DatabaseHelper()

    Public Sub New(eventId As Integer, userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _eventId = eventId
        _userId = userId

    End Sub

    Private Sub EventRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEventID.Text = _eventId.ToString()
        lblUserID.Text = _userId.ToString()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim notes As String = txtNotes.Text.Trim()

        If _dbHelper.RegisterUserForEvent(_eventId, _userId, notes) Then
            MessageBox.Show("You have been successfully registered for the event!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' The error message is shown by the database helper, so we just close the form.
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
