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

        sql = "select p.descripcion Descripcion, p.stock Stock , count(dv.cantidad) Vendidos, (select count(dc.cantidad)   from detallecompras dc, productos p where (p.idProducto=dc.idProducto) group by dc.idProducto) Comprados from Productos p ,  detalleventas dv where (p.idProducto=dv.idProducto)  group by dv.idProducto"
        Funciones.llenarGrilla(sql, dgvGrilla3)



    End Sub

End Class