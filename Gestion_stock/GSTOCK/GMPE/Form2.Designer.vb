<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEnregistrer = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAnnuler = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.statuCount = New System.Windows.Forms.NumericUpDown()
        Me.Emplacement = New System.Windows.Forms.TextBox()
        Me.QuantiteCount = New System.Windows.Forms.NumericUpDown()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.NomMateriel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBoxModifier = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAfficher = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxEnregistrer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAnnuler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.statuCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantiteCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBoxModifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAfficher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.PictureBoxEnregistrer)
        Me.GroupBox1.Controls.Add(Me.PictureBoxBD)
        Me.GroupBox1.Controls.Add(Me.PictureBoxAnnuler)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 417)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBoxEnregistrer
        '
        Me.PictureBoxEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEnregistrer.Image = Global.GMPE.My.Resources.Resources.enregistrer
        Me.PictureBoxEnregistrer.Location = New System.Drawing.Point(6, 19)
        Me.PictureBoxEnregistrer.Name = "PictureBoxEnregistrer"
        Me.PictureBoxEnregistrer.Size = New System.Drawing.Size(123, 44)
        Me.PictureBoxEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEnregistrer.TabIndex = 3
        Me.PictureBoxEnregistrer.TabStop = False
        '
        'PictureBoxBD
        '
        Me.PictureBoxBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBD.Image = Global.GMPE.My.Resources.Resources.ouvrir_bd
        Me.PictureBoxBD.Location = New System.Drawing.Point(390, 19)
        Me.PictureBoxBD.Name = "PictureBoxBD"
        Me.PictureBoxBD.Size = New System.Drawing.Size(123, 44)
        Me.PictureBoxBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBD.TabIndex = 2
        Me.PictureBoxBD.TabStop = False
        '
        'PictureBoxAnnuler
        '
        Me.PictureBoxAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxAnnuler.Image = Global.GMPE.My.Resources.Resources.annuler
        Me.PictureBoxAnnuler.Location = New System.Drawing.Point(189, 19)
        Me.PictureBoxAnnuler.Name = "PictureBoxAnnuler"
        Me.PictureBoxAnnuler.Size = New System.Drawing.Size(123, 44)
        Me.PictureBoxAnnuler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAnnuler.TabIndex = 1
        Me.PictureBoxAnnuler.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.statuCount)
        Me.GroupBox2.Controls.Add(Me.Emplacement)
        Me.GroupBox2.Controls.Add(Me.QuantiteCount)
        Me.GroupBox2.Controls.Add(Me.Description)
        Me.GroupBox2.Controls.Add(Me.NomMateriel)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 317)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'statuCount
        '
        Me.statuCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuCount.Location = New System.Drawing.Point(404, 99)
        Me.statuCount.Name = "statuCount"
        Me.statuCount.Size = New System.Drawing.Size(90, 24)
        Me.statuCount.TabIndex = 10
        '
        'Emplacement
        '
        Me.Emplacement.Location = New System.Drawing.Point(168, 155)
        Me.Emplacement.Multiline = True
        Me.Emplacement.Name = "Emplacement"
        Me.Emplacement.Size = New System.Drawing.Size(326, 52)
        Me.Emplacement.TabIndex = 9
        '
        'QuantiteCount
        '
        Me.QuantiteCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteCount.Location = New System.Drawing.Point(132, 97)
        Me.QuantiteCount.Name = "QuantiteCount"
        Me.QuantiteCount.Size = New System.Drawing.Size(87, 24)
        Me.QuantiteCount.TabIndex = 7
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(168, 232)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(326, 71)
        Me.Description.TabIndex = 6
        '
        'NomMateriel
        '
        Me.NomMateriel.Location = New System.Drawing.Point(168, 39)
        Me.NomMateriel.Multiline = True
        Me.NomMateriel.Name = "NomMateriel"
        Me.NomMateriel.Size = New System.Drawing.Size(326, 23)
        Me.NomMateriel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(257, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Materiel libre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Emplacement :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantité :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom materiel :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.PictureBoxModifier)
        Me.GroupBox4.Controls.Add(Me.PictureBoxAfficher)
        Me.GroupBox4.Location = New System.Drawing.Point(609, 84)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 317)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 57)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cliquer ensuite sur 'Aficher'. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Puis apres mise ajour " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       ciquer sur " & _
    "'Modifier'"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Selectioner le code materiel"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'PictureBoxModifier
        '
        Me.PictureBoxModifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxModifier.Image = Global.GMPE.My.Resources.Resources.modifier
        Me.PictureBoxModifier.Location = New System.Drawing.Point(55, 250)
        Me.PictureBoxModifier.Name = "PictureBoxModifier"
        Me.PictureBoxModifier.Size = New System.Drawing.Size(163, 53)
        Me.PictureBoxModifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxModifier.TabIndex = 1
        Me.PictureBoxModifier.TabStop = False
        '
        'PictureBoxAfficher
        '
        Me.PictureBoxAfficher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxAfficher.Image = Global.GMPE.My.Resources.Resources.afficher2
        Me.PictureBoxAfficher.Location = New System.Drawing.Point(55, 172)
        Me.PictureBoxAfficher.Name = "PictureBoxAfficher"
        Me.PictureBoxAfficher.Size = New System.Drawing.Size(163, 53)
        Me.PictureBoxAfficher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAfficher.TabIndex = 0
        Me.PictureBoxAfficher.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.GMPE.My.Resources.Resources.E
        Me.PictureBox1.Location = New System.Drawing.Point(773, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Image = Global.GMPE.My.Resources.Resources.fermer2
        Me.PictureBoxClose.Location = New System.Drawing.Point(666, 422)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(140, 63)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxClose.TabIndex = 4
        Me.PictureBoxClose.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(740, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = " ENREGISTREMENT DU MATERIEL DANS LA BASE DE DONNEE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 514)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxEnregistrer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAnnuler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.statuCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantiteCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBoxModifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAfficher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBoxBD As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxAnnuler As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBoxEnregistrer As System.Windows.Forms.PictureBox
    Friend WithEvents Emplacement As System.Windows.Forms.TextBox
    Friend WithEvents QuantiteCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents NomMateriel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBoxModifier As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxAfficher As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents statuCount As System.Windows.Forms.NumericUpDown
End Class
