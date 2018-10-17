Imports System.IO
Imports System.Data.Odbc

Public Class InicioSesion

    Public usuarionombre As String
    Public idusuario As Integer
    Dim rs, rs2, rs3 As OdbcDataReader
    Dim sql As String

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click

        If txtcontraseña.PasswordChar = "•" Then
            txtcontraseña.PasswordChar = ""
        Else
            txtcontraseña.PasswordChar = "•"
        End If
    End Sub

    Public Sub logo()

        If File.Exists(Utilidades.pathLogo) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If txtusuario.Text = "" Or txtcontraseña.Text = "" Then
            lblerror.Text = "Hay campos vacios."
        Else


            sql = ("select count(*) from usuarios where usuario = '" & txtusuario.Text & "' ")
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) > 0 Then

                    sql = ("select count(*), idempleado, idusuario from usuarios where usuario = '" & txtusuario.Text & "' and contraseña = '" & txtcontraseña.Text & "' ")
                    rs2 = Funciones.consulta(sql)

                    If rs2.Read Then

                        If rs2(0) > 0 Then

                            txtusuario.Text = ""
                            txtcontraseña.Text = ""

                            sql = ("select e.nombre, e.apellido, tt.nombre from empleados e, tipotrabajo tt where e.idTipo  = tt.idTipo  and  e.idempleado = " & rs2(1))

                            rs3 = Funciones.consulta(sql)

                            If rs3.Read Then

                                Utilidades.nombreUsuario = rs3(0) + " " + rs3(1)
                                Utilidades.tipoUsuario = rs3(2)
                                Utilidades.idUsuario = rs2(2)

                            End If

                            Me.Hide()
                            Inicio.Show()
                        Else
                            lblerror.Text = "La contraseña es erronea"
                            txtcontraseña.Text = ""
                        End If

                    End If

                Else

                    lblerror.Text = "El usuario no existe"
                    txtusuario.Text = ""
                    txtcontraseña.Text = ""

                End If

            End If

            End If

    End Sub


    Private Sub btn_minimizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click

        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub InicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(Utilidades.pathLogo) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

        End If

        Funciones.conexion()


    End Sub
End Class