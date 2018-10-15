Imports System.IO

Module Utilidades
    Public pathLogo As String = obtenerPathBase() + "Resources\Logo\logo.png"
    Public pathLogoDefault As String = obtenerPathBase() + "Resources\Logo\logodefault.png"


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

   

End Module
