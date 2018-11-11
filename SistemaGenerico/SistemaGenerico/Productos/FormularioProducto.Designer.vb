<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProducto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioProducto))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnRemoverP = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.lstProveedores = New System.Windows.Forms.ListBox()
        Me.btnVerProveedores = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPuntoP = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imgError = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(207, 36)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(252, 35)
        Me.btnEditar.TabIndex = 26
        Me.btnEditar.Text = "EDITAR PRODUCTO"
        Me.btnEditar.UseVisualStyleBackColor = False
        Me.btnEditar.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Tomato
        Me.lblError.Location = New System.Drawing.Point(55, 10)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 20)
        Me.lblError.TabIndex = 25
        '
        'btnRemoverP
        '
        Me.btnRemoverP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRemoverP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoverP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemoverP.FlatAppearance.BorderSize = 0
        Me.btnRemoverP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverP.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoverP.Location = New System.Drawing.Point(184, 114)
        Me.btnRemoverP.Name = "btnRemoverP"
        Me.btnRemoverP.Size = New System.Drawing.Size(130, 35)
        Me.btnRemoverP.TabIndex = 24
        Me.btnRemoverP.Text = "REMOVER"
        Me.btnRemoverP.UseVisualStyleBackColor = False
        '
        'btnAgregarP
        '
        Me.btnAgregarP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarP.FlatAppearance.BorderSize = 0
        Me.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarP.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarP.Location = New System.Drawing.Point(26, 114)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(130, 35)
        Me.btnAgregarP.TabIndex = 6
        Me.btnAgregarP.Text = "AGREGAR"
        Me.btnAgregarP.UseVisualStyleBackColor = False
        '
        'lstProveedores
        '
        Me.lstProveedores.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProveedores.FormattingEnabled = True
        Me.lstProveedores.ItemHeight = 20
        Me.lstProveedores.Location = New System.Drawing.Point(26, 168)
        Me.lstProveedores.Name = "lstProveedores"
        Me.lstProveedores.Size = New System.Drawing.Size(288, 104)
        Me.lstProveedores.TabIndex = 23
        '
        'btnVerProveedores
        '
        Me.btnVerProveedores.BackColor = System.Drawing.Color.Transparent
        Me.btnVerProveedores.BackgroundImage = CType(resources.GetObject("btnVerProveedores.BackgroundImage"), System.Drawing.Image)
        Me.btnVerProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVerProveedores.FlatAppearance.BorderSize = 0
        Me.btnVerProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnVerProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerProveedores.Location = New System.Drawing.Point(292, 44)
        Me.btnVerProveedores.Name = "btnVerProveedores"
        Me.btnVerProveedores.Size = New System.Drawing.Size(22, 20)
        Me.btnVerProveedores.TabIndex = 17
        Me.btnVerProveedores.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del Proveedor"
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(25, 65)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(289, 28)
        Me.cboProveedores.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(207, 36)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(252, 35)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "AGREGAR PRODUCTO"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(54, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "AGREGAR PRODUCTO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.btnRemoverP)
        Me.Panel6.Controls.Add(Me.btnAgregarP)
        Me.Panel6.Controls.Add(Me.lstProveedores)
        Me.Panel6.Controls.Add(Me.btnVerProveedores)
        Me.Panel6.Controls.Add(Me.cboProveedores)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(343, 93)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(339, 299)
        Me.Panel6.TabIndex = 61
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 782
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.CausesValidation = False
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(7, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 23)
        Me.Label6.TabIndex = 782
        Me.Label6.Text = "Datos de los Proveedores"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPuntoP)
        Me.Panel1.Controls.Add(Me.lbl_usuario)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Location = New System.Drawing.Point(21, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 299)
        Me.Panel1.TabIndex = 779
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(23, 168)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 785
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(23, 107)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 784
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 783
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(23, 49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 781
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 23)
        Me.Label2.TabIndex = 781
        Me.Label2.Text = "Datos del Producto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 68)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(252, 26)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(39, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock"
        '
        'txtPuntoP
        '
        Me.txtPuntoP.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuntoP.Location = New System.Drawing.Point(23, 189)
        Me.txtPuntoP.Name = "txtPuntoP"
        Me.txtPuntoP.Size = New System.Drawing.Size(252, 26)
        Me.txtPuntoP.TabIndex = 3
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_usuario.Location = New System.Drawing.Point(40, 46)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(142, 20)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Nombre del Producto"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(23, 128)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(252, 26)
        Me.txtStock.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(39, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Punto de Pedido"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(23, 250)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(252, 26)
        Me.txtPrecio.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Controls.Add(Me.imgError)
        Me.Panel2.Controls.Add(Me.btnEditar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Location = New System.Drawing.Point(21, 398)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 89)
        Me.Panel2.TabIndex = 780
        '
        'imgError
        '
        Me.imgError.Image = CType(resources.GetObject("imgError.Image"), System.Drawing.Image)
        Me.imgError.Location = New System.Drawing.Point(32, 13)
        Me.imgError.Name = "imgError"
        Me.imgError.Size = New System.Drawing.Size(17, 17)
        Me.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgError.TabIndex = 787
        Me.imgError.TabStop = False
        Me.imgError.Visible = False
        '
        'FormularioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 542)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormularioProducto"
        Me.Text = "FormularioProducto"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel6, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnVerProveedores As System.Windows.Forms.Button
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstProveedores As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRemoverP As System.Windows.Forms.Button
    Friend WithEvents btnAgregarP As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgError As System.Windows.Forms.PictureBox
End Class
