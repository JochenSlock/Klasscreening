Imports Klasscreeningsklassen
Imports System.Data.OleDb

Public Class frmLeerlingToevoegen
    Inherits FrmLeerlingToevoegenWijzigen

    Private _actiefLijst As List(Of Actief)
    Private _leerlingenLijst As List(Of Leerling)

    Public Delegate Sub ToevoegenLeerling(leerling As Leerling)
    Public Event leerlingToegevoegd As ToevoegenLeerling

    'Public Sub New(leerlingenLijst As List(Of Leerling), actieflijst As Dictionary(Of Integer, String))
    Public Sub New(actieflijst As List(Of Actief))

        InitializeComponent()
        Me._actiefLijst = actieflijst
        'Me._leerlingenLijst = leerlingenLijst

        cboLeerlingActief.Items.AddRange(actieflijst.ToArray)
        Me.Text = "Toevoegen van een nieuwe leerling"
    End Sub



    Public Overrides Sub btnToevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If txtLeerlingNaam.Text = "" OrElse txtLeerlingVoornaam.Text = "" Then Exit Sub

        ' De 0 die voor ID staat in deze constructor is een tijdelijke waarde
        ' de definitieve waarde wordt (na wegschrijven), teruggelezen uit de database
        Dim leerling As New Leerling(0, _
                                     txtLeerlingVoornaam.Text, _
                                     txtLeerlingNaam.Text, _
        dtpLeerlingGeboortedatum.Value.Date, _
        dtpLeerlingInschrijvingsdatum.Value.Date, _
        Convert.ToBoolean(chbOS_ASS.CheckState), _
        Convert.ToBoolean(chbOS_ADHD.CheckState), _
        Convert.ToBoolean(chbOS_GTS.CheckState), _
        Convert.ToBoolean(chbLS_Dyslexie.CheckState), _
        Convert.ToBoolean(chbLS_Dysorthografie.CheckState), _
        Convert.ToBoolean(chbLS_Dyscalculie.CheckState), _
        txtLS_Andere.Text, _
        Convert.ToBoolean(chbLeervoorsprong.CheckState), _
        Convert.ToBoolean(chbPestdader.CheckState), _
        Convert.ToBoolean(chbPestslachtoffer.CheckState), _
        Convert.ToBoolean(chbAnderstalig.CheckState), _
        Convert.ToBoolean(chbBisser.CheckState), _
        cboLeerlingActief.Text)


        Dim zoektermen As String = String.Format("WHERE Voornaam LIKE '{0}' and Familienaam like '{1}'", leerling.VoorNaam, leerling.FamilieNaam)

        Dim connection As Data.OleDb.OleDbConnection = Klasscreeningsklassen.GlobalVariables.conn
        connection.Open()
        Dim updateCommand As Data.OleDb.OleDbCommand = Klasscreeningsklassen.Leerling.insertOLEDB(leerling, _actiefLijst)
        updateCommand.Connection = connection
        updateCommand.ExecuteNonQuery()


        RaiseEvent leerlingToegevoegd(DBRoutines.LaadLeerling(_actiefLijst, zoektermen))
        '_leerlingenLijst.Add(DBRoutines.LaadLeerling(_actiefLijst, zoektermen))


        connection.Close()





        Me.Close()


        'Dim insertleerling As New OleDbCommand
        'insertleerling = leerling.insertOLEDB(leerling, _actiefLijst)

        'Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & "C:\SMDBTool\Database\KlasScreening.accdb" + ";Persist Security Info=False;")

        'Try
        '    conn.Open()
        '    insertleerling.Connection = conn
        '    insertleerling.ExecuteNonQuery()


        'Catch ex As Exception

        '    MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerlingentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Finally

        '    conn.Close()
        '    insertleerling.Dispose()

        'End Try


    End Sub

    Private Sub frmLeerlingToevoegen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboLeerlingActief.Text = "Actief"

    End Sub

    Public Overrides Sub btnAnnuleren_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnAnnuleren_Click_1(sender As System.Object, e As System.EventArgs)

        Me.Close()
    End Sub

End Class