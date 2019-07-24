<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrores))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbExecutar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fgErrores = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tsMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.fgErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackgroundImage = Global.ControlDeAsistencia.My.Resources.Resources.fondo
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExecutar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(908, 25)
        Me.tsMenu.TabIndex = 0
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbExecutar
        '
        Me.tsbExecutar.ForeColor = System.Drawing.Color.White
        Me.tsbExecutar.Image = Global.ControlDeAsistencia.My.Resources.Resources.cache_32x32_32
        Me.tsbExecutar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExecutar.Name = "tsbExecutar"
        Me.tsbExecutar.Size = New System.Drawing.Size(69, 22)
        Me.tsbExecutar.Text = "Ejecutar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fgErrores)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 327)
        Me.Panel1.TabIndex = 1
        '
        'fgErrores
        '
        Me.fgErrores.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgErrores.AllowEditing = False
        Me.fgErrores.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.fgErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgErrores.Location = New System.Drawing.Point(0, 0)
        Me.fgErrores.Name = "fgErrores"
        Me.fgErrores.Rows.DefaultSize = 19
        Me.fgErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgErrores.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgErrores.Size = New System.Drawing.Size(908, 327)
        Me.fgErrores.TabIndex = 0
        '
        'frmErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 358)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErrores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Errores"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.fgErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExecutar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fgErrores As C1.Win.C1FlexGrid.C1FlexGrid
End Class
