Imports System.Data.Odbc

Public Class FormularioTipoTrabajo
    Inherits FormularioBase
    Dim rs, rs2 As OdbcDataReader
    Dim sql, nombre As String
    Dim idTipo As Integer


    Public Sub cargarTrabajos()

        sql = "select nombre from tipotrabajo where nombre not like 'Administrador' and nombre not like 'Empleado'"
        tablatrabajos.DataSource = Funciones.llenarGrilla(sql)


    End Sub

    Private Sub FormularioTipoTrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarTrabajos()
        lblTitulo.Text = "Gestionar Tipos de Trabajos"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnagregar.Click
        If txtnombre.Text <> "" Then

            sql = "select count(*) from tipotrabajo where nombre = '" & txtnombre.Text & "'"
            MsgBox(sql)
            rs = Funciones.consulta(sql)

            If rs.Read Then

                If rs(0) = 0 Then

                    sql = "insert into tipotrabajo values ('','" & txtnombre.Text & "')"
                    Funciones.consulta(sql)
                    cargarTrabajos()
                    lblerror2.Text = ""

                Else

                    lblerror2.Text = "Ya existe un trabajo con ese nombre"

                End If

            End If


        Else
            lblerror2.Text = "Hay campos vacios"

        End If
    End Sub

    Private Sub tablatrabajos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tablatrabajos.CellClick
        Try
            nombre = tablatrabajos.Rows(e.RowIndex).Cells(0).Value.ToString
            sql = "select idTipo from tipotrabajo where nombre = '" & nombre & "'"
            rs = Funciones.consulta(sql)
            If rs.Read Then
                idTipo = rs(0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnborrar.Click
        lblerror.Text = ""

        sql = "select count(*) from empleados where idTipo = " & idTipo
        rs = Funciones.consulta(sql)
        If rs.Read Then
            If rs(0) = 0 Then
                sql = "delete from tipotrabajo where idTipo = " & idTipo
                Funciones.consulta(sql)
                cargarTrabajos()
                lblerror.Text = ""
            Else

                sql = "select idEmpleado from empleados where idTipo =" & idTipo
                rs2 = Funciones.consulta(sql)

                Do While rs2.Read

                    sql = "update empleados set idTipo = (select idTipo from TipoTrabajo where nombre = 'Empleado') where idEmpleado = " & rs2(0)
                    Funciones.consulta(sql)
                Loop

                sql = "delete from tipotrabajo where idTipo = " & idTipo
                Funciones.consulta(sql)
                cargarTrabajos()
                lblerror.Text = ""
            End If
        End If
    End Sub
End Class