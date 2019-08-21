Imports MySql.Data.MySqlClient

Public Class frmEliminarJornada

    Private Sub frmEliminarJornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

        Sucursales()
        Empleados()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub tsbBuscar_Click(sender As Object, e As EventArgs) Handles tsbBuscar.Click

        If Format(dtpFechaFin.Value, "yyyyMMdd") > Format(dtpFechaIni.Value, "yyyyMMdd") Then

            BuscaJornada(cmbEmpleado.SelectedValue, Format(dtpFechaIni.Value, "yyyyMMdd"), Format(dtpFechaFin.Value, "yyyyMMdd"))
            tsbEliminar.Enabled = True

        End If

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click

        Dim Resp As Boolean = False

        If MessageBox.Show("¿Desea Eliminar los Datos?", "ELIMINAR DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Eliminar()

        End If

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgJornada.Cols.Count = 5
        fgJornada.Rows.Count = 1

        fgJornada.Cols(0).Caption = "ID"
        fgJornada.Cols(0).Visible = False
        fgJornada.Cols(1).Caption = "CLAVE"
        fgJornada.Cols(1).Visible = False
        fgJornada.Cols(2).Caption = "FECHA"
        fgJornada.Cols(3).Caption = "ENTRADA"
        fgJornada.Cols(4).Caption = "SALIDA"

        fgJornada.AutoSizeCols()

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

    Private Sub BuscaJornada(ByVal Clave As Integer, ByVal FechaIni As String, ByVal FechaFin As String)

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_jornada, "
        strSql += "clave, "
        strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha, "
        strSql += "entrada, "
        strSql += "salida "
        strSql += "FROM "
        strSql += "jornada_empleado "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha BETWEEN '" & FechaIni & "' AND '" & FechaFin & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgJornada.AddItem("")

            fgJornada.SetData(fgJornada.Rows.Count - 1, 0, rdrObj(0).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 1, rdrObj(1).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 2, rdrObj(2).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 3, rdrObj(3).ToString)
            fgJornada.SetData(fgJornada.Rows.Count - 1, 4, rdrObj(4).ToString)

        End While

        rdrObj.Close()
        cnObj.Close()

        fgJornada.AutoSizeCols()

    End Sub

    Private Sub Eliminar()

        If fgJornada.Row > 0 Then

            Dim cnObj As New MySqlConnection
            cnObj = conectar()

            Dim cmdObj As New MySqlCommand
            cmdObj.Connection = cnObj

            Dim strSql As String

            For i As Integer = 1 To fgJornada.Rows.Count - 1

                strSql = "DELETE "
                strSql += "FROM "
                strSql += "jornada_empleado "
                strSql += "WHERE "
                strSql += "id_jornada = '" & fgJornada.GetData(i, 0) & "'"

                cmdObj.CommandText = strSql

                Try
                    cmdObj.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error al Eliminar la Fecha: " & fgJornada.GetData(i, 2) & ", " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Next

            MessageBox.Show("Datos Eliminados de la Base de Datos", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cnObj.Close()
            Me.Close()

        End If

    End Sub

#End Region

End Class