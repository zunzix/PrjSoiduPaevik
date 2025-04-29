Public Class GroupMember
    Private ID As String
    Private GroupID As String
    Private Email As String
    Private IsAdmin As Boolean

    ' Constructor
    Public Sub New(ByVal id As String, ByVal groupId As String, ByVal email As String, ByVal isAdmin As Boolean)
        Me.ID = id
        Me.GroupID = groupId
        Me.Email = email
        Me.IsAdmin = isAdmin
    End Sub
End Class
