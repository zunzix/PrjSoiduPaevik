Public Class GroupMember
    ' grupp kuhu lisad
    Private GroupID As String

    ' email,´kasutajast, keda lisad
    Private Email As String

    ' kas kasutaja on admin
    Private IsAdmin As Boolean

    ' Constructor
    Public Sub New(ByVal groupId As String, ByVal email As String, ByVal isAdmin As Boolean)
        Me.GroupID = groupId
        Me.Email = email
        Me.IsAdmin = isAdmin
    End Sub
End Class
