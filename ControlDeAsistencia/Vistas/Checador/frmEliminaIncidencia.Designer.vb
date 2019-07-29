<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminaIncidencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminaIncidencia))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.chbRango = New System.Windows.Forms.CheckBox()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fgIncidencias = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.fgIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbRango)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFechaIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEmpleado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmpleado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSucursal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(597, 317)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(135, 282)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(60, 23)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(16, 243)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaFin.TabIndex = 8
        Me.dtpFechaFin.Visible = False
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(12, 227)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaFin.TabIndex = 7
        Me.lblFechaFin.Text = "Fecha Final:"
        Me.lblFechaFin.Visible = False
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(16, 192)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaIni.TabIndex = 6
        '
        'chbRango
        '
        Me.chbRango.AutoSize = True
        Me.chbRango.Location = New System.Drawing.Point(15, 146)
        Me.chbRango.Name = "chbRango"
        Me.chbRango.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbRango.Size = New System.Drawing.Size(111, 17)
        Me.chbRango.TabIndex = 5
        Me.chbRango.Text = "Rango de Fechas"
        Me.chbRango.UseVisualStyleBackColor = True
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(12, 176)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaIni.TabIndex = 4
        Me.lblFechaIni.Text = "Fecha:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(15, 96)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(170, 21)
        Me.cmbEmpleado.TabIndex = 3
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(12, 80)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 2
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(15, 36)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(170, 21)
        Me.cmbSucursal.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(12, 20)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fgIncidencias)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 311)
        Me.Panel1.TabIndex = 0
        '
        'fgIncidencias
        '
        Me.fgIncidencias.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgIncidencias.AllowEditing = False
        Me.fgIncidencias.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgIncidencias.Location = New System.Drawing.Point(0, 0)
        Me.fgIncidencias.Name = "fgIncidencias"
        Me.fgIncidencias.Rows.DefaultSize = 19
        Me.fgIncidencias.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgIncidencias.Size = New System.Drawing.Size(368, 311)
        Me.fgIncidencias.TabIndex = 0
        '
        'frmEliminaIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 317)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEliminaIncidencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimina Incidencia"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.fgIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents chbRango As CheckBox
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents lblSucursal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fgIncidencias As C1.Win.C1FlexGrid.C1FlexGrid
End Class
