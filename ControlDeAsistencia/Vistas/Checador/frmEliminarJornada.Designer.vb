<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarJornada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarJornada))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.fgJornada = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.fgJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = Global.ControlDeAsistencia.My.Resources.Resources.fondo
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbEliminar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(583, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEmpleado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmpleado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(583, 359)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fgJornada)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 353)
        Me.Panel1.TabIndex = 0
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(21, 87)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 0
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(24, 103)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(184, 21)
        Me.cmbEmpleado.TabIndex = 1
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(21, 149)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 2
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(24, 165)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIni.TabIndex = 3
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(24, 226)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 5
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(21, 210)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaFin.TabIndex = 4
        Me.lblFechaFin.Text = "Fecha Inicial:"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.ForeColor = System.Drawing.Color.White
        Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(62, 22)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.ForeColor = System.Drawing.Color.White
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'fgJornada
        '
        Me.fgJornada.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgJornada.AllowEditing = False
        Me.fgJornada.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgJornada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgJornada.Location = New System.Drawing.Point(0, 0)
        Me.fgJornada.Name = "fgJornada"
        Me.fgJornada.Rows.DefaultSize = 19
        Me.fgJornada.Size = New System.Drawing.Size(349, 353)
        Me.fgJornada.TabIndex = 0
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(24, 44)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(184, 21)
        Me.cmbSucursal.TabIndex = 7
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(21, 28)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal"
        '
        'frmEliminarJornada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 384)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEliminarJornada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Jornada"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.fgJornada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fgJornada As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents lblSucursal As Label
End Class
