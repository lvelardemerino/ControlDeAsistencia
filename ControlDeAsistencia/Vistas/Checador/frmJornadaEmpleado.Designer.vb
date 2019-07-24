<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJornadaEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJornadaEmpleado))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGenerar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbPlantilla = New System.Windows.Forms.ComboBox()
        Me.lblPlantilla = New System.Windows.Forms.Label()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.cmbSemanaIni = New System.Windows.Forms.ComboBox()
        Me.lblSemanaIni = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fgHorario = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.fgHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGenerar, Me.tsbGuardar, Me.tsbLimpiar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(592, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbGenerar
        '
        Me.tsbGenerar.ForeColor = System.Drawing.Color.White
        Me.tsbGenerar.Image = CType(resources.GetObject("tsbGenerar.Image"), System.Drawing.Image)
        Me.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerar.Name = "tsbGenerar"
        Me.tsbGenerar.Size = New System.Drawing.Size(68, 22)
        Me.tsbGenerar.Text = "Generar"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.ForeColor = System.Drawing.Color.White
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.Enabled = False
        Me.tsbLimpiar.ForeColor = System.Drawing.Color.White
        Me.tsbLimpiar.Image = CType(resources.GetObject("tsbLimpiar.Image"), System.Drawing.Image)
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(67, 22)
        Me.tsbLimpiar.Text = "Limpiar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSemanaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSemanaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbPlantilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPlantilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEmpleado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmpleado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSucursal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(592, 437)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(12, 28)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(15, 44)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(193, 21)
        Me.cmbSucursal.TabIndex = 1
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(15, 100)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(193, 21)
        Me.cmbEmpleado.TabIndex = 3
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(12, 84)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 2
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbPlantilla
        '
        Me.cmbPlantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlantilla.FormattingEnabled = True
        Me.cmbPlantilla.Location = New System.Drawing.Point(15, 162)
        Me.cmbPlantilla.Name = "cmbPlantilla"
        Me.cmbPlantilla.Size = New System.Drawing.Size(193, 21)
        Me.cmbPlantilla.TabIndex = 5
        '
        'lblPlantilla
        '
        Me.lblPlantilla.AutoSize = True
        Me.lblPlantilla.Location = New System.Drawing.Point(12, 146)
        Me.lblPlantilla.Name = "lblPlantilla"
        Me.lblPlantilla.Size = New System.Drawing.Size(46, 13)
        Me.lblPlantilla.TabIndex = 4
        Me.lblPlantilla.Text = "Plantilla:"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(12, 210)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(83, 13)
        Me.lblFechaIni.TabIndex = 6
        Me.lblFechaIni.Text = "Fecha de Inicio:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(15, 226)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(126, 20)
        Me.dtpFechaIni.TabIndex = 7
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(15, 283)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(126, 20)
        Me.dtpFechaFin.TabIndex = 9
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(12, 267)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaFin.TabIndex = 8
        Me.lblFechaFin.Text = "Fecha Final:"
        '
        'cmbSemanaIni
        '
        Me.cmbSemanaIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemanaIni.FormattingEnabled = True
        Me.cmbSemanaIni.Items.AddRange(New Object() {"PRIMERA", "SEGUNDA"})
        Me.cmbSemanaIni.Location = New System.Drawing.Point(15, 347)
        Me.cmbSemanaIni.Name = "cmbSemanaIni"
        Me.cmbSemanaIni.Size = New System.Drawing.Size(193, 21)
        Me.cmbSemanaIni.TabIndex = 11
        '
        'lblSemanaIni
        '
        Me.lblSemanaIni.AutoSize = True
        Me.lblSemanaIni.Location = New System.Drawing.Point(12, 331)
        Me.lblSemanaIni.Name = "lblSemanaIni"
        Me.lblSemanaIni.Size = New System.Drawing.Size(92, 13)
        Me.lblSemanaIni.TabIndex = 10
        Me.lblSemanaIni.Text = "Semana de Inicio:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fgHorario)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 431)
        Me.Panel1.TabIndex = 0
        '
        'fgHorario
        '
        Me.fgHorario.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgHorario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgHorario.Location = New System.Drawing.Point(0, 0)
        Me.fgHorario.Name = "fgHorario"
        Me.fgHorario.Rows.DefaultSize = 19
        Me.fgHorario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgHorario.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgHorario.Size = New System.Drawing.Size(339, 431)
        Me.fgHorario.TabIndex = 0
        '
        'frmJornadaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJornadaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jornada Empleado"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.fgHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmbSemanaIni As System.Windows.Forms.ComboBox
    Friend WithEvents lblSemanaIni As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaIni As System.Windows.Forms.Label
    Friend WithEvents cmbPlantilla As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlantilla As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fgHorario As C1.Win.C1FlexGrid.C1FlexGrid
End Class
