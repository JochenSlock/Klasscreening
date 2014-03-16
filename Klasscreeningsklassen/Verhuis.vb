Public Class Verhuis
    Public Property llnID As Integer
    Public Property VanKlas As String
    Public Property NaarKlas As String
    Public Property VoorNaam As String
    Public Property FamilieNaam As String
    Public Sub New(llnid As Integer, vanKlas As String, naarKlas As String, voorNaam As String, familieNaam As String)
        Me.llnID = llnid
        Me.VanKlas = vanKlas
        Me.NaarKlas = naarKlas
        Me.VoorNaam = voorNaam
        Me.FamilieNaam = familieNaam
    End Sub

    Public Overrides Function ToString() As String
        Return FamilieNaam & ", " + VoorNaam
    End Function
    Public Function ToString2() As String
        Return String.Format("{0}, {1} : {2} --> {3}", FamilieNaam, VoorNaam, VanKlas, NaarKlas)
    End Function

End Class
