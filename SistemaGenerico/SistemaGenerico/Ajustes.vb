Imports System.IO

Public Class Ajustes
    Inherits SistemaGenerico.MenuBase

    Private Sub Ajustes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Panel de Ajustes"
        logo()

        If File.Exists(Utilidades.pathLogo) Then

            img_logo_ajustes.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

            img_logo_ajustes.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

        End If

    End Sub

    Private Sub reutaurarLogo()

        If File.Exists(Utilidades.pathLogo) Then

            img_logo.BackgroundImage.Dispose()
            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)
            img_logo_ajustes.BackgroundImage.Dispose()
            img_logo_ajustes.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)
            If Inicio.IsDisposed Then
                Inicio.img_logo.BackgroundImage.Dispose()
                Inicio.img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)
            End If
            If Usuario.IsDisposed Then
                Usuario.img_logo.BackgroundImage.Dispose()
                Usuario.img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)
            End If
            If Clientes.IsDisposed Then
                Clientes.img_logo.BackgroundImage.Dispose()
                Clientes.img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)
            End If

            InicioSesion.img_logo.BackgroundImage.Dispose()
            InicioSesion.img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

            File.Delete(Utilidades.pathLogo)

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        reutaurarLogo()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Dim filename As String
        Dim openfiler As New OpenFileDialog
        With openfiler
            .InitialDirectory = "C:\"
            .Filter = "Archivos de imágen(*.jpeg, *.png)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With

        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = openfiler.FileName

            Dim fileInfo As New FileInfo(filename)

            If fileInfo.Extension.EndsWith("jpg") Or fileInfo.Extension.EndsWith("png") Then
                reutaurarLogo()
                img_logo_ajustes.BackgroundImage = Image.FromFile(filename)
                img_logo_ajustes.BackgroundImage.Save(pathLogo, System.Drawing.Imaging.ImageFormat.Png)

                img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)
                InicioSesion.img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

            Else
                MsgBox("ARCHIVO INVALIDO")
            End If


        End If
    End Sub
End Class