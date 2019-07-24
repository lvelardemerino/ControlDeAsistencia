<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosMod))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chbCambio = New System.Windows.Forms.CheckBox()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtAmaterno = New System.Windows.Forms.TextBox()
        Me.lblAmaterno = New System.Windows.Forms.Label()
        Me.txtApaterno = New System.Windows.Forms.TextBox()
        Me.lblApaterno = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
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
        Me.tsMenu.Size = New System.Drawing.Size(368, 25)
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
        Me.Panel1.Controls.Add(Me.chbCambio)
        Me.Panel1.Controls.Add(Me.chbActivo)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.txtAmaterno)
        Me.Panel1.Controls.Add(Me.lblAmaterno)
        Me.Panel1.Controls.Add(Me.txtApaterno)
        Me.Panel1.Controls.Add(Me.lblApaterno)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 237)
        Me.Panel1.TabIndex = 1
        '
        'chbCambio
        '
        Me.chbCambio.AutoSize = True
        Me.chbCambio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCambio.Location = New System.Drawing.Point(12, 201)
        Me.chbCambio.Name = "chbCambio"
        Me.chbCambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbCambio.Size = New System.Drawing.Size(172, 20)
        Me.chbCambio.TabIndex = 11
        Me.chbCambio.Text = "Cambio de Contraseña"
        Me.chbCambio.UseVisualStyleBackColor = True
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbActivo.Location = New System.Drawing.Point(280, 201)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbActivo.Size = New System.Drawing.Size(71, 20)
        Me.chbActivo.TabIndex = 10
        Me.chbActivo.Text = "Estatus"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 156)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtPassword.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 140)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 13)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtAmaterno
        '
        Me.txtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmaterno.Location = New System.Drawing.Point(199, 91)
        Me.txtAmaterno.Name = "txtAmaterno"
        Me.txtAmaterno.Size = New System.Drawing.Size(152, 20)
        Me.txtAmaterno.TabIndex = 7
        '
        'lblAmaterno
        '
        Me.lblAmaterno.AutoSize = True
        Me.lblAmaterno.Location = New System.Drawing.Point(199, 75)
        Me.lblAmaterno.Name = "lblAmaterno"
        Me.lblAmaterno.Size = New System.Drawing.Size(62, 13)
        Me.lblAmaterno.TabIndex = 6
        Me.lblAmaterno.Text = "A. Materno:"
        '
        'txtApaterno
        '
        Me.txtApaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApaterno.Location = New System.Drawing.Point(12, 91)
        Me.txtApaterno.Name = "txtApaterno"
        Me.txtApaterno.Size = New System.Drawing.Size(152, 20)
        Me.txtApaterno.TabIndex = 5
        '
        'lblApaterno
        '
        Me.lblApaterno.AutoSize = True
        Me.lblApaterno.Location = New System.Drawing.Point(12, 75)
        Me.lblApaterno.Name = "lblApaterno"
        Me.lblApaterno.Size = New System.Drawing.Size(60, 13)
        Me.lblApaterno.TabIndex = 4
        Me.lblApaterno.Text = "A. Paterno:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(199, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(199, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Location = New System.Drawing.Point(12, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(152, 20)
        Me.txtId.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 12)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id:"
        '
        'frmUsuariosMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuariosMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
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
    Friend WithEvents chbCambio As System.Windows.Forms.CheckBox
    Friend WithEvents chbActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtAmaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblAmaterno As System.Windows.Forms.Label
    Friend WithEvents txtApaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblApaterno As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
