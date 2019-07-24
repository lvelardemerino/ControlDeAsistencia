Public Class frmSelSucursal

    Private Sub frmSelSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sucursales()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        intSucursal = cmbSucursales.SelectedValue
        Me.Close()

    End Sub

#Region "FUNCIONES"

    Private Sub Sucursales()

        cmbSucursales.DataSource = Nothing
        cmbSucursales.Items.Clear()
        cmbSucursales.Text = ""
        cmbSucursales.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = OficinasUsuario()

        cmbSucursales.ValueMember = "id_sucursal"
        cmbSucursales.DisplayMember = "sucursal"
        cmbSucursales.DataSource = dsObj.Tables("Sucursales")

    End Sub

#End Region

End Class