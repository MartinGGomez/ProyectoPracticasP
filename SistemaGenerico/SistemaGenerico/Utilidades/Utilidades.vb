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

   

End Module
