Public Class Leerling

    Inherits Persoon
    Public Property InschrijvingsDatum As Date
    Public Property OS_ASS As Boolean
    Public Property OS_ADHD As Boolean
    Public Property OS_GTS As Boolean
    Public Property LS_Dyslexie As Boolean
    Public Property LS_Dysorthografie As Boolean
    Public Property LS_Dyscalculie As Boolean
    Public Property LS_Andere As String
    Public Property Leervoorsprong As Boolean
    Public Property Pestdader As Boolean
    Public Property Pestslachtoffer As Boolean
    Public Property Anderstalig As Boolean
    Public Property Bisser As Boolean
    Public Property Actief As Integer

    Public Sub New(ByVal id As Integer, ByVal voornaam As String, ByVal familienaam As String, ByVal geboortedatum As Date, ByVal inschrijvingsdatum As Date, _
        ByVal os_ass As Boolean, ByVal os_adhd As Boolean, ByVal os_gts As Boolean, ByVal ls_dyslexie As Boolean, ByVal ls_dysorthografie As Boolean, _
        ByVal ls_dyscalculie As Boolean, ByVal ls_andere As String, _
        ByVal leervoorsprong As Boolean, ByVal pestdader As Boolean, ByVal pestslachtoffer As Boolean, _
        ByVal anderstalig As Boolean, ByVal bisser As Boolean, ByVal actief As Integer)
        Me.ID = id
        Me.VoorNaam = voornaam
        Me.FamilieNaam = familienaam
        Me.GeboorteDatum = geboortedatum
        Me.InschrijvingsDatum = inschrijvingsdatum

        Me.OS_ASS = os_ass
        Me.OS_ADHD = os_adhd
        Me.OS_GTS = os_gts
        Me.LS_Dyslexie = ls_dyslexie
        Me.LS_Dysorthografie = ls_dysorthografie

        Me.LS_Dyscalculie = ls_dyscalculie
        Me.LS_Andere = ls_andere
        Me.Leervoorsprong = leervoorsprong
        Me.Pestdader = pestdader
        Me.Pestslachtoffer = pestslachtoffer

        Me.Anderstalig = anderstalig
        Me.Bisser = bisser
        Me.Actief = actief

    End Sub

    Public Shared Function updateOLEDB(ByVal leerling As Leerling, ByVal actiefLijst As List(Of Actief)) As OleDb.OleDbCommand

        Dim commandText As String = "UPDATE TBL_Leerling SET" & vbCrLf & _
                                    "Voornaam = @Voornaam," & vbCrLf & "Familienaam = @Familienaam," & vbCrLf & "Geboortedatum = @Geboortedatum," & vbCrLf & "Inschrijvingsdatum = @Inschrijvingsdatum," & _
                                    "OS_ASS = @OS_ASS," & vbCrLf & "OS_ADHD=@OS_ADHD," & vbCrLf & "OS_GTS = @OS_GTS," & vbCrLf & "" & _
                                    "LS_Dyslexie = @LS_Dyslexie," & vbCrLf & "LS_Dysorthografie = @LS_Dysorthografie," & vbCrLf & "LS_Dyscalculie= @LS_Dyscalculie," & vbCrLf & "LS_Andere = @LS_Andere," & vbCrLf & _
                                    "Leervoorsprong = @Leervoorsprong," & vbCrLf & "Pestdader = @Pestdader," & vbCrLf & "Pestslachtoffer = @Pestslachtoffer," & vbCrLf & "Anderstalig = @Anderstalig," & vbCrLf & "Bisser = @Bisser," & vbCrLf & "Actief= @Actief " & _
                                    "Where ID = @ID;"

        Dim command As New OleDb.OleDbCommand(commandText)

        With leerling


            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@Inschrijvingsdatum", .InschrijvingsDatum)
            command.Parameters.AddWithValue("@OS_Ass", .OS_ASS)
            command.Parameters.AddWithValue("@OS_ADHD", .OS_ADHD)
            command.Parameters.AddWithValue("@OS_GTS", .OS_GTS)
            command.Parameters.AddWithValue("@LS_Dyslexie", .LS_Dyslexie)
            command.Parameters.AddWithValue("@LS_Dysorthografie", .LS_Dysorthografie)
            command.Parameters.AddWithValue("@LS_Dyscalculie", .LS_Dyscalculie)
            command.Parameters.AddWithValue("@LS_Andere", .LS_Andere)
            command.Parameters.AddWithValue("@Leervoorsprong", .Leervoorsprong)
            command.Parameters.AddWithValue("@Pestdader", .Pestdader)
            command.Parameters.AddWithValue("@Pestslachtoffer", .Pestslachtoffer)
            command.Parameters.AddWithValue("@Anderstalig", .Anderstalig)
            command.Parameters.AddWithValue("@Bisser", .Bisser)
            command.Parameters.AddWithValue("@Actief", .Actief)
            command.Parameters.AddWithValue("@ID", .ID)


        End With
        Dim tekst As String = command.CommandText
        Return command

    End Function

    Public Shared Function insertOLEDB(ByVal leerling As Leerling, ByVal actiefLijst As List(Of Actief)) As OleDb.OleDbCommand
        Dim commandText As String

        commandText = "INSERT INTO TBL_Leerling " & _
        "(Voornaam,Familienaam,Geboortedatum,Inschrijvingsdatum, " & vbCrLf & _
        "OS_Ass, OS_ADHD, OS_GTS, " & vbCrLf & _
        "LS_Dyslexie, LS_Dysorthografie, LS_Dyscalculie, LS_Andere, " & vbCrLf & _
        "Leervoorsprong, Pestdader, Pestslachtoffer, Anderstalig, Bisser, Actief)" & vbCrLf & _
        " values " & vbCrLf & _
        "(@Voornaam,@Familienaam,@Geboortedatum,@Inschrijvingsdatum," & vbCrLf & _
        "@OS_Ass, @OS_ADHD, @OS_GTS," & vbCrLf & _
        "@LS_Dyslexie, @LS_Dysorthografie, @LS_Dyscalculie, @LS_Andere, " & vbCrLf & _
        "@Leervoorsprong, @Pestdader, @Pestslachtoffer, @Anderstalig, @Bisser, @Actief)"

        Dim command As New OleDb.OleDbCommand(commandText)


        With leerling
            command.Parameters.AddWithValue("@Voornaam", .VoorNaam)
            command.Parameters.AddWithValue("@Familienaam", .FamilieNaam)
            command.Parameters.AddWithValue("@Geboortedatum", .GeboorteDatum)
            command.Parameters.AddWithValue("@Inschrijvingsdatum", .InschrijvingsDatum)
            command.Parameters.AddWithValue("@OS_Ass", .OS_ASS)
            command.Parameters.AddWithValue("@OS_ADHD", .OS_ADHD)
            command.Parameters.AddWithValue("@OS_GTS", .OS_GTS)
            command.Parameters.AddWithValue("@LS_Dyslexie", .LS_Dyslexie)
            command.Parameters.AddWithValue("@LS_Dysorthografie", .LS_Dysorthografie)
            command.Parameters.AddWithValue("@LS_Dyscalculie", .LS_Dyscalculie)
            command.Parameters.AddWithValue("@LS_Andere", .LS_Andere)
            command.Parameters.AddWithValue("@Leervoorsprong", .Leervoorsprong)
            command.Parameters.AddWithValue("@Pestdader", .Pestdader)
            command.Parameters.AddWithValue("@Pestslachtoffer", .Pestslachtoffer)
            command.Parameters.AddWithValue("@Anderstalig", .Anderstalig)
            command.Parameters.AddWithValue("@Bisser", .Bisser)
            command.Parameters.AddWithValue("@Actief", .Actief)
        End With

        Return command
    End Function

End Class

