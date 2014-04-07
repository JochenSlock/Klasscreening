Public Class KlasNaam

    Public Property ID As Integer
    Public Property Naam As String
    Public Sub New(id As Integer, naam As String)
        Me.ID = id
        Me.Naam = naam
    End Sub
    Public Overrides Function ToString() As String
        Return Naam

    End Function
    Public Shared Function updateOLEDB(ByRef klasnaam As KlasNaam) As OleDb.OleDbCommand
        Dim commandText As String = "UPDATE LST_Klasnaam SET" & vbCrLf & _
                                    "Naam = @Naam" & vbCrLf &
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klasnaam

            Command.Parameters.AddWithValue("@Naam", .Naam)
            Command.Parameters.AddWithValue("@ID", .ID)

        End With
        Dim tekst As String = Command.CommandText
        Return command
    End Function
    Public Shared Function insertOLEDB(ByRef klasnaam As KlasNaam) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO LST_Klasnaam " & _
        "(Naam)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Naam)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klasnaam
            command.Parameters.AddWithValue("@Naam", .Naam)
        End With

        Return command
    End Function

End Class
