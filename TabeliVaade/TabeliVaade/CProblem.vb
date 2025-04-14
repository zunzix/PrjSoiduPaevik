Public Class CProblem
    Implements IProblem

    ' For testing purposes without the database intigrated
    Private Shared NextID As Integer = 0

    Public Property ID As Integer Implements IProblem.ID
    Public Property CarID As Integer Implements IProblem.CarID
    Public Property Issue As String Implements IProblem.Issue
    Public Property IsResolved As Boolean Implements IProblem.IsResolved

    ' Problem object constructer
    ' Includes validation in case of wrong datatypes
    Public Sub New(ByVal carId As Integer, ByVal issue As String,
                   ByVal isResolved As Boolean)
        Me.ID = NextID
        NextID += 1

        ' Car ID validation
        Try
            Me.CarID = carId
        Catch ex As Exception
            Me.CarID = -1
        End Try

        ' Car issue validation
        Try
            Me.Issue = issue
        Catch ex As Exception
            Me.Issue = ""
        End Try

        ' Resolve status validation
        Try
            Me.IsResolved = isResolved
        Catch ex As Exception
            Me.IsResolved = True
        End Try
    End Sub

    ' To Add: Functions/Subs for adding, removing and updating database through TableReader

    ' To Add: Functions/Subs for accessing properties
End Class
