Imports System.Data.SqlClient
Module Conexion
    Public Function conectar() As SqlConnection

        Dim conec As New SqlConnection
        conec.ConnectionString = " server=ELVIN_PC\SQLEXPRESS; database=DavidCell; trusted_connection=yes"
        conec.Open()
        Return conec

    End Function
End Module
