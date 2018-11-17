Public Class Clientes
    Inherits SistemaGenerico.MenuBase
    Dim sql, busqueda As String
    Public idCliente As Integer
    Dim rs As Odbc.OdbcDataReader

    Private Sub Clientes_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        idCliente = 0
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gestion de los Clientes"
        logo()
        btn_clientes.BackColor = Color.OrangeRed
        cargarClientes()
    End Sub

    Public Sub cargarClientes()
        sql = "select idCliente ID,DNI, Nombre, Apellido, TEL, Direccion, Mail from clientes where estado='Activo'"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and nombre like '%" & txtBuscador.Text & "%' "
            Funciones.llenarGrilla(busqueda, dgvGrilla)
        Else
            Funciones.llenarGrilla(sql, dgvGrilla)
        End If

    End Sub


    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        FormularioClientes.limpiarFormularioClientes()
        FormularioClientes.pantallaAnterior = Me
        Me.Enabled = False
        FormularioClientes.Show()
        FormularioClientes.lblTitulo.Text = "Cargar Cliente"
        FormularioClientes.btnAgregar.Text = "AGREGAR CLIENTE"

    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        If idCliente = 0 Then

            MsgBox("Seleccione un cliente")

        Else


            sql = "select DNI, Nombre, Apellido,  TEL, Direccion,  Mail from clientes where idCliente = " & idCliente
            rs = consulta(sql)

            If rs.Read = True Then

                FormularioClientes.txtDNICliente.Text = rs(0)
                FormularioClientes.txtNombre.Text = rs(1)
                FormularioClientes.txtApellido.Text = rs(2)
                FormularioClientes.txtTel.Text = rs(3)
                FormularioClientes.txtDireccion.Text = rs(4)
                FormularioClientes.txtMail.Text = rs(5)

            End If

            Me.Enabled = False
            FormularioClientes.Show()
            FormularioClientes.pantallaAnterior = Me
            FormularioClientes.lblTitulo.Text = "Editar Cliente"
            FormularioClientes.btnAgregar.Text = "EDITAR CLIENTE"
        End If
    End Sub

    Private Sub txtBuscador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarClientes()

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If idCliente <> 0 Then

            sql = "update clientes set estado = 'Inactivo' where idCliente = " & idCliente
            Funciones.consulta(sql)
            cargarClientes()

        Else
            MsgBox("Seleccione un cliente")
        End If

    End Sub

    Private Sub dgvGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick
        idCliente = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub


End Class