Imports System.Data.Odbc

Public Class Productos
    Inherits SistemaGenerico.MenuBase

    Dim sql, busqueda As String
    Dim rs As OdbcDataReader
    Dim idProducto As Integer

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gestion de Productos"
        logo()
        btn_productos.BackColor = Color.Black
    End Sub

    Private Sub txtBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarProductos()
    End Sub

    Public Sub cargarProductos()
        sql = "select idProducto ID, Descripcion, Stock, PuntoPedido PuntoDePedido, Precio from Productos where estado = 'Activo'"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and descripcion like '%" & txtBuscador.Text & "%' "
            Funciones.llenarGrilla(busqueda, dgvGrilla)
        Else
            Funciones.llenarGrilla(sql, dgvGrilla)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.Enabled = False
        FormularioProducto.editar = False
        FormularioProducto.cargarDatos()
        FormularioProducto.pantallaAnterior = Me
        FormularioProducto.Show()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If idProducto <> 0 Then
            FormularioProducto.editar = True
            FormularioProducto.idProducto = idProducto
            FormularioProducto.pantallaAnterior = Me
            FormularioProducto.cargarDatos()
            FormularioProducto.Show()
            Me.Enabled = False
        Else
            MsgBox("Seleccione un producto")
        End If
        idProducto = 0

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If idProducto <> 0 Then

            sql = "update productos set estado = 'Inactivo' where idproducto = " & idProducto & ""
            Funciones.consulta(sql)
        Else
            MsgBox("Seleccione un producto")
        End If
        idProducto = 0

    End Sub

    Private Sub dgvGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            idProducto = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class