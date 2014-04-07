Imports System.Data.OleDb
Imports Klasscreeningsklassen

Public Class frmLeerlingen

    Private leerlingLijst As List(Of Leerling)
    Private actiefLijst As List(Of Actief)
    Private WithEvents frmleerlingtoevoegen As frmLeerlingToevoegen
    Private WithEvents frmleerlingenwijzigen As frmLeerlingWijzigen

    Public Sub New(leerlingLijst As List(Of Leerling), actieflijst As List(Of Actief))

        InitializeComponent()
        Me.leerlingLijst = leerlingLijst
        Me.actiefLijst = actieflijst

        ComboBox1.Items.AddRange(actieflijst.ToArray)
        ComboBox1.Items.Add("*")
        ComboBox1.SelectedIndex = 0



    End Sub
    Private Sub btnLeerlingToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerlingToevoegen.Click

        frmleerlingtoevoegen = New frmLeerlingToevoegen(actiefLijst)
        frmleerlingtoevoegen.ShowDialog()

    End Sub

    Private Sub btnAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfsluiten.Click

        Me.Close()

    End Sub

    Private Sub btnLeerlingWijzigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerlingWijzigen.Click, dgvLeerlingen.CellDoubleClick

        If dgvLeerlingen.SelectedRows IsNot Nothing Then

            Dim lln As Leerling = dgvLeerlingen.SelectedRows(0).DataBoundItem()

            frmleerlingenwijzigen = New frmLeerlingWijzigen(lln, actiefLijst)
            frmleerlingenwijzigen.ShowDialog()
        End If


    End Sub


    Public Sub ToevoegenLeerling(leerling As Leerling) Handles frmleerlingtoevoegen.leerlingToegevoegd
        leerlingLijst.Add(leerling)
        UpdateLeerlingenTabel()
    End Sub

    Public Sub UpdateLeerlingenTabel() Handles MyBase.Load, frmleerlingenwijzigen.leerlingGewijzigd, ComboBox1.SelectedIndexChanged
        dgvLeerlingen.DataSource = leerlingLijst
        With dgvLeerlingen
            .Columns("ID").DisplayIndex = 0
            .Columns("VoorNaam").DisplayIndex = 1
            .Columns("FamilieNaam").DisplayIndex = 2
            .Columns("GeboorteDatum").DisplayIndex = 3
            .Columns("InschrijvingsDatum").DisplayIndex = 4
            .Columns("OS_ASS").DisplayIndex = 5
            .Columns("OS_ADHD").DisplayIndex = 6
            .Columns("OS_GTS").DisplayIndex = 7
            .Columns("LS_Dyslexie").DisplayIndex = 8
            .Columns("LS_Dysorthografie").DisplayIndex = 9
            .Columns("LS_Dyscalculie").DisplayIndex = 10
            .Columns("LS_Andere").DisplayIndex = 11
            .Columns("Leervoorsprong").DisplayIndex = 12
            .Columns("Pestdader").DisplayIndex = 13
            .Columns("Pestslachtoffer").DisplayIndex = 14
            .Columns("Anderstalig").DisplayIndex = 15
            .Columns("Bisser").DisplayIndex = 16
            .Columns("Actief").DisplayIndex = 17
        End With

        dgvLeerlingen.Refresh()
    End Sub

    Private Sub btnLeerlingVerwijderen_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerlingVerwijderen.Click
        If dgvLeerlingen.SelectedRows IsNot Nothing Then

            Dim result = MessageBox.Show("Ben je zeker dat je de leerling wenst te verwijderen? (inactief is mogelijk)", "Leerling staat op punt verwijderd te worden", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question)


            If result = DialogResult.Yes Then
                Dim lln = leerlingLijst.Where(Function(x) (x.ID = dgvLeerlingen.SelectedCells(0).Value)).First

                Dim deleteFromTblCommand As New OleDbCommand("DELETE FROM TBL_Leerling WHERE ID =" & lln.ID.ToString, GlobalVariables.conn)

                Dim connection As Data.OleDb.OleDbConnection = Klasscreeningsklassen.GlobalVariables.conn
                connection.Open()
                deleteFromTblCommand.Connection = connection
                deleteFromTblCommand.ExecuteNonQuery()
                connection.Close()

                leerlingLijst.Remove(lln)
                UpdateLeerlingenTabel()

            End If
        End If
    End Sub

End Class