Public Class CCar
    Implements ICar
    Private Property ID As String Implements ICar.ID
    Private Property GroupID As Integer Implements ICar.GroupID
    Private Property Name As String Implements ICar.Name
    Private Property RegistrationPlate As String Implements ICar.RegistrationPlate
    Private Property Mileage As Double Implements ICar.Mileage
    Private Property AvgFuelConsumption As Double Implements ICar.AvgFuelConsumption
    Private Property IsAvailable As Boolean Implements ICar.IsAvailable
    Private Property IsArchived As Boolean Implements ICar.IsArchived
    Private Property IsInCriticalState As Boolean Implements ICar.IsInCriticalState

    ' Car object constructer
    ' Includes validation in case of wrong datatypes
    Public Sub New(ID As Object, groupID As Object, name As Object, registrationPlate As Object, mileage As Object,
                   avgFuelConsumption As Object, isAvailable As Object,
                   isArchived As Object, isInCriticalState As Object)
        ' Automatic ID generation (Temporary)

        Me.ID = Convert.ToString(ID)

        Me.GroupID = Convert.ToInt32(groupID)

        Me.Name = name.ToString()

        Me.RegistrationPlate = Convert.ToString(registrationPlate)

        Me.Mileage = Convert.ToDouble(mileage)

        Me.AvgFuelConsumption = Convert.ToDouble(avgFuelConsumption)

        Me.IsAvailable = Convert.ToBoolean(isAvailable)

        Me.IsArchived = Convert.ToBoolean(isArchived)

        Me.IsInCriticalState = isInCriticalState

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

    Public Sub ArchiveCar() Implements ICar.ArchiveCar
        Me.IsArchived = True
    End Sub

    Public Sub UnarchiveCar() Implements ICar.UnarchiveCar
        Me.IsArchived = False
    End Sub
End Class
