Public Class Verhuis
    Public Property persoon As Persoon
    Public Property VanKlas As KlasNaam
    Public Property NaarKlas As KlasNaam

    Public Sub New(persoon As Persoon, vanklas As KlasNaam)
        Me.persoon = persoon
        Me.VanKlas = vanklas
        Me.NaarKlas = vanklas
    End Sub
    Public Overrides Function ToString() As String
        'Return MyBase.ToString()
        Return persoon.ToString
    End Function
    Public Function ToStringGewijzigd(klasnaamLijst As List(Of KlasNaam)) As String
        'Return MyBase.ToString()
        Dim vanKlasNaam As String = klasnaamLijst.Where(Function(x) x.ID = VanKlas.ID).First.Naam
        Dim naarKlasNaam As String = klasnaamLijst.Where(Function(x) x.ID = NaarKlas.ID).First.Naam
        Return String.Format("{0} : {1} --> {2}", persoon.ToString, VanKlas.Naam, NaarKlas.Naam)
    End Function


End Class
