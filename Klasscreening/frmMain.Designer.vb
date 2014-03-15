<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tmiBestand = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiNieuweKlasscreening = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiOpenKlasscreening = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmiInloggen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiUitloggen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmiAfsluiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiOpties = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiToevoegenWijzigen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiLeerling = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiLeerkracht = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiLokaal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmiOnderhoud = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiActiefstatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiKlasnamen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmiSamenstellenKlassen = New System.Windows.Forms.ToolStripMenuItem()
        Me.staStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tslUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMenuStrip.SuspendLayout()
        Me.staStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiBestand, Me.tmiOpties})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(1132, 24)
        Me.mnuMenuStrip.TabIndex = 1
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'tmiBestand
        '
        Me.tmiBestand.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiNieuweKlasscreening, Me.tmiOpenKlasscreening, Me.ToolStripSeparator2, Me.tmiInloggen, Me.tmiUitloggen, Me.ToolStripSeparator3, Me.tmiAfsluiten})
        Me.tmiBestand.Name = "tmiBestand"
        Me.tmiBestand.Size = New System.Drawing.Size(61, 20)
        Me.tmiBestand.Text = "Bestand"
        '
        'tmiNieuweKlasscreening
        '
        Me.tmiNieuweKlasscreening.Name = "tmiNieuweKlasscreening"
        Me.tmiNieuweKlasscreening.Size = New System.Drawing.Size(188, 22)
        Me.tmiNieuweKlasscreening.Text = "Nieuwe klasscreening"
        '
        'tmiOpenKlasscreening
        '
        Me.tmiOpenKlasscreening.Name = "tmiOpenKlasscreening"
        Me.tmiOpenKlasscreening.Size = New System.Drawing.Size(188, 22)
        Me.tmiOpenKlasscreening.Text = "Open klasscreening"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'tmiInloggen
        '
        Me.tmiInloggen.Name = "tmiInloggen"
        Me.tmiInloggen.Size = New System.Drawing.Size(188, 22)
        Me.tmiInloggen.Text = "Inloggen"
        '
        'tmiUitloggen
        '
        Me.tmiUitloggen.Name = "tmiUitloggen"
        Me.tmiUitloggen.Size = New System.Drawing.Size(188, 22)
        Me.tmiUitloggen.Text = "Uitloggen"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'tmiAfsluiten
        '
        Me.tmiAfsluiten.Name = "tmiAfsluiten"
        Me.tmiAfsluiten.Size = New System.Drawing.Size(188, 22)
        Me.tmiAfsluiten.Text = "Afsluiten"
        '
        'tmiOpties
        '
        Me.tmiOpties.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiToevoegenWijzigen, Me.ToolStripSeparator4, Me.tmiSamenstellenKlassen})
        Me.tmiOpties.Name = "tmiOpties"
        Me.tmiOpties.Size = New System.Drawing.Size(53, 20)
        Me.tmiOpties.Text = "Opties"
        '
        'tmiToevoegenWijzigen
        '
        Me.tmiToevoegenWijzigen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiLeerling, Me.tmiLeerkracht, Me.tmiLokaal, Me.ToolStripSeparator5, Me.tmiOnderhoud})
        Me.tmiToevoegenWijzigen.Name = "tmiToevoegenWijzigen"
        Me.tmiToevoegenWijzigen.Size = New System.Drawing.Size(189, 22)
        Me.tmiToevoegenWijzigen.Text = "Toevoegen / Wijzigen"
        '
        'tmiLeerling
        '
        Me.tmiLeerling.Name = "tmiLeerling"
        Me.tmiLeerling.Size = New System.Drawing.Size(152, 22)
        Me.tmiLeerling.Text = "Leerling"
        '
        'tmiLeerkracht
        '
        Me.tmiLeerkracht.Name = "tmiLeerkracht"
        Me.tmiLeerkracht.Size = New System.Drawing.Size(152, 22)
        Me.tmiLeerkracht.Text = "Leerkracht"
        '
        'tmiLokaal
        '
        Me.tmiLokaal.Name = "tmiLokaal"
        Me.tmiLokaal.Size = New System.Drawing.Size(152, 22)
        Me.tmiLokaal.Text = "Lokaal"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'tmiOnderhoud
        '
        Me.tmiOnderhoud.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiActiefstatus, Me.tmiKlasnamen})
        Me.tmiOnderhoud.Name = "tmiOnderhoud"
        Me.tmiOnderhoud.Size = New System.Drawing.Size(152, 22)
        Me.tmiOnderhoud.Text = "Onderhoud"
        '
        'tmiActiefstatus
        '
        Me.tmiActiefstatus.Name = "tmiActiefstatus"
        Me.tmiActiefstatus.Size = New System.Drawing.Size(136, 22)
        Me.tmiActiefstatus.Text = "Actiefstatus"
        '
        'tmiKlasnamen
        '
        Me.tmiKlasnamen.Name = "tmiKlasnamen"
        Me.tmiKlasnamen.Size = New System.Drawing.Size(136, 22)
        Me.tmiKlasnamen.Text = "Klasnamen"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(186, 6)
        '
        'tmiSamenstellenKlassen
        '
        Me.tmiSamenstellenKlassen.Name = "tmiSamenstellenKlassen"
        Me.tmiSamenstellenKlassen.Size = New System.Drawing.Size(189, 22)
        Me.tmiSamenstellenKlassen.Text = "Samenstellen klassen"
        '
        'staStatusStrip
        '
        Me.staStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslUserName})
        Me.staStatusStrip.Location = New System.Drawing.Point(0, 719)
        Me.staStatusStrip.Name = "staStatusStrip"
        Me.staStatusStrip.Size = New System.Drawing.Size(1132, 22)
        Me.staStatusStrip.TabIndex = 2
        Me.staStatusStrip.Text = "StatusStrip1"
        '
        'tslUserName
        '
        Me.tslUserName.Name = "tslUserName"
        Me.tslUserName.Size = New System.Drawing.Size(74, 17)
        Me.tslUserName.Text = "tslUserName"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 741)
        Me.Controls.Add(Me.staStatusStrip)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Klasscreeningstool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.staStatusStrip.ResumeLayout(False)
        Me.staStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents staStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tmiBestand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiInloggen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiAfsluiten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiNieuweKlasscreening As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiOpenKlasscreening As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmiOpties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiToevoegenWijzigen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiLeerling As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiLeerkracht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiLokaal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmiOnderhoud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiActiefstatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiKlasnamen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmiSamenstellenKlassen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiUitloggen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslUserName As System.Windows.Forms.ToolStripStatusLabel
End Class
