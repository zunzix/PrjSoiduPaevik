Public Interface IInsurance
    Property ID As Integer
    Property CarID As Integer
    Property Name As String
    Property EndDate As Date
    Function GetProperty(ByVal type As String)
End Interface
