Imports System.Data.Odbc

Public Class FormularioProducto
    Inherits SistemaGenerico.FormularioBase

    Public editar As Boolean
    Public idProducto As Integer
    Dim sql As String
    Dim rs As OdbcDataReader
    Dim proveedores As ArrayList = New ArrayList
    Dim provSeleccionados As ArrayList = New ArrayList
    Dim primeraVez As Boolean = True

    Private Sub FormularioProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If editar Then
            lblTitulo.Text = "Editar Producto"
        Else
            lblTitulo.Text = "Cargar Producto"
        End If
    End Sub

    Public Sub cargarDatos()
        lblError.Text = ""
        If editar Then
            btnEditar.Visible = True
            btnAgregar.Visible = False
            sql = "select descripcion, stock, precio, puntopedido from productos where idProducto = " & idProducto & ""
            rs = Funciones.consulta(sql)
            If rs.Read Then
                txtDescripcion.Text = rs(0)
                txtStock.Text = rs(1)
                txtPrecio.Text = rs(2)
                txtPuntoP.Text = rs(3)
            End If
        Else
            btnEditar.Visible = False
            btnAgregar.Visible = True
            txtDescripcion.Clear()
            txtStock.Clear()
            txtPrecio.Clear()
            txtPuntoP.Clear()
            proveedores = New ArrayList
            provSeleccionados = New ArrayList
            lstProveedores.Items.Clear()
        End If
        cargarProveedores()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtDescripcion.Text = "" Or txtStock.Text = "" Or txtPrecio.Text = "" Or lstProveedores.Items.Count = 0 Then
            lblError.Text = "Hay campos vacios. Completar Campos."

        Else
            lblError.Text = ""
            sql = "insert into productos values ('', '" & txtDescripcion.Text & "', " & txtStock.Text & ", " & txtPuntoP.Text & "," & txtPrecio.Text & ", 'Activo')"
            Funciones.consulta(sql)

            sql = "select max(idproducto) from productos"
            rs = Funciones.consulta(sql)
            Dim id As Integer
            If rs.Read Then
                id = rs(0)

                For Each proveedor As Integer In provSeleccionados
                    sql = "insert into productoproveedor values (" & id & ", " & proveedor & ")"
                    Funciones.consulta(sql)
                Next

                Me.Close()
                Productos.cargarProductos()
                Productos.Enabled = True

            End If

        End If
    End Sub

    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Productos.Enabled = True
        Productos.Show()
        Me.Close()
    End Sub

    Public Sub cargarProveedores()
        cboProveedores.Items.Clear()
        If editar Then
            If primeraVez Then
                sql = "select idProveedor, nombre from proveedores where estado ='Activo' and idproveedor not in (select idproveedor from productoproveedor where idproducto = " & idProducto & ")"
                rs = Funciones.consulta(sql)

                Do While rs.Read
                    If Not provSeleccionados.Contains(rs(0)) Then
                        cboProveedores.Items.Add(rs(1))
                        proveedores.Add(rs(0))
                    End If
                Loop
            Else
                sql = "select idproveedor, nombre from proveedores where estado = 'Activo'"
                rs = Funciones.consulta(sql)
                Do While rs.Read
                    If Not provSeleccionados.Contains(rs(0)) Then
                        cboProveedores.Items.Add(rs(1))
                        proveedores.Add(rs(0))
                    End If
                Loop

            End If
            lstProveedores.Items.Clear()
            If primeraVez Then
                sql = "select p.idProveedor, nombre from proveedores p, productoproveedor pp where estado ='Activo' and p.idproveedor = pp.idproveedor and idProducto = " & idProducto & ""
                rs = Funciones.consulta(sql)
                lstProveedores.Items.Clear()
                Do While rs.Read
                    lstProveedores.Items.Add(rs(1))
                    provSeleccionados.Add(rs(0))
                Loop
            Else
                For Each p As Integer In provSeleccionados
                    sql = "select nombre from proveedores where idproveedor = " & p & ""
                    rs = Funciones.consulta(sql)
                    If rs.Read Then
                        lstProveedores.Items.Add(rs(0))
                    End If
                Next
            End If

        Else

            sql = "select idProveedor, nombre from proveedores where estado ='Activo'"
            rs = Funciones.consulta(sql)

            Do While rs.Read
                If Not provSeleccionados.Contains(rs(0)) Then
                    cboProveedores.Items.Add(rs(1))
                    proveedores.Add(rs(0))
                End If
            Loop
        End If


    End Sub

    Private Sub btnAgregarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarP.Click
        If cboProveedores.Text <> "" Then

            If Not editar Then

            lstProveedores.Items.Add(cboProveedores.Text)

            sql = "select idproveedor from proveedores where nombre = '" & cboProveedores.Text & "'"
            rs = Funciones.consulta(sql)
            If rs.Read Then
                provSeleccionados.Add(rs(0))
                End If
            Else
                primeraVez = False
                lstProveedores.Items.Add(cboProveedores.Text)

                sql = "select idproveedor from proveedores where nombre = '" & cboProveedores.Text & "'"
                rs = Funciones.consulta(sql)
                If rs.Read Then
                    If Not provSeleccionados.Contains(rs(0)) Then
                        provSeleccionados.Add(rs(0))
                    End If
                End If
            End If

        Else
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Critical)

        End If
        cargarProveedores()
    End Sub

    Private Sub btnRemoverP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverP.Click
        If Not lstProveedores.SelectedItem = Nothing Then
            If editar Then
                primeraVez = False
                sql = "select idproveedor from proveedores where nombre = '" & lstProveedores.SelectedItem & "'"
                rs = Funciones.consulta(sql)
                If rs.Read Then
                    provSeleccionados.Remove(rs(0))
                    lstProveedores.Items.Remove(lstProveedores.SelectedItem)
                End If
            Else

                provSeleccionados.RemoveAt(lstProveedores.SelectedIndex)
                lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)

            End If

        Else
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Critical)
        End If
        cargarProveedores()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If txtDescripcion.Text = "" Or txtStock.Text = "" Or txtPrecio.Text = "" Or txtPuntoP.Text = "" Or lstProveedores.Items.Count = 0 Then
            lblError.Text = "Hay campos vacios. Completar Campos."

        Else
            lblError.Text = ""
            sql = "update productos set descripcion = '" & txtDescripcion.Text & "', stock = " & txtStock.Text & ", puntopedido = " & txtPuntoP.Text & ", precio = " & txtPrecio.Text & " where idproducto = " & idProducto & " "
            Funciones.consulta(sql)

            sql = "delete from productoproveedor where idproducto = " & idProducto & ""
            Funciones.consulta(sql)
            For Each proveedor As Integer In provSeleccionados
                sql = "insert into productoproveedor values (" & idProducto & ", " & proveedor & ")"
                Funciones.consulta(sql)
            Next

            Me.Close()
            Productos.cargarProductos()
            Productos.Show()
            Productos.Enabled = True

        End If

    End Sub

    Private Sub btnVerProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProveedores.Click
        Lista.cargarDatos("select idProveedor ID, Nombre, Telefono, Mail, Direccion from proveedores where estado='Activo'", "Proveedores", Me)
        Lista.Show()
        Me.Enabled = False
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not IsNumeric(txtPrecio.Text) And txtPrecio.Text <> "" Then
            ErrorProvider.SetError(txtPrecio, "Solo pueden ser datos numericos.")
            btnAgregar.Enabled = False
        Else
            ErrorProvider.SetError(txtPrecio, "")
            If IsNumeric(txtStock.Text) And IsNumeric(txtPuntoP.Text) Then
                btnAgregar.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged
        If Not IsNumeric(txtStock.Text) And txtStock.Text <> "" Then
            ErrorProvider.SetError(txtStock, "Solo pueden ser datos numericos.")
            btnAgregar.Enabled = False
        Else
            ErrorProvider.SetError(txtStock, "")
            If IsNumeric(txtPrecio.Text) And IsNumeric(txtPuntoP.Text) Then
                btnAgregar.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtPuntoP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPuntoP.TextChanged
        If Not IsNumeric(txtStock.Text) And txtStock.Text <> "" Then
            ErrorProvider.SetError(txtPuntoP, "Solo pueden ser datos numericos.")
            btnAgregar.Enabled = False
        Else
            'Ver si se puede poner en funcion'
            ErrorProvider.SetError(txtStock, "")
            If IsNumeric(txtPrecio.Text) And IsNumeric(txtStock.Text) Then
                btnAgregar.Enabled = True
            End If
        End If
    End Sub
End Class