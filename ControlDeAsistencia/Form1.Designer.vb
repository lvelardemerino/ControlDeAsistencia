<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdi
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMdi))
        Me.tsMenu = New System.Windows.Forms.MenuStrip()
        Me.ControlDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmpleadosAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmpleadosBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiJornada = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiJornadaEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiJornadaRevisar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiJornadaModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiJornadaActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModificarDia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAutorizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAutorizarPermiso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAutorizarFalta = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPermisoPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCambioDescanso = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminaIncidencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiVacaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDiasFestivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTiempoEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesAsistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRevisarErrores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosSucursales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosDepartamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogoUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgwPermisos = New System.ComponentModel.BackgroundWorker()
        Me.tmrVentanaOficinas = New System.Windows.Forms.Timer(Me.components)
        Me.bgwActualizar = New System.ComponentModel.BackgroundWorker()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.tsMenuInf = New System.Windows.Forms.ToolStrip()
        Me.tslHora = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslActualizando = New System.Windows.Forms.ToolStripLabel()
        Me.tslVer = New System.Windows.Forms.ToolStripLabel()
        Me.tslVersion = New System.Windows.Forms.ToolStripLabel()
        Me.tsMenu.SuspendLayout()
        Me.tsMenuInf.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeAsistenciaToolStripMenuItem, Me.tsmiCatalogos})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(780, 24)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "MenuStrip1"
        '
        'ControlDeAsistenciaToolStripMenuItem
        '
        Me.ControlDeAsistenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEmpleados, Me.tsmiJornada, Me.tsmiModificarDia, Me.tsmiAutorizar, Me.tsmiVacaciones, Me.tsmiDiasFestivos, Me.tsmiTiempoEmpleado, Me.tsmiReportes, Me.tsmiRevisarErrores})
        Me.ControlDeAsistenciaToolStripMenuItem.Name = "ControlDeAsistenciaToolStripMenuItem"
        Me.ControlDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.ControlDeAsistenciaToolStripMenuItem.Tag = "1"
        Me.ControlDeAsistenciaToolStripMenuItem.Text = "Control de Asistencia"
        '
        'tsmiEmpleados
        '
        Me.tsmiEmpleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEmpleadosAltas, Me.tsmiEmpleadosBajas})
        Me.tsmiEmpleados.Name = "tsmiEmpleados"
        Me.tsmiEmpleados.Size = New System.Drawing.Size(186, 22)
        Me.tsmiEmpleados.Text = "Empleados"
        '
        'tsmiEmpleadosAltas
        '
        Me.tsmiEmpleadosAltas.Name = "tsmiEmpleadosAltas"
        Me.tsmiEmpleadosAltas.Size = New System.Drawing.Size(101, 22)
        Me.tsmiEmpleadosAltas.Text = "Altas"
        '
        'tsmiEmpleadosBajas
        '
        Me.tsmiEmpleadosBajas.Name = "tsmiEmpleadosBajas"
        Me.tsmiEmpleadosBajas.Size = New System.Drawing.Size(101, 22)
        Me.tsmiEmpleadosBajas.Text = "Bajas"
        '
        'tsmiJornada
        '
        Me.tsmiJornada.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlantillaToolStripMenuItem, Me.tsmiJornadaEmpleado, Me.tsmiJornadaRevisar, Me.tsmiJornadaModificar, Me.tsmiJornadaActualizar})
        Me.tsmiJornada.Name = "tsmiJornada"
        Me.tsmiJornada.Size = New System.Drawing.Size(186, 22)
        Me.tsmiJornada.Tag = "20"
        Me.tsmiJornada.Text = "Jornada"
        '
        'PlantillaToolStripMenuItem
        '
        Me.PlantillaToolStripMenuItem.Name = "PlantillaToolStripMenuItem"
        Me.PlantillaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PlantillaToolStripMenuItem.Text = "Plantilla"
        '
        'tsmiJornadaEmpleado
        '
        Me.tsmiJornadaEmpleado.Name = "tsmiJornadaEmpleado"
        Me.tsmiJornadaEmpleado.Size = New System.Drawing.Size(161, 22)
        Me.tsmiJornadaEmpleado.Tag = "10"
        Me.tsmiJornadaEmpleado.Text = "Empleado"
        '
        'tsmiJornadaRevisar
        '
        Me.tsmiJornadaRevisar.Name = "tsmiJornadaRevisar"
        Me.tsmiJornadaRevisar.Size = New System.Drawing.Size(161, 22)
        Me.tsmiJornadaRevisar.Tag = "20"
        Me.tsmiJornadaRevisar.Text = "Revisar"
        '
        'tsmiJornadaModificar
        '
        Me.tsmiJornadaModificar.Name = "tsmiJornadaModificar"
        Me.tsmiJornadaModificar.Size = New System.Drawing.Size(161, 22)
        Me.tsmiJornadaModificar.Tag = "30"
        Me.tsmiJornadaModificar.Text = "Modificar"
        '
        'tsmiJornadaActualizar
        '
        Me.tsmiJornadaActualizar.Name = "tsmiJornadaActualizar"
        Me.tsmiJornadaActualizar.Size = New System.Drawing.Size(161, 22)
        Me.tsmiJornadaActualizar.Tag = "40"
        Me.tsmiJornadaActualizar.Text = "Eliminar Jornada"
        '
        'tsmiModificarDia
        '
        Me.tsmiModificarDia.Name = "tsmiModificarDia"
        Me.tsmiModificarDia.Size = New System.Drawing.Size(186, 22)
        Me.tsmiModificarDia.Tag = "30"
        Me.tsmiModificarDia.Text = "Modificar Dia"
        '
        'tsmiAutorizar
        '
        Me.tsmiAutorizar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAutorizarPermiso, Me.tsmiAutorizarFalta, Me.tsmiPermisoPersonal, Me.tsmiCambioDescanso, Me.tsmiEliminaIncidencia})
        Me.tsmiAutorizar.Name = "tsmiAutorizar"
        Me.tsmiAutorizar.Size = New System.Drawing.Size(186, 22)
        Me.tsmiAutorizar.Tag = "40"
        Me.tsmiAutorizar.Text = "Autorizar"
        '
        'tsmiAutorizarPermiso
        '
        Me.tsmiAutorizarPermiso.Name = "tsmiAutorizarPermiso"
        Me.tsmiAutorizarPermiso.Size = New System.Drawing.Size(185, 22)
        Me.tsmiAutorizarPermiso.Text = "Permiso"
        '
        'tsmiAutorizarFalta
        '
        Me.tsmiAutorizarFalta.Name = "tsmiAutorizarFalta"
        Me.tsmiAutorizarFalta.Size = New System.Drawing.Size(185, 22)
        Me.tsmiAutorizarFalta.Text = "Falta"
        '
        'tsmiPermisoPersonal
        '
        Me.tsmiPermisoPersonal.Name = "tsmiPermisoPersonal"
        Me.tsmiPermisoPersonal.Size = New System.Drawing.Size(185, 22)
        Me.tsmiPermisoPersonal.Text = "Permiso Personal"
        '
        'tsmiCambioDescanso
        '
        Me.tsmiCambioDescanso.Name = "tsmiCambioDescanso"
        Me.tsmiCambioDescanso.Size = New System.Drawing.Size(185, 22)
        Me.tsmiCambioDescanso.Text = "Cambio de Descanso"
        '
        'tsmiEliminaIncidencia
        '
        Me.tsmiEliminaIncidencia.Name = "tsmiEliminaIncidencia"
        Me.tsmiEliminaIncidencia.Size = New System.Drawing.Size(185, 22)
        Me.tsmiEliminaIncidencia.Text = "Elimina Incidencia"
        '
        'tsmiVacaciones
        '
        Me.tsmiVacaciones.Name = "tsmiVacaciones"
        Me.tsmiVacaciones.Size = New System.Drawing.Size(186, 22)
        Me.tsmiVacaciones.Tag = "50"
        Me.tsmiVacaciones.Text = "Vacaciones"
        '
        'tsmiDiasFestivos
        '
        Me.tsmiDiasFestivos.Name = "tsmiDiasFestivos"
        Me.tsmiDiasFestivos.Size = New System.Drawing.Size(186, 22)
        Me.tsmiDiasFestivos.Text = "Dias Festivos"
        '
        'tsmiTiempoEmpleado
        '
        Me.tsmiTiempoEmpleado.Name = "tsmiTiempoEmpleado"
        Me.tsmiTiempoEmpleado.Size = New System.Drawing.Size(186, 22)
        Me.tsmiTiempoEmpleado.Tag = "60"
        Me.tsmiTiempoEmpleado.Text = "Tiempo de Empleado"
        '
        'tsmiReportes
        '
        Me.tsmiReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiReportesAsistencia})
        Me.tsmiReportes.Name = "tsmiReportes"
        Me.tsmiReportes.Size = New System.Drawing.Size(186, 22)
        Me.tsmiReportes.Tag = "70"
        Me.tsmiReportes.Text = "Reportes"
        '
        'tsmiReportesAsistencia
        '
        Me.tsmiReportesAsistencia.Name = "tsmiReportesAsistencia"
        Me.tsmiReportesAsistencia.Size = New System.Drawing.Size(127, 22)
        Me.tsmiReportesAsistencia.Text = "Asistencia"
        '
        'tsmiRevisarErrores
        '
        Me.tsmiRevisarErrores.Name = "tsmiRevisarErrores"
        Me.tsmiRevisarErrores.Size = New System.Drawing.Size(186, 22)
        Me.tsmiRevisarErrores.Text = "Revisar Errores"
        '
        'tsmiCatalogos
        '
        Me.tsmiCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCatalogosSucursales, Me.tsmiCatalogosArea, Me.tsmiCatalogosDepartamentos, Me.tsmiCatalogoUsuarios})
        Me.tsmiCatalogos.Name = "tsmiCatalogos"
        Me.tsmiCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.tsmiCatalogos.Text = "Catalogos"
        '
        'tsmiCatalogosSucursales
        '
        Me.tsmiCatalogosSucursales.Name = "tsmiCatalogosSucursales"
        Me.tsmiCatalogosSucursales.Size = New System.Drawing.Size(155, 22)
        Me.tsmiCatalogosSucursales.Text = "Sucursales"
        '
        'tsmiCatalogosArea
        '
        Me.tsmiCatalogosArea.Name = "tsmiCatalogosArea"
        Me.tsmiCatalogosArea.Size = New System.Drawing.Size(155, 22)
        Me.tsmiCatalogosArea.Text = "Area"
        '
        'tsmiCatalogosDepartamentos
        '
        Me.tsmiCatalogosDepartamentos.Name = "tsmiCatalogosDepartamentos"
        Me.tsmiCatalogosDepartamentos.Size = New System.Drawing.Size(155, 22)
        Me.tsmiCatalogosDepartamentos.Text = "Departamentos"
        '
        'tsmiCatalogoUsuarios
        '
        Me.tsmiCatalogoUsuarios.Name = "tsmiCatalogoUsuarios"
        Me.tsmiCatalogoUsuarios.Size = New System.Drawing.Size(155, 22)
        Me.tsmiCatalogoUsuarios.Text = "Usuarios"
        '
        'bgwActualizar
        '
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'tsMenuInf
        '
        Me.tsMenuInf.BackgroundImage = CType(resources.GetObject("tsMenuInf.BackgroundImage"), System.Drawing.Image)
        Me.tsMenuInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMenuInf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslHora, Me.ToolStripSeparator1, Me.tslActualizando, Me.tslVer, Me.tslVersion})
        Me.tsMenuInf.Location = New System.Drawing.Point(0, 494)
        Me.tsMenuInf.Name = "tsMenuInf"
        Me.tsMenuInf.Size = New System.Drawing.Size(780, 25)
        Me.tsMenuInf.TabIndex = 3
        Me.tsMenuInf.Text = "ToolStrip1"
        '
        'tslHora
        '
        Me.tslHora.ForeColor = System.Drawing.Color.White
        Me.tslHora.Name = "tslHora"
        Me.tslHora.Size = New System.Drawing.Size(87, 22)
        Me.tslHora.Text = "ToolStripLabel1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslActualizando
        '
        Me.tslActualizando.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tslActualizando.Image = CType(resources.GetObject("tslActualizando.Image"), System.Drawing.Image)
        Me.tslActualizando.Name = "tslActualizando"
        Me.tslActualizando.Size = New System.Drawing.Size(16, 22)
        Me.tslActualizando.Text = "ToolStripLabel1"
        Me.tslActualizando.Visible = False
        '
        'tslVer
        '
        Me.tslVer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslVer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslVer.ForeColor = System.Drawing.Color.White
        Me.tslVer.Name = "tslVer"
        Me.tslVer.Size = New System.Drawing.Size(37, 22)
        Me.tslVer.Text = "1.0.0"
        '
        'tslVersion
        '
        Me.tslVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslVersion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslVersion.ForeColor = System.Drawing.Color.White
        Me.tslVersion.Name = "tslVersion"
        Me.tslVersion.Size = New System.Drawing.Size(32, 22)
        Me.tslVersion.Text = "Ver."
        '
        'frmMdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 519)
        Me.Controls.Add(Me.tsMenuInf)
        Me.Controls.Add(Me.tsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.tsMenu
        Me.Name = "frmMdi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maranatha"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.tsMenuInf.ResumeLayout(False)
        Me.tsMenuInf.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ControlDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiJornada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiJornadaEmpleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiJornadaRevisar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiJornadaModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiJornadaActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiModificarDia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAutorizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVacaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTiempoEmpleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiReportesAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bgwPermisos As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrVentanaOficinas As System.Windows.Forms.Timer
    Friend WithEvents tsMenuInf As System.Windows.Forms.ToolStrip
    Friend WithEvents PlantillaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEmpleadosAltas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEmpleadosBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAutorizarPermiso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAutorizarFalta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCatalogos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCatalogosSucursales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCatalogosDepartamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCatalogosArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPermisoPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCambioDescanso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDiasFestivos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCatalogoUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bgwActualizar As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents tslHora As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslActualizando As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsmiRevisarErrores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminaIncidencia As ToolStripMenuItem
    Friend WithEvents tslVer As ToolStripLabel
    Friend WithEvents tslVersion As ToolStripLabel
End Class
