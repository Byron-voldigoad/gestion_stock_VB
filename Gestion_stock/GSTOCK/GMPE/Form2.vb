
Public Class Form2
    Dim dgmateriel = Form3.dgmateriel
    Dim materiel As New Materiel
    Private Sub formtobd()
        materiel.nomMateriel = NomMateriel.Text
        materiel.statut = statuCount.Text
        materiel.quantite = QuantiteCount.Text
        materiel.emplacement = Emplacement.Text
        materiel.description = Description.Text

    End Sub
    Private Sub bdtoform()
        NomMateriel.Text = materiel.nomMateriel
        statuCount.Text = materiel.statut
        QuantiteCount.Text = materiel.quantite
        Emplacement.Text = materiel.emplacement
        Description.Text = materiel.description
    End Sub
    Private Sub vider()
        NomMateriel.Text = ""
        statuCount.Text = 0
        QuantiteCount.Text = 0
        Emplacement.Text = ""
        Description.Text = ""
        NomMateriel.Focus()
        materiel = New Materiel

    End Sub
    Public Sub chargelisteMateriel()
        Dim materiels As List(Of Materiel) = Materieldao.findAll()
        dgmateriel.Rows.Clear()
        Try
            For Each materiel As Materiel In materiels
                dgmateriel.Rows.Add(New Object() {materiel.idMateriel, materiel.nomMateriel, materiel.description, materiel.quantite, materiel.emplacement, materiel.statut})
            Next
        Catch ex As Exception
            MessageBox.Show("Encore")
            Form3.Close()
            Me.Close()
            Form1.Opacity = 1

        End Try


    End Sub

    

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBoxAnnuler.Click
        vider()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBoxBD.Click
        Form3.Show()
        Me.Opacity = 0
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Me.Close()
        Form1.Opacity = 1
    End Sub

    Private Sub PictureBoxEnregistrer_Click(sender As Object, e As EventArgs) Handles PictureBoxEnregistrer.Click
        If NomMateriel.Text.Length = 0 Then
            MessageBox.Show("entrer le nom")
            Exit Sub
        End If
        If QuantiteCount.Text = 0 Then
            MessageBox.Show("entrer la quantité de materiel")
            Exit Sub
        End If
        If Emplacement.Text.Length = 0 Then
            MessageBox.Show("entrer le l'emplacement de materiel")
            Exit Sub
        End If
        If statuCount.Text.Length = 0 Then
            MessageBox.Show("entrer la quantité de materiel libre")
            Exit Sub
        End If
        If statuCount.Text > QuantiteCount.Text Then
            MessageBox.Show("La quantité de materiel libre ne doit pas depassé celle disponible")
            Exit Sub
        End If

        If Materieldao.verification(NomMateriel.Text) > 0 Then
            MessageBox.Show("Ce nom existe deja, Entrer en un autre ou modifier le dans la session des modification")
            Exit Sub
        End If
        formtobd()
        Materieldao.save(materiel)
        MessageBox.Show("Enregistrement reusit")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        materiel.nomMateriel = ComboBox1.Text
        materiel = Materieldao.findcombo(materiel.nomMateriel)
        bdtoform()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub PictureBoxModifier_Click(sender As Object, e As EventArgs) Handles PictureBoxModifier.Click
        If statuCount.Text > QuantiteCount.Text Then
            MessageBox.Show("La quantité de materiel libre ne doit pas depassé celle disponible")
            Exit Sub
        End If
        formtobd()
        Materieldao.save(materiel)
        MessageBox.Show("Modification reusit")
    End Sub

    Private Sub PictureBoxAfficher_Click(sender As Object, e As EventArgs) Handles PictureBoxAfficher.Click
        ComboBox1.DataSource = Materieldao.findAll
        ComboBox1.DisplayMember = "nomMateriel"
        ComboBox1.ValueMember = "idMateriel"
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub statuCount_ValueChanged(sender As Object, e As EventArgs) Handles statuCount.ValueChanged

    End Sub
    Private Sub Form2_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Closed
        Form1.Opacity = 1

    End Sub
End Class