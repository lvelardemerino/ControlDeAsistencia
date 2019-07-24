<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlantillaMod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlantillaMod))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImportar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txtPlantilla = New System.Windows.Forms.TextBox()
        Me.lblPlantilla = New System.Windows.Forms.Label()
        Me.pnlSemana2 = New System.Windows.Forms.Panel()
        Me.fgSemana2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pnlSemana1 = New System.Windows.Forms.Panel()
        Me.fgSemana1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsSemana1 = New System.Windows.Forms.ToolStrip()
        Me.tslSemana1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSemana2 = New System.Windows.Forms.ToolStrip()
        Me.tslSemana2 = New System.Windows.Forms.ToolStripLabel()
        Me.ofdExcel = New System.Windows.Forms.OpenFileDialog()
        Me.tsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlSemana2.SuspendLayout()
        CType(Me.fgSemana2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSemana1.SuspendLayout()
        CType(Me.fgSemana1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSemana1.SuspendLayout()
        Me.tsSemana2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbImportar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(407, 25)
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
        'tsbImportar
        '
        Me.tsbImportar.ForeColor = System.Drawing.Color.White
        Me.tsbImportar.Image = CType(resources.GetObject("tsbImportar.Image"), System.Drawing.Image)
        Me.tsbImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImportar.Name = "tsbImportar"
        Me.tsbImportar.Size = New System.Drawing.Size(73, 22)
        Me.tsbImportar.Text = "Importar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbDepartamento)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDepartamento)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSucursal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPlantilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPlantilla)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlSemana2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlSemana1)
        Me.SplitContainer1.Size = New System.Drawing.Size(407, 378)
        Me.SplitContainer1.SplitterDistance = 182
        Me.SplitContainer1.TabIndex = 1
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(12, 235)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(158, 21)
        Me.cmbDepartamento.TabIndex = 5
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(12, 207)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 4
        Me.lblDepartamento.Text = "Departamento:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(12, 132)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(158, 21)
        Me.cmbSucursal.TabIndex = 3
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(12, 106)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 2
        Me.lblSucursal.Text = "Sucursal:"
        '
        'txtPlantilla
        '
        Me.txtPlantilla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlantilla.Location = New System.Drawing.Point(12, 41)
        Me.txtPlantilla.Name = "txtPlantilla"
        Me.txtPlantilla.Size = New System.Drawing.Size(158, 20)
        Me.txtPlantilla.TabIndex = 1
        '
        'lblPlantilla
        '
        Me.lblPlantilla.AutoSize = True
        Me.lblPlantilla.Location = New System.Drawing.Point(12, 25)
        Me.lblPlantilla.Name = "lblPlantilla"
        Me.lblPlantilla.Size = New System.Drawing.Size(46, 13)
        Me.lblPlantilla.TabIndex = 0
        Me.lblPlantilla.Text = "Plantilla:"
        '
        'pnlSemana2
        '
        Me.pnlSemana2.Controls.Add(Me.tsSemana2)
        Me.pnlSemana2.Controls.Add(Me.fgSemana2)
        Me.pnlSemana2.Location = New System.Drawing.Point(3, 192)
        Me.pnlSemana2.Name = "pnlSemana2"
        Me.pnlSemana2.Size = New System.Drawing.Size(206, 183)
        Me.pnlSemana2.TabIndex = 1
        '
        'fgSemana2
        '
        Me.fgSemana2.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgSemana2.Location = New System.Drawing.Point(0, 24)
        Me.fgSemana2.Name = "fgSemana2"
        Me.fgSemana2.Rows.DefaultSize = 19
        Me.fgSemana2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgSemana2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgSemana2.Size = New System.Drawing.Size(206, 159)
        Me.fgSemana2.TabIndex = 1
        '
        'pnlSemana1
        '
        Me.pnlSemana1.Controls.Add(Me.tsSemana1)
        Me.pnlSemana1.Controls.Add(Me.fgSemana1)
        Me.pnlSemana1.Location = New System.Drawing.Point(3, 0)
        Me.pnlSemana1.Name = "pnlSemana1"
        Me.pnlSemana1.Size = New System.Drawing.Size(206, 189)
        Me.pnlSemana1.TabIndex = 0
        '
        'fgSemana1
        '
        Me.fgSemana1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgSemana1.Location = New System.Drawing.Point(0, 25)
        Me.fgSemana1.Name = "fgSemana1"
        Me.fgSemana1.Rows.DefaultSize = 19
        Me.fgSemana1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgSemana1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgSemana1.Size = New System.Drawing.Size(203, 161)
        Me.fgSemana1.TabIndex = 0
        '
        'tsSemana1
        '
        Me.tsSemana1.BackgroundImage = CType(resources.GetObject("tsSemana1.BackgroundImage"), System.Drawing.Image)
        Me.tsSemana1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslSemana1})
        Me.tsSemana1.Location = New System.Drawing.Point(0, 0)
        Me.tsSemana1.Name = "tsSemana1"
        Me.tsSemana1.Size = New System.Drawing.Size(206, 25)
        Me.tsSemana1.TabIndex = 1
        Me.tsSemana1.Text = "ToolStrip1"
        '
        'tslSemana1
        '
        Me.tslSemana1.Name = "tslSemana1"
        Me.tslSemana1.Size = New System.Drawing.Size(64, 22)
        Me.tslSemana1.Text = "SEMANA 1"
        '
        'tsSemana2
        '
        Me.tsSemana2.BackgroundImage = CType(resources.GetObject("tsSemana2.BackgroundImage"), System.Drawing.Image)
        Me.tsSemana2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslSemana2})
        Me.tsSemana2.Location = New System.Drawing.Point(0, 0)
        Me.tsSemana2.Name = "tsSemana2"
        Me.tsSemana2.Size = New System.Drawing.Size(206, 25)
        Me.tsSemana2.TabIndex = 2
        Me.tsSemana2.Text = "ToolStrip1"
        '
        'tslSemana2
        '
        Me.tslSemana2.Name = "tslSemana2"
        Me.tslSemana2.Size = New System.Drawing.Size(64, 22)
        Me.tslSemana2.Text = "SEMANA 2"
        '
        'ofdExcel
        '
        Me.ofdExcel.FileName = "OpenFileDialog1"
        '
        'frmPlantillaMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 403)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlantillaMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlSemana2.ResumeLayout(False)
        Me.pnlSemana2.PerformLayout()
        CType(Me.fgSemana2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSemana1.ResumeLayout(False)
        Me.pnlSemana1.PerformLayout()
        CType(Me.fgSemana1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSemana1.ResumeLayout(False)
        Me.tsSemana1.PerformLayout()
        Me.tsSemana2.ResumeLayout(False)
        Me.tsSemana2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents txtPlantilla As System.Windows.Forms.TextBox
    Friend WithEvents lblPlantilla As System.Windows.Forms.Label
    Friend WithEvents pnlSemana2 As System.Windows.Forms.Panel
    Friend WithEvents pnlSemana1 As System.Windows.Forms.Panel
    Friend WithEvents fgSemana2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgSemana1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsSemana2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslSemana2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsSemana1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslSemana1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ofdExcel As System.Windows.Forms.OpenFileDialog
End Class
