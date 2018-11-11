<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
    Inherits SistemaGenerico.MenuBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.linealChartGastos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.linealChartGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'linealChartGastos
        '
        ChartArea1.Name = "ChartArea1"
        Me.linealChartGastos.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.linealChartGastos.Legends.Add(Legend1)
        Me.linealChartGastos.Location = New System.Drawing.Point(11, 85)
        Me.linealChartGastos.Name = "linealChartGastos"
        Me.linealChartGastos.Size = New System.Drawing.Size(418, 209)
        Me.linealChartGastos.TabIndex = 6
        Me.linealChartGastos.Text = "Chart1"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel17.Controls.Add(Me.linealChartGastos)
        Me.Panel17.Controls.Add(Me.Label7)
        Me.Panel17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel17.Location = New System.Drawing.Point(244, 55)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(440, 312)
        Me.Panel17.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label7.CausesValidation = False
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(4, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Productos Bajo en Stock"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.Panel17)
        Me.Name = "Gastos"
        Me.Text = "Gastos"
        Me.Controls.SetChildIndex(Me.Panel17, 0)
        CType(Me.linealChartGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents linealChartGastos As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
