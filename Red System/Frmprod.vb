Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frmprod

    Sub Carregar_produtos()
        Try
            Dim dt As New DataTable

            SQL = "SELECT * FROM tb_produtos"
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            dt.Columns.Add("Código")
            dt.Columns.Add("Nome")
            dt.Columns.Add("Descrição")
            dt.Columns.Add("Material")
            dt.Columns.Add("Fornecedor")
            dt.Columns.Add("Preço de Venda")
            dt.Columns.Add("Preço de Custo")
            dt.Columns.Add("Data de Criação")

            Do While Not rs.EOF
                dt.Rows.Add(
                    rs.Fields("id_produtos").Value,
                    rs.Fields("nome").Value,
                    rs.Fields("descricao").Value,
                    rs.Fields("material").Value,
                    rs.Fields("fornecedor").Value,
                    rs.Fields("preco_venda").Value,
                    rs.Fields("preco_custo").Value,
                    rs.Fields("data_criacao").Value
                    )
                rs.MoveNext()
            Loop
            rs.Close()
            dgv_prod.DataSource = dt

            With dgv_prod
                'Ajusta o peso relativo de cada coluna
                .Columns("Código").FillWeight = 30
                .Columns("Nome").FillWeight = 70
                .Columns("Descrição").FillWeight = 120
                .Columns("Material").FillWeight = 50
                .Columns("Fornecedor").FillWeight = 75
                .Columns("Preço de Venda").FillWeight = 100
                .Columns("Preço de Custo").FillWeight = 100
                .Columns("Data de Criação").FillWeight = 120

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
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frminicial.Show()
        Me.Close()
    End Sub

    Private Sub btn_cad_prod_Click(sender As Object, e As EventArgs) Handles btn_cad_prod.Click
        Dim frm As New Frm_cad_prod()
        frm.ShowDialog()
    End Sub

    Private Sub Frmprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_produtos()
    End Sub

    Private Sub dgv_prod_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod.CellDoubleClick
        If e.RowIndex >= 0 Then

            ' Obtém o ID da linha clicada
            Dim idProduto As Integer = dgv_prod.Rows(e.RowIndex).Cells("Código").Value

            ' Abre o formulário de cadastro passando o ID
            Dim frm As New Frm_cad_prod(idProduto)
            frm.ShowDialog()

            ' Após fechar, atualiza a tabela
            Carregar_produtos()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dgv_prod.SelectedRows.Count = 0 Then
            MsgBox("Selecione uma linha para excluir.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If

        Dim idProd As Integer = CInt(dgv_prod.SelectedRows(0).Cells(0).Value)

        If MsgBox("Deseja realmente excluir este produto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            SQL = "DELETE FROM tb_produtos WHERE id_produtos = " & idProd
            db.Execute(SQL)
            MsgBox("Produto excluído com sucesso.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Excluído")
            Carregar_produtos()
        Catch ex As Exception
            MsgBox("Erro ao excluir cliente!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

End Class