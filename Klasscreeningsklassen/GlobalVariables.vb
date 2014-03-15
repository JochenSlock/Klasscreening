Imports System.Data.OleDb

Public Class GlobalVariables

    Public Shared Property inlogID As Integer = 0
    Public Shared Property inlogNaam As String = ""
    Public Shared Property conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & "C:\SMDBTool\Database\KlasScreening.accdb" + ";Persist Security Info=False;")

End Class
