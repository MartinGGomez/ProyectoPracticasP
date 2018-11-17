<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBase
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuBase))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ajustes = New System.Windows.Forms.Button()
        Me.btn_estadisticas = New System.Windows.Forms.Button()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.btn_gastos = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_ventas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_tipo_trab = New System.Windows.Forms.Label()
        Me.img_user = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nom_user = New System.Windows.Forms.Label()
        Me.btn_compras = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.img_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_ajustes)
        Me.Panel1.Controls.Add(Me.btn_estadisticas)
        Me.Panel1.Controls.Add(Me.img_logo)
        Me.Panel1.Controls.Add(Me.btn_gastos)
        Me.Panel1.Controls.Add(Me.btn_productos)
        Me.Panel1.Controls.Add(Me.btn_ventas)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_compras)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.btn_clientes)
        Me.Panel1.Controls.Add(Me.btn_proveedores)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 640)
        Me.Panel1.TabIndex = 1
        '
        'btn_ajustes
        '
        Me.btn_ajustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ajustes.BackgroundImage = CType(resources.GetObject("btn_ajustes.BackgroundImage"), System.Drawing.Image)
        Me.btn_ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ajustes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ajustes.FlatAppearance.BorderSize = 0
        Me.btn_ajustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajustes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajustes.ForeColor = System.Drawing.Color.White
        Me.btn_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajustes.Location = New System.Drawing.Point(0, 506)
        Me.btn_ajustes.Name = "btn_ajustes"
        Me.btn_ajustes.Size = New System.Drawing.Size(231, 35)
        Me.btn_ajustes.TabIndex = 17
        Me.btn_ajustes.Tag = "59"
        Me.btn_ajustes.UseVisualStyleBackColor = False
        '
        'btn_estadisticas
        '
        Me.btn_estadisticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_estadisticas.BackgroundImage = CType(resources.GetObject("btn_estadisticas.BackgroundImage"), System.Drawing.Image)
        Me.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_estadisticas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_estadisticas.FlatAppearance.BorderSize = 0
        Me.btn_estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estadisticas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estadisticas.ForeColor = System.Drawing.Color.White
        Me.btn_estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estadisticas.Location = New System.Drawing.Point(0, 465)
        Me.btn_estadisticas.Name = "btn_estadisticas"
        Me.btn_estadisticas.Size = New System.Drawing.Size(231, 35)
        Me.btn_estadisticas.TabIndex = 16
        Me.btn_estadisticas.Tag = "58"
        Me.btn_estadisticas.UseVisualStyleBackColor = False
        '
        'img_logo
        '
        Me.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_logo.Location = New System.Drawing.Point(36, 12)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(158, 151)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 3
        Me.img_logo.TabStop = False
        Me.img_logo.Tag = "50"
        '
        'btn_gastos
        '
        Me.btn_gastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_gastos.BackgroundImage = CType(resources.GetObject("btn_gastos.BackgroundImage"), System.Drawing.Image)
        Me.btn_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_gastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_gastos.FlatAppearance.BorderSize = 0
        Me.btn_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_gastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gastos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gastos.ForeColor = System.Drawing.Color.White
        Me.btn_gastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gastos.Location = New System.Drawing.Point(-1, 424)
        Me.btn_gastos.Name = "btn_gastos"
        Me.btn_gastos.Size = New System.Drawing.Size(231, 35)
        Me.btn_gastos.TabIndex = 15
        Me.btn_gastos.Tag = "57"
        Me.btn_gastos.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_productos.BackgroundImage = CType(resources.GetObject("btn_productos.BackgroundImage"), System.Drawing.Image)
        Me.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_productos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_productos.FlatAppearance.BorderSize = 0
        Me.btn_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.Color.White
        Me.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_productos.Location = New System.Drawing.Point(0, 301)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(231, 35)
        Me.btn_productos.TabIndex = 11
        Me.btn_productos.Tag = "54"
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ventas.BackgroundImage = CType(resources.GetObject("btn_ventas.BackgroundImage"), System.Drawing.Image)
        Me.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ventas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ventas.FlatAppearance.BorderSize = 0
        Me.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ventas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.Color.White
        Me.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ventas.Location = New System.Drawing.Point(0, 383)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(231, 35)
        Me.btn_ventas.TabIndex = 12
        Me.btn_ventas.Tag = "56"
        Me.btn_ventas.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_tipo_trab)
        Me.Panel3.Controls.Add(Me.img_user)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lbl_nom_user)
        Me.Panel3.Location = New System.Drawing.Point(0, 553)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 86)
        Me.Panel3.TabIndex = 14
        '
        'lbl_tipo_trab
        '
        Me.lbl_tipo_trab.AutoSize = True
        Me.lbl_tipo_trab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_tipo_trab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_tipo_trab.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_trab.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_tipo_trab.Location = New System.Drawing.Point(87, 34)
        Me.lbl_tipo_trab.Name = "lbl_tipo_trab"
        Me.lbl_tipo_trab.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tipo_trab.TabIndex = 12
        '
        'img_user
        '
        Me.img_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.img_user.BackgroundImage = CType(resources.GetObject("img_user.BackgroundImage"), System.Drawing.Image)
        Me.img_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_user.Location = New System.Drawing.Point(12, 12)
        Me.img_user.Name = "img_user"
        Me.img_user.Size = New System.Drawing.Size(70, 60)
        Me.img_user.TabIndex = 9
        Me.img_user.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(87, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CERRAR SESIÓN"
        '
        'lbl_nom_user
        '
        Me.lbl_nom_user.AutoSize = True
        Me.lbl_nom_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_nom_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_nom_user.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_nom_user.Location = New System.Drawing.Point(87, 13)
        Me.lbl_nom_user.Name = "lbl_nom_user"
        Me.lbl_nom_user.Size = New System.Drawing.Size(0, 20)
        Me.lbl_nom_user.TabIndex = 4
        '
        'btn_compras
        '
        Me.btn_compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_compras.BackgroundImage = CType(resources.GetObject("btn_compras.BackgroundImage"), System.Drawing.Image)
        Me.btn_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_compras.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_compras.FlatAppearance.BorderSize = 0
        Me.btn_compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_compras.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compras.ForeColor = System.Drawing.Color.White
        Me.btn_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_compras.Location = New System.Drawing.Point(0, 342)
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Size = New System.Drawing.Size(231, 35)
        Me.btn_compras.TabIndex = 13
        Me.btn_compras.Tag = "55"
        Me.btn_compras.UseVisualStyleBackColor = False
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_inicio.BackgroundImage = CType(resources.GetObject("btn_inicio.BackgroundImage"), System.Drawing.Image)
        Me.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_inicio.FlatAppearance.BorderSize = 0
        Me.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio.ForeColor = System.Drawing.Color.Turquoise
        Me.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inicio.Location = New System.Drawing.Point(0, 178)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(231, 35)
        Me.btn_inicio.TabIndex = 8
        Me.btn_inicio.Tag = "51"
        Me.btn_inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_clientes.BackgroundImage = CType(resources.GetObject("btn_clientes.BackgroundImage"), System.Drawing.Image)
        Me.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_clientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_clientes.FlatAppearance.BorderSize = 0
        Me.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Location = New System.Drawing.Point(0, 219)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(231, 35)
        Me.btn_clientes.TabIndex = 9
        Me.btn_clientes.Tag = "52"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_proveedores.BackgroundImage = CType(resources.GetObject("btn_proveedores.BackgroundImage"), System.Drawing.Image)
        Me.btn_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_proveedores.FlatAppearance.BorderSize = 0
        Me.btn_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedores.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.Color.White
        Me.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedores.Location = New System.Drawing.Point(0, 260)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(231, 35)
        Me.btn_proveedores.TabIndex = 10
        Me.btn_proveedores.Tag = "53"
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(35, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(157, 23)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo de la pantalla"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_minimizar)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btn_cerrar)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(230, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 40)
        Me.Panel2.TabIndex = 5
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImage = CType(resources.GetObject("btn_minimizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(865, 10)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimizar.TabIndex = 7
        Me.btn_minimizar.Tag = "60"
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.BackgroundImage = CType(resources.GetObject("btn_cerrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Location = New System.Drawing.Point(891, 10)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.Tag = "61"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'MenuBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MenuBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.img_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents img_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ajustes As System.Windows.Forms.Button
    Friend WithEvents btn_estadisticas As System.Windows.Forms.Button
    Friend WithEvents btn_gastos As System.Windows.Forms.Button
    Friend WithEvents btn_productos As System.Windows.Forms.Button
    Friend WithEvents btn_ventas As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nom_user As System.Windows.Forms.Label
    Friend WithEvents btn_compras As System.Windows.Forms.Button
    Friend WithEvents btn_inicio As System.Windows.Forms.Button
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents btn_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipo_trab As System.Windows.Forms.Label
    Friend WithEvents img_user As System.Windows.Forms.PictureBox

End Class
