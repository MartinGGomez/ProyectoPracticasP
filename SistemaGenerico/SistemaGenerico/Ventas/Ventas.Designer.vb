<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.gbxVentas = New System.Windows.Forms.GroupBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.gbxOpciones = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEditar = New System.Windows.Forms.Button()
        Me.btnverVentas = New System.Windows.Forms.Button()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVentas.SuspendLayout()
        Me.gbxOpciones.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.Location = New System.Drawing.Point(20, 99)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(797, 350)
        Me.dgvGrilla.TabIndex = 17
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblBuscar.ForeColor = System.Drawing.Color.Orange
        Me.lblBuscar.Location = New System.Drawing.Point(16, 25)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(264, 24)
        Me.lblBuscar.TabIndex = 19
        Me.lblBuscar.Text = "Buscar por monto aproximado"
        '
        'btnVerDetalle
        '
        Me.btnVerDetalle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerDetalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVerDetalle.FlatAppearance.BorderSize = 0
        Me.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerDetalle.Location = New System.Drawing.Point(651, 47)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(166, 35)
        Me.btnVerDetalle.TabIndex = 14
        Me.btnVerDetalle.Text = "VER DETALLE"
        Me.btnVerDetalle.UseVisualStyleBackColor = False
        '
        'gbxVentas
        '
        Me.gbxVentas.Controls.Add(Me.btnverVentas)
        Me.gbxVentas.Controls.Add(Me.txtBuscador)
        Me.gbxVentas.Controls.Add(Me.btnVerDetalle)
        Me.gbxVentas.Controls.Add(Me.lblBuscar)
        Me.gbxVentas.Controls.Add(Me.dgvGrilla)
        Me.gbxVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxVentas.Location = New System.Drawing.Point(266, 70)
        Me.gbxVentas.Name = "gbxVentas"
        Me.gbxVentas.Size = New System.Drawing.Size(844, 468)
        Me.gbxVentas.TabIndex = 26
        Me.gbxVentas.TabStop = False
        '
        'txtBuscador
        '
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBuscador.Location = New System.Drawing.Point(22, 56)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(187, 26)
        Me.txtBuscador.TabIndex = 21
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Controls.Add(Me.btnEliminar)
        Me.gbxOpciones.Controls.Add(Me.btnAgregar)
        Me.gbxOpciones.Controls.Add(Me.txtEditar)
        Me.gbxOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOpciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxOpciones.Location = New System.Drawing.Point(266, 544)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(844, 85)
        Me.gbxOpciones.TabIndex = 27
        Me.gbxOpciones.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(598, 31)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(219, 35)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "BORRAR VENTA"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(42, 31)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(219, 35)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "AGREGAR VENTA"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtEditar
        '
        Me.txtEditar.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.txtEditar.FlatAppearance.BorderSize = 0
        Me.txtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEditar.Location = New System.Drawing.Point(324, 31)
        Me.txtEditar.Name = "txtEditar"
        Me.txtEditar.Size = New System.Drawing.Size(219, 35)
        Me.txtEditar.TabIndex = 14
        Me.txtEditar.Text = "EDITAR VENTA"
        Me.txtEditar.UseVisualStyleBackColor = False
        '
        'btnverVentas
        '
        Me.btnverVentas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnverVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnverVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnverVentas.FlatAppearance.BorderSize = 0
        Me.btnverVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnverVentas.Location = New System.Drawing.Point(651, 47)
        Me.btnverVentas.Name = "btnverVentas"
        Me.btnverVentas.Size = New System.Drawing.Size(166, 35)
        Me.btnverVentas.TabIndex = 23
        Me.btnverVentas.Text = "VER VENTAS"
        Me.btnverVentas.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.gbxVentas)
        Me.Name = "Ventas"
        Me.Controls.SetChildIndex(Me.gbxVentas, 0)
        Me.Controls.SetChildIndex(Me.gbxOpciones, 0)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVentas.ResumeLayout(False)
        Me.gbxVentas.PerformLayout()
        Me.gbxOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnVerDetalle As System.Windows.Forms.Button
    Friend WithEvents gbxVentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbxOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtEditar As System.Windows.Forms.Button
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents btnverVentas As System.Windows.Forms.Button
End Class
