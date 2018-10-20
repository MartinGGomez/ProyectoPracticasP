Public Class Lista
    Inherits FormularioBase

    Public Sub cargarDatos(ByRef sql As String, ByVal titulo As String, ByVal form As Form)
        lblTitulo.Text = "Lista de " & titulo
        pantallaAnterior = form
        Funciones.llenarGrilla(sql, dgvGrilla)
    End Sub
End Class