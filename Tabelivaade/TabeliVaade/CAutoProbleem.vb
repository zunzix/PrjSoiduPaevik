Public Class CAutoProbleem
    Implements IAutoProbleem

    Private Shared nextID As Integer = 0
    Public Property ID As Integer Implements IAutoProbleem.ID
    Public Property CarID As Integer Implements IAutoProbleem.CarID
    Public Property Issue As String Implements IAutoProbleem.Issue
    Public Property IsCritical As Boolean Implements IAutoProbleem.IsCritical
    Public Property IsResolved As Boolean Implements IAutoProbleem.IsResolved

    Public Sub New(ByVal carId As Integer, ByVal issue As String,
                   ByVal isCritical As Boolean, ByVal isResolved As Boolean)
        Me.ID = nextID
        nextID += 1

        Try
            Me.CarID = carId
        Catch ex As Exception
            Me.CarID = -1
        End Try

        Try
            Me.Issue = issue
        Catch ex As Exception
            Me.Issue = ""
        End Try

        Try
            Me.IsCritical = isCritical
        Catch ex As Exception
            Me.IsCritical = False
        End Try

        Try
            Me.IsResolved = isResolved
        Catch ex As Exception
            Me.IsResolved = True
        End Try
    End Sub
End Class
