Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frmpedido

    Sub Carregar_pedidos()
        Try
            Dim dt As New DataTable

            SQL = "SELECT * FROM tb_pedidos"
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            dt.Columns.Add("Nº Pedido")
            dt.Columns.Add("Cód Cliente")
            dt.Columns.Add("Cliente")
            dt.Columns.Add("CNPJ")
            dt.Columns.Add("CPF")
            dt.Columns.Add("Observação")
            dt.Columns.Add("Valor do Pedido")
            dt.Columns.Add("Data de Criação")

            Do While Not rs.EOF
                dt.Rows.Add(
                    rs.Fields("id_pedidos").Value,
                    rs.Fields("cod_cliente").Value,
                    rs.Fields("cliente").Value,
                    rs.Fields("cnpj").Value,
                    rs.Fields("cpf").Value,
                    rs.Fields("obs").Value,
                    rs.Fields("valor_ped").Value,
                    rs.Fields("data_ped").Value
                    )
                rs.MoveNext()
            Loop
            rs.Close()
            dgv_ped.DataSource = dt

            With dgv_ped
                'Ajusta o peso relativo de cada coluna
                .Columns("Nº Pedido").FillWeight = 60
                .Columns("Cód Cliente").FillWeight = 50
                .Columns("Cliente").FillWeight = 120
                .Columns("CNPJ").FillWeight = 50
                .Columns("CPF").FillWeight = 75
                .Columns("Observação").FillWeight = 100
                .Columns("Valor do Pedido").FillWeight = 100
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

    Private Sub btn_novo_pedido_Click(sender As Object, e As EventArgs) Handles btn_novo_pedido.Click
        Dim frm As New Frm_cad_pedido()
        frm.ShowDialog()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frminicial.Show()
        Me.Close()
    End Sub

    Private Sub Frmpedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_pedidos()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dgv_ped.SelectedRows.Count = 0 Then
            MsgBox("Selecione uma linha para excluir.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If

        Dim idPed As Integer = CInt(dgv_ped.SelectedRows(0).Cells(0).Value)

        If MsgBox("Deseja realmente excluir este pedido?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            SQL = "DELETE FROM tb_pedidos WHERE id_pedidos = " & idPed
            db.Execute(SQL)
            MsgBox("Pedido excluído com sucesso.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Excluído")
            Carregar_pedidos()
        Catch ex As Exception
            MsgBox("Erro ao excluir Pedido!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub dgv_ped_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ped.CellDoubleClick
        If e.RowIndex >= 0 Then

            ' Obtém o ID da linha clicada
            Dim idPed As Integer = dgv_ped.Rows(e.RowIndex).Cells(0).Value

            ' Abre o formulário de cadastro passando o ID
            Dim frm As New Frm_cad_pedido(idPed)
            frm.ShowDialog()

            ' Após fechar, atualiza a tabela
            Carregar_pedidos()
        End If
    End Sub

End Class