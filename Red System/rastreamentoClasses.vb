Public Class ApiResponse
    Public Property json As String
    Public Property carrier As String
End Class

Public Class DtHrCriado
    Public Property [date] As String
    Public Property timezone_type As Integer
    Public Property timezone As String
End Class

Public Class Endereco
    Public Property identificacao As String
    Public Property principal As String
    Public Property numero As String
    Public Property logradouro As String
    Public Property complemento As String
    Public Property bairro As String
    Public Property cidade As String
    Public Property uf As String
    Public Property codigoPostal As String
    Public Property siglaPais As String
End Class

Public Class Unidade
    Public Property nome As String
    Public Property codSro As String
    Public Property codMcu As String
    Public Property tipo As String
    Public Property endereco As Endereco
End Class

Public Class Evento
    Public Property codigo As String
    Public Property tipo As String
    Public Property dtHrCriado As DtHrCriado
    Public Property descricao As String
    Public Property unidade As Unidade
    Public Property unidadeDestino As Unidade
    Public Property comentario As String
    Public Property icone As String
    Public Property descricaoFrontEnd As String
    Public Property finalizador As String
    Public Property rota As String
    Public Property descricaoWeb As String
    Public Property detalhe As String
    Public Property destinatario As String
    Public Property cached As Boolean
End Class

Public Class RastreioDetalhado
    Public Property codObjeto As String
    Public Property tipoPostal As Object ' Se quiser detalhar, crie uma classe
    Public Property dtPrevista As String
    Public Property modalidade As String
    Public Property eventos As List(Of Evento)
    Public Property situacao As String
    Public Property autoDeclaracao As Boolean
    Public Property encargoImportacao As Boolean
    Public Property percorridaCarteiro As Boolean
    Public Property bloqueioObjeto As Boolean
    Public Property arEletronico As Boolean
    Public Property arImagem As Object
    Public Property locker As Boolean
    Public Property atrasado As Boolean
    Public Property urlFaleComOsCorreios As String
    Public Property temEventoEntrega As Boolean
End Class
