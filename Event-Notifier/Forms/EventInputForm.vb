Imports System.IO
Imports University_EventPlatform.Classes

Public Class EventInputForm
    Private currentImageBytes As Byte() = Nothing
    Private currentImageFileName As String = ""
    Private currentImageContentType As String = ""

    Private Sub EventInputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        dtpEventDate.MinDate = Date.Today
    End Sub

    Private Sub LoadCategories()
        Dim db As New DatabaseHelper()
        Dim dt As DataTable = db.GetAllCategories()

        ' We bind the DataTable directly to the ComboBox
        ' The "ToString()" method in EventCategory.vb ensures the name will display correctly
        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "CategoryName"
        cmbCategory.ValueMember = "CategoryID"
        cmbCategory.SelectedIndex = -1 ' Start with nothing selected
    End Sub

    ' IMAGE UPLOAD LOGIC
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
        ofd.Title = "Select Event Poster"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                ' 1. Display the Event image
                pbEventImage.Image = Image.FromFile(ofd.FileName)
                
                ' 2. Convert file to bytes array to store at database
                Dim fileInfo As New FileInfo(ofd.FileName)
                currentImageBytes = File.ReadAllBytes(ofd.FileName)
                currentImageFileName = fileInfo.Name
                currentImageContentType = "image/" & fileInfo.Extension.Trim("."c)
                
                ' 3. Show info
                lblImageInfo.Text = fileInfo.Name
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        pbEventImage.Image = Nothing
        currentImageBytes = Nothing
        currentImageFileName = ""
        lblImageInfo.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. Create the Event Object from Inputs
        Dim newEvent As New Events()
        newEvent.EventName = txtEventName.Text.Trim()
        newEvent.Description = rtbDescription.Text.Trim()
        
        If cmbCategory.SelectedValue IsNot Nothing Then
            newEvent.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue)
        End If

        newEvent.EventDate = dtpEventDate.Value.Date
        newEvent.EventTime = dtpEventTime.Value.TimeOfDay
        newEvent.Venue = txtVenue.Text.Trim()
        newEvent.OrganiserName = txtOrganiserName.Text.Trim()
        newEvent.OrganiserContact = txtOrganiserContact.Text.Trim()
        newEvent.MaxParticipants = CInt(nudMaxParticipants.Value)
        
        ' Image Data
        newEvent.ImageData = currentImageBytes
        newEvent.ImageFileName = currentImageFileName
        newEvent.ImageContentType = currentImageContentType
        
        ' 2. Use the built-in Validation we added to Events.vb
        Dim errors As List(Of String) = newEvent.Validate()

        If errors.Count > 0 Then
            MessageBox.Show(String.Join(vbCrLf, errors), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Save to Database
        Try
            Dim db As New DatabaseHelper()
            Dim newId As Integer = db.CreateEvent(newEvent)

            If newId > 0 Then
                MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Close this form
            Else
                MessageBox.Show("Failed to save event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
