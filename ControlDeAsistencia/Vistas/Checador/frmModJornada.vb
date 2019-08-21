Imports MySql.Data.MySqlClient

Public Class frmModJornada
    Private Sub frmModJornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Empleados()

        Configura()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub chbRango_CheckedChanged(sender As Object, e As EventArgs) Handles chbRango.CheckedChanged

        If chbRango.CheckState = CheckState.Checked Then

            lblFechaFin.Visible = True
            dtpFechaFin.Visible = True

        Else

            lblFechaFin.Visible = False
            dtpFechaFin.Visible = False

        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Modifica()
        Me.Close()

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Habilita()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgJornada.Cols.Count = 4
        fgJornada.Rows.Count = 1

        fgJornada.Cols(0).Caption = "ID"
        fgJornada.Cols(1).Caption = "FECHA"
        fgJornada.Cols(1).DataType = GetType(String)
        fgJornada.Cols(2).Caption = "ENTRADA"
        fgJornada.Cols(2).DataType = GetType(String)
        fgJornada.Cols(3).Caption = "SALIDA"
        fgJornada.Cols(3).DataType = GetType(String)

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

    Private Sub ObtieneJornada()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_jornada, "
        strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha, "
        strSql += "entrada, "
        strSql += "salida "
        strSql += "FROM "
        strSql += "jornada_empleado "
        strSql += "WHERE "

        If chbRango.CheckState = CheckState.Checked Then

            strSql += "fecha BETWEEN '" & Format(dtpFechaIni.Value, "yyyyMMdd") & "' AND '" & Format(dtpFechaFin.Value, "yyyyMMdd") & "' AND "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "descanso = 0"

        Else

            strSql += "fecha = '" & Format(dtpFechaIni.Value, "yyyyMMdd") & "' AND "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "descanso = 0"

        End If

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgJornada.AddItem("")

            fgJornada.SetData(fgJornada.Rows.Count - 1, 0, rdrObj(0).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 1, rdrObj(1).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 2, rdrObj(2).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 3, rdrObj(3).ToString)

        End While

        fgJornada.AutoSizeCols()

        rdrObj.Close()
        cnObj.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        ObtieneJornada()
        Inhabilita()

    End Sub

    Private Sub Inhabilita()

        cmbSucursal.Enabled = False
        cmbEmpleado.Enabled = False

        chbRango.Enabled = False
        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False

        tsbGuardar.Enabled = True
        tsbNuevo.Enabled = True

    End Sub

    Private Sub Habilita()

        Configura()

        cmbSucursal.Enabled = True
        cmbEmpleado.Enabled = True

        chbRango.Enabled = True
        dtpFechaIni.Enabled = True
        dtpFechaFin.Enabled = True

        tsbGuardar.Enabled = False
        tsbNuevo.Enabled = False

    End Sub

    Private Sub Modifica()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        For i As Integer = 1 To fgJornada.Rows.Count - 1

            strSql = "UPDATE "
            strSql += "jornada_empleado "
            strSql += "SET "
            strSql += "entrada = '" & fgJornada.GetData(i, 2) & "', "
            strSql += "salida = '" & fgJornada.GetData(i, 3) & "' "
            strSql += "WHERE "
            strSql += "id_jornada = '" & fgJornada.GetData(i, 0) & "'"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al Actualizar la Jornada de la Fecha, " + fgJornada.GetData(i, 1) + " " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Next

        cnObj.Close()

    End Sub

#End Region

End Class