<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeerlingToevoegenWijzigen
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboLeerlingActief = New System.Windows.Forms.ComboBox()
        Me.dtpLeerlingInschrijvingsdatum = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpLeerlingGeboortedatum = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeerlingNaam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLeerlingVoornaam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLeerlingId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLS_Andere = New System.Windows.Forms.TextBox()
        Me.chb_LS_Andere = New System.Windows.Forms.CheckBox()
        Me.chbLS_Dyscalculie = New System.Windows.Forms.CheckBox()
        Me.chbOS_GTS = New System.Windows.Forms.CheckBox()
        Me.chbLS_Dysorthografie = New System.Windows.Forms.CheckBox()
        Me.chbOS_ADHD = New System.Windows.Forms.CheckBox()
        Me.chbLS_Dyslexie = New System.Windows.Forms.CheckBox()
        Me.chbOS_ASS = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chbPestslachtoffer = New System.Windows.Forms.CheckBox()
        Me.chbPestdader = New System.Windows.Forms.CheckBox()
        Me.chbBisser = New System.Windows.Forms.CheckBox()
        Me.chbAnderstalig = New System.Windows.Forms.CheckBox()
        Me.chbLeervoorsprong = New System.Windows.Forms.CheckBox()
        Me.btnAnnuleren = New System.Windows.Forms.Button()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboLeerlingActief)
        Me.GroupBox1.Controls.Add(Me.dtpLeerlingInschrijvingsdatum)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpLeerlingGeboortedatum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLeerlingNaam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLeerlingVoornaam)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLeerlingId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algemeen"
        '
        'cboLeerlingActief
        '
        Me.cboLeerlingActief.FormattingEnabled = True
        Me.cboLeerlingActief.Location = New System.Drawing.Point(154, 77)
        Me.cboLeerlingActief.Name = "cboLeerlingActief"
        Me.cboLeerlingActief.Size = New System.Drawing.Size(181, 21)
        Me.cboLeerlingActief.TabIndex = 12
        '
        'dtpLeerlingInschrijvingsdatum
        '
        Me.dtpLeerlingInschrijvingsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeerlingInschrijvingsdatum.Location = New System.Drawing.Point(462, 47)
        Me.dtpLeerlingInschrijvingsdatum.Name = "dtpLeerlingInschrijvingsdatum"
        Me.dtpLeerlingInschrijvingsdatum.Size = New System.Drawing.Size(200, 20)
        Me.dtpLeerlingInschrijvingsdatum.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Inschrijvingsdatum:"
        '
        'dtpLeerlingGeboortedatum
        '
        Me.dtpLeerlingGeboortedatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeerlingGeboortedatum.Location = New System.Drawing.Point(462, 19)
        Me.dtpLeerlingGeboortedatum.Name = "dtpLeerlingGeboortedatum"
        Me.dtpLeerlingGeboortedatum.Size = New System.Drawing.Size(200, 20)
        Me.dtpLeerlingGeboortedatum.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Geboortedatum:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Actief:"
        '
        'txtLeerlingNaam
        '
        Me.txtLeerlingNaam.Location = New System.Drawing.Point(154, 50)
        Me.txtLeerlingNaam.Name = "txtLeerlingNaam"
        Me.txtLeerlingNaam.Size = New System.Drawing.Size(181, 20)
        Me.txtLeerlingNaam.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Naam:"
        '
        'txtLeerlingVoornaam
        '
        Me.txtLeerlingVoornaam.Location = New System.Drawing.Point(154, 22)
        Me.txtLeerlingVoornaam.Name = "txtLeerlingVoornaam"
        Me.txtLeerlingVoornaam.Size = New System.Drawing.Size(181, 20)
        Me.txtLeerlingVoornaam.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Voornaam:"
        '
        'txtLeerlingId
        '
        Me.txtLeerlingId.Enabled = False
        Me.txtLeerlingId.Location = New System.Drawing.Point(30, 22)
        Me.txtLeerlingId.Name = "txtLeerlingId"
        Me.txtLeerlingId.Size = New System.Drawing.Size(44, 20)
        Me.txtLeerlingId.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLS_Andere)
        Me.GroupBox2.Controls.Add(Me.chb_LS_Andere)
        Me.GroupBox2.Controls.Add(Me.chbLS_Dyscalculie)
        Me.GroupBox2.Controls.Add(Me.chbOS_GTS)
        Me.GroupBox2.Controls.Add(Me.chbLS_Dysorthografie)
        Me.GroupBox2.Controls.Add(Me.chbOS_ADHD)
        Me.GroupBox2.Controls.Add(Me.chbLS_Dyslexie)
        Me.GroupBox2.Controls.Add(Me.chbOS_ASS)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 156)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Antecedenten"
        '
        'txtLS_Andere
        '
        Me.txtLS_Andere.Location = New System.Drawing.Point(284, 108)
        Me.txtLS_Andere.Name = "txtLS_Andere"
        Me.txtLS_Andere.Size = New System.Drawing.Size(117, 20)
        Me.txtLS_Andere.TabIndex = 6
        '
        'chb_LS_Andere
        '
        Me.chb_LS_Andere.AutoSize = True
        Me.chb_LS_Andere.Location = New System.Drawing.Point(209, 111)
        Me.chb_LS_Andere.Name = "chb_LS_Andere"
        Me.chb_LS_Andere.Size = New System.Drawing.Size(69, 17)
        Me.chb_LS_Andere.TabIndex = 11
        Me.chb_LS_Andere.Text = "Andere..."
        Me.chb_LS_Andere.UseVisualStyleBackColor = True
        '
        'chbLS_Dyscalculie
        '
        Me.chbLS_Dyscalculie.AutoSize = True
        Me.chbLS_Dyscalculie.Location = New System.Drawing.Point(209, 88)
        Me.chbLS_Dyscalculie.Name = "chbLS_Dyscalculie"
        Me.chbLS_Dyscalculie.Size = New System.Drawing.Size(80, 17)
        Me.chbLS_Dyscalculie.TabIndex = 10
        Me.chbLS_Dyscalculie.Text = "Dyscalculie"
        Me.chbLS_Dyscalculie.UseVisualStyleBackColor = True
        '
        'chbOS_GTS
        '
        Me.chbOS_GTS.AutoSize = True
        Me.chbOS_GTS.Location = New System.Drawing.Point(30, 88)
        Me.chbOS_GTS.Name = "chbOS_GTS"
        Me.chbOS_GTS.Size = New System.Drawing.Size(48, 17)
        Me.chbOS_GTS.TabIndex = 6
        Me.chbOS_GTS.Text = "GTS"
        Me.chbOS_GTS.UseVisualStyleBackColor = True
        '
        'chbLS_Dysorthografie
        '
        Me.chbLS_Dysorthografie.AutoSize = True
        Me.chbLS_Dysorthografie.Location = New System.Drawing.Point(209, 65)
        Me.chbLS_Dysorthografie.Name = "chbLS_Dysorthografie"
        Me.chbLS_Dysorthografie.Size = New System.Drawing.Size(94, 17)
        Me.chbLS_Dysorthografie.TabIndex = 9
        Me.chbLS_Dysorthografie.Text = "Dysorthografie"
        Me.chbLS_Dysorthografie.UseVisualStyleBackColor = True
        '
        'chbOS_ADHD
        '
        Me.chbOS_ADHD.AutoSize = True
        Me.chbOS_ADHD.Location = New System.Drawing.Point(30, 65)
        Me.chbOS_ADHD.Name = "chbOS_ADHD"
        Me.chbOS_ADHD.Size = New System.Drawing.Size(57, 17)
        Me.chbOS_ADHD.TabIndex = 5
        Me.chbOS_ADHD.Text = "ADHD"
        Me.chbOS_ADHD.UseVisualStyleBackColor = True
        '
        'chbLS_Dyslexie
        '
        Me.chbLS_Dyslexie.AutoSize = True
        Me.chbLS_Dyslexie.Location = New System.Drawing.Point(209, 42)
        Me.chbLS_Dyslexie.Name = "chbLS_Dyslexie"
        Me.chbLS_Dyslexie.Size = New System.Drawing.Size(65, 17)
        Me.chbLS_Dyslexie.TabIndex = 8
        Me.chbLS_Dyslexie.Text = "Dyslexie"
        Me.chbLS_Dyslexie.UseVisualStyleBackColor = True
        '
        'chbOS_ASS
        '
        Me.chbOS_ASS.AutoSize = True
        Me.chbOS_ASS.Location = New System.Drawing.Point(30, 42)
        Me.chbOS_ASS.Name = "chbOS_ASS"
        Me.chbOS_ASS.Size = New System.Drawing.Size(47, 17)
        Me.chbOS_ASS.TabIndex = 4
        Me.chbOS_ASS.Text = "ASS"
        Me.chbOS_ASS.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(185, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Leerstoornissen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Ontwikkelingsstoornissen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbPestslachtoffer)
        Me.GroupBox3.Controls.Add(Me.chbPestdader)
        Me.GroupBox3.Controls.Add(Me.chbBisser)
        Me.GroupBox3.Controls.Add(Me.chbAnderstalig)
        Me.GroupBox3.Controls.Add(Me.chbLeervoorsprong)
        Me.GroupBox3.Location = New System.Drawing.Point(441, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 156)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Andere gegevens"
        '
        'chbPestslachtoffer
        '
        Me.chbPestslachtoffer.AutoSize = True
        Me.chbPestslachtoffer.Location = New System.Drawing.Point(17, 114)
        Me.chbPestslachtoffer.Name = "chbPestslachtoffer"
        Me.chbPestslachtoffer.Size = New System.Drawing.Size(96, 17)
        Me.chbPestslachtoffer.TabIndex = 17
        Me.chbPestslachtoffer.Text = "Pestslachtoffer"
        Me.chbPestslachtoffer.UseVisualStyleBackColor = True
        '
        'chbPestdader
        '
        Me.chbPestdader.AutoSize = True
        Me.chbPestdader.Location = New System.Drawing.Point(17, 91)
        Me.chbPestdader.Name = "chbPestdader"
        Me.chbPestdader.Size = New System.Drawing.Size(74, 17)
        Me.chbPestdader.TabIndex = 16
        Me.chbPestdader.Text = "Pestdader"
        Me.chbPestdader.UseVisualStyleBackColor = True
        '
        'chbBisser
        '
        Me.chbBisser.AutoSize = True
        Me.chbBisser.Location = New System.Drawing.Point(17, 68)
        Me.chbBisser.Name = "chbBisser"
        Me.chbBisser.Size = New System.Drawing.Size(54, 17)
        Me.chbBisser.TabIndex = 15
        Me.chbBisser.Text = "Bisser"
        Me.chbBisser.UseVisualStyleBackColor = True
        '
        'chbAnderstalig
        '
        Me.chbAnderstalig.AutoSize = True
        Me.chbAnderstalig.Location = New System.Drawing.Point(17, 45)
        Me.chbAnderstalig.Name = "chbAnderstalig"
        Me.chbAnderstalig.Size = New System.Drawing.Size(78, 17)
        Me.chbAnderstalig.TabIndex = 14
        Me.chbAnderstalig.Text = "Anderstalig"
        Me.chbAnderstalig.UseVisualStyleBackColor = True
        '
        'chbLeervoorsprong
        '
        Me.chbLeervoorsprong.AutoSize = True
        Me.chbLeervoorsprong.Location = New System.Drawing.Point(17, 22)
        Me.chbLeervoorsprong.Name = "chbLeervoorsprong"
        Me.chbLeervoorsprong.Size = New System.Drawing.Size(100, 17)
        Me.chbLeervoorsprong.TabIndex = 13
        Me.chbLeervoorsprong.Text = "Leervoorsprong"
        Me.chbLeervoorsprong.UseVisualStyleBackColor = True
        '
        'btnAnnuleren
        '
        Me.btnAnnuleren.Location = New System.Drawing.Point(543, 297)
        Me.btnAnnuleren.Name = "btnAnnuleren"
        Me.btnAnnuleren.Size = New System.Drawing.Size(146, 31)
        Me.btnAnnuleren.TabIndex = 13
        Me.btnAnnuleren.Text = "Annuleren"
        Me.btnAnnuleren.UseVisualStyleBackColor = True
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(391, 297)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(146, 31)
        Me.btnToevoegen.TabIndex = 14
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'FrmLeerlingToevoegenWijzigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 336)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.btnAnnuleren)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLeerlingToevoegenWijzigen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLeerlingToevoegenWijzigen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpLeerlingInschrijvingsdatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpLeerlingGeboortedatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLeerlingNaam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLeerlingVoornaam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLeerlingId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLS_Andere As System.Windows.Forms.TextBox
    Friend WithEvents chb_LS_Andere As System.Windows.Forms.CheckBox
    Friend WithEvents chbLS_Dyscalculie As System.Windows.Forms.CheckBox
    Friend WithEvents chbOS_GTS As System.Windows.Forms.CheckBox
    Friend WithEvents chbLS_Dysorthografie As System.Windows.Forms.CheckBox
    Friend WithEvents chbOS_ADHD As System.Windows.Forms.CheckBox
    Friend WithEvents chbLS_Dyslexie As System.Windows.Forms.CheckBox
    Friend WithEvents chbOS_ASS As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chbPestslachtoffer As System.Windows.Forms.CheckBox
    Friend WithEvents chbPestdader As System.Windows.Forms.CheckBox
    Friend WithEvents chbBisser As System.Windows.Forms.CheckBox
    Friend WithEvents chbAnderstalig As System.Windows.Forms.CheckBox
    Friend WithEvents chbLeervoorsprong As System.Windows.Forms.CheckBox
    Friend WithEvents btnAnnuleren As System.Windows.Forms.Button
    Friend WithEvents btnToevoegen As System.Windows.Forms.Button
    Friend WithEvents cboLeerlingActief As System.Windows.Forms.ComboBox
End Class
