Imports System.IO

Public Class InicioSesion

    Private Sub img_logo_Click(sender As System.Object, e As System.EventArgs) Handles img_logo.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        Inicio.Show()
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

    Private Sub InicioSesion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If File.Exists(Utilidades.pathLogo) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

        End If
    End Sub
End Class