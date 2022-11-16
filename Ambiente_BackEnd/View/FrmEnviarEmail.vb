Public Class FrmEnviarEmail
    Public anexoNfe As String
    Public anexoXml As String
    Public anexoBoleto As String
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
End Class