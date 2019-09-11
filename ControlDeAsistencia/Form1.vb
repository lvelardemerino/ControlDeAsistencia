Imports MySql.Data.MySqlClient

Public Class frmMdi

    '*******************************************************************************************************************************************************************
    '*                                                                                                                                                                 *
    '*                          CREADO POR: ING. LUIS ALBERTO VELARDE MERINO.                                                                                          *
    '*                                                                                                                                                                 *
    '*                          ING. SISTEMAS COMPUTACIONALES                                                                                                          *
    '*                                                                                                                                                                 *
    '*                          CEDULA: 10907818                                                                                                                       *
    '*                                                                                                                                                                 *
    '*                          FECHA DE CREACION: 04/09/2019                                                                                                          *
    '*                                                                                                                                                                 *
    '*                          COPYRIGHT: GRACE & JOY S.A. DE C.V.                                                                                                    *
    '*                                                                                                                                                                 *
    '*                          DERECHOS INTELECTUALES: ING. LUIS ALBERTO VELARDE MERINO                                                                               *
    '*                                                                                                                                                                 *
    '*                          CONTACTO: lavsystem@outlook.com                                                                                                        *
    '*                                                                                                                                                                 *
    '*******************************************************************************************************************************************************************

#Region "VARIABLES FORMULARIO"

    Dim actualiza As Integer = 0

#End Region

#Region "FORMULARIO"

    Private Sub frmMdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        tsMenu.CheckForIllegalCrossThreadCalls = False

        dtJornada.Columns.Add("Semana", GetType(Integer))
        dtJornada.Columns.Add("Dia", GetType(String))
        dtJornada.Columns.Add("Entrada", GetType(String))
        dtJornada.Columns.Add("Salida", GetType(String))
        dtJornada.Columns.Add("Descanso", GetType(Double))

        If Not Login() Then

            Me.Close()

        End If

    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick

        If actualiza = 300 Then

            tslHora.Text = Date.Now.ToLongTimeString

            If Not bgwActualizar.IsBusy Then
                bgwActualizar.RunWorkerAsync()
            End If

            actualiza = 0

        Else

            tslHora.Text = Date.Now.ToLongTimeString

        End If

    End Sub

    Private Sub bgwActualizar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwActualizar.DoWork

        tslActualizando.Visible = True
        EnviaEventos()

    End Sub

    Private Sub bgwActualizar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwActualizar.RunWorkerCompleted

        tslActualizando.Visible = False
        dtEventos.Clear()

    End Sub

#End Region

#Region "FUNCIONES"

    Private Function Login() As Boolean

        Dim frmLogin As New frmLogin()

        frmLogin.ShowDialog()

        If frmLogin.DialogResult = Windows.Forms.DialogResult.OK Then

            Login = True

        Else

            Login = False

        End If

    End Function

    Private Sub Sucursales()

        Dim cnObj As New MySqlConnection
        cnObj = Conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        strSql = "SELECT "
        strSql += "* "
        strSql += "FROM "
        strSql += "sucursal "
        strSql += "WHERE "
        strSql += "estatus = 1"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        rdrObj.Read()
        If rdrObj.HasRows = True Then
            bMuestraVentanaOficinas = True
        Else
            bMuestraVentanaOficinas = False
        End If

    End Sub

    'Funcion para Enviar los Eventos Generados
    Private Sub EnviaEventos()

        Dim folioEvento As Integer
        Dim dtEventos As DataTable = New DataTable("eventos")

        dtEventos.Columns.Add("idEvento")
        dtEventos.Columns.Add("idNube")

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cnOtr As New MySqlConnection
        cnOtr = ConectarEve()

        If Not cnObj Is Nothing And Not cnOtr Is Nothing Then

            Dim cmdOtr As New MySqlCommand
            cmdOtr.Connection = cnOtr

            Dim myTrans As MySqlTransaction
            myTrans = cnObj.BeginTransaction

            Dim myOtrTrans As MySqlTransaction
            myOtrTrans = cnOtr.BeginTransaction

            Dim cmdObj As New MySqlCommand
            cmdObj.Connection = cnObj

            cmdObj.Transaction = myTrans
            cmdOtr.Transaction = myOtrTrans

            Dim strSql As String
            Dim strOtr As String

            strSql = "SELECT "
            strSql += "id_evento, "
            strSql += "id_sucursal, "
            strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha, "
            strSql += "evento "
            strSql += "FROM "
            strSql += "eventos "
            strSql += "WHERE "
            strSql += "evento_nube IS NULL "
            strSql += "ORDER BY id_evento ASC"

            cmdObj.CommandText = strSql
            Dim rdrObj As MySqlDataReader
            rdrObj = cmdObj.ExecuteReader


            strOtr = "SELECT "
            strOtr += "IFNULL(MAX(id_evento), 0) + 1 AS id_evento "
            strOtr += "FROM "
            strOtr += "eventos"

            cmdOtr.CommandText = strOtr
            Dim rdrOtr As MySqlDataReader
            rdrOtr = cmdOtr.ExecuteReader

            While rdrOtr.Read
                folioEvento = rdrOtr.Item("id_evento")
            End While

            rdrOtr.Close()

            While rdrObj.Read

                strOtr = "INSERT "
                strOtr += "INTO "
                strOtr += "eventos "
                strOtr += "(id_evento, "
                strOtr += "id_sucursal, "
                strOtr += "fecha, "
                strOtr += "evento) "
                strOtr += "VALUES "
                strOtr += "('" & folioEvento & "', "
                strOtr += "'" & rdrObj.Item("id_sucursal") & "', "
                strOtr += "'" & rdrObj.Item("fecha") & "', "
                strOtr += "'" & rdrObj.Item("evento") & "')"

                cmdOtr.CommandText = strOtr

                Try
                    cmdOtr.ExecuteNonQuery()

                    Dim newRow As DataRow = dtEventos.NewRow()

                    newRow("idEvento") = rdrObj.Item("id_evento")
                    newRow("idNube") = folioEvento

                    dtEventos.Rows.Add(newRow)

                Catch ex As Exception
                    rdrObj.Close()
                    myOtrTrans.Rollback()
                    Exit Sub
                End Try

                folioEvento += 1

            End While

            rdrObj.Close()

            If dtEventos.Rows.Count > 0 Then

                For Each dRow As DataRow In dtEventos.Rows

                    strSql = "UPDATE "
                    strSql += "eventos "
                    strSql += "SET "
                    strSql += "evento_nube = '" & dRow("idNube") & "' "
                    strSql += "WHERE "
                    strSql += "id_evento = '" & dRow("idEvento") & "'"

                    cmdObj.CommandText = strSql

                    Try
                        cmdObj.ExecuteNonQuery()
                    Catch ex As Exception
                        myTrans.Rollback()
                        myOtrTrans.Rollback()
                        Exit Sub
                    End Try

                Next

            End If

            myOtrTrans.Commit()
            myTrans.Commit()

            cnObj.Close()
            cnOtr.Close()

        End If

    End Sub

    'Funcion para Recibe los Eventos Generados
    Private Sub RecibeEventos()

        Dim UltimoEventoRecibido As Integer

        Dim cnObj As New MySqlConnection
        cnObj = ConectarEve()

        Dim cnOtr As MySqlConnection
        cnOtr = conectar()

        If Not cnObj Is Nothing And Not cnOtr Is Nothing Then

            Dim cmdObj As New MySqlCommand
            cmdObj.Connection = cnObj

            Dim cmdOtr As New MySqlCommand
            cmdOtr.Connection = cnOtr

            Dim strSql As String
            Dim strOtr As String

            strOtr = "SELECT "
            strOtr += "ultimo "
            strOtr += "FROM "
            strOtr += "ultimo_evento"

            cmdOtr.CommandText = strOtr
            Dim rdrOtr As MySqlDataReader
            rdrOtr = cmdOtr.ExecuteReader

            While rdrOtr.Read
                UltimoEventoRecibido = rdrOtr.Item("ultimo")
            End While

            rdrOtr.Close()

            strSql = "SELECT "
            strSql += "id_evento, "
            strSql += "id_sucursal, "
            strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha, "
            strSql += "evento "
            strSql += "FROM "
            strSql += "eventos "
            strSql += "WHERE "
            strSql += "(suc_destino = 0 OR suc_destino = '" & intSucursal & "') AND "
            strSql += "id_sucursal <> '" & intSucursal & "' AND "
            strSql += "id_evento > '" & UltimoEventoRecibido & "'"

            cmdObj.CommandText = strSql
            Dim rdrObj As MySqlDataReader
            rdrObj = cmdObj.ExecuteReader

            If rdrObj.HasRows = True Then

                While rdrObj.Read

                    strOtr = rdrObj.Item("evento")
                    strOtr = Replace(strOtr, "*", "'")

                    cmdOtr.CommandText = strOtr

                    Try

                        cmdOtr.ExecuteNonQuery()

                        strOtr = "INSERT "
                        strOtr += "INTO "
                        strOtr += "eventos_recibidos "
                        strOtr += "(id_sucursal, "
                        strOtr += "fecha, "
                        strOtr += "evento, "
                        strOtr += "evento_nube) "
                        strOtr += "VALUES "
                        strOtr += "('" & rdrObj.Item("id_sucursal") & "', "
                        strOtr += "'" & rdrObj.Item("fecha") & "', "
                        strOtr += "'" & rdrObj.Item("evento") & "', "
                        strOtr += "'" & rdrObj.Item("id_evento") & "') "

                        cmdOtr.CommandText = strOtr

                        Try
                            cmdOtr.ExecuteNonQuery()

                            strOtr = "UPDATE "
                            strOtr += "ultimo_evento "
                            strOtr += "SET "
                            strOtr += "ultimo = '" & rdrObj.Item("id_evento") & "'"

                            cmdOtr.CommandText = strOtr

                            Try
                                cmdOtr.ExecuteNonQuery()
                            Catch ex As Exception

                            End Try

                        Catch ex As Exception

                        End Try

                    Catch ex As Exception

                        Dim strError As String = ex.Message.ToString

                        strOtr = "INSERT "
                        strOtr += "INTO "
                        strOtr += "eventos_error "
                        strOtr += "(id_sucursal, "
                        strOtr += "fecha, "
                        strOtr += "evento, "
                        strOtr += "evento_nube, "
                        strOtr += "error) "
                        strOtr += "VALUES "
                        strOtr += "('" & rdrObj.Item("id_sucursal") & "', "
                        strOtr += "'" & rdrObj.Item("fecha") & "', "
                        strOtr += "'" & rdrObj.Item("evento") & "', "
                        strOtr += "'" & rdrObj.Item("id_evento") & "', "
                        strOtr += "'" & strError & "')"

                        cmdOtr.CommandText = strOtr

                        Try
                            cmdOtr.ExecuteNonQuery()

                            strOtr = "UPDATE "
                            strOtr += "ultimo_evento "
                            strOtr += "SET "
                            strOtr += "ultimo = '" & rdrObj.Item("id_evento") & "'"

                            cmdOtr.CommandText = strOtr

                            cmdOtr.ExecuteNonQuery()

                        Finally

                        End Try

                    End Try

                End While

            End If

        End If

        cnOtr.Close()
        cnObj.Close()

    End Sub

#End Region

#Region "MODULOS"

    Private Sub PlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantillaToolStripMenuItem.Click

        Dim frmPlantilla = New frmPlantilla()
        frmPlantilla.MdiParent = Me
        frmPlantilla.Show()

    End Sub

    Private Sub tsmiEmpleadosAltas_Click(sender As Object, e As EventArgs) Handles tsmiEmpleadosAltas.Click

        Dim frmEmpleados = New frmEmpleados()
        frmEmpleados.Estatus = 1
        frmEmpleados.MdiParent = Me
        frmEmpleados.Show()

    End Sub

    Private Sub tsmiEmpleadosBajas_Click(sender As Object, e As EventArgs) Handles tsmiEmpleadosBajas.Click

        Dim frmEmpleados As New frmEmpleados()
        frmEmpleados.ShowDialog()

    End Sub

    Private Sub tsmiModificarDia_Click(sender As Object, e As EventArgs) Handles tsmiModificarDia.Click

        Dim frmModificarDia = New frmModificarDia()
        frmModificarDia.ShowDialog()

    End Sub

    Private Sub tsmiCatalogosSucursales_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosSucursales.Click

        Dim frmSucursales = New frmSucursales()
        frmSucursales.MdiParent = Me
        frmSucursales.Show()

    End Sub

    Private Sub tsmiCatalogosDepartamentos_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosDepartamentos.Click

        Dim frmDepartamentos = New frmDepartamentos()
        frmDepartamentos.MdiParent = Me
        frmDepartamentos.Show()

    End Sub

    Private Sub tsmiCatalogosArea_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosArea.Click

        Dim frmArea = New frmArea()
        frmArea.MdiParent = Me
        frmArea.Show()

    End Sub

    Private Sub tsmiAutorizarPermiso_Click(sender As Object, e As EventArgs) Handles tsmiAutorizarPermiso.Click

        Dim frmPermiso = New frmPermiso()
        frmPermiso.MdiParent = Me
        frmPermiso.Show()

    End Sub

    Private Sub tsmiAutorizarFalta_Click(sender As Object, e As EventArgs) Handles tsmiAutorizarFalta.Click

        Dim frmFalta = New frmFalta()
        frmFalta.MdiParent = Me
        frmFalta.Show()

    End Sub

    Private Sub tsmiPermisoPersonal_Click(sender As Object, e As EventArgs) Handles tsmiPermisoPersonal.Click

        Dim frmPermisoPersonal = New frmPermisoPersonal()
        frmPermisoPersonal.MdiParent = Me
        frmPermisoPersonal.Show()

    End Sub

    Private Sub tsmiCambioDescanso_Click(sender As Object, e As EventArgs) Handles tsmiCambioDescanso.Click

        Dim frmCambioDescanso = New frmCambioDescanso()
        frmCambioDescanso.MdiParent = Me
        frmCambioDescanso.Show()

    End Sub

    Private Sub tsmiVacaciones_Click(sender As Object, e As EventArgs) Handles tsmiVacaciones.Click


        Dim frmVacaciones = New frmVacaciones()
        frmVacaciones.MdiParent = Me
        frmVacaciones.Show()

    End Sub

    Private Sub tsmiJornadaEmpleado_Click(sender As Object, e As EventArgs) Handles tsmiJornadaEmpleado.Click

        Dim frmJornadaEmpleado = New frmJornadaEmpleado()
        frmJornadaEmpleado.MdiParent = Me
        frmJornadaEmpleado.Show()

    End Sub

    Private Sub tsmiDiasFestivos_Click(sender As Object, e As EventArgs) Handles tsmiDiasFestivos.Click

        Dim frmDiaFestivo = New frmDiaFestivo()
        frmDiaFestivo.MdiParent = Me
        frmDiaFestivo.Show()

    End Sub

    Private Sub tsmiCatalogoUsuarios_Click(sender As Object, e As EventArgs) Handles tsmiCatalogoUsuarios.Click

        Dim frmUsuarios = New frmUsuarios()
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()

    End Sub

    Private Sub tsmiTiempoEmpleado_Click(sender As Object, e As EventArgs) Handles tsmiTiempoEmpleado.Click

        Dim frmTiempo = New frmTiempo()
        frmTiempo.MdiParent = Me
        frmTiempo.Show()

    End Sub

    Private Sub tsmiReportesAsistencia_Click(sender As Object, e As EventArgs) Handles tsmiReportesAsistencia.Click

        Dim frmAsistencia = New frmAsistencia()
        frmAsistencia.MdiParent = Me
        frmAsistencia.Show()

    End Sub

    Private Sub tsmiRevisarErrores_Click(sender As Object, e As EventArgs) Handles tsmiRevisarErrores.Click

        Dim frmErrores = New frmErrores()
        frmErrores.MdiParent = Me
        frmErrores.Show()

    End Sub

    Private Sub tsmiJornadaModificar_Click(sender As Object, e As EventArgs) Handles tsmiJornadaModificar.Click

        Dim frmModJornada = New frmModJornada()
        frmModJornada.MdiParent = Me
        frmModJornada.Show()

    End Sub

    Private Sub tsmiEliminaIncidencia_Click(sender As Object, e As EventArgs) Handles tsmiEliminaIncidencia.Click

        Dim frmEliminaIncidencia = New frmEliminaIncidencia()
        frmEliminaIncidencia.MdiParent = Me
        frmEliminaIncidencia.Show()

    End Sub

    Private Sub tsmiJornadaActualizar_Click(sender As Object, e As EventArgs) Handles tsmiJornadaActualizar.Click

        Dim frmEliminarJornada = New frmEliminarJornada()
        frmEliminarJornada.MdiParent = Me
        frmEliminarJornada.Show()

    End Sub

#End Region

End Class
