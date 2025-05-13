Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class CarInsurance
    <JsonProperty> Private CarID As String
    <JsonProperty> Private Name As String
    <JsonProperty> Private EndDate As DateTime


    ' Constructor 
    Public Sub New(ByVal carId As String, ByVal name As String, ByVal endDate As DateTime)
        Me.CarID = carId
        Me.Name = name
        Me.EndDate = endDate.ToUniversalTime()
    End Sub
End Class
