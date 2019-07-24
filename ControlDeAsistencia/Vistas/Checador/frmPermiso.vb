Imports MySql.Data.MySqlClient

Public Class frmPermiso

    Private Sub frmPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        Select Case cmbConcepto.Text

            Case "ENTRADA TEMPRANO"

                If txtHora.Text <> "" Then

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones, "
                    strSql += "entrada) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "', "
                    strSql += "'" & txtHora.Text & "')"

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

                Else

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "')"

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
               

            Case "ENTRADA TARDE"

                If txtHora.Text <> "" Then

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones, "
                    strSql += "entrada) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "', "
                    strSql += "'" & txtHora.Text & "')"

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

                Else

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "')"

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
               

            Case "SALIDA TEMPRANO"

                If txtHora.Text <> "" Then

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones, "
                    strSql += "salida) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "', "
                    strSql += "'" & txtHora.Text & "')"

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

                Else

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "')"

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
               

            Case "SALIDA TARDE"

                If txtHora.Text <> "" Then

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones, "
                    strSql += "salida) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "', "
                    strSql += "'" & txtHora.Text & "')"

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

                Else

                    strSql = "INSERT "
                    strSql += "INTO "
                    strSql += "incidencias "
                    strSql += "(tipo, "
                    strSql += "clave, "
                    strSql += "fecha, "
                    strSql += "observaciones) "
                    strSql += "VALUES "
                    strSql += "('" & cmbConcepto.Text & "', "
                    strSql += "'" & cmbEmpleado.SelectedValue & "', "
                    strSql += "'" & Format(dtpFecha.Value, "yyyyMMdd") & "', "
                    strSql += "'" & txtObservaciones.Text & "')"

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
                

        End Select

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

#End Region

End Class