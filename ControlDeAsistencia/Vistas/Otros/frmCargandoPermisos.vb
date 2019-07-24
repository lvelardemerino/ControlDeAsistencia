Public Class frmCargandoPermisos

    Private Sub frmCargandoPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bPermiteAccesoOpciones = False
        lblLeyenda.Text = lblLeyenda.Text & " " & strUsrId & "..."

    End Sub

    Private Sub trmCargando_Tick(sender As Object, e As EventArgs) Handles trmCargando.Tick

        If Not bCargandoPermisos Then

            bMuestraVentanaOficinas = True
            Me.Close()

        End If

    End Sub

End Class