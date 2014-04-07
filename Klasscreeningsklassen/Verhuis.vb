Public Class Verhuis
    Public Property persoonID As Integer
    Public Property VanKlasNr As Integer
    Public Property NaarKlasNr As Integer

    Public Sub New(persoonid As Integer, vanklasnr As Integer)
        Me.persoonID = persoonid
        Me.VanKlasNr = vanklasnr
        Me.NaarKlasNr = vanklasnr
    End Sub


End Class
