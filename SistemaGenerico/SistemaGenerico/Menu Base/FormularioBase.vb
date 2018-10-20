Public Class FormularioBase

    Public pantallaAnterior As Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        pantallaAnterior.Enabled = True
    End Sub

    Private Sub FormularioBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_minimizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        pantallaAnterior.Show()
        pantallaAnterior.Enabled = True
        Me.Hide()




    End Sub
End Class