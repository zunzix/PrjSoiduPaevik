Imports System.ComponentModel
Public Class CCarAddSub
    Implements ICarAddSub
    'Use the same list as in CTabelReader
    Private _list As BindingList(Of CAuto) = CTabelReader.GetInstance().autodList

    'Description: Archive data (change list component IsArchived to True) by user chosen Car ID
    'Parameters: ChosenCarID as Integer
    'Return: True if data is archived, False if data is not archived
    Public Function ArchiveData(ChosenCarID As Integer) _
        As Boolean Implements ICarAddSub.ArchiveData
        If _list.Count > 0 Then
            For i As Integer = 0 To _list.Count - 1
                If _list(i).ID = ChosenCarID Then
                    _list(i).IsArchived = True
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function

    'Description: Unarchive data (change list component IsArchived to False) by user chosen Car ID
    'Parameters: ChosenCarID as Integer
    'Return: True if data is unarchived, False if data is not unarchived
    Public Function UnarchiveData(ChosenCarID As Integer) _
        As Boolean Implements ICarAddSub.UnarchiveData
        If _list.Count > 0 Then
            For i As Integer = 0 To _list.Count - 1
                If _list(i).ID = ChosenCarID Then
                    _list(i).IsArchived = False
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function

    'Description: Delete data by user chosen Car ID
    'Parameters: ChosenCarID as Integer
    'Return: True if data is deleted, False if data is not deleted
    Public Function DeleteCar(ChosenCarID As Integer) _
        As Boolean Implements ICarAddSub.DeleteCar
        If _list.Count > 0 Then
            For i As Integer = 0 To _list.Count - 1
                If _list(i).ID = ChosenCarID Then
                    _list.RemoveAt(i)
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function

    'Description: Add car to the end of the list
    'Parameters: groupID as Integer, carName as String, mileage as Double, avgFuelCons as Double
    '            isAvailable as Boolean, isArchived as Boolean
    'Return: True if car is added, False if car is not added
    Public Function AddCar(groupID As Integer, carName As String,
                           mileage As Double, avgFuelCons As Double,
                           isAvailable As Boolean, isArchived As Boolean) _
                           As Boolean Implements ICarAddSub.AddCar
        Dim lastLen As Integer = _list.Count
        _list.Add(New CAuto(groupID, carName, mileage, avgFuelCons, isAvailable, isArchived))
        If lastLen + 1 = _list.Count Then
            Return True
        End If
        Return False
    End Function
End Class