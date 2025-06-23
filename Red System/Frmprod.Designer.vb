<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprod
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprod))
        Me.btn_cad_prod = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cad_prod
        '
        Me.btn_cad_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cad_prod.BackColor = System.Drawing.Color.Firebrick
        Me.btn_cad_prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cad_prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cad_prod.ForeColor = System.Drawing.Color.White
        Me.btn_cad_prod.Location = New System.Drawing.Point(899, 618)
        Me.btn_cad_prod.Name = "btn_cad_prod"
        Me.btn_cad_prod.Size = New System.Drawing.Size(334, 42)
        Me.btn_cad_prod.TabIndex = 23
        Me.btn_cad_prod.Text = "Cadastrar Produtos"
        Me.btn_cad_prod.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_voltar.BackColor = System.Drawing.Color.Firebrick
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(12, 618)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(334, 42)
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Produtos"
        '
        'dgv_prod
        '
        Me.dgv_prod.AllowUserToAddRows = False
        Me.dgv_prod.AllowUserToDeleteRows = False
        Me.dgv_prod.AllowUserToResizeRows = False
        Me.dgv_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prod.Location = New System.Drawing.Point(12, 66)
        Me.dgv_prod.MultiSelect = False
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.ReadOnly = True
        Me.dgv_prod.RowHeadersVisible = False
        Me.dgv_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_prod.Size = New System.Drawing.Size(1221, 523)
        Me.dgv_prod.TabIndex = 26
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.BackColor = System.Drawing.Color.Firebrick
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(455, 618)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(334, 42)
        Me.btn_delete.TabIndex = 27
        Me.btn_delete.Text = "Deletar"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Frmprod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1245, 688)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cad_prod)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_prod)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmprod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cad_prod As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_prod As DataGridView
    Friend WithEvents btn_delete As Button
End Class
