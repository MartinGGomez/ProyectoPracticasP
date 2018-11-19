Imports System.Data.Odbc
Public Class Gastos
    Inherits MenuBase

    Dim rs As OdbcDataReader
    Dim sql As String

    Private Sub Gastosvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Registro de Gastos"
        logo()
        btn_gastos.BackColor = Color.OrangeRed

        dtpFecha.ShowUpDown = True
        dtpFecha.CustomFormat = "MMMMyyyy"

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

                sql = "insert into registrogastos values ('', " & idGasto & ", " & txtMonto.Text & ", " & dtpFecha.Value.Year & ", '" & DateAndTime.MonthName(dtpFecha.Value.Month) & "')"
                Funciones.consulta(sql)

                MsgBox("Gasto registrado", MsgBoxStyle.Information)

                cargarGraficos()

            End If
        End If




    End Sub

End Class