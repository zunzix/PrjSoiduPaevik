Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class CTableReader
    Implements ITableReader

    ' Private variables
    Private JwtToken As String
    Private RefreshToken As String

    ' Base URL for the API 
    Private Const BaseUrl As String = "https://localhost:7231/"

    Public Function AddTable() Implements ITableReader.AddTable
        Throw New NotImplementedException()
    End Function

    Public Function RemoveTable() Implements ITableReader.RemoveTable
        Throw New NotImplementedException()
    End Function

    Public Function GetTable() As Object Implements ITableReader.GetTable
        Throw New NotImplementedException()
    End Function

    Public Function UpdateTable() As Object Implements ITableReader.UpdateTable
        Throw New NotImplementedException()
    End Function

    Public Function GetSpecificTable() As Object Implements ITableReader.GetSpecificTable
        Throw New NotImplementedException()
    End Function

    Public Function Register() As Object Implements ITableReader.Register
        Throw New NotImplementedException()
    End Function

    Public Function Login(Email As String, Password As String) As Boolean _
        Implements ITableReader.Login
        Try
            Dim Request As HttpWebRequest
            Dim Response As HttpWebResponse
            Dim Reader As StreamReader
            Dim Input As String

            ' JSON input string
            Input = "{""email"":""" & Email & """,""password"":""" & Password & """}"

            ' HHTP request
            Request = HttpWebRequest.Create(BaseUrl & "api/Account/Login")
            Request.Method = "POST"

            ' Set the content type to application/json
            Request.ContentType = "application/json"

            ' Write the Json Input to Request body
            Request.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(Input), 0, Input.Length)

            ' Get the response from server
            Response = Request.GetResponse()
            Reader = New System.IO.StreamReader(Response.GetResponseStream)
            Dim ResponseString As String = Reader.ReadToEnd()
            Console.WriteLine("Response: " & ResponseString)

            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Logout() As Object Implements ITableReader.Logout
        Throw New NotImplementedException()
    End Function
End Class
