Imports System.Data.SqlClient
Imports System.Net.Mime.MediaTypeNames
Imports System.Web.Script.Serialization
Imports System.IO
Imports ADODB

Public Class Frm_cad_pedido

    Private pedidoID As Integer = -1

    Public Sub New()
        InitializeComponent()
        pedidoID = -1
    End Sub

    Public Sub New(id_pedidos As Integer)
        InitializeComponent()
        pedidoID = id_pedidos
    End Sub

    Sub Carregar_pedido()
        Try
            ' Monta a consulta para buscar o pedido pelo ID
            SQL = "SELECT * FROM tb_pedidos WHERE id_pedidos = " & pedidoID
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                ' Preenche os campos do formulário
                txt_cod_client.Text = rs.Fields("cod_cliente").Value.ToString()
                txt_cliente.Text = rs.Fields("cliente").Value.ToString()
                txt_cnpj.Text = rs.Fields("cnpj").Value.ToString()
                txt_cpf.Text = rs.Fields("cpf").Value.ToString()
                txt_obs.Text = rs.Fields("obs").Value.ToString()
                txt_total.Text = rs.Fields("valor_ped").Value.ToString()
                date_ped.Text = rs.Fields("data_ped").Value.ToString()

                ' Lê o campo JSON com segurança
                Dim json As String = ""
                If Not IsDBNull(rs.Fields("itens_json").Value) Then
                    json = rs.Fields("itens_json").Value.ToString()
                End If

                If Not String.IsNullOrWhiteSpace(json) Then
                    Try
                        Dim serializer As New JavaScriptSerializer()
                        Dim itens As List(Of Dictionary(Of String, Object)) = serializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(json)

                        dgv_itens.Rows.Clear()

                        For Each item In itens
                            Dim produto As String = If(item.ContainsKey("produto"), item("produto").ToString(), "")
                            Dim descricao As String = If(item.ContainsKey("descricao"), item("descricao").ToString(), "")
                            Dim preco As String = If(item.ContainsKey("preco"), item("preco").ToString(), "")
                            Dim qtd As String = If(item.ContainsKey("qtd"), item("qtd").ToString(), "")

                            dgv_itens.Rows.Add(produto, descricao, preco, qtd)
                        Next
                    Catch ex As Exception
                        MsgBox("Erro ao carregar itens do pedido (JSON): " & ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If

            Else
                MsgBox("Pedido não encontrado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            End If

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar pedido!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Sub Salvar_pedido()
        Try
            ' 1. Insere os dados principais do pedido (sem o JSON ainda)
            SQL = $"INSERT INTO tb_pedidos (cod_cliente, cliente, cnpj, cpf, obs, valor_ped, data_ped) " &
              $"VALUES ('{txt_cod_client.Text}', '{txt_cliente.Text}', '{txt_cnpj.Text}', '{txt_cpf.Text}', " &
              $"'{txt_obs.Text}', '{txt_total.Text}', '{date_ped.Text}')"
            db.Execute(SQL)

            ' 2. Recupera o último ID inserido
            SQL = "SELECT TOP 1 id_pedidos FROM tb_pedidos ORDER BY id_pedidos DESC"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                Dim idPedido As Integer = rs.Fields("id_pedidos").Value

                ' 3. Gera o JSON dos itens
                Dim json As String = dgv_itens_ToJSON()

                ' 4. Atualiza o campo itens_json para o pedido recém inserido
                SQL = $"UPDATE tb_pedidos SET itens_json = '{Replace(json, "'", "''")}' WHERE id_pedidos = {idPedido}"
                db.Execute(SQL)

                ' 5. Mensagem de sucesso e recarrega tela
                MsgBox("Pedido salvo com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Close()
                Frmpedido.Close()
                Frmpedido.Show()
            Else
                MsgBox("Erro ao recuperar o ID do pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao salvar pedido!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Function dgv_itens_ToJSON() As String
        Dim rows As New List(Of Dictionary(Of String, Object))()

        For Each row As DataGridViewRow In dgv_itens.Rows
            If Not row.IsNewRow Then
                Dim dict As New Dictionary(Of String, Object)

                ' Colunas fixas: produto, descricao, preco, qtd
                dict("produto") = row.Cells(0).Value
                dict("descricao") = row.Cells(1).Value
                dict("preco") = row.Cells(2).Value
                dict("qtd") = row.Cells(3).Value

                rows.Add(dict)
            End If
        Next

        Dim serializer As New JavaScriptSerializer()
        Return serializer.Serialize(rows)
    End Function

    Private Sub AtualizarTotal()
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In dgv_itens.Rows
            If row.IsNewRow = False Then
                Dim qtdStr As String = row.Cells("colQuantidade").Value?.ToString()
                Dim precoStr As String = row.Cells("colPreco").Value?.ToString().Replace("R$", "").Trim()

                Dim qtd As Integer
                Dim preco As Decimal

                If Integer.TryParse(qtdStr, qtd) AndAlso Decimal.TryParse(precoStr, preco) Then
                    total += qtd * preco
                End If
            End If
        Next

        txt_total.Text = total.ToString("C2") ' Formato R$ 0,00
    End Sub

    Sub Formatar_dgv()
        dgv_itens.Columns.Clear()

        ' Coluna Produto (somente leitura)
        Dim colProd As New DataGridViewTextBoxColumn()
        colProd.Name = "colProduto"
        colProd.HeaderText = "Produto"
        colProd.ReadOnly = True
        dgv_itens.Columns.Add(colProd)

        ' Coluna Descrição (somente leitura)
        Dim colDesc As New DataGridViewTextBoxColumn()
        colDesc.Name = "colDescricao"
        colDesc.HeaderText = "Descrição"
        colDesc.ReadOnly = True
        dgv_itens.Columns.Add(colDesc)

        ' Coluna Preço (somente leitura)
        Dim colPreco As New DataGridViewTextBoxColumn()
        colPreco.Name = "colPreco"
        colPreco.HeaderText = "Preço"
        colPreco.ReadOnly = True
        dgv_itens.Columns.Add(colPreco)

        ' Coluna Quantidade (editável)
        Dim colQtd As New DataGridViewTextBoxColumn()
        colQtd.Name = "colQuantidade"
        colQtd.HeaderText = "Qtd"
        colQtd.ReadOnly = False
        dgv_itens.Columns.Add(colQtd)

        With dgv_itens
            'Ajusta o peso relativo de cada coluna
            colQtd.FillWeight = 30
            colProd.FillWeight = 65
            colPreco.FillWeight = 40
            colDesc.FillWeight = 100

            'Cor de fundo geral
            .BackgroundColor = Color.FromArgb(42, 46, 57)
            .GridColor = Color.Firebrick

            'Cabeçalho (título das colunas)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
            .EnableHeadersVisualStyles = False

            'Linhas alternadas             
            .RowsDefaultCellStyle.BackColor = Color.FromArgb(42, 46, 57)
            .RowsDefaultCellStyle.ForeColor = Color.White

            'Fonte e seleção
            .DefaultCellStyle.Font = New Font("Arial", 10)
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(42, 46, 57)

            'Borda da célula
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            'Remover bordas do cabeçalho
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With
    End Sub 'Formata a dgv de itens

    Sub Adicionar_itens()
        If cmb_prod.SelectedItem IsNot Nothing Then
            Dim Selecao As String = cmb_prod.SelectedItem.ToString()
            Dim preco As Decimal = 0D
            Dim descricao As String = ""

            ' Buscar o preço do produto no banco
            SQL = $"SELECT descricao, preco_venda FROM tb_produtos WHERE nome = '{Selecao}'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                descricao = rs.Fields("descricao").Value.ToString()
                preco = Convert.ToDecimal(rs.Fields("preco_venda").Value)
            End If

            ' Adicionar nova linha no DataGridView
            dgv_itens.Rows.Add(Selecao, descricao, preco.ToString("C2")) ' Ex: R$ 15,50
        Else
            MsgBox("Selecione um produto antes de adicionar.")
        End If
    End Sub 'Adiciona itens na dgv

    Sub Carregar_cmbprod()
        SQL = "SELECT nome FROM tb_produtos"
        rs = db.Execute(SQL)

        While rs.EOF = False
            cmb_prod.Items.Add(rs.Fields("nome").Value.ToString())
            rs.MoveNext()
        End While
    End Sub 'Carrega os produtos no combobox 

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frmpedido.Show()
        Me.Close()
    End Sub

    Private Sub Frm_cad_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formatar_dgv()
        Carregar_cmbprod()
        If pedidoID > 0 Then
            Carregar_pedido()
        End If
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Adicionar_itens()
    End Sub

    Private Sub dgv_itens_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_itens.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            dgv_itens.Rows.RemoveAt(e.RowIndex)
            AtualizarTotal()
        End If
    End Sub

    Private Sub dgv_itens_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_itens.CellEndEdit
        If e.ColumnIndex = dgv_itens.Columns("colQuantidade").Index Then
            Dim qtdStr As String = dgv_itens.Rows(e.RowIndex).Cells("colQuantidade").Value?.ToString()
            Dim precoStr As String = dgv_itens.Rows(e.RowIndex).Cells("colPreco").Value?.ToString().Replace("R$", "").Trim()

            Dim qtd As Integer
            Dim preco As Decimal

            If Not Integer.TryParse(qtdStr, qtd) OrElse qtd <= 0 Then
                MsgBox("Digite uma quantidade válida (número inteiro maior que 0).")
                dgv_itens.Rows(e.RowIndex).Cells("colQuantidade").Value = ""
                Exit Sub
            End If

            If Decimal.TryParse(precoStr, preco) Then
                ' Tudo certo, recalcula o total
                AtualizarTotal()
            End If
        End If
    End Sub

    Private Sub txt_cod_client_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_client.TextChanged
        If pedidoID = -1 Then
            SQL = $"Select * from tb_clientes where id_clientes ='{txt_cod_client.Text}'"
            If txt_cod_client.Text <> Nothing Then
                rs = db.Execute(SQL)
                If rs.EOF = False Then
                    txt_cliente.Text = rs.Fields(1).Value
                    txt_cpf.Text = rs.Fields(2).Value
                    txt_cnpj.Text = rs.Fields(3).Value
                Else
                    MsgBox("Cliente não cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_cod_client.Clear()
                End If
            Else
                txt_cliente.Clear()
                txt_cpf.Clear()
                txt_cnpj.Clear()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_save_pedido_Click(sender As Object, e As EventArgs) Handles btn_save_pedido.Click
        If pedidoID = -1 Then
            Salvar_pedido()
        Else
            MsgBox("Pedidos realizados não podem ser alterados, caso ocorra algo é necessário deletar e refazer um novo pedido.")
            Exit Sub
        End If
    End Sub

End Class