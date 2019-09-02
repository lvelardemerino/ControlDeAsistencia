Public Class frmIncidencias

    Private _fecha As Date

    Public Property fecha As Date
        Get
            fecha = _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Private primerDia, ultimoDia As Date
    Private Cuenta As Integer = 1

    Private Sub frmIncidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configura()

        primerDia = PrimerDiaDelMes(fecha)
        ultimoDia = UltimoDiaDelMes(fecha)

        LlenaGrid()

    End Sub

#Region "FUNCIONES"

    Private Sub Configura()

        fgTfavor.Cols.Count = 4
        fgTfavor.Rows.Count = 1

        fgTfavor.Cols(0).Caption = "FECHA"
        fgTfavor.Cols(1).Caption = "DIA"
        fgTfavor.Cols(2).Caption = "INCIDENCIA"
        fgTfavor.Cols(3).Caption = "TIEMPO"

        fgTfavor.AutoSizeCols()

        fgTcontra.Cols.Count = 4
        fgTcontra.Rows.Count = 1

        fgTcontra.Cols(0).Caption = "FECHA"
        fgTcontra.Cols(1).Caption = "DIA"
        fgTcontra.Cols(2).Caption = "INCIDENCIA"
        fgTcontra.Cols(3).Caption = "TIEMPO"

        fgTcontra.AutoSizeCols()

    End Sub

    Private Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date

        Dim Valor As Date

        Valor = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)

        Return Valor

    End Function

    Private Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date

        Dim Valor As Date

        Valor = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)

        Return Valor

    End Function

    Private Sub LlenaGrid()

        Dim DiaConsecutivo As DateTime

        DiaConsecutivo = primerDia

        While (DiaConsecutivo <= ultimoDia)

            fgTfavor.AddItem("")

            fgTfavor.SetData(fgTfavor.Rows.Count - 1, 0, DiaConsecutivo)
            fgTfavor.SetData(fgTfavor.Rows.Count - 1, 1, UCase(Format(DiaConsecutivo, "dddd")))

            fgTcontra.AddItem("")

            fgTcontra.SetData(fgTcontra.Rows.Count - 1, 0, DiaConsecutivo)
            fgTcontra.SetData(fgTcontra.Rows.Count - 1, 1, UCase(Format(DiaConsecutivo, "dddd")))

            DiaConsecutivo = primerDia.AddDays(Cuenta)
            Cuenta += 1

        End While

        fgTfavor.AutoSizeCols()
        fgTcontra.AutoSizeCols()

    End Sub

#End Region

End Class