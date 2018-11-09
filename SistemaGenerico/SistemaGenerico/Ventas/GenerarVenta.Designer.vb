<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarVenta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxVentas = New System.Windows.Forms.GroupBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnDer = New System.Windows.Forms.Button()
        Me.btnIzq = New System.Windows.Forms.Button()
        Me.btnRestarCant = New System.Windows.Forms.Button()
        Me.btnSumarCant = New System.Windows.Forms.Button()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.lblGrilla2 = New System.Windows.Forms.Label()
        Me.lblGrilla = New System.Windows.Forms.Label()
        Me.gbxOpciones = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtClientes = New System.Windows.Forms.TextBox()
        Me.txtMontoT = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditarMonto = New System.Windows.Forms.Button()
        Me.dgvGrilla2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxVentas.SuspendLayout()
        Me.gbxOpciones.SuspendLayout()
        CType(Me.dgvGrilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxVentas
        '
        Me.gbxVentas.Controls.Add(Me.dgvGrilla2)
        Me.gbxVentas.Controls.Add(Me.dgvGrilla)
        Me.gbxVentas.Controls.Add(Me.txtBuscador)
        Me.gbxVentas.Controls.Add(Me.lblBuscar)
        Me.gbxVentas.Controls.Add(Me.btnDer)
        Me.gbxVentas.Controls.Add(Me.btnIzq)
        Me.gbxVentas.Controls.Add(Me.btnRestarCant)
        Me.gbxVentas.Controls.Add(Me.btnSumarCant)
        Me.gbxVentas.Controls.Add(Me.lblCant)
        Me.gbxVentas.Controls.Add(Me.txtCant)
        Me.gbxVentas.Controls.Add(Me.lblGrilla2)
        Me.gbxVentas.Controls.Add(Me.lblGrilla)
        Me.gbxVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVentas.ForeColor = System.Drawing.Color.Orange
        Me.gbxVentas.Location = New System.Drawing.Point(252, 58)
        Me.gbxVentas.Name = "gbxVentas"
        Me.gbxVentas.Size = New System.Drawing.Size(877, 427)
        Me.gbxVentas.TabIndex = 27
        Me.gbxVentas.TabStop = False
        '
        'txtBuscador
        '
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBuscador.Location = New System.Drawing.Point(192, 40)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(209, 26)
        Me.txtBuscador.TabIndex = 46
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblBuscar.ForeColor = System.Drawing.Color.Orange
        Me.lblBuscar.Location = New System.Drawing.Point(38, 40)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(153, 24)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Buscar producto:"
        '
        'btnDer
        '
        Me.btnDer.BackColor = System.Drawing.Color.Transparent
        Me.btnDer.BackgroundImage = CType(resources.GetObject("btnDer.BackgroundImage"), System.Drawing.Image)
        Me.btnDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDer.FlatAppearance.BorderSize = 0
        Me.btnDer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDer.ForeColor = System.Drawing.Color.Transparent
        Me.btnDer.Location = New System.Drawing.Point(441, 187)
        Me.btnDer.Name = "btnDer"
        Me.btnDer.Size = New System.Drawing.Size(38, 70)
        Me.btnDer.TabIndex = 44
        Me.btnDer.UseVisualStyleBackColor = False
        '
        'btnIzq
        '
        Me.btnIzq.BackColor = System.Drawing.Color.Transparent
        Me.btnIzq.BackgroundImage = CType(resources.GetObject("btnIzq.BackgroundImage"), System.Drawing.Image)
        Me.btnIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIzq.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnIzq.FlatAppearance.BorderSize = 0
        Me.btnIzq.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzq.ForeColor = System.Drawing.Color.Transparent
        Me.btnIzq.Location = New System.Drawing.Point(439, 263)
        Me.btnIzq.Name = "btnIzq"
        Me.btnIzq.Size = New System.Drawing.Size(40, 70)
        Me.btnIzq.TabIndex = 43
        Me.btnIzq.UseVisualStyleBackColor = False
        '
        'btnRestarCant
        '
        Me.btnRestarCant.BackColor = System.Drawing.Color.Transparent
        Me.btnRestarCant.BackgroundImage = CType(resources.GetObject("btnRestarCant.BackgroundImage"), System.Drawing.Image)
        Me.btnRestarCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestarCant.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRestarCant.FlatAppearance.BorderSize = 0
        Me.btnRestarCant.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRestarCant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRestarCant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRestarCant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestarCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestarCant.ForeColor = System.Drawing.Color.Transparent
        Me.btnRestarCant.Location = New System.Drawing.Point(408, 127)
        Me.btnRestarCant.Name = "btnRestarCant"
        Me.btnRestarCant.Size = New System.Drawing.Size(25, 25)
        Me.btnRestarCant.TabIndex = 42
        Me.btnRestarCant.UseVisualStyleBackColor = False
        '
        'btnSumarCant
        '
        Me.btnSumarCant.BackColor = System.Drawing.Color.Transparent
        Me.btnSumarCant.BackgroundImage = CType(resources.GetObject("btnSumarCant.BackgroundImage"), System.Drawing.Image)
        Me.btnSumarCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSumarCant.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSumarCant.FlatAppearance.BorderSize = 0
        Me.btnSumarCant.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSumarCant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSumarCant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSumarCant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumarCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumarCant.ForeColor = System.Drawing.Color.Transparent
        Me.btnSumarCant.Location = New System.Drawing.Point(481, 128)
        Me.btnSumarCant.Name = "btnSumarCant"
        Me.btnSumarCant.Size = New System.Drawing.Size(25, 25)
        Me.btnSumarCant.TabIndex = 41
        Me.btnSumarCant.UseVisualStyleBackColor = False
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblCant.ForeColor = System.Drawing.Color.Orange
        Me.lblCant.Location = New System.Drawing.Point(416, 89)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(84, 24)
        Me.lblCant.TabIndex = 40
        Me.lblCant.Text = "Cantidad"
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCant.Location = New System.Drawing.Point(439, 127)
        Me.txtCant.MaxLength = 3
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(38, 26)
        Me.txtCant.TabIndex = 39
        Me.txtCant.Text = "1"
        Me.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrilla2
        '
        Me.lblGrilla2.AutoSize = True
        Me.lblGrilla2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblGrilla2.ForeColor = System.Drawing.Color.Orange
        Me.lblGrilla2.Location = New System.Drawing.Point(617, 89)
        Me.lblGrilla2.Name = "lblGrilla2"
        Me.lblGrilla2.Size = New System.Drawing.Size(174, 24)
        Me.lblGrilla2.TabIndex = 38
        Me.lblGrilla2.Text = "Productos a vender"
        '
        'lblGrilla
        '
        Me.lblGrilla.AutoSize = True
        Me.lblGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblGrilla.ForeColor = System.Drawing.Color.Orange
        Me.lblGrilla.Location = New System.Drawing.Point(135, 89)
        Me.lblGrilla.Name = "lblGrilla"
        Me.lblGrilla.Size = New System.Drawing.Size(164, 24)
        Me.lblGrilla.TabIndex = 37
        Me.lblGrilla.Text = "Lista de Productos"
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Controls.Add(Me.btnEditarMonto)
        Me.gbxOpciones.Controls.Add(Me.btnGuardar)
        Me.gbxOpciones.Controls.Add(Me.Button5)
        Me.gbxOpciones.Controls.Add(Me.txtClientes)
        Me.gbxOpciones.Controls.Add(Me.txtMontoT)
        Me.gbxOpciones.Controls.Add(Me.lblMonto)
        Me.gbxOpciones.Controls.Add(Me.btnCancelar)
        Me.gbxOpciones.Controls.Add(Me.btnConfirmar)
        Me.gbxOpciones.Controls.Add(Me.lblCliente)
        Me.gbxOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOpciones.ForeColor = System.Drawing.Color.Orange
        Me.gbxOpciones.Location = New System.Drawing.Point(252, 491)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(877, 132)
        Me.gbxOpciones.TabIndex = 29
        Me.gbxOpciones.TabStop = False
        Me.gbxOpciones.Text = "Facturacion"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(366, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 35)
        Me.Button5.TabIndex = 42
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtClientes
        '
        Me.txtClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtClientes.Location = New System.Drawing.Point(192, 38)
        Me.txtClientes.Name = "txtClientes"
        Me.txtClientes.Size = New System.Drawing.Size(168, 26)
        Me.txtClientes.TabIndex = 33
        '
        'txtMontoT
        '
        Me.txtMontoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMontoT.Location = New System.Drawing.Point(192, 84)
        Me.txtMontoT.Name = "txtMontoT"
        Me.txtMontoT.Size = New System.Drawing.Size(168, 26)
        Me.txtMontoT.TabIndex = 32
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblMonto.ForeColor = System.Drawing.Color.Orange
        Me.lblMonto.Location = New System.Drawing.Point(77, 84)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(109, 24)
        Me.lblMonto.TabIndex = 31
        Me.lblMonto.Text = "Monto Total"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Location = New System.Drawing.Point(549, 79)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 35)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Location = New System.Drawing.Point(549, 33)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(144, 35)
        Me.btnConfirmar.TabIndex = 24
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblCliente.ForeColor = System.Drawing.Color.Orange
        Me.lblCliente.Location = New System.Drawing.Point(118, 38)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(68, 24)
        Me.lblCliente.TabIndex = 20
        Me.lblCliente.Text = "Cliente"
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
        Me.Button1.Location = New System.Drawing.Point(549, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 35)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CONFIRMAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Location = New System.Drawing.Point(515, 55)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(223, 35)
        Me.btnGuardar.TabIndex = 45
        Me.btnGuardar.Text = "GUARDAR CAMBIOS"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditarMonto
        '
        Me.btnEditarMonto.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarMonto.BackgroundImage = CType(resources.GetObject("btnEditarMonto.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarMonto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarMonto.FlatAppearance.BorderSize = 0
        Me.btnEditarMonto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEditarMonto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditarMonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditarMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarMonto.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditarMonto.Location = New System.Drawing.Point(370, 81)
        Me.btnEditarMonto.Name = "btnEditarMonto"
        Me.btnEditarMonto.Size = New System.Drawing.Size(35, 30)
        Me.btnEditarMonto.TabIndex = 46
        Me.btnEditarMonto.UseVisualStyleBackColor = False
        '
        'dgvGrilla2
        '
        Me.dgvGrilla2.AllowUserToAddRows = False
        Me.dgvGrilla2.AllowUserToDeleteRows = False
        Me.dgvGrilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvGrilla2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGrilla2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrilla2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrilla2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvGrilla2.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvGrilla2.EnableHeadersVisualStyles = False
        Me.dgvGrilla2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla2.Location = New System.Drawing.Point(515, 128)
        Me.dgvGrilla2.MultiSelect = False
        Me.dgvGrilla2.Name = "dgvGrilla2"
        Me.dgvGrilla2.ReadOnly = True
        Me.dgvGrilla2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrilla2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrilla2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGrilla2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla2.Size = New System.Drawing.Size(341, 262)
        Me.dgvGrilla2.TabIndex = 48
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvGrilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.Location = New System.Drawing.Point(47, 128)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(354, 262)
        Me.dgvGrilla.TabIndex = 47
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Producto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Stock"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Precio"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'GenerarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.gbxVentas)
        Me.Name = "GenerarVenta"
        Me.Controls.SetChildIndex(Me.gbxVentas, 0)
        Me.Controls.SetChildIndex(Me.gbxOpciones, 0)
        Me.gbxVentas.ResumeLayout(False)
        Me.gbxVentas.PerformLayout()
        Me.gbxOpciones.ResumeLayout(False)
        Me.gbxOpciones.PerformLayout()
        CType(Me.dgvGrilla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxVentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbxOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtMontoT As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnDer As System.Windows.Forms.Button
    Friend WithEvents btnIzq As System.Windows.Forms.Button
    Friend WithEvents btnRestarCant As System.Windows.Forms.Button
    Friend WithEvents btnSumarCant As System.Windows.Forms.Button
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents lblGrilla2 As System.Windows.Forms.Label
    Friend WithEvents lblGrilla As System.Windows.Forms.Label
    Friend WithEvents txtClientes As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEditarMonto As System.Windows.Forms.Button
    Friend WithEvents dgvGrilla2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
