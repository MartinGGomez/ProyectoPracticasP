Public Class Ventas
    Inherits MenuBase

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logo()
        lblTitulo.Text = "Gestion de Ventas"
    End Sub

    Public Sub cargarVentas()


    End Sub




    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        GenerarVenta.Show()
        GenerarVenta.cargarClientes()
    End Sub
End Class