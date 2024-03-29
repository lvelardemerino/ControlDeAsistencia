﻿Imports MySql.Data.MySqlClient
Imports System.Math

Module Funciones

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

#Region "VARIABLES GLOBALES"

    Public intSucursal As Integer = 10
    Public strUsrId As String = ""
    Public strUsrNombre As String = ""
    Public strUsrEmail As String = ""
    Public strUsrTelefono As String = ""
    Public intArea As Integer = 0
    Public bCargandoPermisos As Boolean = False
    Public bPermiteAccesoOpciones As Boolean = False
    Public bMuestraVentanaOficinas As Boolean = False
    Public bAutentifica As Boolean = False
    Public strUsrAut As String = ""
    Public bAutorizado As Boolean = False
    Public CambioPass As Integer = 0

    Public dtJornada As New DataTable("jornada")
    Public dtEventos As New DataTable("Eventos")

#End Region

#Region "FUNCIONES"

    Public Function OficinasUsuario() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = Conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_sucursal, "
        strSql += "sucursal "
        strSql += "FROM "
        strSql += "sucursal "

        cmdObj.CommandText = strSql

        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj

        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Sucursales")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_empleado() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "clave, "
        strSql += "concat_ws(' ', nombre, a_paterno) AS Nombre_ape "
        strSql += "FROM "
        strSql += "empleado "
        strSql += "WHERE "
        strSql += "estatus = 1 AND "
        strSql += "(huella1 IS NULL OR "
        strSql += "huella2 IS NULL)"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Empleado")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_sucursal() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_sucursal, "
        strSql += "sucursal "
        strSql += "FROM "
        strSql += "sucursal"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Sucursal")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_Area() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_area, "
        strSql += "area "
        strSql += "FROM "
        strSql += "area"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Area")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_Area(ByVal idArea As Integer) As MySqlDataReader

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_area, "
        strSql += "area, "
        strSql += "estatus, "
        strSql += "fecha_alta, "
        strSql += "fecha_baja "
        strSql += "FROM "
        strSql += "area"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Return rdrObj

        rdrObj.Close()
        cnObj.Close()

    End Function

    Public Function Areas() As MySqlDataReader

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_area, "
        strSql += "area, "
        strSql += "estatus, "
        strSql += "fecha_alta, "
        strSql += "fecha_baja "
        strSql += "FROM "
        strSql += "area"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Return rdrObj

        rdrObj.Close()
        cnObj.Close()

    End Function

    Public Function Obtiene_sucursal(ByVal idSuc As Integer) As MySqlDataReader

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "a.id_sucursal, "
        strSql += "a.sucursal, "
        strSql += "a.razon_social, "
        strSql += "a.rfc, "
        strSql += "a.calle, "
        strSql += "a.num_ext, "
        strSql += "a.num_int, "
        strSql += "a.colonia, "
        strSql += "b.pais_nombre, "
        strSql += "c.estado_nombre, "
        strSql += "d.ciudad_nombre, "
        strSql += "a.codigo_pos, "
        strSql += "a.telefono, "
        strSql += "a.contacto, "
        strSql += "a.mail, "
        strSql += "a.estatus "
        strSql += "FROM "
        strSql += "sucursal a, "
        strSql += "pais b, "
        strSql += "estado c, "
        strSql += "ciudad d "
        strSql += "WHERE "
        strSql += "a.id_pais = b.id_pais AND "
        strSql += "a.id_estado = c.id_estado AND "
        strSql += "a.id_ciudad = d.id_ciudad AND "
        strSql += "a.id_sucursal = '" & idSuc & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Return rdrObj

        rdrObj.Close()
        cnObj.Close()


    End Function

    Public Function Obtiene_departamento() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_departamento, "
        strSql += "departamento "
        strSql += "FROM "
        strSql += "departamento "
        strSql += "WHERE "
        strSql += "estatus = 1"


        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Departamento")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_departamento(ByVal idDepto As Integer) As MySqlDataReader

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "a.id_departamento, "
        strSql += "a.departamento, "
        strSql += "a.estatus, "
        strSql += "a.fecha_alta, "
        strSql += "a.fecha_baja, "
        strSql += "b.area, "
        strSql += "c.sucursal "
        strSql += "FROM "
        strSql += "departamento a, "
        strSql += "area b, "
        strSql += "sucursal c "
        strSql += "WHERE "
        strSql += "a.id_area = b.id_area AND "
        strSql += "a.id_sucursal = c.id_sucursal AND "
        strSql += "a.id_departamento = '" & idDepto & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Return rdrObj

        rdrObj.Close()
        cnObj.Close()

    End Function

    Public Function Obtiene_pais() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = Conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_pais, "
        strSql += "pais_nombre "
        strSql += "FROM "
        strSql += "pais"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Pais")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_estado(ByVal pais_id As String) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = Conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_estado, "
        strSql += "estado_nombre "
        strSql += "FROM "
        strSql += "estado "
        strSql += "WHERE "
        strSql += "id_pais = '" & pais_id & "'"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Estado")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_ciudad(ByVal estado_id As String) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = Conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_ciudad, "
        strSql += "ciudad_nombre "
        strSql += "FROM "
        strSql += "ciudad "
        strSql += "WHERE "
        strSql += "id_estado = '" & estado_id & "'"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Ciudad")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_bancosat() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_banco_sat, "
        strSql += "banco_sat "
        strSql += "FROM "
        strSql += "banco_sat"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "BancoSat")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_jornada() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_jornada, "
        strSql += "jornada "
        strSql += "FROM "
        strSql += "jornada"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Jornada")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_tiposalario() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_tipo_salario, "
        strSql += "tipo_salario "
        strSql += "FROM "
        strSql += "tipo_salario"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "TipoSalario")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_metodopago() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_metodo_pago, "
        strSql += "metodo_pago "
        strSql += "FROM "
        strSql += "metodo_pagosat"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "MetodoPago")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_contrato() As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_contrato, "
        strSql += "contrato "
        strSql += "FROM "
        strSql += "contrato"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Contrato")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Departamento_sucursal(ByVal idSuc As Integer) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "id_departamento, "
        strSql += "departamento "
        strSql += "FROM "
        strSql += "departamento "
        strSql += "WHERE "
        strSql += "id_sucursal = '" & idSuc & "' AND "
        strSql += "estatus = 1"


        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Departamento")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Departamentos() As MySqlDataReader

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "a.id_departamento, "
        strSql += "a.departamento, "
        strSql += "b.area, "
        strSql += "c.sucursal "
        strSql += "FROM "
        strSql += "departamento a, "
        strSql += "area b, "
        strSql += "sucursal c "
        strSql += "WHERE "
        strSql += "a.id_area = b.id_area AND "
        strSql += "a.id_sucursal = c.id_sucursal"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        Return rdrObj

        rdrObj.Close()
        cnObj.Close()

    End Function

    Public Function Obtiene_empSucDepto(ByVal idSuc As Integer, ByVal idDepto As Integer) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "clave, "
        strSql += "concat_ws(' ', nombre, a_paterno) AS Nombre_ape "
        strSql += "FROM "
        strSql += "empleado "
        strSql += "WHERE "
        strSql += "id_sucursal = '" & idSuc & "' AND "
        strSql += "id_departamento = '" & idDepto & "' AND "
        strSql += "estatus = 1"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Empleado")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_empSuc(ByVal idSuc As Integer) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String
        strSql = "SELECT "
        strSql += "clave, "
        strSql += "concat_ws(' ', nombre, a_paterno) AS Nombre_ape "
        strSql += "FROM "
        strSql += "empleado "
        strSql += "WHERE "
        strSql += "id_sucursal = '" & idSuc & "' AND "
        strSql += "estatus = 1 "
        strSql += "order by Nombre_ape"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Empleado")

        cnObj.Close()

        Return dsObj

    End Function

    Public Function Obtiene_plantillas(ByVal suc As Integer) As DataSet

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj
        Dim strSql As String

        strSql = "SELECT "
        strSql += "id_plantilla, "
        strSql += "plantilla "
        strSql += "FROM "
        strSql += "plantilla "
        strSql += "WHERE "
        strSql += "id_sucursal = '" & suc & "'"

        cmdObj.CommandText = strSql
        Dim daObj As New MySqlDataAdapter
        daObj.SelectCommand = cmdObj
        Dim dsObj As DataSet = New DataSet()
        daObj.Fill(dsObj, "Plantillas")

        cnObj.Close()

        Return dsObj

    End Function

    Public Sub GeneraEvento(ByVal suc As Integer, ByVal fecha As String, ByVal evento As String)

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "INSERT "
        strSql += "INTO "
        strSql += "eventos "
        strSql += "(id_sucursal, "
        strSql += "fecha, "
        strSql += "evento, "
        strSql += "suc_destino) "
        strSql += "VALUES "
        strSql += "('" & suc & "', "
        strSql += "'" & fecha & "', "
        strSql += "'" & evento & "', "
        strSql += "0)"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        cnObj.Close()

    End Sub

    Public Function ConvierteNumeroHora(ByVal Numero As Integer) As String

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

    Public Function ConvierteHoraNumero(ByVal Hora As String) As Integer

        Dim Valor As Integer = 0

        Dim tempHora, tempMin As Integer

        tempHora = Mid(Hora, 1, 2)
        tempMin = Mid(Hora, 4, 5)

        Valor = (tempHora * 60) + tempMin

        Return Valor

    End Function

#End Region

End Module
