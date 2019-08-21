<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFalta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFalta))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmbFalta = New System.Windows.Forms.ComboBox()
        Me.lblFalta = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(261, 25)
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
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(74, 95)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(164, 21)
        Me.cmbEmpleado.TabIndex = 9
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(12, 98)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 8
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(74, 53)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(164, 21)
        Me.cmbSucursal.TabIndex = 7
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(12, 56)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(99, 179)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(139, 55)
        Me.txtObservaciones.TabIndex = 15
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 182)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 14
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(74, 260)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecha.TabIndex = 13
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 266)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha:"
        '
        'cmbFalta
        '
        Me.cmbFalta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFalta.FormattingEnabled = True
        Me.cmbFalta.Items.AddRange(New Object() {"FALTA", "FALTA AUTORIZADA"})
        Me.cmbFalta.Location = New System.Drawing.Point(74, 137)
        Me.cmbFalta.Name = "cmbFalta"
        Me.cmbFalta.Size = New System.Drawing.Size(164, 21)
        Me.cmbFalta.TabIndex = 17
        '
        'lblFalta
        '
        Me.lblFalta.AutoSize = True
        Me.lblFalta.Location = New System.Drawing.Point(12, 140)
        Me.lblFalta.Name = "lblFalta"
        Me.lblFalta.Size = New System.Drawing.Size(31, 13)
        Me.lblFalta.TabIndex = 16
        Me.lblFalta.Text = "Tipo:"
        '
        'frmFalta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 307)
        Me.Controls.Add(Me.cmbFalta)
        Me.Controls.Add(Me.lblFalta)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFalta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Falta"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmbFalta As ComboBox
    Friend WithEvents lblFalta As Label
End Class
