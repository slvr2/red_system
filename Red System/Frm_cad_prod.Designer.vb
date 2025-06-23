<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_prod))
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.txt_data_criacao = New System.Windows.Forms.MaskedTextBox()
        Me.txt_alt = New System.Windows.Forms.MaskedTextBox()
        Me.txt_comp = New System.Windows.Forms.MaskedTextBox()
        Me.txt_peso = New System.Windows.Forms.MaskedTextBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.img_foto01 = New System.Windows.Forms.PictureBox()
        Me.img_foto02 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_save_prod = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_material = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_custo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_venda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_larg = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_fornecedor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        CType(Me.img_foto01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_produto
        '
        Me.txt_produto.Location = New System.Drawing.Point(154, 46)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(465, 20)
        Me.txt_produto.TabIndex = 0
        '
        'txt_data_criacao
        '
        Me.txt_data_criacao.Location = New System.Drawing.Point(640, 46)
        Me.txt_data_criacao.Mask = "00/00/0000 00:00"
        Me.txt_data_criacao.Name = "txt_data_criacao"
        Me.txt_data_criacao.Size = New System.Drawing.Size(112, 20)
        Me.txt_data_criacao.TabIndex = 1
        Me.txt_data_criacao.ValidatingType = GetType(Date)
        '
        'txt_alt
        '
        Me.txt_alt.Location = New System.Drawing.Point(45, 202)
        Me.txt_alt.Mask = "00cm"
        Me.txt_alt.Name = "txt_alt"
        Me.txt_alt.Size = New System.Drawing.Size(87, 20)
        Me.txt_alt.TabIndex = 2
        Me.txt_alt.ValidatingType = GetType(Date)
        '
        'txt_comp
        '
        Me.txt_comp.Location = New System.Drawing.Point(45, 260)
        Me.txt_comp.Mask = "00cm"
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(88, 20)
        Me.txt_comp.TabIndex = 3
        Me.txt_comp.ValidatingType = GetType(Date)
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(160, 260)
        Me.txt_peso.Mask = "00cm"
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(87, 20)
        Me.txt_peso.TabIndex = 4
        Me.txt_peso.ValidatingType = GetType(Date)
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(45, 94)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(574, 60)
        Me.txt_descricao.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(158, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(643, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data de Criação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Altura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Comprimento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(163, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Peso"
        '
        'img_foto01
        '
        Me.img_foto01.Image = CType(resources.GetObject("img_foto01.Image"), System.Drawing.Image)
        Me.img_foto01.Location = New System.Drawing.Point(271, 183)
        Me.img_foto01.Name = "img_foto01"
        Me.img_foto01.Size = New System.Drawing.Size(216, 222)
        Me.img_foto01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto01.TabIndex = 14
        Me.img_foto01.TabStop = False
        '
        'img_foto02
        '
        Me.img_foto02.Image = CType(resources.GetObject("img_foto02.Image"), System.Drawing.Image)
        Me.img_foto02.Location = New System.Drawing.Point(536, 183)
        Me.img_foto02.Name = "img_foto02"
        Me.img_foto02.Size = New System.Drawing.Size(216, 222)
        Me.img_foto02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto02.TabIndex = 15
        Me.img_foto02.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(49, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Código"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(430, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 14)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Adicionar Imagem ao produto"
        '
        'btn_save_prod
        '
        Me.btn_save_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save_prod.BackColor = System.Drawing.Color.Firebrick
        Me.btn_save_prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save_prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_prod.ForeColor = System.Drawing.Color.White
        Me.btn_save_prod.Location = New System.Drawing.Point(416, 424)
        Me.btn_save_prod.Name = "btn_save_prod"
        Me.btn_save_prod.Size = New System.Drawing.Size(334, 42)
        Me.btn_save_prod.TabIndex = 23
        Me.btn_save_prod.Text = "Salvar Produto"
        Me.btn_save_prod.UseVisualStyleBackColor = False
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
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(48, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 14)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Material"
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(45, 318)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(202, 20)
        Me.txt_material.TabIndex = 26
        Me.txt_material.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(642, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Preço de Custo"
        '
        'txt_custo
        '
        Me.txt_custo.Location = New System.Drawing.Point(638, 134)
        Me.txt_custo.Multiline = True
        Me.txt_custo.Name = "txt_custo"
        Me.txt_custo.Size = New System.Drawing.Size(114, 20)
        Me.txt_custo.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(643, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 14)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Preço de Venda"
        '
        'txt_venda
        '
        Me.txt_venda.Location = New System.Drawing.Point(640, 94)
        Me.txt_venda.Multiline = True
        Me.txt_venda.Name = "txt_venda"
        Me.txt_venda.Size = New System.Drawing.Size(112, 20)
        Me.txt_venda.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(164, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 14)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Largura"
        '
        'txt_larg
        '
        Me.txt_larg.Location = New System.Drawing.Point(161, 202)
        Me.txt_larg.Mask = "00cm"
        Me.txt_larg.Name = "txt_larg"
        Me.txt_larg.Size = New System.Drawing.Size(87, 20)
        Me.txt_larg.TabIndex = 35
        Me.txt_larg.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(48, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 14)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Fornecedor"
        '
        'txt_fornecedor
        '
        Me.txt_fornecedor.Location = New System.Drawing.Point(45, 376)
        Me.txt_fornecedor.Name = "txt_fornecedor"
        Me.txt_fornecedor.Size = New System.Drawing.Size(202, 20)
        Me.txt_fornecedor.TabIndex = 37
        Me.txt_fornecedor.ValidatingType = GetType(Date)
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(45, 46)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(87, 20)
        Me.txt_cod.TabIndex = 39
        '
        'Frm_cad_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 496)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_fornecedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_larg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_venda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_custo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.btn_save_prod)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.img_foto02)
        Me.Controls.Add(Me.img_foto01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.txt_alt)
        Me.Controls.Add(Me.txt_data_criacao)
        Me.Controls.Add(Me.txt_produto)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_cad_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produto"
        CType(Me.img_foto01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_produto As TextBox
    Friend WithEvents txt_data_criacao As MaskedTextBox
    Friend WithEvents txt_alt As MaskedTextBox
    Friend WithEvents txt_comp As MaskedTextBox
    Friend WithEvents txt_peso As MaskedTextBox
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents img_foto01 As PictureBox
    Friend WithEvents img_foto02 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_save_prod As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_material As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_custo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_venda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_larg As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_fornecedor As MaskedTextBox
    Friend WithEvents txt_cod As TextBox
End Class
