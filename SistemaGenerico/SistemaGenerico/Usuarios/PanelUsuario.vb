Public Class PanelUsuario
    Inherits SistemaGenerico.MenuBase


    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Panel de Usuario"
        logo()
    End Sub

    Private Sub lblTitulo_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btneditar_Click(sender As System.Object, e As System.EventArgs) Handles btneditar.Click
        btneditar.Visible = False
        btncambios.Visible = True
        txtape.Visible = True
        txtnom.Visible = True
        txtmail.Visible = True
    End Sub

    Private Sub btncambios_Click(sender As System.Object, e As System.EventArgs) Handles btncambios.Click
        btneditar.Visible = True
        btncambios.Visible = False
        txtape.Visible = False
        txtnom.Visible = False
        txtmail.Visible = False
    End Sub
End Class