Imports System.Net.Mail
Imports FirebirdSql.Data.FirebirdClient
Public Class FrmEnviarEmail
    Public anexoNfe As String
    Public anexoXml As String
    Public anexoBoleto As String
    Public numNota As String
    Public assunto As String
    Private Sub verificaAnexos()
        If (anexoNfe = "") Then
            imgPDF.Visible = False
            lblAnexoPdf.Visible = False
        Else
            imgPDF.Visible = True
            lblAnexoPdf.Visible = True
        End If

        If (anexoXml = "") Then
            imgXML.Visible = False
            lblAnexoXml.Visible = False
        Else
            imgXML.Visible = True
            lblAnexoXml.Visible = True
        End If

        If (anexoBoleto = "") Then
            imgBoleto.Visible = False
            lblAnexoBoleto.Visible = False
        Else
            imgBoleto.Visible = True
            lblAnexoBoleto.Visible = True
        End If
    End Sub
    Private Sub FrmEnviarEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verificaAnexos()
        txtAssunto.Text = assunto
    End Sub
    Private Sub btnAnexar_Click(sender As Object, e As EventArgs) Handles btnAnexar.Click
        Dim anexo = New OpenFileDialog()
        Dim tipo As String
        anexo.Title = "Anexar Arquivo"
        anexo.InitialDirectory = Environment.CurrentDirectory

        If anexo.ShowDialog() = DialogResult.OK Then
            tipo = anexo.FileName
            tipo = tipo.Substring(tipo.Length - 3, 3)
            If tipo = "xml" Then
                anexoXml = anexo.FileName
            End If
            If tipo = "pdf" Then
                anexoNfe = anexo.FileName
            End If
        End If
        verificaAnexos()
    End Sub
    Private Sub EnviarEmail()
        Dim host As String = LerIni("EMAIL", "Server")
        Dim credenciais As String = LerIni("EMAIL", "Usuario")
        Dim senha As String = LerIni("EMAIL", "Senha")
        Dim porta As String = LerIni("EMAIL", "Porta")
        Dim ssl As Boolean = LerIni("EMAIL", "SSL")

        Try
            Using Smtp As New SmtpClient
                Using email As New MailMessage()
                    Smtp.Host = host
                    Smtp.UseDefaultCredentials = False
                    Smtp.Credentials = New Net.NetworkCredential(credenciais, senha)
                    Smtp.Port = porta
                    Smtp.EnableSsl = ssl

                    email.From = New MailAddress(credenciais)
                    email.To.Add(txtDestinatario.Text)
                    email.Subject = txtAssunto.Text
                    email.IsBodyHtml = False
                    email.Body = rtbMensagem.Text

                    If anexoXml <> "" Then
                        email.Attachments.Add(New Attachment(anexoXml))
                    End If
                    If anexoNfe <> "" Then
                        email.Attachments.Add(New Attachment(anexoNfe))
                    End If
                    
                    Smtp.Send(email)
                End Using
            End Using
            MsgBox("Email Enviado", vbInformation, "Ambiente Soft")
        Catch ex As Exception
            MsgBox("Erro:" & ex.Message)
        End Try
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        EnviarEmail()
    End Sub
    Private Sub ConsultaCliente(codColaborador As String)
        Dim sql As String
        sql = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & codColaborador

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)
        drLocal = cmd.ExecuteReader

        While drLocal.Read()
            txtDestinatario.Text = drLocal("EMAIL").ToString
        End While
    End Sub
    Private Sub FrmEnviarEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Dim sql As String
            Dim numNota As String = InputBox("Digite o numero da nota", "Ambiente Soft")

            If (numNota <> "") Then
                sql = "SELECT * FROM NOTAFISCAL WHERE NUMNOTA = " & numNota

                conexaoLocal.Close()
                conexaoLocal.ConnectionString = bancoLocal
                conexaoLocal.Open()

                Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)
                drLocal = cmd.ExecuteReader

                While drLocal.Read()
                    anexoXml = drLocal("CAMINHOXML").ToString
                    anexoNfe = drLocal("CAMINHOPDF").ToString
                    ConsultaCliente(drLocal("CODCOLABORADOR"))
                    verificaAnexos()
                End While
            End If
        End If
    End Sub
End Class