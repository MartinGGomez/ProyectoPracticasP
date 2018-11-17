Imports System.Data.Odbc
Public Class GenerarVenta
    Inherits MenuBase

    Dim rs As OdbcDataReader
    Dim sql, descripcion, busqueda, nombre, apellido As String
    Dim idP, id2, monto, precio, cantidad As Integer
    Public total As Integer
    Dim idCliente As Integer
    Dim idVenta As Integer
    Dim idDetalle As Integer
    Dim existe As Boolean

    Private Sub GenerarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarClientes()
        logo()

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
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            dgvGrilla.Rows.Clear()
            busqueda &= " and descripcion like '%" & txtBuscador.Text & "%' "
            rs = consulta(busqueda)
            While rs.Read = True
                dgvGrilla.Rows.Add(rs(0), rs(1), rs(2), rs(3))
            End While

        Else
            dgvGrilla.Rows.Clear()
            While rs.Read = True
                dgvGrilla.Rows.Add(rs(0), rs(1), rs(2), rs(3))
            End While

        End If

    End Sub

 
    Private Sub dgvGrilla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        Try
            idP = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
            descripcion = dgvGrilla.Rows(e.RowIndex).Cells(1).Value.ToString
            precio = dgvGrilla.Rows(e.RowIndex).Cells(3).Value.ToString

            btnIzq.Enabled = False
            btnDer.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDer.Click
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

    Private Sub dgvGrilla2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla2.CellClick
        Try
            btnDer.Enabled = False
            btnIzq.Enabled = True

            id2 = dgvGrilla2.Rows(e.RowIndex).Cells(0).Value.ToString
            cantidad = dgvGrilla2.Rows(e.RowIndex).Cells(2).Value.ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnIzq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzq.Click
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

    Private Sub btnSumarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumarCant.Click
        If txtCant.Text < 999 Then
            txtCant.Text = txtCant.Text + 1
        End If

    End Sub

    Private Sub btnRestarCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestarCant.Click
        If txtCant.Text > 1 Then
            txtCant.Text = txtCant.Text - 1
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        onlyNum(e)
    End Sub

    Private Sub txtCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCant.TextChanged
        If txtCant.Text = "0" Or txtCant.Text = "00" Or txtCant.Text = "000" Or txtCant.Text = "" Then
            txtCant.Text = 1
        End If
    End Sub

    Private Sub txtMontoT_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoT.KeyPress
        onlyNum(e)
    End Sub

    Private Sub txtMontoT_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMontoT.TextChanged

        If txtMontoT.Text = "" Then
            txtMontoT.Text = 0
        End If

        If CInt(txtMontoT.Text) < 0 Then
            txtMontoT.Text = 0
        End If

    End Sub

    Private Sub btnEditarMonto_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarMonto.Click

        If txtMontoT.Enabled = False Then
            txtMontoT.Enabled = True
        Else
            txtMontoT.Enabled = False
        End If
    End Sub

  
    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If txtClientes.Text = "" Then
            MsgBox("Debe completar el cliente de la venta", MsgBoxStyle.Critical)
        ElseIf dgvGrilla2.Rows.Count = 0 Then
            MsgBox("Debe haber al menos 1 producto para efectuar la venta", MsgBoxStyle.Critical)
        Else

            Dim palabras As Array

            palabras = Split(txtClientes.Text, " ")

            sql = "select idCliente from clientes where nombre = '" & palabras(0) & "' and apellido = '" & palabras(1) & "'"
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

            Ventas.cargarVentas()
            Ventas.Show()
            Me.Hide()
            limpiar()

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtClientes.Text = "" Then
            MsgBox("Debe completar el cliente de la venta", MsgBoxStyle.Critical)
        ElseIf dgvGrilla2.Rows.Count = 0 Then
            MsgBox("Debe haber al menos 1 producto para efectuar la venta", MsgBoxStyle.Critical)
        Else
            Dim palabras As Array

            palabras = Split(txtClientes.Text, " ")

            sql = "select idCliente from clientes where nombre = '" & palabras(0) & "' and apellido = '" & palabras(1) & "'"
            rs = consulta(sql)

            If rs.Read = True Then
                idCliente = rs(0)
            End If

            sql = "update ventas set idCliente= " & idCliente & " , montoTotal = '" & txtMontoT.Text & "' where idVenta=" & Ventas.ip
            consulta(sql)

            sql = "select idDetalleVenta from detalleventas where idVenta=" & Ventas.ip
            rs = consulta(sql)
            If rs.Read = True Then
                idDetalle = rs(0)
            End If

            sql = "delete from detalleventas where idVenta=" & Ventas.ip
            consulta(sql)

            For Each producto As DataGridViewRow In dgvGrilla2.Rows
                sql = "insert into detalleventas values ('', " & Ventas.ip & ", " & producto.Cells(0).Value.ToString & ", " & producto.Cells(2).Value.ToString & ")"
                Funciones.consulta(sql)
            Next

        End If

        Me.Hide()
        Ventas.Show()
        limpiar()
        Ventas.cargarVentas()

    End Sub

    Public Sub limpiar()
        dgvGrilla2.Rows.Clear()
        txtCant.Text = "1"
        dgvGrilla.Rows.Clear()
        txtClientes.Text = ""
        total = 0
        monto = 0
        Ventas.ip = 0
        idDetalle = 0
        txtBuscador.Text = ""
    End Sub

    Private Sub txtBuscador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarProductos()
    End Sub

   
    Private Sub btnAgregarClieEspecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarClieEspecial.Click
        FormularioClientes.lblTitulo.Text = "Cargar Cliente"
        FormularioClientes.Show()
        Me.Enabled = False
        FormularioClientes.pantallaAnterior = Me

    End Sub

    Private Sub txtClientes_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClientes.TextChanged
        Dim palabras As Array
        Try
            palabras = Split(txtClientes.Text, " ")

            sql = "select idCliente from clientes where nombre = '" & txtClientes.Text & "'"
            rs = consulta(sql)

            If rs.Read = True Then
                idCliente = rs(0)
                existe = True
            Else
                existe = False
            End If

            sql = "select idCliente from clientes where nombre = '" & palabras(0) & "' and apellido = '" & palabras(1) & "'"
            rs = consulta(sql)

            If rs.Read = True Then
                idCliente = rs(0)
                existe = True
            Else
                existe = False
                nombre = palabras(0)
                apellido = palabras(1)
            End If

            If existe Then
                btnAgregarClieEspecial.Enabled = False
            Else
                btnAgregarClieEspecial.Enabled = True
            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnDescartarC_Click(sender As System.Object, e As System.EventArgs) Handles btnDescartarC.Click
        Me.Close()
        Ventas.Show()
        limpiar()
        Ventas.cargarVentas()
    End Sub

End Class