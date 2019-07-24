<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistencia))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslEmpleado = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalMes = New System.Windows.Forms.Label()
        Me.lblMesAnterior = New System.Windows.Forms.Label()
        Me.lblTiempoContra = New System.Windows.Forms.Label()
        Me.lblTiempoFavor = New System.Windows.Forms.Label()
        Me.lblRetardos = New System.Windows.Forms.Label()
        Me.lblRetardoComida = New System.Windows.Forms.Label()
        Me.lblTotMes = New System.Windows.Forms.Label()
        Me.lblMesAnt = New System.Windows.Forms.Label()
        Me.lblRet = New System.Windows.Forms.Label()
        Me.lblTieContra = New System.Windows.Forms.Label()
        Me.lblTieFavor = New System.Windows.Forms.Label()
        Me.lblRetCom = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblComida = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.pbFavor = New System.Windows.Forms.PictureBox()
        Me.lblFavor = New System.Windows.Forms.Label()
        Me.pbSinRegistro = New System.Windows.Forms.PictureBox()
        Me.lblSinRegistro = New System.Windows.Forms.Label()
        Me.pbFalta = New System.Windows.Forms.PictureBox()
        Me.lblFalta = New System.Windows.Forms.Label()
        Me.lblConceptos = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fgJornada = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pdReporte = New System.Drawing.Printing.PrintDocument()
        Me.tsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFavor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSinRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFalta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.fgJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = CType(resources.GetObject("tsMenu.BackgroundImage"), System.Drawing.Image)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImprimir, Me.ToolStripSeparator1, Me.tslEmpleado})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1332, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.ForeColor = System.Drawing.Color.White
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(73, 22)
        Me.tsbImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslEmpleado
        '
        Me.tslEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tslEmpleado.ForeColor = System.Drawing.Color.White
        Me.tslEmpleado.Name = "tslEmpleado"
        Me.tslEmpleado.Size = New System.Drawing.Size(129, 22)
        Me.tslEmpleado.Text = "ToolStripLabel1"
        Me.tslEmpleado.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1332, 485)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblTotalMes)
        Me.Panel2.Controls.Add(Me.lblMesAnterior)
        Me.Panel2.Controls.Add(Me.lblTiempoContra)
        Me.Panel2.Controls.Add(Me.lblTiempoFavor)
        Me.Panel2.Controls.Add(Me.lblRetardos)
        Me.Panel2.Controls.Add(Me.lblRetardoComida)
        Me.Panel2.Controls.Add(Me.lblTotMes)
        Me.Panel2.Controls.Add(Me.lblMesAnt)
        Me.Panel2.Controls.Add(Me.lblRet)
        Me.Panel2.Controls.Add(Me.lblTieContra)
        Me.Panel2.Controls.Add(Me.lblTieFavor)
        Me.Panel2.Controls.Add(Me.lblRetCom)
        Me.Panel2.Location = New System.Drawing.Point(3, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 200)
        Me.Panel2.TabIndex = 1
        '
        'lblTotalMes
        '
        Me.lblTotalMes.AutoSize = True
        Me.lblTotalMes.Location = New System.Drawing.Point(142, 174)
        Me.lblTotalMes.Name = "lblTotalMes"
        Me.lblTotalMes.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalMes.TabIndex = 13
        Me.lblTotalMes.Text = "Label6"
        Me.lblTotalMes.Visible = False
        '
        'lblMesAnterior
        '
        Me.lblMesAnterior.AutoSize = True
        Me.lblMesAnterior.Location = New System.Drawing.Point(142, 142)
        Me.lblMesAnterior.Name = "lblMesAnterior"
        Me.lblMesAnterior.Size = New System.Drawing.Size(39, 13)
        Me.lblMesAnterior.TabIndex = 12
        Me.lblMesAnterior.Text = "Label5"
        Me.lblMesAnterior.Visible = False
        '
        'lblTiempoContra
        '
        Me.lblTiempoContra.AutoSize = True
        Me.lblTiempoContra.Location = New System.Drawing.Point(142, 111)
        Me.lblTiempoContra.Name = "lblTiempoContra"
        Me.lblTiempoContra.Size = New System.Drawing.Size(39, 13)
        Me.lblTiempoContra.TabIndex = 11
        Me.lblTiempoContra.Text = "Label4"
        Me.lblTiempoContra.Visible = False
        '
        'lblTiempoFavor
        '
        Me.lblTiempoFavor.AutoSize = True
        Me.lblTiempoFavor.Location = New System.Drawing.Point(142, 79)
        Me.lblTiempoFavor.Name = "lblTiempoFavor"
        Me.lblTiempoFavor.Size = New System.Drawing.Size(39, 13)
        Me.lblTiempoFavor.TabIndex = 10
        Me.lblTiempoFavor.Text = "Label3"
        Me.lblTiempoFavor.Visible = False
        '
        'lblRetardos
        '
        Me.lblRetardos.AutoSize = True
        Me.lblRetardos.Location = New System.Drawing.Point(142, 46)
        Me.lblRetardos.Name = "lblRetardos"
        Me.lblRetardos.Size = New System.Drawing.Size(39, 13)
        Me.lblRetardos.TabIndex = 9
        Me.lblRetardos.Text = "Label2"
        Me.lblRetardos.Visible = False
        '
        'lblRetardoComida
        '
        Me.lblRetardoComida.AutoSize = True
        Me.lblRetardoComida.Location = New System.Drawing.Point(142, 18)
        Me.lblRetardoComida.Name = "lblRetardoComida"
        Me.lblRetardoComida.Size = New System.Drawing.Size(39, 13)
        Me.lblRetardoComida.TabIndex = 8
        Me.lblRetardoComida.Text = "Label1"
        Me.lblRetardoComida.Visible = False
        '
        'lblTotMes
        '
        Me.lblTotMes.AutoSize = True
        Me.lblTotMes.Location = New System.Drawing.Point(7, 174)
        Me.lblTotMes.Name = "lblTotMes"
        Me.lblTotMes.Size = New System.Drawing.Size(74, 13)
        Me.lblTotMes.TabIndex = 5
        Me.lblTotMes.Text = "Total del Mes:"
        '
        'lblMesAnt
        '
        Me.lblMesAnt.AutoSize = True
        Me.lblMesAnt.Location = New System.Drawing.Point(7, 142)
        Me.lblMesAnt.Name = "lblMesAnt"
        Me.lblMesAnt.Size = New System.Drawing.Size(69, 13)
        Me.lblMesAnt.TabIndex = 4
        Me.lblMesAnt.Text = "Mes Anterior:"
        '
        'lblRet
        '
        Me.lblRet.AutoSize = True
        Me.lblRet.Location = New System.Drawing.Point(7, 46)
        Me.lblRet.Name = "lblRet"
        Me.lblRet.Size = New System.Drawing.Size(53, 13)
        Me.lblRet.TabIndex = 3
        Me.lblRet.Text = "Retardos:"
        '
        'lblTieContra
        '
        Me.lblTieContra.AutoSize = True
        Me.lblTieContra.Location = New System.Drawing.Point(7, 111)
        Me.lblTieContra.Name = "lblTieContra"
        Me.lblTieContra.Size = New System.Drawing.Size(94, 13)
        Me.lblTieContra.TabIndex = 2
        Me.lblTieContra.Text = "Tiempo en Contra:"
        '
        'lblTieFavor
        '
        Me.lblTieFavor.AutoSize = True
        Me.lblTieFavor.Location = New System.Drawing.Point(7, 79)
        Me.lblTieFavor.Name = "lblTieFavor"
        Me.lblTieFavor.Size = New System.Drawing.Size(84, 13)
        Me.lblTieFavor.TabIndex = 1
        Me.lblTieFavor.Text = "Tiempo a Favor:"
        '
        'lblRetCom
        '
        Me.lblRetCom.AutoSize = True
        Me.lblRetCom.Location = New System.Drawing.Point(7, 18)
        Me.lblRetCom.Name = "lblRetCom"
        Me.lblRetCom.Size = New System.Drawing.Size(91, 13)
        Me.lblRetCom.TabIndex = 0
        Me.lblRetCom.Text = "Retardos Comida:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.dtpFechaIni)
        Me.Panel1.Controls.Add(Me.lblFechaIni)
        Me.Panel1.Controls.Add(Me.cmbEmpleado)
        Me.Panel1.Controls.Add(Me.lblEmpleado)
        Me.Panel1.Controls.Add(Me.cmbSucursal)
        Me.Panel1.Controls.Add(Me.lblSucursal)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 273)
        Me.Panel1.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(160, 243)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(57, 23)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(28, 218)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(125, 20)
        Me.dtpFechaFin.TabIndex = 7
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(25, 202)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 6
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(28, 159)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(125, 20)
        Me.dtpFechaIni.TabIndex = 5
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(25, 143)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaIni.TabIndex = 4
        Me.lblFechaIni.Text = "Fecha Inicio:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(28, 101)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(189, 21)
        Me.cmbEmpleado.TabIndex = 3
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(25, 85)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpleado.TabIndex = 2
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(28, 45)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(189, 21)
        Me.cmbSucursal.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(25, 29)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.lblComida)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblContra)
        Me.Panel4.Controls.Add(Me.pbFavor)
        Me.Panel4.Controls.Add(Me.lblFavor)
        Me.Panel4.Controls.Add(Me.pbSinRegistro)
        Me.Panel4.Controls.Add(Me.lblSinRegistro)
        Me.Panel4.Controls.Add(Me.pbFalta)
        Me.Panel4.Controls.Add(Me.lblFalta)
        Me.Panel4.Controls.Add(Me.lblConceptos)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1057, 44)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox2.Location = New System.Drawing.Point(686, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 17)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblComida
        '
        Me.lblComida.AutoSize = True
        Me.lblComida.Location = New System.Drawing.Point(615, 22)
        Me.lblComida.Name = "lblComida"
        Me.lblComida.Size = New System.Drawing.Size(65, 13)
        Me.lblComida.TabIndex = 9
        Me.lblComida.Text = "Ret. Comida"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Orange
        Me.PictureBox1.Location = New System.Drawing.Point(541, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 17)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(449, 22)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(91, 13)
        Me.lblContra.TabIndex = 7
        Me.lblContra.Text = "Tiempo en Contra"
        '
        'pbFavor
        '
        Me.pbFavor.BackColor = System.Drawing.Color.LightGreen
        Me.pbFavor.Location = New System.Drawing.Point(387, 18)
        Me.pbFavor.Name = "pbFavor"
        Me.pbFavor.Size = New System.Drawing.Size(50, 17)
        Me.pbFavor.TabIndex = 6
        Me.pbFavor.TabStop = False
        '
        'lblFavor
        '
        Me.lblFavor.AutoSize = True
        Me.lblFavor.Location = New System.Drawing.Point(300, 22)
        Me.lblFavor.Name = "lblFavor"
        Me.lblFavor.Size = New System.Drawing.Size(81, 13)
        Me.lblFavor.TabIndex = 5
        Me.lblFavor.Text = "Tiempo a Favor"
        '
        'pbSinRegistro
        '
        Me.pbSinRegistro.BackColor = System.Drawing.Color.Yellow
        Me.pbSinRegistro.Location = New System.Drawing.Point(237, 19)
        Me.pbSinRegistro.Name = "pbSinRegistro"
        Me.pbSinRegistro.Size = New System.Drawing.Size(50, 17)
        Me.pbSinRegistro.TabIndex = 4
        Me.pbSinRegistro.TabStop = False
        '
        'lblSinRegistro
        '
        Me.lblSinRegistro.AutoSize = True
        Me.lblSinRegistro.Location = New System.Drawing.Point(173, 22)
        Me.lblSinRegistro.Name = "lblSinRegistro"
        Me.lblSinRegistro.Size = New System.Drawing.Size(64, 13)
        Me.lblSinRegistro.TabIndex = 3
        Me.lblSinRegistro.Text = "Sin Registro"
        '
        'pbFalta
        '
        Me.pbFalta.BackColor = System.Drawing.Color.Red
        Me.pbFalta.Location = New System.Drawing.Point(106, 20)
        Me.pbFalta.Name = "pbFalta"
        Me.pbFalta.Size = New System.Drawing.Size(50, 17)
        Me.pbFalta.TabIndex = 2
        Me.pbFalta.TabStop = False
        '
        'lblFalta
        '
        Me.lblFalta.AutoSize = True
        Me.lblFalta.Location = New System.Drawing.Point(76, 22)
        Me.lblFalta.Name = "lblFalta"
        Me.lblFalta.Size = New System.Drawing.Size(30, 13)
        Me.lblFalta.TabIndex = 1
        Me.lblFalta.Text = "Falta"
        '
        'lblConceptos
        '
        Me.lblConceptos.AutoSize = True
        Me.lblConceptos.Location = New System.Drawing.Point(3, 0)
        Me.lblConceptos.Name = "lblConceptos"
        Me.lblConceptos.Size = New System.Drawing.Size(58, 13)
        Me.lblConceptos.TabIndex = 0
        Me.lblConceptos.Text = "Conceptos"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.fgJornada)
        Me.Panel3.Location = New System.Drawing.Point(3, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1057, 432)
        Me.Panel3.TabIndex = 0
        '
        'fgJornada
        '
        Me.fgJornada.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgJornada.AllowEditing = False
        Me.fgJornada.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgJornada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgJornada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgJornada.Location = New System.Drawing.Point(0, 0)
        Me.fgJornada.Name = "fgJornada"
        Me.fgJornada.Rows.DefaultSize = 19
        Me.fgJornada.Size = New System.Drawing.Size(1057, 432)
        Me.fgJornada.StyleInfo = resources.GetString("fgJornada.StyleInfo")
        Me.fgJornada.TabIndex = 0
        '
        'pdReporte
        '
        '
        'frmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 510)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Asistencia"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFavor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSinRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFalta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.fgJornada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslEmpleado As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalMes As System.Windows.Forms.Label
    Friend WithEvents lblMesAnterior As System.Windows.Forms.Label
    Friend WithEvents lblTiempoContra As System.Windows.Forms.Label
    Friend WithEvents lblTiempoFavor As System.Windows.Forms.Label
    Friend WithEvents lblRetardos As System.Windows.Forms.Label
    Friend WithEvents lblRetardoComida As System.Windows.Forms.Label
    Friend WithEvents lblTotMes As System.Windows.Forms.Label
    Friend WithEvents lblMesAnt As System.Windows.Forms.Label
    Friend WithEvents lblRet As System.Windows.Forms.Label
    Friend WithEvents lblTieContra As System.Windows.Forms.Label
    Friend WithEvents lblTieFavor As System.Windows.Forms.Label
    Friend WithEvents lblRetCom As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaIni As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents fgJornada As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pbSinRegistro As System.Windows.Forms.PictureBox
    Friend WithEvents lblSinRegistro As System.Windows.Forms.Label
    Friend WithEvents pbFalta As System.Windows.Forms.PictureBox
    Friend WithEvents lblFalta As System.Windows.Forms.Label
    Friend WithEvents lblConceptos As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblContra As System.Windows.Forms.Label
    Friend WithEvents pbFavor As System.Windows.Forms.PictureBox
    Friend WithEvents lblFavor As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblComida As System.Windows.Forms.Label
    Friend WithEvents pdReporte As System.Drawing.Printing.PrintDocument
End Class
