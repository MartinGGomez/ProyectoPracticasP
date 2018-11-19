<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gastos))
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarGasto = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cboGastos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel17.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Label2)
        Me.Panel17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel17.Location = New System.Drawing.Point(240, 77)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(440, 259)
        Me.Panel17.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(137, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GRAFICO"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel7.Location = New System.Drawing.Point(240, 359)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(440, 259)
        Me.Panel7.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(150, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "GRAFICO"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(701, 359)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(440, 259)
        Me.Panel6.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(163, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "GRAFICO"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnEditar)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.dtpFecha)
        Me.Panel5.Controls.Add(Me.btnAgregarGasto)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtMonto)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.cboGastos)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(700, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(440, 259)
        Me.Panel5.TabIndex = 54
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(115, 197)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(196, 35)
        Me.btnEditar.TabIndex = 797
        Me.btnEditar.Text = "REGISTRAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(192, 121)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 796
        Me.PictureBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(213, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 795
        Me.Label8.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(192, 142)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(161, 26)
        Me.dtpFecha.TabIndex = 794
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarGasto.BackgroundImage = CType(resources.GetObject("btnAgregarGasto.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarGasto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarGasto.FlatAppearance.BorderSize = 0
        Me.btnAgregarGasto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarGasto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarGasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAgregarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGasto.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarGasto.Location = New System.Drawing.Point(359, 85)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(25, 25)
        Me.btnAgregarGasto.TabIndex = 793
        Me.btnAgregarGasto.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(64, 120)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 792
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(82, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 791
        Me.Label7.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(64, 142)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(109, 26)
        Me.txtMonto.TabIndex = 790
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(62, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 789
        Me.PictureBox3.TabStop = False
        '
        'cboGastos
        '
        Me.cboGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGastos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastos.FormattingEnabled = True
        Me.cboGastos.Location = New System.Drawing.Point(64, 84)
        Me.cboGastos.Name = "cboGastos"
        Me.cboGastos.Size = New System.Drawing.Size(289, 28)
        Me.cboGastos.TabIndex = 787
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(88, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 786
        Me.Label5.Text = "Asunto"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 785
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.CausesValidation = False
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(45, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 784
        Me.Label6.Text = "Registrar Gasto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 640)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "Gastos"
        Me.Text = "Gastosvb"
        Me.Controls.SetChildIndex(Me.Panel5, 0)
        Me.Controls.SetChildIndex(Me.Panel6, 0)
        Me.Controls.SetChildIndex(Me.Panel7, 0)
        Me.Controls.SetChildIndex(Me.Panel17, 0)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboGastos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarGasto As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
