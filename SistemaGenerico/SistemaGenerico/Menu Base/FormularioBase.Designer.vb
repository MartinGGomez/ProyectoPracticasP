<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioBase))
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btn_minimizar.Location = New System.Drawing.Point(668, 5)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimizar.TabIndex = 4
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Gobold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(194, 27)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(307, 41)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "TITULO DE LA PANTALLA"
        '
        'FormularioBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(698, 527)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btn_minimizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormularioBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
