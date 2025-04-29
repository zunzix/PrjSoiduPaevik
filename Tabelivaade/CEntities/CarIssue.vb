Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class CarIssue
    <JsonProperty> Private CarID As String
    <JsonProperty> Private Issue As String
    <JsonProperty> Private IsCritical As Boolean
    <JsonProperty> Private IsResolevd As Boolean

    ' Constructor
    Public Sub New(ByVal carId As String, ByVal issue As String, ByVal isCritical As Boolean, ByVal isResolved As Boolean)
        Me.CarID = carId
        Me.Issue = issue
        Me.IsCritical = isCritical
        Me.IsResolevd = isResolved
    End Sub
End Class
