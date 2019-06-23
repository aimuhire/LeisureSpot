Public Class MainForm
    'This is a mockup project 
    'author: Arsene I. Muhire
    'Lisence: check github project lisence 
    'Description: Could be used by Airport to guide visitors to great places around the region

    'Issues: drop them at my email marsanline@gmail.com
    'Issues: add delete service entry on spot deletion
    '=================================
    ' Always willing to learn new stuff drop the code critics/reviews
    'LeisureSpot v1.0.0
    'Credits: Jean de Dieu & Group Mate at CBE

    '-------: All da best:-------

    Public myMenu As New MenuStrip
    Private addSpotScreen As New UCAddSpot
    Private adminPanelScreen As New UCAdminPanel
    Private loginRegisterScreen As New UCLoginRegister

    Private spotList As UCListSpots


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        spotList = New UCListSpots
        spotList.Location = New Point(1, 27)
        screenContainer.Controls.Add(spotList)
        spotList.BringToFront()
        Controls.Add(myMenu)
        showMainMenu()



    End Sub

    Private Sub showMainMenu()



        myMenu.Items.Clear()

        addSpotsBtn()
        If LoginInfo.access = "admin" Then
            addAdminButtons()
        Else
            addLoginBtn()
        End If
    End Sub

    Public Sub addLoginBtn()
        Dim msItemLogin As New ToolStripMenuItem("Account")
        AddHandler msItemLogin.Click, AddressOf login_click
        myMenu.Items.Add(msItemLogin)
    End Sub
    Public Sub addSpotsBtn()
        Dim msItemSpots As New ToolStripMenuItem("Spots")
        myMenu.Items.Add(msItemSpots)
        AddHandler msItemSpots.Click, AddressOf SpotsToolStripMenuItem_Click


    End Sub
    Public Sub addAdminButtons()
        If LoginInfo.access = "admin" Then


            Dim msItemSpots As New ToolStripMenuItem("Admin Panel")
            myMenu.Items.Add(msItemSpots)
            AddHandler msItemSpots.Click, AddressOf spotsbtn_click


            Dim msItemLogout As New ToolStripMenuItem("Logout")
            myMenu.Items.Add(msItemLogout)
            AddHandler msItemLogout.Click, AddressOf logout_click

        End If
    End Sub
    Public Sub createScreen(ByVal screenName As String)

        screenContainer.Controls.Clear()
        showMainMenu()

        Select Case (screenName)
            Case "leisurespot.uclistspots"
                displayScreen(New UCListSpots)

            Case "leisurespot.ucaddspot"
                displayScreen(addSpotScreen)

            Case "leisurespot.ucadminpanel"
                displayScreen(adminPanelScreen)

            Case "leisurespot.ucloginregister"
                displayScreen(loginRegisterScreen)

            Case Else
                displayScreen(New UCListSpots)

        End Select


    End Sub


    Private Sub SpotsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        createScreen("leisurespot.uclistspots")

    End Sub

    Private Sub spotsbtn_click(sender As Object, e As EventArgs)
        createScreen("leisurespot.ucadminpanel")

    End Sub

    Private Sub logout_click(sender As Object, e As EventArgs)

        createScreen("leisurespot.ucloginregister")
        LoginInfo.access = "user"
        showMainMenu()


    End Sub


    Private Sub login_click(sender As Object, e As EventArgs)
        createScreen("leisurespot.ucloginregister")
        MessageBox.Show("Default email: admin@admin.com  password: admin")



    End Sub


    Private Sub displayScreen(ByRef screen As UserControl)

        'screen.Location = New Point(1, 27)
        screenContainer.Controls.Add(screen)
        screen.BringToFront()
    End Sub


End Class
