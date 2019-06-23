Public Class UCListSpots
    Dim spotItem As UCSpotItem

    Private Sub UCListSpots_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbHelper As New DbHelper
        Dim res As Response = dbHelper.GetSpots()

        If res.Success Then
            showSpotList(res.Data)
        Else
            MessageBox.Show(res.Message)
        End If


    End Sub

    Private Sub showSpotList(ByVal spots As List(Of Dictionary(Of String, String)))
        flowLaySpots.Controls.Clear()

        For Each spot In spots

            Dim spotView As New UCSpotItem
            spotView.SpotId = spot.Item("ID")
            spotView.ImgStr = spot.Item("imageStr")
            spotView.SpotName = spot.Item("name")

            flowLaySpots.Controls.Add(spotView)

        Next

    End Sub

    Private Sub UCSpotItem_Click(sender As Object, e As EventArgs)
        'Handles imgL.Click
        '   MessageBox.Show("yo " + e.ToString)
    End Sub


End Class
