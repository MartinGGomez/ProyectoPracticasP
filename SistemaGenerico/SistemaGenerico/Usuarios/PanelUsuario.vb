Imports System.Data.Odbc

Public Class PanelUsuario
    Inherits SistemaGenerico.MenuBase
    Dim rs As OdbcDataReader
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

    Private Sub btneditar_Click(sender As System.Object, e As System.EventArgs) Handles btneditar.Click
        btneditar.Visible = False
        btndescartar.Visible = True
        btncambios.Visible = True
        txtape.Visible = True
        txtnombre.Visible = True
        txtmail.Visible = True
        txtdni.Visible = True
    End Sub

    Private Sub btncambios_Click(sender As System.Object, e As System.EventArgs) Handles btncambios.Click

        If txtape.Text <> "" And txtmail.Text <> "" And txtnombre.Text <> "" And txtdni.Text <> "" Then
            MsgBox(txtape.Text)
            sql = "update empleados set mail = '" & txtmail.Text & "', nombre = '" & txtnombre.Text & "', dni = '" & txtdni.Text & "', apellido = '" & txtape.Text & "' where idempleado = (select idempleado from usuarios where idusuario = " & Utilidades.idUsuario & ")"
            MsgBox(sql)
            Funciones.consulta(sql)

            cargarData()
            btndescartar.Visible = False
            btneditar.Visible = True
            btncambios.Visible = False
            txtape.Visible = False
            txtnombre.Visible = False
            txtmail.Visible = False
            txtdni.Visible = False



        Else
            lblerror.Text = "Hay campos vacios."

        End If

    End Sub

    Private Sub txtdni_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdni.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btndescartar.Click

        cargarData()

        btndescartar.Visible = False
        btneditar.Visible = True
        btncambios.Visible = False
        txtape.Visible = False
        txtnombre.Visible = False
        txtmail.Visible = False
        txtdni.Visible = False

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If txtnuevacontra.Text = "" Or txtnuevacontrarep.Text = "" Or txtviejacontra.Text = "" Then

            lblerror2.Text = ("Llene todos los campos")

        Else

            If txtnuevacontra.Text.Length < 8 Or txtnuevacontrarep.Text.Length < 8 Then

                lblerror2.Text = ("La contraseña tiene que " + vbLf + "tener mas de ocho caracteres")

            Else

                If txtnuevacontra.Text <> txtnuevacontrarep.Text Then

                    lblerror2.Text = ("Los contraseñas no coinciden")

                Else

                    sql = "select contraseña from usuarios where idUsuario = " & Utilidades.idUsuario

                    rs = Funciones.consulta(sql)

                    If rs.Read = True Then

                        Pass = rs(0)

                    End If


                    If pass <> txtviejacontra.Text Then

                        lblerror2.Text = ("La contraseña que ingreso" + vbLf + "no corresponde al usuario")

                    Else

                        sql = "update usuarios set contraseña = '" & txtnuevacontra.Text & "' where  idUsuario = " & Utilidades.idUsuario
                        Funciones.consulta(sql)

                        txtnuevacontra.Text = ""
                        txtnuevacontrarep.Text = ""
                        txtviejacontra.Text = ""
                        lblerror2.Text = ""


                    End If


                End If

            End If

        End If

    End Sub

    Private Sub btnver_Click(sender As System.Object, e As System.EventArgs) Handles btnver.Click
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
End Class