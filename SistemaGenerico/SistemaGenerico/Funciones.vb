Imports System.Data.Odbc

Module Funciones

    Private cnn As OdbcConnection
    Private cmd As OdbcCommand



    Public Sub conexion()

        Try
            cnn = New OdbcConnection("DSN=SistemaGenerico")
            cnn.Open()
        Catch ex As Exception
            MsgBox("Error en la conexion a la base de datos", MsgBoxStyle.Critical)
            Application.Exit()
        End Try

    End Sub

    Public Function consulta(ByVal sql As String) As OdbcDataReader

        Dim rs As OdbcDataReader

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

        Return rs

    End Function

    Public Function llenarGrilla(ByVal sql As String) As DataTable
        Dim ds As DataSet
        Dim adp As OdbcDataAdapter

        ds = New DataSet("Tabla")
        ds.Tables.Add("Tabla")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Tabla"))

        Return ds.Tables("Tabla")

    End Function

    Public Sub onlyNum(ByVal e)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Module
