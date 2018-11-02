Public Class Cargando

    Dim tiempoFinal, tiempoActual As Integer
    Public pantallaAnterior As Form
    Public mensaje As String

    Public Sub iniciarTimer()
        lblDescripcion.Text = mensaje
        Dim random As New Random
        tiempoFinal = random.Next(50) + 30
        Timer1.Interval = tiempoFinal
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tiempoActual = tiempoActual + 1
        If tiempoActual = tiempoFinal Then
            pantallaAnterior.Enabled = True
            Me.Close()
        End If
    End Sub
End Class