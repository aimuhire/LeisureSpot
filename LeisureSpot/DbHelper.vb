Imports System.Data.OleDb
Imports LeisureSpot

Public Class DbHelper

    Dim conn As OleDbConnection

    Public Sub New()
        conn = New OleDbConnection
        conn.ConnectionString = My.Settings.leisureDbConnectionString
    End Sub


    Public Function Login(ByVal email As String, ByVal password As String) As Response
        Try

            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT password FROM Users WHERE email=?"
            cmd.Parameters.Add(New OleDbParameter("@email", email))


            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader
            reader.Read()


            If reader.GetString(0) = password Then
                Return New Response(True, "admin")
            Else
                Return New Response(False, "Incorrect password.")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return New Response(False, "Fatal error. Contact developer.", ex)
        Finally
            conn.Close()
        End Try
    End Function

    Public Function deleteSpot(spotId As Integer) As Response
        Try


            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete From SpotDetails where  ID=?"
            cmd.Parameters.Add(New OleDbParameter("@name", spotId))
            Dim id As Integer
            Integer.TryParse(id, spotId)
            cmd.Parameters.Add(New OleDbParameter("@id", id))
            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else
                Return New Response(False, "Delete failed.")
            End If


        Catch ex As Exception

            Return New Response(False, ex.ToString, ex)
        Finally
            conn.Close()
        End Try

    End Function

    Public Function deleteService(serviceId As Integer) As Response
        Try


            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete From Services where  ID=?"
            cmd.Parameters.Add(New OleDbParameter("@serviceId", serviceId))

            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else
                Return New Response(False, "Delete failed.")
            End If


        Catch ex As Exception

            Return New Response(False, ex.ToString, ex)
        Finally
            conn.Close()
        End Try

    End Function

    Public Function registerUser(ByVal email As String, ByVal password As String) As Response

        Try


            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO Users (email,[password]) values (?,?)"
            cmd.Parameters.Add(New OleDbParameter("@email", email))
            cmd.Parameters.Add(New OleDbParameter("@pass", password))

            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else
                Return New Response(False, "Register failed.")
            End If


        Catch ex As Exception
            Return New Response(False, ex.ToString, ex)
        Finally
            conn.Close()
        End Try
    End Function

    Friend Function updateSpot(spotId As Integer, name As String, imageStr As String, description As String) As Response
        Try


            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "UPDATE SpotDetails SET sname=?, description=? WHERE [ID]=?"
            cmd.Parameters.Add(New OleDbParameter("@name", name))
            cmd.Parameters.Add(New OleDbParameter("@descr", description))

            cmd.Parameters.Add(New OleDbParameter("@id", spotId))

            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else

                Return New Response(False, "Update failed.")
            End If


        Catch ex As Exception

            Return New Response(False, ex.ToString, ex)
        Finally
            conn.Close()
        End Try

    End Function

    Public Function createSpot(ByVal name As String, ByVal imageString As String, ByVal descr As String) As Response

        Try
            conn.Open()
            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO SpotDetails (sname,imageStr,description) values (?,?,?)"
            cmd.Parameters.Add(New OleDbParameter("@name", name))
            cmd.Parameters.Add(New OleDbParameter("@imageStr", imageString))
            cmd.Parameters.Add(New OleDbParameter("@descr", descr))

            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else
                Return New Response(False, "Create spot failed.")
            End If


        Catch ex As Exception
            Return New Response(False, ex.Message, ex)
        Finally
            conn.Close()
        End Try




    End Function

    Public Function GetSpots() As Response
        Try
            Dim spots As New List(Of Dictionary(Of String, String))

            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM SpotDetails"


            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader
            While reader.Read()

                Dim spot As New Dictionary(Of String, String)
                spot.Add("ID", reader.GetInt32(0).ToString)
                spot.Add("name", reader.GetString(2))
                spot.Add("imageStr", reader.GetString(3))
                spots.Add(spot)
            End While

            Dim response As New Response(True)

            response.Data = spots

            Return response


        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)
            Return New Response(False, "Fatal error. Contact developer.", ex)
        Finally
            conn.Close()
        End Try
    End Function


    Public Function GetSpotDetails(ByVal spotId) As Response
        Try

            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM SpotDetails WHERE ID=?"
            cmd.Parameters.Add(New OleDbParameter("@id", spotId))

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader

            reader.Read()
            Dim details As New Dictionary(Of String, String)

            details.Add("spotId", reader.GetInt32(0).ToString)
            details.Add("name", reader.GetString(2))
            details.Add("imageStr", reader.GetString(3))
            details.Add("description", reader.GetString(4))

            Dim response As New Response(True)

            response.Data = details

            Return response


        Catch ex As Exception

            Return New Response(False, "Fatal error. Contact developer.", ex)
        Finally
            conn.Close()
        End Try
    End Function

    Public Function GetSpotServices(ByVal spotId) As Response
        Try

            conn.Open()



            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM Services WHERE spotId=?"
            cmd.Parameters.Add(New OleDbParameter("@id", spotId))

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader

            Dim services As New List(Of Dictionary(Of String, String))

            While reader.Read()

                Dim s As New Dictionary(Of String, String)
                s.Add("ID", reader.GetInt32(0).ToString)
                s.Add("name", reader.GetString(2))
                s.Add("price", reader.GetString(3))

                services.Add(s)

            End While

            Dim response As New Response(True)

            response.Data = services

            Return response


        Catch ex As Exception
            Return New Response(False, "Fatal error. Contact developer.", ex)
        Finally
            conn.Close()
        End Try
    End Function

    Public Function addService(ByVal spotId As Integer, ByVal serviceName As String, ByVal priceInfo As String) As Response

        Try
            conn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO Services (spotId,sname,priceInfo) values (?,?,?)"
            cmd.Parameters.Add(New OleDbParameter("@spotId", spotId))
            cmd.Parameters.Add(New OleDbParameter("@sname", serviceName))
            cmd.Parameters.Add(New OleDbParameter("@priceInfo", priceInfo))

            Dim rows As Integer
            rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                Return New Response(True)
            Else
                Return New Response(False, "Create service failed.")
            End If


        Catch ex As Exception
            Return New Response(False, ex.ToString, ex)
        Finally
            conn.Close()
        End Try
    End Function



End Class
