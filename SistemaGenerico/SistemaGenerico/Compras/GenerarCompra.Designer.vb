<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarCompra
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarCompra))
        Me.gbxProductos = New System.Windows.Forms.GroupBox()
        Me.dgvProductosCompra = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.idp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnRemoverProducto = New System.Windows.Forms.Button()
        Me.btnRestarCant = New System.Windows.Forms.Button()
        Me.btnSumarCant = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.rdbPendiente = New System.Windows.Forms.RadioButton()
        Me.rdbFinalizada = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxProductos.SuspendLayout()
        CType(Me.dgvProductosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxProductos
        '
        Me.gbxProductos.Controls.Add(Me.dgvProductosCompra)
        Me.gbxProductos.Controls.Add(Me.dgvProductos)
        Me.gbxProductos.Controls.Add(Me.btnAgregarProducto)
        Me.gbxProductos.Controls.Add(Me.btnRemoverProducto)
        Me.gbxProductos.Controls.Add(Me.btnRestarCant)
        Me.gbxProductos.Controls.Add(Me.btnSumarCant)
        Me.gbxProductos.Controls.Add(Me.Label5)
        Me.gbxProductos.Controls.Add(Me.txtCant)
        Me.gbxProductos.Controls.Add(Me.Label3)
        Me.gbxProductos.Controls.Add(Me.Label2)
        Me.gbxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxProductos.Location = New System.Drawing.Point(259, 111)
        Me.gbxProductos.Name = "gbxProductos"
        Me.gbxProductos.Size = New System.Drawing.Size(860, 418)
        Me.gbxProductos.TabIndex = 25
        Me.gbxProductos.TabStop = False
        '
        'dgvProductosCompra
        '
        Me.dgvProductosCompra.AllowUserToAddRows = False
        Me.dgvProductosCompra.AllowUserToDeleteRows = False
        Me.dgvProductosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductosCompra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvProductosCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductosCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProductosCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.desc, Me.cant})
        Me.dgvProductosCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvProductosCompra.EnableHeadersVisualStyles = False
        Me.dgvProductosCompra.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductosCompra.Location = New System.Drawing.Point(500, 77)
        Me.dgvProductosCompra.MultiSelect = False
        Me.dgvProductosCompra.Name = "dgvProductosCompra"
        Me.dgvProductosCompra.ReadOnly = True
        Me.dgvProductosCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductosCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvProductosCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductosCompra.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvProductosCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProductosCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosCompra.Size = New System.Drawing.Size(344, 319)
        Me.dgvProductosCompra.TabIndex = 39
        '
        'id
        '
        Me.id.FillWeight = 76.14214!
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'desc
        '
        Me.desc.FillWeight = 111.9289!
        Me.desc.HeaderText = "Descripcion"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'cant
        '
        Me.cant.FillWeight = 111.9289!
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idp, Me.descr, Me.stock})
        Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos.Location = New System.Drawing.Point(23, 74)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProductos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(344, 319)
        Me.dgvProductos.TabIndex = 38
        '
        'idp
        '
        Me.idp.FillWeight = 76.14214!
        Me.idp.HeaderText = "ID"
        Me.idp.Name = "idp"
        Me.idp.ReadOnly = True
        '
        'descr
        '
        Me.descr.FillWeight = 111.9289!
        Me.descr.HeaderText = "Descripcion"
        Me.descr.Name = "descr"
        Me.descr.ReadOnly = True
        '
        'stock
        '
        Me.stock.FillWeight = 111.9289!
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.BackgroundImage = CType(resources.GetObject("btnAgregarProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarProducto.Location = New System.Drawing.Point(416, 156)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(38, 70)
        Me.btnAgregarProducto.TabIndex = 36
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'btnRemoverProducto
        '
        Me.btnRemoverProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoverProducto.BackgroundImage = CType(resources.GetObject("btnRemoverProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoverProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoverProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemoverProducto.FlatAppearance.BorderSize = 0
        Me.btnRemoverProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRemoverProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemoverProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemoverProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverProducto.ForeColor = System.Drawing.Color.Transparent
        Me.btnRemoverProducto.Location = New System.Drawing.Point(414, 232)
        Me.btnRemoverProducto.Name = "btnRemoverProducto"
        Me.btnRemoverProducto.Size = New System.Drawing.Size(40, 70)
        Me.btnRemoverProducto.TabIndex = 35
        Me.btnRemoverProducto.UseVisualStyleBackColor = False
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
        Me.btnRestarCant.Location = New System.Drawing.Point(383, 76)
        Me.btnRestarCant.Name = "btnRestarCant"
        Me.btnRestarCant.Size = New System.Drawing.Size(25, 25)
        Me.btnRestarCant.TabIndex = 34
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
        Me.btnSumarCant.Location = New System.Drawing.Point(458, 77)
        Me.btnSumarCant.Name = "btnSumarCant"
        Me.btnSumarCant.Size = New System.Drawing.Size(25, 25)
        Me.btnSumarCant.TabIndex = 33
        Me.btnSumarCant.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(393, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Cantidad"
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCant.Location = New System.Drawing.Point(416, 76)
        Me.txtCant.MaxLength = 3
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(38, 26)
        Me.txtCant.TabIndex = 31
        Me.txtCant.Text = "1"
        Me.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(594, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Productos a comprar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(78, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Productos de proveedor "
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtMonto.Location = New System.Drawing.Point(867, 539)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(125, 26)
        Me.txtMonto.TabIndex = 27
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblMonto.ForeColor = System.Drawing.Color.Orange
        Me.lblMonto.Location = New System.Drawing.Point(755, 543)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(106, 24)
        Me.lblMonto.TabIndex = 28
        Me.lblMonto.Text = "Monto total:"
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(259, 77)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(253, 28)
        Me.cboProveedores.TabIndex = 22
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblBuscar.ForeColor = System.Drawing.Color.Orange
        Me.lblBuscar.Location = New System.Drawing.Point(255, 50)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(98, 24)
        Me.lblBuscar.TabIndex = 19
        Me.lblBuscar.Text = "Proveedor"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegistrar.Location = New System.Drawing.Point(595, 580)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(201, 37)
        Me.btnRegistrar.TabIndex = 29
        Me.btnRegistrar.Text = "REGISTRAR COMPRA"
        Me.btnRegistrar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(595, 580)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(201, 37)
        Me.btnEditar.TabIndex = 31
        Me.btnEditar.Text = "GUARDAR CAMBIOS"
        Me.btnEditar.UseVisualStyleBackColor = False
        Me.btnEditar.Visible = False
        '
        'rdbPendiente
        '
        Me.rdbPendiente.AutoSize = True
        Me.rdbPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPendiente.ForeColor = System.Drawing.Color.Orange
        Me.rdbPendiente.Location = New System.Drawing.Point(518, 78)
        Me.rdbPendiente.Name = "rdbPendiente"
        Me.rdbPendiente.Size = New System.Drawing.Size(108, 24)
        Me.rdbPendiente.TabIndex = 32
        Me.rdbPendiente.TabStop = True
        Me.rdbPendiente.Text = "Pendiente"
        Me.rdbPendiente.UseVisualStyleBackColor = True
        '
        'rdbFinalizada
        '
        Me.rdbFinalizada.AutoSize = True
        Me.rdbFinalizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdbFinalizada.ForeColor = System.Drawing.Color.Orange
        Me.rdbFinalizada.Location = New System.Drawing.Point(632, 79)
        Me.rdbFinalizada.Name = "rdbFinalizada"
        Me.rdbFinalizada.Size = New System.Drawing.Size(109, 24)
        Me.rdbFinalizada.TabIndex = 33
        Me.rdbFinalizada.TabStop = True
        Me.rdbFinalizada.Text = "Finalizada"
        Me.rdbFinalizada.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(791, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Location = New System.Drawing.Point(866, 81)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(253, 23)
        Me.dtpFecha.TabIndex = 35
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'GenerarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdbFinalizada)
        Me.Controls.Add(Me.rdbPendiente)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.gbxProductos)
        Me.Controls.Add(Me.cboProveedores)
        Me.Controls.Add(Me.lblBuscar)
        Me.Name = "GenerarCompra"
        Me.Text = "GenerarCompra"
        Me.Controls.SetChildIndex(Me.lblBuscar, 0)
        Me.Controls.SetChildIndex(Me.cboProveedores, 0)
        Me.Controls.SetChildIndex(Me.gbxProductos, 0)
        Me.Controls.SetChildIndex(Me.lblMonto, 0)
        Me.Controls.SetChildIndex(Me.btnRegistrar, 0)
        Me.Controls.SetChildIndex(Me.txtMonto, 0)
        Me.Controls.SetChildIndex(Me.btnEditar, 0)
        Me.Controls.SetChildIndex(Me.rdbPendiente, 0)
        Me.Controls.SetChildIndex(Me.rdbFinalizada, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.gbxProductos.ResumeLayout(False)
        Me.gbxProductos.PerformLayout()
        CType(Me.dgvProductosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxProductos As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents rdbPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFinalizada As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents btnRestarCant As System.Windows.Forms.Button
    Friend WithEvents btnSumarCant As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents btnRemoverProducto As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents idProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProductosCompra As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
