Public Class Lista

    Dim form As Form

    Private Sub btn_minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub cargarLista(ByVal query As String, ByVal fromForm As Form, ByVal nombre As String)
        lblTitulo.Text = "Lista de " & nombre
        dgvGrilla.DataSource = Funciones.llenarGrilla(query)
        form = fromForm
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        form.Enabled = True
    End Sub
End Class