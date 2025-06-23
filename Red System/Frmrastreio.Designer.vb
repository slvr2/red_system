<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmrastreio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmrastreio))
        Me.txt_cod_rastreio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_rastrear = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.dgv_eventos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.Button()
        CType(Me.dgv_eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cod_rastreio
        '
        Me.txt_cod_rastreio.Location = New System.Drawing.Point(768, 32)
        Me.txt_cod_rastreio.Name = "txt_cod_rastreio"
        Me.txt_cod_rastreio.Size = New System.Drawing.Size(465, 20)
        Me.txt_cod_rastreio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(523, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite o código de rastreio da encomenda:"
        '
        'btn_rastrear
        '
        Me.btn_rastrear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_rastrear.BackColor = System.Drawing.Color.Firebrick
        Me.btn_rastrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rastrear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_rastrear.ForeColor = System.Drawing.Color.White
        Me.btn_rastrear.Location = New System.Drawing.Point(899, 618)
        Me.btn_rastrear.Name = "btn_rastrear"
        Me.btn_rastrear.Size = New System.Drawing.Size(334, 42)
        Me.btn_rastrear.TabIndex = 24
        Me.btn_rastrear.Text = "Rastrear"
        Me.btn_rastrear.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_voltar.BackColor = System.Drawing.Color.Firebrick
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(12, 618)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(334, 42)
        Me.btn_voltar.TabIndex = 25
        Me.btn_voltar.Text = "Volltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'dgv_eventos
        '
        Me.dgv_eventos.AllowUserToAddRows = False
        Me.dgv_eventos.AllowUserToDeleteRows = False
        Me.dgv_eventos.AllowUserToResizeRows = False
        Me.dgv_eventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_eventos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_eventos.Location = New System.Drawing.Point(12, 66)
        Me.dgv_eventos.MultiSelect = False
        Me.dgv_eventos.Name = "dgv_eventos"
        Me.dgv_eventos.ReadOnly = True
        Me.dgv_eventos.RowHeadersVisible = False
        Me.dgv_eventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_eventos.Size = New System.Drawing.Size(1221, 523)
        Me.dgv_eventos.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Rastreio"
        '
        'btn_limpar
        '
        Me.btn_limpar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_limpar.BackColor = System.Drawing.Color.Firebrick
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Location = New System.Drawing.Point(455, 618)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(334, 42)
        Me.btn_limpar.TabIndex = 28
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'Frmrastreio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 688)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_eventos)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_rastrear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cod_rastreio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmrastreio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rastrear Pedido"
        CType(Me.dgv_eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cod_rastreio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rastrear As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_eventos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_limpar As Button
End Class
