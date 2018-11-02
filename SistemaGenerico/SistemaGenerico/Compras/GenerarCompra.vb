Public Class GenerarCompra
    Inherits MenuBase

    Private Sub btnSumarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumarCant.Click
        If txtCant.Text < 999 Then
            txtCant.Text = txtCant.Text + 1
        End If
    End Sub

    Private Sub btnRestaCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestarCant.Click
        If txtCant.Text > 1 Then
            txtCant.Text = txtCant.Text - 1
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCant.KeyPress
        onlyNum(e)
    End Sub

    Private Sub txtCant_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCant.TextChanged
        If txtCant.Text = "" Or txtCant.Text = "0" Or txtCant.Text = "00" Or txtCant.Text = "000" Then
            txtCant.Text = "1"
        End If
    End Sub
End Class