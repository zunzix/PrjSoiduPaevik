Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class Car
    <JsonProperty> Private GroupID As String
    <JsonProperty> Private Name As String
    <JsonProperty> Private RegistrationPlate As String
    <JsonProperty> Private Mileage As Double
    <JsonProperty> Private AvgFuelCons As Double
    <JsonProperty> Private IsAvailable As Boolean
    <JsonProperty> Private IsArchived As Boolean
    <JsonProperty> Private IsCritical As Boolean

    ' Constructor
    Public Sub New(ByVal groupId As String, ByVal name As String, ByVal registrationPlate As String, ByVal mileage As Double, ByVal avgFuelCons As Double, ByVal isAvailable As Boolean, ByVal isArchived As Boolean, ByVal isCritical As Boolean)
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


