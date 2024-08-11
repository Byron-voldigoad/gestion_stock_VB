Imports System.Data.Odbc
Public Class Userdao
    Public Shared Sub save(ByVal user As User)
        If (user.idUser = 0) Then
            Dim cmd As New OdbcCommand("insert into utililisateur(nomUser,prenomUser,password) values (?,?,?,?)", BDD.connecter())
            cmd.Parameters.AddWithValue("b", user.nomUser)
            cmd.Parameters.AddWithValue("c", user.prenomUser)
            cmd.Parameters.AddWithValue("d", user.password)
            cmd.ExecuteNonQuery()

        Else
            Dim cmd As New OdbcCommand("update utililisateur set nomUser=?,prenomUser=?,password=? where idUser=?", BDD.connecter())
            cmd.Parameters.AddWithValue("b", user.nomUser)
            cmd.Parameters.AddWithValue("c", user.prenomUser)
            cmd.Parameters.AddWithValue("d", user.password)
            cmd.Parameters.AddWithValue("a", user.idUser)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Shared Function find(ByVal idUser As Integer) As User
        Dim user As New User
        Dim cmd As New OdbcCommand("select * from utililisateur where idUser=?", BDD.connecter())
        cmd.Parameters.AddWithValue("a", idUser)
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            user.idUser = dr.GetInt32(0)
            user.nomUser = dr.GetString(1)
            user.prenomUser = dr.GetString(2)
            user.password = dr.GetString(3)
        End If
        Return user
    End Function

    Public Shared Function findAll() As List(Of User)
        Dim users As New List(Of User)
        Dim cmd As New OdbcCommand("select idUser from utililisateur", BDD.connecter())
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim user As User = find(dr.GetInt32(0))
            users.Add(user)
        End While
        Return users
    End Function
End Class
