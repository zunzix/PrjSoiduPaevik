Public Class CCar
    Implements ICar

    ' For testing purposes without the database intigrated
    Private Shared NextID As Integer = 0

    Private Property ID As Integer Implements ICar.ID
    Private Property GroupID As Integer Implements ICar.GroupID
    Private Property Name As String Implements ICar.Name
    Private Property Mileage As Double Implements ICar.Mileage
    Private Property AvgFuelConsumption As Double Implements ICar.AvgFuelConsumption
    Private Property IsAvailable As Boolean Implements ICar.IsAvailable
    Private Property IsArchived As Boolean Implements ICar.IsArchived
    Private Property IsInCriticalState As Boolean Implements ICar.IsInCriticalState

    ' Car object constructer
    ' Includes validation in case of wrong datatypes
    Public Sub New(groupID As Object, name As Object, mileage As Object,
                   avgFuelConsumption As Object, isAvailable As Object,
                   isArchived As Object, isInCriticalState As Object)
        ' Automatic ID generation (Temporary)
        Me.ID = NextID
        NextID += 1

        ' GroupID validation
        Try
            Me.GroupID = Convert.ToInt32(groupID)
        Catch ex As Exception
            Me.GroupID = -1
        End Try

        ' Name validation
        If TypeOf name Is String AndAlso Not String.IsNullOrWhiteSpace(name.ToString()) Then
            Me.Name = name.ToString()
        Else
            Me.Name = String.Empty
        End If

        ' Milage validation
        Try
            Me.Mileage = Convert.ToDouble(mileage)
        Catch ex As Exception
            Me.Mileage = 0
        End Try

        ' Fuel consumption validation
        Try
            Me.AvgFuelConsumption = Convert.ToDouble(avgFuelConsumption)
        Catch ex As Exception
            Me.AvgFuelConsumption = 0
        End Try

        ' Availability validation
        Try
            Me.IsAvailable = Convert.ToBoolean(isAvailable)
        Catch ex As Exception
            Me.IsAvailable = False
        End Try

        ' Archival validation
        Try
            Me.IsArchived = Convert.ToBoolean(isArchived)
        Catch ex As Exception
            Me.IsArchived = False
        End Try

        ' Criticality validation
        Try
            Me.IsInCriticalState = isInCriticalState
        Catch ex As Exception
            Me.IsInCriticalState = False
        End Try
    End Sub

    ' To Add: Functions/Subs for adding, removing and updating database through TableReader

    ' Function for getting the values of the private properties
    ' Get the chosen type by writing the name of the property in quotes ("...")
    Public Function GetProperty(ByVal type As String) Implements ICar.GetProperty
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
