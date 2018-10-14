Public Class GestionarUsuarios
    Inherits MenuBase

    Private Sub GestionarUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gestionar Usuarios"
        logo()

        tabla_empleados.Columns(0).Width = 40 'id'
        tabla_empleados.Columns(1).Width = 120 'nombre'
        tabla_empleados.Columns(2).Width = 120 'apellido'
        tabla_empleados.Columns(3).Width = 250 'email'
        tabla_empleados.Columns(4).Width = 150 'trabajo'

        tabla_empleados.Rows.Add("1", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("2", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("3", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("4", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("5", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("6", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("7", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("8", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("9", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("10", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("11", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("12", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
        tabla_empleados.Rows.Add("13", "Federico", "Markus", "federicomarkus@gmail.com", "Administrador", "True")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabla_empleados.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        AgregarUsuario.Show()
    End Sub
End Class