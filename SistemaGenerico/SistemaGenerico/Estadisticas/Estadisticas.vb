Public Class Estadisticas
    Inherits MenuBase

    Dim sql As String
    Private Sub Estadisticas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Estadisticas"
        logo()
        cargarEstadisticas()

    End Sub

    Public Sub cargarEstadisticas()

        sql = "select c.nombre Nombre , c.apellido Apellido, count(v.idCliente) Cantidad, sum(montoTotal) Concepto from Clientes c, ventas v where (c.idCliente=v.idCliente) order by Cantidad "
        Funciones.llenarGrilla(sql, dgvGrilla)

        sql = "select p.nombre Nombre, count(c.idProveedor) Cantidad, sum(montoTotal) Concepto from proveedores p, compras c where (c.idProveedor=p.idProveedor) "
        Funciones.llenarGrilla(sql, dgvGrilla2)

    End Sub

End Class