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
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_tipo_trab = New System.Windows.Forms.Label()
        Me.img_user = New System.Windows.Forms.PictureBox()
        Me.btn_ajustes = New System.Windows.Forms.Button()
        Me.btn_estadisticas = New System.Windows.Forms.Button()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.btn_gastos = New System.Windows.Forms.Button()
        Me.btn_ventas = New System.Windows.Forms.Button()
        Me.btn_compras = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nom_user = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.img_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_cerrar.Location = New System.Drawing.Point(1125, 6)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrar.TabIndex = 0
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.lbl_tipo_trab)
        Me.Panel1.Controls.Add(Me.img_user)
        Me.Panel1.Controls.Add(Me.btn_ajustes)
        Me.Panel1.Controls.Add(Me.btn_estadisticas)
        Me.Panel1.Controls.Add(Me.img_logo)
        Me.Panel1.Controls.Add(Me.btn_gastos)
        Me.Panel1.Controls.Add(Me.btn_ventas)
        Me.Panel1.Controls.Add(Me.btn_compras)
        Me.Panel1.Controls.Add(Me.btn_productos)
        Me.Panel1.Controls.Add(Me.btn_proveedores)
        Me.Panel1.Controls.Add(Me.btn_clientes)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 640)
        Me.Panel1.TabIndex = 1
        '
        'lbl_tipo_trab
        '
        Me.lbl_tipo_trab.AutoSize = True
        Me.lbl_tipo_trab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_tipo_trab.Font = New System.Drawing.Font("Gobold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_trab.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_tipo_trab.Location = New System.Drawing.Point(89, 591)
        Me.lbl_tipo_trab.Name = "lbl_tipo_trab"
        Me.lbl_tipo_trab.Size = New System.Drawing.Size(81, 15)
        Me.lbl_tipo_trab.TabIndex = 10
        Me.lbl_tipo_trab.Text = "administrador"
        '
        'img_user
        '
        Me.img_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.img_user.BackgroundImage = CType(resources.GetObject("img_user.BackgroundImage"), System.Drawing.Image)
        Me.img_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_user.Location = New System.Drawing.Point(12, 567)
        Me.img_user.Name = "img_user"
        Me.img_user.Size = New System.Drawing.Size(70, 60)
        Me.img_user.TabIndex = 8
        Me.img_user.TabStop = False
        '
        'btn_ajustes
        '
        Me.btn_ajustes.BackgroundImage = CType(resources.GetObject("btn_ajustes.BackgroundImage"), System.Drawing.Image)
        Me.btn_ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ajustes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ajustes.FlatAppearance.BorderSize = 0
        Me.btn_ajustes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajustes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajustes.ForeColor = System.Drawing.Color.White
        Me.btn_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ajustes.Location = New System.Drawing.Point(0, 507)
        Me.btn_ajustes.Name = "btn_ajustes"
        Me.btn_ajustes.Size = New System.Drawing.Size(231, 35)
        Me.btn_ajustes.TabIndex = 7
        Me.btn_ajustes.UseVisualStyleBackColor = True
        '
        'btn_estadisticas
        '
        Me.btn_estadisticas.BackgroundImage = CType(resources.GetObject("btn_estadisticas.BackgroundImage"), System.Drawing.Image)
        Me.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_estadisticas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_estadisticas.FlatAppearance.BorderSize = 0
        Me.btn_estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estadisticas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estadisticas.ForeColor = System.Drawing.Color.White
        Me.btn_estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estadisticas.Location = New System.Drawing.Point(0, 466)
        Me.btn_estadisticas.Name = "btn_estadisticas"
        Me.btn_estadisticas.Size = New System.Drawing.Size(231, 35)
        Me.btn_estadisticas.TabIndex = 6
        Me.btn_estadisticas.UseVisualStyleBackColor = True
        '
        'img_logo
        '
        Me.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_logo.Location = New System.Drawing.Point(39, 18)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(157, 146)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 3
        Me.img_logo.TabStop = False
        '
        'btn_gastos
        '
        Me.btn_gastos.BackgroundImage = CType(resources.GetObject("btn_gastos.BackgroundImage"), System.Drawing.Image)
        Me.btn_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_gastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_gastos.FlatAppearance.BorderSize = 0
        Me.btn_gastos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_gastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gastos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gastos.ForeColor = System.Drawing.Color.White
        Me.btn_gastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gastos.Location = New System.Drawing.Point(-1, 425)
        Me.btn_gastos.Name = "btn_gastos"
        Me.btn_gastos.Size = New System.Drawing.Size(231, 35)
        Me.btn_gastos.TabIndex = 5
        Me.btn_gastos.UseVisualStyleBackColor = True
        '
        'btn_ventas
        '
        Me.btn_ventas.BackgroundImage = CType(resources.GetObject("btn_ventas.BackgroundImage"), System.Drawing.Image)
        Me.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ventas.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ventas.FlatAppearance.BorderSize = 0
        Me.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ventas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.Color.White
        Me.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ventas.Location = New System.Drawing.Point(0, 384)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(231, 35)
        Me.btn_ventas.TabIndex = 3
        Me.btn_ventas.UseVisualStyleBackColor = True
        '
        'btn_compras
        '
        Me.btn_compras.BackgroundImage = CType(resources.GetObject("btn_compras.BackgroundImage"), System.Drawing.Image)
        Me.btn_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_compras.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_compras.FlatAppearance.BorderSize = 0
        Me.btn_compras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_compras.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compras.ForeColor = System.Drawing.Color.White
        Me.btn_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_compras.Location = New System.Drawing.Point(0, 343)
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Size = New System.Drawing.Size(231, 35)
        Me.btn_compras.TabIndex = 4
        Me.btn_compras.UseVisualStyleBackColor = True
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_productos.BackgroundImage = CType(resources.GetObject("btn_productos.BackgroundImage"), System.Drawing.Image)
        Me.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_productos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_productos.FlatAppearance.BorderSize = 0
        Me.btn_productos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productos.ForeColor = System.Drawing.Color.White
        Me.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_productos.Location = New System.Drawing.Point(0, 302)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(231, 35)
        Me.btn_productos.TabIndex = 3
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackgroundImage = CType(resources.GetObject("btn_proveedores.BackgroundImage"), System.Drawing.Image)
        Me.btn_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_proveedores.FlatAppearance.BorderSize = 0
        Me.btn_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedores.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.Color.White
        Me.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedores.Location = New System.Drawing.Point(0, 261)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(231, 35)
        Me.btn_proveedores.TabIndex = 2
        Me.btn_proveedores.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.BackgroundImage = CType(resources.GetObject("btn_clientes.BackgroundImage"), System.Drawing.Image)
        Me.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_clientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_clientes.FlatAppearance.BorderSize = 0
        Me.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Location = New System.Drawing.Point(0, 220)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(231, 35)
        Me.btn_clientes.TabIndex = 1
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_inicio
        '
        Me.btn_inicio.BackgroundImage = CType(resources.GetObject("btn_inicio.BackgroundImage"), System.Drawing.Image)
        Me.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_inicio.FlatAppearance.BorderSize = 0
        Me.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio.ForeColor = System.Drawing.Color.Turquoise
        Me.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inicio.Location = New System.Drawing.Point(0, 179)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(231, 35)
        Me.btn_inicio.TabIndex = 0
        Me.btn_inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_inicio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_nom_user)
        Me.Panel2.Location = New System.Drawing.Point(0, 554)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 86)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Gobold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(89, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CERRAR SESIÓN"
        '
        'lbl_nom_user
        '
        Me.lbl_nom_user.AutoSize = True
        Me.lbl_nom_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_nom_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_nom_user.Font = New System.Drawing.Font("Gobold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_nom_user.Location = New System.Drawing.Point(88, 16)
        Me.lbl_nom_user.Name = "lbl_nom_user"
        Me.lbl_nom_user.Size = New System.Drawing.Size(120, 20)
        Me.lbl_nom_user.TabIndex = 4
        Me.lbl_nom_user.Text = "FEDERICO MARKUS"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Gobold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(565, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(309, 41)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo de la Pantalla"
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
        Me.btn_minimizar.Location = New System.Drawing.Point(1099, 6)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimizar.TabIndex = 3
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'MenuBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MenuBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_inicio As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents img_logo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_gastos As System.Windows.Forms.Button
    Friend WithEvents btn_ventas As System.Windows.Forms.Button
    Friend WithEvents btn_compras As System.Windows.Forms.Button
    Friend WithEvents btn_productos As System.Windows.Forms.Button
    Friend WithEvents btn_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents btn_ajustes As System.Windows.Forms.Button
    Friend WithEvents btn_estadisticas As System.Windows.Forms.Button
    Friend WithEvents img_user As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_tipo_trab As System.Windows.Forms.Label
    Friend WithEvents lbl_nom_user As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button

End Class
