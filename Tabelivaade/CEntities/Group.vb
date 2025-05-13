Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class Group

    <JsonProperty> Private Name As String

    ' Constructor
    Public Sub New(ByVal name As String)
        Me.Name = name
    End Sub
End Class
