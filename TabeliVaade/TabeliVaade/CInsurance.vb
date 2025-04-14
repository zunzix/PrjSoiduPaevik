Public Class CInsurance
    Implements IInsurance

    ' For testing purposes without the database intigrated
    Private Shared NextID As Integer = 0

    Private Property ID As Integer Implements IInsurance.ID
    Private Property CarID As Integer Implements IInsurance.CarID
    Private Property Name As String Implements IInsurance.Name
    Private Property EndDate As Date Implements IInsurance.EndDate

    ' Insurance object constructer
    ' Includes validation in case of wrong datatypes
    Public Sub New(ByVal carID As Integer, ByVal name As String, ByVal endDate As Date)
        Me.ID = NextID
        NextID += 1

        ' Car ID validation
        Try
            Me.CarID = carID
        Catch ex As Exception
            Me.CarID = -1
        End Try

        ' Name validation
        Try
            Me.Name = name
        Catch ex As Exception
            Me.Name = ""
        End Try

        ' Insurance end date validation
        Try
            Me.EndDate = endDate
        Catch ex As Exception
            Me.EndDate = DateSerial(1970, 1, 1)
        End Try
    End Sub

    ' To Add: Functions/Subs for adding, removing and updating database through TableReader

    ' Function for getting the values of the private properties
    ' Get the chosen type by writing the name of the property in quotes ("...")
    Public Function GetProperty(ByVal type As String) Implements IInsurance.GetProperty
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
