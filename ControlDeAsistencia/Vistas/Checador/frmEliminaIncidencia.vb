Imports MySql.Data.MySqlClient

Public Class frmEliminaIncidencia

    Private Sub frmEliminaIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Empleados()

        Configura()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub fgIncidencias_KeyDown(sender As Object, e As KeyEventArgs) Handles fgIncidencias.KeyDown

        If e.KeyCode = Keys.Delete Then

            If fgIncidencias.Row > 0 Then

                If MessageBox.Show("¿Desea Eliminar el Registro " + fgIncidencias.GetData(fgIncidencias.Row, 1) + ", de la Base de Datos?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = ShowDialog.Yes Then

                    Elimina()

                End If

            End If

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Incidencias()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgIncidencias.Cols.Count = 4
        fgIncidencias.Rows.Count = 1

        fgIncidencias.Cols(0).Caption = "ID"
        fgIncidencias.Cols(0).Visible = False
        fgIncidencias.Cols(1).Caption = "TIPO"
        fgIncidencias.Cols(2).Caption = "FECHA"
        fgIncidencias.Cols(2).DataType = GetType(String)
        fgIncidencias.Cols(3).Caption = "OBSERVACIONES"

    End Sub

    Private Sub Sucursales()

        cmbSucursal.DataSource = Nothing
        cmbSucursal.Items.Clear()
        cmbSucursal.Text = ""
        cmbSucursal.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_sucursal()

        cmbSucursal.ValueMember = "id_sucursal"
        cmbSucursal.DisplayMember = "sucursal"
        cmbSucursal.DataSource = dsObj.Tables("Sucursal")

    End Sub

    Private Sub Empleados()

        cmbEmpleado.DataSource = Nothing
        cmbEmpleado.Items.Clear()
        cmbEmpleado.Text = ""
        cmbEmpleado.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_empSuc(cmbSucursal.SelectedValue)

        cmbEmpleado.ValueMember = "clave"
        cmbEmpleado.DisplayMember = "Nombre_ape"
        cmbEmpleado.DataSource = dsObj.Tables("Empleado")

    End Sub

    Private Sub Elimina()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "DELETE "
        strSql += "FROM "
        strSql += "incidencias "
        strSql += "WHERE "
        strSql += "id_incidencia = '" & fgIncidencias.GetData(fgIncidencias.Row, 0) & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Incidencia Eliminada", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Borrar la Incidencia, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Incidencias()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_incidencia, "
        strSql += "tipo, "
        strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha, "
        strSql += "observaciones "
        strSql += "FROM "
        strSql += "incidencias "
        strSql += "WHERE "

        If chbRango.CheckState = CheckState.Checked Then
            strSql += "fecha BETWEEN '" & Format(dtpFechaIni.Value, "yyyyMMdd") & "' AND '" & Format(dtpFechaFin.Value, "yyyyMMdd") & "'"
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

        Else

            strSql += "fecha = '" & Format(dtpFechaIni.Value, "yyyyMMdd") & "' AND "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

        End If

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgIncidencias.AddItem("")

            fgIncidencias.SetData(fgIncidencias.Rows.Count - 1, 0, rdrObj(0).ToString)
            fgIncidencias.SetData(fgIncidencias.Rows.Count - 1, 1, rdrObj(1).ToString)
            fgIncidencias.SetData(fgIncidencias.Rows.Count - 1, 2, rdrObj(2).ToString)
            fgIncidencias.SetData(fgIncidencias.Rows.Count - 1, 3, rdrObj(3).ToString)

        End While

        fgIncidencias.AutoSizeCols()

        rdrObj.Close()
        cnObj.Close()

    End Sub

#End Region

End Class