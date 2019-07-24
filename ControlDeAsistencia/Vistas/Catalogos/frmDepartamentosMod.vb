Imports MySql.Data.MySqlClient

Public Class frmDepartamentosMod

    Dim _id As Integer
    Dim fecha As String = Format(Date.Now, "yyyyMMdd")

    Public Property Id As Integer
        Get
            Id = _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Sub frmDepartamentosMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Id > 0 Then

            Departamento()

        Else

            Sucursales()
            Areas()

        End If

    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged

        Areas()

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If Id > 0 Then

            Nuevo()

        Else

            Edita()

        End If

    End Sub

#Region "FUNCIONES"

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

    Private Sub Areas()

        cmbArea.DataSource = Nothing
        cmbArea.Items.Clear()
        cmbArea.Text = ""
        cmbArea.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_Area()

        cmbArea.ValueMember = "id_area"
        cmbArea.DisplayMember = "area"
        cmbArea.DataSource = dsObj.Tables("Area")

    End Sub

    Private Sub Departamento()

        Sucursales()
        Areas()

        Dim rdrObj As MySqlDataReader

        rdrObj = Obtiene_departamento(Id)

        While rdrObj.Read

            txtDepartamento.Text = rdrObj.Item("departamento")

            If rdrObj.Item("estatus") = 1 Then
                chbEstatus.CheckState = CheckState.Checked
            Else
                chbEstatus.CheckState = CheckState.Unchecked
            End If

            dtpAlta.Value = rdrObj.Item("fecha_alta")
            dtpBaja.Value = rdrObj.Item("fecha_baja")

            cmbArea.Text = rdrObj.Item("area")
            cmbSucursal.Text = rdrObj.Item("sucursal")

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
        strSql += "departamento "
        strSql += "(departamento, "
        strSql += "estatus, "
        strSql += "fecha_alta, "
        strSql += "fecha_baja, "
        strSql += "id_area, "
        strSql += "id_sucursal) "
        strSql += "VALUES "
        strSql += "('" & txtDepartamento.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "1, "
        Else
            strSql += "0, "
        End If

        strSql += "'" & Format(dtpAlta.Value, "yyyyMMdd") & "', "
        strSql += "'" & Format(dtpBaja.Value, "yyyyMMdd") & "', "
        strSql += "'" & cmbArea.SelectedValue & "', "
        strSql += "'" & cmbSucursal.SelectedValue & "')"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        strSql += "departamento "
        strSql += "SET "
        strSql += "departamento = '" & txtDepartamento.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "estatus = 1, "
        Else
            strSql += "estatus = 0, "
        End If

        strSql += "fecha_alta = '" & Format(dtpAlta.Value, "yyyyMMdd") & "', "
        strSql += "fecha_baja = '" & Format(dtpBaja.Value, "yyyyMMdd") & "', "
        strSql += "id_area = '" & cmbArea.SelectedValue & "', "
        strSql += "id_sucursal = '" & cmbSucursal.SelectedValue & "' "
        strSql += "WHERE "
        strSql += "id_departamento = '" & Id & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

#End Region

End Class