Public Class CAuto
    Implements IAuto

    ' Shared laseb muutujat jagada kõigi CAuto objektide vahel
    ' Integeri asemel GUID.
    Private Shared nextID As Integer = 0

    Public Property ID As Integer Implements IAuto.ID
    Public Property GroupID As Integer Implements IAuto.groupID
    Public Property Name As String Implements IAuto.name
    Public Property Mileage As Double Implements IAuto.mileage
    Public Property AvgFuelCon As Double Implements IAuto.avgFuelConsumption
    Public Property IsAvailable As Boolean Implements IAuto.isAvailable
    Public Property IsArchived As Boolean Implements IAuto.isArchived

    ' Auto objekti konstruktor
    ' Sisaldab info valideerimist, mis errori puhul määrab vaikimisi väärtuse
    Public Sub New(groupID As Object, name As Object, mileage As Object, avgFuelConsumption As Object, isAvailable As Object, isArchived As Object)
        ' Automaatne ID genereerimine
        Me.ID = nextID
        nextID += 1

        ' GroupID valideerimine
        Try
            Me.GroupID = Convert.ToInt32(groupID)
        Catch ex As Exception
            Me.GroupID = 0
        End Try

        ' Nime valideerimine
        If TypeOf name Is String AndAlso Not String.IsNullOrWhiteSpace(name.ToString()) Then
            Me.Name = name.ToString()
        Else
            Me.Name = String.Empty
        End If

        ' kilometraaži valideerimine
        Try
            Me.Mileage = Convert.ToDouble(mileage)
        Catch ex As Exception
            Me.Mileage = 0
        End Try

        ' kütusekulu valideerimine
        Try
            Me.AvgFuelCon = Convert.ToDouble(avgFuelConsumption)
        Catch ex As Exception
            Me.AvgFuelCon = 0
        End Try

        ' isAvailable valideerimine
        Try
            Me.IsAvailable = Convert.ToBoolean(isAvailable)
        Catch ex As Exception
            Me.IsAvailable = False
        End Try

        ' IsArchived valideerimine
        Try
            Me.IsArchived = Convert.ToBoolean(isArchived)
        Catch ex As Exception
            Me.IsArchived = False
        End Try
    End Sub

End Class
