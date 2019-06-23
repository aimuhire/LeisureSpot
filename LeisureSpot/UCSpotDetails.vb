Public Class UCSpotDetails
    Private _spotId As Integer
    Private _fileName As String

    Private _serviceIdDict As Dictionary(Of Integer, Integer)

    Public Property SpotId As Integer

        Get
            Return _spotId
        End Get

        Set(value As Integer)
            _spotId = value
        End Set
    End Property

    Public Property ServiceIdDict As Dictionary(Of Integer, Integer)
        Get
            Return _serviceIdDict
        End Get
        Set(value As Dictionary(Of Integer, Integer))
            _serviceIdDict = value
        End Set
    End Property

    Public Property FileName As String
        Get
            Return _fileName
        End Get
        Set(value As String)
            _fileName = value
        End Set
    End Property

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editSpot As New UCEdit

        editSpot.tbName.Text = lblName.Text
        editSpot.SpotId1 = SpotId
        editSpot.tbDescr.Text = lblDescription.Text
        MainForm.Controls.Item("screenContainer").Controls.Add(editSpot)
        editSpot.BringToFront()
        editSpot.Location = New Point(1, 27)

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Site name: " + lblName.Text, "Are you sure you want to delete this leisure spot ?", MessageBoxButtons.OKCancel)
        If result <> DialogResult.OK Then
            Exit Sub
        End If


        Dim dbHelper As New DbHelper
        Dim res As Response = dbHelper.deleteSpot(SpotId)

        If res.Success Then
            MessageBox.Show("Delete successful.")
            removeFile()

            MainForm.createScreen("leisurespot.uclistspots")

        Else
            MessageBox.Show("Delete not successful.")
            MessageBox.Show(res.Message)
            'MessageBox.Show(res.Data.ToString)
        End If
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim addServiceView As New UCAddService
        addServiceView.Location = New Point(243, 109)
        addServiceView.SpotId = SpotId
        MainForm.Controls.Item("screenContainer").Controls.Add(addServiceView)
        addServiceView.BringToFront()
    End Sub

    Private Sub dgvServices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServices.CellContentClick

        If LoginInfo.access <> "admin" Then
            Exit Sub
        End If
        Dim result As Integer = MessageBox.Show(dgvServices.Item(0, e.RowIndex).Value + " price: " + dgvServices.Item(1, e.RowIndex).Value, "Are you sure you want to delete this service ?", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Dim dbHelper As New DbHelper
            Dim res As Response = dbHelper.deleteService(ServiceIdDict(e.RowIndex))

            If res.Success Then
                MessageBox.Show("Service deleted!")
                MainForm.createScreen("leisurespot.uclistspots")
            Else
                MessageBox.Show(res.Message)
            End If
        End If
    End Sub

    Private Sub removeFile()
        Dim filePath As String = My.Application.Info.DirectoryPath + "\featured\" + FileName

        Try
            pbFeatured.Image = pbFeatured.InitialImage
            My.Computer.FileSystem.DeleteFile(filePath)
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try

    End Sub


End Class
