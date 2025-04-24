Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports CCar
Imports Newtonsoft
Imports Newtonsoft.Json.Linq


Public Class CTableReader
    Implements ITableReader

    ' Private lists
    Private CarList As CCar

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

    ' Description: Function to fill the CarList of type CCar with data from the API
    ' Parameters: None
    ' Returns: A list of cars or an error message
    Public Function GetCarTable() As Object _
        Implements ITableReader.GetCarTable

        ' TODO: Add GroupID to paramaters
        ' TODO: if it even works :))))))

        Try
            Dim Request As HttpWebRequest
            Dim Response As HttpWebResponse
            Dim Reader As StreamReader
            Dim JsonResponse As String
            Dim Cars As JArray
            Dim CarList As New List(Of CCar)

            ' HTTP request
            Request = HttpWebRequest.Create(BaseUrl & "api/Cars/GetCars")
            Request.Method = "GET"
            Request.ContentType = "application/json"

            ' Add Jwt token
            Request.Headers.Add("Authorization", "Bearer " & JwtToken)

            ' Get response
            Response = Request.GetResponse()
            Reader = New StreamReader(Response.GetResponseStream)
            JsonResponse = Reader.ReadToEnd()

            ' Parse JSON
            Cars = JArray.Parse(JsonResponse)

            ' Add each car to CarList
            For Each Car In Cars
                CarList.Add(New CCar(
                Car("id"),
                Car("groupId"),
                Car("name"),
                Car("mileage"),
                Car("avgFuelCons"),
                Car("isAvailable"),
                Car("isArchived"),
                Car("isCritical")
            ))
            Next

            Return CarList

        Catch ex As WebException

            If CType(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized Then
                ' if error is 401, refresh token and retry
                If RefreshJwtToken(RefreshToken) Then

                    Return GetCarTable()

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing

        End Try


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

    ' Description: Function for Loggin a user in
    ' Parameters: Email as String and Password as String
    ' Returns: True if login is successful, False otherwise
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

            ' Parse the response
            Dim responseData As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(ResponseString)

            ' Extract the tokens from the response
            If responseData.ContainsKey("jwt") AndAlso
                responseData.ContainsKey("refreshToken") Then

                JwtToken = responseData("jwt")
                RefreshToken = responseData("refreshToken")
                Console.WriteLine("DEBUG: Login successful! JWT: " & JwtToken & vbCrLf & "Refresh Token: " & RefreshToken)
                Return True
            Else
                Console.WriteLine("Error: Missing tokens in response.")
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Logout() As Object Implements ITableReader.Logout
        Throw New NotImplementedException()
    End Function

    Public Function RefreshJwtToken(RefreshToken As String) As String _
        Implements ITableReader.RefreshJwtToken

        Return RefreshToken
    End Function
End Class
