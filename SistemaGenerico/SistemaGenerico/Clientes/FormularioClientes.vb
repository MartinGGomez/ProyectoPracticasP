Public Class FormularioClientes
    Inherits FormularioBase

    Dim sql As String
    Private Sub FormularioClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
        pantallaAnterior = Clientes
    End Sub

    Public Sub limpiarFormularioClientes()

        txtDNICliente.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtMail.Text = ""
        txtNombre.Text = ""
        txtTel.Text = ""
        lblError.Text = ""
        imgError.Visible = False

    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click

        If lblTitulo.Text = "Cargar Cliente" Then
            If txtDNICliente.Text = "" Or txtTel.Text = "" Or txtMail.Text = "" Or txtDireccion.Text = "" Or txtApellido.Text = "" Or txtNombre.Text = "" Then
                lblError.Text = "Hay campos vacios. Completar Campos."
                imgError.Visible = True
            Else

                sql = "insert into clientes values ('', '" & txtDNICliente.Text & "', '" & txtNombre.Text & "', '" & txtApellido.Text & "', '" & txtTel.Text & "',  '" & txtDireccion.Text & "', '" & txtMail.Text & "', 'Activo')"
                Funciones.consulta(Sql)
                Clientes.cargarClientes()
                Me.Close()
                Clientes.Enabled = True
                Clientes.idCliente = 0
                lblError.Text = ""

            End If
        Else

            If txtDNICliente.Text = "" Or txtTel.Text = "" Or txtMail.Text = "" Or txtDireccion.Text = "" Or txtApellido.Text = "" Or txtNombre.Text = "" Then
                lblError.Text = "Hay campos vacios. Completar Campos."
                imgError.Visible = True
            Else
                sql = "update clientes set Nombre = '" & txtNombre.Text & "', TEL = '" & txtTel.Text & "', Mail = '" & txtMail.Text & "', Direccion = '" & txtDireccion.Text & "',  Apellido = '" & txtApellido.Text & "',  DNI = '" & txtDNICliente.Text & "' where idCliente =" & Clientes.idCliente
                consulta(Sql)
                Clientes.cargarClientes()
                Me.Close()
                Clientes.Enabled = True
                Clientes.idCliente = 0
                lblError.Text = ""
            End If


        End If

    End Sub
End Class