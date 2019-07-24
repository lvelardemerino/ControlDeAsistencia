Imports MySql.Data.MySqlClient

Public Class frmUsuarios

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Usuarios()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgUsuarios.Cols.Count = 3
        fgUsuarios.Rows.Count = 1

        fgUsuarios.Cols(0).Caption = "ID"
        fgUsuarios.Cols(0).Visible = False
        fgUsuarios.Cols(1).Caption = "USUARIO"
        fgUsuarios.Cols(2).Caption = "ESTATUS"

        fgUsuarios.AutoSizeCols()

    End Sub

    Private Sub Usuarios()

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "usr_id, "
        strSql += "concat_ws(' ', usr_nombre, usr_paterno) AS Nombre_ape, "
        strSql += "usr_activo "
        strSql += "FROM "
        strSql += "usuario"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgUsuarios.AddItem("")

            fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 0, rdrObj.Item("usr_id"))
            fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 1, rdrObj.Item("Nombre_ape"))

            If rdrObj.Item("usr_activo") = 1 Then
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 2, "ACTIVO")
            Else
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 2, "INACTIVO")
            End If

        End While

        rdrObj.Close()
        cnObj.Close()

        fgUsuarios.AutoSizeCols()

    End Sub

#End Region

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        If fgUsuarios.Row > 1 Then

            Dim frmUsuariosMod As New frmUsuariosMod()
            frmUsuariosMod.Id = fgUsuarios.GetData(fgUsuarios.Row, 0)
            frmUsuariosMod.ShowDialog()

        End If

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Dim frmUsuariosMod As New frmUsuariosMod()
        frmUsuariosMod.Id = ""
        frmUsuariosMod.ShowDialog()

    End Sub

End Class