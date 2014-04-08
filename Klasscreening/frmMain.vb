Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class frmMain

    Public leerkrachtenLijst As New List(Of Leerkracht)
    Public leerlingenLijst As New List(Of Leerling)
    Public klassenLijst As New List(Of Klas)
    Public klasNaamLijst As New List(Of KlasNaam)
    Public klasLokalenLijst As New List(Of Lokaal)
    Public actiefLijst As New List(Of Actief)
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
        Dim frmKlasscreening As New FrmKlasscreening()
        frmKlasscreening.MdiParent = Me
        frmKlasscreening.Show()
    End Sub

    Public Sub InitialiseerAlleMenuItems()

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
        Select New Verhuis(leerling, klasNaamLijst.Where(Function(x) x.ID = klas.Naam).First)

        Dim frmKlassen As New FrmKlassen(openstaandeLijst.ToList, klasNaamLijst, leerlingenLijst, leerkrachtenLijst)
        frmKlassen.MdiParent = Me
        frmKlassen.Show()
    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NieuwToolStripMenuItem.Click
        Dim frmKlasscreening As New FrmKlasscreening()
        frmKlasscreening.MdiParent = Me
        frmKlasscreening.Show()
    End Sub

    Private Sub LokaalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LokaalToolStripMenuItem.Click

    End Sub
End Class