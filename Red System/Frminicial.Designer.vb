<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frminicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frminicial))
        Me.btn_rastreio = New System.Windows.Forms.Button()
        Me.btn_client = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_rastreio
        '
        Me.btn_rastreio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_rastreio.BackColor = System.Drawing.Color.Firebrick
        Me.btn_rastreio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rastreio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rastreio.ForeColor = System.Drawing.Color.White
        Me.btn_rastreio.Location = New System.Drawing.Point(154, 16)
        Me.btn_rastreio.Name = "btn_rastreio"
        Me.btn_rastreio.Size = New System.Drawing.Size(151, 42)
        Me.btn_rastreio.TabIndex = 1
        Me.btn_rastreio.Text = "Rastreio"
        Me.btn_rastreio.UseVisualStyleBackColor = False
        '
        'btn_client
        '
        Me.btn_client.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_client.BackColor = System.Drawing.Color.Firebrick
        Me.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_client.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_client.ForeColor = System.Drawing.Color.White
        Me.btn_client.Location = New System.Drawing.Point(468, 16)
        Me.btn_client.Name = "btn_client"
        Me.btn_client.Size = New System.Drawing.Size(151, 42)
        Me.btn_client.TabIndex = 2
        Me.btn_client.Text = "Clientes"
        Me.btn_client.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_prod.BackColor = System.Drawing.Color.Firebrick
        Me.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_prod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prod.ForeColor = System.Drawing.Color.White
        Me.btn_prod.Location = New System.Drawing.Point(311, 16)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(151, 42)
        Me.btn_prod.TabIndex = 3
        Me.btn_prod.Text = "Produtos"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_config
        '
        Me.btn_config.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_config.BackColor = System.Drawing.Color.Firebrick
        Me.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_config.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config.ForeColor = System.Drawing.Color.White
        Me.btn_config.Location = New System.Drawing.Point(782, 16)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(151, 42)
        Me.btn_config.TabIndex = 6
        Me.btn_config.Text = "Configuração"
        Me.btn_config.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_sair.BackColor = System.Drawing.Color.Firebrick
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(939, 16)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(151, 42)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_pedidos.BackColor = System.Drawing.Color.Firebrick
        Me.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedidos.ForeColor = System.Drawing.Color.White
        Me.btn_pedidos.Location = New System.Drawing.Point(625, 16)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(151, 42)
        Me.btn_pedidos.TabIndex = 4
        Me.btn_pedidos.Text = "Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(154, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(936, 624)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Frminicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1245, 688)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_config)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_client)
        Me.Controls.Add(Me.btn_rastreio)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frminicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Inicial"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_rastreio As Button
    Friend WithEvents btn_client As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_config As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
