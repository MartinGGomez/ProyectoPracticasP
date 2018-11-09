Imports System.Data.Odbc

Public Class Compras
    Inherits MenuBase

    Dim sql, busqueda, estado As String
    Dim rs As OdbcDataReader
    Dim idCompra As Integer


    Public Sub cargarCompras()
        lblTitulo.Text = "Gestion de Compras"
        cargarProveedores()

        sql = "select idCompra ID, nombre Proveedor, Fecha, MontoTotal, c.estado Estado from compras c, proveedores p where c.idproveedor = p.idproveedor"
        busqueda = sql
        If Not String.IsNullOrEmpty(cboProveedores.Text) And cboProveedores.Text <> "Todos" Then
            busqueda &= " and p.nombre like '%" & cboProveedores.Text & "%' order by fecha"
            Funciones.llenarGrilla(busqueda, dgvProveedores)
        Else
            Funciones.llenarGrilla(sql & " order by fecha", dgvProveedores)
        End If
        If dgvProveedores.Rows.Count > 0 Then
            dgvProveedores.Rows(0).Selected = False
        End If


    End Sub

    Private Sub cargarProveedores()
        cboProveedores.Items.Clear()
        cboProveedores.Items.Add("Todos")
        sql = "select Nombre from proveedores where estado = 'Activo'"
        rs = Funciones.consulta(sql)
        Do While rs.Read
            cboProveedores.Items.Add(rs(0))
        Loop
    End Sub

    Private Sub dgvProveedores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        Try
            idCompra = dgvProveedores.Rows(e.RowIndex).Cells(0).Value.ToString
            estado = dgvProveedores.Rows(e.RowIndex).Cells("Estado").Value.ToString
        Catch ex As Exception
        End Try

        If estado = "Finalizada" Then
            btnFinalizar.Enabled = False
            btnEditar.Enabled = False
        Else
            btnFinalizar.Enabled = True
            btnEditar.Enabled = True
        End If

    End Sub

    Private Sub dgvProveedores_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvProveedores.CellToolTipTextNeeded
        e.ToolTipText = "Doble click para ver el detalle"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCompra.Click
        GenerarCompra.Show()
        Me.Close()
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Cargando.mensaje = "Actualizando stock"
        Cargando.iniciarTimer()
        Cargando.pantallaAnterior = Me
        Cargando.Show()


        sql = "select idProducto, cantidad from detallecompras where idcompra = " & idCompra & ""
        rs = Funciones.consulta(sql)

        Do While rs.Read
            sql = "update productos set stock = stock + " & rs(1) & " where idproducto = " & rs(0) & ""
            Funciones.consulta(sql)
        Loop

        sql = "update compras set estado = 'Finalizada' where idcompra = " & idCompra & ""
        Funciones.consulta(sql)

        cargarCompras()
        Me.Enabled = False


    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If idCompra = 0 Then
            MsgBox("Seleccione una compra", MsgBoxStyle.Critical)
        Else
            GenerarCompra.Show()
            GenerarCompra.cargarDatosCompra(idCompra)
            Me.Close()
        End If
        idCompra = 0
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedores.SelectedIndexChanged
        sql = "select idCompra ID, nombre Proveedor, Fecha, MontoTotal, c.estado Estado from compras c, proveedores p where c.idproveedor = p.idproveedor"
        busqueda = sql
        If Not String.IsNullOrEmpty(cboProveedores.Text) And cboProveedores.Text <> "Todos" Then
            busqueda &= " and p.nombre like '%" & cboProveedores.Text & "%' order by fecha"
            Funciones.llenarGrilla(busqueda, dgvProveedores)
        Else
            Funciones.llenarGrilla(sql & " order by fecha", dgvProveedores)
        End If
        If dgvProveedores.Rows.Count > 0 Then
            dgvProveedores.Rows(0).Selected = False
        End If
    End Sub

    Private Sub btnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalle.Click
        If idCompra = 0 Then
            MsgBox("Seleccione una compra", MsgBoxStyle.Critical)
        Else
            DetalleCompra.Show()
            DetalleCompra.cargarDatosCompra(idCompra)
            Me.Close()
        End If
        idCompra = 0
    End Sub
End Class