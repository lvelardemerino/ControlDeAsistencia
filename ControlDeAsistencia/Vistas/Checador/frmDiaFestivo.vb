Imports MySql.Data.MySqlClient

Public Class frmDiaFestivo

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Guardar()

    End Sub

#Region "FUNCIONES"

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "INSERT "
        strSql += "INTO "
        strSql += "festivo "
        strSql += "(fecha, "
        strSql += "descripcion) "
        strSql += "VALUES "
        strSql += "('" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
        strSql += "'" & txtDescripcion.Text & "')"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class