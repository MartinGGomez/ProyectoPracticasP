Imports System.Data.Odbc
Public Class Gastos
    Inherits MenuBase

    Dim rs, rsRegistros As OdbcDataReader
    Dim sql As String

    Private Sub Gastosvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Registro de Gastos"
        logo()
        btn_gastos.BackColor = Color.OrangeRed

        dtpFecha.ShowUpDown = True
        dtpFecha.CustomFormat = "MMMMyyyy"

        dtpFechaPie.ShowUpDown = True
        dtpFechaPie.CustomFormat = "MMMMyyyy"

        cargarTiposGastos()
        cargarGraficos()

    End Sub

    Private Sub btnAgregarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGasto.Click
        Dim gasto As String
        gasto = InputBox("Ingrese la descripcion del gasto", "Nuevo Gasto")

        If Not String.IsNullOrEmpty(gasto) Then
            sql = "insert into Gastos values ('', '" & gasto & "')"
            Funciones.consulta(sql)
        End If

        cargarTiposGastos()

    End Sub

    Private Sub cargarTiposGastos()
        cboGastos.Items.Clear()
        sql = "select * from gastos"
        rs = Funciones.consulta(sql)

        Do While rs.Read
            cboGastos.Items.Add(rs(1))
        Loop

    End Sub

    Private Sub cargarGraficos()
        'sql = "select descripcion, monto, mes, año anio from gastos g, registrogastos r where r.idgasto = g.idgasto"
        'Funciones.llenarGrilla(sql, dgvGrilla)

        cargarGraficoLineal()
        cargarGraficoPie()


    End Sub

    Private Sub cargarGraficoLineal()
        linearChart.Series.Clear()

        linearChart.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
        linearChart.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
        linearChart.ChartAreas(0).AxisX.IsMarginVisible = False
        linearChart.ChartAreas(0).AxisY.IsMarginVisible = False

        ' Elegir inclinacion de los labels
        'linearChart.ChartAreas(0).AxisX.LabelStyle.Angle = -40

        sql = "select descripcion, idgasto from gastos"
        rs = Funciones.consulta(sql)

        Dim serieIndex As Integer = 0

        Do While rs.Read
            linearChart.Series.Add(rs(0)).ChartType = DataVisualization.Charting.SeriesChartType.Spline

            sql = "select monto, año, mes from registrogastos where idgasto = " & rs(1) & " order by fecha"
            rsRegistros = Funciones.consulta(sql)


            Do While rsRegistros.Read

                linearChart.Series(serieIndex).Points.AddXY(abreviarMes(rsRegistros(2)) & " - " & rsRegistros(1), rsRegistros(0))

            Loop
            serieIndex = serieIndex + 1
        Loop




        'linearChart.Series(0).Points.AddXY("Enero", 100)
        'linearChart.Series(0).Points.AddXY("Febrero", 200)
        'linearChart.Series(0).Points.AddXY("Marzo", 300)

    End Sub

    Private Sub cargarGraficoPie()
        pieChart.Series.Clear()
        pieChart.Series.Add("Serie 1").ChartType = DataVisualization.Charting.SeriesChartType.Pie

        sql = "select descripcion, monto from registrogastos r, gastos g where r.idgasto = g.idgasto and mes = '" & DateAndTime.MonthName(dtpFechaPie.Value.Month) & "' and año = " & dtpFechaPie.Value.Year & " "
        rs = Funciones.consulta(sql)

        Dim hayRegistros As Boolean = False
        Do While rs.Read
            hayRegistros = True
            pieChart.Visible = True
            lblRegistros.Visible = False
            pieChart.Series(0).Points.AddXY(" " & rs(0) & " - $ " & rs(1), rs(1))
        Loop
        If Not hayRegistros Then
            pieChart.Visible = False
            lblRegistros.Visible = True
        End If

    End Sub


    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        If cboGastos.Text = "" Or txtMonto.Text = "" Then
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical)
        Else


            sql = "select idgasto from gastos where descripcion = '" & cboGastos.Text & "'"
            rs = Funciones.consulta(sql)
            Dim idGasto As Integer

            If rs.Read Then

                idGasto = rs(0)


                sql = "select count(*) from registrogastos where idgasto = " & idGasto & " and mes = '" & DateAndTime.MonthName(dtpFecha.Value.Month) & "' and año = " & dtpFecha.Value.Year & ""
                rs = Funciones.consulta(sql)

                If rs.Read Then
                    If rs(0) > 0 Then
                        MsgBox("El gasto ya esta registrado", MsgBoxStyle.Critical)
                    Else
                        sql = "insert into registrogastos values ('', " & idGasto & ", " & txtMonto.Text & ", " & dtpFecha.Value.Year & ", '" & DateAndTime.MonthName(dtpFecha.Value.Month) & "', '" & Format(dtpFecha.Value.Date, "yyyy/MM/dd") & "')"
                        Funciones.consulta(sql)

                        txtMonto.Clear()

                        MsgBox("Gasto registrado", MsgBoxStyle.Information)

                        cargarGraficos()

                    End If
                End If


            
            End If
        End If




    End Sub

    Private Function abreviarMes(ByVal mes As String)
        Dim mesAbreviado As String = ""

        If mes = "enero" Then
            mesAbreviado = "ENE"
        End If
        If mes = "febrero" Then
            mesAbreviado = "FEB"
        End If
        If mes = "marzo" Then
            mesAbreviado = "MAR"
        End If
        If mes = "abril" Then
            mesAbreviado = "ABR"
        End If
        If mes = "mayo" Then
            mesAbreviado = "MAY"
        End If
        If mes = "junio" Then
            mesAbreviado = "JUN"
        End If
        If mes = "julio" Then
            mesAbreviado = "JUL"
        End If
        If mes = "agosto" Then
            mesAbreviado = "AGO"
        End If
        If mes = "septiembre" Then
            mesAbreviado = "SEP"
        End If
        If mes = "octubre" Then
            mesAbreviado = "OCT"
        End If
        If mes = "noviembre" Then
            mesAbreviado = "NOV"
        End If
        If mes = "diciembre" Then
            mesAbreviado = "DIC"
        End If
        Return mesAbreviado
    End Function

    Private Sub dtpFechaPie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaPie.ValueChanged
        cargarGraficoPie()
    End Sub
End Class