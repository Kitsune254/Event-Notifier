Imports System.IO
Imports System.Net.Http



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.png;*.jpg;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then
            filePath = ofd.FileName
        Else
            MessageBox.Show("Choose a file!!!")
            Exit Sub
        End If

        Dim supabaseUrl As String = "https://zezzswjjdyoaeyunasue.supabase.co"
        Dim anonKey As String = "sb_publishable_suvic5NTBZZLESghvpobJg_F6aS1S60"

        Dim bucket As String = "VB"

        Dim extension As String = Path.GetExtension(filePath).ToLower()
        Dim type As String

        Select Case extension
            Case ".jpg", ".jpeg"
                type = "image/jpeg"
            Case ".png"
                type = "image/png"
            Case Else
                MessageBox.Show("Unsupported file type")
                Exit Sub
        End Select

        Dim uniqueName As String = Guid.NewGuid().ToString() & extension
        Dim uploadUrl As String = $"{supabaseUrl}/storage/v1/object/{bucket}/{uniqueName}"

        Dim client As New HttpClient()
        client.DefaultRequestHeaders.Add("Authorization", "Bearer" & anonKey)
        client.DefaultRequestHeaders.Add("apikey", anonKey)

        Dim bytes = File.ReadAllBytes(filePath)
        Dim content As New ByteArrayContent(bytes)
        content.Headers.ContentType = New Headers.MediaTypeHeaderValue(type)

        Dim response = Await client.PostAsync(uploadUrl, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Upload Successful!")
        Else
            MessageBox.Show("Upload failed")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim HomePage As New UserDashboard()
        HomePage.Show()
        Me.Hide()
    End Sub
End Class
