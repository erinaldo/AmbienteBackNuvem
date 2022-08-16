Imports System.Text
Imports System.Runtime.InteropServices
Module mdl_INI
    <DllImport("kernel32.dll", SetLastError:=True)> Public Function WritePrivateProfileString _
      (ByVal lpApplicationName As String,
      ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> Public Function GetPrivateProfileString(
      ByVal lpAppName As String,
      ByVal lpKeyName As String,
      ByVal lpDefault As String,
      ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    End Function

    Public Function lerINI(ByVal strIniFile As String, ByVal strKey As String, ByVal strItem As String) As String
        Dim strValue As StringBuilder = New StringBuilder(255)
        Dim intSize As Integer
        intSize = GetPrivateProfileString(strKey, strItem, "", strValue, 255, strIniFile)
        Return strValue.ToString
    End Function

    Public Function escreveINI(ByVal strIniFile As String, ByVal strKey As String,
                            ByVal strItem As String, ByVal strValue As String) _
                                As String
        Return WritePrivateProfileString(strKey, strItem, strValue, strIniFile)
    End Function

    'Para ler um arquivo .ini: lerINI(Diretório do arquivo + arquivo.ini, "valor entre cochetes", "valor antes do igual")
    'Para escrever arquivo .ini: escreveINI(Diretório do arquivo + arquivo.ini, "Valor entre cochetes", "valor antes do igual", "valor depois do igual")

    Public Function LerIni(ByVal strItem As String, ByVal strValue As String) As String
        Return lerINI(Environment.CurrentDirectory + "/Data/Configuracao.ini", strItem, strValue)
    End Function

    Public Function EscreveIni(ByVal strKey As String, ByVal strItem As String, ByVal strValue As String) As String
        Return escreveINI(Environment.CurrentDirectory + "/Data/Configuracao.ini", strKey, strItem, strValue)
    End Function
End Module
