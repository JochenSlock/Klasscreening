<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKlasscreening
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
        Me.btnLinq = New System.Windows.Forms.Button()
        Me.btnOLEDBtoList = New System.Windows.Forms.Button()
        Me.btnInsertLeerling = New System.Windows.Forms.Button()
        Me.btnUpdateLeerling = New System.Windows.Forms.Button()
        Me.txtSQLCommand = New System.Windows.Forms.TextBox()
        Me.lblLijstenInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdateLeerkracht = New System.Windows.Forms.Button()
        Me.btnInsertLeerkracht = New System.Windows.Forms.Button()
        Me.btnUpdateKlas = New System.Windows.Forms.Button()
        Me.btnInsertKlas = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnVulTekstvakken = New System.Windows.Forms.Button()
        Me.btnLeegTekstvakken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLinq
        '
        Me.btnLinq.Location = New System.Drawing.Point(12, 160)
        Me.btnLinq.Name = "btnLinq"
        Me.btnLinq.Size = New System.Drawing.Size(156, 54)
        Me.btnLinq.TabIndex = 6
        Me.btnLinq.Text = "LINQ"
        Me.btnLinq.UseVisualStyleBackColor = True
        '
        'btnOLEDBtoList
        '
        Me.btnOLEDBtoList.Location = New System.Drawing.Point(12, 12)
        Me.btnOLEDBtoList.Name = "btnOLEDBtoList"
        Me.btnOLEDBtoList.Size = New System.Drawing.Size(156, 53)
        Me.btnOLEDBtoList.TabIndex = 8
        Me.btnOLEDBtoList.Text = "OLE DB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to LIST"
        Me.btnOLEDBtoList.UseVisualStyleBackColor = True
        '
        'btnInsertLeerling
        '
        Me.btnInsertLeerling.Location = New System.Drawing.Point(12, 255)
        Me.btnInsertLeerling.Name = "btnInsertLeerling"
        Me.btnInsertLeerling.Size = New System.Drawing.Size(156, 54)
        Me.btnInsertLeerling.TabIndex = 9
        Me.btnInsertLeerling.Text = "Insert Leerling -> Access"
        Me.btnInsertLeerling.UseVisualStyleBackColor = True
        '
        'btnUpdateLeerling
        '
        Me.btnUpdateLeerling.Location = New System.Drawing.Point(12, 315)
        Me.btnUpdateLeerling.Name = "btnUpdateLeerling"
        Me.btnUpdateLeerling.Size = New System.Drawing.Size(156, 54)
        Me.btnUpdateLeerling.TabIndex = 11
        Me.btnUpdateLeerling.Text = "Update Leerling -> Access"
        Me.btnUpdateLeerling.UseVisualStyleBackColor = True
        '
        'txtSQLCommand
        '
        Me.txtSQLCommand.Location = New System.Drawing.Point(1112, 12)
        Me.txtSQLCommand.Multiline = True
        Me.txtSQLCommand.Name = "txtSQLCommand"
        Me.txtSQLCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSQLCommand.Size = New System.Drawing.Size(161, 444)
        Me.txtSQLCommand.TabIndex = 14
        '
        'lblLijstenInfo
        '
        Me.lblLijstenInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLijstenInfo.Location = New System.Drawing.Point(225, 56)
        Me.lblLijstenInfo.Name = "lblLijstenInfo"
        Me.lblLijstenInfo.Size = New System.Drawing.Size(225, 115)
        Me.lblLijstenInfo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "<-- testje met LINQ opdracht"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "<-- Importeert lijsten uit Access DB"
        '
        'btnUpdateLeerkracht
        '
        Me.btnUpdateLeerkracht.Location = New System.Drawing.Point(193, 315)
        Me.btnUpdateLeerkracht.Name = "btnUpdateLeerkracht"
        Me.btnUpdateLeerkracht.Size = New System.Drawing.Size(156, 54)
        Me.btnUpdateLeerkracht.TabIndex = 21
        Me.btnUpdateLeerkracht.Text = "Update Leerkracht -> Access"
        Me.btnUpdateLeerkracht.UseVisualStyleBackColor = True
        '
        'btnInsertLeerkracht
        '
        Me.btnInsertLeerkracht.Location = New System.Drawing.Point(193, 255)
        Me.btnInsertLeerkracht.Name = "btnInsertLeerkracht"
        Me.btnInsertLeerkracht.Size = New System.Drawing.Size(156, 54)
        Me.btnInsertLeerkracht.TabIndex = 20
        Me.btnInsertLeerkracht.Text = "Insert Leerkracht -> Access"
        Me.btnInsertLeerkracht.UseVisualStyleBackColor = True
        '
        'btnUpdateKlas
        '
        Me.btnUpdateKlas.Location = New System.Drawing.Point(378, 315)
        Me.btnUpdateKlas.Name = "btnUpdateKlas"
        Me.btnUpdateKlas.Size = New System.Drawing.Size(156, 54)
        Me.btnUpdateKlas.TabIndex = 23
        Me.btnUpdateKlas.Text = "Update Klas -> Access"
        Me.btnUpdateKlas.UseVisualStyleBackColor = True
        '
        'btnInsertKlas
        '
        Me.btnInsertKlas.Location = New System.Drawing.Point(378, 255)
        Me.btnInsertKlas.Name = "btnInsertKlas"
        Me.btnInsertKlas.Size = New System.Drawing.Size(156, 54)
        Me.btnInsertKlas.TabIndex = 22
        Me.btnInsertKlas.Text = "Insert Klas -> Access"
        Me.btnInsertKlas.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(705, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(391, 407)
        Me.ListBox1.TabIndex = 28
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(472, 32)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(163, 82)
        Me.ListBox2.TabIndex = 29
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(472, 151)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(163, 82)
        Me.ListBox3.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(598, 277)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(598, 303)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(49, 20)
        Me.TextBox2.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(598, 333)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(49, 20)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(598, 359)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(49, 20)
        Me.TextBox4.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(598, 385)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(49, 20)
        Me.TextBox5.TabIndex = 35
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(598, 411)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(49, 20)
        Me.TextBox6.TabIndex = 36
        '
        'btnVulTekstvakken
        '
        Me.btnVulTekstvakken.Location = New System.Drawing.Point(33, 400)
        Me.btnVulTekstvakken.Name = "btnVulTekstvakken"
        Me.btnVulTekstvakken.Size = New System.Drawing.Size(94, 46)
        Me.btnVulTekstvakken.TabIndex = 37
        Me.btnVulTekstvakken.Text = "Vul tekstvakken"
        Me.btnVulTekstvakken.UseVisualStyleBackColor = True
        '
        'btnLeegTekstvakken
        '
        Me.btnLeegTekstvakken.Location = New System.Drawing.Point(174, 404)
        Me.btnLeegTekstvakken.Name = "btnLeegTekstvakken"
        Me.btnLeegTekstvakken.Size = New System.Drawing.Size(88, 41)
        Me.btnLeegTekstvakken.TabIndex = 38
        Me.btnLeegTekstvakken.Text = "Leeg Tekstvakken"
        Me.btnLeegTekstvakken.UseVisualStyleBackColor = True
        '
        'FrmKlasscreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 468)
        Me.Controls.Add(Me.btnLeegTekstvakken)
        Me.Controls.Add(Me.btnVulTekstvakken)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnUpdateKlas)
        Me.Controls.Add(Me.btnInsertKlas)
        Me.Controls.Add(Me.btnUpdateLeerkracht)
        Me.Controls.Add(Me.btnInsertLeerkracht)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLijstenInfo)
        Me.Controls.Add(Me.txtSQLCommand)
        Me.Controls.Add(Me.btnUpdateLeerling)
        Me.Controls.Add(Me.btnInsertLeerling)
        Me.Controls.Add(Me.btnOLEDBtoList)
        Me.Controls.Add(Me.btnLinq)
        Me.Name = "FrmKlasscreening"
        Me.Text = "Klasscreening"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLinq As System.Windows.Forms.Button
    Friend WithEvents btnOLEDBtoList As System.Windows.Forms.Button
    Friend WithEvents btnInsertLeerling As System.Windows.Forms.Button
    Friend WithEvents btnUpdateLeerling As System.Windows.Forms.Button
    Friend WithEvents txtSQLCommand As System.Windows.Forms.TextBox
    Friend WithEvents lblLijstenInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateLeerkracht As System.Windows.Forms.Button
    Friend WithEvents btnInsertLeerkracht As System.Windows.Forms.Button
    Friend WithEvents btnUpdateKlas As System.Windows.Forms.Button
    Friend WithEvents btnInsertKlas As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btnVulTekstvakken As System.Windows.Forms.Button
    Friend WithEvents btnLeegTekstvakken As System.Windows.Forms.Button

End Class
