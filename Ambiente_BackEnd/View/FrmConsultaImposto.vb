Imports FirebirdSql.Data.FirebirdClient

Public Class FrmConsultaImposto
    Public tipoConsulta As String
    Public codImposto As String

    Private Sub FrmConsultaImposto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim str As String = 0
        If (conexaoLocal.State <> ConnectionState.Closed) Then
            conexaoLocal.Close()
        End If

        If (tipoConsulta = "1") Then
            str = "SELECT CFOP.CODCFOP,CFOP.NOME_CFO FROM CFOP"
        ElseIf (tipoConsulta = "2") Then
            str = "SELECT GRUPO_ICMS.CSOSN,GRUPO_ICMS.DESCRICAO FROM GRUPO_ICMS"
        ElseIf (tipoConsulta = "3") Then
            str = "SELECT GRUPO_CSTRN.COD,GRUPO_CSTRN.DESCRICAO FROM GRUPO_CSTRN"
        ElseIf (tipoConsulta = "4") Then
            str = "SELECT GRUPO_COFINS.COD,GRUPO_COFINS.DESCRICAO FROM GRUPO_COFINS"
        ElseIf (tipoConsulta = "5") Then
            str = "SELECT GRUPO_PIS.COD,GRUPO_PIS.DESCRICAO FROM GRUPO_PIS"
        ElseIf (tipoConsulta = "6") Then
            str = "SELECT GRUPO_IPI.COD,GRUPO_IPI.DESCRICAO FROM GRUPO_IPI"
        ElseIf (tipoConsulta = "7") Then
            str = "SELECT PRODUTO_NCM.NCM,PRODUTO_NCM.DESCRICAO FROM PRODUTO_NCM"
        End If

        daLocal = New FbDataAdapter(str, conexaoLocal)
        daLocal.Fill(ds)

        dg_cofins.DataSource = ds.Tables(0)
        dg_cofins.Columns(0).HeaderText = "CODIGO"
        dg_cofins.Columns(0).Width = 90
    End Sub

    Private Sub txtpesquisar_TextChanged(sender As Object, e As EventArgs) Handles txtpesquisar.TextChanged
        Dim str As String = 0

        If (tipoConsulta = "1") Then
            str = "SELECT CFOP.CODCFOP,CFOP.NOME_CFO FROM CFOP WHERE CODCFOP LIKE  '%" & txtpesquisar.Text & "%'"
        ElseIf (tipoConsulta = "2") Then
            str = "SELECT GRUPO_ICMS.CSOSN,GRUPO_ICMS.DESCRICAO FROM GRUPO_ICMS WHERE CSOSN LIKE  '%" & txtpesquisar.Text & "%'"
        ElseIf (tipoConsulta = "3") Then
            str = "SELECT GRUPO_CSTRN.COD,GRUPO_CSTRN.DESCRICAO FROM GRUPO_CSTRN WHERE COD LIKE  '%" & txtpesquisar.Text & "%'"
        ElseIf (tipoConsulta = "4") Then
            str = "SELECT GRUPO_COFINS.COD,GRUPO_COFINS.DESCRICAO FROM GRUPO_COFINS WHERE COD LIKE  '%" & txtpesquisar.Text & "%'"
        ElseIf (tipoConsulta = "5") Then
            str = "SELECT GRUPO_PIS.COD,GRUPO_PIS.DESCRICAO FROM GRUPO_PIS WHERE COD LIKE  '%" & txtpesquisar.Text & "%'"
        ElseIf (tipoConsulta = "7") Then
            str = "SELECT PRODUTO_NCM.NCM,PRODUTO_NCM.DESCRICAO FROM PRODUTO_NCM WHERE NCM Like  '%" & txtpesquisar.Text & "%'"
        End If

        conexaoLocal.Close()
        conexaoLocal.ConnectionString = bancoLocal
        conexaoLocal.Open()

        Dim cmd As FbCommand = New FbCommand(str, conexaoLocal)
        Dim da As FbDataAdapter = New FbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        dg_cofins.DataSource = dt


        conexaoLocal.Close()
    End Sub

    Private Sub FrmConsultaImposto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Close()
            tipoConsulta = ""
        End If
    End Sub

    Private Sub dg_cofins_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cofins.CellDoubleClick
        Dim currentRow As DataGridViewRow = Me.dg_cofins.Rows(e.RowIndex)
        codImposto = currentRow.Cells(0).Value.ToString
        Close()
        tipoConsulta = ""
    End Sub
End Class