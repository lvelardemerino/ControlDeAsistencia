Imports MySql.Data.MySqlClient

Public Class frmErrores

    Private Sub frmErrores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()
        ObtieneErrores()

    End Sub

    Private Sub tsbExecutar_Click(sender As Object, e As EventArgs) Handles tsbExecutar.Click

        If fgErrores.Row > 0 Then

            Ejecuta()

        End If

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgErrores.Cols.Count = 6
        fgErrores.Rows.Count = 1

        fgErrores.Cols(0).Caption = "ID"
        fgErrores.Cols(0).Visible = False
        fgErrores.Cols(1).Caption = "SUCURSAL"
        fgErrores.Cols(2).Caption = "FECHA"
        fgErrores.Cols(3).Caption = "EVENTO"
        fgErrores.Cols(4).Caption = "NUBE"
        fgErrores.Cols(5).Caption = "ERROR"

        fgErrores.AutoSizeCols()

    End Sub

    Private Sub ObtieneErrores()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "a.id_evento_error, "
        strSql += "b.sucursal, "
        strSql += "a.fecha, "
        strSql += "a.evento, "
        strSql += "a.evento_nube "
        strSql += "FROM "
        strSql += "eventos_error a, "
        strSql += "sucursal b "
        strSql += "WHERE "
        strSql += "a.id_sucursal = b.id_sucursal"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgErrores.AddItem("")

            fgErrores.SetData(fgErrores.Rows.Count - 1, 0, rdrObj.Item("id_evento_error"))
            fgErrores.SetData(fgErrores.Rows.Count - 1, 1, rdrObj.Item("sucursal"))
            fgErrores.SetData(fgErrores.Rows.Count - 1, 2, rdrObj.Item("fecha"))
            fgErrores.SetData(fgErrores.Rows.Count - 1, 3, rdrObj.Item("evento"))
            fgErrores.SetData(fgErrores.Rows.Count - 1, 4, rdrObj.Item("evento_nube"))

        End While

        fgErrores.Cols(1).Width = 180
        fgErrores.Cols(2).Width = 80
        fgErrores.Cols(3).Width = 250
        fgErrores.Cols(4).Width = 60

        rdrObj.Close()
        cnObj.Close()

    End Sub

    Private Sub Ejecuta()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = Replace(fgErrores.GetData(fgErrores.Row, 3), "*", "'")

        cmdObj.CommandText = strSql

        Try

            cmdObj.ExecuteNonQuery()
            fgErrores.SetData(fgErrores.Row, 5, "CORRECTO")
            fgErrores.Cols(5).Width = 250

        Catch ex As Exception

            Dim strError As String = ex.Message.ToString

            Dim cnOtr As New MySqlConnection
            cnOtr = conectar()

            Dim cmdOtr As New MySqlCommand
            cmdOtr.Connection = cnOtr

            Dim strOtr As String

            strOtr = "UPDATE "
            strOtr += "eventos_error "
            strOtr += "SET "
            strOtr += "error = '" & strError & "' "
            strOtr += "WHERE "
            strOtr += "id_evento_error = '" & fgErrores.GetData(fgErrores.Row, 0) & "'"

            cmdOtr.CommandText = strOtr

            Try
                cmdOtr.ExecuteNonQuery()
            Catch exOtr As Exception

            End Try

            cnOtr.Close()

            fgErrores.SetData(fgErrores.Row, 5, ex.Message)
            fgErrores.Cols(5).Width = 250

        End Try

        cnObj.Close()

    End Sub

#End Region

End Class