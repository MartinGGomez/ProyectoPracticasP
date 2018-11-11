Imports System.Data.Odbc

Public Class FormularioUsuario
    Inherits FormularioBase

    Dim sql As String
    Dim rs, rs2 As OdbcDataReader
    Public idTipo, idEmpleado As Integer
    Public admin, editar, especial As Boolean
    Public trabajo As String


    Private Sub btneditar_Click(sender As System.Object, e As System.EventArgs)

        GestionarUsuarios.Show()
        GestionarUsuarios.Enabled = True
        Me.Close()

    End Sub

    Public Sub cargarInfo()

        sql = "select nombre, apellido,dni,mail,idTipo from empleados where idEmpleado = " & idEmpleado
        rs = Funciones.consulta(sql)

        If rs.Read Then

            txtape.Text = rs(1)
            txtnom.Text = rs(0)
            txtdni.Text = rs(2)
            txtmail.Text = rs(3)
            idTipo = rs(4)
        End If

        cargarTrabajos()

    End Sub

    Public Sub cargarTrabajos()

        sql = "select nombre from tipotrabajo"
        rs = Funciones.consulta(sql)
        cmbtrabajo.Items.Clear()
        Do While rs.Read

            cmbtrabajo.Items.Add(rs(0))

        Loop

        If idTipo <> 0 Then
            sql = "select nombre from tipotrabajo where idTipo = " & idTipo
            rs = Funciones.consulta(sql)

            If rs.Read Then

                cmbtrabajo.Text = rs(0)
                trabajo = rs(0)
                If trabajo.Equals("Administrador") Then

                    cmbtrabajo.Enabled = False

                End If

            End If

        End If
    End Sub

    Public Sub blanquear()

        txtape.Text = ""
        txtnom.Text = ""
        txtdni.Text = ""
        txtmail.Text = ""
        cmbtrabajo.Text = ""
        lblerror.Text = ""
        cmbtrabajo.Enabled = True
        imgError.Visible = False

    End Sub

    Private Sub enableChanged_Click(sender As System.Object, e As System.EventArgs) Handles Me.EnabledChanged
        cargarTrabajos()
        cmbtrabajo.Text = trabajo
    End Sub

    Private Sub FormularioUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not editar Then
            cargarTrabajos()
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        FormularioTipoTrabajo.pantallaAnterior = Me
        FormularioTipoTrabajo.Show()
        FormularioTipoTrabajo.lblerror.Text = ""
        FormularioTipoTrabajo.lblerror2.Text = ""
        cmbtrabajo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnagregar.Click

        If txtape.Text <> "" And txtmail.Text <> "" And txtnom.Text <> "" And txtdni.Text <> "" And cmbtrabajo.Text <> "" Then

            sql = "select idTipo from tipotrabajo where nombre = '" & cmbtrabajo.Text & "'"

            rs = Funciones.consulta(sql)

            If rs.Read Then

                idTipo = rs(0)

            End If

           
                sql = "select count(*) from empleados where dni = '" & txtdni.Text & "'"
                rs = Funciones.consulta(sql)



            If rs.Read Then

                If rs(0) = 0 Then



                    sql = "insert into empleados values ('', '" & txtdni.Text & "', '" & txtnom.Text & "', '" & txtape.Text & "','" & txtmail.Text & "', " & idTipo & ", 'Activo')"
                    Funciones.consulta(sql)

                    sql = "select idEmpleado from empleados where dni = '" & txtdni.Text & "'"
                    rs2 = Funciones.consulta(sql)

                    If rs2.Read Then
                        idEmpleado = rs2(0)
                    End If

                    If cmbtrabajo.Text.Equals("Administrador") Then
                        admin = True
                    Else
                        admin = False
                    End If

                    sql = "insert into usuarios values ('', " & idEmpleado & ", '" & txtdni.Text & "','12345678'," & admin & " )"
                    Funciones.consulta(sql)

                    blanquear()

                    pantallaAnterior.Enabled = True
                    pantallaAnterior.Show()

                    Me.Close()

                Else

                    lblError.Text = "Ya existe otro empleado con ese dni."
                    imgError.Visible = True

                End If

            End If

        Else

            lblerror.Text = "Hay campos vacios."
            imgError.Visible = True
        End If

    End Sub

    Private Sub btneditar_Click_1(sender As System.Object, e As System.EventArgs) Handles btneditar.Click

        If txtape.Text <> "" And txtmail.Text <> "" And txtnom.Text <> "" And txtdni.Text <> "" And cmbtrabajo.Text <> "" Then

            sql = "select idTipo from tipotrabajo where nombre = '" & cmbtrabajo.Text & "'"

            rs = Funciones.consulta(sql)

            If rs.Read Then

                idTipo = rs(0)

            End If

            sql = "select count(*) from empleados where dni = '" & txtdni.Text & "' and not idEmpleado = " & idEmpleado
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 0 Then

                    sql = "update empleados set nombre = '" & txtnom.Text & "',apellido = '" & txtape.Text & "',mail = '" & txtmail.Text & "',dni = '" & txtdni.Text & "', idTipo = " & idTipo & " where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)


                    If cmbtrabajo.Text.Equals("Administrador") Then
                        sql = "update usuarios set administrador = true where idEmpleado = " & idEmpleado
                        Funciones.consulta(sql)

                    End If

                    sql = "update usuarios set usuario = '" & txtdni.Text & "' where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)

                    blanquear()

                    pantallaAnterior.Enabled = True
                    pantallaAnterior.Show()

                    Me.Close()

                Else

                    lblerror.Text = "Ya existe otro empleado con ese dni."
                    imgError.Visible = True
                End If


            End If

        Else

            lblerror.Text = "Hay campos vacios."
            imgError.Visible = True
        End If

    End Sub

    Private Sub btnagregaresp_Click(sender As System.Object, e As System.EventArgs) Handles btnagregaresp.Click

        If txtnom.Text <> "" And cmbtrabajo.Text <> "" Then

            sql = "select idTipo from tipotrabajo where nombre = '" & cmbtrabajo.Text & "'"

            rs = Funciones.consulta(sql)

            If rs.Read Then

                idTipo = rs(0)

            End If


            sql = "select count(*) from usuarios where usuario = '" & txtnom.Text & "'"
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 0 Then



                    sql = "insert into empleados values ('', '" & txtdni.Text & "', '" & txtnom.Text & "', '" & txtape.Text & "','" & txtmail.Text & "', " & idTipo & ", 'Activo')"
                    Funciones.consulta(sql)

                    sql = "select idEmpleado from empleados where nombre = '" & txtnom.Text & "'"
                    rs2 = Funciones.consulta(sql)

                    If rs2.Read Then
                        idEmpleado = rs2(0)
                    End If

                    If cmbtrabajo.Text.Equals("Administrador") Then
                        admin = True
                    Else
                        admin = False
                    End If

                    sql = "insert into usuarios values ('', " & idEmpleado & ", '" & txtnom.Text & "','12345678'," & admin & " )"
                    Funciones.consulta(sql)

                    especial = False

                    blanquear()

                    pantallaAnterior.Enabled = True
                    pantallaAnterior.Show()

                    Me.Close()

                Else

                    lblerror.Text = "Ya existe otro empleado especial con ese nombre."
                    imgError.Visible = True
                End If

            End If

        Else

            lblerror.Text = "Hay campos vacios."
            imgError.Visible = True
        End If

    End Sub

    Private Sub btneditaresp_Click(sender As System.Object, e As System.EventArgs) Handles btneditaresp.Click
        If txtnom.Text <> "" And cmbtrabajo.Text <> "" Then

            sql = "select idTipo from tipotrabajo where nombre = '" & cmbtrabajo.Text & "'"

            rs = Funciones.consulta(sql)

            If rs.Read Then

                idTipo = rs(0)

            End If

            sql = "select count(*) from usuarios where usuario = '" & txtnom.Text & "' and not idEmpleado = " & idEmpleado
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 0 Then

                    sql = "update empleados set nombre = '" & txtnom.Text & "', idTipo = " & idTipo & " where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)


                    If cmbtrabajo.Text.Equals("Administrador") Then
                        sql = "update usuarios set administrador = true where idEmpleado = '" & idEmpleado & "'"

                        Funciones.consulta(sql)

                    End If

                    sql = "update usuarios set usuario = '" & txtnom.Text & "' where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)

                    pantallaAnterior.Enabled = True
                    pantallaAnterior.Show()

                    blanquear()
                    Me.Close()

                Else

                    lblerror.Text = "Ya existe otro empleado especial con ese nombre."
                    imgError.Visible = True
                End If


            End If

        Else

            lblerror.Text = "Hay campos vacios."
            imgError.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class