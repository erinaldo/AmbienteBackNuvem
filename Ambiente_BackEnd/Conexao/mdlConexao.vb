Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient
Module mdlConexao
    Public bancoNuvem As String = LerIni("Banco", "BancoNuvem")
    Public bancoAtualiza As String = LerIni("Banco", "BancoAtualiza")
    Public bancoLocal As String = LerIni("Banco", "BancoLocal")

    Public conexaoNuvem As MySqlConnection = New MySqlConnection(bancoNuvem)
    Public conexaoAtualiza As MySqlConnection = New MySqlConnection(bancoAtualiza)
    Public drNuvem As MySqlDataReader
    Public comandoNuvem As MySqlCommand
    Public daNuvem As MySqlDataAdapter

    Public conexaoLocal As New FbConnection(bancoLocal)
    Public drLocal As FbDataReader
    Public drLocalVenda As FbDataReader
    Public comandoLocal As New FbCommand
    Public daLocal As FbDataAdapter

End Module
