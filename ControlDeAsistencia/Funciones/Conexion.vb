Imports MySql.Data.MySqlClient

Module Conexion

    Public Function conectar() As MySqlConnection

        Dim cn As New MySqlConnection

        ' Base Local
        cn.ConnectionString = "Server=192.168.2.248;DataBase=checador;User Id=sistemas;Password=s1st3m@s2017"

        'Base Pruebas
        'cn.ConnectionString = "Server=LocalHost;DataBase=checador;User Id=sistemas;Password=s1st3m@s2017"

        Try

            cn.Open()
            Return cn

        Catch ex As Exception

            MessageBox.Show("No se puede conectar a la base de datos " + ex.Message)
            Return Nothing
            Exit Function

        End Try

    End Function

    Public Function ConectarEve() As MySqlConnection

        Dim cn As New MySqlConnection

        'Base de Eventos
        cn.ConnectionString = "Server=grace2.ddns.cyberoam.com;DataBase=eventos;User Id=eventos;Password=$3rv3r3v3nt0$"

        Try

            cn.Open()
            Return cn

        Catch ex As Exception

            Return Nothing
            Exit Function

        End Try

    End Function

    Public Function conectar_Actualizador() As MySqlConnection

        Dim cn As New MySqlConnection

        'Base Externa
        'cn.ConnectionString = "Server=grace.ddns.cyberoam.com;DataBase=maranatha;User Id=sistemas;Password=s1st3m@s2017"

        'Base Local
        cn.ConnectionString = "Server=172.16.16.51;DataBase=maranatha;User Id=sistemas;Password=s1st3m@s2017"

        Try

            cn.Open()
            Return cn

        Catch ex As Exception

            MessageBox.Show("No se puede conectar a la base de datos " + ex.Message)
            Return Nothing
            Exit Function

        End Try

    End Function

End Module
