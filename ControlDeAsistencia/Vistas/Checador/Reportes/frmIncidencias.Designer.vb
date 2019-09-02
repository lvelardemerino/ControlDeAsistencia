<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncidencias))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fgTfavor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblTiempoFavor = New System.Windows.Forms.Label()
        Me.lblTiempoContra = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fgTcontra = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotFavor = New System.Windows.Forms.Label()
        Me.txtTotFavor = New System.Windows.Forms.TextBox()
        Me.txtTotContra = New System.Windows.Forms.TextBox()
        Me.lblTotContra = New System.Windows.Forms.Label()
        Me.lblMesAnt = New System.Windows.Forms.Label()
        Me.txtMesAnt = New System.Windows.Forms.TextBox()
        Me.tsMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.fgTfavor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.fgTcontra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = Global.ControlDeAsistencia.My.Resources.Resources.fondo
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImprimir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(809, 25)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fgTfavor)
        Me.Panel1.Location = New System.Drawing.Point(8, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 529)
        Me.Panel1.TabIndex = 1
        '
        'fgTfavor
        '
        Me.fgTfavor.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgTfavor.AllowEditing = False
        Me.fgTfavor.ColumnInfo = "10,0,0,0,0,95,Columns:1{Width:96;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgTfavor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgTfavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgTfavor.Location = New System.Drawing.Point(0, 0)
        Me.fgTfavor.Name = "fgTfavor"
        Me.fgTfavor.Rows.DefaultSize = 19
        Me.fgTfavor.Size = New System.Drawing.Size(383, 529)
        Me.fgTfavor.StyleInfo = resources.GetString("fgTfavor.StyleInfo")
        Me.fgTfavor.TabIndex = 1
        '
        'lblTiempoFavor
        '
        Me.lblTiempoFavor.AutoSize = True
        Me.lblTiempoFavor.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoFavor.Location = New System.Drawing.Point(142, 25)
        Me.lblTiempoFavor.Name = "lblTiempoFavor"
        Me.lblTiempoFavor.Size = New System.Drawing.Size(89, 16)
        Me.lblTiempoFavor.TabIndex = 0
        Me.lblTiempoFavor.Text = "Tiempo a Favor"
        '
        'lblTiempoContra
        '
        Me.lblTiempoContra.AutoSize = True
        Me.lblTiempoContra.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoContra.Location = New System.Drawing.Point(545, 25)
        Me.lblTiempoContra.Name = "lblTiempoContra"
        Me.lblTiempoContra.Size = New System.Drawing.Size(102, 16)
        Me.lblTiempoContra.TabIndex = 2
        Me.lblTiempoContra.Text = "Tiempo en Contra"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.fgTcontra)
        Me.Panel2.Location = New System.Drawing.Point(397, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 529)
        Me.Panel2.TabIndex = 3
        '
        'fgTcontra
        '
        Me.fgTcontra.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgTcontra.AllowEditing = False
        Me.fgTcontra.ColumnInfo = "10,0,0,0,0,95,Columns:1{Width:96;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgTcontra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgTcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgTcontra.Location = New System.Drawing.Point(0, 0)
        Me.fgTcontra.Name = "fgTcontra"
        Me.fgTcontra.Rows.DefaultSize = 19
        Me.fgTcontra.Size = New System.Drawing.Size(380, 529)
        Me.fgTcontra.StyleInfo = resources.GetString("fgTcontra.StyleInfo")
        Me.fgTcontra.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtMesAnt)
        Me.Panel3.Controls.Add(Me.lblMesAnt)
        Me.Panel3.Controls.Add(Me.txtTotContra)
        Me.Panel3.Controls.Add(Me.lblTotContra)
        Me.Panel3.Controls.Add(Me.txtTotFavor)
        Me.Panel3.Controls.Add(Me.lblTotFavor)
        Me.Panel3.Location = New System.Drawing.Point(12, 579)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 68)
        Me.Panel3.TabIndex = 4
        '
        'lblTotFavor
        '
        Me.lblTotFavor.AutoSize = True
        Me.lblTotFavor.Location = New System.Drawing.Point(14, 10)
        Me.lblTotFavor.Name = "lblTotFavor"
        Me.lblTotFavor.Size = New System.Drawing.Size(103, 13)
        Me.lblTotFavor.TabIndex = 0
        Me.lblTotFavor.Text = "Tot. Tiempo a favor:"
        '
        'txtTotFavor
        '
        Me.txtTotFavor.Location = New System.Drawing.Point(123, 7)
        Me.txtTotFavor.Name = "txtTotFavor"
        Me.txtTotFavor.ReadOnly = True
        Me.txtTotFavor.Size = New System.Drawing.Size(57, 20)
        Me.txtTotFavor.TabIndex = 1
        '
        'txtTotContra
        '
        Me.txtTotContra.Location = New System.Drawing.Point(508, 11)
        Me.txtTotContra.Name = "txtTotContra"
        Me.txtTotContra.ReadOnly = True
        Me.txtTotContra.Size = New System.Drawing.Size(57, 20)
        Me.txtTotContra.TabIndex = 3
        '
        'lblTotContra
        '
        Me.lblTotContra.AutoSize = True
        Me.lblTotContra.Location = New System.Drawing.Point(399, 14)
        Me.lblTotContra.Name = "lblTotContra"
        Me.lblTotContra.Size = New System.Drawing.Size(103, 13)
        Me.lblTotContra.TabIndex = 2
        Me.lblTotContra.Text = "Tot. Tiempo a favor:"
        '
        'lblMesAnt
        '
        Me.lblMesAnt.AutoSize = True
        Me.lblMesAnt.Location = New System.Drawing.Point(14, 39)
        Me.lblMesAnt.Name = "lblMesAnt"
        Me.lblMesAnt.Size = New System.Drawing.Size(69, 13)
        Me.lblMesAnt.TabIndex = 4
        Me.lblMesAnt.Text = "Mes Anterior:"
        '
        'txtMesAnt
        '
        Me.txtMesAnt.Location = New System.Drawing.Point(89, 36)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.Size = New System.Drawing.Size(57, 20)
        Me.txtMesAnt.TabIndex = 5
        '
        'frmIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 648)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblTiempoContra)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblTiempoFavor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidencias"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.fgTfavor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.fgTcontra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTiempoFavor As Label
    Friend WithEvents lblTiempoContra As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents fgTfavor As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgTcontra As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMesAnt As TextBox
    Friend WithEvents lblMesAnt As Label
    Friend WithEvents txtTotContra As TextBox
    Friend WithEvents lblTotContra As Label
    Friend WithEvents txtTotFavor As TextBox
    Friend WithEvents lblTotFavor As Label
End Class
