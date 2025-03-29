Imports System.ComponentModel
Public Interface ICarAddSub
    Function ArchiveData(ByVal ChosenCarID As Guid) As Boolean
    Function UnarchiveData(ByVal ChosenCarID As Guid) As Boolean
    Function DeleteCar(ByVal ChosenCarID As Guid) As Boolean
    Function AddCar(carID As Guid, groupID As Guid _
                    , carName As String, mileage As Double, avgFuelCons As Double _
                    , isAvailable As Boolean, isArchived As Boolean) As Boolean
End Interface
