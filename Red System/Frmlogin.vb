Public Class Frmlogin

    Sub Autenticar_login()
        Try
            SQL = $"SELECT COUNT(*) FROM tb_user WHERE usuario = '{txt_usuario.Text}' AND senha = '{txt_senha.Text}'"
            rs = db.Execute(SQL)
            If rs.Fields(0).Value > 0 Then
                MsgBox("Login Bem-Sucedido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")

                SQL = $"select acesso from tb_user where usuario = '{txt_usuario.Text}'"
                rs = db.Execute(SQL)

                If rs.Fields(0).Value.ToString() = "Administrador" Then
                    Frminicial.btn_config.Enabled = True
                Else
                    Frminicial.btn_config.Enabled = False
                End If

                Frminicial.Show()
                Me.Hide()
            Else
                MsgBox("Usuário ou Senha incorretos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")
                txt_senha.Clear()
                txt_usuario.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar usuário no banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub '--> Falta reparar o bloqueio de confiiguração para usuário normal

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Autenticar_login()
    End Sub

    Private Sub chk_visulizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visulizar.CheckedChanged
        If chk_visulizar.Checked Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_senha.UseSystemPasswordChar = True
        Conectar_banco()
    End Sub
End Class