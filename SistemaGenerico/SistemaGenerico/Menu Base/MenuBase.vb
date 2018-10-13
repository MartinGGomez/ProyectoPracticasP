Public Class MenuBase

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click

        Application.Exit()

    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inicio.Click

        If Not Me.Equals(Inicio) Then
            Inicio.Show()
            Me.Hide()
       
        End If


    End Sub

    Private Sub btn_minimizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btn_clientes_Click(sender As System.Object, e As System.EventArgs) Handles btn_clientes.Click

        If Not Me.Equals(Clientes) Then
            Clientes.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
        InicioSesion.Show()
    End Sub
End Class
