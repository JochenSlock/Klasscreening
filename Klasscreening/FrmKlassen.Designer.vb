<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKlassen
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
        Me.lstVan = New System.Windows.Forms.ListBox()
        Me.lstNaar = New System.Windows.Forms.ListBox()
        Me.btnEnkeleVanNaar = New System.Windows.Forms.Button()
        Me.btnAlleVanNaar = New System.Windows.Forms.Button()
        Me.btnEnkeleNaarVan = New System.Windows.Forms.Button()
        Me.btnAlleNaarVan = New System.Windows.Forms.Button()
        Me.cboVan = New System.Windows.Forms.ComboBox()
        Me.cboNaar = New System.Windows.Forms.ComboBox()
        Me.btnBewaar = New System.Windows.Forms.Button()
        Me.btnVerwerp = New System.Windows.Forms.Button()
        Me.lstGewijzigde = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstVan
        '
        Me.lstVan.FormattingEnabled = True
        Me.lstVan.Location = New System.Drawing.Point(12, 77)
        Me.lstVan.Name = "lstVan"
        Me.lstVan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstVan.Size = New System.Drawing.Size(285, 563)
        Me.lstVan.TabIndex = 0
        '
        'lstNaar
        '
        Me.lstNaar.FormattingEnabled = True
        Me.lstNaar.Location = New System.Drawing.Point(428, 77)
        Me.lstNaar.Name = "lstNaar"
        Me.lstNaar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstNaar.Size = New System.Drawing.Size(285, 563)
        Me.lstNaar.TabIndex = 1
        '
        'btnEnkeleVanNaar
        '
        Me.btnEnkeleVanNaar.Location = New System.Drawing.Point(331, 156)
        Me.btnEnkeleVanNaar.Name = "btnEnkeleVanNaar"
        Me.btnEnkeleVanNaar.Size = New System.Drawing.Size(57, 55)
        Me.btnEnkeleVanNaar.TabIndex = 2
        Me.btnEnkeleVanNaar.Text = ">"
        Me.btnEnkeleVanNaar.UseVisualStyleBackColor = True
        '
        'btnAlleVanNaar
        '
        Me.btnAlleVanNaar.Location = New System.Drawing.Point(331, 217)
        Me.btnAlleVanNaar.Name = "btnAlleVanNaar"
        Me.btnAlleVanNaar.Size = New System.Drawing.Size(57, 55)
        Me.btnAlleVanNaar.TabIndex = 3
        Me.btnAlleVanNaar.Text = ">>"
        Me.btnAlleVanNaar.UseVisualStyleBackColor = True
        '
        'btnEnkeleNaarVan
        '
        Me.btnEnkeleNaarVan.Location = New System.Drawing.Point(331, 427)
        Me.btnEnkeleNaarVan.Name = "btnEnkeleNaarVan"
        Me.btnEnkeleNaarVan.Size = New System.Drawing.Size(57, 55)
        Me.btnEnkeleNaarVan.TabIndex = 4
        Me.btnEnkeleNaarVan.Text = "<"
        Me.btnEnkeleNaarVan.UseVisualStyleBackColor = True
        '
        'btnAlleNaarVan
        '
        Me.btnAlleNaarVan.Location = New System.Drawing.Point(331, 488)
        Me.btnAlleNaarVan.Name = "btnAlleNaarVan"
        Me.btnAlleNaarVan.Size = New System.Drawing.Size(57, 55)
        Me.btnAlleNaarVan.TabIndex = 5
        Me.btnAlleNaarVan.Text = "<<"
        Me.btnAlleNaarVan.UseVisualStyleBackColor = True
        '
        'cboVan
        '
        Me.cboVan.FormattingEnabled = True
        Me.cboVan.Location = New System.Drawing.Point(45, 26)
        Me.cboVan.Name = "cboVan"
        Me.cboVan.Size = New System.Drawing.Size(215, 21)
        Me.cboVan.TabIndex = 6
        '
        'cboNaar
        '
        Me.cboNaar.FormattingEnabled = True
        Me.cboNaar.Location = New System.Drawing.Point(457, 26)
        Me.cboNaar.Name = "cboNaar"
        Me.cboNaar.Size = New System.Drawing.Size(215, 21)
        Me.cboNaar.TabIndex = 7
        '
        'btnBewaar
        '
        Me.btnBewaar.Location = New System.Drawing.Point(787, 668)
        Me.btnBewaar.Name = "btnBewaar"
        Me.btnBewaar.Size = New System.Drawing.Size(236, 55)
        Me.btnBewaar.TabIndex = 8
        Me.btnBewaar.Text = "Wijzigingen bewaren"
        Me.btnBewaar.UseVisualStyleBackColor = True
        '
        'btnVerwerp
        '
        Me.btnVerwerp.Location = New System.Drawing.Point(1041, 668)
        Me.btnVerwerp.Name = "btnVerwerp"
        Me.btnVerwerp.Size = New System.Drawing.Size(236, 55)
        Me.btnVerwerp.TabIndex = 9
        Me.btnVerwerp.Text = "Wijzigingen verwerpen"
        Me.btnVerwerp.UseVisualStyleBackColor = True
        '
        'lstGewijzigde
        '
        Me.lstGewijzigde.FormattingEnabled = True
        Me.lstGewijzigde.Location = New System.Drawing.Point(852, 77)
        Me.lstGewijzigde.Name = "lstGewijzigde"
        Me.lstGewijzigde.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstGewijzigde.Size = New System.Drawing.Size(285, 563)
        Me.lstGewijzigde.TabIndex = 10
        '
        'FrmKlassen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 735)
        Me.Controls.Add(Me.lstGewijzigde)
        Me.Controls.Add(Me.btnVerwerp)
        Me.Controls.Add(Me.btnBewaar)
        Me.Controls.Add(Me.cboNaar)
        Me.Controls.Add(Me.cboVan)
        Me.Controls.Add(Me.btnAlleNaarVan)
        Me.Controls.Add(Me.btnEnkeleNaarVan)
        Me.Controls.Add(Me.btnAlleVanNaar)
        Me.Controls.Add(Me.btnEnkeleVanNaar)
        Me.Controls.Add(Me.lstNaar)
        Me.Controls.Add(Me.lstVan)
        Me.Name = "FrmKlassen"
        Me.Text = "Klassen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstVan As System.Windows.Forms.ListBox
    Friend WithEvents lstNaar As System.Windows.Forms.ListBox
    Friend WithEvents btnEnkeleVanNaar As System.Windows.Forms.Button
    Friend WithEvents btnAlleVanNaar As System.Windows.Forms.Button
    Friend WithEvents btnEnkeleNaarVan As System.Windows.Forms.Button
    Friend WithEvents btnAlleNaarVan As System.Windows.Forms.Button
    Friend WithEvents cboVan As System.Windows.Forms.ComboBox
    Friend WithEvents cboNaar As System.Windows.Forms.ComboBox
    Friend WithEvents btnBewaar As System.Windows.Forms.Button
    Friend WithEvents btnVerwerp As System.Windows.Forms.Button
    Friend WithEvents lstGewijzigde As System.Windows.Forms.ListBox
End Class
