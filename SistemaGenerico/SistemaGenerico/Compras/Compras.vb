Imports System.Data.Odbc

Public Class Compras
    Inherits MenuBase

    Dim sql, busqueda As String
    Dim rs As OdbcDataReader


    Public Sub cargarCompras()
        lblTitulo.Text = "Gestion de Compras"
        cargarProveedores()

        sql = "select idCompra ID, nombre Proveedor, Descripcion, Fecha, MontoTotal, c.estado Estado from compras c, proveedores p where c.idproveedor = p.idproveedor"
        busqueda = sql
        If Not String.IsNullOrEmpty(cboProveedores.Text) Then
            busqueda &= " and p.nombre like '%" & cboProveedores.Text & "%' "
            Funciones.llenarGrilla(busqueda, dgvProveedores)
        Else
            Funciones.llenarGrilla(sql, dgvProveedores)
        End If


    End Sub

    Private Sub cargarProveedores()
        sql = "select Nombre from proveedores where estado = 'Activo'"
        rs = Funciones.consulta(sql)
        Do While rs.Read
            cboProveedores.Items.Add(rs(0))
        Loop
    End Sub

    Private Sub dgvProveedores_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvProveedores.CellToolTipTextNeeded
        e.ToolTipText = "Doble click para ver el detalle"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCompra.Click
        GenerarCompra.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Cargando.mensaje = "Actualizando stock"
        Cargando.iniciarTimer()
        Cargando.pantallaAnterior = Me
        Cargando.Show()
        Me.Enabled = False
    End Sub
End Class