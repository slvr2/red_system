Imports System.Data.SqlClient
Imports System.IO
Imports ADODB

Public Class Frm_cad_prod

    Private produtoID As Integer = -1

    Public Sub New()
        InitializeComponent()
        produtoID = -1
    End Sub

    Public Sub New(id_produtos As Integer)
        InitializeComponent()
        produtoID = id_produtos
    End Sub

    Sub Salvar_produto()
        Dim imagem01() As Byte = Nothing
        Dim imagem02() As Byte = Nothing

        If img_foto01.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                Dim bmp As New Bitmap(img_foto01.Image)
                bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                imagem01 = ms.ToArray()
            End Using
        End If

        If img_foto02.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                Dim bmp As New Bitmap(img_foto02.Image)
                bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                imagem02 = ms.ToArray()
            End Using
        End If

        Try
            SQL = $"select * from tb_produtos where id_produtos= '{txt_cod.Text}'"
            rs = db.Execute(SQL)
            'Adiciona as informações direto no banco de dados
            If rs.EOF = True Then
                SQL = $"insert into tb_produtos (id_produtos,nome,data_criacao,descricao,preco_venda,preco_custo,altura,largura,comp,peso,material,fornecedor) values ('{txt_cod.Text}','{txt_produto.Text}','{txt_data_criacao.Text}','{txt_descricao.Text}','{txt_venda.Text}','{txt_custo.Text}','{txt_alt.Text}','{txt_larg.Text}','{txt_comp.Text}','{txt_peso.Text}','{txt_material.Text}','{txt_fornecedor.Text}')"
                rs = db.Execute(SQL)

                'Atualiza as Imagens no mesmo campo
                SQL = $"select * from tb_produtos where id_produtos = '{txt_cod.Text}'"
                rs = New ADODB.Recordset
                rs.Open(SQL, db, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                If rs.EOF = False Then
                    rs.Fields("foto1").Value = imagem01
                    rs.Fields("foto2").Value = imagem02
                    rs.Update()
                End If

                MsgBox("Produto Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                rs.Close()
                Me.Close()
                Frmprod.Close()
                Frmprod.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro ao cadastrar produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub Atualizar_produto()
        Try
            SQL = "SELECT * FROM tb_produtos WHERE id_produtos = " & produtoID
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If rs.EOF = False Then
                rs.Fields("id_produtos").Value = txt_cod.Text
                rs.Fields("nome").Value = txt_produto.Text
                rs.Fields("descricao").Value = txt_descricao.Text
                rs.Fields("data_criacao").Value = txt_data_criacao.Text
                rs.Fields("preco_venda").Value = txt_venda.Text
                rs.Fields("preco_custo").Value = txt_custo.Text
                rs.Fields("altura").Value = txt_alt.Text
                rs.Fields("largura").Value = txt_larg.Text
                rs.Fields("comp").Value = txt_comp.Text
                rs.Fields("peso").Value = txt_peso.Text
                rs.Fields("material").Value = txt_material.Text
                rs.Fields("fornecedor").Value = txt_fornecedor.Text

                If img_foto01.Image IsNot Nothing Then
                    Using ms As New IO.MemoryStream()
                        Dim bmp As New Bitmap(img_foto01.Image)
                        bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                        rs.Fields("foto1").Value = ms.ToArray()
                    End Using
                End If

                If img_foto02.Image IsNot Nothing Then
                    Using ms As New IO.MemoryStream()
                        Dim bmp As New Bitmap(img_foto02.Image)
                        bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                        rs.Fields("foto2").Value = ms.ToArray()
                    End Using
                End If

                rs.Update()
                rs.Close()
                MsgBox("Produto atualizado com sucesso!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao atualizar produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub Carregar_produtos()
        Try
            SQL = "SELECT * FROM tb_produtos WHERE id_produtos = " & produtoID
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                txt_cod.Text = rs.Fields("id_produtos").Value.ToString()
                txt_produto.Text = rs.Fields("nome").Value.ToString()
                txt_descricao.Text = rs.Fields("descricao").Value.ToString()
                txt_data_criacao.Text = rs.Fields("data_criacao").Value.ToString()
                txt_venda.Text = rs.Fields("preco_venda").Value.ToString()
                txt_custo.Text = rs.Fields("preco_custo").Value.ToString()
                txt_alt.Text = rs.Fields("altura").Value.ToString()
                txt_larg.Text = rs.Fields("largura").Value.ToString()
                txt_comp.Text = rs.Fields("comp").Value.ToString()
                txt_peso.Text = rs.Fields("peso").Value.ToString()
                txt_material.Text = rs.Fields("material").Value.ToString()
                txt_fornecedor.Text = rs.Fields("fornecedor").Value.ToString()

                If Not IsDBNull(rs.Fields("foto1").Value) Then
                    Dim bytes() As Byte = rs.Fields("foto1").Value
                    Using ms As New IO.MemoryStream(bytes)
                        img_foto01.Image = Image.FromStream(ms)
                    End Using
                End If

                If Not IsDBNull(rs.Fields("foto2").Value) Then
                    Dim bytes() As Byte = rs.Fields("foto2").Value
                    Using ms As New IO.MemoryStream(bytes)
                        img_foto02.Image = Image.FromStream(ms)
                    End Using
                End If
            End If

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar dados do cliente!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frmprod.Show()
        Me.Close()
    End Sub

    Private Sub img_foto01_Click(sender As Object, e As EventArgs) Handles img_foto01.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto do cliente"
                .InitialDirectory = "C:\Users\" & Environment.UserName & "\Downloads"
                .Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"

                If .ShowDialog() = DialogResult.OK Then
                    diretorio = .FileName
                    Using fs As New FileStream(.FileName, FileMode.Open, FileAccess.Read)
                        img_foto01.Image = Image.FromStream(fs)
                    End Using
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub img_foto02_Click(sender As Object, e As EventArgs) Handles img_foto02.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto do cliente"
                .InitialDirectory = "C:\Users\" & Environment.UserName & "\Downloads"
                .Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"

                If .ShowDialog() = DialogResult.OK Then
                    diretorio = .FileName
                    Using fs As New FileStream(.FileName, FileMode.Open, FileAccess.Read)
                        img_foto02.Image = Image.FromStream(fs)
                    End Using
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_save_prod_Click(sender As Object, e As EventArgs) Handles btn_save_prod.Click
        If produtoID = -1 Then
            Salvar_produto()
        Else
            Atualizar_produto()
        End If
    End Sub

    Private Sub Frm_cad_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not produtoID = -1 Then
            Carregar_produtos()
        End If
    End Sub

End Class