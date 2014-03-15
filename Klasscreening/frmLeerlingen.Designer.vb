<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeerlingen
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvLeerlingen = New System.Windows.Forms.DataGridView()
        Me.btnLeerlingToevoegen = New System.Windows.Forms.Button()
        Me.btnLeerlingWijzigen = New System.Windows.Forms.Button()
        Me.btnLeerlingVerwijderen = New System.Windows.Forms.Button()
        Me.btnAfsluiten = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvLeerlingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLeerlingen
        '
        Me.dgvLeerlingen.AllowUserToAddRows = False
        Me.dgvLeerlingen.AllowUserToDeleteRows = False
        Me.dgvLeerlingen.AllowUserToOrderColumns = True
        Me.dgvLeerlingen.AllowUserToResizeColumns = False
        Me.dgvLeerlingen.AllowUserToResizeRows = False
        Me.dgvLeerlingen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLeerlingen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLeerlingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeerlingen.Location = New System.Drawing.Point(12, 190)
        Me.dgvLeerlingen.MultiSelect = False
        Me.dgvLeerlingen.Name = "dgvLeerlingen"
        Me.dgvLeerlingen.ReadOnly = True
        Me.dgvLeerlingen.RowHeadersVisible = False
        Me.dgvLeerlingen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvLeerlingen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeerlingen.Size = New System.Drawing.Size(1139, 355)
        Me.dgvLeerlingen.TabIndex = 0
        '
        'btnLeerlingToevoegen
        '
        Me.btnLeerlingToevoegen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLeerlingToevoegen.Location = New System.Drawing.Point(12, 551)
        Me.btnLeerlingToevoegen.Name = "btnLeerlingToevoegen"
        Me.btnLeerlingToevoegen.Size = New System.Drawing.Size(154, 38)
        Me.btnLeerlingToevoegen.TabIndex = 5
        Me.btnLeerlingToevoegen.Text = "Toevoegen"
        Me.btnLeerlingToevoegen.UseVisualStyleBackColor = True
        '
        'btnLeerlingWijzigen
        '
        Me.btnLeerlingWijzigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLeerlingWijzigen.Location = New System.Drawing.Point(172, 551)
        Me.btnLeerlingWijzigen.Name = "btnLeerlingWijzigen"
        Me.btnLeerlingWijzigen.Size = New System.Drawing.Size(154, 38)
        Me.btnLeerlingWijzigen.TabIndex = 6
        Me.btnLeerlingWijzigen.Text = "Wijzigen"
        Me.btnLeerlingWijzigen.UseVisualStyleBackColor = True
        '
        'btnLeerlingVerwijderen
        '
        Me.btnLeerlingVerwijderen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLeerlingVerwijderen.Location = New System.Drawing.Point(332, 551)
        Me.btnLeerlingVerwijderen.Name = "btnLeerlingVerwijderen"
        Me.btnLeerlingVerwijderen.Size = New System.Drawing.Size(154, 38)
        Me.btnLeerlingVerwijderen.TabIndex = 7
        Me.btnLeerlingVerwijderen.Text = "Verwijderen"
        Me.btnLeerlingVerwijderen.UseVisualStyleBackColor = True
        '
        'btnAfsluiten
        '
        Me.btnAfsluiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAfsluiten.Location = New System.Drawing.Point(997, 551)
        Me.btnAfsluiten.Name = "btnAfsluiten"
        Me.btnAfsluiten.Size = New System.Drawing.Size(154, 38)
        Me.btnAfsluiten.TabIndex = 8
        Me.btnAfsluiten.Text = "Afsluiten"
        Me.btnAfsluiten.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(364, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'frmLeerlingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 601)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnAfsluiten)
        Me.Controls.Add(Me.btnLeerlingVerwijderen)
        Me.Controls.Add(Me.btnLeerlingWijzigen)
        Me.Controls.Add(Me.btnLeerlingToevoegen)
        Me.Controls.Add(Me.dgvLeerlingen)
        Me.Name = "frmLeerlingen"
        Me.Text = "Leerlingen"
        CType(Me.dgvLeerlingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLeerlingen As System.Windows.Forms.DataGridView
    Friend WithEvents btnLeerlingToevoegen As System.Windows.Forms.Button
    Friend WithEvents btnLeerlingWijzigen As System.Windows.Forms.Button
    Friend WithEvents btnLeerlingVerwijderen As System.Windows.Forms.Button
    Friend WithEvents btnAfsluiten As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
