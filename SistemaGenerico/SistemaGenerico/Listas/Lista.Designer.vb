<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_minimizar.Location = New System.Drawing.Point(731, 9)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(20, 20)
        Me.btn_minimizar.TabIndex = 5
        Me.btn_minimizar.UseVisualStyleBackColor = False
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
        Me.btnVolver.Location = New System.Drawing.Point(645, 535)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(103, 35)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Gobold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(223, 29)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(307, 41)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "TITULO DE LA PANTALLA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvGrilla)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 431)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.Location = New System.Drawing.Point(20, 29)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(696, 384)
        Me.dgvGrilla.TabIndex = 17
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(760, 582)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btn_minimizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_minimizar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
End Class
