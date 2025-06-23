Imports ADODB

Public Class Frmconfig

    Sub Deletar_usuario()
        If dgv_user.SelectedRows.Count = 0 Then
            MsgBox("Selecione uma linha para excluir.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If

        Dim iduser As Integer = CInt(dgv_user.SelectedRows(0).Cells(0).Value)

        If MsgBox("Deseja realmente excluir este produto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            SQL = "DELETE FROM tb_user WHERE id_usuario = " & iduser
            db.Execute(SQL)
            MsgBox("Usuário excluído com sucesso.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Excluído")
            Carregar_usuarios()
        Catch ex As Exception
            MsgBox("Erro ao excluir usuário!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub Carregar_usuarios()
        Try
            Dim dt As New DataTable

            SQL = "SELECT * FROM tb_user"
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            dt.Columns.Add("Id")
            dt.Columns.Add("Usuário")
            dt.Columns.Add("Senha")
            dt.Columns.Add("Nivel de acesso")


            Do While Not rs.EOF
                dt.Rows.Add(
                    rs.Fields("id_usuario").Value,
                    rs.Fields("usuario").Value,
                    rs.Fields("senha").Value,
                    rs.Fields("acesso").Value
                    )
                rs.MoveNext()
            Loop
            rs.Close()
            dgv_user.DataSource = dt

            'Formatar dgv
            With dgv_user
                'Ajusta o peso relativo de cada coluna
                .Columns("Id").FillWeight = 25
                .Columns("Usuário").FillWeight = 75
                .Columns("Senha").FillWeight = 75
                .Columns("Nivel de acesso").FillWeight = 100

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

    Sub Salvar_usuarios()
        Try
            SQL = $"select * from tb_user where usuario= '{txt_usuario.Text}'"
            rs = db.Execute(SQL)
            'Adiciona as informações direto no banco de dados
            If rs.EOF = True Then
                SQL = $"insert into tb_user (usuario,senha,acesso) values ('{txt_usuario.Text}','{txt_senha.Text}','{cmb_acesso.Text}')"
                rs = db.Execute(SQL)

                MsgBox("Usuário Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                cmb_acesso.Text = ""
                Carregar_usuarios()
            End If

        Catch ex As Exception
            MsgBox("Erro ao cadastrar usuario", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frminicial.Show()
        Me.Close()
    End Sub

    Private Sub Frmconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_senha.UseSystemPasswordChar = True
        Carregar_usuarios()
    End Sub

    Private Sub btn_cad_user_Click(sender As Object, e As EventArgs) Handles btn_cad_user.Click
        Salvar_usuarios()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Deletar_usuario()
    End Sub

    Private Sub chk_visulizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visulizar.CheckedChanged
        If chk_visulizar.Checked Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub

End Class