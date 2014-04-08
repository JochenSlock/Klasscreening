Imports Klasscreeningsklassen

Public Class FrmKlassen

    Private _verhuisLijst As List(Of Verhuis)
    Private _klasNaamLijst As List(Of KlasNaam)
    Private _leerlingenLijst As List(Of Leerling)
    Private _leerkrachtenLijst As List(Of Leerkracht)


    Public Sub New(verhuislijst As List(Of Verhuis), klasNaamLijst As List(Of KlasNaam), ByRef leerlingenlijst As List(Of Leerling), ByRef leerkrachtenlijst As List(Of Leerkracht))
        InitializeComponent()

        Me._verhuisLijst = verhuislijst
        Me._klasNaamLijst = klasNaamLijst
        Me._leerlingenLijst = leerlingenlijst
        Me._leerkrachtenLijst = leerkrachtenlijst

        cboVan.Items.AddRange(klasNaamLijst.ToArray)
        cboNaar.Items.AddRange(klasNaamLijst.ToArray)


        '2 nieuwe klasnamen, nieuwe leerling en afgestudeerd.. bij beide anders handelen
        'afgestudeerd = gn nieuwe record + status leerling aanpassen
        'nieuwe leerling = gn record update enkel nieuwe record

        cboVan.SelectedIndex = 1
        cboNaar.SelectedIndex = 1
    End Sub

    Public Sub updateVanLijst() Handles cboVan.SelectedIndexChanged
        lstVan.Items.Clear()

        Dim van = From verhuisElement In _verhuisLijst
                  Where verhuisElement.NaarKlas.ID = CType(cboVan.SelectedItem, KlasNaam).ID
                  Select verhuisElement

        lstVan.Items.AddRange(van.ToArray)
    End Sub
    Public Sub updateNaarLijst() Handles cboNaar.SelectedIndexChanged
        lstNaar.Items.Clear()

        Dim naar = From verhuisElement In _verhuisLijst
                  Where verhuisElement.NaarKlas.ID = CType(cboNaar.SelectedItem, KlasNaam).ID
                  Select verhuisElement

        lstNaar.Items.AddRange(naar.ToArray)
    End Sub

    Private Sub btnEnkeleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleVanNaar.Click

        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboNaar.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()

    End Sub

    Private Sub btnEnkeleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboVan.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub

    Private Sub btnAlleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleVanNaar.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboNaar.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub

    Private Sub btnAlleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        For Each verhuisElement In verhuisLijst
            verhuisElement.NaarKlas = CType(cboVan.SelectedItem, KlasNaam)
        Next verhuisElement

        updateAlleLijsten()
    End Sub
    Private Sub updateAlleLijsten()
        updateNaarLijst()
        updateVanLijst()
        updateGewijzigdeLijst()
    End Sub
    Private Sub updateGewijzigdeLijst()

        lstGewijzigde.Items.Clear()

        Dim gewijzigde = From verhuisde In _verhuisLijst
                         Where verhuisde.NaarKlas.ID <> verhuisde.VanKlas.ID
                         Select verhuisde.ToStringGewijzigd(_klasNaamLijst)

        lstGewijzigde.Items.AddRange(gewijzigde.ToArray)
    End Sub
End Class