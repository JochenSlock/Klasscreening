Imports System.Data.OleDb
Imports Klasscreeningsklassen

Public Class FrmKlasscreening



    'Public leerkrachtenLijst As New List(Of Leerkracht)
    'Public leerlingenLijst As New List(Of Leerling)
    'Public klassenLijst As New List(Of Klas)
    'Public klasNaamLijst As New Dictionary(Of Integer, String)
    'Public klasLokalenLijst As New Dictionary(Of Integer, String)
    'Public actiefLijst As New Dictionary(Of Integer, String)

    'Public conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & "C:\SMDBTool\Database\KlasScreening.accdb" + ";Persist Security Info=False;")


    'Private Sub btnLinq_Click(sender As System.Object, e As System.EventArgs) Handles btnLinq.Click
    '    Dim query = From leerling In leerlingenLijst
    '                Where leerling.ID > 9999
    '                Select leerling

    '    klassenLijst.RemoveAt(4)


    '    Dim query2 = From leerling In leerlingenLijst
    '            Join klas In klassenLijst On leerling.ID Equals klas.Deelnemer
    '            Select leerling.ID, leerling.VoorNaam, leerling.FamilieNaam, klas.Naam




    '    Dim tekst As String = ""

    '    If False Then
    '        For Each temp In query
    '            tekst += temp.ID.ToString + ": " + temp.VoorNaam + " " + temp.FamilieNaam + vbCrLf
    '        Next

    '    ElseIf True Then
    '        For Each temp In query2
    '            ListBox1.Items.Add(temp.ID.ToString + ": " + temp.FamilieNaam + ", " + temp.VoorNaam + " --> " + temp.Naam.ToString)
    '            'tekst += temp.FamilieNaam + ", " + temp.VoorNaam + " --> " + temp.Naam.ToString + vbCrLf
    '        Next
    '    End If
    '    ListBox1.Items.AddRange(query2.ToArray)


    '    Dim info() As System.Reflection.PropertyInfo = leerlingenLijst.Item(0).GetType().GetProperties()

    '    ListBox2.Items.Clear()
    '    ListBox3.Items.Clear()

    '    Dim prop_OS = From leerlingProperties In info
    '                Where leerlingProperties.Name Like "OS*"
    '                Select leerlingProperties.Name

    '    ListBox2.Items.AddRange(prop_OS.ToArray)

    '    Dim prop_LS = _
    '        From leerlingProperties In info
    '        Where leerlingProperties.Name Like "LS*" And Not leerlingProperties.Name Like "LS_Andere"
    '        Select leerlingProperties.Name

    '    ListBox3.Items.AddRange(prop_LS.ToArray)




    '    Dim leerlingLeerkrachtNietGevonden = _
    '        From klasElement In klassenLijst
    '        Select klasElement.Deelnemer
    '        Distinct.Except(
    '        From leerling In leerlingenLijst
    '        Select leerling.ID
    '        Distinct.Union(
    '        From leerkracht In leerkrachtenLijst
    '        Select leerkracht.ID
    '        Distinct))

    '    Dim leerkrachtBoven10000 = _
    '        From leerkracht In leerkrachtenLijst
    '        Where leerkracht.ID >= 10000
    '        Select leerkracht.ID

    '    Dim leerlingOnder10000 = _
    '        From leerling In leerlingenLijst
    '        Where leerling.ID < 10000
    '        Select leerling.ID



    'End Sub
    'Private Sub LaadActief()
    '    Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Actief", conn)
    '    Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
    '    Try
    '        While reader.Read()
    '            actiefLijst.Add(Convert.ToInt32(reader(0)), reader(1))
    '        End While

    '        reader.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van Actieflijst.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try
    'End Sub
    'Private Sub LaadLokalen()
    '    Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Lokalen", conn)
    '    Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
    '    Try
    '        While reader.Read()
    '            klasLokalenLijst.Add(Convert.ToInt32(reader(0)), New Lokaal(Convert.ToInt32(reader(1)), reader(2)))
    '        End While

    '        reader.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van Lokalen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try
    'End Sub
    'Private Sub LaadKlasNamen()
    '    Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Klasnaam", conn)
    '    Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
    '    Try
    '        While reader.Read()
    '            klasNaamLijst.Add(Convert.ToInt32(reader(0)), reader(1))
    '        End While

    '        reader.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van Klasnamen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try
    'End Sub
    'Private Sub LaadLeerlingen()
    '    Dim selectFromTblCommand As New OleDbCommand("SELECT * FROM TBL_Leerling", conn)

    '    Try

    '        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
    '        While reader.Read()
    '            leerlingenLijst.Add(New Leerling _
    '                (Convert.ToInt32(reader(0)), _
    '                reader(1), _
    '                reader(2), _
    '                Convert.ToDateTime(reader(3)), _
    '                Convert.ToDateTime(reader(4))) _
    '            )

    '        End While

    '        reader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van leerlingen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub LaadLeerkrachten()


    '    Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM TBL_Leerkracht", conn)
    '    Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()

    '    Try
    '        While reader.Read()
    '            leerkrachtenLijst.Add(New Leerkracht _
    '                (Convert.ToInt32(reader(0)), _
    '                reader(1), _
    '                reader(2), _
    '                Convert.ToDateTime(reader(3)), _
    '                Convert.ToDateTime(reader(4)), _
    '                Convert.ToBoolean(reader(5)))
    '            )

    '        End While

    '        reader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van Leerkrachten.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub LaadKlassen()
    '    Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM TBL_Klas", conn)
    '    Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
    '    Try
    '        While reader.Read()

    '            klassenLijst.Add(New Klas _
    '                (Convert.ToInt32(reader(0)), _
    '                klasNaamLijst.Item(reader(1)), _
    '                Convert.ToInt32(reader(2)), _
    '                Convert.ToInt32(reader(3)), _
    '                Convert.ToDateTime(reader(4)), _
    '                Convert.ToDateTime(reader(5)))
    '            )

    '        End While

    '        reader.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens laden van Klassen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        selectFromTblCommand.Dispose()
    '    End Try
    'End Sub
    'Private Sub btnOLEDBtoList_Click(sender As System.Object, e As System.EventArgs) Handles btnOLEDBtoList.Click


    '    leerlingenLijst.Clear()
    '    klassenLijst.Clear()
    '    leerkrachtenLijst.Clear()
    '    actiefLijst.Clear()
    '    klasLokalenLijst.Clear()
    '    klasNaamLijst.Clear()

    '    Try
    '        conn.Open()

    '        LaadActief()
    '        LaadKlasNamen()
    '        LaadLokalen()
    '        LaadLeerkrachten()
    '        LaadKlassen()
    '        LaadLeerlingen()


    '        lblLijstenInfo.Text = String.Format("{0} items in de 'list(of Leerling)'," + vbCrLf + _
    '                                        "{1} items in de 'list(of Leerkracht)'," + vbCrLf + _
    '                                        "{2} items in de 'list(of Klas)'," + vbCrLf + _
    '                                        "{3} items in de 'Dictionary Actief'," + vbCrLf + _
    '                                        "{4} items in de 'Dictionary Klasnaam'," + vbCrLf + _
    '                                        "{5} items in de 'Dictionary KlasLokalen'," _
    '                                        , leerlingenLijst.Count, leerkrachtenLijst.Count, klassenLijst.Count, _
    '                                        actiefLijst.Count, klasNaamLijst.Count, klasLokalenLijst.Count)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens selecteren van tabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '    End Try



    'End Sub
    'Private Sub btnInsertLeerling_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertLeerling.Click
    '    Dim myLeerling As Leerling = New Leerling(100010, "Pietje", "Smit", Date.Today, Date.Today)
    '    myLeerling.LS_Andere = "iets anders"
    '    Dim insertCommand As OleDbCommand = Leerling.insertOLEDB(myLeerling)
    '    txtSQLCommand.Text = insertCommand.CommandText
    '    Try
    '        conn.Open()
    '        insertCommand.Connection = conn
    '        insertCommand.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerlingentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        insertCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub btnUpdateLeerling_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateLeerling.Click
    '    btnUpdateLeerling.Text = "Update Leerling -> Access"
    '    Dim myLeerling As Leerling = New Leerling(10009, "Jantje", "de Voorste", Date.Today, Date.Today)
    '    myLeerling.LS_Andere = "nog iets anders"
    '    Dim updateCommand As OleDbCommand = Leerling.updateOLEDB(myLeerling)
    '    txtSQLCommand.Text = updateCommand.CommandText
    '    Try
    '        conn.Open()
    '        updateCommand.Connection = conn
    '        Dim temp As Integer = updateCommand.ExecuteNonQuery()
    '        btnUpdateLeerling.Text = "Update Leerling -> Access: " + temp.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerlingentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        updateCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub btnInsertLeerkracht_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertLeerkracht.Click
    '    Dim myLeerkracht As Leerkracht = New Leerkracht(10007, "Pietje", "Smit", New Date(1983, 3, 28, 10, 20, 0), New Date(1983, 3, 28, 10, 20, 0), 1)
    '    Dim insertCommand As OleDbCommand = Leerkracht.insertOLEDB(myLeerkracht)
    '    txtSQLCommand.Text = insertCommand.CommandText
    '    Try
    '        conn.Open()
    '        insertCommand.Connection = conn
    '        insertCommand.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerkrachtentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        insertCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub btnUpdateLeerkracht_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateLeerkracht.Click
    '    btnUpdateLeerkracht.Text = "Update Leerkracht -> Access"
    '    Dim myLeerkracht As Leerkracht = New Leerkracht(6, "Jantje", "Smit", New Date(1983, 3, 28, 10, 20, 0), New Date(1983, 3, 28, 10, 20, 0), 1)
    '    Dim updateCommand As OleDbCommand = Leerkracht.updateOLEDB(myLeerkracht)
    '    txtSQLCommand.Text = updateCommand.CommandText
    '    Try
    '        conn.Open()
    '        updateCommand.Connection = conn
    '        Dim temp As Integer = updateCommand.ExecuteNonQuery()
    '        btnUpdateLeerkracht.Text = "Update Leerkracht -> Access: " + temp.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar leerkrachtentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        updateCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub btnInsertKlas_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertKlas.Click
    '    Dim myKlas As Klas = New Klas(2, 16, 100002, 2, Date.Today, Date.Today)
    '    Dim insertCommand As OleDbCommand = Klas.insertOLEDB(myKlas)
    '    txtSQLCommand.Text = insertCommand.CommandText
    '    Try
    '        conn.Open()
    '        insertCommand.Connection = conn
    '        insertCommand.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar klassentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        insertCommand.Dispose()
    '    End Try

    'End Sub
    'Private Sub btnUpdateKlas_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateKlas.Click
    '    btnUpdateKlas.Text = "Update Klas -> Access"
    '    Dim myKlas As Klas = New Klas(2, 100, 100002, 2, Date.Today, Date.Today)
    '    Dim updateCommand As OleDbCommand = Klas.updateOLEDB(myKlas)
    '    txtSQLCommand.Text = updateCommand.CommandText
    '    Try
    '        conn.Open()
    '        updateCommand.Connection = conn
    '        Dim temp As Integer = updateCommand.ExecuteNonQuery()
    '        btnUpdateKlas.Text = "Update Klas -> Access: " + temp.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error tijdens schrijven naar klassentabel", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        conn.Close()
    '        updateCommand.Dispose()
    '    End Try
    'End Sub
    'Private Sub btnVulTekstvakken_Click(sender As System.Object, e As System.EventArgs) Handles btnVulTekstvakken.Click
    '    For Each X As Control In Me.Controls
    '        If TypeOf X Is TextBox Then
    '            X.Text = "blablabla"
    '        End If
    '    Next
    'End Sub
    'Private Sub btnLeegTekstvakken_Click(sender As System.Object, e As System.EventArgs) Handles btnLeegTekstvakken.Click
    '    For Each X As Control In Me.Controls
    '        If TypeOf X Is TextBox Then
    '            X.Text = String.Empty
    '        End If
    '    Next
    'End Sub

    Private Sub btnOLEDBtoList_Click(sender As System.Object, e As System.EventArgs) Handles btnOLEDBtoList.Click

    End Sub

    Private Sub btnLinq_Click(sender As System.Object, e As System.EventArgs) Handles btnLinq.Click

    End Sub
End Class
