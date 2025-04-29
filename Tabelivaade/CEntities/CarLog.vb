Public Class CarLog
    Private CarID As String
    Private StartDate As DateTime
    Private EndDate As DateTime
    Private StartPoint As String
    Private EndPoint As String
    Private Distance As Double
    Private Comment As String


    ' Constructor
    Public Sub New(ByVal carId As String, ByVal startDate As DateTime, ByVal endDate As DateTime, ByVal startPoint As String, ByVal endPoint As String, ByVal distance As Double, ByVal comment As String)
        Me.CarID = carId
        Me.StartDate = startDate
        Me.EndDate = endDate
        Me.StartPoint = startPoint
        Me.EndPoint = endPoint
        Me.Distance = distance
        Me.Comment = comment
    End Sub


End Class
