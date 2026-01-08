Imports Npgsql

Class EventRegistrationForm
    Private txtDepartment As Object

    Private Function Validation() As Boolean
        Dim IsValid As Boolean
        IsValid = True
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then

            IsValid = False
        End If
        If String.IsNullOrWhiteSpace(txtLastname.Text) Then

            IsValid = False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not ValidEmail(txtEmail.Text) Then

            IsValid = False
        End If
        If String.IsNullOrWhiteSpace(cmbUserType.Text) Then

            IsValid = False
        End If
        If String.IsNullOrWhiteSpace(txtID.Text) Then

            IsValid = False
        End If
        If Not (ChckbxTerms.IsChecked) Then

            IsValid = False
        End If

        Return IsValid
    End Function

    Private Function ValidEmail(email As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Text.RegularExpressions.Regex(pattern)
        Return regex.IsMatch(email)
    End Function




    Private Sub Register_Click(sender As Object, e As RoutedEventArgs) Handles Register.Click
        If Not Validation() Then
            MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error)
            Return
        End If
        Dim database As New DatabaseHelper()
        If database.DuplicateRegistration(txtEmail.Text.Trim()) Then
            MessageBox.Show("An account with this email already exists.", "Duplicate Registration", MessageBoxButton.OK, MessageBoxImage.Warning)
            Exit Sub
        End If

        Dim success = database.CreateUser(
            txtFirstName.Text.Trim(),
            txtLastname.Text.Trim(),
            txtEmail.Text.Trim(),
            txtPhonenumber.Text.Trim(),
            cmbUserType.SelectedItem.ToString(),
            txtID.Text.Trim(),
            txtDepartment.Text.Trim())


        If success Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information)
            Close()
        Else
            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As RoutedEventArgs) Handles btnCancel.Click
        Dim result = MessageBox.Show("Are you sure you want to cancel the registration?", "Confirm Cancel", MessageBoxButton.YesNo, MessageBoxImage.Question)
        If result = MessageBoxResult.Yes Then
            Dim dash As New userDashboard()
            dash.Show()
            Me.Hide()
        End If

    End Sub


End Class
