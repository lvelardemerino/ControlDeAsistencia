Imports MySql.Data.MySqlClient

Public Class frmDepartamentos

    Private Sub frmDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        If fgDepartamento.Row > 0 Then

            Dim frmDepartamentosMod As New frmDepartamentosMod
            frmDepartamentosMod.Id = fgDepartamento.GetData(fgDepartamento.Row, 0)
            frmDepartamentosMod.ShowDialog()

            Departamentos()

        End If

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Dim frmDepartamentosMod As New frmDepartamentosMod()
        frmDepartamentosMod.Id = 0
        frmDepartamentosMod.ShowDialog()

        Departamentos()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgDepartamento.Cols.Count = 4
        fgDepartamento.Rows.Count = 1

        fgDepartamento.Cols(0).Caption = "ID"
        fgDepartamento.Cols(0).Visible = False
        fgDepartamento.Cols(1).Caption = "DEPARTAMENTO"
        fgDepartamento.Cols(2).Caption = "AREA"
        fgDepartamento.Cols(3).Caption = "SUCURSAL"

        Departamentos()

        fgDepartamento.AutoSizeCols()

    End Sub

    Private Sub Departamentos()

        Dim rdrObj As MySqlDataReader

        rdrObj = Funciones.Departamentos

        While rdrObj.Read

            fgDepartamento.AddItem("")

            fgDepartamento.SetData(fgDepartamento.Rows.Count - 1, 0, rdrObj.Item("id_departamento"))
            fgDepartamento.SetData(fgDepartamento.Rows.Count - 1, 1, rdrObj.Item("departamento"))
            fgDepartamento.SetData(fgDepartamento.Rows.Count - 1, 2, rdrObj.Item("area"))
            fgDepartamento.SetData(fgDepartamento.Rows.Count - 1, 3, rdrObj.Item("sucursal"))

        End While

        rdrObj.Close()

    End Sub

#End Region

End Class