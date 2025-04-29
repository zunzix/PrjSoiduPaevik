Public Class CarIssue
    Private ID As String
    Private CarID As String
    Private Issue As String
    Private IsCritical As Boolean
    Private IsResolevd As Boolean

    ' Constructor
    Public Sub New(ByVal id As String, ByVal carId As String, ByVal issue As String, ByVal isCritical As Boolean, ByVal isResolved As Boolean)
        Me.ID = id
        Me.CarID = carId
        Me.Issue = issue
        Me.IsCritical = isCritical
        Me.IsResolevd = isResolved
    End Sub
End Class
