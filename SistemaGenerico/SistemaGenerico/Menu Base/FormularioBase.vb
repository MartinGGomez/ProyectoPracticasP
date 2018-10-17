Public Class FormularioBase

    Public pantallaAnterior As Form

    Private Sub btn_minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        pantallaAnterior.Enabled = True
    End Sub

    Private Sub FormularioBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_minimizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimizar.Click

    End Sub
End Class