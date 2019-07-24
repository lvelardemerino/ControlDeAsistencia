Imports MySql.Data.MySqlClient

Public Class frmTiempo

    Dim mesNumero As Integer
    Dim Tiempo, Tipo, TempTiempo As Integer

    Private Sub frmTiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()
        Empleados()

    End Sub

    Private Sub txtTiempo_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo.TextChanged

        TempTiempo = ConvierteTiempo(txtTiempo.Text)

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Empleados()

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Guardar()

    End Sub

#Region "FUNCIONES"

    Private Function ConvierteTiempo(ByVal Tiempo As String) As Integer

        Dim Valor As Integer
        Dim TempHora, TempMinuto As String

        For i As Integer = 1 To Len(Tiempo)

            If Mid(Tiempo, i, 1) = ":" Then

                TempHora = Mid(Tiempo, 1, (i - 1))
                TempMinuto = Mid(Tiempo, (i + 1), 2)

            End If

        Next

        If TempHora <> "" And TempMinuto <> "" Then
            Valor = CInt(TempHora) * 60
            Valor += CInt(TempMinuto)
        End If

        Return Valor

    End Function

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

        Dim bExsite As Boolean = False

        mesNumero = ConvierteMesaNumero(cmbMes.Text)
        bExsite = ValidaTiempo(cmbEmpleado.SelectedValue, mesNumero, cmbAnio.Text)

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        If bExsite = True Then

            strSql = "UPDATE "
            strSql += "tiempo "
            strSql += "SET "
            strSql += "tiempo = '" & TempTiempo & "', "

            If cmbTipo.Text = "FAVOR" Then
                strSql += "tipo = 1 "
            Else
                strSql += "tipo = 0 "
            End If

            strSql += "WHERE "
            strSql += "clave = '" & cmbEmpleado.SelectedValue & "' AND "
            strSql += "mes = '" & mesNumero & "' AND "
            strSql += "anio = '" & cmbAnio.Text & "'"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnObj.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            strSql += "'" & mesNumero & "', "
            strSql += "'" & cmbAnio.Text & "', "
            strSql += "'" & TempTiempo & "', "

            If cmbTipo.Text = "FAVOR" Then
                strSql += "1)"
            Else
                strSql += "0)"
            End If

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnObj.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        
    End Sub

    Private Function ConvierteMesaNumero(ByVal Mes As String) As Integer

        Dim Valor As Integer

        Select Case Mes

            Case "ENERO"

                Valor = 1

            Case "FEBRERO"

                Valor = 2

            Case "MARZO"

                Valor = 3

            Case "ABRIL"

                Valor = 4

            Case "MAYO"

                Valor = 5

            Case "JUNIO"

                Valor = 6

            Case "JULIO"

                Valor = 7

            Case "AGOSTO"

                Valor = 8

            Case "SEPTIEMBRE"

                Valor = 9

            Case "OCTUBRE"

                Valor = 10

            Case "NOVIEMBRE"

                Valor = 11

            Case "DICIEMBRE"

                Valor = 12

        End Select

        Return Valor

    End Function

    Private Function ValidaTiempo(ByVal Clave As String, ByVal Mes As Integer, ByVal Anio As Integer) As Boolean

        Dim Valor As Boolean = False

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "tiempo "
        strSql += "FROM "
        strSql += "tiempo "
        strSql += "WHERE "
        strSql += "clave = '" & Clave & "' AND "
        strSql += "mes = '" & Mes & "' AND "
        strSql += "anio = '" & Anio & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        If rdrObj.HasRows = True Then
            Valor = True
        Else
            Valor = False
        End If

        rdrObj.Close()
        cnObj.Close()

        Return Valor

    End Function

#End Region
    
End Class