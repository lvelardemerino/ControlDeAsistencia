Imports MySql.Data.MySqlClient
Imports System.Math

Public Class frmIncidencias

    Public Property fecha As Date
        Get
            fecha = _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Clave As Integer
        Get
            Clave = _Clave
        End Get
        Set(value As Integer)
            _Clave = value
        End Set
    End Property

#Region "VARIABLES DE LA CLASE"

    Private _fecha As Date
    Private primerDia, ultimoDia As Date
    Private Cuenta As Integer = 1
    Public _Clave As Integer
    Private TotTiempoFavor, TotTiempoContra As Integer

#End Region

    Private Sub frmIncidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

        primerDia = PrimerDiaDelMes(fecha)
        ultimoDia = UltimoDiaDelMes(fecha)

        LlenaGrid()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgTfavor.Cols.Count = 4
        fgTfavor.Rows.Count = 1

        fgTfavor.Cols(0).Caption = "FECHA"
        fgTfavor.Cols(0).DataType = GetType(Date)
        fgTfavor.Cols(1).Caption = "DIA"
        fgTfavor.Cols(1).DataType = GetType(String)
        fgTfavor.Cols(2).Caption = "INCIDENCIAS"
        fgTfavor.Cols(2).DataType = GetType(String)
        fgTfavor.Cols(3).Caption = "TIEMPO"
        fgTfavor.Cols(3).DataType = GetType(String)

        fgTfavor.AutoSizeCols()

        fgTcontra.Cols.Count = 4
        fgTcontra.Rows.Count = 1

        fgTcontra.Cols(0).Caption = "FECHA"
        fgTcontra.Cols(0).DataType = GetType(Date)
        fgTcontra.Cols(1).Caption = "DIA"
        fgTcontra.Cols(1).DataType = GetType(String)
        fgTcontra.Cols(2).Caption = "INCIDENCIA"
        fgTcontra.Cols(2).DataType = GetType(String)
        fgTcontra.Cols(3).Caption = "TIEMPO"
        fgTcontra.Cols(3).DataType = GetType(String)

        fgTcontra.AutoSizeCols()

    End Sub

    Private Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date

        Dim Valor As Date

        Valor = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)

        Return Valor

    End Function

    Private Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date

        Dim Valor As Date

        Valor = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)

        Return Valor

    End Function

    Private Sub LlenaGrid()

        Dim DiaConsecutivo As DateTime

        DiaConsecutivo = primerDia

        While (DiaConsecutivo <= ultimoDia)

            fgTfavor.AddItem("")

            fgTfavor.SetData(fgTfavor.Rows.Count - 1, 0, DiaConsecutivo)
            fgTfavor.SetData(fgTfavor.Rows.Count - 1, 1, UCase(Format(DiaConsecutivo, "dddd")))

            fgTcontra.AddItem("")

            fgTcontra.SetData(fgTcontra.Rows.Count - 1, 0, DiaConsecutivo)
            fgTcontra.SetData(fgTcontra.Rows.Count - 1, 1, UCase(Format(DiaConsecutivo, "dddd")))

            DiaConsecutivo = primerDia.AddDays(Cuenta)
            Cuenta += 1

        End While

        fgTfavor.AutoSizeCols()
        fgTcontra.AutoSizeCols()

        Tiempos()

    End Sub

    Private Sub Tiempos()

        '*******************************************************************************************************************************************************************
        '*                                                                                                                                                                 *
        '*                          FUNCION EN LA QUE SE GENERAN LOS MOVIMIENTOS DE LAS INCIDENCIAS, SE GENERAN LOS TIEMPOS EN CONTRA,                                     *
        '*                                                                                                                                                                 *
        '*                          LAS FALTAS, LOS RETARDOS DE COMIDA, RETARDOS DE ENTRADA, SALIDAS TEMPRANAS, SALIDAS TARDES,                                            *
        '*                                                                                                                                                                 *
        '*                          NUMERO DE RETARDOS, PERMISOS PERSONALES, PERMISOS, TIEMPO TOTAL A FAVOR, TIEMPO TOTAL EN CONTRA,                                       *
        '*                                                                                                                                                                 *
        '*                          EL TIEMPO QUE GENERO EL COLABORADOR DEL MES ANTERIOR, ASI COMO TODOS LOS CALCULOS PARA GENERAR                                         *
        '*                                                                                                                                                                 *
        '*                          EL TOTAL DE TIEMPO DEL MES DEL COLABORADOR, SE COLOCAN LOS CONCEPTOS DE LAS INCIDENCIAS Y SE                                           *
        '*                                                                                                                                                                 *
        '*                          GENERA EL REPORTE IMPRESO PARA SU REVISION Y POSTERIOR FIRMA DE ACUERDO DEL COLABORADOR.                                               *
        '*                                                                                                                                                                 *
        '*******************************************************************************************************************************************************************

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cnOtr As New MySqlConnection
        cnOtr = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim cmdOtr As New MySqlCommand
        cmdOtr.Connection = cnOtr

        Dim rdrObj As MySqlDataReader
        Dim rdrOtr As MySqlDataReader

        Dim strSql As String
        Dim strOtr As String

        'Recorremos el grid de tiempo a favor para revisar las incidencias
        For i As Integer = 1 To fgTfavor.Rows.Count - 1

            Dim Entrada, Salida, salComida, entComida, entJornada, salJornada, tempEntrada, tempSalida As String
            Dim difTiempoFavor, difTiempoContra As Integer

            difTiempoFavor = 0
            difTiempoContra = 0

            'Verifico si el dia no sea domingo
            If UCase(Format(fgTfavor.GetData(i, 0), "dddd")) <> "DOMINGO" Then

                'Obtenemos los datos de registro del colaborador de la fecha recorrida
                strOtr = "SELECT "
                strOtr += "reg_entrada, "
                strOtr += "reg_sal_comida, "
                strOtr += "reg_ent_comida, "
                strOtr += "reg_salida "
                strOtr += "FROM "
                strOtr += "registro "
                strOtr += "WHERE "
                strOtr += "clave = '" & Clave & "' AND "
                strOtr += "fecha = '" & Format(fgTfavor.GetData(i, 0), "yyyyMMdd") & "'"

                cmdOtr.CommandText = strOtr
                rdrOtr = cmdOtr.ExecuteReader

                If rdrOtr.HasRows = True Then

                    While rdrOtr.Read

                        Entrada = rdrOtr(0).ToString
                        Salida = rdrOtr(1).ToString
                        salComida = rdrOtr(2).ToString
                        entComida = rdrOtr(3).ToString

                    End While

                    rdrOtr.Close()

                Else
                    rdrOtr.Close()
                    Continue For
                End If

                'Obtenemos los datos de la jornada del colaborador de la fecha recorrida
                strOtr = "SELECT "
                strOtr += "entrada, "
                strOtr += "salida "
                strOtr += "FROM "
                strOtr += "jornada_empleado "
                strOtr += "WHERE "
                strOtr += "clave = '" & Clave & "' AND "
                strOtr += "fecha = '" & Format(fgTfavor.GetData(i, 0), "yyyyMMdd") & "'"

                cmdOtr.CommandText = strOtr
                rdrOtr = cmdOtr.ExecuteReader

                If rdrOtr.HasRows = True Then

                    While rdrOtr.Read

                        entJornada = rdrOtr(0).ToString
                        salJornada = rdrOtr(1).ToString

                    End While

                    rdrOtr.Close()

                Else

                    rdrOtr.Close()
                    Continue For
                End If

                'Seleccionamos las incidencias del dia recorrido
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
                strSql += "fecha = '" & Format(fgTfavor.GetData(i, 0), "yyyyMMdd") & "'"

                cmdObj.CommandText = strSql
                rdrObj = cmdObj.ExecuteReader

                If rdrObj.HasRows = True Then

                    While rdrObj.Read

                        Dim TiempoTemp As Integer = 0

                        'Seleccionamos el tipo de incidencia
                        Select Case rdrObj.Item("tipo")

                            'Si la incidencia es de entrada temprano
                            Case "ENTRADA TEMPRANO"

                                'revisamos si tiene una hora de entrada, si no tiene hora de entrada, 
                                'se genera el tiempo a partir de la hora de entrada de la jornada y la hora de entrada
                                If rdrObj.Item("entrada") Is DBNull.Value Then

                                    TiempoTemp = DateDiff("n", Entrada, entJornada)

                                    If fgTfavor.GetData(i, 3) <> "" Then
                                        TiempoTemp += ConvierteHoraNumero(fgTfavor.GetData(i, 3))
                                    End If

                                    fgTfavor.SetData(i, 3, ConvierteNumeroHora(TiempoTemp))
                                    difTiempoFavor += TiempoTemp

                                    'Revisamos si se tiene otro concepto anterior para este dia
                                    If fgTfavor.GetData(i, 2) <> "" Then

                                        Dim tempConcepto As String

                                        tempConcepto = fgTfavor.GetData(i, 2)
                                        tempConcepto = tempConcepto & ", " & "ENTRADA TEMPRANO"
                                        fgTfavor.SetData(i, 2, tempConcepto)

                                    Else

                                        fgTfavor.SetData(i, 2, "ENTRADA TEMPRANO")

                                    End If

                                Else

                                    Dim Tiempo As String

                                    Tiempo = rdrObj(1).ToString

                                    TiempoTemp = Abs(DateDiff("n", Tiempo, entJornada))

                                    If fgTfavor.GetData(i, 11) <> "" Then
                                        TiempoTemp += ConvierteHoraNumero(fgTfavor.GetData(i, 3))
                                    End If

                                    fgTfavor.SetData(i, 3, ConvierteNumeroHora(TiempoTemp))
                                    difTiempoFavor += TiempoTemp

                                    If fgTfavor.GetData(i, 2) <> "" Then

                                        Dim tempConcepto As String

                                        tempConcepto = fgTfavor.GetData(i, 2)
                                        tempConcepto = tempConcepto & ", " & "ENTRADA TEMPRANO"
                                        fgTfavor.SetData(i, 2, tempConcepto)

                                    Else

                                        fgTfavor.SetData(i, 2, "ENTRADA TEMPRANO")

                                    End If

                                End If

                            Case "SALIDA TARDE"

                                If rdrObj.Item("salida") Is DBNull.Value Then

                                    TiempoTemp = DateDiff("n", Salida, salJornada)

                                    If fgTfavor.GetData(i, 3) <> "" Then
                                        TiempoTemp += ConvierteHoraNumero(fgTfavor.GetData(i, 3))
                                    End If

                                    fgTfavor.SetData(i, 3, ConvierteNumeroHora(TiempoTemp))
                                    difTiempoFavor += TiempoTemp

                                    If fgTfavor.GetData(i, 2) <> "" Then

                                        Dim tempConcepto As String

                                        tempConcepto = fgTfavor.GetData(i, 2)
                                        tempConcepto = tempConcepto & ", " & "SALIDA TARDE"
                                        fgTfavor.SetData(i, 2, tempConcepto)

                                    Else

                                        fgTfavor.SetData(i, 2, "SALIDA TARDE")

                                    End If

                                Else

                                    Dim Tiempo As String

                                    Tiempo = rdrObj(2).ToString

                                    TiempoTemp = Abs(DateDiff("n", Tiempo, salJornada))

                                    If fgTfavor.GetData(i, 3) <> "" Then
                                        TiempoTemp += ConvierteHoraNumero(fgTfavor.GetData(i, 3))
                                    End If

                                    fgTfavor.SetData(i, 3, ConvierteNumeroHora(TiempoTemp))

                                    difTiempoFavor += TiempoTemp

                                    If fgTfavor.GetData(i, 2) <> "" Then

                                        Dim tempConcepto As String

                                        tempConcepto = fgTfavor.GetData(i, 2)
                                        tempConcepto = tempConcepto & ", " & "SALIDA TARDE"
                                        fgTfavor.SetData(i, 2, tempConcepto)

                                    Else

                                        fgTfavor.SetData(i, 2, "SALIDA TARDE")

                                    End If

                                End If

                            Case "PAGO DE TIEMPO"

                                TiempoTemp = DateDiff("n", rdrObj(1).ToString, rdrObj(2).ToString)

                                If fgTfavor.GetData(i, 5) <> "" And fgTfavor.GetData(i, 6) <> "" Then

                                    TiempoTemp -= 60

                                End If

                                difTiempoFavor = TiempoTemp

                                If fgTfavor.GetData(i, 15) <> "" Then

                                    Dim tempConcepto As String

                                    tempConcepto = fgTfavor.GetData(i, 15)
                                    tempConcepto = tempConcepto & ", " & "PAGO DE TIEMPO"
                                    fgTfavor.SetData(i, 15, tempConcepto)

                                Else

                                    fgTfavor.SetData(i, 15, "PAGO DE TIEMPO")

                                End If

                        End Select

                    End While

                End If

                rdrObj.Close()

                TotTiempoFavor += difTiempoFavor
                TotTiempoContra += difTiempoContra

                rdrObj.Close()

            End If

        Next

        fgTfavor.AutoSizeCols()

    End Sub

#End Region

End Class