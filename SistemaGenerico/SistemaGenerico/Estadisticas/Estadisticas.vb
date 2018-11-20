Public Class Estadisticas
    Inherits MenuBase

    Dim sql As String
    Private Sub Estadisticas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Estadisticas"
        logo()
        cargarEstadisticas()

    End Sub

    Public Sub cargarEstadisticas()

        sql = "select c.nombre Nombre , c.apellido Apellido, count(v.idCliente) Cantidad, sum(montoTotal) Concepto from Clientes c, ventas v where (c.idCliente=v.idCliente) group by c.nombre order by Concepto desc"
        Funciones.llenarGrilla(sql, dgvGrilla)

        sql = "select p.nombre Nombre, count(c.idProveedor) Cantidad, sum(montoTotal) Concepto from proveedores p, compras c where (c.idProveedor=p.idProveedor) group by p.nombre order by Concepto desc"
        Funciones.llenarGrilla(sql, dgvGrilla2)

        sql = "select p.descripcion Descripcion, p.stock Stock , count(dv.cantidad) Vendidos from Productos p ,  detalleventas dv where (p.idProducto=dv.idProducto)  group by dv.idProducto order by Vendidos desc"
        Funciones.llenarGrilla(sql, dgvGrilla3)

        sql = "select p.descripcion Descripcion, p.stock Stock , count(dv.cantidad) Comprados from Productos p ,  detallecompras dv where (p.idProducto=dv.idProducto)  group by dv.idProducto order by Comprados desc"
        Funciones.llenarGrilla(sql, dgvGrilla4)

    End Sub

End Class