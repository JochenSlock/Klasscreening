Public Class Persoon
    Public Property ID As Integer
    Public Property VoorNaam As String
    Public Property FamilieNaam As String
    Public Property GeboorteDatum As Date

    Public Overrides Function ToString() As String
        'Return MyBase.ToString()
        If ID < 10000 Then
            Return String.Format("{0}, {1} *", FamilieNaam, VoorNaam)
        Else
            Return String.Format("{0}, {1}", FamilieNaam, VoorNaam)
        End If
    End Function
End Class
