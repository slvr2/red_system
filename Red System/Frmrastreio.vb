Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Frmrastreio

    Private Async Sub btn_rastrear_Click(sender As Object, e As EventArgs) Handles btn_rastrear.Click
        Dim codigoRastreio As String = txt_cod_rastreio.Text.Trim()

        If String.IsNullOrWhiteSpace(codigoRastreio) Then
            MsgBox("Digite um código de rastreio.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim url As String = "https://api-labs.wonca.com.br/wonca.labs.v1.LabsService/Track"
        Dim apiKey As String = "686tlAy0nCrLA_MSYRtxBRUYVsVwlV2QJebYQGGLcts" ' Substitua aqui pela sua chave real
        Dim jsonBody As String = $"{{""code"": ""{codigoRastreio}""}}"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", "Apikey " & apiKey)
            client.DefaultRequestHeaders.Add("Accept", "application/json")

            Dim content As New StringContent(jsonBody, Encoding.UTF8, "application/json")

            Try
                Dim response = Await client.PostAsync(url, content)
                Dim jsonResponse = Await response.Content.ReadAsStringAsync()

                Dim apiResp As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(jsonResponse)
                Dim rastreio As RastreioDetalhado = JsonConvert.DeserializeObject(Of RastreioDetalhado)(apiResp.json)

                If rastreio.eventos Is Nothing OrElse rastreio.eventos.Count = 0 Then
                    MsgBox("Nenhum evento encontrado.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                ' Preenche o DataGridView
                dgv_eventos.Rows.Clear()

                ' Adiciona os eventos como linhas
                For Each evento In rastreio.eventos
                    Dim dataHora As String = evento.dtHrCriado?.[date]
                    Dim descricao As String = evento.descricaoFrontEnd
                    Dim cidade As String = evento.unidade?.endereco?.cidade
                    Dim detalhe As String = evento.detalhe

                    dgv_eventos.Rows.Add(dataHora, descricao, cidade, detalhe)
                Next

            Catch ex As Exception
                MsgBox("Erro ao consultar a API: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frminicial.Show()
        Me.Close()
    End Sub

    Private Sub Frmrastreio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dgv_eventos
            ' Cria as colunas
            dgv_eventos.Columns.Add("DataHora", "Data/Hora")
            dgv_eventos.Columns.Add("Descricao", "Descrição")
            dgv_eventos.Columns.Add("Cidade", "Cidade")
            dgv_eventos.Columns.Add("Detalhe", "Detalhe")

            'Ajusta o peso relativo de cada coluna
            .Columns("DataHora").FillWeight = 50
            .Columns("Descricao").FillWeight = 100
            .Columns("Cidade").FillWeight = 40
            .Columns("Detalhe").FillWeight = 125


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
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        dgv_eventos.Rows.Clear()
    End Sub
End Class