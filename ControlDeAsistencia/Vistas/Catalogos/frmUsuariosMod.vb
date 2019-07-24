Imports MySql.Data.MySqlClient

Public Class frmUsuariosMod

    Dim _id As String

    Public Property Id As String
        Get
            Id = _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Private Sub frmUsuariosMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Id <> "" Then
            ObtieneUsuario()
            txtId.ReadOnly = True
        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If Id <> "" Then
            Editar()
        Else
            Nuevo()
        End If

    End Sub

#Region "FUNCIONES"

    Private Sub ObtieneUsuario()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "usr_id, "
        strSql += "usr_nombre, "
        strSql += "usr_paterno, "
        strSql += "usr_materno, "
        strSql += "usr_password, "
        strSql += "usr_activo, "
        strSql += "cambio_password "
        strSql += "FROM "
        strSql += "usuario "
        strSql += "WHERE "
        strSql += "usr_id = '" & Id & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            txtId.Text = rdrObj.Item("usr_id")
            txtNombre.Text = rdrObj.Item("usr_nombre")
            txtApaterno.Text = rdrObj.Item("usr_paterno")
            txtAmaterno.Text = rdrObj.Item("usr_materno")
            txtPassword.Text = rdrObj.Item("usr_password")

            If rdrObj.Item("usr_activo") = 1 Then
                chbActivo.CheckState = CheckState.Checked
            Else
                chbActivo.CheckState = CheckState.Unchecked
            End If

            If rdrObj.Item("cambio_password") = 1 Then
                chbCambio.CheckState = CheckState.Checked
            Else
                chbCambio.CheckState = CheckState.Unchecked
            End If

        End While

        rdrObj.Close()
        cnObj.Close()

    End Sub

    Private Sub Nuevo()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "INSERT "
        strSql += "INTO "
        strSql += "usuario "
        strSql += "(usr_id, "
        strSql += "usr_nombre, "
        strSql += "usr_paterno, "
        strSql += "usr_materno, "
        strSql += "usr_password, "
        strSql += "usr_activo, "
        strSql += "cambio_password) "
        strSql += "VALUES "
        strSql += "('" & txtId.Text & "', "
        strSql += "'" & txtNombre.Text & "', "
        strSql += "'" & txtApaterno.Text & "', "
        strSql += "'" & txtAmaterno.Text & "', "
        strSql += "'" & txtPassword.Text & "', "

        If chbActivo.CheckState = CheckState.Checked Then
            strSql += "1, "
        Else
            strSql += "0, "
        End If

        If chbCambio.CheckState = CheckState.Checked Then
            strSql = "1)"
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

    End Sub

    Private Sub Editar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "UPDATE "
        strSql += "usuario "
        strSql += "SET "
        strSql += "usr_nombre = '" & txtNombre.Text & "', "
        strSql += "usr_paterno = '" & txtApaterno.Text & "', "
        strSql += "usr_materno = '" & txtAmaterno.Text & "', "
        strSql += "usr_password = '" & txtPassword.Text & "', "

        If chbActivo.CheckState = CheckState.Checked Then
            strSql += "usr_activo = 1, "
        Else
            strSql += "usr_activo = 0, "
        End If

        If chbCambio.CheckState = CheckState.Checked Then
            strSql = "cambio_password = 1 "
        Else
            strSql += "cambio_password = 0 "
        End If

        strSql += "WHERE "
        strSql += "usr_id = '" & Id & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class