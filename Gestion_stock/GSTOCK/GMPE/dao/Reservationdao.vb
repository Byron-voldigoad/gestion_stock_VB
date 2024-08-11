Imports System.Data.Odbc
Public Class Reservationdao
    Public Shared Sub save(ByVal reservation As Reservation)
        If (reservation.identifiant = 0) Then
            Dim cmd As New OdbcCommand("insert into reservation(NomUser,nomMateriel,dateJour,HeuresDebut,HeuresFin) values (?,?,?,?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("a", reservation.NomUser)
            cmd.Parameters.AddWithValue("b", reservation.nomMateriel)
            cmd.Parameters.AddWithValue("c", reservation.dateJour)
            cmd.Parameters.AddWithValue("d", reservation.HeuresDebut)
            cmd.Parameters.AddWithValue("d", reservation.HeuresFin)
            cmd.ExecuteNonQuery()

        Else
            Dim cmd As New OdbcCommand("update reservation set idMateriel=?,idUser=?,dateJour=?,HeuresDebut=?,HeuresDebut=? where identifiant=?", BDD.connecter())
            cmd.Parameters.AddWithValue("a", reservation.nomMateriel)
            cmd.Parameters.AddWithValue("b", reservation.NomUser)
            cmd.Parameters.AddWithValue("c", reservation.dateJour)
            cmd.Parameters.AddWithValue("d", reservation.HeuresDebut)
            cmd.Parameters.AddWithValue("d", reservation.HeuresFin)
            cmd.Parameters.AddWithValue("f", reservation.identifiant)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Sub delete(ByVal identifiant As Integer)
        Dim cmd As New OdbcCommand("delete from reservation where identifiant=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", identifiant)
        cmd.ExecuteNonQuery()

    End Sub


    Public Shared Function find(ByVal identifiant As Integer) As Reservation
        Dim reservation As New Reservation
        Dim cmd As New OdbcCommand("select * from reservation where identifiant=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", identifiant)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            reservation.identifiant = dr.GetInt32(0)
            reservation.nomMateriel = dr.GetString(1)
            reservation.NomUser = dr.GetString(2)
            reservation.dateJour = dr.GetString(3)
            reservation.HeuresDebut = dr.GetString(4)
            reservation.HeuresFin = dr.GetString(5)
        End If
        Return reservation
    End Function
    Public Shared Sub soustraction(ByVal nomMateriel As String)
        Dim cmd As New OdbcCommand("update materiel set  statut=statut -1 where nomMateriel=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", nomMateriel)
        cmd.ExecuteNonQuery()

    End Sub
    Public Shared Sub addition(ByVal nomMateriel As String)
        Dim cmd As New OdbcCommand("update materiel set  statut=statut +1 where nomMateriel=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", nomMateriel)
        cmd.ExecuteNonQuery()

    End Sub

    Public Shared Function findAll() As List(Of Reservation)
        Dim reservations As New List(Of Reservation)
        Dim cmd As New OdbcCommand("select identifiant from reservation", BDD.connecter())
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim reservation As Reservation = find(dr.GetInt32(0))
            reservations.Add(reservation)
        End While
        Return reservations
    End Function

    Public Shared Function findcombo(ByVal nomMateriel As String) As Materiel
        Dim materiel As New Materiel
        Dim cmd As New OdbcCommand("select * from materiel where nomMateriel=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", nomMateriel)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            materiel.idMateriel = dr.GetInt32(0)
            materiel.nomMateriel = dr.GetString(1)
            materiel.description = dr.GetString(2)
            materiel.quantite = dr.GetString(3)
            materiel.emplacement = dr.GetString(4)
            materiel.statut = dr.GetString(5)
        End If
        Return materiel
    End Function

    Public Shared Sub deleteAll()
        Dim cmd As New OdbcCommand("TRUNCATE TABLE reservation", BDD.connecter())
        cmd.ExecuteNonQuery()
     
    End Sub
End Class
