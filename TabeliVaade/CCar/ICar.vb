Public Interface ICar
    Property ID As String
    Property GroupID As Integer
    Property Name As String
    Property RegistrationPlate As String
    Property Mileage As Double
    Property AvgFuelConsumption As Double
    Property IsAvailable As Boolean
    Property IsArchived As Boolean
    Property IsInCriticalState As Boolean
    Function GetProperty(ByVal type As String)
    Sub ArchiveCar()
    Sub UnarchiveCar()
End Interface
