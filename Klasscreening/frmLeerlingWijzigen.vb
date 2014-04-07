Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class frmLeerlingWijzigen

    Inherits FrmLeerlingToevoegenWijzigen
    Private _leerling As Leerling
    Private _actieflijst As List(Of Actief)

    Public Delegate Sub WijzigenLeerling()
    Public Event leerlingGewijzigd As WijzigenLeerling

    Public Sub New(ByRef leerling As Leerling, actieflijst As List(Of Actief))

        InitializeComponent()
        Me._leerling = leerling
        Me._actieflijst = actieflijst

        cboLeerlingActief.Items.AddRange(actieflijst.ToArray)


        With _leerling
            Me.Text = "Wijzigen van een bestaande leerling"
            Me.btnToevoegen.Text = "Wijzigen"

            Me.txtLeerlingId.Text = .ID.ToString

            Me.cboLeerlingActief.SelectedItem = .Actief
            Me.txtLeerlingNaam.Text = .FamilieNaam
            Me.txtLeerlingVoornaam.Text = .VoorNaam
            Me.txtLS_Andere.Text = .LS_Andere

            Me.chbAnderstalig.CheckState = -1 * .Anderstalig
            Me.chbBisser.CheckState = -1 * .Bisser
            Me.chbLeervoorsprong.CheckState = -1 * .Leervoorsprong
            Me.chbLS_Dyscalculie.CheckState = -1 * .LS_Dyscalculie
            Me.chbLS_Dyslexie.CheckState = -1 * .LS_Dyslexie
            Me.chbLS_Dysorthografie.CheckState = -1 * .LS_Dysorthografie
            Me.chbOS_ADHD.CheckState = -1 * .OS_ADHD
            Me.chbOS_ASS.CheckState = -1 * .OS_ASS
            Me.chbOS_GTS.CheckState = -1 * .OS_GTS
            Me.chbPestdader.CheckState = -1 * .Pestdader
            Me.chbPestslachtoffer.CheckState = -1 * .Pestslachtoffer
            Me.dtpLeerlingGeboortedatum.Value = .GeboorteDatum
            Me.dtpLeerlingInschrijvingsdatum.Value = .InschrijvingsDatum
        End With



    End Sub

    Public Overrides Sub btnToevoegen_Click(sender As System.Object, e As System.EventArgs)
        With _leerling

            '.FamilieNaam = Me.txtLeerlingNaam.Text
            '.VoorNaam = Me.txtLeerlingVoornaam.Text
            .Actief = Me.cboLeerlingActief.SelectedItem
            .LS_Andere = Me.txtLS_Andere.Text

            .Anderstalig = Me.chbAnderstalig.CheckState
            .Bisser = Me.chbBisser.CheckState
            .Leervoorsprong = Me.chbLeervoorsprong.CheckState
            .LS_Dyscalculie = Me.chbLS_Dyscalculie.CheckState
            .LS_Dyslexie = Me.chbLS_Dyslexie.CheckState
            .LS_Dysorthografie = Me.chbLS_Dysorthografie.CheckState
            .OS_ADHD = Me.chbOS_ADHD.CheckState
            .OS_ASS = Me.chbOS_ASS.CheckState
            .OS_GTS = Me.chbOS_GTS.CheckState
            .Pestdader = Me.chbPestdader.CheckState
            .Pestslachtoffer = Me.chbPestslachtoffer.CheckState
            .GeboorteDatum = Me.dtpLeerlingGeboortedatum.Value
            .InschrijvingsDatum = Me.dtpLeerlingInschrijvingsdatum.Value
        End With



        Dim connection As OleDbConnection = GlobalVariables.conn
        connection.Open()
        Dim updateCommand As OleDbCommand = Leerling.updateOLEDB(_leerling, _actieflijst)
        updateCommand.Connection = connection
        updateCommand.ExecuteNonQuery()
        connection.Close()

        RaiseEvent leerlingGewijzigd()
        Me.Close()

    End Sub

    Public Overrides Sub btnAnnuleren_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
End Class