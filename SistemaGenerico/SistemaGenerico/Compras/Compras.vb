Public Class Compras
    Inherits MenuBase

    Dim sql, busqueda As String


    Public Sub cargarCompras()
        sql = "select * from compras"
        busqueda = Sql
        If Not String.IsNullOrEmpty(cboProveedores.Text) Then
            busqueda &= " and descripcion like '%" & cboProveedores.Text & "%' "
            dgvProveedores.DataSource = Funciones.llenarGrilla(busqueda)
        Else
            dgvProveedores.DataSource = Funciones.llenarGrilla(sql)
        End If
  

    End Sub

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub dgvProveedores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick

    End Sub

    Private Sub dgvProveedores_CellToolTipTextNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles dgvProveedores.CellToolTipTextNeeded

        e.ToolTipText = "Doble click para ver el detalle"

    End Sub
End Class