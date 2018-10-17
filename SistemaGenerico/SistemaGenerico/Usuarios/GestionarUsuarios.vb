Imports System.Data.Odbc

Public Class GestionarUsuarios
    Inherits MenuBase

    Dim sql, busqueda As String
    Dim idEmpleado As Integer
    Dim rs As OdbcDataReader

    Private Sub GestionarUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gestionar Usuarios"
        logo()

        cargarUsuarios()
    End Sub

    Private Sub txtBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarUsuarios()
    End Sub

    Public Sub cargarUsuarios()
        sql = "select e.idEmpleado ID, Nombre, Apellido, Dni, mail, Estado, u.Administrador  from empleados e, usuarios u where estado = 'Activo' and e.idempleado = u.idempleado"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and nombre like '%" & txtBuscador.Text & "%' or apellido like '%" & txtBuscador.Text & "%' "
            tabla_empleados.DataSource = Funciones.llenarGrilla(busqueda)
        Else
            tabla_empleados.DataSource = Funciones.llenarGrilla(sql)
        End If


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Me.Enabled = False
        FormularioUsuario.Show()
        FormularioUsuario.lblTitulo.Text = "AGREGAR USUARIO"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Enabled = False
        FormularioUsuario.Show()
        FormularioUsuario.lblTitulo.Text = "EDITAR USUARIO"
        FormularioUsuario.txtnom.Text = "Federico"
        FormularioUsuario.txtape.Text = "Markus"
        FormularioUsuario.txtmail.Text = "federicomarkus@gmail.com"
        FormularioUsuario.ComboBox1.Items.Add("Administrador")
        FormularioUsuario.ComboBox1.Text = "Administrador"
    End Sub
End Class