Imports MySql.Data.MySqlClient

Public Class frmAreaMod

    Dim _id As Integer
    Dim Fecha As String = Format(Date.Now, "yyyyMMdd")

    Public Property Id As Integer
        Get
            Id = _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Sub frmAreaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Id > 0 Then

            ObtieneArea()

        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If Id > 0 Then
            Edita()
        Else
            Nuevo()
        End If

    End Sub

#Region "FUNCIONES"

    Private Sub ObtieneArea()

        Dim rdrObj As MySqlDataReader

        rdrObj = Funciones.Obtiene_Area(Id)

        While rdrObj.Read

            txtArea.Text = rdrObj.Item("area")

            If rdrObj.Item("estatus") = 1 Then
                chbEstatus.CheckState = CheckState.Checked
            Else
                chbEstatus.CheckState = CheckState.Unchecked
            End If

            dtpAlta.Value = rdrObj.Item("fecha_alta")
            dtpBaja.Value = rdrObj.Item("fecha_baja")

        End While

        rdrObj.Close()

    End Sub

    Private Sub Nuevo()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim strOtr As String

        strSql = "INSERT "
        strSql += "INTO "
        strSql += "area "
        strSql += "(area, "
        strSql += "estatus, "
        strSql += "fecha_alta, "
        strSql += "fecha_baja) "
        strSql += "VALUES "
        strSql += "('" & txtArea.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "1, "
        Else
            strSql += "0, "
        End If

        strSql += "'" & Format(dtpAlta.Value, "yyyyMMdd") & "', "
        strSql += "'" & Format(dtpBaja.Value, "yyyyMMdd") & "')"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

    Private Sub Edita()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim strOtr As String

        strSql = "UPDATE "
        strSql += "area "
        strSql += "SET "
        strSql += "area = '" & txtArea.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "estatus = 1, "
        Else
            strSql += "estatus = 0, "
        End If

        strSql += "fecha_alta = '" & Format(dtpAlta.Value, "yyyyMMdd") & "', "
        strSql += "fecha_baja = '" & Format(dtpBaja.Value, "yyyyMMdd") & "' "
        strSql += "WHERE "
        strSql += "id_area = '" & Id & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

#End Region

End Class