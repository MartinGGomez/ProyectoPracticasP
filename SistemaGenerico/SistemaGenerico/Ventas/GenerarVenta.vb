Imports System.Data.Odbc
Public Class GenerarVenta
    Inherits MenuBase

    Dim rs As OdbcDataReader
    Dim sql As String

    Public Sub cargarClientes()
        sql = "select idCliente, nombre, apellido from clientes where estado = 'Activo' "
        rs = Funciones.consulta(sql)

        Do While rs.Read
            txtClientes.AutoCompleteCustomSource.Add(rs(1) & " " & rs(2))
        Loop

    End Sub

End Class