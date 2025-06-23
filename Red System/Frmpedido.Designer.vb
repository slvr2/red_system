<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmpedido))
        Me.btn_novo_pedido = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_ped = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.dgv_ped, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_novo_pedido
        '
        Me.btn_novo_pedido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_novo_pedido.BackColor = System.Drawing.Color.Firebrick
        Me.btn_novo_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_novo_pedido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_novo_pedido.ForeColor = System.Drawing.Color.White
        Me.btn_novo_pedido.Location = New System.Drawing.Point(899, 618)
        Me.btn_novo_pedido.Name = "btn_novo_pedido"
        Me.btn_novo_pedido.Size = New System.Drawing.Size(334, 42)
        Me.btn_novo_pedido.TabIndex = 24
        Me.btn_novo_pedido.Text = "Novo Pedido"
        Me.btn_novo_pedido.UseVisualStyleBackColor = False
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
        Me.btn_voltar.TabIndex = 25
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
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Pedidos"
        '
        'dgv_ped
        '
        Me.dgv_ped.AllowUserToAddRows = False
        Me.dgv_ped.AllowUserToDeleteRows = False
        Me.dgv_ped.AllowUserToResizeRows = False
        Me.dgv_ped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ped.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ped.Location = New System.Drawing.Point(12, 66)
        Me.dgv_ped.MultiSelect = False
        Me.dgv_ped.Name = "dgv_ped"
        Me.dgv_ped.ReadOnly = True
        Me.dgv_ped.RowHeadersVisible = False
        Me.dgv_ped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ped.Size = New System.Drawing.Size(1221, 523)
        Me.dgv_ped.TabIndex = 27
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
        Me.btn_delete.TabIndex = 28
        Me.btn_delete.Text = "Deletar"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Frmpedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 688)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dgv_ped)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_novo_pedido)
        Me.Controls.Add(Me.btn_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmpedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        CType(Me.dgv_ped, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_novo_pedido As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_ped As DataGridView
    Friend WithEvents btn_delete As Button
End Class
