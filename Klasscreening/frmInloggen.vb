Imports Klasscreeningsklassen

Public Class frmInloggen

   


    Private Sub btnInloggen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInloggen.Click

        ' Inloggen met admin user
        If cboNaam.SelectedItem = "Admin" Then

            GlobalVariables.inlogID = 1111
            GlobalVariables.inlogNaam = cboNaam.SelectedItem

        End If



        Me.Close()


    End Sub

    Private Sub frmInloggen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboNaam.Items.Add("Admin")


    End Sub
End Class