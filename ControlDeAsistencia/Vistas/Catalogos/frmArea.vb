Imports MySql.Data.MySqlClient

Public Class frmArea

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgAreas.Cols.Count = 2
        fgAreas.Rows.Count = 1

        fgAreas.Cols(0).Caption = "ID"
        fgAreas.Cols(0).Visible = False
        fgAreas.Cols(1).Caption = "AREA"

        Areas()

        fgAreas.AutoSizeCols()

    End Sub

    Private Sub Areas()

        Dim rdrObj As MySqlDataReader

        rdrObj = Funciones.Areas

        While rdrObj.Read

            fgAreas.AddItem("")

            fgAreas.SetData(fgAreas.Rows.Count - 1, 0, rdrObj.Item("id_area"))
            fgAreas.SetData(fgAreas.Rows.Count - 1, 1, rdrObj.Item("area"))

        End While

        rdrObj.Close()

    End Sub

#End Region

End Class