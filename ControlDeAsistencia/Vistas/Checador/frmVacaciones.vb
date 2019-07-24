Imports MySql.Data.MySqlClient

Public Class frmVacaciones

    Private Sub frmVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim bExiste As Boolean = False

        For i As Integer = 1 To fgVacaciones.Rows.Count - 1

            If cmbEmpleado.SelectedValue = fgVacaciones.GetData(i, 0) And Format(dtpFecha.Value, "yyyy-MM-dd") = fgVacaciones.GetData(i, 2) Then
                bExiste = True
                Exit For
            End If

        Next

        If bExiste = False Then

            fgVacaciones.AddItem("")

            fgVacaciones.SetData(fgVacaciones.Rows.Count - 1, 0, cmbEmpleado.SelectedValue)
            fgVacaciones.SetData(fgVacaciones.Rows.Count - 1, 1, cmbEmpleado.Text)
            fgVacaciones.SetData(fgVacaciones.Rows.Count - 1, 2, Format(dtpFecha.Value, "yyyy-MM-dd"))

            fgVacaciones.AutoSizeCols()

        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Guardar()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgVacaciones.Cols.Count = 3
        fgVacaciones.Rows.Count = 1

        fgVacaciones.Cols(0).Caption = "CLAVE"
        fgVacaciones.Cols(0).Visible = False
        fgVacaciones.Cols(1).Caption = "EMPLEADO"
        fgVacaciones.Cols(2).Caption = "FECHA"

        fgVacaciones.AutoSizeCols()

        Sucursales()
        Empleados()

    End Sub

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        For i As Integer = 1 To fgVacaciones.Rows.Count - 1

            Dim bExiste As Boolean = False

            bExiste = ValidaFechaVacaciones(fgVacaciones.GetData(i, 0), fgVacaciones.GetData(i, 2))

            If bExiste = False Then

                strSql = "INSERT "
                strSql += "INTO "
                strSql += "vacaciones "
                strSql += "(clave, "
                strSql += "fecha) "
                strSql += "VALUES "
                strSql += "('" & fgVacaciones.GetData(i, 0) & "', "
                strSql += "'" & fgVacaciones.GetData(i, 2) & "')"

                cmdObj.CommandText = strSql

                Try
                    cmdObj.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else

                MessageBox.Show("La fecha " & fgVacaciones.GetData(i, 2) & " Para el Empleado " & fgVacaciones.GetData(i, 1) & " Ya esta dada de alta", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
           
        Next

        cnObj.Close()
        Me.Close()

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

    Private Function ValidaFechaVacaciones(ByVal Clave As Integer, ByVal fecha As String) As Boolean

        Dim bValida As Boolean = False

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "* "
        strSql += "FROM "
        strSql += "vacaciones "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha = '" & fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            bValida = True
        Else
            bValida = False
        End If

        rdrObj.Close()
        cnObj.Close()

        Return bValida

    End Function

#End Region

End Class