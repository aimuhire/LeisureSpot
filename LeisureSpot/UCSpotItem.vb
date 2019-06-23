Public Class UCSpotItem
    Private _spotId As Integer
    Private _imgStr As String
    Private _SpotName As String
    Public Property SpotId As Integer
        Get
            Return _spotId
        End Get
        Set(value As Integer)
            _spotId = value
        End Set
    End Property

    Public Property ImgStr As String
        Get
            Return _imgStr
        End Get
        Set(value As String)
            _imgStr = value
            Using fs As New IO.FileStream(My.Application.Info.DirectoryPath + "\featured\" + value, IO.FileMode.Open, IO.FileAccess.Read)
                pbSpot.Image = Image.FromStream(fs)

            End Using
        End Set
    End Property

    Public Property SpotName As String
        Get
            Return _SpotName
        End Get
        Set(value As String)
            _SpotName = value
            lblSpotName.Text = value
        End Set
    End Property

    Private Sub UCSpotItem_Click(sender As Object, e As EventArgs) Handles pbSpot.Click

        Dim dbHelper As New DbHelper
        Dim sDict As New Dictionary(Of Integer, Integer)
        Dim res As Response = dbHelper.GetSpotDetails(SpotId)
        Dim sRes As Response = dbHelper.GetSpotServices(SpotId)
        If Not res.Success Then
            '      MessageBox.Show(sRes.Message) 
            ' MessageBox.Show(res.Dat)
            Exit Sub
        End If




        Dim spotDets As New UCSpotDetails
        Dim details As New Dictionary(Of String, String)
        Dim services As New List(Of Dictionary(Of String, String))
        spotDets.Location = New Point(1, 27)
        details = res.Data
        spotDets.lblName.Text = details.Item("name")
        spotDets.lblDescription.Text = details.Item("description")
        Dim path As String = My.Application.Info.DirectoryPath + "\featured\" + details.Item("imageStr")
        Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
            spotDets.pbFeatured.Image = Image.FromStream(fs)

        End Using


        spotDets.SpotId = details.Item("spotId")
        spotDets.FileName = details.Item("imageStr")
        services = sRes.Data
        Dim i As Integer = 0
        For Each service In services
            sDict.Add(i, service.Item("ID"))
            spotDets.dgvServices.RowCount = services.Count

            spotDets.dgvServices.Item(0, i).Value = service.Item("name")

            spotDets.dgvServices.Item(1, i).Value = service.Item("price")

            i += 1
        Next
        If LoginInfo.access = "admin" Then
            spotDets.btnDelete.Visible = True
            spotDets.btnEdit.Visible = True
            spotDets.btnAddService.Visible = True
        Else
            spotDets.btnDelete.Visible = False
            spotDets.btnEdit.Visible = False
            spotDets.btnAddService.Visible = False
        End If
        spotDets.ServiceIdDict = sDict
        MainForm.Controls.Item("screenContainer").Controls.Add(spotDets)
        spotDets.BringToFront()



    End Sub


End Class
