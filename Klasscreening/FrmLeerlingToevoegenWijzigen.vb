Public Class FrmLeerlingToevoegenWijzigen

    
    Public Overridable Sub btnAnnuleren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuleren.Click

        Me.Close()

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overridable Sub btnToevoegen_Click(sender As System.Object, e As System.EventArgs) Handles btnToevoegen.Click

    End Sub
End Class