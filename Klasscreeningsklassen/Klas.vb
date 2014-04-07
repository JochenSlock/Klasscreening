Public Class Klas
    Public Property ID As Integer
    Public Property Naam As Integer
    Public Property Deelnemer As Integer
    Public Property StartTijdStip As Date
    Public Property StopTijdStip As Nullable(Of Date)
    Public Sub New(id As Integer, naam As Integer, deelnemer As Integer, starttijdstip As Date, stoptijdstip As Nullable(Of Date))
        Me.ID = id
        Me.Naam = naam
        Me.Deelnemer = deelnemer
        Me.StartTijdStip = starttijdstip
        Me.StopTijdStip = stoptijdstip
    End Sub

    Public Shared Function updateOLEDB(ByRef klas As Klas) As OleDb.OleDbCommand
        Dim commandText As String = "UPDATE TBL_Klas SET" & vbCrLf & _
                                    "Naam = @Naam" & vbCrLf &
                                    "Deelnemer = @Deelnemer" & vbCrLf &
                                    "Lokaal = @Lokaal" & vbCrLf &
                                    "StartTijdStip = @StartTijdStip" & vbCrLf &
                                    "StopTijdStip = @StopTijdStip" & vbCrLf &
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klas

            command.Parameters.AddWithValue("@Naam", .Naam)
            command.Parameters.AddWithValue("@Deelnemer", .Deelnemer)
            command.Parameters.AddWithValue("@StartTijdStip", .StartTijdStip)
            command.Parameters.AddWithValue("@StopTijdStip", .StopTijdStip)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Dim tekst As String = command.CommandText
        Return command
    End Function
    Public Shared Function insertOLEDB(ByRef klas As Klas) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO TBL_Klas " & _
            "(Naam)" & vbCrLf & _
            "(Deelnemer)" & vbCrLf & _
            "(Lokaal)" & vbCrLf & _
            "(StartTijdStip)" & vbCrLf & _
            "(StopTijdStip)" & vbCrLf & _
            " values " & vbCrLf & _
            "(@Naam,@Deelnemer,@Lokaal,@StartTijdStip,@StopTijdStip)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With klas
            command.Parameters.AddWithValue("@Naam", .Naam)
            command.Parameters.AddWithValue("@Deelnemer", .Deelnemer)
            command.Parameters.AddWithValue("@StartTijdStip", .StartTijdStip)
            command.Parameters.AddWithValue("@StopTijdStip", .StopTijdStip)
        End With

        Return command
    End Function

End Class
