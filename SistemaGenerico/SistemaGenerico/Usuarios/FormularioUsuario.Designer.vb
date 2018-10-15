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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtape = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtape)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Gobold Thin Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(170, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 366)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacíon del Usuario"
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
        Me.Button1.Text = "AGREGAR USUARIO"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(203, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 26)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "agregar trabajo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Gobold Thin Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(53, 267)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(253, 29)
        Me.ComboBox1.TabIndex = 22
        '
        'txtmail
        '
        Me.txtmail.Font = New System.Drawing.Font("Gobold Thin Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail.Location = New System.Drawing.Point(53, 189)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(253, 28)
        Me.txtmail.TabIndex = 20
        '
        'txtape
        '
        Me.txtape.Font = New System.Drawing.Font("Gobold Thin Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtape.Location = New System.Drawing.Point(54, 125)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(252, 28)
        Me.txtape.TabIndex = 19
        '
        'txtnom
        '
        Me.txtnom.Font = New System.Drawing.Font("Gobold Thin Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.Location = New System.Drawing.Point(54, 61)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(252, 28)
        Me.txtnom.TabIndex = 18
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
        Me.Label4.Location = New System.Drawing.Point(50, 102)
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
        Me.Label3.Location = New System.Drawing.Point(50, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trabajo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gobold Thin Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(50, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mail"
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
        Me.btneditar.Location = New System.Drawing.Point(583, 480)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(103, 35)
        Me.btneditar.TabIndex = 18
        Me.btneditar.Text = "VOLVER"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'FormularioUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 527)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioUsuario"
        Me.Text = "AgregarUsuario"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btneditar, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtape As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
End Class
