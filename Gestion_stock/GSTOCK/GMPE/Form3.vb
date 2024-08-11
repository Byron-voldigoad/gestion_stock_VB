Public Class Form3
    Dim materiel As New Materiel

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form2.Opacity = 1
    End Sub
    Private Sub Form2_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Closed
        Form2.Opacity = 1

    End Sub
    Private Sub bdtoform()
        Form2.NomMateriel.Text = materiel.nomMateriel
        materiel.statut = Form2.statuCount.Text
        Form2.QuantiteCount.Text = materiel.quantite
        Form2.Emplacement.Text = materiel.emplacement
        Form2.Description.Text = materiel.description
    End Sub

    Private Sub dgmateriel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgmateriel.CellContentClick
        materiel.idMateriel = dgmateriel.SelectedRows(0).Cells(0).Value
        materiel = Materieldao.find(materiel.idMateriel)
        bdtoform()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.chargelisteMateriel()
    End Sub

    Public Sub chargelisteMaterielbynom(ByVal AZ As String)
        Dim materiels As List(Of Materiel) = Materieldao.findAll2(AZ)
        dgmateriel.Rows.Clear()
        For Each materiel As Materiel In materiels
            dgmateriel.Rows.Add(New Object() {materiel.idMateriel, materiel.nomMateriel, materiel.description, materiel.quantite, materiel.emplacement, materiel.statut})
        Next
    End Sub
    Public Sub chargelisteMaterielbystatut(ByVal A As String)

        Dim materiels As List(Of Materiel) = Materieldao.findAll3(A)
        dgmateriel.Rows.Clear()
        For Each materiel As Materiel In materiels
            dgmateriel.Rows.Add(New Object() {materiel.idMateriel, materiel.nomMateriel, materiel.description, materiel.quantite, materiel.emplacement, materiel.statut})
        Next
    End Sub
    Public Sub chargelisteMaterielbystatut2(ByVal AB As String)

        Dim materiels As List(Of Materiel) = Materieldao.findAll3_2(AB)
        dgmateriel.Rows.Clear()
        For Each materiel As Materiel In materiels
            dgmateriel.Rows.Add(New Object() {materiel.idMateriel, materiel.nomMateriel, materiel.description, materiel.quantite, materiel.emplacement, materiel.statut})
        Next
    End Sub
    Public Sub chargelisteMaterielbynbr(ByVal AA As String)
        Dim materiels As List(Of Materiel) = Materieldao.findAll4(AA)
        dgmateriel.Rows.Clear()
        For Each materiel As Materiel In materiels
            dgmateriel.Rows.Add(New Object() {materiel.idMateriel, materiel.nomMateriel, materiel.description, materiel.quantite, materiel.emplacement, materiel.statut})
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chargelisteMaterielbynom(TextBox1.Text)
        If TextBox1.Text.Length = 0 Then
            Form2.chargelisteMateriel()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "Libre" Then
            chargelisteMaterielbystatut(0)
        End If
        If ComboBox1.Text = "Reserver" Then
            chargelisteMaterielbystatut2(0)
        End If

        If ComboBox1.Text.Length = 0 Then
            Form2.chargelisteMateriel()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chargelisteMaterielbynbr(Quantiterecherche.Text)
        If Quantiterecherche.Text.Length = 0 Then
            Form2.chargelisteMateriel()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If materiel.idMateriel = 0 Then
            MessageBox.Show("selectionner une ligne a supprimer")
            Exit Sub
        End If
        Materieldao.delete(materiel.idMateriel)
        Form2.chargelisteMateriel()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer
        result = MsgBox("Voulez-vous vraiment supprimer ce fichier ?", vbYesNoCancel, "Confirmation")
        MessageBox.Show(result)
        If result = 6 Then
            Materieldao.deleteAll()
            Form2.chargelisteMateriel()
            Exit Sub
        End If

    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        materiel.nomMateriel = ComboBox1.Text
        materiel = Materieldao.findcombo(materiel.nomMateriel)
        bdtoform()
    End Sub


    Private Sub ListeDesReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesReservationToolStripMenuItem.Click
        Form4.Show()
        'Me.Opacity = 0
    End Sub
End Class