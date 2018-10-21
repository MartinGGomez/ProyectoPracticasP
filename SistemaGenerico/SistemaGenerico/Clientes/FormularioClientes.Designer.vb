<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioClientes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDNICliente = New System.Windows.Forms.TextBox()
        Me.lblNombreProv = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtDNICliente)
        Me.GroupBox1.Controls.Add(Me.lblNombreProv)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 356)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Cliente"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtApellido.Location = New System.Drawing.Point(30, 214)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(302, 26)
        Me.txtApellido.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(26, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtNombre.Location = New System.Drawing.Point(30, 139)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(302, 26)
        Me.txtNombre.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Tomato
        Me.lblError.Location = New System.Drawing.Point(26, 268)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(68, 22)
        Me.lblError.TabIndex = 24
        Me.lblError.Text = "lblError"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtDireccion.Location = New System.Drawing.Point(353, 139)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(302, 26)
        Me.txtDireccion.TabIndex = 23
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDireccion.Location = New System.Drawing.Point(349, 112)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(90, 24)
        Me.lblDireccion.TabIndex = 22
        Me.lblDireccion.Text = "Direccion"
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
        Me.btnAgregar.Location = New System.Drawing.Point(214, 301)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(252, 35)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "AGREGAR CLIENTE"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtMail.Location = New System.Drawing.Point(353, 214)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(302, 26)
        Me.txtMail.TabIndex = 20
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtTel.Location = New System.Drawing.Point(353, 68)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(302, 26)
        Me.txtTel.TabIndex = 19
        '
        'txtDNICliente
        '
        Me.txtDNICliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.txtDNICliente.Location = New System.Drawing.Point(30, 68)
        Me.txtDNICliente.Name = "txtDNICliente"
        Me.txtDNICliente.Size = New System.Drawing.Size(302, 26)
        Me.txtDNICliente.TabIndex = 18
        '
        'lblNombreProv
        '
        Me.lblNombreProv.AutoSize = True
        Me.lblNombreProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblNombreProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreProv.Location = New System.Drawing.Point(26, 45)
        Me.lblNombreProv.Name = "lblNombreProv"
        Me.lblNombreProv.Size = New System.Drawing.Size(41, 24)
        Me.lblNombreProv.TabIndex = 4
        Me.lblNombreProv.Text = "DNI"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTel.Location = New System.Drawing.Point(349, 45)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(85, 24)
        Me.lblTel.TabIndex = 7
        Me.lblTel.Text = "Telefono"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMail.Location = New System.Drawing.Point(349, 187)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(44, 24)
        Me.lblMail.TabIndex = 8
        Me.lblMail.Text = "Mail"
        '
        'FormularioClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioClientes"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtDNICliente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreProv As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
End Class
