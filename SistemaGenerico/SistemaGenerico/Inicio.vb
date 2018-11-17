Public Class Inicio
    Inherits SistemaGenerico.MenuBase
    Dim sql As String
    Dim rs As Odbc.OdbcDataReader

    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Inicio"
        logo()
        contadores()
        cargarGrillas()
        btn_inicio.BackColor = Color.OrangeRed


    End Sub



    Public Sub cargarGrillas()
        sql = "select descripcion Nombre, stock Stock, PuntoPedido PuntoDePedido from productos where estado = 'Activo' and stock <= puntopedido"

        tabla_productos.DataSource = Funciones.llenarGrilla(sql)

        sql = "select fecha Fecha, montoTotal Monto from ventas order by fecha desc limit 10"
        tablaventas.DataSource = Funciones.llenarGrilla(sql)

        sql = "select fecha Fecha, montoTotal Monto from compras order by fecha desc limit 10"
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

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()
        Clientes.Show()
    End Sub

    Private Sub lblclientescont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblclientescont.Click
        Me.Close()
        Clientes.Show()
    End Sub

    Private Sub Panel11_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel11.Click
        Me.Close()
        Clientes.Show()
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Close()
        Clientes.Show()
    End Sub

    Private Sub Panel16_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel16.Click
        Me.Close()
        Clientes.Show()
    End Sub

    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel10.Click
        Me.Close()
        Compras.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Close()
        Compras.Show()
    End Sub

    Private Sub lblcomprascont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcomprascont.Click
        Me.Close()
        Compras.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Compras.Show()
    End Sub

    Private Sub Panel13_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel13.Click
        Me.Close()
        Compras.Show()
    End Sub

    Private Sub lblventascont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblventascont.Click
        Me.Close()
        Ventas.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
        Ventas.Show()
    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel8.Click
        Me.Close()
        Ventas.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Ventas.Show()
    End Sub

    Private Sub Panel12_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel12.Click
        Me.Close()
        Ventas.Show()
    End Sub


End Class