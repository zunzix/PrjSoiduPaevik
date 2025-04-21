Public Class CProblem
    Implements IProblem

    ' For testing purposes without the database intigrated
    Private Shared NextID As Integer = 0

    Private Property ID As Integer Implements IProblem.ID
    Private Property CarID As Integer Implements IProblem.CarID
    Private Property Issue As String Implements IProblem.Issue
    Private Property IsResolved As Boolean Implements IProblem.IsResolved

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

    ' Function for getting the values of the private properties
    ' Get the chosen type by writing the name of the property in quotes ("...")
    Public Function GetProperty(ByVal type As String) Implements IProblem.GetProperty
        ' Get the info of the required property and store it
        Dim propertyInfo = Me.GetType().GetProperty(type)

        ' Check whether it exists or not
        If type IsNot Nothing Then
            Return propertyInfo.GetValue(Me, Nothing)
        Else
            Throw New ArgumentException($"Property '{type}' doesn't exist!")
        End If
    End Function
End Class
