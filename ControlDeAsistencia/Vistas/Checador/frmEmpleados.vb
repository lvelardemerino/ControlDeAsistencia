Imports MySql.Data.MySqlClient

Public Class frmEmpleados

    Dim _Estatus As Integer

    Public Property Estatus As Integer
        Get
            Estatus = _Estatus
        End Get
        Set(value As Integer)
            _Estatus = value
        End Set
    End Property

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Estatus > 0 Then
            EmpleadoActivo()
        Else
            EmpleadoInactivo()
            tsbNuevo.Enabled = False
        End If

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        If fgEmpleados.Row > 0 Then

            Dim frmEmpleadosMod As New frmEmpleadosMod()

            frmEmpleadosMod.Clave = CStr(fgEmpleados.GetData(fgEmpleados.Row, 0))
            frmEmpleadosMod.ShowDialog()

            If Estatus > 0 Then
                EmpleadoActivo()
            Else
                EmpleadoInactivo()
                tsbNuevo.Enabled = False
            End If

        End If

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Dim frmEmpleadosMod As New frmEmpleadosMod()

        frmEmpleadosMod.Clave = 0
        frmEmpleadosMod.ShowDialog()

        If Estatus > 0 Then
            EmpleadoActivo()
        Else
            EmpleadoInactivo()
            tsbNuevo.Enabled = False
        End If

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgEmpleados.Cols.Count = 6
        fgEmpleados.Rows.Count = 1

        fgEmpleados.Cols(0).Caption = "Clave"
        fgEmpleados.Cols(1).Caption = "Nombre"
        fgEmpleados.Cols(2).Caption = "Apellido Paterno"
        fgEmpleados.Cols(3).Caption = "Apellido Materno"
        fgEmpleados.Cols(4).Caption = "Sucursal"
        fgEmpleados.Cols(5).Caption = "Departamento"


        fgEmpleados.AutoSizeCols()
        fgEmpleados.Cols.Frozen = 1

    End Sub

    Private Sub EmpleadoActivo()

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        strSql = "SELECT "
        strSql += "a.clave, "
        strSql += "a.nombre, "
        strSql += "a.a_paterno, "
        strSql += "a.a_materno, "
        strSql += "c.departamento, "
        strSql += "b.sucursal, "
        strSql += "a.estatus "
        strSql += "FROM "
        strSql += "empleado a, "
        strSql += "departamento c, "
        strSql += "sucursal b "
        strSql += "WHERE "
        strSql += "a.id_departamento = c.id_departamento AND "
        strSql += "a.id_sucursal = b.id_sucursal AND "
        strSql += "a.estatus = 1 "
        strSql += "ORDER BY clave ASC"

        cmdObj.CommandText = strSql

        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            fgEmpleados.AddItem("")

            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 0, rdrObj.Item("clave"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 1, rdrObj.Item("nombre"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 2, rdrObj.Item("a_paterno"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 3, rdrObj.Item("a_materno"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 4, rdrObj.Item("departamento"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 5, rdrObj.Item("sucursal"))


        End While

        fgEmpleados.AutoSizeCols()

        rdrObj.Close()
        cnObj.Close()

    End Sub

    Private Sub EmpleadoInactivo()

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String
        strSql = "SELECT "
        strSql += "a.clave, "
        strSql += "a.nombre, "
        strSql += "a.a_paterno, "
        strSql += "a.a_materno, "
        strSql += "c.departamento, "
        strSql += "b.sucursal, "
        strSql += "a.estatus "
        strSql += "FROM "
        strSql += "empleado a, "
        strSql += "departamento c, "
        strSql += "sucursal b "
        strSql += "WHERE "
        strSql += "a.id_departamento = c.id_departamento AND "
        strSql += "a.id_sucursal = b.id_sucursal AND "
        strSql += "a.estatus = 0 "
        strSql += "ORDER BY clave ASC"

        cmdObj.CommandText = strSql

        Dim rdrObj As MySqlDataReader
        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

             fgEmpleados.AddItem("")

            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 0, rdrObj.Item("clave"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 1, rdrObj.Item("nombre"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 2, rdrObj.Item("a_paterno"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 3, rdrObj.Item("a_materno"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 4, rdrObj.Item("departamento"))
            fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 5, rdrObj.Item("sucursal"))

        End While

        fgEmpleados.AutoSizeCols()

        rdrObj.Close()
        cnObj.Close()

    End Sub

#End Region

End Class