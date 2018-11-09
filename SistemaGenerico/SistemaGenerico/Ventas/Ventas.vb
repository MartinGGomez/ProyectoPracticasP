Public Class Ventas
    Inherits MenuBase
    Dim sql, busqueda As String
    Public ip As Integer
    Dim rs, rs2, rs3 As Odbc.OdbcDataReader

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logo()
        lblTitulo.Text = "Gestion de Ventas"
        cargarVentas()
        btnverVentas.Visible = False

    End Sub

    Public Sub cargarVentas()

        sql = "select idVenta ID, c.Nombre, c.Apellido, fecha , montoTotal from clientes c, ventas v  where (c.idCliente=v.idCliente) and estado='Activo'"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and montoTotal like '%" & txtBuscador.Text & "%' "
            Funciones.llenarGrilla(busqueda, dgvGrilla)
        Else
            Funciones.llenarGrilla(sql, dgvGrilla)
        End If

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        GenerarVenta.Show()
        GenerarVenta.cargarClientes()
        GenerarVenta.cargarProductos()
        GenerarVenta.btnConfirmar.Visible = True
        GenerarVenta.btnCancelar.Visible = True
        GenerarVenta.btnDescartarC.Visible = False
        GenerarVenta.btnGuardar.Visible = False
    End Sub

    Private Sub txtBuscador_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.KeyPress
        onlyNum(e)
    End Sub

    Private Sub dgvGrilla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            ip = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalle.Click
        If ip = 0 Then

            MsgBox("Seleccione una venta", MsgBoxStyle.Exclamation, "ATENCION")
        Else

            sql = "select p.descripcion , d.cantidad from detalleventas d , productos p where (p.idProducto=d.idProducto) and idVenta= " & ip
            llenarGrilla(sql, dgvGrilla)

            btnVerDetalle.Visible = False
            btnverVentas.Visible = True

        End If
    End Sub

    Private Sub btnverVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverVentas.Click
        btnVerDetalle.Visible = True
        btnverVentas.Visible = False

        cargarVentas()
        ip = 0

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If ip = 0 Then
            MsgBox("Seleccione una venta", MsgBoxStyle.Exclamation, "ATENCION")
        Else
          

            sql = "delete from detalleventas where idVenta = " & ip
            consulta(sql)

            sql = "delete from ventas where idVenta = " & ip
            consulta(sql)

            cargarVentas()

        End If
        ip = 0
    End Sub

    Private Sub txtEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEditar.Click
        If ip = 0 Then

            MsgBox("Seleccione una venta", MsgBoxStyle.Exclamation, "ATENCION")

        Else
            sql = "select d.idProducto ID, p.Descripcion, d.cantidad from Productos p , detalleventas d  where (p.idProducto=d.idProducto) and idVenta= " & ip
            rs = consulta(sql)

            While rs.Read = True
                GenerarVenta.dgvGrilla2.Rows.Add(rs(0), rs(1), rs(2))
            End While

            sql = "select montoTotal, idCliente from ventas where idVenta =" & ip
            rs = consulta(sql)
            Dim cliente As Integer

            If rs.Read = True Then
                GenerarVenta.txtMontoT.Text = rs(0)
                GenerarVenta.total = rs(0)
                cliente = rs(1)
            End If

            sql = "select nombre, apellido from clientes where idCliente=" & cliente
            rs2 = consulta(sql)

            If rs2.Read = True Then
                GenerarVenta.txtClientes.Text = rs2(0) & " " & rs2(1)
            End If


            sql = "select idProducto ID, Descripcion, Stock, Precio from Productos where idProducto not in (select idProducto from DetalleVentas where idVenta= " & ip & ")"
            rs3 = consulta(sql)

            Do While rs3.Read = True
                GenerarVenta.dgvGrilla.Rows.Add(rs3(0), rs3(1), rs3(2), rs3(3))
            Loop

            GenerarVenta.btnConfirmar.Visible = False
            GenerarVenta.btnCancelar.Visible = False
            GenerarVenta.btnGuardar.Visible = True
            GenerarVenta.btnDescartarC.Visible = True


            Me.Hide()
            GenerarVenta.Show()


        End If
    End Sub

    Private Sub txtBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarVentas()
    End Sub
End Class