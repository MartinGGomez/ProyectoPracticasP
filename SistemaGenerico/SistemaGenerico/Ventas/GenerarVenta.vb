Imports System.Data.Odbc
Public Class GenerarVenta
    Inherits MenuBase

    Dim rs As OdbcDataReader
    Dim sql, descripcion As String
    Dim idP, id2, monto, precio, cantidad As Integer
    Public total As Integer
    Dim idCliente As Integer
    Dim idVenta As Integer
    Dim idDetalle As Integer


    Private Sub GenerarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarClientes()
        ' cargarProductos()



    End Sub
    Public Sub cargarClientes()
        sql = "select idCliente, nombre, apellido from clientes where estado = 'Activo' "
        rs = Funciones.consulta(sql)

        Do While rs.Read
            txtClientes.AutoCompleteCustomSource.Add(rs(1) & " " & rs(2))
        Loop

    End Sub

    Public Sub cargarProductos()

        sql = "select idProducto ID, Descripcion, Stock, Precio from Productos where estado = 'Activo'"
        rs = Funciones.consulta(sql)

        While rs.Read = True
            dgvGrilla.Rows.Add(rs(0), rs(1), rs(2), rs(3))
        End While



    End Sub


    Private Sub dgvGrilla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            idP = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
            descripcion = dgvGrilla.Rows(e.RowIndex).Cells(1).Value.ToString
            precio = dgvGrilla.Rows(e.RowIndex).Cells(3).Value.ToString

            btnIzq.Enabled = False
            btnDer.Enabled = True
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnDer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgvGrilla.Rows.Count = 0 Then

            MsgBox("No hay mas productos para vender", MsgBoxStyle.Exclamation, "ATENCION")
        Else


            If idP = 0 Then

                MsgBox("No hay un producto seleccionado", MsgBoxStyle.Critical, "ATENCION!")

            Else

                dgvGrilla2.Rows.Add(idP, descripcion, txtCant.Text)

                monto = monto + precio * txtCant.Text
                total = total + monto
                txtMontoT.Text = total
                monto = 0


                dgvGrilla.Rows.RemoveAt(dgvGrilla.SelectedRows(0).Index)
                btnDer.Enabled = True
                btnIzq.Enabled = True
                txtCant.Text = 1

            End If
        End If
        idP = 0
    End Sub

    Private Sub dgvGrilla2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            btnDer.Enabled = False
            btnIzq.Enabled = True

            id2 = dgvGrilla2.Rows(e.RowIndex).Cells(0).Value.ToString
            cantidad = dgvGrilla2.Rows(e.RowIndex).Cells(2).Value.ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnIzq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dgvGrilla2.Rows.Count = 0 Then
            MsgBox("No hay Productos Cargados", MsgBoxStyle.Critical, "ATENCION")

        Else

            If id2 = 0 Then
                MsgBox("No selecciono ningun producto", MsgBoxStyle.Critical, "ATENCION")
            Else

                dgvGrilla2.Rows.RemoveAt(dgvGrilla2.SelectedRows(0).Index)

                sql = "select idProducto ID, Descripcion, Stock, Precio from Productos where estado = 'Activo' and idProducto=" & id2
                rs = Funciones.consulta(sql)

                If rs.Read = True Then
                    dgvGrilla.Rows.Add(rs(0), rs(1), rs(2), rs(3))

                    monto = monto + rs(3) * cantidad
                    total = total - monto
                    txtMontoT.Text = total
                    monto = 0

                    If dgvGrilla2.Rows.Count = 0 Then
                        txtMontoT.Text = "0"
                    End If

                End If

            End If

        End If
        id2 = 0

    End Sub

    Private Sub btnSumarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtCant.Text < 999 Then
            txtCant.Text = txtCant.Text + 1
        End If

    End Sub

    Private Sub btnRestarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtCant.Text > 1 Then
            txtCant.Text = txtCant.Text - 1
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        onlyNum(e)
    End Sub

    Private Sub txtCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtCant.Text = "0" Or txtCant.Text = "00" Or txtCant.Text = "000" Or txtCant.Text = "" Then
            txtCant.Text = 1
        End If
    End Sub

    Private Sub txtMontoT_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        onlyNum(e)
    End Sub


    Private Sub txtMontoT_TextChanged(sender As System.Object, e As System.EventArgs)


        If txtMontoT.Text = "" Then
            txtMontoT.Text = 0
        End If

        If CInt(txtMontoT.Text) < 0 Then
            txtMontoT.Text = 0
        End If



    End Sub

    Private Sub btnEditarMonto_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtClientes.Text = "" Then
            MsgBox("Debe completar el cliente de la venta", MsgBoxStyle.Critical)
        ElseIf dgvGrilla2.Rows.Count = 0 Then
            MsgBox("Debe haber al menos 1 producto para efectuar la venta", MsgBoxStyle.Critical)
        Else



            sql = "select idCliente from clientes where nombre = '" & txtClientes.Text & "'"
            rs = consulta(sql)

            If rs.Read = True Then
                idCliente = rs(0)
            End If

            sql = "insert into ventas values ('', " & idCliente & ",  Descripcion , '" & DateTime.Now.ToString("yyyy/MM/dd") & "', " & txtMontoT.Text & ")"
            Funciones.consulta(sql)

            sql = "select max(idVenta) from Ventas"
            rs = Funciones.consulta(sql)

            If rs.Read Then
                idVenta = rs(0)
            End If

            For Each producto As DataGridViewRow In dgvGrilla2.Rows
                sql = "insert into detalleventas values ('', " & idVenta & ", " & producto.Cells(0).Value.ToString & ", " & producto.Cells(2).Value.ToString & ")"
                Funciones.consulta(sql)
            Next

            limpiar()


            Ventas.cargarVentas()
            Ventas.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub limpiar()
        dgvGrilla2.Rows.Clear()
        txtCant.Text = "1"
        dgvGrilla.Rows.Clear()
        txtClientes.Text = ""
    End Sub
End Class