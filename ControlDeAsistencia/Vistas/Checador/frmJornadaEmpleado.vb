Imports MySql.Data.MySqlClient

Public Class frmJornadaEmpleado

    Dim Desc_sem As Integer
    Dim Desc_dia As String

    Private Sub frmJornadaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Empleados()
        Plantillas()
        Configura()

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()
        Plantillas()

    End Sub

    Private Sub tsbGenerar_Click(sender As Object, e As EventArgs) Handles tsbGenerar.Click

        GenereHorario()
        tsbLimpiar.Enabled = True
        tsbGuardar.Enabled = True

    End Sub

    Private Sub tsbLimpiar_Click(sender As Object, e As EventArgs) Handles tsbLimpiar.Click

        fgHorario.Clear()
        Configura()
        dtJornada.Clear()

        tsbLimpiar.Enabled = False

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        GuardaJornada()
        dtJornada.Clear()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgHorario.Cols.Count = 6
        fgHorario.Rows.Count = 1

        fgHorario.Cols(0).Caption = "Fecha"
        fgHorario.Cols(0).DataType = GetType(Date)
        fgHorario.Cols(1).Caption = "Dia"
        fgHorario.Cols(2).Caption = "Hora Entrada"
        fgHorario.Cols(2).DataType = GetType(String)
        fgHorario.Cols(3).Caption = "Hora Salida"
        fgHorario.Cols(3).DataType = GetType(String)
        fgHorario.Cols(4).Caption = "Descanso"
        fgHorario.Cols(4).DataType = GetType(Integer)
        fgHorario.Cols(4).Visible = False
        fgHorario.Cols(5).Caption = "Semana"
        fgHorario.Cols(5).Visible = False

        fgHorario.AutoSizeCols()

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

    Private Sub Plantillas()

        cmbPlantilla.DataSource = Nothing
        cmbPlantilla.Items.Clear()
        cmbPlantilla.Text = ""
        cmbPlantilla.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_plantillas(cmbSucursal.SelectedValue)

        cmbPlantilla.ValueMember = "id_plantilla"
        cmbPlantilla.DisplayMember = "plantilla"
        cmbPlantilla.DataSource = dsObj.Tables("Plantillas")

    End Sub

    Private Sub GenereHorario()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "lunes1_entrada, "
        strSql += "lunes1_salida, "
        strSql += "martes1_entrada, "
        strSql += "martes1_salida, "
        strSql += "miercoles1_entrada, "
        strSql += "miercoles1_salida, "
        strSql += "jueves1_entrada, "
        strSql += "jueves1_salida, "
        strSql += "viernes1_entrada, "
        strSql += "viernes1_salida, "
        strSql += "sabado1_entrada, "
        strSql += "sabado1_salida, "
        strSql += "domingo1_entrada, "
        strSql += "domingo1_salida, "
        strSql += "lunes2_entrada, "
        strSql += "lunes2_salida, "
        strSql += "martes2_entrada, "
        strSql += "martes2_salida, "
        strSql += "miercoles2_entrada, "
        strSql += "miercoles2_salida, "
        strSql += "jueves2_entrada, "
        strSql += "jueves2_salida, "
        strSql += "viernes2_entrada, "
        strSql += "viernes2_salida, "
        strSql += "sabado2_entrada, "
        strSql += "sabado2_salida, "
        strSql += "domingo2_entrada, "
        strSql += "domingo2_salida "
        strSql += "FROM "
        strSql += "plantilla "
        strSql += "WHERE "
        strSql += "id_plantilla = '" & cmbPlantilla.SelectedValue & "' AND "
        strSql += "id_sucursal = '" & cmbSucursal.SelectedValue & "'"

        cmdObj.CommandText = strSql

        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Dim Cons As Integer = 1

        While rdrObj.Read

            Dim drNewRowJor As DataRow = dtJornada.NewRow

            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "LUNES"
            drNewRowJor("Entrada") = rdrObj.Item("lunes1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("lunes1_salida")

            If rdrObj.Item("lunes1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "LUNES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "MARTES"
            drNewRowJor("Entrada") = rdrObj.Item("martes1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("martes1_salida")

            If rdrObj.Item("martes1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "MARTES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "MIÉRCOLES"
            drNewRowJor("Entrada") = rdrObj.Item("miercoles1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("miercoles1_salida")

            If rdrObj.Item("miercoles1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "MIÉRCOLES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "JUEVES"
            drNewRowJor("Entrada") = rdrObj.Item("jueves1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("jueves1_salida")

            If rdrObj.Item("jueves1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "JUEVES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "VIERNES"
            drNewRowJor("Entrada") = rdrObj.Item("viernes1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("viernes1_salida")

            If rdrObj.Item("viernes1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "VIERNES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "SÁBADO"
            drNewRowJor("Entrada") = rdrObj.Item("sabado1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("sabado1_salida")

            If rdrObj.Item("sabado1_entrada").ToString = "00:00:00" Then
                Desc_sem = 1
                Desc_dia = "SÁBADO"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 1
            drNewRowJor("Dia") = "DOMINGO"
            drNewRowJor("Entrada") = rdrObj.Item("domingo1_entrada")
            drNewRowJor("Salida") = rdrObj.Item("domingo1_salida")
            drNewRowJor("Descanso") = False

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "LUNES"
            drNewRowJor("Entrada") = rdrObj.Item("lunes2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("lunes2_salida")

            If rdrObj.Item("lunes2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "LUNES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "MARTES"
            drNewRowJor("Entrada") = rdrObj.Item("martes2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("martes2_salida")

            If rdrObj.Item("martes2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "MARTES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "MIÉRCOLES"
            drNewRowJor("Entrada") = rdrObj.Item("miercoles2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("miercoles2_salida")

            If rdrObj.Item("miercoles2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "MIÉRCOLES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "JUEVES"
            drNewRowJor("Entrada") = rdrObj.Item("jueves2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("jueves2_salida")

            If rdrObj.Item("jueves2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "JUEVES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "VIERNES"
            drNewRowJor("Entrada") = rdrObj.Item("viernes2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("viernes2_salida")

            If rdrObj.Item("viernes2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "VIERNES"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "SÁBADO"
            drNewRowJor("Entrada") = rdrObj.Item("sabado2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("sabado2_salida")

            If rdrObj.Item("sabado2_entrada").ToString = "00:00:00" Then
                Desc_sem = 2
                Desc_dia = "SÁBADO"
                drNewRowJor("Descanso") = True
            Else
                drNewRowJor("Descanso") = False
            End If

            dtJornada.Rows.Add(drNewRowJor)

            drNewRowJor = dtJornada.NewRow
            drNewRowJor("Semana") = 2
            drNewRowJor("Dia") = "DOMINGO"
            drNewRowJor("Entrada") = rdrObj.Item("domingo2_entrada")
            drNewRowJor("Salida") = rdrObj.Item("domingo2_salida")
            drNewRowJor("Descanso") = False

            dtJornada.Rows.Add(drNewRowJor)

        End While

        Dim Semana As Integer

        If cmbSemanaIni.Text = "PRIMERA" Then

            Dim DiaIni As DateTime
            Dim DiaFin As DateTime
            Dim DiaConsecutivo As DateTime
            Dim DiaHorario As String
            Dim Vueltas As Integer = 1
            'Dim Temp As String

            DiaIni = dtpFechaIni.Value
            DiaFin = dtpFechaFin.Value
            DiaConsecutivo = DiaIni

            DiaHorario = Format(DiaConsecutivo, "dddd")

            If DiaHorario = "domingo" And cmbSemanaIni.Text = "PRIMERA" Then
                Semana = 2
            Else
                Semana = 1
            End If

            While (DiaConsecutivo <= DiaFin)

                DiaHorario = Format(DiaConsecutivo, "dddd")

                Select Case DiaHorario

                    Case "lunes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "martes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "miércoles"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "jueves"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "viernes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "sábado"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "domingo"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                            Semana = 2

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                            Semana = 1

                        End If

                End Select

                DiaConsecutivo = DiaIni.AddDays(Vueltas)
                Vueltas += 1

            End While

        ElseIf cmbSemanaIni.Text = "SEGUNDA" Then

            Dim DiaIni As DateTime
            Dim DiaFin As DateTime
            Dim DiaConsecutivo As DateTime
            Dim DiaHorario As String
            Dim Vueltas As Integer = 1
            Dim Temp As String

            DiaIni = dtpFechaIni.Value
            DiaFin = dtpFechaFin.Value
            DiaConsecutivo = DiaIni

            DiaHorario = Format(DiaConsecutivo, "dddd")

            If DiaHorario = "domingo" And cmbSemanaIni.Text = "SEGUNDA" Then
                Semana = 1
            Else
                Semana = 2
            End If

            While (DiaConsecutivo <= DiaFin)

                DiaHorario = Format(DiaConsecutivo, "dddd")

                Select Case DiaHorario

                    Case "lunes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "martes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "miércoles"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "jueves"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "viernes"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "sábado"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 0)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                        End If

                    Case "domingo"

                        If Semana = 1 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                            Semana = 2

                        ElseIf Semana = 2 Then

                            If Desc_sem = Semana And Desc_dia = UCase(DiaHorario) Then

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            Else

                                Dim drJorRow As DataRow() = dtJornada.Select("Semana = " & "'" & Semana & "'" & " And Dia = " & "'" & UCase(DiaHorario) & "'")
                                Dim drRowJor As DataRow

                                For Each drRowJor In drJorRow

                                    fgHorario.AddItem("")
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 0, DiaConsecutivo)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 1, DiaHorario)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 2, drRowJor("Entrada"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 3, drRowJor("Salida"))
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 4, 1)
                                    fgHorario.SetData(fgHorario.Rows.Count - 1, 5, Semana)

                                Next

                            End If

                            Semana = 1

                        End If

                End Select

                DiaConsecutivo = DiaIni.AddDays(Vueltas)
                Vueltas += 1

            End While

        End If

        fgHorario.AutoSizeCols()

    End Sub

    Private Sub GuardaJornada()

        Dim bCorrecto As Boolean = False

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim des As Integer
        Dim strSql As String = ""
        Dim strOtr As String = ""

        For i As Integer = 1 To fgHorario.Rows.Count - 1

            Dim bExiste As Boolean = False

            bExiste = ValidaJornadaEmpleado(cmbEmpleado.SelectedValue, Format(fgHorario.GetData(i, 0), "yyyyMMdd"))

            If bExiste = False Then

                strSql = "INSERT "
                strSql += "INTO "
                strSql += "jornada_empleado "
                strSql += "(clave, "
                strSql += "id_plantilla, "
                strSql += "fecha, "
                strSql += "entrada, "
                strSql += "salida, "
                strSql += "descanso, "
                strSql += "semana) "
                strSql += "VALUES "
                strSql += "('" & cmbEmpleado.SelectedValue & "', "
                strSql += "'" & cmbPlantilla.SelectedValue & "', "
                strSql += "'" & Format(fgHorario.GetData(i, 0), "yyyyMMdd") & "', "
                strSql += "'" & fgHorario.GetData(i, 2) & "', "

                des = fgHorario.GetData(i, 4)

                strSql += "'" & fgHorario.GetData(i, 3) & "', "
                If des = 1 Then
                    strSql += "1, "
                ElseIf des = 0 Then
                    strSql += "0, "
                End If

                strSql += "'" & fgHorario.GetData(i, 5) & "')"

                cmdObj.CommandText = strSql

                Try
                    cmdObj.ExecuteNonQuery()
                    bCorrecto = True
                Catch ex As Exception
                    MessageBox.Show("Error al Generar el Horario " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    bCorrecto = False
                End Try

            End If

        Next

        If Jornada_asignada(cmbEmpleado.SelectedValue) Then

            strSql = "UPDATE "
            strSql += "jornada_asignada "
            strSql += "SET "
            strSql += "id_plantilla = '" & cmbPlantilla.SelectedValue & "' "
            strSql += "WHERE "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "'"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al Generar el Horario " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else

            strSql = "INSERT "
            strSql += "INTO "
            strSql += "jornada_asignada "
            strSql += "(id_plantilla, "
            strSql += "clave) "
            strSql += "VALUES "
            strSql += "('" & cmbPlantilla.SelectedValue & "', "
            strSql += "'" & cmbEmpleado.SelectedValue & "')"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al Generar el Horario " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        cnObj.Close()

        If bCorrecto = True Then
            MessageBox.Show("Datos Guardados en la Base de Datos", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()

    End Sub

    Private Function Jornada_asignada(ByVal idEmp As Integer) As Boolean

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "* "
        strSql += "FROM "
        strSql += "jornada_asignada "
        strSql += "WHERE "
        strSql += "clave = '" & idEmp & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            Jornada_asignada = True
        Else
            Jornada_asignada = False
        End If

        Return Jornada_asignada

    End Function

    Private Function ValidaJornadaEmpleado(ByVal Clave As Integer, ByVal Fecha As String) As Boolean

        Dim bValor As Boolean = False

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "* "
        strSql += "FROM "
        strSql += "jornada_empleado "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "fecha = '" & Fecha & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            bValor = True
        Else
            bValor = False
        End If

        rdrObj.Close()
        cnObj.Close()

        Return bValor

    End Function

#End Region

End Class