Imports System.Data.Odbc

Public Class GestionarUsuarios
    Inherits MenuBase

    Dim sql, busqueda As String
    Dim idEmpleado, idTipo As Integer
    Dim rs As OdbcDataReader

    Private Sub GestionarUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gestionar Usuarios"
        logo()

        cargarUsuarios()
    End Sub

    Private Sub txtBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.TextChanged
        cargarUsuarios()
    End Sub

    Private Sub me_enabled(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        cargarUsuarios()
        FormularioUsuario.txtape.Enabled = True
        FormularioUsuario.txtmail.Enabled = True
        FormularioUsuario.txtdni.Enabled = True
    End Sub

    Private Sub tabla_empleados_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabla_empleados.CellClick
        Try
            idEmpleado = tabla_empleados.Rows(e.RowIndex).Cells(0).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Public Sub cargarUsuarios()
        sql = "select e.idEmpleado ID, Nombre, Apellido, Dni, Mail, Estado, u.Administrador  from empleados e, usuarios u where estado = 'Activo' and e.idempleado = u.idempleado"
        busqueda = sql
        If Not String.IsNullOrEmpty(txtBuscador.Text) Then
            busqueda &= " and nombre like '%" & txtBuscador.Text & "%' or apellido like '%" & txtBuscador.Text & "%' "
            tabla_empleados.DataSource = Funciones.llenarGrilla(busqueda)
        Else
            tabla_empleados.DataSource = Funciones.llenarGrilla(sql)
        End If


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        FormularioUsuario.blanquear()

        Me.Enabled = False
        FormularioUsuario.Show()
        FormularioUsuario.btneditar.Visible = False
        FormularioUsuario.btnagregar.Visible = True
        FormularioUsuario.btnagregaresp.Visible = False
        FormularioUsuario.btneditaresp.Visible = False
        FormularioUsuario.lblTitulo.Text = "AGREGAR USUARIO"
        FormularioUsuario.pantallaAnterior = Me
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click


        If idEmpleado <> 0 Then

            FormularioUsuario.idEmpleado = idEmpleado
            FormularioUsuario.editar = True
            FormularioUsuario.blanquear()
            FormularioUsuario.cargarInfo()

            Me.Enabled = False
            FormularioUsuario.Show()
            FormularioUsuario.btnagregar.Visible = False
            FormularioUsuario.btnagregaresp.Visible = False
            If FormularioUsuario.txtdni.Text = "" Then
                FormularioUsuario.btneditaresp.Visible = True
                FormularioUsuario.btneditar.Visible = False
                FormularioUsuario.lblTitulo.Text = "EDITAR USUARIO ESPECIAL"
                FormularioUsuario.txtape.Enabled = False
                FormularioUsuario.txtmail.Enabled = False
                FormularioUsuario.txtdni.Enabled = False
            Else
                FormularioUsuario.btneditar.Visible = True
                FormularioUsuario.btneditaresp.Visible = False
                FormularioUsuario.lblTitulo.Text = "EDITAR USUARIO"
            End If

            FormularioUsuario.pantallaAnterior = Me
        Else

            MsgBox("No se ha seleccionado ningun usuario", MsgBoxStyle.Critical)

        End If

        idEmpleado = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If idEmpleado <> 0 Then

            sql = "select administrador from usuarios where idEmpleado = " & idEmpleado
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 1 Then

                    MsgBox("No se puede borrar un administrador", MsgBoxStyle.Critical)

                Else
                    sql = "delete from usuarios where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)

                    sql = "delete from empleados where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)

                    cargarUsuarios()
                End If

            End If

        End If
        idEmpleado = 0
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        FormularioUsuario.blanquear()

        Me.Enabled = False
        FormularioUsuario.Show()
        FormularioUsuario.btneditar.Visible = False
        FormularioUsuario.btnagregar.Visible = False
        FormularioUsuario.btnagregaresp.Visible = True
        FormularioUsuario.btneditaresp.Visible = False
        FormularioUsuario.txtape.Enabled = False
        FormularioUsuario.txtmail.Enabled = False
        FormularioUsuario.txtdni.Enabled = False
        FormularioUsuario.especial = True
        FormularioUsuario.lblTitulo.Text = "AGREGAR USUARIO ESPECIAL"
        FormularioUsuario.pantallaAnterior = Me
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If idEmpleado <> 0 Then

            sql = "select administrador from usuarios where idEmpleado = " & idEmpleado
            rs = Funciones.consulta(sql)

            If rs.Read Then
                MsgBox(rs(0))
                If rs(0) = 1 Then

                    MsgBox("Ya es administrador", MsgBoxStyle.Critical)

                Else
                    sql = "update usuarios set administrador = true where idEmpleado = " & idEmpleado
                    Funciones.consulta(sql)

                    cargarUsuarios()
                End If

            End If

        End If
        idEmpleado = 0
    End Sub

    Private Sub lblBuscar_Click(sender As System.Object, e As System.EventArgs) Handles lblBuscar.Click

    End Sub
End Class