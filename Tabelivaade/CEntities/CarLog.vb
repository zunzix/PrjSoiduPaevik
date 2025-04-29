Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class CarLog
    <JsonProperty> Private CarID As String
    <JsonProperty> Private StartDate As DateTime
    <JsonProperty> Private EndDate As DateTime
    <JsonProperty> Private StartPoint As String
    <JsonProperty> Private EndPoint As String
    <JsonProperty> Private Distance As Double
    <JsonProperty> Private Comment As String


    ' Constructor
    Public Sub New(ByVal carId As String, ByVal startDate As DateTime, ByVal endDate As DateTime, ByVal startPoint As String, ByVal endPoint As String, ByVal distance As Double, ByVal comment As String)
        Me.CarID = carId
        Me.StartDate = startDate.ToUniversalTime
        Me.EndDate = endDate.ToUniversalTime()
        Me.StartPoint = startPoint
        Me.EndPoint = endPoint
        Me.Distance = distance
        Me.Comment = comment
    End Sub


End Class
