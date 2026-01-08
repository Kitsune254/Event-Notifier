Public Class UserDashboard

    'Function to open view details page
    Private Sub OpenCategoryPage(categoryName As String)
        ' Create a new instance of your new form
        Dim viewForm As New EventsDetailsView()

        ' Pass the specific category name to it
        viewForm.CurrentCategory = categoryName


        'This makes the Dashboard wait in the background
        viewForm.ShowDialog()
    End Sub

    ' --- BUTTON CLICK EVENTS ---

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        OpenCategoryPage("Sports")
    End Sub

    Private Sub btnCulture_Click(sender As Object, e As EventArgs) Handles btnCulture.Click
        OpenCategoryPage("Culture")
    End Sub

    Private Sub btnAdministrative_Click(sender As Object, e As EventArgs) Handles btnAdministrative.Click
        OpenCategoryPage("Administrative")
    End Sub

    Private Sub btnCareer_Click(sender As Object, e As EventArgs) Handles btnCareer.Click
        OpenCategoryPage("Career")
    End Sub

    Private Sub btnSocial_Click(sender As Object, e As EventArgs) Handles btnSocial.Click
        OpenCategoryPage("Social")
    End Sub

    Private Sub btnAcademics_Click(sender As Object, e As EventArgs) Handles btnAcademics.Click
        OpenCategoryPage("Academic")
    End Sub

End Class