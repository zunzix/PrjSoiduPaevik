Imports System.ComponentModel

Public Interface ITabelReader
    Function GetTable(ByVal type As Integer)
    Sub AddCar(groupID As Integer, Name As String, Mileage As Double, AvgFuelConsumption As Double, IsAvaivable As Boolean, isArchived As Boolean)
    Sub RemoveCar(ID As Integer) ' Hiljem Guid
End Interface