Imports System.ComponentModel

Public Class CCarAddSub
    Implements ICarAddSub

    Private _list As BindingList(Of CAuto)

    Public Sub New(list As BindingList(Of CAuto))
        _list = list
    End Sub


    Private Property ICarAddSub_List As BindingList(Of CAuto) _
        Implements ICarAddSub.List
        Get
            Return _list
        End Get
        Set(value As BindingList(Of CAuto))
            _list = value
        End Set
    End Property

    Public Function ArchiveData(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.ArchiveData
        If _list.Contains(ChosenCarID) Then
            _list(_list.IndexOf(ChosenCarID)).IsArchived = False
            Return True

        ElseIf _list.Count = 0 Then
            Return False
        End If
        Return False
    End Function

    Public Function UnarchiveData(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.UnarchiveData
        If _list.Contains(ChosenCarID) Then
            _list(_list.IndexOf(ChosenCarID)).IsArchived = False
            Return True

        ElseIf _list.Count = 0 Then
            Return False
        End If
        Return False
    End Function

    Public Function DeleteCar(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.DeleteCar
        If _list.Count = 0 Then
            Return False
        ElseIf _list.Contains(ChosenCarID) Then
            _list.RemoveAt(_list.IndexOf(ChosenCarID))
            Return True
        End If
        Return False
    End Function

    Public Function AddCar(carID As Guid, groupID As Guid, carName As String,
                           mileage As Double, avgFuelCons As Double,
                           isAvailable As Boolean, isArchived As Boolean) _
                           As Boolean Implements ICarAddSub.AddCar
        Try 'üks muutuja liialt praegu, arvan, et peaks CAuto klassi lisama ka auto ID muutuja.

            _list.Add(New CAuto(carID, groupID, carName, mileage,
                               avgFuelCons, isAvailable, isArchived))

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class
