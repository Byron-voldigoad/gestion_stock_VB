Imports System.Data.Odbc
Public Class Materieldao

    Public Shared Sub save(ByVal materiel As Materiel)
        If (materiel.idMateriel = 0) Then
            Dim cmd As New OdbcCommand("insert into materiel(nomMateriel,quantite,statut,description,emplacement) values (?,?,?,?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("a", materiel.nomMateriel)
            cmd.Parameters.AddWithValue("b", materiel.quantite)
            cmd.Parameters.AddWithValue("c", materiel.statut)
            cmd.Parameters.AddWithValue("d", materiel.description)
            cmd.Parameters.AddWithValue("e", materiel.emplacement)
            cmd.ExecuteNonQuery()

        Else
            Dim cmd As New OdbcCommand("update materiel set nomMateriel=?,quantite=?,statut=?,description=?,emplacement=? where idMateriel=?", BDD.connecter())
            cmd.Parameters.AddWithValue("a", materiel.nomMateriel)
            cmd.Parameters.AddWithValue("b", materiel.quantite)
            cmd.Parameters.AddWithValue("c", materiel.statut)
            cmd.Parameters.AddWithValue("d", materiel.description)
            cmd.Parameters.AddWithValue("e", materiel.emplacement)
            cmd.Parameters.AddWithValue("f", materiel.idMateriel)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Sub delete(ByVal idMateriel As Integer)
        Dim cmd As New OdbcCommand("delete from materiel where idMateriel=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", idMateriel)
        cmd.ExecuteNonQuery()

    End Sub
    Public Shared Function verification(ByVal nomMateriel As String)
        Dim cmd As New OdbcCommand("SELECT COUNT(*) AS count FROM materiel WHERE nomMateriel =?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", nomMateriel)
        Dim count As Integer = cmd.ExecuteScalar()
        cmd.ExecuteNonQuery()

        Return count
    End Function
    Public Shared Sub deleteAll()
        Dim cmd As New OdbcCommand("delete from materiel", BDD.connecter())
        cmd.ExecuteNonQuery()

    End Sub

    Public Shared Function find(ByVal idMateriel As Integer) As Materiel
        Dim materiel As New Materiel
        Dim cmd As New OdbcCommand("select * from materiel where idMateriel=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", idMateriel)
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
    Public Shared Function findAllReserv() As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("select idMateriel from materiel where statut>0", BDD.connecter())
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function

    Public Shared Function findAll() As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("select idMateriel from materiel", BDD.connecter())
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function

    Public Shared Function findAll2(ByVal nomMateriel As String) As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("select * from materiel where nomMateriel like '%" & nomMateriel & "%'", BDD.connecter())
        cmd.Parameters.AddWithValue("a", nomMateriel)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function
    Public Shared Function findAll3(ByVal statut As String) As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("SELECT * FROM materiel WHERE statut >?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", statut)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function
    Public Shared Function findAll3_2(ByVal statut As String) As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("SELECT * FROM materiel WHERE statut =?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", statut)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function
    Public Shared Function findAll4(ByVal quantite As String) As List(Of Materiel)
        Dim materiels As New List(Of Materiel)
        Dim cmd As New OdbcCommand("select * from materiel where quantite like '%" & quantite & "%'", BDD.connecter())
        cmd.Parameters.AddWithValue("a", quantite)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim materiel As Materiel = find(dr.GetInt32(0))
            materiels.Add(materiel)
        End While
        Return materiels
    End Function

End Class
