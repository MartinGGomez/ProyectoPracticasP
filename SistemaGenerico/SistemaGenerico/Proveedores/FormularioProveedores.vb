Public Class FormularioProveedores
    Inherits SistemaGenerico.FormularioBase
    Dim sql As String
    Dim rs As Odbc.OdbcDataReader

    Private Sub FormularioProveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub


    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs)
        Proveedores.Enabled = True
        Proveedores.Show()
        Me.Close()

        Proveedores.idProveedor = 0
        lblError.Text = ""
        imgError.Visible = False
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If lblTitulo.Text = "Cargar Proveedor" Then
            If txtNombreProv.Text = "" Or txtTel.Text = "" Or txtMail.Text = "" Or txtDireccion.Text = "" Then
                lblError.Text = "Hay campos vacios. Completar Campos."
                imgError.Visible = True
            Else

                sql = "insert into proveedores values ('', '" & txtNombreProv.Text & "', '" & txtTel.Text & "', '" & txtMail.Text & "', '" & txtDireccion.Text & "', 'Activo')"
                Funciones.consulta(sql)
                Proveedores.cargarProveedores()
                Proveedores.Enabled = True
                Proveedores.Show()
                Me.Close()
                Proveedores.idProveedor = 0
                lblError.Text = ""

            End If
        Else

            If txtNombreProv.Text = "" Or txtTel.Text = "" Or txtMail.Text = "" Or txtDireccion.Text = "" Then
                lblError.Text = "Hay campos vacios. Completar Campos."
                imgError.Visible = True
            Else
                sql = "update proveedores set nombre = '" & txtNombreProv.Text & "', telefono = '" & txtTel.Text & "', mail = '" & txtMail.Text & "', direccion = '" & txtDireccion.Text & "' where idProveedor =" & Proveedores.idProveedor
                consulta(sql)
                Proveedores.cargarProveedores()
                Proveedores.Enabled = True
                Proveedores.Show()
                Me.Close()
                Proveedores.idProveedor = 0
                lblError.Text = ""
                imgError.Visible = False
            End If


        End If

    

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub
End Class