<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.dgvGrilla)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(27, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 380)
        Me.Panel1.TabIndex = 780
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrilla.EnableHeadersVisualStyles = False
        Me.dgvGrilla.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvGrilla.Location = New System.Drawing.Point(17, 33)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrilla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(611, 329)
        Me.dgvGrilla.TabIndex = 781
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label7.CausesValidation = False
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(25, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 23)
        Me.Label7.TabIndex = 780
        Me.Label7.Text = "Lista"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(7, 8)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 792
        Me.PictureBox7.TabStop = False
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Lista"
        Me.Text = "Lista"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
End Class
