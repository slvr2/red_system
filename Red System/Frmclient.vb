Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frmclient

    Sub Carregar_clientes()
        Try
            Dim dt As New DataTable

            SQL = "SELECT * FROM tb_clientes"
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            dt.Columns.Add("Código")
            dt.Columns.Add("Nome")
            dt.Columns.Add("CPF")
            dt.Columns.Add("CNPJ")
            dt.Columns.Add("Email")
            dt.Columns.Add("Celular")
            dt.Columns.Add("Cep")
            dt.Columns.Add("Endereço")
            dt.Columns.Add("Estado")
            dt.Columns.Add("Cidade")

            Do While Not rs.EOF
                dt.Rows.Add(
                    rs.Fields("id_clientes").Value,
                    rs.Fields("nome").Value,
                    rs.Fields("cpf").Value,
                    rs.Fields("cnpj").Value,
                    rs.Fields("email").Value,
                    rs.Fields("celular").Value,
                    rs.Fields("cep").Value,
                    rs.Fields("endereco").Value,
                    rs.Fields("estado").Value,
                    rs.Fields("cidade").Value
                )
                rs.MoveNext()
            Loop
            rs.Close()
            dgv_client.DataSource = dt

            'Formatar dgv
            With dgv_client
                'Ajusta o peso relativo de cada coluna
                .Columns("Código").FillWeight = 50
                .Columns("Nome").FillWeight = 100
                .Columns("CPF").FillWeight = 75
                .Columns("CNPJ").FillWeight = 100
                .Columns("Email").FillWeight = 125
                .Columns("Celular").FillWeight = 100
                .Columns("Cep").FillWeight = 50
                .Columns("Endereço").FillWeight = 120
                .Columns("Estado").FillWeight = 50
                .Columns("Cidade").FillWeight = 75

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
    End Sub '--> OK

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frminicial.Show()
        Me.Close()
    End Sub '--> OK

    Private Sub Frmclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_clientes()
    End Sub '--> OK

    Private Sub dgv_client_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_client.CellContentDoubleClick
        If e.RowIndex >= 0 Then

            ' Obtém o ID da linha clicada
            Dim idCliente As Integer = dgv_client.Rows(e.RowIndex).Cells("Código").Value

            ' Abre o formulário de cadastro passando o ID
            Dim frm As New Frm_cad_client(idCliente)
            frm.ShowDialog()

            ' Após fechar, atualiza a tabela
            Carregar_clientes()
        End If
    End Sub '--> OK

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dgv_client.SelectedRows.Count = 0 Then
            MsgBox("Selecione uma linha para excluir.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If

        Dim idCliente As Integer = CInt(dgv_client.SelectedRows(0).Cells(0).Value)

        If MsgBox("Deseja realmente excluir este cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            SQL = "DELETE FROM tb_clientes WHERE id_clientes = " & idCliente
            db.Execute(SQL)
            MsgBox("Cliente excluído com sucesso.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Excluído")
            Carregar_clientes()
        Catch ex As Exception
            MsgBox("Erro ao excluir cliente!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub '--> OK

    Private Sub btn_cad_client_Click(sender As Object, e As EventArgs) Handles btn_cad_client.Click
        Dim frm As New Frm_cad_client()
        frm.ShowDialog()
    End Sub '--> OK
End Class