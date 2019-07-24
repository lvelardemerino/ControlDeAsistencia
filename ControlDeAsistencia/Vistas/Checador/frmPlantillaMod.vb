Imports MySql.Data.MySqlClient

Public Class frmPlantillaMod

    Dim dtJornada As New DataTable("jornada")
    Private _id As Integer

#Region "FORMULARIO"

    Public Property Id As Integer
        Get
            Id = _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Sub frmPlantillaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtJornada.Columns.Add("Id", GetType(Integer))
        dtJornada.Columns.Add("Dia", GetType(String))
        dtJornada.Columns.Add("Entrada", GetType(DateTime))
        dtJornada.Columns.Add("Salida", GetType(DateTime))

        If Id > 0 Then

            ObtienePlantilla()
            fgSemana1.Enabled = True
            fgSemana2.Enabled = True

            tsbImportar.Enabled = False
            cmbDepartamento.Enabled = True

        Else

            Configura()

        End If

    End Sub

    Private Sub tsbImportar_Click(sender As Object, e As EventArgs) Handles tsbImportar.Click

        Try
            ofdExcel.Reset()

            ofdExcel.RestoreDirectory = True
            ofdExcel.FilterIndex = 1

            ofdExcel.Filter = "Excel (*.xls)|*.xls|Todos los archivos (*.*)|*.*"

            ofdExcel.AddExtension = True

            If ofdExcel.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                If ofdExcel.FileName.Length > 0 Then
                    ImportarJornada(ofdExcel.FileName)
                End If
            End If


        Catch ex As System.Exception

            MessageBox.Show("Ocurrió el siguiente error: '" & ex.Message & "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub

        End Try

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        If txtPlantilla.Text <> "" Then
            Guardar()
        End If

    End Sub

#End Region

#Region "FUNCIONES"

    Private Sub Configura()

        Departamentos()
        Sucursales()


        fgSemana1.Cols.Count = 3
        fgSemana1.Rows.Count = 1

        fgSemana1.Cols(0).Caption = "DIA"
        fgSemana1.Cols(1).Caption = "ENTRADA"
        fgSemana1.Cols(2).Caption = "SALIDA"

        For i As Integer = 1 To 7

            fgSemana1.AddItem("")

            Select Case i

                Case 1
                    fgSemana1.SetData(i, 0, "LUNES")

                Case 2
                    fgSemana1.SetData(i, 0, "MARTES")

                Case 3
                    fgSemana1.SetData(i, 0, "MIERCOLES")

                Case 4
                    fgSemana1.SetData(i, 0, "JUEVES")

                Case 5
                    fgSemana1.SetData(i, 0, "VIERNES")

                Case 6
                    fgSemana1.SetData(i, 0, "SABADO")

                Case 7
                    fgSemana1.SetData(i, 0, "DOMINGO")

            End Select

        Next

        fgSemana1.Cols(0).Width = 70
        fgSemana1.Cols(1).Width = 64
        fgSemana1.Cols(2).Width = 64

 
        fgSemana2.Cols.Count = 3
        fgSemana2.Rows.Count = 1

        fgSemana2.Cols(0).Caption = "DIA"
        fgSemana2.Cols(1).Caption = "ENTRADA"
        fgSemana2.Cols(2).Caption = "SALIDA"

        For i As Integer = 1 To 7

            fgSemana2.AddItem("")

            Select Case i

                Case 1
                    fgSemana2.SetData(i, 0, "LUNES")

                Case 2
                    fgSemana2.SetData(i, 0, "MARTES")

                Case 3
                    fgSemana2.SetData(i, 0, "MIERCOLES")

                Case 4
                    fgSemana2.SetData(i, 0, "JUEVES")

                Case 5
                    fgSemana2.SetData(i, 0, "VIERNES")

                Case 6
                    fgSemana2.SetData(i, 0, "SABADO")

                Case 7
                    fgSemana2.SetData(i, 0, "DOMINGO")

            End Select

        Next

        fgSemana2.Cols(0).Width = 70
        fgSemana2.Cols(1).Width = 64
        fgSemana2.Cols(2).Width = 64

    End Sub

    Private Sub Departamentos()

        cmbDepartamento.DataSource = Nothing
        cmbDepartamento.Items.Clear()
        cmbDepartamento.Text = ""
        cmbDepartamento.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_departamento()

        cmbDepartamento.ValueMember = "id_departamento"
        cmbDepartamento.DisplayMember = "departamento"
        cmbDepartamento.DataSource = dsObj.Tables("Departamento")

    End Sub

    Private Sub Sucursales()

        cmbSucursal.DataSource = Nothing
        cmbSucursal.Items.Clear()
        cmbSucursal.Text = ""
        cmbSucursal.SelectedValue = ""

        Dim dsObj As DataSet = New DataSet()
        dsObj = Obtiene_sucursal()

        cmbSucursal.ValueMember = "id_sucursal"
        cmbSucursal.DisplayMember = "sucursal"
        cmbSucursal.DataSource = dsObj.Tables("Sucursal")

    End Sub

    Private Sub ObtienePlantilla()

        Configura()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        strSql = "SELECT "
        strSql += "a.plantilla, "
        strSql += "b.departamento, "
        strSql += "c.sucursal, "
        strSql += "a.lunes1_entrada, "
        strSql += "a.lunes1_salida, "
        strSql += "a.martes1_entrada, "
        strSql += "a.martes1_salida, "
        strSql += "a.miercoles1_entrada, "
        strSql += "a.miercoles1_salida, "
        strSql += "a.jueves1_entrada, "
        strSql += "a.jueves1_salida, "
        strSql += "a.viernes1_entrada, "
        strSql += "a.viernes1_salida, "
        strSql += "a.sabado1_entrada, "
        strSql += "a.sabado1_salida, "
        strSql += "a.domingo1_entrada, "
        strSql += "a.domingo1_salida, "
        strSql += "a.lunes2_entrada, "
        strSql += "a.lunes2_salida, "
        strSql += "a.martes2_entrada, "
        strSql += "a.martes2_salida, "
        strSql += "a.miercoles2_entrada, "
        strSql += "a.miercoles2_salida, "
        strSql += "a.jueves2_entrada, "
        strSql += "a.jueves2_salida, "
        strSql += "a.viernes2_entrada, "
        strSql += "a.viernes2_salida, "
        strSql += "a.sabado2_entrada, "
        strSql += "a.sabado2_salida, "
        strSql += "a.domingo2_entrada, "
        strSql += "a.domingo2_salida "
        strSql += "FROM "
        strSql += "plantilla a, "
        strSql += "departamento b, "
        strSql += "sucursal c "
        strSql += "WHERE "
        strSql += "a.id_departamento = b.id_departamento AND "
        strSql += "a.id_sucursal = c.id_sucursal AND "
        strSql += "id_plantilla = '" & Id & "'"

        cmdObj.CommandText = strSql
        Dim rdrObj As MySqlDataReader

        rdrObj = cmdObj.ExecuteReader

        While rdrObj.Read

            cmbDepartamento.Text = rdrObj.Item("departamento")
            cmbSucursal.Text = rdrObj.Item("sucursal")
            txtPlantilla.Text = rdrObj.Item("plantilla")

            fgSemana1.SetData(1, 1, rdrObj(3).ToString)
            fgSemana1.SetData(1, 2, rdrObj(4).ToString)
            fgSemana1.SetData(2, 1, rdrObj(5).ToString)
            fgSemana1.SetData(2, 2, rdrObj(6).ToString)
            fgSemana1.SetData(3, 1, rdrObj(7).ToString)
            fgSemana1.SetData(3, 2, rdrObj(8).ToString)
            fgSemana1.SetData(4, 1, rdrObj(9).ToString)
            fgSemana1.SetData(4, 2, rdrObj(10).ToString)
            fgSemana1.SetData(5, 1, rdrObj(11).ToString)
            fgSemana1.SetData(5, 2, rdrObj(12).ToString)
            fgSemana1.SetData(6, 1, rdrObj(13).ToString)
            fgSemana1.SetData(6, 2, rdrObj(14).ToString)
            fgSemana1.SetData(7, 1, rdrObj(15).ToString)
            fgSemana1.SetData(7, 2, rdrObj(16).ToString)

            fgSemana2.SetData(1, 1, rdrObj(17).ToString)
            fgSemana2.SetData(1, 2, rdrObj(18).ToString)
            fgSemana2.SetData(2, 1, rdrObj(19).ToString)
            fgSemana2.SetData(2, 2, rdrObj(20).ToString)
            fgSemana2.SetData(3, 1, rdrObj(21).ToString)
            fgSemana2.SetData(3, 2, rdrObj(22).ToString)
            fgSemana2.SetData(4, 1, rdrObj(23).ToString)
            fgSemana2.SetData(4, 2, rdrObj(24).ToString)
            fgSemana2.SetData(5, 1, rdrObj(25).ToString)
            fgSemana2.SetData(5, 2, rdrObj(26).ToString)
            fgSemana2.SetData(6, 1, rdrObj(27).ToString)
            fgSemana2.SetData(6, 2, rdrObj(28).ToString)
            fgSemana2.SetData(7, 1, rdrObj(29).ToString)
            fgSemana2.SetData(7, 2, rdrObj(30).ToString)

        End While

        rdrObj.Close()
        cnObj.Close()

        cmbDepartamento.Enabled = False
        cmbSucursal.Enabled = False
        txtPlantilla.ReadOnly = True

        fgSemana1.Enabled = False
        fgSemana2.Enabled = False

        cmbDepartamento.Enabled = False

    End Sub

    Private Sub ImportarJornada(ByVal strArchivo As String)

        Dim cnEx As New OleDb.OleDbConnection()
        cnEx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=" & strArchivo & ";Extended Properties=""Excel 8.0;HDR=NO;IMEX=1"""

        cnEx.Open()

        If Not cnEx Is Nothing Then

            Dim cmdEx As New OleDb.OleDbCommand()
            cmdEx.Connection = cnEx

            Dim rdrEx As OleDb.OleDbDataReader

            Dim strSql As String

            strSql = "SELECT * "
            strSql = strSql & "FROM "
            strSql = strSql & "[Hoja1$]"

            cmdEx.CommandText = strSql

            Try

                rdrEx = cmdEx.ExecuteReader()
                Dim Cons As Integer = 1

                Do While rdrEx.Read()

                    Dim drNewRowJor As DataRow = dtJornada.NewRow

                    drNewRowJor("Id") = Cons
                    drNewRowJor("Dia") = rdrEx.Item(0) & ""
                    If Not rdrEx.Item(1) Is DBNull.Value Then
                        drNewRowJor("Entrada") = rdrEx.Item(1) & ""
                    Else
                        drNewRowJor("Entrada") = Date.Parse("00:00:00")
                    End If

                    If Not rdrEx.Item(2) Is DBNull.Value Then
                        drNewRowJor("Salida") = rdrEx.Item(2) & ""
                    Else
                        drNewRowJor("Salida") = Date.Parse("00:00:00")
                    End If

                    dtJornada.Rows.Add(drNewRowJor)
                    Cons += 1

                Loop

                rdrEx.Close()

            Catch ex As Exception
                cnEx.Close()
                MessageBox.Show("Ocurrió el siguiente error: '" & ex.Message & "'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            cnEx.Close()

        End If

        For j As Integer = 1 To 7

            Dim drJorRow As DataRow() = dtJornada.Select("Id = " & j & "")
            Dim drRowJor As DataRow

            For Each drRowJor In drJorRow

                fgSemana1.SetData(j, 1, Format(drRowJor("Entrada"), "H:mm:ss"))
                fgSemana1.SetData(j, 2, Format(drRowJor("Salida"), "H:mm:ss"))


            Next

        Next

        Dim k As Integer = 1

        For j As Integer = 8 To 14

            Dim drJorRow As DataRow() = dtJornada.Select("Id = " & j & "")
            Dim drRowJor As DataRow

            For Each drRowJor In drJorRow

                fgSemana2.SetData(k, 1, Format(drRowJor("Entrada"), "H:mm:ss"))
                fgSemana2.SetData(k, 2, Format(drRowJor("Salida"), "H:mm:ss"))

                k += 1

            Next

        Next

    End Sub

    Private Sub Guardar()

        Dim cnObj As New MySqlConnection
        cnObj = conectar()

        Dim cmdObj As New MySqlCommand
        cmdObj.Connection = cnObj

        Dim strSql As String

        If Id > 0 Then

            strSql = "UPDATE "
            strSql += "plantilla "
            strSql += "SET "
            strSql += "id_departamento = '" & cmbDepartamento.SelectedValue & "', "
            strSql += "lunes1_entrada = '" & fgSemana1.GetData(1, 1) & "', "
            strSql += "lunes1_salida = '" & fgSemana1.GetData(1, 2) & "', "
            strSql += "martes1_entrada = '" & fgSemana1.GetData(2, 1) & "', "
            strSql += "martes1_salida = '" & fgSemana1.GetData(2, 2) & "', "
            strSql += "miercoles1_entrada = '" & fgSemana1.GetData(3, 1) & "', "
            strSql += "miercoles1_salida = '" & fgSemana1.GetData(3, 2) & "', "
            strSql += "jueves1_entrada = '" & fgSemana1.GetData(4, 1) & "', "
            strSql += "jueves1_salida = '" & fgSemana1.GetData(4, 2) & "', "
            strSql += "viernes1_entrada = '" & fgSemana1.GetData(5, 1) & "', "
            strSql += "viernes1_salida = '" & fgSemana1.GetData(5, 2) & "', "
            strSql += "sabado1_entrada = '" & fgSemana1.GetData(6, 1) & "', "
            strSql += "sabado1_salida = '" & fgSemana1.GetData(6, 2) & "', "
            strSql += "domingo1_entrada = '" & fgSemana1.GetData(7, 1) & "', "
            strSql += "domingo1_salida = '" & fgSemana1.GetData(7, 2) & "', "
            strSql += "lunes2_entrada = '" & fgSemana2.GetData(1, 1) & "', "
            strSql += "lunes2_salida = '" & fgSemana2.GetData(1, 2) & "', "
            strSql += "martes2_entrada = '" & fgSemana2.GetData(2, 1) & "', "
            strSql += "martes2_salida = '" & fgSemana2.GetData(2, 2) & "', "
            strSql += "miercoles2_entrada = '" & fgSemana2.GetData(3, 1) & "', "
            strSql += "miercoles2_salida = '" & fgSemana2.GetData(3, 2) & "', "
            strSql += "jueves2_entrada = '" & fgSemana2.GetData(4, 1) & "', "
            strSql += "jueves2_salida = '" & fgSemana2.GetData(4, 2) & "', "
            strSql += "viernes2_entrada = '" & fgSemana2.GetData(5, 1) & "', "
            strSql += "viernes2_salida = '" & fgSemana2.GetData(5, 2) & "', "
            strSql += "sabado2_entrada = '" & fgSemana2.GetData(6, 1) & "', "
            strSql += "sabado2_salida = '" & fgSemana2.GetData(6, 2) & "', "
            strSql += "domingo2_entrada = '" & fgSemana2.GetData(7, 1) & "', "
            strSql += "domingo2_salida = '" & fgSemana2.GetData(7, 2) & "' "
            strSql += "WHERE "
            strSql += "id_plantilla = '" & Id & "'"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al Guardar los Datos " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else

            strSql = "INSERT "
            strSql += "INTO "
            strSql += "plantilla "
            strSql += "(plantilla, "
            strSql += "id_departamento, "
            strSql += "id_sucursal, "
            strSql += "lunes1_entrada, "
            strSql += "lunes1_salida, "
            strSql += "martes1_entrada, "
            strSql += "martes1_salida, "
            strSql += "miercoles1_entrada, "
            strSql += "miercoles1_salida, "
            strSql += "jueves1_entrada, "
            strSql += "jueves1_salida, "
            strSql += "viernes1_entrada, "
            strSql += "viernes1_salida, "
            strSql += "sabado1_entrada, "
            strSql += "sabado1_salida, "
            strSql += "domingo1_entrada, "
            strSql += "domingo1_salida, "
            strSql += "lunes2_entrada, "
            strSql += "lunes2_salida, "
            strSql += "martes2_entrada, "
            strSql += "martes2_salida, "
            strSql += "miercoles2_entrada, "
            strSql += "miercoles2_salida, "
            strSql += "jueves2_entrada, "
            strSql += "jueves2_salida, "
            strSql += "viernes2_entrada, "
            strSql += "viernes2_salida, "
            strSql += "sabado2_entrada, "
            strSql += "sabado2_salida, "
            strSql += "domingo2_entrada, "
            strSql += "domingo2_salida) "
            strSql += "VALUES "
            strSql += "('" & txtPlantilla.Text & "', "
            strSql += "'" & cmbDepartamento.SelectedValue & "', "
            strSql += "'" & cmbSucursal.SelectedValue & "', "
            strSql += "'" & fgSemana1.GetData(1, 1) & "', "
            strSql += "'" & fgSemana1.GetData(1, 2) & "', "
            strSql += "'" & fgSemana1.GetData(2, 1) & "', "
            strSql += "'" & fgSemana1.GetData(2, 2) & "', "
            strSql += "'" & fgSemana1.GetData(3, 1) & "', "
            strSql += "'" & fgSemana1.GetData(3, 2) & "', "
            strSql += "'" & fgSemana1.GetData(4, 1) & "', "
            strSql += "'" & fgSemana1.GetData(4, 2) & "', "
            strSql += "'" & fgSemana1.GetData(5, 1) & "', "
            strSql += "'" & fgSemana1.GetData(5, 2) & "', "
            strSql += "'" & fgSemana1.GetData(6, 1) & "', "
            strSql += "'" & fgSemana1.GetData(6, 2) & "', "
            strSql += "'" & fgSemana1.GetData(7, 1) & "', "
            strSql += "'" & fgSemana1.GetData(7, 2) & "', "
            strSql += "'" & fgSemana2.GetData(1, 1) & "', "
            strSql += "'" & fgSemana2.GetData(1, 2) & "', "
            strSql += "'" & fgSemana2.GetData(2, 1) & "', "
            strSql += "'" & fgSemana2.GetData(2, 2) & "', "
            strSql += "'" & fgSemana2.GetData(3, 1) & "', "
            strSql += "'" & fgSemana2.GetData(3, 2) & "', "
            strSql += "'" & fgSemana2.GetData(4, 1) & "', "
            strSql += "'" & fgSemana2.GetData(4, 2) & "', "
            strSql += "'" & fgSemana2.GetData(5, 1) & "', "
            strSql += "'" & fgSemana2.GetData(5, 2) & "', "
            strSql += "'" & fgSemana2.GetData(6, 1) & "', "
            strSql += "'" & fgSemana2.GetData(6, 2) & "', "
            strSql += "'" & fgSemana2.GetData(7, 1) & "', "
            strSql += "'" & fgSemana2.GetData(7, 2) & "')"

            cmdObj.CommandText = strSql

            Try
                cmdObj.ExecuteNonQuery()
                MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al Guardar los Datos " + ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        Me.Close()

    End Sub

#End Region

End Class