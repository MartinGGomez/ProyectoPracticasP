
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Gastos
    Inherits MenuBase

    Dim sql As String
    Dim rs As OdbcDataReader

    Private Sub Gastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Gastos"
        logo()
        cargarGraficos()

    End Sub

    Public Sub cargarGraficos()

        sql = "select descripcion, año, mes, monto from gastos"
        rs = Funciones.consulta(sql)
        Dim contador As Integer = 0

        Do While rs.Read = True



            linealChartGastos.Series.Add(rs(0))
            linealChartGastos.Series(contador).Points.AddXY(contador + 1, 100 * contador + 1)
            linealChartGastos.Series(contador).ChartType = SeriesChartType.Column

            contador = contador + 1
        Loop



    End Sub

End Class