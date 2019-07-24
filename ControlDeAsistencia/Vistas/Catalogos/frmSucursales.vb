Public Class frmSucursales

    Private Sub frmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        If fgSucursales.Row > 0 Then

            Dim frmSucursalesMod As New frmSucursalesMod()
            frmSucursalesMod.Id = fgSucursales.GetData(fgSucursales.Row, 0)
            frmSucursalesMod.ShowDialog()

            Sucursales()

        End If

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click

        Dim frmSucursalesMod As New frmSucursalesMod()
        frmSucursalesMod.Id = 0
        frmSucursalesMod.ShowDialog()

        Sucursales()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgSucursales.Cols.Count = 2
        fgSucursales.Rows.Count = 1

        fgSucursales.Cols(0).Caption = "ID"
        fgSucursales.Cols(0).Visible = False
        fgSucursales.Cols(1).Caption = "SUCURSAL"

        fgSucursales.AutoSizeCols()

        Sucursales()

    End Sub

    Private Sub Sucursales()

        Dim dsobj As New DataSet

        dsobj = Obtiene_sucursal()

        fgSucursales.DataSource = dsobj.Tables("Sucursal")

        fgSucursales.AutoSizeCols()

    End Sub

#End Region

End Class