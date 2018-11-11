Imports System.Data.Odbc

Public Class PanelUsuario
    Inherits SistemaGenerico.MenuBase
    Dim rs, rs1 As OdbcDataReader
    Dim sql, pass As String

    Private Sub cargarData()
        sql = ("select e.nombre, e.apellido, e.mail, tt.nombre, e.dni from empleados e, tipotrabajo tt , usuarios u where e.idTipo  = tt.idTipo and  e.idempleado = u.idempleado and idusuario = " & Utilidades.idUsuario)
        rs = Funciones.consulta(sql)

        If rs.Read Then

            lblnombre.Text = rs(0)
            lblapellido.Text = rs(1)
            lblmail.Text = rs(2)
            lbltrabajo.Text = rs(3)
            lbldni.Text = rs(4)
            txtnombre.Text = rs(0)
            txtape.Text = rs(1)
            txtmail.Text = rs(2)
            txtdni.Text = rs(4)

            If Not (rs(0) + rs(1)).Equals(Utilidades.nombreUsuario) Then
                Utilidades.nombreUsuario = rs(0) + " " + rs(1)
            End If

        End If
    End Sub

    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Panel de Usuario"
        logo()


        cargarData()

    End Sub

    Private Sub lblTitulo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click

        btneditar.Visible = False
        btndescartar.Visible = True
        btncambios.Visible = True
        txtape.Visible = True
        txtnombre.Visible = True
        txtmail.Visible = True
        txtdni.Visible = True

        sql = "select dni from usuarios u , empleados e where idUsuario = " & Utilidades.idUsuario & " and u.idempleado = e.idempleado"
        rs = Funciones.consulta(sql)



        If rs.Read = True Then

            If rs(0) = "" Then

                txtape.Enabled = False
                txtdni.Enabled = False
                txtmail.Enabled = False

            End If

        End If

    End Sub

    Private Sub btncambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambios.Click

        sql = "select dni, e.idempleado, e.nombre from usuarios u , empleados e where idUsuario = " & Utilidades.idUsuario & " and u.idempleado = e.idempleado"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then

            If rs(0) = "" Then
                If txtnombre.Text <> "" Then

                    sql = "select count(*) from usuarios where usuario = '" & txtnombre.Text & "'"
                    rs1 = Funciones.consulta(sql)
                    If rs1.Read = True Then

                        If rs1(0) > 0 Then

                            lblerror.Text = "Ya existe otro usuario con ese nombre"
                            imgError.Visible = True

                        Else
                            sql = "update empleados set  nombre = '" & txtnombre.Text & "' where idempleado = (select idempleado from usuarios where idusuario = " & Utilidades.idUsuario & ")"

                            Funciones.consulta(sql)


                            sql = "update usuarios set usuario = '" & txtnombre.Text & "' where idEmpleado = " & rs(1)
                            Funciones.consulta(sql)


                            cargarData()
                            btndescartar.Visible = False
                            btneditar.Visible = True
                            btncambios.Visible = False
                            txtape.Visible = False
                            txtnombre.Visible = False
                            txtmail.Visible = False
                            txtdni.Visible = False

                            lblerror.Text = ""
                            lblerror2.Text = ""
                            imgError.Visible = False
                            imgError2.Visible = False

                        End If

                    End If

                Else
                    lblerror.Text = "Hay campos vacios."
                    imgError.Visible = True

                End If

            Else
                If txtape.Text <> "" And txtmail.Text <> "" And txtnombre.Text <> "" And txtdni.Text <> "" Then

                    sql = "select count(*) from empleados where dni = '" & txtdni.Text & "' and idempleado != " & rs(1)
                    rs1 = Funciones.consulta(sql)
                    If rs1.Read = True Then

                        If rs1(0) > 0 Then

                            lblerror.Text = "Ya existe otro usuario con ese dni"
                            imgError.Visible = True

                        Else

                            sql = "update empleados set mail = '" & txtmail.Text & "', nombre = '" & txtnombre.Text & "', dni = '" & txtdni.Text & "', apellido = '" & txtape.Text & "' where idempleado = (select idempleado from usuarios where idusuario = " & Utilidades.idUsuario & ")"
                            Funciones.consulta(sql)

                            sql = "update usuarios set usuario = '" & txtdni.Text & "' where idEmpleado = " & rs(1)
                            Funciones.consulta(sql)

                            cargarData()
                            btndescartar.Visible = False
                            btneditar.Visible = True
                            btncambios.Visible = False
                            txtape.Visible = False
                            txtnombre.Visible = False
                            txtmail.Visible = False
                            txtdni.Visible = False

                            lblerror.Text = ""
                            lblerror2.Text = ""
                            imgError.Visible = False
                            imgError2.Visible = False
                        End If
                    End If

                Else
                    lblerror.Text = "Hay campos vacios."
                    imgError.Visible = True

                End If


                    End If

                End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndescartar.Click


        cargarData()

        btndescartar.Visible = False
        btneditar.Visible = True
        btncambios.Visible = False
        txtape.Visible = False
        txtnombre.Visible = False
        txtmail.Visible = False
        txtdni.Visible = False
        lblerror.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtnuevacontra.Text = "" Or txtnuevacontrarep.Text = "" Or txtviejacontra.Text = "" Then

            lblerror2.Text = ("Llene todos los campos")
            imgError2.Visible = True

        Else

            If txtnuevacontra.Text.Length < 8 Or txtnuevacontrarep.Text.Length < 8 Then

                lblerror2.Text = ("La contraseña tiene que " + vbLf + "tener mas de ocho caracteres")
                imgError2.Visible = True

            Else

                If txtnuevacontra.Text <> txtnuevacontrarep.Text Then

                    lblerror2.Text = ("Los contraseñas no coinciden")
                    imgError2.Visible = True

                Else

                    sql = "select contraseña from usuarios where idUsuario = " & Utilidades.idUsuario

                    rs = Funciones.consulta(sql)

                    If rs.Read = True Then

                        pass = rs(0)

                    End If


                    If pass <> txtviejacontra.Text Then

                        lblerror2.Text = ("La contraseña que ingreso" + vbLf + "no corresponde al usuario")
                        imgError2.Visible = True

                    Else

                        sql = "update usuarios set contraseña = '" & txtnuevacontra.Text & "' where  idUsuario = " & Utilidades.idUsuario
                        Funciones.consulta(sql)

                        txtnuevacontra.Text = ""
                        txtnuevacontrarep.Text = ""
                        txtviejacontra.Text = ""
                        lblerror2.Text = ""

                        lblerror.Text = ""
                        lblerror2.Text = ""
                        imgError.Visible = False
                        imgError2.Visible = False


                    End If


                End If

            End If

        End If

    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If txtnuevacontra.PasswordChar = "•" Then
            txtnuevacontra.PasswordChar = ""
        Else
            txtnuevacontra.PasswordChar = "•"
        End If

        If txtnuevacontrarep.PasswordChar = "•" Then
            txtnuevacontrarep.PasswordChar = ""
        Else
            txtnuevacontrarep.PasswordChar = "•"
        End If

        If txtviejacontra.PasswordChar = "•" Then
            txtviejacontra.PasswordChar = ""
        Else
            txtviejacontra.PasswordChar = "•"
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles imgError2.Click

    End Sub

    Private Sub lblerror2_Click(sender As System.Object, e As System.EventArgs) Handles lblerror2.Click

    End Sub

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class