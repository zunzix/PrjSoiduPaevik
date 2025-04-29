Public Class CarInsurance
    Private CarID As String
    Private Name As String
    Private EndDate As DateTime

    ' Constructor 
    Public Sub New(ByVal carId As String, ByVal name As String, ByVal endDate As DateTime)
        Me.CarID = carId
        Me.Name = name
        Me.EndDate = endDate
    End Sub
End Class
