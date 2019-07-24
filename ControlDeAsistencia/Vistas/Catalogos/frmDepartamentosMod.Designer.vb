<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentosMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentosMod))
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.chbEstatus = New System.Windows.Forms.CheckBox()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.lblAlta = New System.Windows.Forms.Label()
        Me.dtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.dtpBaja = New System.Windows.Forms.DateTimePicker()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(22, 41)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Departamento:"
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(332, 25)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(105, 38)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(187, 20)
        Me.txtDepartamento.TabIndex = 2
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(22, 129)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 3
        Me.lblArea.Text = "Area:"
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(105, 126)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(187, 21)
        Me.cmbArea.TabIndex = 4
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(105, 81)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(187, 21)
        Me.cmbSucursal.TabIndex = 6
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(22, 84)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 5
        Me.lblSucursal.Text = "Sucursal:"
        '
        'chbEstatus
        '
        Me.chbEstatus.AutoSize = True
        Me.chbEstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEstatus.Location = New System.Drawing.Point(237, 209)
        Me.chbEstatus.Name = "chbEstatus"
        Me.chbEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbEstatus.Size = New System.Drawing.Size(66, 20)
        Me.chbEstatus.TabIndex = 7
        Me.chbEstatus.Text = "Activo"
        Me.chbEstatus.UseVisualStyleBackColor = True
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
        'lblAlta
        '
        Me.lblAlta.AutoSize = True
        Me.lblAlta.Location = New System.Drawing.Point(22, 175)
        Me.lblAlta.Name = "lblAlta"
        Me.lblAlta.Size = New System.Drawing.Size(28, 13)
        Me.lblAlta.TabIndex = 8
        Me.lblAlta.Text = "Alta:"
        '
        'dtpAlta
        '
        Me.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAlta.Location = New System.Drawing.Point(56, 169)
        Me.dtpAlta.Name = "dtpAlta"
        Me.dtpAlta.Size = New System.Drawing.Size(93, 20)
        Me.dtpAlta.TabIndex = 9
        '
        'dtpBaja
        '
        Me.dtpBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBaja.Location = New System.Drawing.Point(210, 169)
        Me.dtpBaja.Name = "dtpBaja"
        Me.dtpBaja.Size = New System.Drawing.Size(93, 20)
        Me.dtpBaja.TabIndex = 11
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.Location = New System.Drawing.Point(176, 175)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(31, 13)
        Me.lblBaja.TabIndex = 10
        Me.lblBaja.Text = "Baja:"
        '
        'frmDepartamentosMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 230)
        Me.Controls.Add(Me.dtpBaja)
        Me.Controls.Add(Me.lblBaja)
        Me.Controls.Add(Me.dtpAlta)
        Me.Controls.Add(Me.lblAlta)
        Me.Controls.Add(Me.chbEstatus)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblDepartamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepartamentosMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamento"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents chbEstatus As System.Windows.Forms.CheckBox
    Friend WithEvents lblAlta As System.Windows.Forms.Label
    Friend WithEvents dtpAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBaja As System.Windows.Forms.Label
End Class
