﻿Imports System.Data.Odbc

Public Class DetalleCompra

    Inherits MenuBase

    Dim rs As OdbcDataReader
    Dim sql As String

    Public Sub cargarDatosCompra(ByVal idCompra As Integer)
        Dim estado As String

        dgvProductos.Rows.Clear()
        sql = "select p.nombre, fecha, montoTotal, c.estado from Compras C, Proveedores P where c.idproveedor = p.idproveedor and c.idCompra = " & idCompra & ""
        rs = Funciones.consulta(sql)

        If rs.Read Then
            cboProveedores.Items.Add(rs(0))
            cboProveedores.Text = rs(0)
            cboProveedores.Enabled = False
            dtpFecha.Value = rs(1)
            estado = rs(3)
            lblMontoTotal.Text = "$" + rs(2).ToString

            If estado = "Finalizada" Then
                lblEstado.ForeColor = Color.Red
                lblEstado.Text = estado
            Else
                lblEstado.ForeColor = Color.YellowGreen
                lblEstado.Text = estado
            End If

        End If

        sql = "select p.idproducto, descripcion, cantidad from productos p, detallecompras c where p.idproducto = c.idproducto and c.idcompra = " & idCompra & ""
        rs = Funciones.consulta(sql)

        Do While rs.Read
            dgvProductos.Rows.Add(rs(0), rs(1), rs(2))
        Loop

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        Compras.cargarCompras()
        Compras.Show()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DetalleCompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        logo()
        lblTitulo.Text = "Gestionar Compras  >  Detalle de la Compra"
        btn_compras.BackColor = Color.OrangeRed
    End Sub
End Class