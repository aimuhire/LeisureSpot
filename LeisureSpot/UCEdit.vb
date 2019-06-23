Public Class UCEdit
    Dim destinationPath As String
    Dim imageStr As String
    Dim spotId As Integer

    Public Property ImageStr1 As String
        Get
            Return imageStr
        End Get
        Set(value As String)
            imageStr = value
        End Set
    End Property

    Public Property DestinationPath1 As String
        Get
            Return destinationPath
        End Get
        Set(value As String)
            destinationPath = value
        End Set
    End Property

    Public Property SpotId1 As Integer
        Get
            Return spotId
        End Get
        Set(value As Integer)
            spotId = value
        End Set
    End Property

    Private Sub btnPickImage_Click(sender As Object, e As EventArgs) Handles btnPickImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Pick site featured image."
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.SafeFileName


            Try
                DestinationPath1 = My.Application.Info.DirectoryPath + "\featured\" + fd.SafeFileName
                My.Computer.FileSystem.CopyFile(fd.FileName, DestinationPath1)
                setImage()

                ImageStr1 = fd.SafeFileName
            Catch ex As Exception
                MessageBox.Show("uceditspotvb " + ex.ToString)
                setImage()

            End Try

        End If
    End Sub
    Public Sub setImage()
        Try
            Dim path As String = DestinationPath1
            Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
                pbFeatured.Image = Image.FromStream(fs)

            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnUpdateSpot_Click(sender As Object, e As EventArgs) Handles btnUpdateSpot.Click
        Dim dbHelper As New DbHelper

        Dim res As Response = dbHelper.updateSpot(SpotId1, tbName.Text, ImageStr1, tbDescr.Text)
        If res.Success Then
            MessageBox.Show("Leisure site updated.")
        Else
            MessageBox.Show("Leisure site not updated: " + res.Message)
        End If
    End Sub
End Class
