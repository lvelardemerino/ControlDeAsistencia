<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleadosMod
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleadosMod))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tcEmpleado = New System.Windows.Forms.TabControl()
        Me.tpDatosGenerales = New System.Windows.Forms.TabPage()
        Me.chbEstatus = New System.Windows.Forms.CheckBox()
        Me.txtCurp = New System.Windows.Forms.TextBox()
        Me.txtNss = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtAmaterno = New System.Windows.Forms.TextBox()
        Me.txtApaterno = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.dtpFechaNa = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNa = New System.Windows.Forms.Label()
        Me.lblCurp = New System.Windows.Forms.Label()
        Me.lblNss = New System.Windows.Forms.Label()
        Me.lblRfc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAmaterno = New System.Windows.Forms.Label()
        Me.lblApaterno = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.tpDireccion = New System.Windows.Forms.TabPage()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.txtCodigoPos = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtNint = New System.Windows.Forms.TextBox()
        Me.txtNext = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblCodigoPos = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblNint = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.tpDatosRh = New System.Windows.Forms.TabPage()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.dtpFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cmbContrato = New System.Windows.Forms.ComboBox()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.txtSalarioDiario = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cmbSalario = New System.Windows.Forms.ComboBox()
        Me.cmbJornada = New System.Windows.Forms.ComboBox()
        Me.txtCuentaBanco = New System.Windows.Forms.TextBox()
        Me.cmbBancoSat = New System.Windows.Forms.ComboBox()
        Me.lblFechaBaja = New System.Windows.Forms.Label()
        Me.lblFechaIngerso = New System.Windows.Forms.Label()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblSalarioDiario = New System.Windows.Forms.Label()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblJornada = New System.Windows.Forms.Label()
        Me.lblCuentaBanco = New System.Windows.Forms.Label()
        Me.lblBancoSat = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.tcEmpleado.SuspendLayout()
        Me.tpDatosGenerales.SuspendLayout()
        Me.tpDireccion.SuspendLayout()
        Me.tpDatosRh.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(492, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.ForeColor = System.Drawing.Color.White
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tcEmpleado
        '
        Me.tcEmpleado.Controls.Add(Me.tpDatosGenerales)
        Me.tcEmpleado.Controls.Add(Me.tpDireccion)
        Me.tcEmpleado.Controls.Add(Me.tpDatosRh)
        Me.tcEmpleado.Location = New System.Drawing.Point(0, 28)
        Me.tcEmpleado.Name = "tcEmpleado"
        Me.tcEmpleado.SelectedIndex = 0
        Me.tcEmpleado.Size = New System.Drawing.Size(495, 282)
        Me.tcEmpleado.TabIndex = 1
        '
        'tpDatosGenerales
        '
        Me.tpDatosGenerales.BackColor = System.Drawing.Color.Gainsboro
        Me.tpDatosGenerales.Controls.Add(Me.chbEstatus)
        Me.tpDatosGenerales.Controls.Add(Me.txtCurp)
        Me.tpDatosGenerales.Controls.Add(Me.txtNss)
        Me.tpDatosGenerales.Controls.Add(Me.txtRfc)
        Me.tpDatosGenerales.Controls.Add(Me.txtNombre)
        Me.tpDatosGenerales.Controls.Add(Me.txtAmaterno)
        Me.tpDatosGenerales.Controls.Add(Me.txtApaterno)
        Me.tpDatosGenerales.Controls.Add(Me.txtClave)
        Me.tpDatosGenerales.Controls.Add(Me.dtpFechaNa)
        Me.tpDatosGenerales.Controls.Add(Me.lblFechaNa)
        Me.tpDatosGenerales.Controls.Add(Me.lblCurp)
        Me.tpDatosGenerales.Controls.Add(Me.lblNss)
        Me.tpDatosGenerales.Controls.Add(Me.lblRfc)
        Me.tpDatosGenerales.Controls.Add(Me.lblNombre)
        Me.tpDatosGenerales.Controls.Add(Me.lblAmaterno)
        Me.tpDatosGenerales.Controls.Add(Me.lblApaterno)
        Me.tpDatosGenerales.Controls.Add(Me.lblClave)
        Me.tpDatosGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tpDatosGenerales.Name = "tpDatosGenerales"
        Me.tpDatosGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDatosGenerales.Size = New System.Drawing.Size(487, 256)
        Me.tpDatosGenerales.TabIndex = 0
        Me.tpDatosGenerales.Text = "Datos Generales"
        '
        'chbEstatus
        '
        Me.chbEstatus.AutoSize = True
        Me.chbEstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbEstatus.Location = New System.Drawing.Point(329, 213)
        Me.chbEstatus.Name = "chbEstatus"
        Me.chbEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbEstatus.Size = New System.Drawing.Size(134, 20)
        Me.chbEstatus.TabIndex = 16
        Me.chbEstatus.Text = "Empleado Activo"
        Me.chbEstatus.UseVisualStyleBackColor = True
        '
        'txtCurp
        '
        Me.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurp.Location = New System.Drawing.Point(275, 157)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.ReadOnly = True
        Me.txtCurp.Size = New System.Drawing.Size(156, 20)
        Me.txtCurp.TabIndex = 15
        '
        'txtNss
        '
        Me.txtNss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNss.Location = New System.Drawing.Point(51, 157)
        Me.txtNss.Name = "txtNss"
        Me.txtNss.ReadOnly = True
        Me.txtNss.Size = New System.Drawing.Size(145, 20)
        Me.txtNss.TabIndex = 14
        '
        'txtRfc
        '
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.Location = New System.Drawing.Point(270, 105)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.ReadOnly = True
        Me.txtRfc.Size = New System.Drawing.Size(140, 20)
        Me.txtRfc.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(72, 105)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(155, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtAmaterno
        '
        Me.txtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmaterno.Location = New System.Drawing.Point(328, 63)
        Me.txtAmaterno.Name = "txtAmaterno"
        Me.txtAmaterno.ReadOnly = True
        Me.txtAmaterno.Size = New System.Drawing.Size(135, 20)
        Me.txtAmaterno.TabIndex = 11
        '
        'txtApaterno
        '
        Me.txtApaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApaterno.Location = New System.Drawing.Point(93, 63)
        Me.txtApaterno.Name = "txtApaterno"
        Me.txtApaterno.ReadOnly = True
        Me.txtApaterno.Size = New System.Drawing.Size(134, 20)
        Me.txtApaterno.TabIndex = 10
        '
        'txtClave
        '
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClave.Location = New System.Drawing.Point(51, 20)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(98, 20)
        Me.txtClave.TabIndex = 9
        '
        'dtpFechaNa
        '
        Me.dtpFechaNa.Enabled = False
        Me.dtpFechaNa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNa.Location = New System.Drawing.Point(120, 210)
        Me.dtpFechaNa.Name = "dtpFechaNa"
        Me.dtpFechaNa.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaNa.TabIndex = 8
        '
        'lblFechaNa
        '
        Me.lblFechaNa.AutoSize = True
        Me.lblFechaNa.Location = New System.Drawing.Point(8, 212)
        Me.lblFechaNa.Name = "lblFechaNa"
        Me.lblFechaNa.Size = New System.Drawing.Size(96, 13)
        Me.lblFechaNa.TabIndex = 7
        Me.lblFechaNa.Text = "Fecha Nacimiento:"
        '
        'lblCurp
        '
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Location = New System.Drawing.Point(233, 160)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.Size = New System.Drawing.Size(40, 13)
        Me.lblCurp.TabIndex = 6
        Me.lblCurp.Text = "CURP:"
        '
        'lblNss
        '
        Me.lblNss.AutoSize = True
        Me.lblNss.Location = New System.Drawing.Point(8, 160)
        Me.lblNss.Name = "lblNss"
        Me.lblNss.Size = New System.Drawing.Size(32, 13)
        Me.lblNss.TabIndex = 5
        Me.lblNss.Text = "NSS:"
        '
        'lblRfc
        '
        Me.lblRfc.AutoSize = True
        Me.lblRfc.Location = New System.Drawing.Point(233, 108)
        Me.lblRfc.Name = "lblRfc"
        Me.lblRfc.Size = New System.Drawing.Size(31, 13)
        Me.lblRfc.TabIndex = 4
        Me.lblRfc.Text = "RFC:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(8, 108)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre(s):"
        '
        'lblAmaterno
        '
        Me.lblAmaterno.AutoSize = True
        Me.lblAmaterno.Location = New System.Drawing.Point(233, 66)
        Me.lblAmaterno.Name = "lblAmaterno"
        Me.lblAmaterno.Size = New System.Drawing.Size(89, 13)
        Me.lblAmaterno.TabIndex = 2
        Me.lblAmaterno.Text = "Apellido Materno:"
        '
        'lblApaterno
        '
        Me.lblApaterno.AutoSize = True
        Me.lblApaterno.Location = New System.Drawing.Point(8, 66)
        Me.lblApaterno.Name = "lblApaterno"
        Me.lblApaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblApaterno.TabIndex = 1
        Me.lblApaterno.Text = "Apellido Paterno:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(8, 23)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(37, 13)
        Me.lblClave.TabIndex = 0
        Me.lblClave.Text = "Clave:"
        '
        'tpDireccion
        '
        Me.tpDireccion.BackColor = System.Drawing.Color.Gainsboro
        Me.tpDireccion.Controls.Add(Me.txtCorreo)
        Me.tpDireccion.Controls.Add(Me.lblCorreo)
        Me.tpDireccion.Controls.Add(Me.txtTelefono)
        Me.tpDireccion.Controls.Add(Me.lblTelefono)
        Me.tpDireccion.Controls.Add(Me.cmbCiudad)
        Me.tpDireccion.Controls.Add(Me.cmbEstado)
        Me.tpDireccion.Controls.Add(Me.cmbPais)
        Me.tpDireccion.Controls.Add(Me.txtCodigoPos)
        Me.tpDireccion.Controls.Add(Me.txtColonia)
        Me.tpDireccion.Controls.Add(Me.txtNint)
        Me.tpDireccion.Controls.Add(Me.txtNext)
        Me.tpDireccion.Controls.Add(Me.txtCalle)
        Me.tpDireccion.Controls.Add(Me.lblCiudad)
        Me.tpDireccion.Controls.Add(Me.lblEstado)
        Me.tpDireccion.Controls.Add(Me.lblPais)
        Me.tpDireccion.Controls.Add(Me.lblCodigoPos)
        Me.tpDireccion.Controls.Add(Me.lblColonia)
        Me.tpDireccion.Controls.Add(Me.lblNint)
        Me.tpDireccion.Controls.Add(Me.lblNext)
        Me.tpDireccion.Controls.Add(Me.lblCalle)
        Me.tpDireccion.Location = New System.Drawing.Point(4, 22)
        Me.tpDireccion.Name = "tpDireccion"
        Me.tpDireccion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDireccion.Size = New System.Drawing.Size(487, 256)
        Me.tpDireccion.TabIndex = 1
        Me.tpDireccion.Text = "Direccción"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(57, 186)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(292, 20)
        Me.txtCorreo.TabIndex = 19
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(8, 189)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 18
        Me.lblCorreo.Text = "Correo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(279, 140)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(146, 20)
        Me.txtTelefono.TabIndex = 17
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(221, 143)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 16
        Me.lblTelefono.Text = "Telefono:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.Enabled = False
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(57, 140)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(134, 21)
        Me.cmbCiudad.TabIndex = 15
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(265, 97)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(134, 21)
        Me.cmbEstado.TabIndex = 14
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.Enabled = False
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(59, 97)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(134, 21)
        Me.cmbPais.TabIndex = 13
        '
        'txtCodigoPos
        '
        Me.txtCodigoPos.Location = New System.Drawing.Point(265, 59)
        Me.txtCodigoPos.Name = "txtCodigoPos"
        Me.txtCodigoPos.ReadOnly = True
        Me.txtCodigoPos.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoPos.TabIndex = 12
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(59, 59)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.ReadOnly = True
        Me.txtColonia.Size = New System.Drawing.Size(122, 20)
        Me.txtColonia.TabIndex = 11
        '
        'txtNint
        '
        Me.txtNint.Location = New System.Drawing.Point(381, 18)
        Me.txtNint.Name = "txtNint"
        Me.txtNint.ReadOnly = True
        Me.txtNint.Size = New System.Drawing.Size(86, 20)
        Me.txtNint.TabIndex = 10
        '
        'txtNext
        '
        Me.txtNext.Location = New System.Drawing.Point(238, 18)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.ReadOnly = True
        Me.txtNext.Size = New System.Drawing.Size(86, 20)
        Me.txtNext.TabIndex = 9
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(47, 18)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(134, 20)
        Me.txtCalle.TabIndex = 8
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(8, 143)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudad.TabIndex = 7
        Me.lblCiudad.Text = "Ciudad:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(221, 100)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 6
        Me.lblEstado.Text = "Estado:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(8, 100)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 13)
        Me.lblPais.TabIndex = 5
        Me.lblPais.Text = "Pais:"
        '
        'lblCodigoPos
        '
        Me.lblCodigoPos.AutoSize = True
        Me.lblCodigoPos.Location = New System.Drawing.Point(187, 62)
        Me.lblCodigoPos.Name = "lblCodigoPos"
        Me.lblCodigoPos.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPos.TabIndex = 4
        Me.lblCodigoPos.Text = "Codigo Postal"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(8, 62)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 3
        Me.lblColonia.Text = "Colonia:"
        '
        'lblNint
        '
        Me.lblNint.AutoSize = True
        Me.lblNint.Location = New System.Drawing.Point(333, 21)
        Me.lblNint.Name = "lblNint"
        Me.lblNint.Size = New System.Drawing.Size(42, 13)
        Me.lblNint.TabIndex = 2
        Me.lblNint.Text = "No. Int."
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Location = New System.Drawing.Point(187, 21)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(45, 13)
        Me.lblNext.TabIndex = 1
        Me.lblNext.Text = "No. Ext."
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(8, 21)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle:"
        '
        'tpDatosRh
        '
        Me.tpDatosRh.BackColor = System.Drawing.Color.Gainsboro
        Me.tpDatosRh.Controls.Add(Me.cmbSucursal)
        Me.tpDatosRh.Controls.Add(Me.lblSucursal)
        Me.tpDatosRh.Controls.Add(Me.dtpFechaBaja)
        Me.tpDatosRh.Controls.Add(Me.dtpFechaIngreso)
        Me.tpDatosRh.Controls.Add(Me.cmbContrato)
        Me.tpDatosRh.Controls.Add(Me.cmbPago)
        Me.tpDatosRh.Controls.Add(Me.txtSalarioDiario)
        Me.tpDatosRh.Controls.Add(Me.txtPuesto)
        Me.tpDatosRh.Controls.Add(Me.cmbDepartamento)
        Me.tpDatosRh.Controls.Add(Me.cmbSalario)
        Me.tpDatosRh.Controls.Add(Me.cmbJornada)
        Me.tpDatosRh.Controls.Add(Me.txtCuentaBanco)
        Me.tpDatosRh.Controls.Add(Me.cmbBancoSat)
        Me.tpDatosRh.Controls.Add(Me.lblFechaBaja)
        Me.tpDatosRh.Controls.Add(Me.lblFechaIngerso)
        Me.tpDatosRh.Controls.Add(Me.lblContrato)
        Me.tpDatosRh.Controls.Add(Me.lblPago)
        Me.tpDatosRh.Controls.Add(Me.lblSalarioDiario)
        Me.tpDatosRh.Controls.Add(Me.lblPuesto)
        Me.tpDatosRh.Controls.Add(Me.lblDepartamento)
        Me.tpDatosRh.Controls.Add(Me.lblSalario)
        Me.tpDatosRh.Controls.Add(Me.lblJornada)
        Me.tpDatosRh.Controls.Add(Me.lblCuentaBanco)
        Me.tpDatosRh.Controls.Add(Me.lblBancoSat)
        Me.tpDatosRh.Location = New System.Drawing.Point(4, 22)
        Me.tpDatosRh.Name = "tpDatosRh"
        Me.tpDatosRh.Size = New System.Drawing.Size(487, 256)
        Me.tpDatosRh.TabIndex = 2
        Me.tpDatosRh.Text = "Datos RH"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(315, 52)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(161, 21)
        Me.cmbSucursal.TabIndex = 23
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(252, 55)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 22
        Me.lblSucursal.Text = "Sucursal:"
        '
        'dtpFechaBaja
        '
        Me.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBaja.Location = New System.Drawing.Point(301, 219)
        Me.dtpFechaBaja.Name = "dtpFechaBaja"
        Me.dtpFechaBaja.Size = New System.Drawing.Size(133, 20)
        Me.dtpFechaBaja.TabIndex = 21
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(92, 219)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(133, 20)
        Me.dtpFechaIngreso.TabIndex = 20
        '
        'cmbContrato
        '
        Me.cmbContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContrato.FormattingEnabled = True
        Me.cmbContrato.Location = New System.Drawing.Point(56, 172)
        Me.cmbContrato.Name = "cmbContrato"
        Me.cmbContrato.Size = New System.Drawing.Size(247, 21)
        Me.cmbContrato.TabIndex = 19
        '
        'cmbPago
        '
        Me.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Location = New System.Drawing.Point(292, 129)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(184, 21)
        Me.cmbPago.TabIndex = 18
        '
        'txtSalarioDiario
        '
        Me.txtSalarioDiario.Location = New System.Drawing.Point(79, 129)
        Me.txtSalarioDiario.Name = "txtSalarioDiario"
        Me.txtSalarioDiario.ReadOnly = True
        Me.txtSalarioDiario.Size = New System.Drawing.Size(146, 20)
        Me.txtSalarioDiario.TabIndex = 17
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(326, 91)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.ReadOnly = True
        Me.txtPuesto.Size = New System.Drawing.Size(150, 20)
        Me.txtPuesto.TabIndex = 16
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(79, 91)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(194, 21)
        Me.cmbDepartamento.TabIndex = 15
        '
        'cmbSalario
        '
        Me.cmbSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalario.FormattingEnabled = True
        Me.cmbSalario.Location = New System.Drawing.Point(360, 172)
        Me.cmbSalario.Name = "cmbSalario"
        Me.cmbSalario.Size = New System.Drawing.Size(116, 21)
        Me.cmbSalario.TabIndex = 14
        '
        'cmbJornada
        '
        Me.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJornada.FormattingEnabled = True
        Me.cmbJornada.Location = New System.Drawing.Point(79, 52)
        Me.cmbJornada.Name = "cmbJornada"
        Me.cmbJornada.Size = New System.Drawing.Size(167, 21)
        Me.cmbJornada.TabIndex = 13
        '
        'txtCuentaBanco
        '
        Me.txtCuentaBanco.Location = New System.Drawing.Point(315, 18)
        Me.txtCuentaBanco.Name = "txtCuentaBanco"
        Me.txtCuentaBanco.ReadOnly = True
        Me.txtCuentaBanco.Size = New System.Drawing.Size(161, 20)
        Me.txtCuentaBanco.TabIndex = 12
        '
        'cmbBancoSat
        '
        Me.cmbBancoSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancoSat.FormattingEnabled = True
        Me.cmbBancoSat.Location = New System.Drawing.Point(79, 18)
        Me.cmbBancoSat.Name = "cmbBancoSat"
        Me.cmbBancoSat.Size = New System.Drawing.Size(146, 21)
        Me.cmbBancoSat.TabIndex = 11
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.AutoSize = True
        Me.lblFechaBaja.Location = New System.Drawing.Point(231, 225)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaBaja.TabIndex = 10
        Me.lblFechaBaja.Text = "Fecha Baja:"
        '
        'lblFechaIngerso
        '
        Me.lblFechaIngerso.AutoSize = True
        Me.lblFechaIngerso.Location = New System.Drawing.Point(8, 225)
        Me.lblFechaIngerso.Name = "lblFechaIngerso"
        Me.lblFechaIngerso.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIngerso.TabIndex = 9
        Me.lblFechaIngerso.Text = "Fecha Ingreso:"
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Location = New System.Drawing.Point(8, 175)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(50, 13)
        Me.lblContrato.TabIndex = 8
        Me.lblContrato.Text = "Contrato:"
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(252, 132)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(35, 13)
        Me.lblPago.TabIndex = 7
        Me.lblPago.Text = "Pago:"
        '
        'lblSalarioDiario
        '
        Me.lblSalarioDiario.AutoSize = True
        Me.lblSalarioDiario.Location = New System.Drawing.Point(8, 136)
        Me.lblSalarioDiario.Name = "lblSalarioDiario"
        Me.lblSalarioDiario.Size = New System.Drawing.Size(72, 13)
        Me.lblSalarioDiario.TabIndex = 6
        Me.lblSalarioDiario.Text = "Salario Diario:"
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(279, 94)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(43, 13)
        Me.lblPuesto.TabIndex = 5
        Me.lblPuesto.Text = "Puesto:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(8, 94)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 4
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(312, 175)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(42, 13)
        Me.lblSalario.TabIndex = 3
        Me.lblSalario.Text = "Salario:"
        '
        'lblJornada
        '
        Me.lblJornada.AutoSize = True
        Me.lblJornada.Location = New System.Drawing.Point(8, 55)
        Me.lblJornada.Name = "lblJornada"
        Me.lblJornada.Size = New System.Drawing.Size(48, 13)
        Me.lblJornada.TabIndex = 2
        Me.lblJornada.Text = "Jornada:"
        '
        'lblCuentaBanco
        '
        Me.lblCuentaBanco.AutoSize = True
        Me.lblCuentaBanco.Location = New System.Drawing.Point(231, 21)
        Me.lblCuentaBanco.Name = "lblCuentaBanco"
        Me.lblCuentaBanco.Size = New System.Drawing.Size(78, 13)
        Me.lblCuentaBanco.TabIndex = 1
        Me.lblCuentaBanco.Text = "Cuenta Banco:"
        '
        'lblBancoSat
        '
        Me.lblBancoSat.AutoSize = True
        Me.lblBancoSat.Location = New System.Drawing.Point(8, 21)
        Me.lblBancoSat.Name = "lblBancoSat"
        Me.lblBancoSat.Size = New System.Drawing.Size(65, 13)
        Me.lblBancoSat.TabIndex = 0
        Me.lblBancoSat.Text = "Banco SAT:"
        '
        'frmEmpleadosMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 308)
        Me.Controls.Add(Me.tcEmpleado)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpleadosMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.tcEmpleado.ResumeLayout(False)
        Me.tpDatosGenerales.ResumeLayout(False)
        Me.tpDatosGenerales.PerformLayout()
        Me.tpDireccion.ResumeLayout(False)
        Me.tpDireccion.PerformLayout()
        Me.tpDatosRh.ResumeLayout(False)
        Me.tpDatosRh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tcEmpleado As System.Windows.Forms.TabControl
    Friend WithEvents tpDatosGenerales As System.Windows.Forms.TabPage
    Friend WithEvents txtCurp As System.Windows.Forms.TextBox
    Friend WithEvents txtNss As System.Windows.Forms.TextBox
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtAmaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaNa As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNa As System.Windows.Forms.Label
    Friend WithEvents lblCurp As System.Windows.Forms.Label
    Friend WithEvents lblNss As System.Windows.Forms.Label
    Friend WithEvents lblRfc As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblAmaterno As System.Windows.Forms.Label
    Friend WithEvents lblApaterno As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents tpDireccion As System.Windows.Forms.TabPage
    Friend WithEvents tpDatosRh As System.Windows.Forms.TabPage
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoPos As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtNint As System.Windows.Forms.TextBox
    Friend WithEvents txtNext As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPos As System.Windows.Forms.Label
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblNint As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbContrato As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtSalarioDiario As System.Windows.Forms.TextBox
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSalario As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJornada As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuentaBanco As System.Windows.Forms.TextBox
    Friend WithEvents cmbBancoSat As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaBaja As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngerso As System.Windows.Forms.Label
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents lblPago As System.Windows.Forms.Label
    Friend WithEvents lblSalarioDiario As System.Windows.Forms.Label
    Friend WithEvents lblPuesto As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblSalario As System.Windows.Forms.Label
    Friend WithEvents lblJornada As System.Windows.Forms.Label
    Friend WithEvents lblCuentaBanco As System.Windows.Forms.Label
    Friend WithEvents lblBancoSat As System.Windows.Forms.Label
    Friend WithEvents chbEstatus As System.Windows.Forms.CheckBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
End Class
