Public Class CGroup
    Implements IGroup

    Private Property ID As String Implements IGroup.ID
    Private Property Name As String Implements IGroup.Name

    Public Sub New(ID As Object, Name As Object)
        ' Automatic ID generation (Temporary)
        Me.ID = Convert.ToString(ID)

        Me.Name = Convert.ToString(Name)

    End Sub


End Class
