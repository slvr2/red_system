Public Class Frminicial
    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        Frmprod.Show()
        Me.Hide()
    End Sub

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click
        Frmclient.Show()
        Me.Hide()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Frmpedido.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        If MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Frmlogin.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        Frmconfig.Show()
        Me.Close()
    End Sub

    Private Sub btn_rastreio_Click(sender As Object, e As EventArgs) Handles btn_rastreio.Click
        Frmrastreio.Show()
        Me.Hide()
    End Sub
End Class