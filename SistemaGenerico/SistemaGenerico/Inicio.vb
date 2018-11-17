Public Class Inicio
    Inherits SistemaGenerico.MenuBase
    Dim sql As String
    Dim rs As Odbc.OdbcDataReader

    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Inicio"
        logo()
        contadores()
        cargarGrillas()


    End Sub



    Public Sub cargarGrillas()
        sql = "select descripcion Nombre, stock Stock, PuntoPedido PuntoDePedido from productos where estado = 'Activo' and stock <= puntopedido"

        tabla_productos.DataSource = Funciones.llenarGrilla(sql)

        sql = "select descripcion Descripcion, fecha Fecha, montoTotal Monto from ventas order by fecha desc limit 10"
        tablaventas.DataSource = Funciones.llenarGrilla(sql)

        sql = "select descripcion Descripcion, fecha Fecha, montoTotal Monto from compras order by fecha desc limit 10"
        tablacompras.DataSource = Funciones.llenarGrilla(sql)


    End Sub

    Public Sub contadores()

        sql = "select count(*) from clientes where estado = 'Activo'"
        rs = Funciones.consulta(sql)
        If rs.Read = True Then
            lblclientescont.Text = rs(0)
        End If

        sql = "select count(*) from ventas"
        rs = Funciones.consulta(sql)
        If rs.Read = True Then
            lblventascont.Text = rs(0)
        End If

        sql = "select count(*) from compras"
        rs = Funciones.consulta(sql)
        If rs.Read = True Then
            lblcomprascont.Text = rs(0)
        End If

        sql = "select sum(montoTotal) from compras"
        rs = Funciones.consulta(sql)
        If rs.Read = True Then
            lblegresos.Text = "$ " + rs(0).ToString
            If lblegresos.Text.Equals("$ ") Then
                lblegresos.Text = "$ 0"
            End If
        End If

        sql = "select sum(montoTotal) from ventas"
        rs = Funciones.consulta(sql)
        If rs.Read = True Then
            lblingresos.Text = "$ " + rs(0).ToString
            If lblingresos.Text.Equals("$ ") Then
                lblingresos.Text = "$ 0"
            End If
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clientes.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clientes.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clientes.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class