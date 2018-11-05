Imports System.Data.Odbc

Public Class GenerarCompra
    Inherits MenuBase

    Dim sql As String
    Dim rs As OdbcDataReader
    Dim idProveedor, idProd, cantidad As Integer
    Dim descripcion As String


    Private Sub GenerarCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Generar Compra"
        rdbPendiente.Checked = True

        sql = "select Nombre from Proveedores where estado = 'Activo'"
        rs = Funciones.consulta(sql)

        Do While rs.Read
            cboProveedores.Items.Add(rs(0))
        Loop

    End Sub

    Private Sub btnSumarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumarCant.Click
        If txtCant.Text < 999 Then
            txtCant.Text = txtCant.Text + 1
        End If
    End Sub

    Private Sub btnRestaCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestarCant.Click
        If txtCant.Text > 1 Then
            txtCant.Text = txtCant.Text - 1
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCant.KeyPress
        onlyNum(e)
    End Sub

    Private Sub txtCant_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCant.TextChanged
        If txtCant.Text = "" Or txtCant.Text = "0" Or txtCant.Text = "00" Or txtCant.Text = "000" Then
            txtCant.Text = "1"
        End If
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedores.SelectedIndexChanged
        dgvProductos.Rows.Clear()
        sql = "select p.idProducto ID, Descripcion, Stock, pr.idproveedor from productoproveedor pp, productos p, proveedores pr where pp.idProveedor = pr.idProveedor and p.idproducto = pp.idproducto and pr.nombre = '" & cboProveedores.Text & "'"
        rs = Funciones.consulta(sql)
        Do While rs.Read
            dgvProductos.Rows.Add(rs(0), rs(1), rs(2))
            idProveedor = rs(3)
        Loop

    End Sub

    Private Sub btnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProducto.Click
        If idProd <> 0 Then
            dgvProductosCompra.Rows.Add(idProd, descripcion, txtCant.Text)
            dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows(0).Index)
            If dgvProductos.Rows.Count > 0 Then
                dgvProductos.Rows(dgvProductos.SelectedRows(0).Index).Selected = False
                dgvProductosCompra.Rows(dgvProductosCompra.Rows.Count - 1).Selected = False
            End If
            txtCant.Text = "1"
        Else
            MsgBox("Seleccione un Producto", MsgBoxStyle.Critical)
        End If
        idProd = 0
    End Sub

    Private Sub btnRemoverProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverProducto.Click
        If idProd <> 0 Then
            dgvProductosCompra.Rows.RemoveAt(dgvProductosCompra.SelectedRows(0).Index)

            sql = "select idProducto ID, Descripcion, Stock from productos where idProducto = " & idProd & ""
            rs = Funciones.consulta(sql)
            If rs.Read Then
                dgvProductos.Rows.Add(rs(0), rs(1), rs(2))
            End If
            If dgvProductosCompra.Rows.Count > 0 Then
                dgvProductosCompra.Rows(dgvProductosCompra.SelectedRows(0).Index).Selected = False
                dgvProductos.Rows(dgvProductos.Rows.Count - 1).Selected = False
            End If

        Else
            MsgBox("Seleccione un Producto", MsgBoxStyle.Critical)
        End If
        idProd = 0
    End Sub

    Private Sub dgvProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Try
            idProd = dgvProductos.Rows(e.RowIndex).Cells(0).Value.ToString
            descripcion = dgvProductos.Rows(e.RowIndex).Cells(1).Value.ToString
            cantidad = dgvProductos.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvProductosCompra_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductosCompra.CellClick
        Try
            idProd = dgvProductosCompra.Rows(e.RowIndex).Cells(0).Value.ToString
            descripcion = dgvProductosCompra.Rows(e.RowIndex).Cells(1).Value.ToString
            cantidad = dgvProductosCompra.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If txtMonto.Text = 0 Then
            MsgBox("Debe completar el monto de la compra", MsgBoxStyle.Critical)
        ElseIf dgvProductosCompra.Rows.Count = 0 Then
            MsgBox("Debe haber al menos 1 producto para efectuar la compra", MsgBoxStyle.Critical)
        Else

            Dim estado As String = IIf(rdbFinalizada.Checked, "Finalizada", "Pendiente")

            sql = "insert into compras values ('', " & idProveedor & ", 'Compra de Productos', '" & DateTime.Now.ToString("yyyy/MM/dd") & "', " & txtMonto.Text & ", '" & estado & "')"
            Funciones.consulta(sql)

            sql = "select max(idCompra) from compras"
            rs = Funciones.consulta(sql)
            Dim idCompra As Integer
            If rs.Read Then
                idCompra = rs(0)
            End If

            For Each producto As DataGridViewRow In dgvProductosCompra.Rows
                sql = "insert into detallecompras values ('', " & idCompra & ", " & producto.Cells(0).Value.ToString & ", " & producto.Cells(2).Value.ToString & ")"
                Funciones.consulta(sql)
            Next

        End If
    End Sub
End Class