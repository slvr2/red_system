Imports System.Data.SqlClient

Module mod_geral
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dt As New DataTable

    Sub Conectar_banco()
        Try
            If db.State = 1 Then
                db.Close()
            Else
                db = CreateObject("ADODB.Connection")
            End If

            db.Open("Provider=SQLOLEDB;Data Source=IMANI;Initial Catalog=red_system;trusted_connection=yes")
            MsgBox("Conexão Sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

End Module
