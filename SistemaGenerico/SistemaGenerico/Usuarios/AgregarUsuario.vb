Public Class AgregarUsuario
    Inherits FormularioBase

    Private Sub btneditar_Click(sender As System.Object, e As System.EventArgs) Handles btneditar.Click

        GestionarUsuarios.Show()
        GestionarUsuarios.Enabled = True
        Me.Close()
    End Sub
End Class