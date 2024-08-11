Public Class Form4

    Dim reservation As New Reservation

    Private Sub formtobd()
        reservation.nomUser = ComboBox2.Text
        reservation.nomMateriel = ComboBox1.Text
        reservation.dateJour = DateTimePicker1.Text
        reservation.HeuresDebut = DateTimePicker3.Text
        reservation.HeuresFin = DateTimePicker4.Text

    End Sub

    Private Sub bdtoform()
        ComboBox2.Text = reservation.nomMateriel
        ComboBox1.Text = reservation.NomUser
        DateTimePicker1.Text = reservation.dateJour
        DateTimePicker3.Text = reservation.HeuresDebut
        DateTimePicker4.Text = reservation.HeuresFin

    End Sub
    Private Sub chargelisteReservation()
        Dim reservations As List(Of Reservation) = Reservationdao.findAll()
        dgreservation.Rows.Clear()
        For Each reservation As Reservation In reservations
            dgreservation.Rows.Add(New Object() {reservation.identifiant, reservation.nomMateriel, reservation.NomUser, reservation.dateJour, reservation.HeuresDebut, reservation.HeuresFin})
        Next
    End Sub
    Private Sub chargementCombobox()
        ComboBox1.DataSource = Materieldao.findAllReserv
        ComboBox1.DisplayMember = "nomMateriel"
        ComboBox1.ValueMember = "idMateriel"

        ComboBox2.DataSource = Userdao.findAll
        ComboBox2.DisplayMember = "nomUser"
        ComboBox2.ValueMember = "idUser"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementCombobox()

        chargelisteReservation()
        'MessageBox.Show("Jour :" & DateTimePicker2.Text & ",Heure :" & DateTimePicker3.Text)

    End Sub
    Private Sub vider()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        reservation = New Reservation

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        
    End Sub

    Private Sub PictureBoxEnregistrer_Click(sender As Object, e As EventArgs) Handles PictureBoxEnregistrer.Click
        formtobd()
        Reservationdao.save(reservation)
        Reservationdao.soustraction(ComboBox1.Text)
        MessageBox.Show("Enregistrement reusit")
        chargelisteReservation()
        chargementCombobox()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgreservation.CellContentClick, dgreservation.CellClick

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgreservation.CellClick, dgreservation.CellContentClick
        reservation.identifiant = dgreservation.SelectedRows(0).Cells(0).Value
        reservation = Reservationdao.find(reservation.identifiant)
        bdtoform()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBoxAnnuler_Click(sender As Object, e As EventArgs) Handles PictureBoxAnnuler.Click
        vider()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If reservation.identifiant = 0 Then
            MessageBox.Show("selectionner une ligne a supprimer")
            Exit Sub
        End If
        Reservationdao.addition(ComboBox1.Text)
        MessageBox.Show(ComboBox1.Text)
        Reservationdao.delete(reservation.identifiant)
        chargelisteReservation()
        chargementCombobox()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer
        result = MsgBox("Voulez-vous vraiment supprimer ce fichier ?", vbYesNoCancel, "Confirmation")

        If result = 6 Then
            Reservationdao.deleteAll()
            chargelisteReservation()
            Exit Sub
        End If
        chargementCombobox()
    End Sub
End Class