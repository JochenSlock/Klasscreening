Imports System.Data.OleDb

Public Class DBRoutines
    Public Shared Function LaadActief() As Dictionary(Of Integer, String)
        Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Actief", GlobalVariables.conn)
        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
        Dim actiefDict As New Dictionary(Of Integer, String)
        Try
            While reader.Read()
                actiefDict.Add(Convert.ToInt32(reader(0)), Convert.ToString(reader(1)))
            End While

            reader.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van Actieflijst.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try

        Return actiefDict
    End Function
    Public Shared Function LaadLokalen() As Dictionary(Of Integer, String)
        Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Lokalen", GlobalVariables.conn)
        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
        Dim lokaalDict As New Dictionary(Of Integer, String)
        Try
            While reader.Read()
                lokaalDict.Add(Convert.ToInt32(reader(0)), Convert.ToString(reader(1)))
            End While

            reader.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van Lokalen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try
        Return lokaalDict
    End Function
    Public Shared Function LaadKlasNamen() As Dictionary(Of Integer, String)
        Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM LST_Klasnaam", GlobalVariables.conn)
        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
        Dim klasNaamDict As New Dictionary(Of Integer, String)
        Try
            While reader.Read()
                klasNaamDict.Add(Convert.ToInt32(reader(0)), Convert.ToString(reader(1)))
            End While

            reader.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van Klasnamen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try

        Return klasNaamDict
    End Function
    Public Shared Function LaadLeerlingen(actiefLijst As Dictionary(Of Integer, String)) As List(Of Leerling)
        Dim selectFromTblCommand As New OleDbCommand("SELECT * FROM TBL_Leerling", GlobalVariables.conn)
        Dim leerlingLijst As New List(Of Leerling)
        Try

            Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
            While reader.Read()
                leerlingLijst.Add(New Leerling( _
                    Convert.ToInt32(reader(0)), _
                    Convert.ToString(reader(1)), _
                    Convert.ToString(reader(2)), _
                    Convert.ToDateTime(reader(3)), _
                    Convert.ToDateTime(reader(4)), _
                Convert.ToBoolean(reader(5)), _
                Convert.ToBoolean(reader(6)), _
                Convert.ToBoolean(reader(7)), _
                Convert.ToBoolean(reader(8)), _
                Convert.ToBoolean(reader(9)),
                Convert.ToBoolean(reader(10)), _
                Convert.ToString(reader(11)),
                Convert.ToBoolean(reader(12)), _
                Convert.ToBoolean(reader(13)), _
                Convert.ToBoolean(reader(14)), _
                Convert.ToBoolean(reader(15)), _
                Convert.ToBoolean(reader(16)),
                actiefLijst.Item(Convert.ToInt32(reader(17))) _
                ))
            End While
            'Convert.ToString(reader(11)), _
            reader.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van leerlingen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try
        Return leerlingLijst
    End Function
    Public Shared Function LaadLeerling(actiefLijst As Dictionary(Of Integer, String), ByVal waar As String) As Leerling
        Dim selectFromTblCommand As New OleDbCommand("SELECT * FROM TBL_Leerling " & waar, GlobalVariables.conn)
        Dim leerling As Leerling
        Try

            Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
            reader.Read()
            leerling = New Leerling( _
                Convert.ToInt32(reader(0)), _
                Convert.ToString(reader(1)), _
                Convert.ToString(reader(2)), _
                Convert.ToDateTime(reader(3)), _
                Convert.ToDateTime(reader(4)), _
            Convert.ToBoolean(reader(5)), _
            Convert.ToBoolean(reader(6)), _
            Convert.ToBoolean(reader(7)), _
            Convert.ToBoolean(reader(8)), _
            Convert.ToBoolean(reader(9)),
            Convert.ToBoolean(reader(10)), _
            Convert.ToString(reader(11)),
            Convert.ToBoolean(reader(12)), _
            Convert.ToBoolean(reader(13)), _
            Convert.ToBoolean(reader(14)), _
            Convert.ToBoolean(reader(15)), _
            Convert.ToBoolean(reader(16)),
            actiefLijst.Item(Convert.ToInt32(reader(17))) _
            )
            'Convert.ToString(reader(11)), _
            reader.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van leerlingen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try
        Return leerling
    End Function

    Public Shared Function LaadLeerkrachten() As List(Of Leerkracht)


        Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM TBL_Leerkracht", GlobalVariables.conn)
        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
        Dim leerkrachtLijst As New List(Of Leerkracht)
        Try
            While reader.Read()
                leerkrachtLijst.Add(New Leerkracht( _
                    Convert.ToInt32(reader(0)), _
                    Convert.ToString(reader(1)), _
                    Convert.ToString(reader(2)), _
                    Convert.ToDateTime(reader(3)), _
                    Convert.ToDateTime(reader(4)), _
                    Convert.ToInt32(reader(5)))
                )

            End While

            reader.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Database Error tijdens laden van Leerkrachten.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            selectFromTblCommand.Dispose()
        End Try

        Return leerkrachtLijst
    End Function
    Public Shared Function LaadKlassen() As List(Of Klas)
        Dim selectFromTblCommand = New OleDbCommand("SELECT * FROM TBL_Klas", GlobalVariables.conn)
        Dim reader As OleDbDataReader = selectFromTblCommand.ExecuteReader()
        Dim klasLijst As New List(Of Klas)



            Try
                While reader.Read()


                If reader.IsDBNull(5) Then
                    klasLijst.Add(New Klas( _
                        Convert.ToInt32(reader(0)), _
                        Convert.ToString(reader(1)), _
                        Convert.ToInt32(reader(2)), _
                        Convert.ToInt32(reader(3)), _
                        Convert.ToDateTime(reader(4)), _
                        Nothing))

                Else

                    klasLijst.Add(New Klas( _
                        Convert.ToInt32(reader(0)), _
                        Convert.ToString(reader(1)), _
                        Convert.ToInt32(reader(2)), _
                        Convert.ToInt32(reader(3)), _
                        Convert.ToDateTime(reader(4)), _
                        Convert.ToDateTime(reader(5)))
                    )
                End If
            End While

                reader.Close()

            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Database Error tijdens laden van Klassen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                selectFromTblCommand.Dispose()
            End Try

            Return klasLijst
    End Function
End Class
