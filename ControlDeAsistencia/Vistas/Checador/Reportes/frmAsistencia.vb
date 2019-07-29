Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Math

Public Class frmAsistencia

    Dim mes, anio, falta As Integer
    Dim entrada, salida, fechaCambio As String
    Dim TotTiempoFavor, TotTiempoContra, TotFaltas, TotalRetardos, numRetardos, numRetComida, TotMesAnt, TotMes, Tipo As Integer

    Private Sub frmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()
        Sucursales()
        Empleados()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        TotTiempoFavor = 0
        TotTiempoContra = 0
        TotFaltas = 0
        TotalRetardos = 0
        numRetardos = 0
        numRetComida = 0
        TotMesAnt = 0
        TotMes = 0
        Tipo = 0
        entrada = ""
        salida = ""
        fechaCambio = ""

        lblRetardoComida.Text = ""
        lblRetardos.Text = ""
        lblTiempoFavor.Text = ""
        lblTiempoContra.Text = ""
        lblMesAnterior.Text = ""
        lblTotalMes.Text = ""

        ObtieneRegistros()
        ObtieneJornada()
        TiempoComida()
        CambioDescanso()
        Tiempos()

    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click

        Imprime()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgJornada.Cols.Count = 15
        fgJornada.Rows.Count = 1

        fgJornada.Cols(0).Caption = "CLAVE"
        fgJornada.Cols(0).Visible = False
        fgJornada.Cols(1).Caption = "FECHA"
        fgJornada.Cols(1).DataType = GetType(Date)
        fgJornada.Cols(2).Caption = "DIA"
        fgJornada.Cols(2).DataType = GetType(String)
        fgJornada.Cols(3).Caption = "ENTRADA JORNADA"
        fgJornada.Cols(3).DataType = GetType(String)
        fgJornada.Cols(4).Caption = "REGISTRO DE ENTRADA"
        fgJornada.Cols(4).DataType = GetType(String)
        fgJornada.Cols(5).Caption = "REGISTRO SAL. COMIDA"
        fgJornada.Cols(5).DataType = GetType(String)
        fgJornada.Cols(6).Caption = "REGISTRO ENT. COMIDA"
        fgJornada.Cols(6).DataType = GetType(String)
        fgJornada.Cols(7).Caption = "REGISTRO SALIDA"
        fgJornada.Cols(7).DataType = GetType(String)
        fgJornada.Cols(8).Caption = "SALIDA JORNADA"
        fgJornada.Cols(8).DataType = GetType(String)
        fgJornada.Cols(9).Caption = "TIEMPO DE COMIDA"
        fgJornada.Cols(9).DataType = GetType(String)
        fgJornada.Cols(10).Caption = "ENTRADA TARDE"
        fgJornada.Cols(10).DataType = GetType(String)
        fgJornada.Cols(11).Caption = "ENTRADA TEMPRANO"
        fgJornada.Cols(11).DataType = GetType(String)
        fgJornada.Cols(12).Caption = "SALIDA TARDE"
        fgJornada.Cols(12).DataType = GetType(String)
        fgJornada.Cols(13).Caption = "SALIDA TEMPRANO"
        fgJornada.Cols(13).DataType = GetType(String)
        fgJornada.Cols(14).Caption = "CONCEPTO"
        fgJornada.Cols(14).DataType = GetType(String)

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

    Private Sub ObtieneRegistros()

        Dim intFaltas, intTiempoFavor, intTiempoContra, TiempoMesAnterior, ClaveEmp, Cuenta As Integer
        Dim DiaConsecutivo As DateTime
        Dim FechaIni, FechaFin As Date

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim rdrObj As MySqlDataReader

        Dim strSql As String

        intFaltas = 0
        intTiempoFavor = 0
        intTiempoContra = 0
        TiempoMesAnterior = 0
        Cuenta = 1

        FechaIni = Format(dtpFechaIni.Value, "yyyy-MM-dd")
        FechaFin = Format(dtpFechaFin.Value, "yyyy-MM-dd")
        ClaveEmp = cmbEmpleado.SelectedValue

        Configura()

        mes = Format(dtpFechaIni.Value, "MM")
        anio = Format(dtpFechaIni.Value, "yyyy")
        DiaConsecutivo = FechaIni

        'Variables para Obtener el tiempo a Favor o en Contra del mes Anterior, si el mes es 1 (ENERO) se le resta al Año 1 para que sea de Diciembre del Año pasado y 
        'el Mes se Coloca En el mes 12

        If mes = 1 Then
            mes = 12
            anio -= 1
        Else
            mes -= 1
        End If

        While (DiaConsecutivo <= FechaFin)

            fgJornada.AddItem("")

            'Clave del Empleado
            fgJornada.SetData(fgJornada.Rows.Count - 1, 0, cmbEmpleado.SelectedValue)
            'Fecha
            fgJornada.SetData(fgJornada.Rows.Count - 1, 1, DiaConsecutivo)
            'Dia de la Semana
            fgJornada.SetData(fgJornada.Rows.Count - 1, 2, UCase(Format(DiaConsecutivo, "dddd")))

            strSql = "SELECT "
            strSql += "reg_entrada, "
            strSql += "reg_sal_comida, "
            strSql += "reg_ent_comida, "
            strSql += "reg_salida "
            strSql += "FROM "
            strSql += "registro "
            strSql += "WHERE "
            strSql += "clave = '" & ClaveEmp & "' AND "
            strSql += "fecha = '" & Format(DiaConsecutivo, "yyyyMMdd") & "'"

            cmdObj.CommandText = strSql
            rdrObj = cmdObj.ExecuteReader

            'Si hay registros del empleado del dia actual
            If rdrObj.HasRows = True Then

                While rdrObj.Read

                    'Registro de la Entrada a la Sucursal
                    fgJornada.SetData(fgJornada.Rows.Count - 1, 4, rdrObj(0).ToString)

                    'Registro de la Salida a Comer
                    If rdrObj.Item("reg_sal_comida") Is DBNull.Value Then

                        Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                        crRegistro = fgJornada.GetCellRange(Cuenta, 5)
                        crRegistro.Style = fgJornada.Styles("CustomStyle2")

                        fgJornada.SetData(fgJornada.Rows.Count - 1, 5, "")
                    Else

                        If rdrObj(1).ToString <> "00:00:00" Then
                            fgJornada.SetData(fgJornada.Rows.Count - 1, 5, rdrObj(1).ToString)
                        End If

                    End If

                    'Registro del Regreso de Comida
                    If rdrObj.Item("reg_ent_comida") Is DBNull.Value Then

                        Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                        crRegistro = fgJornada.GetCellRange(Cuenta, 6)
                        crRegistro.Style = fgJornada.Styles("CustomStyle2")

                        fgJornada.SetData(fgJornada.Rows.Count - 1, 6, "")
                    Else

                        If rdrObj(2).ToString <> "00:00:00" Then
                            fgJornada.SetData(fgJornada.Rows.Count - 1, 6, rdrObj(2).ToString)
                        End If

                    End If

                    'Registro de la Salida del Colaborador de la Sucursal
                    If rdrObj.Item("reg_salida") Is DBNull.Value Then

                        Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                        crRegistro = fgJornada.GetCellRange(Cuenta, 7)
                        crRegistro.Style = fgJornada.Styles("CustomStyle2")

                        fgJornada.SetData(fgJornada.Rows.Count - 1, 7, "")
                    Else
                        If rdrObj(3).ToString <> "00:00:00" Then
                            fgJornada.SetData(fgJornada.Rows.Count - 1, 7, rdrObj(3).ToString)
                        End If

                    End If

                End While

            Else

                If UCase(Format(DiaConsecutivo, "dddd")) = "DOMINGO" Then

                    fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "DESCANSO")

                Else

                    'Revisa si hay alguna alguna incidencia
                    If Incidencias(ClaveEmp, Format(DiaConsecutivo, "yyyyMMdd")) <> "" Then

                        Select Case Incidencias(ClaveEmp, Format(DiaConsecutivo, "yyyyMMdd"))

                            Case "FALTA"
                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "FALTA")

                                Dim crRegistro As New C1.Win.C1FlexGrid.CellRange

                                crRegistro = fgJornada.GetCellRange(Cuenta, 4)
                                crRegistro.Style = fgJornada.Styles("CustomStyle1")

                                crRegistro = fgJornada.GetCellRange(Cuenta, 5)
                                crRegistro.Style = fgJornada.Styles("CustomStyle1")

                                crRegistro = fgJornada.GetCellRange(Cuenta, 6)
                                crRegistro.Style = fgJornada.Styles("CustomStyle1")

                                crRegistro = fgJornada.GetCellRange(Cuenta, 7)
                                crRegistro.Style = fgJornada.Styles("CustomStyle1")

                                intFaltas += 1

                            Case "ENTRADA TEMPRANO"
                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "ENTRADA TEMPRANO")

                            Case "ENTRADA TARDE"
                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "ENTRADA TARDE")

                            Case "SALIDA TEMPRANO"

                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "SALIDA TEMPRANO")

                            Case "SALIDA TARDE"
                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "SALIDA TARDE")

                            Case "CAMBIO DESCANSO"
                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "CAMBIO DESCANSO")

                        End Select

                    Else

                        'Revisamos si es dia de Vacaciones
                        If Vacaciones(ClaveEmp, Format(DiaConsecutivo, "yyyyMMdd")) <> "" Then

                            fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "VACACIONES")

                        Else

                            If Festivo(Format(DiaConsecutivo, "yyyyMMdd")) <> "" Then

                                fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "DIA FESTIVO")

                            Else

                                If Descanso(ClaveEmp, Format(DiaConsecutivo, "yyyyMMdd")) <> "" Then

                                    fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "DESCANSO")

                                Else

                                    fgJornada.SetData(fgJornada.Rows.Count - 1, 14, "SIN REGISTRO")

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange

                                    crRegistro = fgJornada.GetCellRange(Cuenta, 4)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle2")

                                    crRegistro = fgJornada.GetCellRange(Cuenta, 5)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle2")

                                    crRegistro = fgJornada.GetCellRange(Cuenta, 6)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle2")

                                    crRegistro = fgJornada.GetCellRange(Cuenta, 7)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle2")

                                End If

                            End If

                        End If

                    End If


                End If

            End If

            rdrObj.Close()

            DiaConsecutivo = FechaIni.AddDays(Cuenta)
            Cuenta += 1

        End While

        fgJornada.AutoSizeCols()

    End Sub

    Private Sub CambioDescanso()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim rdrObj As MySqlDataReader

        Dim strSql As String

        Dim cnOtr As New MySqlConnection
        cnOtr = conectar()

        Dim cmdOtr As New MySqlCommand
        cmdOtr.Connection = cnOtr

        Dim rdrOtr As MySqlDataReader

        Dim strOtr As String

        'DIA QUE VA A TRABAJAR
        For i As Integer = 1 To fgJornada.Rows.Count - 1

            strSql = "SELECT "
            strSql += "DATE_FORMAT(fecha_cambio, '%Y-%m-%d') AS fechaCambio "
            strSql += "FROM "
            strSql += "incidencias "
            strSql += "WHERE "
            strSql += "fecha = '" & Format(fgJornada.GetData(i, 1), "yyyyMMdd") & "' AND "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "tipo = 'CAMBIO DESCANSO'"

            cmdObj.CommandText = strSql
            rdrObj = cmdObj.ExecuteReader

            If rdrObj.HasRows = True Then

                While rdrObj.Read

                    strOtr = "SELECT "
                    strOtr += "entrada, "
                    strOtr += "salida "
                    strOtr += "FROM "
                    strOtr += "jornada_empleado "
                    strOtr += "WHERE "
                    strOtr += "fecha = '" & rdrObj.Item("fechaCambio") & "' AND "
                    strOtr += "clave = '" & cmbEmpleado.SelectedValue & "'"

                    cmdOtr.CommandText = strOtr
                    rdrOtr = cmdOtr.ExecuteReader

                    While rdrOtr.Read

                        fgJornada.SetData(i, 3, rdrOtr(0).ToString)
                        fgJornada.SetData(i, 8, rdrOtr(1).ToString)

                    End While

                    rdrOtr.Close()

                End While
              
            End If

            rdrObj.Close()

        Next

        'DIA QUE VA A DESCANSAR
        For i As Integer = 1 To fgJornada.Rows.Count - 1

            strSql = "SELECT "
            strSql += "DATE_FORMAT(fecha, '%Y-%m-%d') AS fecha "
            strSql += "FROM "
            strSql += "incidencias "
            strSql += "WHERE "
            strSql += "fecha_cambio = '" & Format(fgJornada.GetData(i, 1), "yyyyMMdd") & "' AND "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "tipo = 'CAMBIO DESCANSO'"

            cmdObj.CommandText = strSql
            rdrObj = cmdObj.ExecuteReader

            If rdrObj.HasRows = True Then

                fgJornada.SetData(i, 14, "DESCANSO")

            End If

            rdrObj.Close()

        Next

    End Sub

    Private Sub ObtieneJornada()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim rdrObj As MySqlDataReader

        Dim strSql As String

        For i As Integer = 1 To fgJornada.Rows.Count - 1

            strSql = "SELECT "
            strSql += "entrada, "
            strSql += "salida "
            strSql += "FROM "
            strSql += "jornada_empleado "
            strSql += "WHERE "
            strSql += "clave = '" & fgJornada.GetData(i, 0) & "' AND "
            strSql += "fecha = '" & Format(fgJornada.GetData(i, 1), "yyyyMMdd") & "'"

            cmdObj.CommandText = strSql
            rdrObj = cmdObj.ExecuteReader

            While rdrObj.Read

                fgJornada.SetData(i, 3, rdrObj(0).ToString)
                fgJornada.SetData(i, 8, rdrObj(1).ToString)

            End While

            rdrObj.Close()

        Next

        cnObj.Close()

    End Sub

    Private Sub TiempoComida()

        Dim DifComida As Integer

        For i As Integer = 1 To fgJornada.Rows.Count - 1

            If fgJornada.GetData(i, 5) <> "" And fgJornada.GetData(i, 6) <> "" Then

                DifComida = DateDiff("n", fgJornada.GetData(i, 5), fgJornada.GetData(i, 6))

                If DifComida < 60 Then

                    fgJornada.SetData(i, 9, "00:" & CStr(DifComida))

                ElseIf DifComida = 60 Then

                    fgJornada.SetData(i, 9, "01:00")

                Else

                    Dim HoraCom, MinCom As Integer
                    Dim TotalCom As String

                    HoraCom = Truncate(DifComida / 60)
                    MinCom = DifComida Mod 60

                    If HoraCom < 10 Then
                        TotalCom = "0" & CStr(HoraCom)
                    Else
                        TotalCom = CStr(HoraCom)
                    End If

                    If MinCom < 10 Then
                        TotalCom = TotalCom & ":0" & CStr(MinCom)
                    Else
                        TotalCom = TotalCom & ":" & CStr(MinCom)
                    End If

                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                    crRegistro = fgJornada.GetCellRange(i, 9)
                    crRegistro.Style = fgJornada.Styles("CustomStyle3")

                    fgJornada.SetData(i, 9, TotalCom)

                    TotTiempoContra += (DifComida - 60)
                    numRetComida += 1

                End If

            End If

        Next

    End Sub

    Private Function Incidencias(ByVal Clave As Integer, ByVal Fecha As String) As String

        Dim Valor As String = ""

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "tipo, "
        strSql += "entrada, "
        strSql += "salida, "
        strSql += "fecha_cambio, "
        strSql += "falta "
        strSql += "FROM "
        strSql += "incidencias "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha = '" & Fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then

            While rdrObj.Read

                Valor = rdrObj(0).ToString
                If rdrObj.Item("entrada") Is DBNull.Value Then
                    entrada = ""
                Else
                    entrada = rdrObj(1).ToString
                End If

                If rdrObj.Item("salida") Is DBNull.Value Then
                    salida = ""
                Else
                    salida = rdrObj(2).ToString
                End If

                If rdrObj.Item("fecha_cambio") Is DBNull.Value Then
                    fechaCambio = ""
                Else
                    fechaCambio = rdrObj(3).ToString
                End If

            End While

        Else

            Valor = ""

        End If

        rdrObj.Close()
        cnObj.Close()

        Return Valor

    End Function

    Private Function Vacaciones(ByVal Clave As Integer, ByVal Fecha As String) As String

        Dim Valor As String = ""

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "clave, "
        strSql += "fecha "
        strSql += "FROM "
        strSql += "vacaciones "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha = '" & Fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            Valor = "VACACIONES"
        Else
            Valor = ""
        End If

        rdrObj.Close()
        cnObj.Close()

        Return Valor

    End Function

    Private Function Festivo(ByVal Fecha As String) As String

        Dim Valor As String = ""

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "fecha, "
        strSql += "descripcion "
        strSql += "FROM "
        strSql += "festivo "
        strSql += "WHERE "
        strSql += "fecha = '" & Fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            Valor = "VACACIONES"
        Else
            Valor = ""
        End If

        rdrObj.Close()
        cnObj.Close()

        Return Valor

    End Function

    Private Function Descanso(ByVal Clave As Integer, ByVal Fecha As String) As String

        Dim Valor As String = ""

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "descanso "
        strSql += "FROM "
        strSql += "jornada_empleado "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha = '" & Fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then

            While rdrObj.Read

                If rdrObj.Item("descanso") = 1 Then
                    Valor = "DESCANSO"
                Else
                    Valor = ""
                End If

            End While

        Else

            Valor = ""

        End If

        rdrObj.Close()
        cnObj.Close()

        Return Valor

    End Function

    Private Sub Tiempos()

        Dim difTiempoFavor, difTiempoContra As Integer

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim rdrObj As MySqlDataReader

        Dim strSql As String

        For i As Integer = 1 To fgJornada.Rows.Count - 1

            difTiempoFavor = 0
            difTiempoContra = 0

            If UCase(Format(fgJornada.GetData(i, 1), "dddd")) <> "DOMINGO" Then

                strSql = "SELECT "
                strSql += "tipo, "
                strSql += "entrada, "
                strSql += "salida, "
                strSql += "fecha_cambio, "
                strSql += "falta "
                strSql += "FROM "
                strSql += "incidencias "
                strSql += "WHERE "
                strSql += "clave = '" & fgJornada.GetData(i, 0) & "' AND "
                strSql += "fecha = '" & Format(fgJornada.GetData(i, 1), "yyyyMMdd") & "'"

                cmdObj.CommandText = strSql
                rdrObj = cmdObj.ExecuteReader

                If rdrObj.HasRows = True Then

                    While rdrObj.Read

                        Dim TiempoTemp As Integer = 0

                        Select Case rdrObj.Item("tipo")

                            Case "ENTRADA TEMPRANO"

                                If rdrObj.Item("entrada") Is DBNull.Value Then
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 4), fgJornada.GetData(i, 3))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 11)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle4")
                                    fgJornada.SetData(i, 11, TiempoTemp)

                                    difTiempoFavor += TiempoTemp

                                Else
                                    Dim Tiempo As DateTime
                                    Tiempo = rdrObj(1).ToString
                                    TiempoTemp = DateDiff("n", Tiempo, fgJornada.GetData(i, 3))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 11)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle4")
                                    fgJornada.SetData(i, 11, TiempoTemp)

                                    difTiempoFavor += TiempoTemp

                                End If

                            Case "SALIDA TARDE"

                                If rdrObj.Item("salida") Is DBNull.Value Then
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 7), fgJornada.GetData(i, 8))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 12)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle4")
                                    fgJornada.SetData(i, 12, TiempoTemp)

                                    difTiempoFavor += TiempoTemp

                                Else
                                    Dim Tiempo As DateTime
                                    Tiempo = rdrObj(2).ToString
                                    TiempoTemp = DateDiff("n", Tiempo, fgJornada.GetData(i, 8))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 12)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle4")
                                    fgJornada.SetData(i, 12, TiempoTemp)

                                    difTiempoFavor += TiempoTemp

                                End If

                            Case "ENTRADA TARDE"

                                If rdrObj.Item("entrada") Is DBNull.Value Then
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 3), fgJornada.GetData(i, 4))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 10)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                    fgJornada.SetData(i, 10, TiempoTemp)

                                    difTiempoContra += TiempoTemp

                                Else
                                    Dim Tiempo As DateTime
                                    Tiempo = rdrObj(1).ToString
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 3), Tiempo)

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 10)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                    fgJornada.SetData(i, 10, TiempoTemp)

                                    difTiempoContra += TiempoTemp

                                End If

                            Case "SALIDA TEMPRANO"

                                If rdrObj.Item("salida") Is DBNull.Value Then
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 8), fgJornada.GetData(i, 7))

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 13)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                    fgJornada.SetData(i, 13, TiempoTemp)

                                    difTiempoContra += TiempoTemp

                                Else

                                    Dim Tiempo As DateTime
                                    Tiempo = rdrObj(2).ToString
                                    TiempoTemp = DateDiff("n", fgJornada.GetData(i, 8), Tiempo)

                                    Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                    crRegistro = fgJornada.GetCellRange(i, 13)
                                    crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                    fgJornada.SetData(i, 13, TiempoTemp)

                                    difTiempoContra += TiempoTemp

                                End If

                            Case "FALTA"

                                TotFaltas += 1

                            Case Else



                        End Select

                    End While

                Else

                    Dim TiempoTemp As Integer = 0

                    If fgJornada.GetData(i, 3) <> "" And fgJornada.GetData(i, 8) <> "" Then

                        'Diferencia de tiempo en la entrada
                        If fgJornada.GetData(i, 3) <> "" And fgJornada.GetData(i, 4) <> "" Then

                            TiempoTemp = DateDiff("n", fgJornada.GetData(i, 3), fgJornada.GetData(i, 4))

                            If TiempoTemp > 0 Then

                                Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                crRegistro = fgJornada.GetCellRange(i, 4)
                                crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                fgJornada.SetData(i, 10, TiempoTemp)

                                difTiempoContra += TiempoTemp

                                numRetardos += 1

                            End If

                        End If

                        If fgJornada.GetData(i, 7) <> "" And fgJornada.GetData(i, 8) <> "" Then

                            TiempoTemp = DateDiff("n", fgJornada.GetData(i, 7), fgJornada.GetData(i, 8))

                            If TiempoTemp > 0 Then

                                Dim crRegistro As New C1.Win.C1FlexGrid.CellRange
                                crRegistro = fgJornada.GetCellRange(i, 7)
                                crRegistro.Style = fgJornada.Styles("CustomStyle5")
                                fgJornada.SetData(i, 13, TiempoTemp)

                                difTiempoContra += TiempoTemp

                            End If

                        End If

                    End If

                End If

                rdrObj.Close()

                    TotTiempoFavor += difTiempoFavor
                    TotTiempoContra += difTiempoContra

                    rdrObj.Close()

            End If

        Next

        If TotTiempoFavor > 0 Then
            lblTiempoFavor.Text = ConvierteNumeroHora(TotTiempoFavor)
            lblTiempoFavor.Visible = True
        Else
            lblTiempoFavor.Text = ""
            lblTiempoFavor.Visible = False
        End If

        If TotTiempoContra > 0 Then
            lblTiempoContra.Text = ConvierteNumeroHora(TotTiempoContra)
            lblTiempoContra.Visible = True
        Else
            lblTiempoContra.Text = ""
            lblTiempoContra.Visible = False
        End If

        If numRetComida > 0 Then
            lblRetardoComida.Text = ConvierteNumeroHora(numRetComida)
            lblRetardoComida.Visible = True
        Else
            lblRetardoComida.Text = ""
            lblRetardoComida.Visible = False
        End If

        If numRetardos > 0 Then
            lblRetardos.Text = ConvierteNumeroHora(numRetardos)
            lblRetardos.Visible = True
        Else
            lblRetardos.Text = ""
            lblRetardos.Visible = False
        End If

        strSql = "SELECT "
        strSql += "tiempo, "
        strSql += "tipo "
        strSql += "FROM "
        strSql += "tiempo "
        strSql += "WHERE "
        strSql += "mes = '" & mes & "' AND "
        strSql += "anio = '" & anio & "' AND "
        strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

        cmdObj.CommandText = strSql
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then

            While rdrObj.Read
                TotMesAnt = rdrObj.Item("tiempo")
                Tipo = rdrObj.Item("tipo")
            End While
        Else
            TotMesAnt = 0
            Tipo = 0
        End If

        If TotMesAnt > 0 Then

            If Tipo = 1 Then
                lblMesAnterior.Text = ConvierteNumeroHora(TotMesAnt)
                lblMesAnterior.Visible = True
            Else
                lblMesAnterior.Text = ConvierteNumeroHora(TotMesAnt)
                lblMesAnterior.Visible = True
                lblMesAnt.ForeColor = Color.Red
            End If

        End If

        If Tipo = 1 Then

            TotMes = TotTiempoFavor + TotMesAnt - TotTiempoContra

            If TotMes < 0 Then

                lblTotalMes.Text = ConvierteNumeroHora(Abs(TotMes))
                lblTotalMes.Visible = True
                lblTotalMes.ForeColor = Color.Red

            Else

                lblTotalMes.Text = ConvierteNumeroHora(TotMes)
                lblTotalMes.Visible = True

            End If

        Else

            TotMes = TotTiempoFavor - TotMesAnt - TotTiempoContra

            If TotMes < 0 Then

                lblTotalMes.Text = ConvierteNumeroHora(Abs(TotMes))
                lblTotalMes.Visible = True
                lblTotalMes.ForeColor = Color.Red

            Else

                lblTotalMes.Text = ConvierteNumeroHora(TotMes)
                lblTotalMes.Visible = True

            End If

        End If

    End Sub

    Private Function ConvierteNumeroHora(ByVal Numero As Integer) As String

        Dim Valor As String = ""

        Dim Hora, Minuto As Integer

        Hora = Truncate(Abs(Numero) / 60)
        Minuto = Abs(Numero) Mod 60

        If Hora < 10 Then
            Valor = "0" & CStr(Hora)
        Else
            Valor = CStr(Hora)
        End If

        If Minuto < 10 Then
            Valor = Valor & ":0" & CStr(Minuto)
        Else
            Valor = Valor & ":" & CStr(Minuto)
        End If

        Return Valor

    End Function

    Private Sub Imprime()

        pdReporte.Print()

    End Sub

    Private Sub pdReporte_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReporte.PrintPage

        Dim _Suc As Integer

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim rdrObj As MySqlDataReader

        Dim prFont As New Font("Arial", 12, FontStyle.Bold)

        'Imprime Logo
        Dim Imagen As Image = Image.FromFile("c:\checador\LOGOMARANATHA.png")

        e.Graphics.DrawImage(Imagen, 0, 0, 220, 180)

        'Imprime el tipo de documento
        e.Graphics.DrawString("REPORTE DE PUNTUALIDAD", prFont, Brushes.Black, 500, 50)

        strSql = "SELECT "
        strSql += "a_paterno, "
        strSql += "a_materno, "
        strSql += "nombre, "
        strSql += "id_sucursal "
        strSql += "FROM "
        strSql += "empleado "
        strSql += "WHERE "
        strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

        cmdObj.CommandText = strSql
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            prFont = New Font("Arial", 10, FontStyle.Bold)

            e.Graphics.DrawString("Empleado: " & rdrObj.Item("a_paterno") & " " & rdrObj.Item("a_materno") & " " & rdrObj.Item("nombre"), prFont, Brushes.Black, 240, 100)
            _Suc = rdrObj.Item("id_sucursal")

        End While

        rdrObj.Close()

        e.Graphics.DrawString("Periodo: " & Format(dtpFechaIni.Value, "dd/MM/yyyy") & " - " & Format(dtpFechaFin.Value, "dd/MM/yyyy"), prFont, Brushes.Black, 240, 120)

        strSql = "SELECT "
        strSql += "sucursal "
        strSql += "FROM "
        strSql += "sucursal "
        strSql += "WHERE "
        strSql += "id_sucursal = '" & _Suc & "'"

        cmdObj.CommandText = strSql
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            e.Graphics.DrawString("Sucursal: " & rdrObj.Item("sucursal"), prFont, Brushes.Black, 240, 140)

        End While

        rdrObj.Close()

        For i As Integer = 5 To 1080

            e.Graphics.DrawString("-", prFont, Brushes.Black, i, 160)
            i += 5

        Next

        Dim Salto As Integer = 180

        prFont = New Font("Arial", 7, FontStyle.Bold)
        e.Graphics.DrawString("FECHA", prFont, Brushes.Black, 14, Salto)
        e.Graphics.DrawString("DIA", prFont, Brushes.Black, 75, Salto)

        e.Graphics.DrawString("ENTRADA", prFont, Brushes.Black, 120, Salto)
        e.Graphics.DrawString("JORNADA", prFont, Brushes.Black, 120, Salto + 10)

        e.Graphics.DrawString("ENTRADA", prFont, Brushes.Black, 195, Salto)
        e.Graphics.DrawString("REGISTRADA", prFont, Brushes.Black, 195, Salto + 10)

        e.Graphics.DrawString("SALIDA", prFont, Brushes.Black, 260, Salto)
        e.Graphics.DrawString("COMIDA", prFont, Brushes.Black, 260, Salto + 10)

        e.Graphics.DrawString("ENTRADA", prFont, Brushes.Black, 315, Salto)
        e.Graphics.DrawString("COMIDA", prFont, Brushes.Black, 319, Salto + 10)

        e.Graphics.DrawString("SALIDA", prFont, Brushes.Black, 385, Salto)
        e.Graphics.DrawString("REGISTRADA", prFont, Brushes.Black, 385, Salto + 10)

        e.Graphics.DrawString("JORNADA", prFont, Brushes.Black, 380, Salto + 10)
        e.Graphics.DrawString("SALIDA", prFont, Brushes.Black, 450, Salto)

        e.Graphics.DrawString("COMIDA", prFont, Brushes.Black, 500, Salto)

        e.Graphics.DrawString("TIEMPO A", prFont, Brushes.Black, 550, Salto)
        e.Graphics.DrawString("FAVOR", prFont, Brushes.Black, 555, Salto + 10)

        e.Graphics.DrawString("TIEMPO EN", prFont, Brushes.Black, 610, Salto)
        e.Graphics.DrawString("CONTRA", prFont, Brushes.Black, 610, Salto + 10)

        e.Graphics.DrawString("CONCEPTO", prFont, Brushes.Black, 675, Salto)

        Salto += 30

        For i As Integer = 1 To fgJornada.Rows.Count - 1

            prFont = New Font("Arial", 7, FontStyle.Regular)

            'Fecha
            e.Graphics.DrawString(fgJornada.GetData(i, 1), prFont, Brushes.Black, 6, Salto)
            'Dia
            e.Graphics.DrawString(fgJornada.GetData(i, 2), prFont, Brushes.Black, 65, Salto)
            'Entrada Jornada
            e.Graphics.DrawString(fgJornada.GetData(i, 3), prFont, Brushes.Black, 122, Salto)

            'Entrada

            e.Graphics.DrawString(fgJornada.GetData(i, 4), prFont, Brushes.Black, 200, Salto)

            'Salida Comida
            e.Graphics.DrawString(fgJornada.GetData(i, 5), prFont, Brushes.Black, 260, Salto)

            'Entrada Comida
            e.Graphics.DrawString(fgJornada.GetData(i, 6), prFont, Brushes.Black, 320, Salto)

            'Salida Jornada
            e.Graphics.DrawString(fgJornada.GetData(i, 7), prFont, Brushes.Black, 380, Salto)

            'Salida
            e.Graphics.DrawString(fgJornada.GetData(i, 8), prFont, Brushes.Black, 450, Salto)

            'Tiempo de Comida

            e.Graphics.DrawString(fgJornada.GetData(i, 9), prFont, Brushes.Black, 510, Salto)

            'Tiempo A Favor
            e.Graphics.DrawString(fgJornada.GetData(i, 10), prFont, Brushes.Red, 570, Salto)

            'Tiempo En Contra

            e.Graphics.DrawString(fgJornada.GetData(i, 11), prFont, Brushes.Red, 630, Salto)

            Salto += 14

        Next

        Salto += 10

        For i As Integer = 5 To 1080

            e.Graphics.DrawString("-", prFont, Brushes.Black, i, Salto)
            i += 5

        Next

        'Retardo Comida
        If numRetComida > 0 Then
            e.Graphics.DrawString("RETARDOS COMIDA: ", prFont, Brushes.Black, 10, 670)
            e.Graphics.DrawString(numRetComida, prFont, Brushes.Green, 115, 670)
        Else
            e.Graphics.DrawString("RETARDOS COMIDA: ", prFont, Brushes.Black, 10, 670)
        End If


        'Tiempo a Favor
        If numRetardos > 0 Then
            e.Graphics.DrawString("RETARDOS: ", prFont, Brushes.Black, 10, 690)
            e.Graphics.DrawString(numRetardos, prFont, Brushes.Green, 115, 690)
        Else
            e.Graphics.DrawString("RETARDOS: ", prFont, Brushes.Black, 10, 690)
        End If


        'Tiempo en Contra
        If TotTiempoFavor > 0 Then
            e.Graphics.DrawString("TIEMPO A FAVOR: ", prFont, Brushes.Black, 10, 710)
            e.Graphics.DrawString(ConvierteNumeroHora(TotTiempoFavor), prFont, Brushes.Red, 115, 710)
        Else
            e.Graphics.DrawString("TIEMPO A FAVOR: ", prFont, Brushes.Black, 10, 710)
        End If

        'Retardos
        If TotTiempoContra > 0 Then
            e.Graphics.DrawString("TIEMPO EN CONTRA: ", prFont, Brushes.Black, 10, 730)
            e.Graphics.DrawString(ConvierteNumeroHora(TotTiempoContra), prFont, Brushes.Black, 115, 730)
        Else
            e.Graphics.DrawString("TIEMPO EN CONTRA: ", prFont, Brushes.Black, 10, 730)
        End If

        'Tiempo Mes Anterior
        If Tipo = 1 Then
            e.Graphics.DrawString("MES ANTERIOR: ", prFont, Brushes.Black, 10, 750)
            e.Graphics.DrawString(ConvierteNumeroHora(Abs(TotMesAnt)), prFont, Brushes.Green, 115, 750)
        Else
            e.Graphics.DrawString("MES ANTERIOR: ", prFont, Brushes.Black, 10, 750)
            e.Graphics.DrawString(ConvierteNumeroHora(Abs(TotMesAnt)), prFont, Brushes.Red, 115, 750)
        End If

        'Total del Mes
        If TotMes >= 0 Then
            e.Graphics.DrawString("TOTAL DEL MES ", prFont, Brushes.Black, 10, 770)
            e.Graphics.DrawString(ConvierteNumeroHora(Abs(TotMes)), prFont, Brushes.Green, 115, 770)
        Else
            e.Graphics.DrawString("TOTAL DEL MES ", prFont, Brushes.Black, 10, 770)
            e.Graphics.DrawString(ConvierteNumeroHora(Abs(TotMes)), prFont, Brushes.Red, 115, 770)
        End If


        strSql = "SELECT "
        strSql += "tiempo "
        strSql += "FROM "
        strSql += "tiempo "
        strSql += "WHERE "
        strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
        strSql += "mes = '" & Format(dtpFechaIni.Value, "MM") & "' AND "
        strSql += "anio = '" & Format(dtpFechaIni.Value, "yyyy") & "'"

        cmdObj.CommandText = strSql
        rdrObj = cmdObj.ExecuteReader

        Dim bExiste As Boolean

        If rdrObj.HasRows = True Then
            bExiste = True
        Else
            bExiste = False
        End If

        If bExiste = True Then

            strSql = "UPDATE "
            strSql += "tiempo "
            strSql += "SET "

            If TotMes >= 0 Then
                strSql += "tiempo = '" & TotMes & "' "
                strSql += "tipo = 1 "
            Else
                strSql += "tiempo = '" & Abs(TotMes) & "' "
                strSql += "tipo = 0 "
            End If

            strSql += "WHERE "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "mes = '" & Format(dtpFechaIni.Value, "MM") & "' AND "
            strSql += "anio = '" & Format(dtpFechaIni.Value, "yyyy") & "'"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception

            End Try

        Else

            strSql = "INSERT "
            strSql += "INTO "
            strSql += "tiempo "
            strSql += "(clave, "
            strSql += "mes, "
            strSql += "anio, "
            strSql += "tiempo, "
            strSql += "tipo) "
            strSql += "VALUES "
            strSql += "('" & cmbEmpleado.SelectedValue & "', "
            strSql += "'" & Format(dtpFechaIni.Value, "MM") & "', "
            strSql += "'" & Format(dtpFechaIni.Value, "yyyy") & "', "
            If TotMes >= 0 Then
                strSql += "'" & TotMes & "', "
                strSql += "1)"
            Else
                strSql += "'" & Abs(TotMes) & "', "
                strSql += "0)"
            End If

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception

            End Try

        End If

        For i As Integer = 205 To 410

            e.Graphics.DrawString("-", prFont, Brushes.Black, i, 770)
            i += 1

        Next

        e.Graphics.DrawString("FIRMA Y HUELLA DEL COLABORADOR", prFont, Brushes.Black, 220, 780)

        For i As Integer = 520 To 725

            e.Graphics.DrawString("-", prFont, Brushes.Black, i, 770)
            i += 1

        Next

        e.Graphics.DrawString("FIRMA Y HUELLA SUPERVISOR", prFont, Brushes.Black, 550, 780)

        For i As Integer = 835 To 1050

            e.Graphics.DrawString("-", prFont, Brushes.Black, i, 770)
            i += 1

        Next

        e.Graphics.DrawString("FIRMA Y HUELLA REVISO", prFont, Brushes.Black, 880, 780)

    End Sub

#End Region

End Class