<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisoPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermisoPersonal))
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblHoraIni = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.txtHoraIni = New System.Windows.Forms.TextBox()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(106, 175)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(139, 40)
        Me.txtObservaciones.TabIndex = 23
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(19, 178)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 22
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(81, 97)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(164, 21)
        Me.cmbEmpleado.TabIndex = 19
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(19, 100)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 18
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(81, 55)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(164, 21)
        Me.cmbSucursal.TabIndex = 17
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(19, 58)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 16
        Me.lblSucursal.Text = "Sucursal:"
        '
        'lblHoraIni
        '
        Me.lblHoraIni.AutoSize = True
        Me.lblHoraIni.Location = New System.Drawing.Point(19, 233)
        Me.lblHoraIni.Name = "lblHoraIni"
        Me.lblHoraIni.Size = New System.Drawing.Size(63, 13)
        Me.lblHoraIni.TabIndex = 24
        Me.lblHoraIni.Text = "Hora Inicial:"
        '
        'lblHoraFin
        '
        Me.lblHoraFin.AutoSize = True
        Me.lblHoraFin.Location = New System.Drawing.Point(19, 272)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(58, 13)
        Me.lblHoraFin.TabIndex = 25
        Me.lblHoraFin.Text = "Hora Final:"
        '
        'txtHoraIni
        '
        Me.txtHoraIni.Location = New System.Drawing.Point(88, 230)
        Me.txtHoraIni.Name = "txtHoraIni"
        Me.txtHoraIni.Size = New System.Drawing.Size(89, 20)
        Me.txtHoraIni.TabIndex = 26
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(88, 269)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(89, 20)
        Me.txtHoraFin.TabIndex = 27
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(266, 25)
        Me.tsMenu.TabIndex = 28
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
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(81, 136)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecha.TabIndex = 30
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(19, 142)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 29
        Me.lblFecha.Text = "Fecha:"
        '
        'frmPermisoPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 306)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.txtHoraFin)
        Me.Controls.Add(Me.txtHoraIni)
        Me.Controls.Add(Me.lblHoraFin)
        Me.Controls.Add(Me.lblHoraIni)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblSucursal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermisoPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso Personal"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblHoraIni As System.Windows.Forms.Label
    Friend WithEvents lblHoraFin As System.Windows.Forms.Label
    Friend WithEvents txtHoraIni As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraFin As System.Windows.Forms.TextBox
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
End Class
