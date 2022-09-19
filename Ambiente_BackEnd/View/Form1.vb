Imports System.Net
Imports Newtonsoft.Json
Imports System.Web.Script.Serialization
Imports System.IO

Public Class Form1
    Dim ser As JavaScriptSerializer = New JavaScriptSerializer()
    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Dim consultas As consulta = New consulta()

        Dim jsonString As String = New System.Net.WebClient().DownloadString("https://receitaws.com.br/v1/cnpj/22803124000148")
        consultas = ser.Deserialize(Of consulta)(jsonString)

        TextBox1.Text = consultas.nome
        TextBox2.Text = consultas.tipo
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Class consulta
        Public Property nome As String
        Public Property tipo As String
    End Class
End Class