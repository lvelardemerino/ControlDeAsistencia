<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiempo))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(318, 25)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTipo)
        Me.Panel1.Controls.Add(Me.txtTiempo)
        Me.Panel1.Controls.Add(Me.lblTiempo)
        Me.Panel1.Controls.Add(Me.cmbMes)
        Me.Panel1.Controls.Add(Me.lblMes)
        Me.Panel1.Controls.Add(Me.cmbAnio)
        Me.Panel1.Controls.Add(Me.lblAnio)
        Me.Panel1.Controls.Add(Me.cmbEmpleado)
        Me.Panel1.Controls.Add(Me.lblEmpleado)
        Me.Panel1.Controls.Add(Me.cmbSucursal)
        Me.Panel1.Controls.Add(Me.lblSucursal)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 221)
        Me.Panel1.TabIndex = 1
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"FAVOR", "CONTRA"})
        Me.cmbTipo.Location = New System.Drawing.Point(185, 172)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(92, 21)
        Me.cmbTipo.TabIndex = 10
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(75, 172)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(78, 20)
        Me.txtTiempo.TabIndex = 9
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(24, 175)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(45, 13)
        Me.lblTiempo.TabIndex = 8
        Me.lblTiempo.Text = "Tiempo:"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmbMes.Location = New System.Drawing.Point(185, 117)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(92, 21)
        Me.cmbMes.TabIndex = 7
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(150, 120)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 6
        Me.lblMes.Text = "Mes:"
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060"})
        Me.cmbAnio.Location = New System.Drawing.Point(59, 117)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(76, 21)
        Me.cmbAnio.TabIndex = 5
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(24, 120)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 4
        Me.lblAnio.Text = "Año:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(81, 64)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(196, 21)
        Me.cmbEmpleado.TabIndex = 3
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(24, 67)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 2
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(81, 20)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(196, 21)
        Me.cmbSucursal.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(24, 23)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'frmTiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 249)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTiempo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiempo de Empleado"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTiempo As System.Windows.Forms.TextBox
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
End Class
