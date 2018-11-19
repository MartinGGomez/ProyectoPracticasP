Imports System.IO

Module Utilidades
    Public pathLogo As String = obtenerPathBase() + "Resources\Logo\logo.png"
    Public pathLogoDefault As String = obtenerPathBase() + "Resources\Logo\logodefault.png"
    Public nombreUsuario As String
    Public tipoUsuario As String
    Public idUsuario As Integer


    Public Function obtenerPathBase()

        Dim pathActual, pathBase As String
        Dim array() As Char
        Dim cantidad As Integer

        pathActual = Application.StartupPath
        pathBase = ""
        array = pathActual.ToCharArray
        cantidad = pathActual.Length

        For index As Integer = 0 To cantidad - 10
            pathBase = pathBase + array.GetValue(index)

        Next
        Return pathBase

    End Function

    Public Function estaAbiertoElFormulario(form As String)

        Dim abierto As Boolean = False

        For Each f As Form In Application.OpenForms
            If f.Name.Equals(form) Then
                abierto = True
            End If
        Next

        Return abierto

    End Function

    Public Sub restaurarLogo()

        If File.Exists(Utilidades.pathLogo) Then

            If Utilidades.estaAbiertoElFormulario("InicioSesion") Then
                InicioSesion.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Ajustes") Then
                Ajustes.img_logo.BackgroundImage.Dispose()
                Ajustes.img_logo_ajustes.BackgroundImage.Dispose()
            End If
            If Utilidades.estaAbiertoElFormulario("Inicio") Then
                Inicio.img_logo.BackgroundImage.Dispose()
            End If
            If Utilidades.estaAbiertoElFormulario("PanelUsuario") Then
                PanelUsuario.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Clientes") Then
                Clientes.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("GestionarUsuarios") Then
                GestionarUsuarios.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Productos") Then
                Productos.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Compras") Then
                Compras.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Ventas") Then
                Ventas.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("GenerarVenta") Then
                GenerarCompra.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("DetalleCompra") Then
                DetalleCompra.img_logo.BackgroundImage.Dispose()
            End If


            If Utilidades.estaAbiertoElFormulario("GenerarCompra") Then
                GenerarCompra.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Gastos") Then
                Gastos.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Proveedores") Then
                Proveedores.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Registros") Then
                Registros.img_logo.BackgroundImage.Dispose()
            End If

            If Utilidades.estaAbiertoElFormulario("Estadisticas") Then
                Registros.img_logo.BackgroundImage.Dispose()
            End If

            File.Delete(Utilidades.pathLogo)

            refrescarLogo()

        End If

    End Sub

    Public Sub refrescarLogo()

        GestionarUsuarios.logo()
        PanelUsuario.logo()
        Clientes.logo()
        Productos.logo()
        Inicio.logo()
        Ajustes.logo()
        Ajustes.logoAjustes()
        InicioSesion.logo()
        Compras.logo()
        Ventas.logo()
        DetalleCompra.logo()
        GenerarCompra.logo()
        GenerarVenta.logo()
        Gastos.logo()
        Proveedores.logo()
        Registros.logo()
    End Sub



End Module
