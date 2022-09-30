Imports System.Xml
Imports FirebirdSql.Data.FirebirdClient

Module mdl_emitirnfe
    Public codCliente As String
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

    Private Sub BuscaCliente()
        Dim strColaborador As String
        strColaborador = "SELECT * FROM COLABORADOR WHERE CODCOLABORADOR = " & codCliente

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

    Public Sub EmitirRegimeSimplesNacional(chaveAcesso As String, tipoNfe As String, codCfop As String)
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
        xWriter.WriteStartElement("xmlns", sNamespace)

        xWriter.WriteStartElement("infNFe")
        xWriter.WriteAttributeString("versao", "4.00")
        xWriter.WriteAttributeString("Id", "NFe" & chaveAcesso)

        'INICIO IDE---------------------------------------------------------------------------
        xWriter.WriteStartElement("ide")
        xWriter.WriteStartElement("cUF")
        xWriter.WriteValue(LerIni("ide", "cUF"))
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("cNF")
        'xWriter.WriteValue(txtCNF.Text)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("natOp")
        xWriter.WriteValue(codCfop)
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("mod")
        xWriter.WriteValue("55")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("serie")
        xWriter.WriteValue("1")
        xWriter.WriteEndElement()

        xWriter.WriteStartElement("nNF")
        'xWriter.WriteValue(txtNumeroNota.Text)
        xWriter.WriteEndElement()
    End Sub

End Module
