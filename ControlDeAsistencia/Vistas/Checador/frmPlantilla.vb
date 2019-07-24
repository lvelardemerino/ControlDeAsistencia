Imports MySql.Data.MySqlClient

Public Class frmPlantilla


#Region "FORMULARIO"

    Private Sub frmPlantilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Jornadas()

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Dim frmPlantillaMod As New frmPlantillaMod()
        frmPlantillaMod.Id = 0
        frmPlantillaMod.ShowDialog()

        Jornadas()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        Dim frmPlantillaMod As New frmPlantillaMod()
        frmPlantillaMod.Id = fgJornadas.GetData(fgJornadas.Row, 0)
        frmPlantillaMod.ShowDialog()

        Jornadas()

    End Sub

#End Region

#Region "FUNCIONES"

    Private Sub Configura()

        fgJornadas.Cols.Count = 4
        fgJornadas.Rows.Count = 1

        fgJornadas.Cols(0).Caption = "Id"
        fgJornadas.Cols(0).Visible = False
        fgJornadas.Cols(1).Caption = "Sucursal"
        fgJornadas.Cols(2).Caption = "Departamento"
        fgJornadas.Cols(3).Caption = "Jornada"

        fgJornadas.AutoSizeCols()

    End Sub

    Private Sub Jornadas()

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "a.id_plantilla, "
        strSql += "a.plantilla, "
        strSql += "b.departamento, "
        strSql += "c.sucursal "
        strSql += "FROM "
        strSql += "plantilla a, "
        strSql += "departamento b, "
        strSql += "sucursal c "
        strSql += "WHERE "
        strSql += "a.id_departamento = b.id_departamento AND "
        strSql += "a.id_sucursal = c.id_sucursal"

        cmdObj.CommandText = strSql

        Dim rdrObj As MySqlDataReader

        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgJornadas.AddItem("")

            fgJornadas.SetData(fgJornadas.Rows.Count - 1, 0, rdrObj.Item("id_plantilla"))
            fgJornadas.SetData(fgJornadas.Rows.Count - 1, 1, rdrObj.Item("sucursal"))
            fgJornadas.SetData(fgJornadas.Rows.Count - 1, 2, rdrObj.Item("departamento"))
            fgJornadas.SetData(fgJornadas.Rows.Count - 1, 3, rdrObj.Item("plantilla"))

        End While

        fgJornadas.AutoSizeCols()

        rdrObj.Close()
        cnObj.Close()

    End Sub

#End Region

End Class