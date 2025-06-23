Imports System.Data.SqlClient
Imports System.IO
Imports ADODB

Public Class Frm_cad_client

    Private clienteID As Integer = -1

    Sub Salvar_cliente()
        Dim imagem() As Byte = Nothing

        If img_foto.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                Dim bmp As New Bitmap(img_foto.Image)
                bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                imagem = ms.ToArray()
            End Using
        End If

        Try
            SQL = $"select * from tb_clientes where id_clientes= '{txt_cod.Text}'"
            rs = db.Execute(SQL)
            'Adiciona as informações direto no banco de dados
            If rs.EOF = True Then
                SQL = $"insert into tb_clientes (id_clientes,nome,cpf,cnpj,celular,email,cep,endereco,cidade,estado,complem) values ('{txt_cod.Text}','{txt_cliente.Text}','{txt_cpf.Text}','{txt_cnpj.Text}','{txt_celular.Text}','{txt_email.Text}','{txt_cep.Text}','{txt_endereco.Text}','{txt_cidade.Text}','{txt_estado.Text}','{txt_comp.Text}')"
                rs = db.Execute(SQL)

                'Atualiza as Imagens no mesmo campo
                SQL = $"select * from tb_clientes where id_clientes = '{txt_cod.Text}'"
                rs = New ADODB.Recordset
                rs.Open(SQL, db, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                If rs.EOF = False Then
                    rs.Fields("foto").Value = imagem
                    rs.Update()
                End If

                MsgBox("Cliente Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                rs.Close()
                Me.Close()
                Frmclient.Close()
                Frmclient.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Cadastrar Cliente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub '--> OK

    Sub Carregar_clientes()
        Try
            SQL = "SELECT * FROM tb_clientes WHERE id_clientes = " & clienteID
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                txt_cod.Text = rs.Fields("id_clientes").Value.ToString()
                txt_cliente.Text = rs.Fields("nome").Value.ToString()
                txt_endereco.Text = rs.Fields("endereco").Value.ToString()
                txt_cidade.Text = rs.Fields("cidade").Value.ToString()
                txt_estado.Text = rs.Fields("estado").Value.ToString()
                txt_cep.Text = rs.Fields("cep").Value.ToString()
                txt_cpf.Text = rs.Fields("cpf").Value.ToString()
                txt_cnpj.Text = rs.Fields("cnpj").Value.ToString()
                txt_email.Text = rs.Fields("email").Value.ToString()
                txt_celular.Text = rs.Fields("celular").Value.ToString()
                txt_comp.Text = rs.Fields("complem").Value.ToString()

                If Not IsDBNull(rs.Fields("foto").Value) Then
                    Dim bytes() As Byte = rs.Fields("foto").Value
                    Using ms As New IO.MemoryStream(bytes)
                        img_foto.Image = Image.FromStream(ms)
                    End Using
                End If
            End If

            rs.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados do cliente: " & ex.Message)
        End Try
    End Sub '--> OK

    Sub Atualizar_clientes()
        Try
            SQL = "SELECT * FROM tb_clientes WHERE id_clientes = " & clienteID
            rs = New ADODB.Recordset
            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If rs.EOF = False Then
                rs.Fields("id_clientes").Value = txt_cod.Text
                rs.Fields("nome").Value = txt_cliente.Text
                rs.Fields("endereco").Value = txt_endereco.Text
                rs.Fields("cidade").Value = txt_cidade.Text
                rs.Fields("estado").Value = txt_estado.Text
                rs.Fields("cep").Value = txt_cep.Text
                rs.Fields("cpf").Value = txt_cpf.Text
                rs.Fields("cnpj").Value = txt_cnpj.Text
                rs.Fields("email").Value = txt_email.Text
                rs.Fields("celular").Value = txt_celular.Text
                rs.Fields("complem").Value = txt_comp.Text

                If img_foto.Image IsNot Nothing Then
                    Using ms As New IO.MemoryStream()
                        Dim bmp As New Bitmap(img_foto.Image)
                        bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                        rs.Fields("foto").Value = ms.ToArray()
                    End Using
                End If

                rs.Update()
                rs.Close()
                MsgBox("Cliente atualizado com sucesso!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao atualizar cliente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub '--> OK

    Public Sub New()
        InitializeComponent()
        clienteID = -1
    End Sub '--> OK

    Public Sub New(id_clientes As Integer)
        InitializeComponent()
        clienteID = id_clientes
    End Sub '--> OK

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Frmclient.Show()
        Me.Close()
    End Sub '--> OK

    Private Sub btn_save_client_Click(sender As Object, e As EventArgs) Handles btn_save_client.Click
        If clienteID = -1 Then
            Salvar_cliente()
        Else
            Atualizar_clientes()
        End If
    End Sub '--> OK

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto do cliente"
                .InitialDirectory = "C:\Users\" & Environment.UserName & "\Downloads"
                .Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"

                If .ShowDialog() = DialogResult.OK Then
                    diretorio = .FileName
                    Using fs As New FileStream(.FileName, FileMode.Open, FileAccess.Read)
                        img_foto.Image = Image.FromStream(fs)
                    End Using
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub '--> OK

    Private Sub Frm_cad_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not clienteID = -1 Then
            Carregar_clientes()
        End If
    End Sub '--> OK
End Class

'--> •Verificar Textboxes para que cada uma contenha o tamanho correto de caracteres igual ao permitido no banco•
'--> •Verificar Imagens para ficarem com a propriedade ->Strech<-•
