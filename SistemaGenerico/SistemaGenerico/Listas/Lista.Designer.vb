<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
    Inherits SistemaGenerico.FormularioBase

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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxProveedores = New System.Windows.Forms.GroupBox()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.gbxProveedores.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxProveedores
        '
        Me.gbxProveedores.Controls.Add(Me.dgvGrilla)
        Me.gbxProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxProveedores.Location = New System.Drawing.Point(12, 71)
        Me.gbxProveedores.Name = "gbxProveedores"
        Me.gbxProveedores.Size = New System.Drawing.Size(674, 402)
        Me.gbxProveedores.TabIndex = 26
        Me.gbxProveedores.TabStop = False
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.Location = New System.Drawing.Point(17, 28)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(639, 358)
        Me.dgvGrilla.TabIndex = 17
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 542)
        Me.Controls.Add(Me.gbxProveedores)
        Me.Name = "Lista"
        Me.Text = "Lista"
        Me.Controls.SetChildIndex(Me.gbxProveedores, 0)
        Me.gbxProveedores.ResumeLayout(False)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxProveedores As System.Windows.Forms.GroupBox
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
End Class
