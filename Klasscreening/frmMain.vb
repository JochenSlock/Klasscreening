Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class frmMain

    Public leerkrachtenLijst As New List(Of Leerkracht)
    Public leerlingenLijst As New List(Of Leerling)
    Public klassenLijst As New List(Of Klas)
    Public klasNaamLijst As New Dictionary(Of Integer, String)
    Public klasLokalenLijst As New Dictionary(Of Integer, String)
    Public actiefLijst As New Dictionary(Of Integer, String)
    Public verhuisLijst As New List(Of verhuis)

    Private Sub OphalenLijsten()

        GlobalVariables.conn.Open()
        actiefLijst = DBRoutines.LaadActief()
        klasNaamLijst = DBRoutines.LaadKlasNamen()
        klassenLijst = DBRoutines.LaadKlassen()
        leerkrachtenLijst = DBRoutines.LaadLeerkrachten()
        leerlingenLijst = DBRoutines.LaadLeerlingen(actiefLijst)
        klasLokalenLijst = DBRoutines.LaadLokalen()
        GlobalVariables.conn.Close()
    End Sub

    Private Sub tmiAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiAfsluiten.Click

        Me.Close()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialiseren van de opstart mogelijkheden, er moet eerst worden ingelogd om aan de verschillende opties te kunnen.
        ' Inloggen is nodig om in de logfiles een correcte naam te kunnen zetten.
        '---------------------------------------------------------------------------------------------------------------------

        OphalenLijsten()



    End Sub

    Private Sub tmiInloggen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiInloggen.Click

        frmInloggen.ShowDialog()

    End Sub

    Public Sub EnableAlleMenuItems()

        tmiActiefstatus.Enabled = True
        tmiAfsluiten.Enabled = True
        tmiBestand.Enabled = True
        tmiKlasnamen.Enabled = True
        tmiLeerkracht.Enabled = True
        tmiLeerling.Enabled = True
        tmiInloggen.Enabled = True
        tmiUitloggen.Enabled = True
        tmiLokaal.Enabled = True
        tmiNieuweKlasscreening.Enabled = True
        tmiOnderhoud.Enabled = True
        tmiOpenKlasscreening.Enabled = True
        tmiOpties.Enabled = True
        tmiSamenstellenKlassen.Enabled = True
        tmiToevoegenWijzigen.Enabled = True

    End Sub

    Public Sub InitialiseerAlleMenuItems()

        tmiActiefstatus.Enabled = False
        tmiAfsluiten.Enabled = True
        tmiBestand.Enabled = True
        tmiKlasnamen.Enabled = False
        tmiLeerkracht.Enabled = False
        tmiLeerling.Enabled = False
        tmiInloggen.Enabled = True
        tmiUitloggen.Enabled = False
        tmiLokaal.Enabled = False
        tmiNieuweKlasscreening.Enabled = False
        tmiOnderhoud.Enabled = True
        tmiOpenKlasscreening.Enabled = False
        tmiOpties.Enabled = True
        tmiSamenstellenKlassen.Enabled = False
        tmiToevoegenWijzigen.Enabled = True

    End Sub

    Private Sub tmiLeerling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmiLeerling.Click

        ' frmleerlingen laden in de MDI parent (frmMain)
        Dim frmleerlingen As New frmLeerlingen(leerlingenLijst, actiefLijst)
        frmleerlingen.MdiParent = Me
        frmleerlingen.Show()

    End Sub


    Private Sub tmiSamenstellenKlassen_Click(sender As System.Object, e As System.EventArgs) Handles tmiSamenstellenKlassen.Click
        Dim openstaandeLijst = From klas In klassenLijst
        Where klas.StopTijdStip Is Nothing
        Join leerling In leerlingenLijst On klas.Deelnemer Equals leerling.ID
        Select New Verhuis(leerling.ID, klas.Naam, klas.Naam, leerling.VoorNaam, leerling.FamilieNaam)

        Dim frmKlassen As New FrmKlassen(openstaandeLijst.ToList, klasNaamLijst)
        frmKlassen.MdiParent = Me
        frmKlassen.Show()
    End Sub
End Class