<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_cad_client
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_client))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_comp = New System.Windows.Forms.MaskedTextBox()
        Me.btn_save_client = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(157, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cliente"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(45, 174)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(455, 20)
        Me.txt_email.TabIndex = 23
        Me.txt_email.ValidatingType = GetType(Date)
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(45, 110)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(88, 20)
        Me.txt_cpf.TabIndex = 22
        Me.txt_cpf.ValidatingType = GetType(Date)
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(154, 46)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(346, 20)
        Me.txt_cliente.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(537, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 14)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Imagem do Cliente"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(44, 302)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(706, 20)
        Me.txt_endereco.TabIndex = 26
        Me.txt_endereco.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(47, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Endereço"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(45, 238)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(102, 20)
        Me.txt_cep.TabIndex = 26
        Me.txt_cep.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "CEP"
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(363, 110)
        Me.txt_celular.Mask = "(99) 99999-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(137, 20)
        Me.txt_celular.TabIndex = 24
        Me.txt_celular.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(366, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 14)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Celular"
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(151, 110)
        Me.txt_cnpj.Mask = "99.999.999/9999-99"
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(193, 20)
        Me.txt_cnpj.TabIndex = 22
        Me.txt_cnpj.ValidatingType = GetType(Date)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(154, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 14)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "CNPJ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(47, 350)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 14)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Complemento"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(366, 366)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(178, 20)
        Me.txt_cidade.TabIndex = 26
        Me.txt_cidade.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(369, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 14)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cidade"
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(566, 366)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(184, 20)
        Me.txt_estado.TabIndex = 26
        Me.txt_estado.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(569, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 14)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Estado"
        '
        'txt_comp
        '
        Me.txt_comp.Location = New System.Drawing.Point(44, 366)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(300, 20)
        Me.txt_comp.TabIndex = 26
        Me.txt_comp.ValidatingType = GetType(Date)
        '
        'btn_save_client
        '
        Me.btn_save_client.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save_client.BackColor = System.Drawing.Color.Firebrick
        Me.btn_save_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save_client.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_client.ForeColor = System.Drawing.Color.White
        Me.btn_save_client.Location = New System.Drawing.Point(416, 424)
        Me.btn_save_client.Name = "btn_save_client"
        Me.btn_save_client.Size = New System.Drawing.Size(334, 42)
        Me.btn_save_client.TabIndex = 40
        Me.btn_save_client.Text = "Salvar Cliente"
        Me.btn_save_client.UseVisualStyleBackColor = False
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
        Me.btn_voltar.TabIndex = 41
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'img_foto
        '
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(534, 46)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(216, 222)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 43
        Me.img_foto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Código"
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(45, 46)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(87, 20)
        Me.txt_cod.TabIndex = 44
        '
        'Frm_cad_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 496)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.btn_save_client)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_comp)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_cad_client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_email As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_endereco As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_cnpj As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cidade As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_estado As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_comp As MaskedTextBox
    Friend WithEvents btn_save_client As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cod As TextBox
End Class
