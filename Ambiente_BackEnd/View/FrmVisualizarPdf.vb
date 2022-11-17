Imports Org.pdfclown
Imports PdfiumViewer

Public Class FrmVisualizarPdf
    Dim pdf As New PdfiumViewer.PdfViewer

    Public caminhopdf As String
    Private Sub OpenFileDialog(filePath As String)
        Dim conteudo = System.IO.File.ReadAllBytes(filePath)
        Dim stream = New System.IO.MemoryStream(conteudo)
        Dim meuDocumento As PdfDocument = PdfDocument.Load(stream)
        pdf.Document = meuDocumento
    End Sub
    Private Sub FrmVisualizarPdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pdf = New PdfViewer

        pdf.Width = Me.Width - 40
        pdf.Height = Me.Height - 80
        Controls.Add(pdf)
        OpenFileDialog(caminhopdf)
    End Sub
End Class