<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_pedido))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_prod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_cod_client = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_save_pedido = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.date_ped = New System.Windows.Forms.DateTimePicker()
        Me.dgv_itens = New System.Windows.Forms.DataGridView()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(304, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Observação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(649, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Data do pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cód cliente"
        '
        'cmb_prod
        '
        Me.cmb_prod.FormattingEnabled = True
        Me.cmb_prod.Location = New System.Drawing.Point(45, 149)
        Me.cmb_prod.Name = "cmb_prod"
        Me.cmb_prod.Size = New System.Drawing.Size(584, 21)
        Me.cmb_prod.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(139, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(136, 55)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(493, 20)
        Me.txt_cliente.TabIndex = 26
        '
        'txt_cod_client
        '
        Me.txt_cod_client.Location = New System.Drawing.Point(45, 55)
        Me.txt_cod_client.Name = "txt_cod_client"
        Me.txt_cod_client.Size = New System.Drawing.Size(75, 20)
        Me.txt_cod_client.TabIndex = 18
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(45, 102)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(109, 20)
        Me.txt_cpf.TabIndex = 19
        Me.txt_cpf.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "CPF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Adicionar Produto"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(45, 384)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(159, 20)
        Me.txt_total.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(48, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Valor Total"
        '
        'btn_save_pedido
        '
        Me.btn_save_pedido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save_pedido.BackColor = System.Drawing.Color.Firebrick
        Me.btn_save_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save_pedido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_pedido.ForeColor = System.Drawing.Color.White
        Me.btn_save_pedido.Location = New System.Drawing.Point(417, 424)
        Me.btn_save_pedido.Name = "btn_save_pedido"
        Me.btn_save_pedido.Size = New System.Drawing.Size(334, 42)
        Me.btn_save_pedido.TabIndex = 38
        Me.btn_save_pedido.Text = "Salvar Pedido"
        Me.btn_save_pedido.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_voltar.BackColor = System.Drawing.Color.Firebrick
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(45, 424)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(334, 42)
        Me.btn_voltar.TabIndex = 39
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_adicionar.BackColor = System.Drawing.Color.Firebrick
        Me.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_adicionar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_adicionar.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar.Location = New System.Drawing.Point(645, 147)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(106, 23)
        Me.btn_adicionar.TabIndex = 40
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'date_ped
        '
        Me.date_ped.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ped.Location = New System.Drawing.Point(645, 55)
        Me.date_ped.Name = "date_ped"
        Me.date_ped.Size = New System.Drawing.Size(106, 20)
        Me.date_ped.TabIndex = 41
        '
        'dgv_itens
        '
        Me.dgv_itens.AllowUserToAddRows = False
        Me.dgv_itens.AllowUserToDeleteRows = False
        Me.dgv_itens.AllowUserToResizeRows = False
        Me.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_itens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_itens.Location = New System.Drawing.Point(45, 197)
        Me.dgv_itens.MultiSelect = False
        Me.dgv_itens.Name = "dgv_itens"
        Me.dgv_itens.RowHeadersVisible = False
        Me.dgv_itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_itens.Size = New System.Drawing.Size(706, 160)
        Me.dgv_itens.TabIndex = 42
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(301, 102)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(450, 20)
        Me.txt_obs.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(177, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "CNPJ"
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(173, 102)
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(110, 20)
        Me.txt_cnpj.TabIndex = 43
        Me.txt_cnpj.ValidatingType = GetType(Date)
        '
        'Frm_cad_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 496)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.date_ped)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.btn_save_pedido)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.cmb_prod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_cod_client)
        Me.Controls.Add(Me.dgv_itens)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_cad_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pedido"
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_prod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents txt_cod_client As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_save_pedido As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents date_ped As DateTimePicker
    Friend WithEvents dgv_itens As DataGridView
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cnpj As MaskedTextBox
End Class
