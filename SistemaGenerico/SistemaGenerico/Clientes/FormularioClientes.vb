Public Class FormularioClientes
    Inherits FormularioBase

    Dim sql As String


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
                Funciones.consulta(sql)
                Clientes.Enabled = True
                Clientes.idCliente = 0
                lblError.Text = ""
                Clientes.cargarClientes()
                Clientes.Show()
                Me.Close()
                
                If (pantallaAnterior.Equals(GenerarVenta)) Then
                    GenerarVenta.cargarClientes()
                    GenerarVenta.Enabled = True
                End If
            End If
        Else

            If txtDNICliente.Text = "" Or txtTel.Text = "" Or txtMail.Text = "" Or txtDireccion.Text = "" Or txtApellido.Text = "" Or txtNombre.Text = "" Then
                lblError.Text = "Hay campos vacios. Completar Campos."
                imgError.Visible = True
            Else
                sql = "update clientes set Nombre = '" & txtNombre.Text & "', TEL = '" & txtTel.Text & "', Mail = '" & txtMail.Text & "', Direccion = '" & txtDireccion.Text & "',  Apellido = '" & txtApellido.Text & "',  DNI = '" & txtDNICliente.Text & "' where idCliente =" & Clientes.idCliente
                consulta(sql)
                Clientes.cargarClientes()
                Clientes.Enabled = True
                Clientes.idCliente = 0
                lblError.Text = ""
                Clientes.Show()
                Me.Close()
              
            End If


        End If

    End Sub
End Class