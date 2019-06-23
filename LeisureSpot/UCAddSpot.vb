Public Class UCAddSpot
    Dim destinationPath As String
    Dim imageStr As String
    Private Sub btnPickImage_Click(sender As Object, e As EventArgs) Handles btnPickImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Pick site featured image."
        fd.RestoreDirectory = True
        fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.SafeFileName


            Try
                destinationPath = My.Application.Info.DirectoryPath + "\featured\" + fd.SafeFileName
                My.Computer.FileSystem.CopyFile(fd.FileName, destinationPath)
                setImage()

                imageStr = fd.SafeFileName
            Catch ex As Exception
                setImage()

            End Try

        End If
    End Sub

    Public Sub setImage()
        Try
            Dim path As String = destinationPath
            Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
                pbFeatured.Image = Image.FromStream(fs)

            End Using
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnCreateSpot_Click(sender As Object, e As EventArgs) Handles btnCreateSpot.Click

        If tbName.Text Is Nothing Or tbDescr Is Nothing Or imageStr Is Nothing Then
            MessageBox.Show("All fields are required")
            Exit Sub
        End If
        Dim dbHelper As New DbHelper

        Dim res As Response = dbHelper.createSpot(tbName.Text, imageStr, tbDescr.Text)
        If res.Success Then
            tbDescr.Clear()
            tbName.Clear()
            pbFeatured.Image = pbFeatured.InitialImage
            MessageBox.Show("Leisure site created.")
        Else
            MessageBox.Show("Leisure site not created: " + res.Message)
        End If
    End Sub

End Class
