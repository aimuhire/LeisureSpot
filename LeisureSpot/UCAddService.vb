Public Class UCAddService

    Private _spotId As Integer

    Public Property SpotId As Integer
        Get
            Return _spotId
        End Get
        Set(value As Integer)
            _spotId = value
        End Set
    End Property

    Private Sub btnServiceAdd_Click(sender As Object, e As EventArgs) Handles btnServiceAdd.Click
        If tbServiceName.Text Is Nothing Or tbPriceInfo Is Nothing Then
            MessageBox.Show("All fields are required")
            Exit Sub

        End If
        Dim dbHelper As New DbHelper

        Dim res As Response = dbHelper.addService(SpotId, tbServiceName.Text, tbPriceInfo.Text)

        If res.Success Then

            MainForm.createScreen("leisurespot.uclistspots")
            MessageBox.Show("Service added successfully.")
        Else
            MessageBox.Show(res.Message)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MainForm.createScreen("leisurespot.ucspotdetails")

    End Sub
End Class
