Public Class Proveedores
    Inherits SistemaGenerico.MenuBase
    Dim sql, busqueda As String
    Public idProveedor As Integer
    Dim rs As Odbc.OdbcDataReader

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
        lblTitulo.Text = "Gestionar Proveedores"
        logo()
        btn_proveedores.BackColor = Color.OrangeRed
        cargarProveedores()

    End Sub

    Public Sub cargarProveedores()
        sql = "select idProveedor ID, nombre Nombre_Proveedor, telefono Tel, mail Mail, direccion Direccion from Proveedores where estado = 'Activo'"
        busqueda = Sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and nombre like '%" & txtBuscador.Text & "%' "
            Funciones.llenarGrilla(busqueda, dgvGrilla)
        Else
            Funciones.llenarGrilla(sql, dgvGrilla)
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        FormularioProveedores.pantallaAnterior = Me
        Me.Enabled = False
        FormularioProveedores.Show()
        FormularioProveedores.lblTitulo.Text = "Cargar Proveedor"
        FormularioProveedores.btnAgregar.Text = "AGREGAR PROVEEDOR"

    End Sub


    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        If idProveedor = 0 Then

            MsgBox("Seleccione un proveedor")

        Else


            sql = "select nombre, telefono, mail, direccion from proveedores where idProveedor = " & idProveedor
            rs = consulta(sql)

            If rs.Read = True Then

                FormularioProveedores.txtNombreProv.Text = rs(0)
                FormularioProveedores.txtTel.Text = rs(1)
                FormularioProveedores.txtMail.Text = rs(2)
                FormularioProveedores.txtDireccion.Text = rs(3)

            End If

            Me.Enabled = False
            FormularioProveedores.Show()
            FormularioProveedores.pantallaAnterior = Me
            FormularioProveedores.lblTitulo.Text = "Editar Proveedor"
            FormularioProveedores.btnAgregar.Text = "EDITAR PROVEEDOR"
        End If


    End Sub
    Private Sub txtBuscador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarProveedores()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

        If idProveedor <> 0 Then

            sql = "update proveedores set estado = 'Inactivo' where idProveedor = " & idProveedor
            Funciones.consulta(sql)
            cargarProveedores()

        Else
            MsgBox("Seleccione un proveedor")
        End If




    End Sub

    Private Sub dgvGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellClick

        idProveedor = dgvGrilla.Rows(e.RowIndex).Cells(0).Value.ToString

    End Sub

    
End Class