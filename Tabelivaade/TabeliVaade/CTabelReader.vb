Imports System.ComponentModel

Public Class CTabelReader

    Private Shared _instance As New CTabelReader()

    Public autodList As New BindingList(Of CAuto)()

    Public probleemidList As New BindingList(Of CAutoProbleem)()

    ' siin toimub autode lisamine tabelisse
    Private Sub New()
        autodList.Add(New CAuto(1, "Peugeot 206", 178989, 11.2, True, False))
        autodList.Add(New CAuto(2, "Honda Civic", 15003.2, 6.8, False, False))
        autodList.Add(New CAuto(3, "Ford Focus", 9999, 7.5, True, False))

        probleemidList.Add(New CAutoProbleem(0, "Mootor väriseb", False, False))
        probleemidList.Add(New CAutoProbleem(1, "Raadio ei töödanud", False, True))
        probleemidList.Add(New CAutoProbleem(2, "Auto on Fordi poolt toodetud", True, False))
    End Sub

    Public Shared Function GetInstance() As CTabelReader
        Return _instance
    End Function

End Class
