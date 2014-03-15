<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInloggen
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
        Me.lblIkBenEen = New System.Windows.Forms.Label()
        Me.rbnLeerkracht = New System.Windows.Forms.RadioButton()
        Me.rbnLeerling = New System.Windows.Forms.RadioButton()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.cboNaam = New System.Windows.Forms.ComboBox()
        Me.btnInloggen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIkBenEen
        '
        Me.lblIkBenEen.AutoSize = True
        Me.lblIkBenEen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIkBenEen.Location = New System.Drawing.Point(12, 22)
        Me.lblIkBenEen.Name = "lblIkBenEen"
        Me.lblIkBenEen.Size = New System.Drawing.Size(96, 20)
        Me.lblIkBenEen.TabIndex = 0
        Me.lblIkBenEen.Text = "Ik ben een..."
        '
        'rbnLeerkracht
        '
        Me.rbnLeerkracht.AutoSize = True
        Me.rbnLeerkracht.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnLeerkracht.Location = New System.Drawing.Point(125, 20)
        Me.rbnLeerkracht.Name = "rbnLeerkracht"
        Me.rbnLeerkracht.Size = New System.Drawing.Size(103, 24)
        Me.rbnLeerkracht.TabIndex = 1
        Me.rbnLeerkracht.TabStop = True
        Me.rbnLeerkracht.Text = "Leerkracht"
        Me.rbnLeerkracht.UseVisualStyleBackColor = True
        '
        'rbnLeerling
        '
        Me.rbnLeerling.AutoSize = True
        Me.rbnLeerling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnLeerling.Location = New System.Drawing.Point(234, 20)
        Me.rbnLeerling.Name = "rbnLeerling"
        Me.rbnLeerling.Size = New System.Drawing.Size(83, 24)
        Me.rbnLeerling.TabIndex = 2
        Me.rbnLeerling.TabStop = True
        Me.rbnLeerling.Text = "Leerling"
        Me.rbnLeerling.UseVisualStyleBackColor = True
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.Location = New System.Drawing.Point(12, 63)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(55, 20)
        Me.lblNaam.TabIndex = 3
        Me.lblNaam.Text = "Naam:"
        '
        'cboNaam
        '
        Me.cboNaam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNaam.FormattingEnabled = True
        Me.cboNaam.Location = New System.Drawing.Point(73, 60)
        Me.cboNaam.Name = "cboNaam"
        Me.cboNaam.Size = New System.Drawing.Size(244, 28)
        Me.cboNaam.TabIndex = 4
        '
        'btnInloggen
        '
        Me.btnInloggen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInloggen.Location = New System.Drawing.Point(12, 109)
        Me.btnInloggen.Name = "btnInloggen"
        Me.btnInloggen.Size = New System.Drawing.Size(305, 33)
        Me.btnInloggen.TabIndex = 5
        Me.btnInloggen.Text = "Inloggen"
        Me.btnInloggen.UseVisualStyleBackColor = True
        '
        'frmInloggen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 159)
        Me.Controls.Add(Me.btnInloggen)
        Me.Controls.Add(Me.cboNaam)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.rbnLeerling)
        Me.Controls.Add(Me.rbnLeerkracht)
        Me.Controls.Add(Me.lblIkBenEen)
        Me.Name = "frmInloggen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Klasscreeningstool: Inloggen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIkBenEen As System.Windows.Forms.Label
    Friend WithEvents rbnLeerkracht As System.Windows.Forms.RadioButton
    Friend WithEvents rbnLeerling As System.Windows.Forms.RadioButton
    Friend WithEvents lblNaam As System.Windows.Forms.Label
    Friend WithEvents cboNaam As System.Windows.Forms.ComboBox
    Friend WithEvents btnInloggen As System.Windows.Forms.Button
End Class
