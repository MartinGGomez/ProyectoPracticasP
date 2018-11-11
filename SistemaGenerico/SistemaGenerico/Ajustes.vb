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


    Public Sub logoAjustes()

        If File.Exists(Utilidades.pathLogo) Then

            img_logo_ajustes.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

            img_logo_ajustes.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

        End If

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Utilidades.restaurarLogo()
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

                Utilidades.restaurarLogo()

                img_logo_ajustes.BackgroundImage = Image.FromFile(filename)
                img_logo_ajustes.BackgroundImage.Save(pathLogo, System.Drawing.Imaging.ImageFormat.Png)

                Utilidades.refrescarLogo()

            Else
                MsgBox("ARCHIVO INVALIDO")
            End If


        End If
    End Sub

  
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        GestionarUsuarios.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class