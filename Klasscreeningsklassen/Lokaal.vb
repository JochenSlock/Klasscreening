Public Class Lokaal

    Public Property ID As Integer
    Public Property LokaalNr As Integer
    Public Property LokaalNaam As String

    Sub New(id As Integer, lokaalnr As Integer, lokaalnaam As String)
        Me.ID = id
        Me.LokaalNr = lokaalnr
        Me.LokaalNaam = lokaalnaam
    End Sub
    Public Shared Function insertOLEDB(ByRef lokaal As Lokaal) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO LST_Lokalen " & _
        "(LokaalNr,LokaalNaam)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@LokaalNr,@LokaalNaam)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With lokaal
            command.Parameters.AddWithValue("@LokaalNr", .LokaalNr)
            command.Parameters.AddWithValue("@LokaalNaam", .LokaalNaam)
        End With

        Return command
    End Function
    Public Shared Function updateOLEDB(ByRef lokaal As Lokaal) As OleDb.OleDbCommand
        Dim commandText As String = "UPDATE LST_Lokalen SET" & vbCrLf & _
                                    "LokaalNr = @LokaalNr," & vbCrLf & "LokaalNaam = @LokaalNaam" & vbCrLf & _
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With lokaal

            command.Parameters.AddWithValue("@LokaalNr", .LokaalNr)
            command.Parameters.AddWithValue("@LokaalNaam", .LokaalNaam)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Dim tekst As String = command.CommandText
        Return command
    End Function
End Class
