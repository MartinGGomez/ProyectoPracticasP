﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.gbxProductos = New System.Windows.Forms.GroupBox()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.gbxOpciones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.gbxProductos.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxProductos
        '
        Me.gbxProductos.Controls.Add(Me.btnAgregarCompra)
        Me.gbxProductos.Controls.Add(Me.cboProveedores)
        Me.gbxProductos.Controls.Add(Me.lblBuscar)
        Me.gbxProductos.Controls.Add(Me.dgvProveedores)
        Me.gbxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxProductos.Location = New System.Drawing.Point(275, 74)
        Me.gbxProductos.Name = "gbxProductos"
        Me.gbxProductos.Size = New System.Drawing.Size(844, 468)
        Me.gbxProductos.TabIndex = 24
        Me.gbxProductos.TabStop = False
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarCompra.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarCompra.FlatAppearance.BorderSize = 0
        Me.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarCompra.Location = New System.Drawing.Point(598, 28)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(219, 35)
        Me.btnAgregarCompra.TabIndex = 21
        Me.btnAgregarCompra.Text = "AGREGAR COMPRA"
        Me.btnAgregarCompra.UseVisualStyleBackColor = False
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(20, 42)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(253, 28)
        Me.cboProveedores.TabIndex = 20
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblBuscar.ForeColor = System.Drawing.Color.Orange
        Me.lblBuscar.Location = New System.Drawing.Point(16, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(193, 24)
        Me.lblBuscar.TabIndex = 19
        Me.lblBuscar.Text = "Buscar por proveedor"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProveedores.Location = New System.Drawing.Point(20, 89)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvProveedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProveedores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvProveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(797, 350)
        Me.dgvProveedores.TabIndex = 17
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Controls.Add(Me.Button1)
        Me.gbxOpciones.Controls.Add(Me.btnEliminar)
        Me.gbxOpciones.Controls.Add(Me.btnEditar)
        Me.gbxOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOpciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxOpciones.Location = New System.Drawing.Point(275, 543)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(844, 85)
        Me.gbxOpciones.TabIndex = 25
        Me.gbxOpciones.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(54, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "EDITAR COMPRA"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(333, 31)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(219, 35)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "FINALIZAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(598, 31)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(219, 35)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "VER DETALLE"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.gbxProductos)
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.Controls.SetChildIndex(Me.gbxProductos, 0)
        Me.Controls.SetChildIndex(Me.gbxOpciones, 0)
        Me.gbxProductos.ResumeLayout(False)
        Me.gbxProductos.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxProductos As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarCompra As System.Windows.Forms.Button
    Friend WithEvents gbxOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
