Public Class Gastos
    Inherits MenuBase

    Private Sub Gastosvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Registro de Gastos"
        logo()
        btn_gastos.BackColor = Color.OrangeRed
    End Sub
End Class