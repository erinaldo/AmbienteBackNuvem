Imports System.IO
Imports System.Xml
Imports FirebirdSql.Data.FirebirdClient
Imports ZionDanfe
Imports ZionDanfe.Modelo

Public Class FrmNotasEmitidas
    Dim caminhoDanfe As String
    Dim caminhoXml As String
    Dim chaveAcesso As String
    Dim natOp As String
    Dim numNota As String
    Dim valorNota As String
    Dim statusRetorno As String
    Dim cstat As String
    Dim formaPagto As String
    Dim nomeColaborador As String
    Private Sub btnPesqusiar_Click(sender As Object, e As EventArgs) Handles btnPesqusiar.Click
        Dim ds As New DataSet
        Dim periodoConverte As String
        Dim ateConverte As String

        periodoConverte = Replace("'" & txtperiodo.Text & "'", "/", ".")
        ateConverte = Replace("'" & txtate.Text & "'", "/", ".")

        If (periodoConverte = "'  .  .'") Then daLocal = New FbDataAdapter("SELECT NOTAFISCAL.NUMNOTA,NOTAFISCAL.CODCFOP,NOTAFISCAL.CODFORMAPAGTO,NOTAFISCAL.COLABORADOR,NOTAFISCAL.TOTALNFE,NOTAFISCAL.STATUS FROM NOTAFISCAL", conexaoLocal)

        daLocal.Fill(ds)
        dgProdutosVendidos.DataSource = ds.Tables(0)
        'calculaTotal()
        If dgProdutosVendidos.RowCount = 0 Then MsgBox("Nenhum registro encontrado", MsgBoxStyle.Exclamation, "Aviso !")
    End Sub

    Private Sub dgProdutosVendidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProdutosVendidos.CellClick

        If e.ColumnIndex = btnVisualizar.Index AndAlso e.RowIndex >= 0 Then
            Dim caminhoPDF As String
            Dim currentRow As DataGridViewRow = dgProdutosVendidos.Rows(e.RowIndex)
            Dim sql As String = "SELECT * FROM NOTAFISCAL WHERE NUMNOTA = " & currentRow.Cells(0).Value

            Try
                conexaoLocal.Close()
                conexaoLocal.Open()
                Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)

                drLocal = cmd.ExecuteReader
                While drLocal.Read()
                    caminhoPDF = drLocal("CAMINHOPDF").ToString
                End While
                FrmVisualizarPdf.caminhopdf = caminhoPDF
                FrmVisualizarPdf.ShowDialog()
            Catch ex As Exception
                MsgBox("Erro ao visualizar nota: " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub GerarDanfe(ByVal xml As String, ByVal arquivo As String)
        Dim gerar = LerIni("Danfe", "GerarDanfe")

        If gerar <> "1" Then MessageBox.Show("Não configurado para visualizar DANFE, entre em contato com o administrador.")
        Try
            Dim modelo = DanfeViewModelCreator.CriarDeArquivoXml(xml)
            Dim danfe = New Danfe(modelo)
            danfe.Gerar()

            Dim diretorio As String = Path.Combine(Environment.CurrentDirectory + "\DANFE\", DateTime.Now.ToString("yyyyMM"))

            Directory.CreateDirectory(diretorio)

            danfe.Salvar(Path.Combine(diretorio, arquivo))
            caminhoDanfe = Path.Combine(diretorio, arquivo)
            InserirNota()
        Catch ex As Exception
            MsgBox("Erro ao gerar o Danfe: " + ex.Message, MsgBoxStyle.Critical)
            Process.Start("C:\Unimake\UniNFe\unidanfe.exe")
        End Try
    End Sub
    Private Sub LerXML()
        Try
            Using arqXml = XmlReader.Create(caminhoXml)
                While arqXml.Read()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "chNFe" Then chaveAcesso = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "natOp" Then natOp = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "nNF" Then numNota = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "vNF" Then valorNota = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "xMotivo" Then statusRetorno = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "tPag" Then formaPagto = arqXml.ReadElementString()
                    If arqXml.NodeType = XmlNodeType.Element And arqXml.Name = "xNome" Then nomeColaborador = arqXml.ReadElementString()
                End While
            End Using
            GerarDanfe(caminhoXml, numNota + ".pdf")
        Catch ex As Exception
            MsgBox("Erro ao inserir nota no banco de dados: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ConsultaCfop()
        Dim sql As String = "SELECT * FROM CFOP WHERE NOME_CFO = '" & natOp & "'"

        Try
            conexaoLocal.Close()
            conexaoLocal.Open()
            Dim cmd As FbCommand = New FbCommand(sql, conexaoLocal)

            drLocal = cmd.ExecuteReader
            While drLocal.Read()
                natOp = drLocal("CODCFOP").ToString
            End While
        Catch ex As Exception
            MsgBox("Erro ao consultar cfop: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub InserirNota()
        Dim sql As String
        Try
            ConsultaCfop()
            sql = "INSERT INTO NOTAFISCAL (COLABORADOR,NUMNOTA,CAMINHOXML,CAMINHOPDF,CHAVEACESSO,TOTALNFE,CODCFOP,CODFORMAPAGTO,STATUS) VALUES
                                          (@COLABORADOR,@NUMNOTA,@CAMINHOXML,@CAMINHOPDF,@CHAVEACESSO,@TOTALNFE,@CODCFOP,@CODFORMAPAGTO,@STATUS)"

            comandoLocal = New FbCommand(sql, conexaoLocal)

            comandoLocal.Parameters.AddWithValue("@COLABORADOR", nomeColaborador)
            comandoLocal.Parameters.AddWithValue("@NUMNOTA", numNota)
            comandoLocal.Parameters.AddWithValue("@CAMINHOXML", caminhoXml)
            comandoLocal.Parameters.AddWithValue("@CAMINHOPDF", caminhoDanfe)
            comandoLocal.Parameters.AddWithValue("@CHAVEACESSO", chaveAcesso)
            comandoLocal.Parameters.AddWithValue("@TOTALNFE", valorNota)
            comandoLocal.Parameters.AddWithValue("@CODCFOP", natOp)
            comandoLocal.Parameters.AddWithValue("@CODFORMAPAGTO", formaPagto)
            comandoLocal.Parameters.AddWithValue("@STATUS", statusRetorno)

            conexaoLocal.Close()
            conexaoLocal.Open()
            comandoLocal.ExecuteNonQuery()
            conexaoLocal.Close()

            MsgBox("NOTA INSERIDA COM SUCESSO!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Erro ao inserir nota: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub INSERIRNOTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERIRNOTAToolStripMenuItem.Click
        Dim arquivoDANFE = New OpenFileDialog()
        arquivoDANFE.Title = "Abrir Arquivo XML"
        arquivoDANFE.InitialDirectory = Environment.CurrentDirectory
        arquivoDANFE.Filter = "todos arquivos|*.xml"

        If arquivoDANFE.ShowDialog() = DialogResult.OK Then caminhoXml = (arquivoDANFE.FileName)
        LerXML()
    End Sub

    Private Sub dgProdutosVendidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgProdutosVendidos.CellFormatting
        For Each Linha As DataGridViewRow In dgProdutosVendidos.Rows
            If Linha.Cells(5).Value Is DBNull.Value Then Linha.Cells(5).Value = False
            If Linha.Cells(5).Value <> "Autorizado o uso da NF-e" Then Linha.Cells(5).Style.ForeColor = ForeColor.Red

        Next
    End Sub
End Class