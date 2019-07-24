Imports MySql.Data.MySqlClient

Public Class frmSucursalesMod

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

    Private Sub frmSucursalesMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Id > 0 Then

            Sucursal()

        Else

            Pais()
            Estado()
            Ciudad()

            txtSucursal.Focus()

        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If Id > 0 Then
            Editar()
        Else
            Nuevo()
        End If

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        Ciudad()

    End Sub

#Region "FUNCIONES"

    Private Sub Pais()

        cmbPais.DataSource = Nothing
        cmbPais.Items.Clear()
        cmbPais.Text = ""
        cmbPais.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_pais()

        cmbPais.ValueMember = "id_pais"
        cmbPais.DisplayMember = "pais_nombre"
        cmbPais.DataSource = dsObj.Tables("Pais")

    End Sub

    Private Sub Estado()

        cmbEstado.DataSource = Nothing
        cmbEstado.Items.Clear()
        cmbEstado.Text = ""
        cmbEstado.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_estado(cmbPais.SelectedValue)

        cmbEstado.ValueMember = "id_estado"
        cmbEstado.DisplayMember = "estado_nombre"
        cmbEstado.DataSource = dsObj.Tables("Estado")

    End Sub

    Private Sub Ciudad()

        cmbCiudad.DataSource = Nothing
        cmbCiudad.Items.Clear()
        cmbCiudad.Text = ""
        cmbCiudad.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_ciudad(cmbEstado.SelectedValue)

        cmbCiudad.ValueMember = "id_ciudad"
        cmbCiudad.DisplayMember = "ciudad_nombre"
        cmbCiudad.DataSource = dsObj.Tables("Ciudad")

    End Sub

    Private Sub Sucursal()

        Pais()
        Estado()
        Ciudad()

        Dim rdrObj As MySqlDataReader

        rdrObj = Obtiene_sucursal(Id)

        While rdrObj.Read

            txtSucursal.Text = rdrObj.Item("sucursal")
            txtRazonSocial.Text = rdrObj.Item("razon_social")
            txtRfc.Text = rdrObj.Item("rfc")
            txtCalle.Text = rdrObj.Item("calle")
            txtNext.Text = rdrObj.Item("num_ext")
            txtNint.Text = rdrObj.Item("num_int")
            txtColonia.Text = rdrObj.Item("colonia")
            cmbPais.Text = rdrObj.Item("pais_nombre")
            cmbEstado.Text = rdrObj.Item("estado_nombre")
            cmbCiudad.Text = rdrObj.Item("ciudad_nombre")
            txtCodPos.Text = rdrObj.Item("codigo_pos")
            txtTelefono.Text = rdrObj.Item("telefono")
            txtContacto.Text = rdrObj.Item("contacto")
            txtMail.Text = rdrObj.Item("mail")

            If rdrObj.Item("estatus") = 1 Then
                chbEstatus.CheckState = CheckState.Checked
            Else
                chbEstatus.CheckState = CheckState.Unchecked
            End If

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
        strSql += "sucursal "
        strSql += "(id_empresa, "
        strSql += "sucursal, "
        strSql += "razon_social, "
        strSql += "rfc, "
        strSql += "calle, "
        strSql += "num_ext, "
        strSql += "num_int, "
        strSql += "colonia, "
        strSql += "id_pais, "
        strSql += "id_estado, "
        strSql += "id_ciudad, "
        strSql += "codigo_pos, "
        strSql += "telefono, "
        strSql += "contacto, "
        strSql += "mail, "
        strSql += "estatus) "
        strSql += "VALUES "
        strSql += "(1, "
        strSql += "'" & txtSucursal.Text & "', "
        strSql += "'" & txtRazonSocial.Text & "', "
        strSql += "'" & txtRfc.Text & "', "
        strSql += "'" & txtCalle.Text & "', "
        strSql += "'" & txtNext.Text & "', "
        strSql += "'" & txtNint.Text & "', "
        strSql += "'" & txtColonia.Text & "', "
        strSql += "'" & cmbPais.SelectedValue & "', "
        strSql += "'" & cmbEstado.SelectedValue & "', "
        strSql += "'" & cmbCiudad.SelectedValue & "', "
        strSql += "'" & txtCodPos.Text & "', "
        strSql += "'" & txtTelefono.Text & "', "
        strSql += "'" & txtContacto.Text & "', "
        strSql += "'" & txtMail.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql = "1)"
        Else
            strSql += "0)"
        End If

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Guardados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

    Private Sub Editar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim strOtr As String

        strSql = "UPDATE "
        strSql += "sucursal "
        strSql += "SET "
        strSql += "sucursal = '" & txtSucursal.Text & "', "
        strSql += "razon_social = '" & txtRazonSocial.Text & "', "
        strSql += "rfc = '" & txtRfc.Text & "', "
        strSql += "calle = '" & txtCalle.Text & "', "
        strSql += "num_ext = '" & txtNext.Text & "', "
        strSql += "num_int = '" & txtNint.Text & "', "
        strSql += "colonia = '" & txtColonia.Text & "', "
        strSql += "id_pais = '" & cmbPais.SelectedValue & "', "
        strSql += "id_estado = '" & cmbEstado.SelectedValue & "', "
        strSql += "id_ciudad = '" & cmbCiudad.SelectedValue & "', "
        strSql += "codigo_pos = '" & txtCodPos.Text & "', "
        strSql += "telefono = '" & txtTelefono.Text & "', "
        strSql += "contacto = '" & txtContacto.Text & "', "
        strSql += "mail = '" & txtMail.Text & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql = "estatus = 1 "
        Else
            strSql += "estatus = 0 "
        End If

        strSql += "WHERE "
        strSql += "id_sucursal = '" & Id & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Actualizados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Actualizar los Datos, " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

#End Region

End Class