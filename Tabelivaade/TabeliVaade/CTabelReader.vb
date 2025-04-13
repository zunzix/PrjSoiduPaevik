Imports System.ComponentModel

Public Class CTabelReader
    Implements ITabelReader

    Private Shared _instance As New CTabelReader()

    Private autodList As New BindingList(Of CAuto)()

    Public probleemidList As New BindingList(Of CAutoProbleem)()

    Public kindlustusList As New BindingList(Of CKindlustus)()

    ' siin toimub autode lisamine tabelisse
    Private Sub New()
        autodList.Add(New CAuto(1, "Peugeot 206", 178989, 11.2, True, False))
        autodList.Add(New CAuto(2, "Honda Civic", 15003.2, 6.8, False, False))
        autodList.Add(New CAuto(3, "Ford Focus", 9999, 7.5, True, False))

        probleemidList.Add(New CAutoProbleem(0, "Mootor väriseb", False, False))
        probleemidList.Add(New CAutoProbleem(1, "Raadio ei töödanud", False, True))
        probleemidList.Add(New CAutoProbleem(2, "Auto on Fordi poolt toodetud", True, False))

        kindlustusList.Add(New CKindlustus(0, "if", DateAdd("Year", 1, Today)))
        kindlustusList.Add(New CKindlustus(1, "Swedbank", DateAdd("Week", 1, Today)))
        kindlustusList.Add(New CKindlustus(2, "Salva", DateAdd("Week", 2.5, Today)))
    End Sub

    'Description: Get a copy of table data (not access to the original list)
    'Parameters: none
    'Return: copy of autodList as List(Of cAuto)
    Public Function GetTable() As List(Of CAuto) Implements ITabelReader.GetTabel
        Return autodList.ToList()
    End Function

    'Description: Add a car to the list
    'Parameters: groupID As Integer, Name As String, Mileage As Double, AvgFuelConsumption As Double, IsAvaivable As Boolean, isArchived As Boolean
    'Return: copy of autodList as List(Of cAuto)
    Public Sub AddCar(groupID As Integer, Name As String, Mileage As Double, AvgFuelConsumption As Double, IsAvaivable As Boolean, isArchived As Boolean) _
        Implements ITabelReader.AddCar
        autodList.Add(New CAuto(groupID, Name, Mileage, AvgFuelConsumption, IsAvaivable, isArchived))
    End Sub

    'Description: Remove a car from the list by ID
    'Parameters: ID as Integer
    'Return: returns nothing
    Public Sub RemoveCar(ID As Integer) Implements ITabelReader.RemoveCar
        Dim autoToRemove As CAuto = autodList.FirstOrDefault(Function(a) a.ID = ID)
        If autoToRemove IsNot Nothing Then
            autodList.Remove(autoToRemove)
        End If
    End Sub

    'Description: Returns the instance of the class
    'Parameters: none
    'Return: returns the instance of the class
    Public Shared Function GetInstance() As CTabelReader
        Return _instance
    End Function

End Class
