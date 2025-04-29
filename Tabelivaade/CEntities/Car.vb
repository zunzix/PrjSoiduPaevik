Public Class Car
    Private ID As String
    Private GroupID As String
    Private Name As String
    Private RegistrationPlate As String
    Private Mileage As Double
    Private AvgFuelCons As Double
    Private IsAvailable As Boolean
    Private IsArchived As Boolean
    Private IsCritical As Boolean

    ' Constructor
    Public Sub New(ByVal id As String, ByVal groupId As String, ByVal name As String, ByVal registrationPlate As String, ByVal mileage As Double, ByVal avgFuelCons As Double, ByVal isAvailable As Boolean, ByVal isArchived As Boolean, ByVal isCritical As Boolean)
        Me.ID = id
        Me.GroupID = groupId
        Me.Name = name
        Me.RegistrationPlate = registrationPlate
        Me.Mileage = mileage
        Me.AvgFuelCons = avgFuelCons
        Me.IsAvailable = isAvailable
        Me.IsArchived = isArchived
        Me.IsCritical = isCritical
    End Sub
End Class


