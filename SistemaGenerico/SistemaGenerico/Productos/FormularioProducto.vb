Imports System.Data.Odbc

Public Class FormularioProducto
    Inherits SistemaGenerico.FormularioBase

    Public editar As Boolean
    Public idProducto As Integer
    Dim sql As String
    Dim rs As OdbcDataReader
    Dim proveedores As ArrayList = New ArrayList
    Dim provSeleccionados As ArrayList = New ArrayList

    Private Sub FormularioProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If editar Then
            lblTitulo.Text = "Editar Producto"
        Else
            lblTitulo.Text = "Cargar Producto"
        End If
    End Sub

    Public Sub cargarDatos()
        lblError.Text = ""
        sql = "select descripcion, stock, precio from productos where idProducto = " & idProducto & ""
        rs = Funciones.consulta(sql)
        If rs.Read Then
            txtDescripcion.Text = rs(0)
            txtStock.Text = rs(1)
            txtPrecio.Text = rs(2)
        End If
        cargarProveedores()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtDescripcion.Text = "" Or txtStock.Text = "" Or txtPrecio.Text = "" Then
            lblError.Text = "Hay campos vacios. Completar Campos."

        Else
            lblError.Text = ""
            sql = "insert into productos values ('', '" & txtDescripcion.Text & "', " & txtStock.Text & ", " & txtPrecio.Text & ", 'Activo')"
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

    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Productos.Enabled = True
        Productos.Show()
        Me.Close()
    End Sub

    Public Sub cargarProveedores()
        cboProveedores.Items.Clear()
        If editar Then
            sql = "select idProveedor, nombre from proveedores where estado ='Activo' and idproveedor not in (select idproveedor from productoproveedor where idproducto = " & idProducto & ")"
            rs = Funciones.consulta(sql)

            Do While rs.Read
                If Not provSeleccionados.Contains(rs(0)) Then
                    cboProveedores.Items.Add(rs(1))
                    proveedores.Add(rs(0))
                End If
            Loop

            sql = "select p.idProveedor, nombre from proveedores p, productoproveedor pp where estado ='Activo' and p.idproveedor = pp.idproveedor and idProducto = " & idProducto & ""
            rs = Funciones.consulta(sql)
            lstProveedores.Items.Clear()
            Do While rs.Read
                lstProveedores.Items.Add(rs(1))
                provSeleccionados.Add(rs(0))
            Loop
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
            lstProveedores.Items.Add(cboProveedores.Text)

            sql = "select idproveedor from proveedores where nombre = '" & cboProveedores.Text & "'"
            rs = Funciones.consulta(sql)
            If rs.Read Then
                provSeleccionados.Add(rs(0))
            End If

        Else
            MsgBox("Seleccione un proveedor")

        End If
        cargarProveedores()
    End Sub

    Private Sub btnRemoverP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverP.Click
        If editar Then

            If Not lstProveedores.SelectedItem = Nothing Then
                sql = "select idproveedor from proveedores where nombre = '" & lstProveedores.SelectedItem & "'"
                rs = Funciones.consulta(sql)
                If rs.Read Then
                    provSeleccionados.Remove(rs(0))
                    sql = "delete from productoproveedor where idproducto=" & idProducto & " and idproveedor=" & rs(0) & ""
                    Funciones.consulta(sql)
                    lstProveedores.Items.Remove(lstProveedores.SelectedItem)
                End If

            Else
                MsgBox("Seleccione un proveedor")

            End If
        Else

            provSeleccionados.RemoveAt(lstProveedores.SelectedIndex)
            lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)

        End If

        cargarProveedores()
    End Sub

    Private Sub btnVerProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProveedores.Click
        Lista.cargarLista("select idProveedor ID, Nombre, Telefono, Mail, Direccion from proveedores where estado='Activo'", Me, "Proveedores")
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
            ErrorProvider.SetError(txtStock, "")
            If IsNumeric(txtPrecio.Text) And IsNumeric(txtStock.Text) Then
                btnAgregar.Enabled = True
            End If
        End If
    End Sub
End Class