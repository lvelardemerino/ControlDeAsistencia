Imports MySql.Data.MySqlClient

Public Class frmFalta

    Private Sub frmFalta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Empleados()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Guardar()

    End Sub

#Region "FUNCIONES"

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

    Private Sub Guardar()

        If Valida(cmbEmpleado.SelectedValue, Format(dtpFecha.Value, "yyyyMMdd")) = False Then

            Dim cnObj As New MySqlConnection
            cnObj = conectar()

            Dim cmdObj As New MySqlCommand
            cmdObj.Connection = cnObj

            Dim strSql As String

            strSql = "INSERT "
            strSql += "INTO "
            strSql += "incidencias "
            strSql += "(tipo, "
            strSql += "clave, "
            strSql += "fecha, "
            strSql += "observaciones, "
            strSql += "falta) "
            strSql += "VALUES "
            strSql += "('FALTA', "
            strSql += "'" & cmbEmpleado.SelectedValue & "', "
            strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
            strSql += "'" & txtObservaciones.Text & "', "
            strSql += "1)"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnObj.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al Guardar, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cnObj.Close()

        End If

    End Sub

    Private Function Valida(ByVal clave As Integer, ByVal fecha As String) As Boolean

        Dim Valor As Boolean = False

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "* "
        strSql += "FROM "
        strSql += "incidencias "
        strSql += "WHERE "
        strSql += "clave = '" & clave & "' AND "
        strSql += "fecha = '" & fecha & "' AND "
        strSql += "tipo = 'FALTA'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            Valor = True
        Else
            Valor = False
        End If

        Return Valor

        rdrObj.Close()
        cnObj.Close()

    End Function

#End Region

End Class