Public Class MenuBase

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover

        Button2.BackColor = Color.Black

    End Sub

    Private Sub Button2_Clsick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave


        Button2.BackColor = Color.DodgerBlue



    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clientes.Show()
        Me.Hide()
    End Sub
End Class
