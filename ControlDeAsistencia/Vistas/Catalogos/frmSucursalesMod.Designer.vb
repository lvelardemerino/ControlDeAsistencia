<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursalesMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursalesMod))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblRfc = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.lblNint = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCodPos = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.chbEstatus = New System.Windows.Forms.CheckBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNext = New System.Windows.Forms.TextBox()
        Me.txtNint = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCodPos = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
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
        Me.tsMenu.Size = New System.Drawing.Size(457, 25)
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
        Me.Panel1.Controls.Add(Me.cmbCiudad)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Controls.Add(Me.cmbPais)
        Me.Panel1.Controls.Add(Me.txtMail)
        Me.Panel1.Controls.Add(Me.txtContacto)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtCodPos)
        Me.Panel1.Controls.Add(Me.txtColonia)
        Me.Panel1.Controls.Add(Me.txtNint)
        Me.Panel1.Controls.Add(Me.txtNext)
        Me.Panel1.Controls.Add(Me.txtCalle)
        Me.Panel1.Controls.Add(Me.txtRfc)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.txtSucursal)
        Me.Panel1.Controls.Add(Me.chbEstatus)
        Me.Panel1.Controls.Add(Me.lblCiudad)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.lblPais)
        Me.Panel1.Controls.Add(Me.lblMail)
        Me.Panel1.Controls.Add(Me.lblContacto)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.lblCodPos)
        Me.Panel1.Controls.Add(Me.lblColonia)
        Me.Panel1.Controls.Add(Me.lblNint)
        Me.Panel1.Controls.Add(Me.lblNext)
        Me.Panel1.Controls.Add(Me.lblCalle)
        Me.Panel1.Controls.Add(Me.lblRfc)
        Me.Panel1.Controls.Add(Me.lblRazonSocial)
        Me.Panel1.Controls.Add(Me.lblSucursal)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 318)
        Me.Panel1.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(12, 16)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(12, 51)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lblRazonSocial.TabIndex = 1
        Me.lblRazonSocial.Text = "Razon Social:"
        '
        'lblRfc
        '
        Me.lblRfc.AutoSize = True
        Me.lblRfc.Location = New System.Drawing.Point(12, 86)
        Me.lblRfc.Name = "lblRfc"
        Me.lblRfc.Size = New System.Drawing.Size(28, 13)
        Me.lblRfc.TabIndex = 2
        Me.lblRfc.Text = "RFC"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(12, 129)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 3
        Me.lblCalle.Text = "Calle:"
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Location = New System.Drawing.Point(183, 129)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(45, 13)
        Me.lblNext.TabIndex = 4
        Me.lblNext.Text = "No. Ext."
        '
        'lblNint
        '
        Me.lblNint.AutoSize = True
        Me.lblNint.Location = New System.Drawing.Point(307, 129)
        Me.lblNint.Name = "lblNint"
        Me.lblNint.Size = New System.Drawing.Size(42, 13)
        Me.lblNint.TabIndex = 5
        Me.lblNint.Text = "No. Int."
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(12, 171)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 6
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCodPos
        '
        Me.lblCodPos.AutoSize = True
        Me.lblCodPos.Location = New System.Drawing.Point(183, 171)
        Me.lblCodPos.Name = "lblCodPos"
        Me.lblCodPos.Size = New System.Drawing.Size(75, 13)
        Me.lblCodPos.TabIndex = 7
        Me.lblCodPos.Text = "Codigo Postal:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(307, 171)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Location = New System.Drawing.Point(12, 209)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(53, 13)
        Me.lblContacto.TabIndex = 9
        Me.lblContacto.Text = "Contacto:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(183, 209)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(38, 13)
        Me.lblMail.TabIndex = 10
        Me.lblMail.Text = "E-mail:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(12, 250)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 13)
        Me.lblPais.TabIndex = 11
        Me.lblPais.Text = "Pais:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(242, 250)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Estado:"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(14, 288)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudad.TabIndex = 13
        Me.lblCiudad.Text = "Ciudad:"
        '
        'chbEstatus
        '
        Me.chbEstatus.AutoSize = True
        Me.chbEstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEstatus.Location = New System.Drawing.Point(310, 281)
        Me.chbEstatus.Name = "chbEstatus"
        Me.chbEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbEstatus.Size = New System.Drawing.Size(71, 20)
        Me.chbEstatus.TabIndex = 14
        Me.chbEstatus.Text = "Estatus"
        Me.chbEstatus.UseVisualStyleBackColor = True
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(69, 13)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(159, 20)
        Me.txtSucursal.TabIndex = 2
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(91, 48)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(146, 20)
        Me.txtRazonSocial.TabIndex = 15
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(46, 83)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(146, 20)
        Me.txtRfc.TabIndex = 16
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(46, 126)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(131, 20)
        Me.txtCalle.TabIndex = 17
        '
        'txtNext
        '
        Me.txtNext.Location = New System.Drawing.Point(228, 126)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(73, 20)
        Me.txtNext.TabIndex = 18
        '
        'txtNint
        '
        Me.txtNint.Location = New System.Drawing.Point(355, 126)
        Me.txtNint.Name = "txtNint"
        Me.txtNint.Size = New System.Drawing.Size(73, 20)
        Me.txtNint.TabIndex = 19
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(61, 168)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(116, 20)
        Me.txtColonia.TabIndex = 20
        '
        'txtCodPos
        '
        Me.txtCodPos.Location = New System.Drawing.Point(255, 168)
        Me.txtCodPos.Name = "txtCodPos"
        Me.txtCodPos.Size = New System.Drawing.Size(46, 20)
        Me.txtCodPos.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(355, 168)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(90, 20)
        Me.txtTelefono.TabIndex = 22
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(61, 206)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(116, 20)
        Me.txtContacto.TabIndex = 23
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(227, 206)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(218, 20)
        Me.txtMail.TabIndex = 24
        '
        'cmbPais
        '
        Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(61, 247)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(154, 21)
        Me.cmbPais.TabIndex = 25
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(291, 247)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(154, 21)
        Me.cmbEstado.TabIndex = 26
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(61, 285)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(154, 21)
        Me.cmbCiudad.TabIndex = 27
        '
        'frmSucursalesMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSucursalesMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursal"
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
    Friend WithEvents chbEstatus As System.Windows.Forms.CheckBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblCodPos As System.Windows.Forms.Label
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblNint As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblRfc As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPos As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtNint As System.Windows.Forms.TextBox
    Friend WithEvents txtNext As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
End Class
