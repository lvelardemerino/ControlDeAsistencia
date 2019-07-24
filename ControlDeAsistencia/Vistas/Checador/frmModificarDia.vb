Imports MySql.Data.MySqlClient

Public Class frmModificarDia

    Dim bNuevo As Boolean = False
    Dim fecha As String = Format(Date.Now, "yyyyMMdd")

    Private Sub frmModificarDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Departamento()
        Empleados()
        Configura()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Departamento()

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "clave, "
        strSql += "fecha, "
        strSql += "reg_entrada, "
        strSql += "reg_sal_comida, "
        strSql += "reg_ent_comida, "
        strSql += "reg_salida "
        strSql += "FROM "
        strSql += "registro "
        strSql += "WHERE "
        strSql += "fecha = '" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND "
        strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgHorarios.AddItem("")

            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 0, rdrObj.Item("clave"))
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 1, cmbEmpleado.Text)
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 2, rdrObj.Item("fecha"))
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 3, rdrObj.Item("reg_entrada"))
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 4, rdrObj.Item("reg_sal_comida"))
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 5, rdrObj.Item("reg_ent_comida"))
            fgHorarios.SetData(fgHorarios.Rows.Count - 1, 6, rdrObj.Item("reg_salida"))

        End While

        rdrObj.Close()
        cnObj.Close()

        fgHorarios.AutoSizeCols()

    End Sub

    Private Sub tsbIngresar_Click(sender As Object, e As EventArgs) Handles tsbIngresar.Click

        fgHorarios.AddItem("")

        fgHorarios.SetData(fgHorarios.Rows.Count - 1, 0, cmbEmpleado.SelectedValue)
        fgHorarios.SetData(fgHorarios.Rows.Count - 1, 1, cmbEmpleado.Text)
        fgHorarios.SetData(fgHorarios.Rows.Count - 1, 2, Format(dtpFecha.Value, "dd-MM-yyyy"))

        Inhabilita()
        'cmbDepartamento.Enabled = False
        'cmbEmpleado.Enabled = False
        'cmbSucursal.Enabled = False
        'dtpFecha.Enabled = False

        'tsbIngresar.Enabled = False
        'btnBuscar.Enabled = False
        'bNuevo = True

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Guardar()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgHorarios.Cols.Count = 7
        fgHorarios.Rows.Count = 1

        fgHorarios.Cols(0).Caption = "Id Empleado"
        fgHorarios.Cols(0).Visible = False
        fgHorarios.Cols(1).Caption = "Empleado"
        fgHorarios.Cols(2).Caption = "Fecha"
        fgHorarios.Cols(3).Caption = "Entrada"
        fgHorarios.Cols(4).Caption = "Salida a Comer"
        fgHorarios.Cols(5).Caption = "Entrada de Comer"
        fgHorarios.Cols(6).Caption = "Salida"

        fgHorarios.Cols(1).Width = 200
        fgHorarios.Cols(2).Width = 70
        fgHorarios.Cols(3).Width = 70
        fgHorarios.Cols(4).Width = 90
        fgHorarios.Cols(5).Width = 95
        fgHorarios.Cols(6).Width = 70

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

    Private Sub Departamento()

        cmbDepartamento.DataSource = Nothing
        cmbDepartamento.Items.Clear()
        cmbDepartamento.Text = ""
        cmbDepartamento.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Departamento_sucursal(cmbSucursal.SelectedValue)

        cmbDepartamento.ValueMember = "id_departamento"
        cmbDepartamento.DisplayMember = "departamento"
        cmbDepartamento.DataSource = dsObj.Tables("Departamento")

    End Sub

    Private Sub Empleados()

        cmbEmpleado.DataSource = Nothing
        cmbEmpleado.Items.Clear()
        cmbEmpleado.Text = ""
        cmbEmpleado.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_empSucDepto(cmbSucursal.SelectedValue, cmbDepartamento.SelectedValue)

        cmbEmpleado.ValueMember = "clave"
        cmbEmpleado.DisplayMember = "Nombre_ape"
        cmbEmpleado.DataSource = dsObj.Tables("Empleado")

    End Sub

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim strOtr As String

        If bNuevo = False Then

            For i As Integer = 1 To fgHorarios.Rows.Count - 1

                'Cambios(cmbColaborador.SelectedValue, Format(dtpFecha.Value, "yyyyMMdd"), fgHorarios.GetData(i, 3), fgHorarios.GetData(i, 4), fgHorarios.GetData(i, 5), fgHorarios.GetData(i, 6))

                strSql = "UPDATE "
                strSql += "registro "
                strSql += "SET "
                strSql += "reg_entrada = '" & fgHorarios.GetData(i, 3) & "', "
                If fgHorarios.GetData(i, 4) <> "" Then
                    strSql += "reg_sal_comida = '" & fgHorarios.GetData(i, 4) & "', "
                End If

                If fgHorarios.GetData(i, 5) <> "" Then
                    strSql += "reg_ent_comida = '" & fgHorarios.GetData(i, 5) & "', "
                End If

                If fgHorarios.GetData(i, 6) <> "" Then
                    strSql += "reg_salida = '" & fgHorarios.GetData(i, 6) & "', "
                End If


                strSql += "WHERE "
                strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
                strSql += "fecha = '" & Format(dtpFecha.Value, "yyyyMMdd") & "'"

                cmdObj.CommandText = strSql

                Try
                    cmdObj.ExecuteNonQuery()
                    strOtr = Replace(strSql, "'", "*")
                    GeneraEvento(intSucursal, fecha, strOtr)

                Catch ex As Exception
                    MessageBox.Show("Error al Guardar los Datos, " & ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Next

        Else

            strSql = "INSERT "
            strSql += "INTO "
            strSql += "registro "
            strSql += "(clave, "
            strSql += "fecha, "
            strSql += "reg_entrada, "
            strSql += "suc_entrada, "
            strSql += "reg_sal_comida, "
            strSql += "suc_sal_comida, "
            strSql += "reg_ent_comida, "
            strSql += "suc_ent_comida, "
            strSql += "reg_salida, "
            strSql += "suc_salida) "
            strSql += "VALUES "
            strSql += "('" & cmbEmpleado.SelectedValue & "', "
            strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
            strSql += "'" & fgHorarios.GetData(1, 3) & "', "
            strSql += "'" & intSucursal & "', "
            strSql += "'" & fgHorarios.GetData(1, 4) & "', "
            strSql += "'" & intSucursal & "', "
            strSql += "'" & fgHorarios.GetData(1, 5) & "', "
            strSql += "'" & intSucursal & "', "
            strSql += "'" & fgHorarios.GetData(1, 6) & "', "
            strSql += "'" & intSucursal & "')"


            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                strOtr = Replace(strSql, "'", "*")
                GeneraEvento(intSucursal, fecha, strOtr)
            Catch ex As Exception
                MessageBox.Show("Error al Guardar los Datos, " & ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        cnObj.Close()

        Configura()
        Habilita()

    End Sub

    Private Sub Inhabilita()

        cmbDepartamento.Enabled = False
        cmbEmpleado.Enabled = False
        cmbSucursal.Enabled = False
        dtpFecha.Enabled = False

        tsbIngresar.Enabled = False
        btnBuscar.Enabled = False
        bNuevo = True

    End Sub

    Private Sub Habilita()

        cmbDepartamento.Enabled = True
        cmbEmpleado.Enabled = True
        cmbSucursal.Enabled = True
        dtpFecha.Enabled = True

        tsbIngresar.Enabled = True
        btnBuscar.Enabled = True
        bNuevo = False

    End Sub

#End Region

End Class