Imports System.Data.Odbc

Public Class FormularioUsuario
    Inherits FormularioBase

    Dim sql As String
    Dim rs, rs2 As OdbcDataReader
    Dim idTipo, idEmpleado As Integer

    Private Sub btneditar_Click(sender As System.Object, e As System.EventArgs)

        GestionarUsuarios.Show()
        GestionarUsuarios.Enabled = True
        Me.Close()

    End Sub

    Public Sub cargarTrabajos()

        sql = "select nombre from tipotrabajo"
        rs = Funciones.consulta(sql)
        cmbtrabajo.Items.Clear()
        Do While rs.Read

            cmbtrabajo.Items.Add(rs(0))

        Loop
    End Sub

    Private Sub enableChanged_Click(sender As System.Object, e As System.EventArgs) Handles Me.EnabledChanged
        cargarTrabajos()
    End Sub
    Private Sub FormularioUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarTrabajos()
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        FormularioTipoTrabajo.pantallaAnterior = Me
        FormularioTipoTrabajo.Show()
        FormularioTipoTrabajo.lblerror.Text = ""
        FormularioTipoTrabajo.lblerror2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If txtape.Text <> "" Or txtmail.Text <> "" Or txtnom.Text <> "" Or txtdni.Text <> "" Or cmbtrabajo.Text <> "" Then

            sql = "select idTipo from tipotrabajo where nombre = '" & cmbtrabajo.Text & "'"

            rs = Funciones.consulta(sql)

            If rs.Read Then

                idTipo = rs(0)

            End If

            sql = "select count(*) from empleados where dni = '" & txtdni.Text & "'"
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 0 Then

                    sql = "insert into empleado values ('', '" & txtdni.Text & "', '" & txtnom.Text & "', '" & txtape.Text & "','" & txtmail.Text & "', " & idTipo & ", 'Activo')"
                    Funciones.consulta(sql)

                    sql = "select idEmpleado from empleado where dni = ' " & txtdni.Text & "'"
                    rs2 = Funciones.consulta(sql)

                    If rs2.Read Then

                        idEmpleado = rs2(0)

                    End If

                    sql = "insert into usuarios values ('', " & idEmpleado & ",  )"
                Else

                    lblerror.Text = "Ya existe otro empleado con ese dni."

                End If


            End If

        Else

            lblerror.Text = "Hay campos vacios."


        End If

    End Sub
End Class