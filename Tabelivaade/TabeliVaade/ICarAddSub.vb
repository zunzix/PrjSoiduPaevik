Imports System.ComponentModel
Public Interface ICarAddSub

    Function ArchiveData(ByVal ChosenCarID As Integer) As Boolean
    Function UnarchiveData(ByVal ChosenCarID As Integer) As Boolean
    Function DeleteCar(ByVal ChosenCarID As Integer) As Boolean
    Function AddCar(groupID As Integer, carName As String, mileage As Double,
                    avgFuelCons As Double, isAvailable As Boolean,
                    isArchived As Boolean) As Boolean
End Interface