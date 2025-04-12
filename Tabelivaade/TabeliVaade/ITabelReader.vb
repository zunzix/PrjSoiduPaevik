Imports System.ComponentModel

Public Interface ITabelReader
    Function GetTabel() As List(Of CAuto)
    Sub AddCar(groupID As Integer, Name As String, Mileage As Double, AvgFuelConsumption As Double, IsAvaivable As Boolean, isArchived As Boolean)
    Sub RemoveCar(ID As Integer) ' Hiljem Guid
End Interface