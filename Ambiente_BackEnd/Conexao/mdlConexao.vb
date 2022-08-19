﻿Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient
Module mdlConexao
    Public bancoNuvem As String = LerIni("Banco", "BancoNuvem")
    Public bancoLocal As String = LerIni("Banco", "BancoLocal")

    Public conexaoNuvem As MySqlConnection = New MySqlConnection(bancoNuvem)
    Public drNuvem As MySqlDataReader
    Public comandoNuvem As MySqlCommand
    Public daNuvem As MySqlDataAdapter

    Public conexaoLocal As New FbConnection(bancoLocal)
    Public drLocal As FbDataReader
    Public comandoLocal As New FbCommand
    Public daLocal As FbDataAdapter

End Module