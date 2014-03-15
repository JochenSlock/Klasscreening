Imports System.Data.OleDb
Imports Klasscreeningsklassen

Public Class frmLeerlingen

    Private leerlingLijst As List(Of Leerling)
    Private actiefLijst As Dictionary(Of Integer, String)
    Private WithEvents frmleerlingtoevoegen As frmLeerlingToevoegen
    Private WithEvents frmleerlingenwijzigen As frmLeerlingWijzigen

    Public Sub New(leerlingLijst As List(Of Leerling), actieflijst As Dictionary(Of Integer, String))

        InitializeComponent()
        Me.leerlingLijst = leerlingLijst
        Me.actiefLijst = actieflijst

        ComboBox1.Items.AddRange(actieflijst.Values.ToArray)
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

            Dim lln = leerlingLijst.Where(Function(x) (x.ID = dgvLeerlingen.SelectedCells(0).Value)).ToArray
            'Where(ll.ID = dgvLeerlingen.SelectedCells(0).Value)
            'Select CType(ll, Leerling)

            frmleerlingenwijzigen = New frmLeerlingWijzigen(lln(0), actiefLijst)
            frmleerlingenwijzigen.ShowDialog()
        End If


    End Sub


    Public Sub ToevoegenLeerling(leerling As Leerling) Handles frmleerlingtoevoegen.leerlingToegevoegd
        leerlingLijst.Add(leerling)
        UpdateLeerlingenTabel()
    End Sub

    Public Sub UpdateLeerlingenTabel() Handles MyBase.Load, frmleerlingenwijzigen.leerlingGewijzigd, ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnLeerlingVerwijderen_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerlingVerwijderen.Click
        If dgvLeerlingen.SelectedRows IsNot Nothing Then

            Dim result = MessageBox.Show("Ben je zeker dat je de leerling wenst te verwijderen? (inactief is mogelijk)", "Leerling staat op punt verwijderd te worden", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question)


            If result = DialogResult.Yes Then
                Dim lln = leerlingLijst.Where(Function(x) (x.ID = dgvLeerlingen.SelectedCells(0).Value)).ToArray.Distinct

                Dim deleteFromTblCommand As New OleDbCommand("DELETE FROM TBL_Leerling WHERE ID =" & lln(0).ID.ToString, GlobalVariables.conn)

                Dim connection As Data.OleDb.OleDbConnection = Klasscreeningsklassen.GlobalVariables.conn
                connection.Open()
                deleteFromTblCommand.Connection = connection
                deleteFromTblCommand.ExecuteNonQuery()
                connection.Close()

                leerlingLijst.Remove(lln(0))
                UpdateLeerlingenTabel()

            End If
        End If
    End Sub

End Class