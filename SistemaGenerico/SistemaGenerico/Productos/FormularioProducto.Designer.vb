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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioProducto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRemoverP = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.lstProveedores = New System.Windows.Forms.ListBox()
        Me.btnVerProveedores = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(14, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 403)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(12, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRemoverP)
        Me.GroupBox2.Controls.Add(Me.btnAgregarP)
        Me.GroupBox2.Controls.Add(Me.lstProveedores)
        Me.GroupBox2.Controls.Add(Me.btnVerProveedores)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboProveedores)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(327, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 281)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedores"
        '
        'btnRemoverP
        '
        Me.btnRemoverP.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRemoverP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoverP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemoverP.FlatAppearance.BorderSize = 0
        Me.btnRemoverP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverP.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoverP.Location = New System.Drawing.Point(165, 99)
        Me.btnRemoverP.Name = "btnRemoverP"
        Me.btnRemoverP.Size = New System.Drawing.Size(104, 35)
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
        Me.btnAgregarP.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarP.Location = New System.Drawing.Point(30, 99)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(104, 35)
        Me.btnAgregarP.TabIndex = 22
        Me.btnAgregarP.Text = "AGREGAR"
        Me.btnAgregarP.UseVisualStyleBackColor = False
        '
        'lstProveedores
        '
        Me.lstProveedores.FormattingEnabled = True
        Me.lstProveedores.ItemHeight = 24
        Me.lstProveedores.Location = New System.Drawing.Point(30, 153)
        Me.lstProveedores.Name = "lstProveedores"
        Me.lstProveedores.Size = New System.Drawing.Size(253, 76)
        Me.lstProveedores.TabIndex = 23
        '
        'btnVerProveedores
        '
        Me.btnVerProveedores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVerProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVerProveedores.FlatAppearance.BorderSize = 0
        Me.btnVerProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnVerProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerProveedores.Location = New System.Drawing.Point(275, 54)
        Me.btnVerProveedores.Name = "btnVerProveedores"
        Me.btnVerProveedores.Size = New System.Drawing.Size(40, 29)
        Me.btnVerProveedores.TabIndex = 17
        Me.btnVerProveedores.Text = "Ver"
        Me.btnVerProveedores.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(16, 55)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(253, 28)
        Me.cboProveedores.TabIndex = 22
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
        Me.btnAgregar.Location = New System.Drawing.Point(209, 351)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(252, 35)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "AGREGAR PRODUCTO"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtPrecio.Location = New System.Drawing.Point(30, 223)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(252, 26)
        Me.txtPrecio.TabIndex = 20
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtStock.Location = New System.Drawing.Point(30, 145)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(252, 26)
        Me.txtStock.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtDescripcion.Location = New System.Drawing.Point(30, 61)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(252, 26)
        Me.txtDescripcion.TabIndex = 18
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_usuario.Location = New System.Drawing.Point(26, 38)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(110, 24)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(26, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(44, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio"
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
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Location = New System.Drawing.Point(583, 495)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(103, 35)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'FormularioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 542)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioProducto"
        Me.Text = "FormularioProducto"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnVolver, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnVerProveedores As System.Windows.Forms.Button
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstProveedores As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRemoverP As System.Windows.Forms.Button
    Friend WithEvents btnAgregarP As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
