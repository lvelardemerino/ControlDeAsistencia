Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Len(Trim(txtUsr.Text & "")) = 0 Then

            MessageBox.Show("Falta especificar el Usuario.", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsr.Focus()
            Exit Sub

        Else

            If Len(Trim(txtPwd.Text & "")) = 0 Then

                MessageBox.Show("Falta especificar el Password.", "FALTA INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPwd.Focus()
                Exit Sub

            Else

                Dim cnObj As New MySqlConnection

                Dim strSql As String

                'Valido el usuario

                cnObj = conectar()

                If Not cnObj Is Nothing Then

                    strSql = "SELECT COUNT(*) AS cuantos, "
                    strSql += "(usr_nombre+' '+usr_paterno) AS nombre, "
                    strSql += "usr_id, "
                    strSql += "cambio_password "
                    strSql += "FROM "
                    strSql += "usuario "
                    strSql += "WHERE "
                    strSql += "usr_id = '" & txtUsr.Text & "' AND "
                    strSql += "usr_password = '" & txtPwd.Text & "' AND "
                    strSql += "usr_activo = 1 "
                    strSql += "GROUP BY "
                    strSql += "usr_id, "
                    strSql += "usr_nombre, "
                    strSql += "usr_paterno "



                    Dim cmdUsr As New MySqlCommand(strSql, cnObj)
                    Dim rdrUsr As MySqlDataReader

                    Try

                        rdrUsr = cmdUsr.ExecuteReader()

                        If rdrUsr.Read() Then

                            If CInt(rdrUsr.Item("cuantos")) > 0 Then

                                strUsrId = rdrUsr.Item("usr_id")
                                strUsrNombre = rdrUsr.Item("nombre")
                                CambioPass = rdrUsr.Item("cambio_password")

                            Else

                                MessageBox.Show("El usuario o password son incorrectos.", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                cnObj.Close()
                                Exit Sub

                            End If

                        Else

                            txtUsr.Text = ""
                            txtPwd.Text = ""

                            txtUsr.Focus()

                            MessageBox.Show("El usuario o password son incorrectos.", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cnObj.Close()
                            Exit Sub

                        End If

                        rdrUsr.Close()

                    Catch ex As System.Exception
                        cnObj.Close()
                        MessageBox.Show("Ocurrió el siguiente error: '" & ex.Message & "'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try

                    cnObj.Close()

                Else

                    Exit Sub

                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

            End If

        End If

    End Sub

End Class