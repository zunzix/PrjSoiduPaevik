Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft
Imports Newtonsoft.Json.Linq
Imports System.Reflection
Imports System.Linq.Expressions


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

    ' Description: Function to fill the CarList of type CCar with data from the API
    ' Parameters: None
    ' Returns: A list of cars or an error message
    Public Function GetGroupTable() As Object _
        Implements ITableReader.GetGroupTable

        ' if is car, group, groupmember, carissue, carlog, carinsurance, then get that table

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim List As JArray
        Dim dt As New DataTable()

        ' HTTP request
        Request = HttpWebRequest.Create(BaseUrl & "api/Groups/GetGroups")
        Request.Method = "GET"
        Request.ContentType = "application/json"

        ' Add Jwt token
        Request.Headers.Add("Authorization", "Bearer " & JwtToken)

        Try
            ' Get response
            Response = Request.GetResponse()
            Reader = New StreamReader(Response.GetResponseStream)
            JsonResponse = Reader.ReadToEnd()
            Console.WriteLine("DEBUG: Response: " & JsonResponse)

        Catch ex As WebException

            If CType(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized Then
                ' if error is 401, refresh token and retry
                If RefreshJwtToken() Then

                    Return GetGroupTable()

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing

        End Try

        ' Parse JSON
        List = JArray.Parse(JsonResponse)

        dt.Columns.Add("ID", GetType(String))
        dt.Columns.Add("GroupName", GetType(String))

        Try
            ' Populate DataTable
            For Each item In List
                dt.Rows.Add(item("id"), item("name"))
            Next
        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing
        End Try

        Return dt
    End Function


    ' if is car, group, groupmember, carissue, carlog, carinsurance, then get that table

    ' Parameters: which table to get, 
    Public Function GetSpecificTables(TheTableToGet As String, ID As String) As Object Implements ITableReader.GetSpecificTables
        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim List As JArray
        Dim dt As New DataTable()


        Select Case TheTableToGet
            Case "Car"
                Request = HttpWebRequest.Create(BaseUrl & "api/Cars/GetGroupCars/" & ID)
            Case "GroupMember"
                Request = HttpWebRequest.Create(BaseUrl & "api/GroupMembers/GetGroupGroupMember/" & ID)
            Case "CarIssue"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarIssues/GetCarCarIssues/" & ID)
            Case "CarLog"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarLogs/GetCarCarLogs/" & ID)
            Case "CarInsurance"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarInsurances/GetCarCarInsurances/" & ID)
            Case Else
                Console.WriteLine("Error: Invalid table type.")
                Return Nothing
        End Select

        Request.Method = "GET"
        Request.ContentType = "application/json"

        ' Add Jwt token
        Request.Headers.Add("Authorization", "Bearer " & JwtToken)

        Try
            ' Get response
            Response = Request.GetResponse()
            Reader = New StreamReader(Response.GetResponseStream)
            JsonResponse = Reader.ReadToEnd()

        Catch ex As WebException

            If CType(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized Then
                ' if error is 401, refresh token and retry
                If RefreshJwtToken() Then

                    Return GetSpecificTables(TheTableToGet, ID)

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing

        End Try

        List = JArray.Parse(JsonResponse)

        Select Case TheTableToGet
            Case "Car"

                dt.Columns.Add("ID", GetType(String))
                dt.Columns.Add("GroupID", GetType(String))
                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("RegistrationPlate", GetType(String))
                dt.Columns.Add("Mileage", GetType(Integer))
                dt.Columns.Add("AvgFuelConsumption", GetType(Double))
                dt.Columns.Add("IsAvailable", GetType(Boolean))
                dt.Columns.Add("IsArchived", GetType(Boolean))
                dt.Columns.Add("IsInCriticalState", GetType(Boolean))

                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"), item("name"))
                    Next
                Catch ex As WebException
                    Console.WriteLine("Error: " & ex.Message)
                    Return Nothing
                End Try

                Return dt

            Case Else
                Console.WriteLine("Error: No table")
                Return Nothing
        End Select


    End Function

    Public Function UpdateTable() As Object Implements ITableReader.UpdateTable
        Throw New NotImplementedException()
    End Function


    ' Description: Function for Loggin a user in
    ' Parameters: Email as String and Password as String
    ' Returns: True if login is successful, False otherwise
    Public Function LoginRegister(Email As String, Password As String, Purpose As String) As Boolean _
        Implements ITableReader.LoginRegister
        Try
            Dim Request As HttpWebRequest
            Dim Response As HttpWebResponse
            Dim Reader As StreamReader
            Dim Input As String

            ' JSON input string
            Input = "{""email"":""" & Email & """,""password"":""" & Password & """}"

            ' HHTP request
            If (Purpose Is "Login") Then
                Request = HttpWebRequest.Create(BaseUrl & "api/Account/Login")
            ElseIf (Purpose Is "Register") Then
                Request = HttpWebRequest.Create(BaseUrl & "api/Account/Register")
            Else
                Console.WriteLine("Error: Invalid purpose. Use 'Login' or 'Register'.")
                Return False
            End If

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
        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Logout() As Object Implements ITableReader.Logout
        Throw New NotImplementedException()
    End Function

    Private Function RefreshJwtToken() As Boolean
        ' TODO: if this function returns false, it should return the user back to login screen
        ' enter jwt and refresh 
        ' returns new jwt and new refresh
        Try
            Dim Request As HttpWebRequest
            Dim Response As HttpWebResponse
            Dim Reader As StreamReader
            Dim Input As String

            ' JSON input string
            Input = "{""jwt"":""" & JwtToken & """,""refreshToken"":""" & RefreshToken & """}"

            ' HHTP request
            Request = HttpWebRequest.Create(BaseUrl & "api/Account/RefreshTokenData")
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
            If responseData.ContainsKey("jwt") AndAlso responseData.ContainsKey("refreshToken") Then

                JwtToken = responseData("jwt")
                RefreshToken = responseData("refreshToken")
                Console.WriteLine("DEBUG: Login successful! JWT: " & JwtToken & vbCrLf & "Refresh Token: " & RefreshToken)

                Return True

            Else
                Console.WriteLine("Error: Missing tokens in response.")
                Return False

            End If

        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function
End Class
