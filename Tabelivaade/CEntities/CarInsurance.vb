Public Class CarInsurance
    Private ID As String
    Private CarID As String
    Private Name As String
    Private EndDate As DateTime

    ' Constructor 
    Public Sub New(ByVal id As String, ByVal carId As String, ByVal name As String, ByVal endDate As DateTime)
        Me.ID = id
        Me.CarID = carId
        Me.Name = name
        Me.EndDate = endDate
    End Sub
End Class
