Public Class Actief
    Public Property ID As Integer
    Public Property Omschrijving As String
    Public Sub New(id As Integer, Omschrijving As String)
        Me.ID = id
        Me.Omschrijving = Omschrijving
    End Sub
    Public Shared Function insertOLEDB(ByRef actief As Actief) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO LST_Actief " & _
        "(Omschrijving)" & _
        " values " & vbCrLf & _
        "(@Omschrijving)"

        Dim command As New OleDb.OleDbCommand(commandText)

        With actief
            command.Parameters.AddWithValue("@Omschrijving", .Omschrijving)

        End With

        Return command
    End Function
    Public Shared Function updateOLEDB(ByRef actief As Actief) As OleDb.OleDbCommand
        Dim commandText As String = "UPDATE LST_Actief SET" & vbCrLf & _
                                    "Omschrijving = @Omschrijving" & vbCrLf & _
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With Actief

            command.Parameters.AddWithValue("@Omschrijving", .Omschrijving)
            command.Parameters.AddWithValue("@ID", .ID)

        End With
        Dim tekst As String = command.CommandText
        Return command
    End Function
    Public Overrides Function ToString() As String
        Return Omschrijving
    End Function
End Class
