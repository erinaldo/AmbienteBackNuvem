Imports FirebirdSql.Data.FirebirdClient

Module mdl_atualizapreco
    Public Sub AtualizaPreco()
        Dim str As String

        str = "UPDATE ATUALIZAPRECO SET CAIXA1 = @CAIXA1,CAIXA2 = @CAIXA2,CAIXA3 = @CAIXA3,CAIXA4 = @CAIXA4,CAIXA5 = @CAIXA5 WHERE CODATUALIZAPRECO = @CODATUALIZAPRECO"

        comandoLocal = New FbCommand(str, conexaoLocal)

        comandoLocal.Parameters.AddWithValue("@CODATUALIZAPRECO", "1")
        comandoLocal.Parameters.AddWithValue("@CAIXA1", "SIM")
        comandoLocal.Parameters.AddWithValue("@CAIXA2", "SIM")
        comandoLocal.Parameters.AddWithValue("@CAIXA3", "SIM")
        comandoLocal.Parameters.AddWithValue("@CAIXA4", "SIM")
        comandoLocal.Parameters.AddWithValue("@CAIXA5", "SIM")

        conexaoLocal.Close()
        conexaoLocal.Open()
        comandoLocal.ExecuteNonQuery()
        conexaoLocal.Close()
    End Sub
End Module
