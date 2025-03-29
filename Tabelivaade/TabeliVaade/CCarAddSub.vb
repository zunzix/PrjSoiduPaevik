Public Class CCarAddSub
    Implements ICarAddSub

    Public Function ArchiveData(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.ArchiveData
        If autodList.Contains = ChosenCarID Then
            autodList(autodList.IndexOf(ChosenCarID)).IsArchived = False
            Return True

        ElseIf autodList.Count = 0 Then
            Return False
        End If
        Return False
    End Function

    Public Function UnarchiveData(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.UnarchiveData
        If autodList.Contains = ChosenCarID Then
            autodList(autodList.IndexOf(ChosenCarID)).IsArchived = False
            Return True

        ElseIf autodList.Count = 0 Then
            Return False
        End If
        Return False
    End Function

    Public Function DeleteCar(ChosenCarID As Guid) _
        As Boolean Implements ICarAddSub.DeleteCar
        If autodList.Count = 0 Then
            Return False
        ElseIf autodList.Contains = ChosenCarID Then
            autodList.RemoveAt(autodList.IndexOf(ChosenCarID))
            Return True
        End If
        Return False
    End Function

    Public Function AddCar(carID As Guid, groupID As Guid, carName As String,
                           mileage As Double, avgFuelCons As Double,
                           isAvailable As Boolean, isArchived As Boolean) _
                           As Boolean Implements ICarAddSub.AddCar
        autoList.Add(New CAuto(carID, groupID, carName, mileage, avgFuelCons, isAvailable, isArchived))
        'üks muutuja liialt praegu, arvan, et peaks CAuto klassi lisama ka auto ID muutuja.
    End Function
End Class
