﻿Imports System.IO

Public Class MenuBase


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click

        Application.Exit()

    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inicio.Click

        If Not Me.Equals(Inicio) Then

            Inicio.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub btn_minimizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btn_clientes_Click(sender As System.Object, e As System.EventArgs) Handles btn_clientes.Click

        If Not Me.Equals(Clientes) Then

            Clientes.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

        InicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_nom_user_Click(sender As System.Object, e As System.EventArgs) Handles lbl_nom_user.Click
        If Not Me.Equals(PanelUsuario) Then
            Me.Hide()
            PanelUsuario.Show()


        End If
    End Sub

    Private Sub img_user_Click(sender As System.Object, e As System.EventArgs) Handles img_user.Click
        If Not Me.Equals(PanelUsuario) Then

            PanelUsuario.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btn_ajustes_Click(sender As System.Object, e As System.EventArgs) Handles btn_ajustes.Click
        If Not Me.Equals(Ajustes) Then

            Ajustes.Show()
            Me.Hide()

        End If
    End Sub

    Public Sub logo()


        If File.Exists(Utilidades.pathLogo) Then

            img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogo)

        ElseIf File.Exists(Utilidades.pathLogoDefault) Then

                img_logo.BackgroundImage = Image.FromFile(Utilidades.pathLogoDefault)

            End If

    End Sub

    Private Sub btn_productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productos.Click
        If Not Me.Equals(Productos) Then
            Me.Hide()
            Productos.cargarProductos()
            Productos.Show()
        End If
    End Sub

    Private Sub btn_proveedores_Click(sender As System.Object, e As System.EventArgs) Handles btn_proveedores.Click
        If Not Me.Equals(Proveedores) Then
            Me.Hide()
            Proveedores.cargarProveedores()
            Proveedores.Show()
        End If

    End Sub

    Private Sub MenuBase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_nom_user.Text = Utilidades.nombreUsuario
        lbl_tipo_trab.Text = Utilidades.tipoUsuario

    End Sub

    Private Sub btn_compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compras.Click
        If Not Me.Equals(Compras) Then
            Me.Hide()
            Compras.cargarCompras()
            Compras.Show()
        End If
    End Sub
End Class
