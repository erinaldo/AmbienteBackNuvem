Imports System.IO
Imports System.Xml
Imports FirebirdSql.Data.FirebirdClient
Imports ZionDanfe
Imports ZionDanfe.Modelo
Imports PdfiumViewer


Module mdl_emitirnfe
    Dim pdf As New PdfiumViewer.PdfViewer
    Dim cnpjCpf As String
    Dim razaoSocial As String
    Dim logradouro As String
    Dim numero As String
    Dim cpl As String
    Dim Bairro As String
    Dim cMunicipio As String
    Dim xMunicipio As String
    Dim UF As String
    Dim cep As String
    Dim cPais As String
    Dim xPais As String
    Dim fone As String
    Dim inscEstadual As String
    Dim email As String
    Dim ufDest As String
    Dim chaveAcesso As String
    Dim aliquotaProdutos As Decimal
    Dim aliqTotal As Decimal

    Public codCliente As String
    Public cNF As String
    Public proxnumero As String
    Public arquivoRetorno As String

    Public Sub ArqRetorno()
        Dim cnpjEmitente As String = LerIni("Empresa", "CNPJ")
        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo("C:\Unimake\UniNFe\" & cnpjEmitente & "\Retorno")
        Dim oFileInfoCollection() As FileInfo
        Dim oFileInfo As FileInfo
        Dim i As Integer

        oFileInfoCollection = DirDiretorio.GetFiles("*-pro-rec.xml")

        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            arquivoRetorno = oFileInfo.Name
        Next
    End Sub

    Public Sub Retorno()
        Dim cnpjEmitente As String = LerIni("Empresa", "CNPJ")
        Dim vcaminhoRetorno = "C:\Unimake\UniNFe\" & cnpjEmitente & "\Retorno\"
        Dim isEmitente = False
        Dim arquivo As String
        Dim cstat As String

        ArqRetorno()
        arquivo = vcaminhoRetorno + arquivoRetorno
        Using meuXml = XmlReader.Create(arquivo)
            While meuXml.Read()
                If meuXml.NodeType = XmlNodeType.Element And meuXml.Name = "infProt" Then
                    isEmitente = True
                ElseIf meuXml.NodeType = XmlNodeType.Element And meuXml.Name = "infProt" Then
                    Exit While
                End If
                If isEmitente Then
                    If meuXml.NodeType = XmlNodeType.Element And meuXml.Name = "cStat" Then
                        cstat = meuXml.ReadElementContentAsString()
                    End If
                    If meuXml.NodeType = XmlNodeType.Element And meuXml.Name = "xMotivo" Then
                        If cstat = "100" Then
                            MsgBox(meuXml.ReadElementContentAsString(), MsgBoxStyle.Information, "Ambiente Soft")
                        Else
                            MsgBox(meuXml.ReadElementContentAsString(), MsgBoxStyle.Critical, "Ambiente Soft")
                        End If
                    End If
                End If
            End While
        End Using
    End Sub
    Public Sub BuscaCliente(codigoCliente As String)
        Dim strColaborador As String
        strColaborador = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & codigoCliente

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmdItens As FbCommand = New FbCommand(strColaborador, conexaoLocal)
        drLocal = cmdItens.ExecuteReader

        While drLocal.Read()
            cnpjCpf = drLocal("CNPJ_CPF").ToString
            razaoSocial = drLocal("RAZAOSOCIAL").ToString
            logradouro = drLocal("LOGRADOURO").ToString
            numero = drLocal("NUMERO").ToString
            Bairro = drLocal("BAIRRO").ToString
            cMunicipio = drLocal("CODIGOIBGE").ToString
            xMunicipio = drLocal("MUNICIPIO").ToString
            UF = drLocal("ESTADO").ToString
            cep = drLocal("CEP").ToString
            'cPais = drLocal("").ToString
            'xPais = drLocal("").ToString
            fone = drLocal("TELEFONE_1").ToString
            inscEstadual = drLocal("INSCESTADUAL").ToString
            email = drLocal("EMAIL").ToString
        End While
    End Sub
    Public Function FormataZerosEsq(ByVal Valor As String, ByVal nZeros As String)
        FormataZerosEsq = Valor.PadLeft(nZeros, "0")
    End Function
    Function DVmod11(vNr As String) As Integer
        'Função retirada do site: http://comunidade.itlab.com.br/eve/forums/a/tpc/f/273606921/m/6817001723?r=6817001723#6817001723
        On Error GoTo erro
        Dim vchave As String
        Dim i As Integer, vSoma As Long, vMult As Byte
        vSoma = 0
        vMult = 2
        For i = Len(vNr) To 1 Step -1
            If vMult = 10 Then vMult = 2
            vSoma = vSoma + CInt(Mid(vNr, i, 1)) * vMult
            vMult = vMult + 1
        Next
        If vSoma Mod 11 = 0 Or vSoma Mod 11 = 1 Then
            DVmod11 = 0
        Else
            DVmod11 = 11 - (vSoma Mod 11)
        End If
        'MsgBox DVmod11
Sair:
        Exit Function
erro:
        ' MsgBox Err.Description, vbCritical + vbOKOnly, "Erro na Função DVmod11"
        Resume Sair
    End Function
    Public Sub GeraChaveAcesso(nNota As String, codCfop As String, IndiPresenca As String, IndiIntermediario As String)
        Dim serie As String = "001"
        Dim tpamb As Integer
        Dim datachave As DateTime = DateTime.Now
        Dim Dataconvertida As String
        Dim xchave As String
        Dim inicio As Integer
        Dim fim As Integer
        Dim result As Integer
        Dim cnpjEmitente As String
        inicio = 0
        fim = 10000000
        Dim numeroale As Integer
        Dim GeradorDeNumerosAleatorios As Random = New Random()
        numeroale = GeradorDeNumerosAleatorios.Next(inicio, fim)
        result = numeroale
        cNF = result
        cNF = FormataZerosEsq(cNF, 8)

        Dataconvertida = datachave.ToString("yyMM")
        tpamb = LerIni("ide", "tpamb")
        cnpjEmitente = LerIni("Empresa", "CNPJ")
        serie = "001"
        proxnumero = nNota
        proxnumero = FormataZerosEsq(proxnumero, 9)
        chaveAcesso = 35 & Format(Dataconvertida) & cnpjEmitente & 55 & serie & proxnumero & tpamb & cNF
        xchave = chaveAcesso
        Dim left, right As String
        left = xchave.Substring(0, 1)
        If left = 0 Then
            right = xchave.Substring(0, 44)
            xchave = 3 + right
        End If
        xchave = DVmod11(xchave)
        chaveAcesso = (chaveAcesso & xchave)

        mdl_emitirnfe.EmitirRegimeSimplesNacional(chaveAcesso, "", nNota, cNF, "55", codCfop, IndiPresenca, IndiIntermediario, 20.3, xchave, FrmNotaFiscalEletronica.rtbInformaçõesComplementares.Text)
    End Sub
    Private Sub ConsultaProduto(codProduto As String)
        Dim strProduto As String
        strProduto = "SELECT * FROM PRODUTOS WHERE CODPRODUTO = " & codProduto

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmdItens As FbCommand = New FbCommand(strProduto, conexaoLocal)
        drLocal = cmdItens.ExecuteReader

        While drLocal.Read()
            aliquotaProdutos = CDec(drLocal("ALIQTOTAL").ToString)
            aliqTotal = aliqTotal + aliquotaProdutos
        End While
    End Sub
    Public Sub EmitirRegimeSimplesNacional(chaveAcesso As String, chaveAcessoDevolucao As String, numeroNota As String, cNF As String, tipoNfe As String, codCfop As String, indPres As String, indInter As String, totalImpostos As String, digitoVerificador As String, InfAdicional As String)
        Dim cnpjEmitente As String = LerIni("Empresa", "Cnpj")
        Dim dataAtual As DateTime = DateTime.Now
        Dim data As String = dataAtual.ToString("yyyy-MM-dd")
        Dim vCaminho As String = "C:\Unimake\UniNFe\" & cnpjEmitente & "\Envio\"
        Dim arquivo As String = vCaminho + chaveAcesso + "-nfe.xml"
        Dim sNamespace As [String] = "http://www.portalfiscal.inf.br/nfe"
        Dim xWriter As XmlWriter = XmlWriter.Create(arquivo)
        Dim left As String
        Dim dest As String

        dest = cMunicipio
        left = dest.Substring(0, 2)
        dest = left

        ufDest = dest

        If dest = 35 Then
            dest = 1
        Else
            dest = 2
        End If

        If tipoNfe = "SAIDA" Then
            tipoNfe = 1
        Else
            tipoNfe = 0
        End If

        'CABEÇALHO DA NOTA--------------------------------------------------------------------
        xWriter.WriteStartElement("NFe", sNamespace)

        xWriter.WriteStartElement("infNFe")
        xWriter.WriteAttributeString("versao", "4.00")
        xWriter.WriteAttributeString("Id", "NFe" & chaveAcesso)

        'INICIO IDE---------------------------------------------------------------------------
        xWriter.WriteStartElement("ide")
        xWriter.WriteStartElement("cUF")
        xWriter.WriteValue(LerIni("ide", "cUF"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cNF")
        xWriter.WriteValue(cNF)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("natOp")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtDescricaoCfop.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("mod")
        xWriter.WriteValue("55")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("serie")
        xWriter.WriteValue("1")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("nNF")
        xWriter.WriteValue(numeroNota)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("dhEmi")
        xWriter.WriteValue(data + "T" + FormatDateTime(dataAtual, DateFormat.LongTime) + "-03:00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("dhSaiEnt")
        xWriter.WriteValue(data + "T" + FormatDateTime(dataAtual, DateFormat.LongTime) + "-03:00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("tpNF")
        xWriter.WriteValue("1")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("idDest")
        xWriter.WriteValue(dest)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cMunFG")
        xWriter.WriteValue(LerIni("ide", "cMunFG"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("tpImp")
        xWriter.WriteValue(LerIni("ide", "tpimp"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("tpEmis")
        xWriter.WriteValue(LerIni("ide", "tpemis"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cDV")
        xWriter.WriteValue(digitoVerificador)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("tpAmb")
        xWriter.WriteValue(LerIni("ide", "tpamb"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("finNFe")
        xWriter.WriteValue(LerIni("ide", "finNFe"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("indFinal")
        xWriter.WriteValue(LerIni("ide", "indfinal"))
        xWriter.WriteEndElement()

        If (indPres = "0") Or (indPres = "1") Or (indPres = "5") Then
            xWriter.WriteStartElement("indPres")
            xWriter.WriteValue(indPres)
            xWriter.WriteEndElement()
        Else
            xWriter.WriteStartElement("indPres")
            xWriter.WriteValue(indPres)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("indIntermed")
            xWriter.WriteValue(indInter)
            xWriter.WriteEndElement()
        End If

        xWriter.WriteStartElement("procEmi")
        xWriter.WriteValue(LerIni("ide", "procEmi"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("verProc")
        xWriter.WriteValue("4.00")
        xWriter.WriteEndElement()

        If chaveAcessoDevolucao <> "" Then
            xWriter.WriteStartElement("NFref")
            xWriter.WriteStartElement("refNFe")
            xWriter.WriteValue(chaveAcessoDevolucao)
            xWriter.WriteEndElement()
            xWriter.WriteEndElement()

            xWriter.WriteEndElement()
        Else
            xWriter.WriteEndElement()
        End If

        xWriter.WriteStartElement("emit")
        xWriter.WriteStartElement("CNPJ")
        xWriter.WriteValue(LerIni("emit", "cnpj"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xNome")
        xWriter.WriteValue(LerIni("emit", "xNome"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xFant")
        xWriter.WriteValue(LerIni("emit", "xFantasia"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("enderEmit")

        xWriter.WriteStartElement("xLgr")
        xWriter.WriteValue(LerIni("emit", "xLgr"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("nro")
        xWriter.WriteValue(LerIni("emit", "nro"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xBairro")
        xWriter.WriteValue(LerIni("emit", "xBairro"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cMun")
        xWriter.WriteValue(LerIni("emit", "cMun"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xMun")
        xWriter.WriteValue(LerIni("emit", "xMun"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("UF")
        xWriter.WriteValue(LerIni("emit", "uf"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("CEP")
        xWriter.WriteValue(LerIni("emit", "CEP"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cPais")
        xWriter.WriteValue(LerIni("emit", "cPais"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xPais")
        xWriter.WriteValue(LerIni("Emit", "xPais"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("fone")
        xWriter.WriteValue(LerIni("emit", "fone"))
        xWriter.WriteEndElement()

        xWriter.WriteEndElement()

        xWriter.WriteStartElement("IE")
        xWriter.WriteValue(LerIni("emit", "IE"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("CRT")
        xWriter.WriteValue(LerIni("emit", "CRT"))
        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        'INICIO DEST--------------------------------------------------------------

        xWriter.WriteStartElement("dest")

        Dim doc As String
        doc = cnpjCpf
        If Len(doc) > "11" Then
            xWriter.WriteStartElement("CNPJ")
            xWriter.WriteValue(cnpjCpf)
            xWriter.WriteEndElement()
        Else
            xWriter.WriteStartElement("CPF")
            xWriter.WriteValue(cnpjCpf)
            xWriter.WriteEndElement()
        End If

        xWriter.WriteStartElement("xNome")
        xWriter.WriteValue(razaoSocial)
        xWriter.WriteEndElement()

        'INICIO ENDERDEST------------------------------------------------------------
        xWriter.WriteStartElement("enderDest")

        xWriter.WriteStartElement("xLgr")
        xWriter.WriteValue(logradouro)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("nro")
        xWriter.WriteValue(numero)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xCpl")
        xWriter.WriteValue("1")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xBairro")
        xWriter.WriteValue(Bairro)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cMun")
        xWriter.WriteValue(cMunicipio)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xMun")
        xWriter.WriteValue(xMunicipio)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("UF")
        xWriter.WriteValue(UF)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("CEP")
        xWriter.WriteValue(cep)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cPais")
        xWriter.WriteValue("1058")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("xPais")
        xWriter.WriteValue("Brasil")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("fone")
        xWriter.WriteValue(fone)
        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        If inscEstadual = "ISENTO" Then
            xWriter.WriteStartElement("indIEDest")
            xWriter.WriteValue(9)
            xWriter.WriteEndElement()
        Else
            xWriter.WriteStartElement("indIEDest")
            xWriter.WriteValue(1)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("IE")
            xWriter.WriteValue(inscEstadual)
            xWriter.WriteEndElement()
        End If

        xWriter.WriteStartElement("email")
        xWriter.WriteValue(email)
        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        Dim item As String = 1

        For Each linha As DataGridViewRow In FrmNotaFiscalEletronica.dgNotaFiscal.Rows
            Dim ncm As String = linha.Cells(4).Value
            Dim cfop As String = linha.Cells(2).Value
            'ConsultaProduto(linha.Cells(0).Value)
            xWriter.WriteStartElement("det")
            xWriter.WriteAttributeString("nItem", item)

            xWriter.WriteStartElement("prod")

            xWriter.WriteStartElement("cProd")
            xWriter.WriteValue(linha.Cells(0).Value)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement(CStr("cEAN"))
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("xProd")
            xWriter.WriteValue(linha.Cells(1).Value)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("NCM")
            xWriter.WriteValue(ncm)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("CFOP")
            xWriter.WriteValue(cfop)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("uCom")
            xWriter.WriteValue("UN")
            xWriter.WriteEndElement()

            Dim QCom As Decimal
            QCom = linha.Cells(7).Value
            Dim complemento As Decimal
            Dim dec As Decimal
            dec = CType(QCom, Decimal)
            complemento = FormatNumber(dec, 4)
            QCom = complemento.ToString("###.0000")

            xWriter.WriteStartElement("qCom")
            xWriter.WriteValue(QCom)
            xWriter.WriteEndElement()

            Dim vUnCom As Decimal
            vUnCom = linha.Cells(6).Value
            Dim complemento_Vuncom As Decimal
            Dim dec_vUnCom As Decimal
            dec_vUnCom = CType(vUnCom, Decimal)
            complemento_Vuncom = FormatNumber(dec_vUnCom, 4)
            vUnCom = complemento_Vuncom.ToString("###.0000000000")

            xWriter.WriteStartElement("vUnCom")
            xWriter.WriteValue(vUnCom)
            xWriter.WriteEndElement()

            Dim vProd As Decimal
            vProd = CDec(linha.Cells(8).Value)
            vProd = FormatCurrency(vProd, 2)
            Dim complemento_vprod As Decimal
            Dim dec_vProd As Decimal
            dec_vProd = CType(vProd, Decimal)
            complemento_vprod = FormatNumber(dec_vProd, 4)

            xWriter.WriteStartElement("vProd")
            xWriter.WriteValue(vProd)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement(CStr("cEANTrib"))
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("uTrib")
            xWriter.WriteValue("UN")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("qTrib")
            xWriter.WriteValue(QCom)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("vUnTrib")
            xWriter.WriteValue(vUnCom)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("indTot")
            xWriter.WriteValue("1")
            xWriter.WriteEndElement()

            item = item + 1
            xWriter.WriteEndElement()

            '-----------------IMPOSTOS----------+
            xWriter.WriteStartElement("imposto")

            Dim impvTrotTrib As Decimal
            ConsultaProduto(linha.Cells(0).Value)
            impvTrotTrib = (linha.Cells(6).Value * aliquotaProdutos) / 100
            impvTrotTrib = impvTrotTrib.ToString("##.00")
            xWriter.WriteStartElement("vTotTrib")

            xWriter.WriteValue(impvTrotTrib)
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("ICMS")
            If linha.Cells(3).Value = 500 Then
                xWriter.WriteStartElement("ICMSSN500")
                xWriter.WriteStartElement("orig")
                xWriter.WriteValue("0")
                xWriter.WriteEndElement()

                xWriter.WriteStartElement("CSOSN")
                xWriter.WriteValue("500")
                xWriter.WriteEndElement()
            Else
                xWriter.WriteStartElement("ICMSSN102")
                xWriter.WriteStartElement("orig")
                xWriter.WriteValue("0")
                xWriter.WriteEndElement()

                xWriter.WriteStartElement("CSOSN")
                xWriter.WriteValue("102")
                xWriter.WriteEndElement()
            End If

            xWriter.WriteEndElement()
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("PIS")
            xWriter.WriteStartElement("PISOutr")

            xWriter.WriteStartElement("CST")
            xWriter.WriteValue("49")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("vBC")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("pPIS")
            xWriter.WriteValue("0.0000")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("vPIS")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()

            xWriter.WriteEndElement()
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("COFINS")
            xWriter.WriteStartElement("COFINSOutr")

            xWriter.WriteStartElement("CST")
            xWriter.WriteValue("49")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("vBC")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("pCOFINS")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()

            xWriter.WriteStartElement("vCOFINS")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()

            xWriter.WriteEndElement()

            xWriter.WriteEndElement()
            xWriter.WriteEndElement()
            xWriter.WriteEndElement()

        Next

        xWriter.WriteStartElement("total")
        xWriter.WriteStartElement("ICMSTot")
        xWriter.WriteStartElement("vBC")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vICMS")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vICMSDeson")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vFCP")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vBCST")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vST")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vFCPST")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vFCPSTRet")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        Dim TotalNf As Decimal
        TotalNf = FrmNotaFiscalEletronica.nTotalNFe.Value
        TotalNf = FormatCurrency(TotalNf, 2)
        xWriter.WriteStartElement("vProd")
        xWriter.WriteValue(TotalNf)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vFrete")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vSeg")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vDesc")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vII")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vIPI")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vIPIDevol")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vPIS")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vCOFINS")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vOutro")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vNF")
        xWriter.WriteValue(TotalNf)
        xWriter.WriteEndElement()

        aliqTotal = aliqTotal.ToString("##.00")
        xWriter.WriteStartElement("vTotTrib")
        xWriter.WriteValue(aliqTotal)
        xWriter.WriteEndElement()

        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("transp")

        xWriter.WriteStartElement("modFrete")
        xWriter.WriteValue(FrmNotaFiscalEletronica.modeloFrete)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vol")

        xWriter.WriteStartElement("qVol")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtQuantidadeVolume.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("esp")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtEspecie.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("nVol")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtNumeroVolume.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("pesoL")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtPesoLiquido.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("pesoB")
        xWriter.WriteValue(FrmNotaFiscalEletronica.txtPesoB.Text)
        xWriter.WriteEndElement()

        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cobr")
        xWriter.WriteStartElement("fat")

        xWriter.WriteStartElement("nFat")
        xWriter.WriteValue("131266")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vOrig")
        xWriter.WriteValue("2456.12")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vDesc")
        xWriter.WriteValue("0.00")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vLiq")
        xWriter.WriteValue("2456.12")
        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("dup")

        xWriter.WriteStartElement("nDump")
        xWriter.WriteValue("001")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("dVenc")
        xWriter.WriteValue("2022-11-24")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("vDup")
        xWriter.WriteValue("800.20")
        xWriter.WriteEndElement()

        xWriter.WriteEndElement()
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("pag")
        xWriter.WriteStartElement("detPag")

        xWriter.WriteStartElement("tPag")
        xWriter.WriteValue(FrmNotaFiscalEletronica.FormaPagamento)
        xWriter.WriteEndElement()

        If FrmNotaFiscalEletronica.FormaPagamento = 90 Then
            xWriter.WriteStartElement("vPag")
            xWriter.WriteValue("0.00")
            xWriter.WriteEndElement()
        Else
            xWriter.WriteStartElement("vPag")
            xWriter.WriteValue(TotalNf)
            xWriter.WriteEndElement()
        End If
        xWriter.WriteEndElement()
        xWriter.WriteEndElement()
        xWriter.WriteStartElement("infAdic")
        xWriter.WriteStartElement("infCpl")
        xWriter.WriteValue(CStr(InfAdicional))

        xWriter.WriteEndElement()
        xWriter.WriteEndElement()
        xWriter.Close()
        GerarDanfe("C:\Unimake\UniNFe\14396397000197\Envio\35190714887258000166550010000000081461798812-procNFe.xml", numeroNota + ".pdf")
        GravaBanco(numeroNota, chaveAcesso)
    End Sub
    Private Sub GravaBanco(numnota As String, chaveAcesso As String)
        Dim sql As String
        sql = "INSERT INTO NOTAFISCAL (COLABORADOR,CODFORMAPAGTO,NUMNOTA,CAMINHOXML,CAMINHOPDF,CHAVEACESSO) VALUES
                                          (@COLABORADOR,@CODFORMAPAGTO,@NUMNOTA,@CAMINHOXML,@CAMINHOPDF,@CHAVEACESSO)"

        comandoLocal = New FbCommand(sql, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@COLABORADOR", FrmNotaFiscalEletronica.txtNomeCliente.Text)
        comandoLocal.Parameters.AddWithValue("@CODFORMAPAGTO", FrmNotaFiscalEletronica.FormaPagamento)
        comandoLocal.Parameters.AddWithValue("@NUMNOTA", numnota)
        comandoLocal.Parameters.AddWithValue("@CAMINHOXML", FrmNotaFiscalEletronica.caminhoXml)
        comandoLocal.Parameters.AddWithValue("@CAMINHOPDF", FrmNotaFiscalEletronica.caminhoPdf)
        comandoLocal.Parameters.AddWithValue("@CHAVEACESSO", chaveAcesso)

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()
    End Sub

    Public Sub GerarDanfe(ByVal xml As String, ByVal arquivo As String)
        Dim gerar = LerIni("Danfe", "GerarDanfe")

        If gerar <> "1" Then
            MessageBox.Show("Não configurado para visualizar DANFE, entre em contato com o administrador.")
            Return
        End If
        Try
            Dim modelo = DanfeViewModelCreator.CriarDeArquivoXml(xml)
            Dim danfe = New Danfe(modelo)
            danfe.Gerar()

            Dim diretorio As String = Path.Combine(Environment.CurrentDirectory + "\DANFE", DateTime.Now.ToString("yyyyMM"))

            Directory.CreateDirectory(diretorio)

            danfe.Salvar(Path.Combine(diretorio, arquivo))
            'Process.Start(Path.Combine(diretorio, arquivo))
            FrmNotaFiscalEletronica.caminhoXml = xml
            FrmNotaFiscalEletronica.caminhoPdf = Path.Combine(diretorio, arquivo)

            FrmVisualizarPdf.caminhopdf = Path.Combine(diretorio, arquivo)
            FrmVisualizarPdf.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Process.Start("C:\Unimake\UniNFe\unidanfe.exe")
        End Try
    End Sub

End Module
