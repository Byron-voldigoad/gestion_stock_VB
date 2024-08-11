Imports System.Data.Odbc
Public Class BDD
    Public Shared Function connecter()
        Dim con As String = ("dsn=gmpde_bd")
        Dim conn As New OdbcConnection
        conn.ConnectionString = con
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return conn
    End Function


End Class
