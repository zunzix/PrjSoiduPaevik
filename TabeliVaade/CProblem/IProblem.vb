Public Interface IProblem
    Property ID As Integer
    Property CarID As Integer
    Property Issue As String
    Property IsResolved As Boolean
    Function GetProperty(ByVal type As String)
End Interface
