Public Class CKindlustus
    Implements IKindlustus

    Private Shared nextID As Integer = 0

    Public Property ID As Integer Implements IKindlustus.ID

    Public Property carID As Integer Implements IKindlustus.carID

    Public Property name As String Implements IKindlustus.name

    Public Property endDate As Date Implements IKindlustus.endDate

    Public Sub New(ByVal CarID As Integer, ByVal Name As String, ByVal EndDate As Date)
        Me.ID = nextID
        nextID += 1

        Try
            Me.carID = CarID
        Catch ex As Exception
            Me.carID = -1
        End Try

        Try
            Me.name = Name
        Catch ex As Exception
            Me.name = ""
        End Try

        Try
            Me.endDate = EndDate
        Catch ex As Exception
            Me.endDate = DateSerial(1970, 1, 1)
        End Try
    End Sub
End Class
