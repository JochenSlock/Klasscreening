Imports Klasscreeningsklassen

Public Class FrmKlassen

    Private _verhuisLijst As List(Of Verhuis)
    Private _klasNaamLijst As Dictionary(Of Integer, String)


    Public Sub New(verhuislijst As List(Of Verhuis), klasNaamLijst As Dictionary(Of Integer, String))
        InitializeComponent()

        Me._verhuisLijst = verhuislijst
        Me._klasNaamLijst = klasNaamLijst

        cboVan.Items.AddRange(klasNaamLijst.Values.ToArray)
        cboNaar.Items.AddRange(klasNaamLijst.Values.ToArray)

        cboVan.SelectedIndex = 1
        cboNaar.SelectedIndex = 1
    End Sub

    Public Sub updateVanLijst() Handles cboVan.SelectedIndexChanged
        lstVan.Items.Clear()
        Dim van = From verhuisElement In _verhuisLijst
                  Where verhuisElement.NaarKlas = cboVan.SelectedItem
                  Select verhuisElement

        lstVan.Items.AddRange(van.ToArray)
    End Sub
    Public Sub updateNaarLijst() Handles cboNaar.SelectedIndexChanged
        lstNaar.Items.Clear()
        Dim naar = From verhuisElement In _verhuisLijst
          Where verhuisElement.NaarKlas = cboNaar.SelectedItem
          Select verhuisElement

        lstNaar.Items.AddRange(naar.ToArray)
    End Sub

    Private Sub btnEnkeleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleVanNaar.Click

        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        Dim elementen = From verhuisElement In _verhuisLijst
                    Where verhuisLijst.Contains(verhuisElement)
                    Select verhuisElement

        For Each verhuisElement In elementen
            verhuisElement.NaarKlas = cboNaar.SelectedItem
        Next verhuisElement

 updateAlleLijsten
    End Sub

    Private Sub btnEnkeleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnEnkeleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.SelectedItems
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        Dim elementen = From verhuisElement In _verhuisLijst
                    Where verhuisLijst.Contains(verhuisElement)
                    Select verhuisElement

        For Each verhuisElement In elementen
            verhuisElement.NaarKlas = cboVan.SelectedItem
        Next verhuisElement

 updateAlleLijsten
    End Sub

    Private Sub btnAlleVanNaar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleVanNaar.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstVan.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        Dim elementen = From verhuisElement In _verhuisLijst
                    Where verhuisLijst.Contains(verhuisElement)
                    Select verhuisElement

        For Each verhuisElement In elementen
            verhuisElement.NaarKlas = cboNaar.SelectedItem
        Next verhuisElement

        updateAlleLijsten()
    End Sub

    Private Sub btnAlleNaarVan_Click(sender As System.Object, e As System.EventArgs) Handles btnAlleNaarVan.Click
        Dim verhuisLijst As New List(Of Verhuis)

        For Each item In lstNaar.Items
            verhuisLijst.Add(CType(item, Verhuis))
        Next

        Dim elementen = From verhuisElement In _verhuisLijst
                    Where verhuisLijst.Contains(verhuisElement)
                    Select verhuisElement

        For Each verhuisElement In elementen
            verhuisElement.NaarKlas = cboVan.SelectedItem
        Next verhuisElement

updateAlleLijsten
    End Sub
    Private Sub updateAlleLijsten()
        updateNaarLijst()
        updateVanLijst()
        updateGewijzigdeLijst()
    End Sub
    Private Sub updateGewijzigdeLijst()

        lstGewijzigde.Items.Clear()
        Dim gewijzigde = From lln In _verhuisLijst
                         Where lln.VanKlas <> lln.NaarKlas
                         Select lln.ToString2

        lstGewijzigde.Items.AddRange(gewijzigde.ToArray)
    End Sub
End Class