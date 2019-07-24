Imports MySql.Data.MySqlClient

Public Class frmEmpleadosMod

    Dim _Clave As Integer
    Dim Fecha As String = Format(Date.Now, "yyyyMMdd")

    Public Property Clave As Integer
        Get
            Clave = _Clave
        End Get
        Set(value As Integer)
            _Clave = value
        End Set
    End Property

    Private Sub frmEmpleadosMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Clave > 0 Then
            Empleado()
            txtClave.ReadOnly = True
        Else
            Habilita()
            dtpFechaBaja.Enabled = False
        End If

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

        Ciudad()

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If txtClave.Text = "" Then
            MessageBox.Show("Debe de Indicar la Clave del Empleado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtClave.Focus()
            Exit Sub

        ElseIf txtApaterno.Text = "" Then
            MessageBox.Show("Debe de Indicar el Apellido Paterno del Empleado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtApaterno.Focus()
            Exit Sub

        ElseIf txtAmaterno.Text = "" Then
            MessageBox.Show("Debe de Indicar el Apellido Materno del Empleado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAmaterno.Focus()
            Exit Sub

        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Debe de Indicar el Nombre del Empleado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
            Exit Sub

        Else

            If Clave > 0 Then
                Edita()
            Else
                Guardar()
            End If

            Me.Close()

        End If

    End Sub

#Region "FUNCIONES"

    Private Sub Habilita()

        txtClave.ReadOnly = False
        txtApaterno.ReadOnly = False
        txtAmaterno.ReadOnly = False
        txtNombre.ReadOnly = False
        txtRfc.ReadOnly = False
        txtNss.ReadOnly = False
        txtCurp.ReadOnly = False
        cmbBancoSat.Enabled = True
        txtCuentaBanco.ReadOnly = False
        dtpFechaIngreso.Enabled = True
        dtpFechaBaja.Enabled = True
        cmbJornada.Enabled = True
        cmbSalario.Enabled = True
        cmbDepartamento.Enabled = True
        txtPuesto.ReadOnly = False
        txtSalarioDiario.ReadOnly = False
        cmbPago.Enabled = True
        cmbContrato.Enabled = True
        txtCorreo.ReadOnly = False
        txtTelefono.ReadOnly = False
        dtpFechaNa.Enabled = True
        txtCalle.ReadOnly = False
        txtNext.ReadOnly = False
        txtNint.ReadOnly = False
        txtColonia.ReadOnly = False
        txtCodigoPos.ReadOnly = False
        cmbPais.Enabled = True
        cmbEstado.Enabled = True
        cmbCiudad.Enabled = True
        cmbSucursal.Enabled = True
        chbEstatus.Enabled = True

        Pais()
        Estado()
        Ciudad()
        Departamentos()
        Banco_sat()
        Jornada()
        Tipo_salario()
        Metodo_pago()
        Contrato()
        Sucursales()

    End Sub

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

    Private Sub Departamentos()

        cmbDepartamento.DataSource = Nothing
        cmbDepartamento.Items.Clear()
        cmbDepartamento.Text = ""
        cmbDepartamento.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_departamento()

        cmbDepartamento.ValueMember = "id_departamento"
        cmbDepartamento.DisplayMember = "departamento"
        cmbDepartamento.DataSource = dsObj.Tables("Departamento")

    End Sub

    Private Sub Banco_sat()

        cmbBancoSat.DataSource = Nothing
        cmbBancoSat.Items.Clear()
        cmbBancoSat.Text = ""
        cmbBancoSat.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_bancosat()

        cmbBancoSat.ValueMember = "id_banco_sat"
        cmbBancoSat.DisplayMember = "banco_sat"
        cmbBancoSat.DataSource = dsObj.Tables("BancoSat")

    End Sub

    Private Sub Jornada()

        cmbJornada.DataSource = Nothing
        cmbJornada.Items.Clear()
        cmbJornada.Text = ""
        cmbJornada.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_jornada()

        cmbJornada.ValueMember = "id_jornada"
        cmbJornada.DisplayMember = "jornada"
        cmbJornada.DataSource = dsObj.Tables("Jornada")

    End Sub

    Private Sub Tipo_salario()

        cmbSalario.DataSource = Nothing
        cmbSalario.Items.Clear()
        cmbSalario.Text = ""
        cmbSalario.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_tiposalario()

        cmbSalario.ValueMember = "id_tipo_salario"
        cmbSalario.DisplayMember = "tipo_salario"
        cmbSalario.DataSource = dsObj.Tables("TipoSalario")

    End Sub

    Private Sub Metodo_pago()

        cmbPago.DataSource = Nothing
        cmbPago.Items.Clear()
        cmbPago.Text = ""
        cmbPago.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_metodopago()

        cmbPago.ValueMember = "id_metodo_pago"
        cmbPago.DisplayMember = "metodo_pago"
        cmbPago.DataSource = dsObj.Tables("MetodoPago")

    End Sub

    Private Sub Contrato()

        cmbContrato.DataSource = Nothing
        cmbContrato.Items.Clear()
        cmbContrato.Text = ""
        cmbContrato.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_contrato()

        cmbContrato.ValueMember = "id_contrato"
        cmbContrato.DisplayMember = "contrato"
        cmbContrato.DataSource = dsObj.Tables("Contrato")

    End Sub

    Private Sub Empleado()

        Habilita()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "a.clave, "
        strSql += "a.a_paterno, "
        strSql += "a.a_materno, "
        strSql += "a.nombre, "
        strSql += "a.rfc, "
        strSql += "a.nss, "
        strSql += "a.curp, "
        strSql += "b.banco_sat, "
        strSql += "a.cuenta_banco, "
        strSql += "a.fecha_ingreso, "
        strSql += "a.fecha_baja, "
        strSql += "c.jornada, "
        strSql += "d.tipo_salario, "
        strSql += "e.departamento, "
        strSql += "a.puesto, "
        strSql += "a.salario_diario, "
        strSql += "f.metodo_pago, "
        strSql += "g.contrato, "
        strSql += "a.correo, "
        strSql += "a.telefono, "
        strSql += "a.fecha_nac, "
        strSql += "a.calle, "
        strSql += "a.num_ext, "
        strSql += "a.num_int, "
        strSql += "a.colonia, "
        strSql += "a.codigo_pos, "
        strSql += "h.pais_nombre, "
        strSql += "i.estado_nombre, "
        strSql += "j.ciudad_nombre, "
        strSql += "k.sucursal, "
        strSql += "a.estatus, "
        strSql += "a.sector "
        strSql += "FROM "
        strSql += "empleado a, "
        strSql += "banco_sat b, "
        strSql += "jornada c, "
        strSql += "tipo_salario d, "
        strSql += "departamento e, "
        strSql += "metodo_pagosat f, "
        strSql += "contrato g, "
        strSql += "pais h, "
        strSql += "estado i, "
        strSql += "ciudad j, "
        strSql += "sucursal k "
        strSql += "WHERE "
        strSql += "a.id_banco = b.id_banco_sat AND "
        strSql += "a.id_jornada = c.id_jornada AND "
        strSql += "a.id_salario = d.id_tipo_salario AND "
        strSql += "a.id_departamento = e.id_departamento AND "
        strSql += "a.id_pago = f.id_metodo_pago AND "
        strSql += "a.id_contrato = g.id_contrato AND "
        strSql += "a.id_pais = h.id_pais AND "
        strSql += "a.id_estado = i.id_estado AND "
        strSql += "a.id_ciudad = j.id_ciudad AND "
        strSql += "a.id_sucursal = k.id_sucursal AND "
        strSql += "a.clave = '" & Clave & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            txtClave.Text = rdrObj.Item("clave")
            txtApaterno.Text = rdrObj.Item("a_paterno")
            txtAmaterno.Text = rdrObj.Item("a_materno")
            txtNombre.Text = rdrObj.Item("nombre")
            txtRfc.Text = rdrObj.Item("rfc")
            txtNss.Text = rdrObj.Item("nss")
            txtCurp.Text = rdrObj.Item("curp")
            cmbBancoSat.Text = rdrObj.Item("banco_sat")
            txtCuentaBanco.Text = rdrObj.Item("cuenta_banco")
            dtpFechaIngreso.Value = rdrObj.Item("fecha_ingreso")
            dtpFechaBaja.Value = rdrObj.Item("fecha_baja")
            cmbJornada.Text = rdrObj.Item("jornada")
            cmbSalario.Text = rdrObj.Item("tipo_salario")
            cmbDepartamento.Text = rdrObj.Item("departamento")
            txtPuesto.Text = rdrObj.Item("puesto")
            txtSalarioDiario.Text = rdrObj.Item("salario_diario")
            cmbPago.Text = rdrObj.Item("metodo_pago")
            cmbContrato.Text = rdrObj.Item("contrato")
            txtCorreo.Text = rdrObj.Item("correo")
            txtTelefono.Text = rdrObj.Item("telefono")
            dtpFechaNa.Value = rdrObj.Item("fecha_nac")
            txtCalle.Text = rdrObj.Item("calle")
            txtNext.Text = rdrObj.Item("num_ext")
            txtNint.Text = rdrObj.Item("num_int")
            txtColonia.Text = rdrObj.Item("colonia")
            txtCodigoPos.Text = rdrObj.Item("codigo_pos")
            cmbPais.Text = rdrObj.Item("pais_nombre")
            cmbEstado.Text = rdrObj.Item("estado_nombre")
            cmbCiudad.Text = rdrObj.Item("ciudad_nombre")
            cmbSucursal.Text = rdrObj.Item("sucursal")

            If rdrObj.Item("estatus") = 1 Then
                chbEstatus.CheckState = CheckState.Checked
            ElseIf rdrObj.Item("estatus") = 0 Then
                chbEstatus.CheckState = CheckState.Unchecked
            End If

        End While

        rdrObj.Close()
        cnObj.Close()

    End Sub

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        Dim strOtr As String

        strSql = "INSERT "
        strSql += "INTO "
        strSql += "empleado "
        strSql += "(clave, "
        strSql += "a_paterno, "
        strSql += "a_materno, "
        strSql += "nombre, "
        strSql += "rfc, "
        strSql += "nss, "
        strSql += "curp, "
        strSql += "id_banco, "
        strSql += "cuenta_banco, "
        strSql += "fecha_ingreso, "
        strSql += "fecha_baja, "
        strSql += "id_jornada, "
        strSql += "id_salario, "
        strSql += "id_departamento, "
        strSql += "puesto, "
        strSql += "salario_diario, "
        strSql += "id_pago, "
        strSql += "id_contrato, "
        strSql += "correo, "
        strSql += "telefono, "
        strSql += "fecha_nac, "
        strSql += "calle, "
        strSql += "num_ext, "
        strSql += "num_int, "
        strSql += "colonia, "
        strSql += "codigo_pos, "
        strSql += "id_pais, "
        strSql += "id_estado, "
        strSql += "id_ciudad, "
        strSql += "id_sucursal, "
        strSql += "estatus, "
        strSql += "sector) "
        strSql += "VALUES "
        strSql += "('" & txtClave.Text & "', "
        strSql += "'" & txtApaterno.Text & "', "
        strSql += "'" & txtAmaterno.Text & "', "
        strSql += "'" & txtNombre.Text & "', "
        strSql += "'" & txtRfc.Text & "', "
        strSql += "'" & txtNss.Text & "', "
        strSql += "'" & txtCurp.Text & "', "
        strSql += "'" & cmbBancoSat.SelectedValue & "', "
        strSql += "'" & txtCuentaBanco.Text & "', "
        strSql += "'" & Format(dtpFechaIngreso.Value, "yyyyMMdd") & "', "
        strSql += "'" & Format(dtpFechaIngreso.Value, "yyyyMMdd") & "', "
        strSql += "'" & cmbJornada.SelectedValue & "', "
        strSql += "'" & cmbSalario.SelectedValue & "', "
        strSql += "'" & cmbDepartamento.SelectedValue & "', "
        strSql += "'" & txtPuesto.Text & "', "
        strSql += "'" & txtSalarioDiario.Text & "', "
        strSql += "'" & cmbPago.SelectedValue & "', "
        strSql += "'" & cmbContrato.SelectedValue & "', "
        strSql += "'" & txtCorreo.Text & "', "
        strSql += "'" & txtTelefono.Text & "', "
        strSql += "'" & Format(dtpFechaNa.Value, "yyyyMMdd") & "', "
        strSql += "'" & txtCalle.Text & "', "
        strSql += "'" & txtNext.Text & "', "
        strSql += "'" & txtNint.Text & "',"
        strSql += "'" & txtColonia.Text & "', "
        strSql += "'" & txtCodigoPos.Text & "', "
        strSql += "'" & cmbPais.SelectedValue & "', "
        strSql += "'" & cmbEstado.SelectedValue & "', "
        strSql += "'" & cmbCiudad.SelectedValue & "', "
        strSql += "'" & cmbSucursal.SelectedValue & "', "

        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "1, "
        ElseIf chbEstatus.CheckState = CheckState.Unchecked Then
            strSql += "0, "
        End If

        strSql += "0 )"



        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Almacenados en la Base de Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar los Datos " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        strSql += "empleado "
        strSql += "SET "
        strSql += "a_paterno = '" & txtApaterno.Text & "', "
        strSql += "a_materno = '" & txtAmaterno.Text & "', "
        strSql += "nombre = '" & txtNombre.Text & "', "
        strSql += "rfc = '" & txtRfc.Text & "', "
        strSql += "nss = '" & txtNss.Text & "', "
        strSql += "curp = '" & txtCurp.Text & "', "
        strSql += "id_banco = '" & cmbBancoSat.SelectedValue & "', "
        strSql += "cuenta_banco = '" & txtCuentaBanco.Text & "', "
        strSql += "fecha_ingreso = '" & Format(dtpFechaIngreso.Value, "yyyyMMdd") & "', "
        strSql += "fecha_baja = '" & Format(dtpFechaIngreso.Value, "yyyyMMdd") & "', "
        strSql += "id_jornada = '" & cmbJornada.SelectedValue & "', "
        strSql += "id_salario = '" & cmbSalario.SelectedValue & "', "
        strSql += "id_departamento = '" & cmbDepartamento.SelectedValue & "', "
        strSql += "puesto = '" & txtPuesto.Text & "', "
        strSql += "salario_diario = '" & txtSalarioDiario.Text & "', "
        strSql += "id_pago = '" & cmbPago.SelectedValue & "', "
        strSql += "id_contrato = '" & cmbContrato.SelectedValue & "', "
        strSql += "correo = '" & txtCorreo.Text & "', "
        strSql += "telefono = '" & txtTelefono.Text & "', "
        strSql += "fecha_nac = '" & Format(dtpFechaNa.Value, "yyyyMMdd") & "', "
        strSql += "calle = '" & txtCalle.Text & "', "
        strSql += "num_ext = '" & txtNext.Text & "', "
        strSql += "num_int = '" & txtNint.Text & "', "
        strSql += "colonia = '" & txtColonia.Text & "', "
        strSql += "codigo_pos = '" & txtCodigoPos.Text & "', "
        strSql += "id_pais = '" & cmbPais.SelectedValue & "', "
        strSql += "id_estado = '" & cmbEstado.SelectedValue & "', "
        strSql += "id_ciudad = '" & cmbCiudad.SelectedValue & "', "
        strSql += "id_sucursal = '" & cmbSucursal.SelectedValue & "', "
        If chbEstatus.CheckState = CheckState.Checked Then
            strSql += "estatus = 1 "
        ElseIf chbEstatus.CheckState = CheckState.Unchecked Then
            strSql += "estatus = 0 "
        End If

        strSql += "WHERE "
        strSql += "clave = '" & Clave & "'"

        cmdObj.CommandText = strSql

        Try
            cmdObj.ExecuteNonQuery()
            MessageBox.Show("Datos Actualizados en la Base de Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            strOtr = Replace(strSql, "'", "*")
            GeneraEvento(intSucursal, Fecha, strOtr)
            cnObj.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al Guardar los Datos " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cnObj.Close()

    End Sub

#End Region

End Class