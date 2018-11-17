<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contra = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnver = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.imgError = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.img_logo)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 311)
        Me.Panel1.TabIndex = 0
        '
        'img_logo
        '
        Me.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_logo.Location = New System.Drawing.Point(39, 47)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(220, 208)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 0
        Me.img_logo.TabStop = False
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_usuario.Location = New System.Drawing.Point(405, 78)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(69, 23)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_contra
        '
        Me.lbl_contra.AutoSize = True
        Me.lbl_contra.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_contra.Location = New System.Drawing.Point(408, 144)
        Me.lbl_contra.Name = "lbl_contra"
        Me.lbl_contra.Size = New System.Drawing.Size(98, 23)
        Me.lbl_contra.TabIndex = 2
        Me.lbl_contra.Text = "Contraseña"
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(386, 102)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(241, 29)
        Me.txtusuario.TabIndex = 1
        Me.txtusuario.Text = "admin"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(386, 169)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcontraseña.Size = New System.Drawing.Size(241, 29)
        Me.txtcontraseña.TabIndex = 2
        Me.txtcontraseña.Text = "admin1234"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(380, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INICIO DE SESIÓN"
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
        Me.btn_minimizar.Location = New System.Drawing.Point(652, 6)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimizar.TabIndex = 6
        Me.btn_minimizar.UseVisualStyleBackColor = False
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
        Me.btn_cerrar.Location = New System.Drawing.Point(678, 6)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(20, 20)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(386, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INICIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(536, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnver
        '
        Me.btnver.BackColor = System.Drawing.Color.Transparent
        Me.btnver.BackgroundImage = CType(resources.GetObject("btnver.BackgroundImage"), System.Drawing.Image)
        Me.btnver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnver.FlatAppearance.BorderSize = 0
        Me.btnver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnver.Location = New System.Drawing.Point(633, 172)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(28, 23)
        Me.btnver.TabIndex = 3
        Me.btnver.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Tomato
        Me.lblerror.Location = New System.Drawing.Point(412, 211)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 18)
        Me.lblerror.TabIndex = 11
        Me.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(386, 79)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 792
        Me.PictureBox4.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(387, 146)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 793
        Me.PictureBox9.TabStop = False
        '
        'imgError
        '
        Me.imgError.Image = CType(resources.GetObject("imgError.Image"), System.Drawing.Image)
        Me.imgError.Location = New System.Drawing.Point(389, 211)
        Me.imgError.Name = "imgError"
        Me.imgError.Size = New System.Drawing.Size(17, 17)
        Me.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgError.TabIndex = 794
        Me.imgError.TabStop = False
        Me.imgError.Visible = False
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(702, 300)
        Me.Controls.Add(Me.imgError)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.lbl_contra)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioSesion"
        Me.Panel1.ResumeLayout(False)
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents img_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_contra As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents imgError As System.Windows.Forms.PictureBox
End Class
