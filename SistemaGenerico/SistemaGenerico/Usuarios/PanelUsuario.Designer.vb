<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelUsuario))
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lbltrabajo = New System.Windows.Forms.Label()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndescartar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtape = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btncambios = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnver = New System.Windows.Forms.Button()
        Me.lblerror2 = New System.Windows.Forms.Label()
        Me.txtnuevacontrarep = New System.Windows.Forms.TextBox()
        Me.txtnuevacontra = New System.Windows.Forms.TextBox()
        Me.txtviejacontra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.Orange
        Me.lbl_usuario.Location = New System.Drawing.Point(51, 42)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(54, 20)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(51, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trabajo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(51, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(51, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mail"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnombre.Location = New System.Drawing.Point(51, 62)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(74, 23)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "Federico"
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblapellido.Location = New System.Drawing.Point(51, 127)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(65, 23)
        Me.lblapellido.TabIndex = 10
        Me.lblapellido.Text = "Markus"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblmail.Location = New System.Drawing.Point(51, 196)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(217, 23)
        Me.lblmail.TabIndex = 11
        Me.lblmail.Text = "federicomarkus@gmail.com"
        '
        'lbltrabajo
        '
        Me.lbltrabajo.AutoSize = True
        Me.lbltrabajo.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrabajo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltrabajo.Location = New System.Drawing.Point(51, 328)
        Me.lbltrabajo.Name = "lbltrabajo"
        Me.lbltrabajo.Size = New System.Drawing.Size(0, 23)
        Me.lbltrabajo.TabIndex = 12
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneditar.Location = New System.Drawing.Point(130, 403)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(103, 35)
        Me.btneditar.TabIndex = 6
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(54, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CAMBIAR CONTRASEÑA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndescartar)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblerror)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtape)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.lbltrabajo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblmail)
        Me.GroupBox1.Controls.Add(Me.lblapellido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btncambios)
        Me.GroupBox1.Font = New System.Drawing.Font("Gobold Thin Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(332, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 479)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacíon del Usuario"
        '
        'btndescartar
        '
        Me.btndescartar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btndescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndescartar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btndescartar.FlatAppearance.BorderSize = 0
        Me.btndescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescartar.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndescartar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndescartar.Location = New System.Drawing.Point(55, 428)
        Me.btndescartar.Name = "btndescartar"
        Me.btndescartar.Size = New System.Drawing.Size(242, 35)
        Me.btndescartar.TabIndex = 8
        Me.btndescartar.Text = "DESCARTAR CAMBIOS"
        Me.btndescartar.UseVisualStyleBackColor = False
        Me.btndescartar.Visible = False
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(55, 262)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(250, 27)
        Me.txtdni.TabIndex = 5
        Me.txtdni.Visible = False
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldni.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbldni.Location = New System.Drawing.Point(51, 260)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(0, 23)
        Me.lbldni.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(51, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DNI"
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Tomato
        Me.lblerror.Location = New System.Drawing.Point(52, 356)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 18)
        Me.lblerror.TabIndex = 17
        Me.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmail
        '
        Me.txtmail.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail.Location = New System.Drawing.Point(55, 198)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(250, 27)
        Me.txtmail.TabIndex = 4
        Me.txtmail.Visible = False
        '
        'txtape
        '
        Me.txtape.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtape.Location = New System.Drawing.Point(55, 130)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(250, 27)
        Me.txtape.TabIndex = 3
        Me.txtape.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(55, 65)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(250, 27)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.Visible = False
        '
        'btncambios
        '
        Me.btncambios.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncambios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncambios.FlatAppearance.BorderSize = 0
        Me.btncambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncambios.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncambios.Location = New System.Drawing.Point(55, 380)
        Me.btncambios.Name = "btncambios"
        Me.btncambios.Size = New System.Drawing.Size(242, 35)
        Me.btncambios.TabIndex = 7
        Me.btncambios.Text = "CONFIRMAR CAMBIOS"
        Me.btncambios.UseVisualStyleBackColor = False
        Me.btncambios.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnver)
        Me.GroupBox2.Controls.Add(Me.lblerror2)
        Me.GroupBox2.Controls.Add(Me.txtnuevacontrarep)
        Me.GroupBox2.Controls.Add(Me.txtnuevacontra)
        Me.GroupBox2.Controls.Add(Me.txtviejacontra)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Gobold Thin Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(725, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 351)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambiar Contraseña"
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
        Me.btnver.Location = New System.Drawing.Point(288, 297)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(28, 23)
        Me.btnver.TabIndex = 17
        Me.btnver.UseVisualStyleBackColor = False
        '
        'lblerror2
        '
        Me.lblerror2.AutoSize = True
        Me.lblerror2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror2.ForeColor = System.Drawing.Color.Tomato
        Me.lblerror2.Location = New System.Drawing.Point(51, 241)
        Me.lblerror2.Name = "lblerror2"
        Me.lblerror2.Size = New System.Drawing.Size(0, 18)
        Me.lblerror2.TabIndex = 26
        Me.lblerror2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnuevacontrarep
        '
        Me.txtnuevacontrarep.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnuevacontrarep.Location = New System.Drawing.Point(54, 204)
        Me.txtnuevacontrarep.Name = "txtnuevacontrarep"
        Me.txtnuevacontrarep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtnuevacontrarep.Size = New System.Drawing.Size(219, 27)
        Me.txtnuevacontrarep.TabIndex = 12
        '
        'txtnuevacontra
        '
        Me.txtnuevacontra.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnuevacontra.Location = New System.Drawing.Point(54, 134)
        Me.txtnuevacontra.Name = "txtnuevacontra"
        Me.txtnuevacontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtnuevacontra.Size = New System.Drawing.Size(219, 27)
        Me.txtnuevacontra.TabIndex = 11
        '
        'txtviejacontra
        '
        Me.txtviejacontra.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtviejacontra.Location = New System.Drawing.Point(54, 67)
        Me.txtviejacontra.Name = "txtviejacontra"
        Me.txtviejacontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtviejacontra.Size = New System.Drawing.Size(219, 27)
        Me.txtviejacontra.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Orange
        Me.Label9.Location = New System.Drawing.Point(50, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Vieja Contraseña"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Orange
        Me.Label13.Location = New System.Drawing.Point(50, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Repetir Nueva Contraseña"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Orange
        Me.Label16.Location = New System.Drawing.Point(50, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 20)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Nueva Contraseña"
        '
        'PanelUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PanelUsuario"
        Me.Text = "Usuario"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblapellido As System.Windows.Forms.Label
    Friend WithEvents lblmail As System.Windows.Forms.Label
    Friend WithEvents lbltrabajo As System.Windows.Forms.Label
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnuevacontrarep As System.Windows.Forms.TextBox
    Friend WithEvents txtnuevacontra As System.Windows.Forms.TextBox
    Friend WithEvents txtviejacontra As System.Windows.Forms.TextBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtape As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents btncambios As System.Windows.Forms.Button
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents btndescartar As System.Windows.Forms.Button
    Friend WithEvents lblerror2 As System.Windows.Forms.Label
    Friend WithEvents btnver As System.Windows.Forms.Button
End Class
