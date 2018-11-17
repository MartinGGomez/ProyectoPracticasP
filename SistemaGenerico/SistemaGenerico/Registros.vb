Public Class Registros
    Inherits MenuBase
    Dim sql As String
    Dim rs, rs2, rs3 As Odbc.OdbcDataReader

    Private Sub Registros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logo()
        sql = "select count(*) from ventas"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Ventas")
            End If
        End If

        sql = "select count(*) from compras"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Compras")
            End If
        End If

        sql = "select count(*) from Clientes"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Clientes")
            End If
        End If
        sql = "select count(*) from Productos"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Productos")
            End If
        End If
        sql = "select count(*) from Proveedores"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Proveedores")
            End If
        End If

        sql = "select count(*) from ProductoProveedor"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("ProductosProveedor")
            End If
        End If

        sql = "select count(*) from Usuarios"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Usuarios")
            End If
        End If

        sql = "select count(*) from Empleados"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("Empleados")
            End If
        End If

        sql = "select count(*) from TipoTrabajo"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("TipoTrabajo")
            End If
        End If
        sql = "select count(*) from DetalleVentas"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("DetalleVentas")
            End If
        End If
        sql = "select count(*) from DetalleCompras"
        rs = Funciones.consulta(sql)

        If rs.Read = True Then
            If rs(0) > 0 Then
                cboRegistros.Items.Add("DetalleCompras")
            End If
        End If
    End Sub

    Private Sub cboRegistros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegistros.SelectedIndexChanged



        Dim seleccion As String = ""

        seleccion = cboRegistros.Text

        If seleccion.Equals("Ventas") Then
            sql = "select * from ventas"
            lblRegistros.Text = "Registro de Ventas"

        ElseIf seleccion.Equals("Compras") Then
            sql = "select * from compras"
            lblRegistros.Text = "Registro de Compras"

        ElseIf seleccion.Equals("Usuarios") Then
            sql = "select * from usuarios"
            lblRegistros.Text = "Registro de Usuarios"

        ElseIf seleccion.Equals("Clientes") Then
            sql = "select * from clientes"
            lblRegistros.Text = "Registro de Clientes"

        ElseIf seleccion.Equals("Empleados") Then
            sql = "select * from empleados"
            lblRegistros.Text = "Registro de Empleados"

        ElseIf seleccion.Equals("Proveedores") Then
            sql = "select * from Proveedores"
            lblRegistros.Text = "Registro de Proveedores"

        ElseIf seleccion.Equals("Productos") Then
            sql = "select * from Productos"
            lblRegistros.Text = "Registro de Productos"

        ElseIf seleccion.Equals("ProductosProveedor") Then
            sql = "select * from ProductoProveedor"
            lblRegistros.Text = "Registro de Productos del Proveedor"

        ElseIf seleccion.Equals("TipoTrabajo") Then
            sql = "select * from TipoTrabajo"
            lblRegistros.Text = "Registro de Tipos de Trabajo"

        ElseIf seleccion.Equals("DetalleCompras") Then
            sql = "select * from DetalleCompras"
            lblRegistros.Text = "Registro de Detalle de Compras"

        ElseIf seleccion.Equals("DetalleVentas") Then
            sql = "select * from DetalleVentas"
            lblRegistros.Text = "Registro de Detalles de Ventas"
        End If

        Funciones.llenarGrilla(sql, dgvGrilla)
    End Sub

   
End Class