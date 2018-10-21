<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioUsuario
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
        Me.btneditar = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbtrabajo = New System.Windows.Forms.ComboBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtape = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnagregaresp = New System.Windows.Forms.Button()
        Me.btneditaresp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btneditaresp)
        Me.GroupBox1.Controls.Add(Me.btnagregaresp)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.lblerror)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.cmbtrabajo)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtape)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Gobold Thin Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(35, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 348)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacíon del Usuario"
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
        Me.btneditar.Location = New System.Drawing.Point(183, 277)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(252, 35)
        Me.btneditar.TabIndex = 778
        Me.btneditar.Text = "EDITAR USUARIO"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Tomato
        Me.lblerror.Location = New System.Drawing.Point(52, 255)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 18)
        Me.lblerror.TabIndex = 25
        Me.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(54, 133)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(252, 27)
        Me.txtdni.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(50, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "DNI"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnagregar.Location = New System.Drawing.Point(182, 277)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(252, 35)
        Me.btnagregar.TabIndex = 88
        Me.btnagregar.Text = "AGREGAR USUARIO"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Gobold Thin Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(313, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 26)
        Me.Button3.TabIndex = 777
        Me.Button3.Text = "GESTIONAR TIPOS DE TRABAJO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmbtrabajo
        '
        Me.cmbtrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrabajo.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtrabajo.FormattingEnabled = True
        Me.cmbtrabajo.Location = New System.Drawing.Point(54, 204)
        Me.cmbtrabajo.Name = "cmbtrabajo"
        Me.cmbtrabajo.Size = New System.Drawing.Size(253, 27)
        Me.cmbtrabajo.TabIndex = 6
        '
        'txtmail
        '
        Me.txtmail.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail.Location = New System.Drawing.Point(333, 133)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(253, 27)
        Me.txtmail.TabIndex = 5
        '
        'txtape
        '
        Me.txtape.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtape.Location = New System.Drawing.Point(333, 61)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(252, 27)
        Me.txtape.TabIndex = 3
        '
        'txtnom
        '
        Me.txtnom.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.Location = New System.Drawing.Point(54, 61)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(252, 27)
        Me.txtnom.TabIndex = 2
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_usuario.Location = New System.Drawing.Point(50, 38)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(54, 20)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(329, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(51, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de Trabajo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(330, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mail"
        '
        'btnagregaresp
        '
        Me.btnagregaresp.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnagregaresp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregaresp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnagregaresp.FlatAppearance.BorderSize = 0
        Me.btnagregaresp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregaresp.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregaresp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnagregaresp.Location = New System.Drawing.Point(183, 277)
        Me.btnagregaresp.Name = "btnagregaresp"
        Me.btnagregaresp.Size = New System.Drawing.Size(252, 35)
        Me.btnagregaresp.TabIndex = 779
        Me.btnagregaresp.Text = "AGREGAR USUARIO ESPECIAL"
        Me.btnagregaresp.UseVisualStyleBackColor = False
        '
        'btneditaresp
        '
        Me.btneditaresp.BackColor = System.Drawing.SystemColors.Highlight
        Me.btneditaresp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditaresp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btneditaresp.FlatAppearance.BorderSize = 0
        Me.btneditaresp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditaresp.Font = New System.Drawing.Font("Gobold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditaresp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneditaresp.Location = New System.Drawing.Point(183, 277)
        Me.btneditaresp.Name = "btneditaresp"
        Me.btneditaresp.Size = New System.Drawing.Size(252, 35)
        Me.btneditaresp.TabIndex = 780
        Me.btneditaresp.Text = "EDITAR USUARIO ESPECIAL"
        Me.btneditaresp.UseVisualStyleBackColor = False
        '
        'FormularioUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioUsuario"
        Me.Text = "AgregarUsuario"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbtrabajo As System.Windows.Forms.ComboBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtape As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnagregaresp As System.Windows.Forms.Button
    Friend WithEvents btneditaresp As System.Windows.Forms.Button
End Class
