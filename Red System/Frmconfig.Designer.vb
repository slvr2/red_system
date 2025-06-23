<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmconfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmconfig))
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cad_user = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_visulizar = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_user
        '
        Me.dgv_user.AllowUserToAddRows = False
        Me.dgv_user.AllowUserToDeleteRows = False
        Me.dgv_user.AllowUserToResizeRows = False
        Me.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_user.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(45, 170)
        Me.dgv_user.MultiSelect = False
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.ReadOnly = True
        Me.dgv_user.RowHeadersVisible = False
        Me.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_user.Size = New System.Drawing.Size(705, 236)
        Me.dgv_user.TabIndex = 25
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
        Me.btn_voltar.TabIndex = 27
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.BackColor = System.Drawing.Color.Firebrick
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(416, 127)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(334, 21)
        Me.btn_delete.TabIndex = 28
        Me.btn_delete.Text = "Deletar"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_cad_user
        '
        Me.btn_cad_user.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cad_user.BackColor = System.Drawing.Color.Firebrick
        Me.btn_cad_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cad_user.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cad_user.ForeColor = System.Drawing.Color.White
        Me.btn_cad_user.Location = New System.Drawing.Point(416, 424)
        Me.btn_cad_user.Name = "btn_cad_user"
        Me.btn_cad_user.Size = New System.Drawing.Size(334, 42)
        Me.btn_cad_user.TabIndex = 29
        Me.btn_cad_user.Text = "Cadastrar Usuário"
        Me.btn_cad_user.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(416, 60)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(334, 20)
        Me.txt_senha.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(412, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Senha"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(45, 60)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(334, 20)
        Me.txt_usuario.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Usuário"
        '
        'cmb_acesso
        '
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Items.AddRange(New Object() {"Administrador", "Usuário"})
        Me.cmb_acesso.Location = New System.Drawing.Point(45, 127)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(334, 21)
        Me.cmb_acesso.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nivel de Acesso"
        '
        'chk_visulizar
        '
        Me.chk_visulizar.AutoSize = True
        Me.chk_visulizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.chk_visulizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_visulizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visulizar.ForeColor = System.Drawing.Color.White
        Me.chk_visulizar.Location = New System.Drawing.Point(416, 86)
        Me.chk_visulizar.Name = "chk_visulizar"
        Me.chk_visulizar.Size = New System.Drawing.Size(115, 19)
        Me.chk_visulizar.TabIndex = 40
        Me.chk_visulizar.Text = "Visualizar Senha"
        Me.chk_visulizar.UseVisualStyleBackColor = False
        '
        'Frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 496)
        Me.Controls.Add(Me.chk_visulizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_acesso)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cad_user)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_user)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmconfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_cad_user As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_visulizar As CheckBox
End Class
