<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaMod))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblAlta = New System.Windows.Forms.Label()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.dtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.dtpBaja = New System.Windows.Forms.DateTimePicker()
        Me.chbEstatus = New System.Windows.Forms.CheckBox()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(251, 25)
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
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(23, 54)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 1
        Me.lblArea.Text = "Area:"
        '
        'lblAlta
        '
        Me.lblAlta.AutoSize = True
        Me.lblAlta.Location = New System.Drawing.Point(23, 104)
        Me.lblAlta.Name = "lblAlta"
        Me.lblAlta.Size = New System.Drawing.Size(28, 13)
        Me.lblAlta.TabIndex = 2
        Me.lblAlta.Text = "Alta:"
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.Location = New System.Drawing.Point(23, 149)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(31, 13)
        Me.lblBaja.TabIndex = 3
        Me.lblBaja.Text = "Baja:"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(61, 51)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(170, 20)
        Me.txtArea.TabIndex = 4
        '
        'dtpAlta
        '
        Me.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAlta.Location = New System.Drawing.Point(61, 98)
        Me.dtpAlta.Name = "dtpAlta"
        Me.dtpAlta.Size = New System.Drawing.Size(103, 20)
        Me.dtpAlta.TabIndex = 5
        '
        'dtpBaja
        '
        Me.dtpBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBaja.Location = New System.Drawing.Point(61, 143)
        Me.dtpBaja.Name = "dtpBaja"
        Me.dtpBaja.Size = New System.Drawing.Size(103, 20)
        Me.dtpBaja.TabIndex = 6
        '
        'chbEstatus
        '
        Me.chbEstatus.AutoSize = True
        Me.chbEstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEstatus.Location = New System.Drawing.Point(165, 190)
        Me.chbEstatus.Name = "chbEstatus"
        Me.chbEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbEstatus.Size = New System.Drawing.Size(66, 20)
        Me.chbEstatus.TabIndex = 7
        Me.chbEstatus.Text = "Activo"
        Me.chbEstatus.UseVisualStyleBackColor = True
        '
        'frmAreaMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 232)
        Me.Controls.Add(Me.chbEstatus)
        Me.Controls.Add(Me.dtpBaja)
        Me.Controls.Add(Me.dtpAlta)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.lblBaja)
        Me.Controls.Add(Me.lblAlta)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAreaMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblAlta As System.Windows.Forms.Label
    Friend WithEvents lblBaja As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents dtpAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbEstatus As System.Windows.Forms.CheckBox
End Class
