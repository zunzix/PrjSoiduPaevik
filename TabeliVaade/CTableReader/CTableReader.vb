Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft
Imports Newtonsoft.Json.Linq
Imports System.Reflection
Imports System.Linq.Expressions
Imports CEntities


Public Class CTableReader
    Implements ITableReader

    ' Private variables
    Private JwtToken As String
    Private RefreshToken As String

    ' Base URL for the API 
    Private Const BaseUrl As String = "https://mustik.ee:85/"

    Public Function AddTable(TheTableToAddTo As String, Table As Object) As Boolean _
        Implements ITableReader.AddTable

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim Input As String

        Select Case TheTableToAddTo
            Case "Car"
                Request = HttpWebRequest.Create(BaseUrl & "api/Cars/PostCar")
            Case "GroupMember"
                Request = HttpWebRequest.Create(BaseUrl & "api/GroupMembers/PostGroupMember")
            Case "CarIssue"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarIssues/PostCarIssue")
            Case "CarLog"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarLogs/PostCarLog")
            Case "CarInsurance"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarInsurances/PostCarInsurance")
            Case "Group"
                Request = HttpWebRequest.Create(BaseUrl & "api/Groups/PostGroup")
            Case Else
                Console.WriteLine("Error: Invalid table type.")
                Return Nothing
        End Select

        Input = JsonConvert.SerializeObject(Table)
        Console.WriteLine("DEBUG: Input: " & Input)

        ' Write the Json Input to Request body

        Request.Method = "POST"
        Request.ContentType = "application/json; charset=utf-8"

        ' Add Jwt token
        Request.Headers.Add("Authorization", "Bearer " & JwtToken)

        Dim utf8Bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(Input)
        Request.ContentLength = utf8Bytes.Length
        Using requestStream = Request.GetRequestStream()
            requestStream.Write(utf8Bytes, 0, utf8Bytes.Length)
        End Using

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

                    Return AddTable(TheTableToAddTo, Table)
                    Console.WriteLine("DEBUG: refreshing token and retrying")

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return False

        End Try

        Return True
    End Function

    Public Function RemoveTable(TheTableToRemove As String, ID As String) As Boolean _
        Implements ITableReader.RemoveTable

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String

        Select Case TheTableToRemove
            Case "Car"
                Request = HttpWebRequest.Create(BaseUrl & "api/Cars/DeleteCar/" & ID)
            Case "GroupMember"
                Request = HttpWebRequest.Create(BaseUrl & "api/GroupMembers/DeleteGroupMember/" & ID)
            Case "CarIssue"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarIssues/DeleteCarIssue" & ID)
            Case "CarLog"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarLogs/DeleteCarLog" & ID)
            Case "CarInsurance"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarInsurances/DeleteCarInsurance" & ID)
            Case "Group"
                Request = HttpWebRequest.Create(BaseUrl & "api/Groups/DeleteGroup" & ID)
            Case Else
                Console.WriteLine("Error: Invalid table type.")
                Return Nothing
        End Select

        ' Write the Json Input to Request body
        Request.Method = "DELETE"
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

                    Return RemoveTable(TheTableToRemove, ID)

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return False

        End Try

        Return True
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

    ' Description: Function to get a specific table from the API and to return the respective DataTable
    ' Parameters: TheTableToGet as String, ID as String
    ' Returns: A DataTable containing the data from the specified table or an error message
    Public Function GetSpecificTables(TheTableToGet As String, ID As String) As Object _
        Implements ITableReader.GetSpecificTables

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

                dt.Columns.Add("CarID", GetType(String))
                dt.Columns.Add("CarGroupID", GetType(String))
                dt.Columns.Add("CarName", GetType(String))
                dt.Columns.Add("CarRegistrationPlate", GetType(String))
                dt.Columns.Add("CarMileage", GetType(Integer))
                dt.Columns.Add("CarAvgFuelConsumption", GetType(Double))
                dt.Columns.Add("CarIsAvailable", GetType(Boolean))
                dt.Columns.Add("CarIsArchived", GetType(Boolean))
                dt.Columns.Add("CarIsInCriticalState", GetType(Boolean))

                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"),
                                    item("groupId"),
                                    item("name"),
                                    item("registrationPlate"),
                                    item("mileage"),
                                    item("avgFuelCons"),
                                    item("isAvailable"),
                                    item("isArchived"),
                                    item("isCritical"))
                    Next
                Catch ex As WebException
                    Console.WriteLine("Error: " & ex.Message)
                    Return Nothing
                End Try

                Return dt

            Case "GroupMember"

                dt.Columns.Add("GroupMemberID", GetType(String))
                dt.Columns.Add("GroupMemberGroupID", GetType(String))
                dt.Columns.Add("GroupMemberEmail", GetType(String))
                dt.Columns.Add("GroupMemberIsAdmin", GetType(Boolean))
                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"),
                                    item("groupId"),
                                    item("email"),
                                    item("isAdmin"))
                    Next
                Catch ex As WebException
                    Console.WriteLine("Error: " & ex.Message)
                    Return Nothing
                End Try

                Return dt
            Case "CarIssue"
                dt.Columns.Add("CarIssueID", GetType(String))
                dt.Columns.Add("CarIssueCarID", GetType(String))
                dt.Columns.Add("CarIssueDescription", GetType(String))
                dt.Columns.Add("CarIssueIsCritical", GetType(Boolean))
                dt.Columns.Add("CarIssueIsResolved", GetType(Boolean))
                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"),
                                    item("carId"),
                                    item("issue"),
                                    item("isCritical"),
                                    item("isResolved"))
                    Next
                Catch ex As WebException
                    Console.WriteLine("Error: " & ex.Message)
                    Return Nothing
                End Try
                Return dt

            Case "CarLog"
                dt.Columns.Add("CarLogID", GetType(String))
                dt.Columns.Add("CarLogCarID", GetType(String))
                dt.Columns.Add("CarLogUserEmail", GetType(String))
                dt.Columns.Add("CarLogStartDate", GetType(DateTime))
                dt.Columns.Add("CarLogEndDate", GetType(DateTime))
                dt.Columns.Add("CarLogStartPoint", GetType(String))
                dt.Columns.Add("CarLogEndPoint", GetType(String))
                dt.Columns.Add("CarLogDistance", GetType(Double))
                dt.Columns.Add("CarLogComment", GetType(String))

                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"),
                                    item("carId"),
                                    item("email"),
                                    item("startDate"),
                                    item("endDate"),
                                    item("startPoint"),
                                    item("endPoint"),
                                    item("distance"),
                                    item("comment"))
                    Next
                Catch ex As WebException
                    Console.WriteLine("Error: " & ex.Message)
                    Return Nothing
                End Try

                Return dt

            Case "CarInsurance"
                dt.Columns.Add("CarInsuranceID", GetType(String))
                dt.Columns.Add("CarInsuranceCarID", GetType(String))
                dt.Columns.Add("CarInsuranceName", GetType(String))
                dt.Columns.Add("CarInsuranceEndDate", GetType(DateTime))
                Try
                    ' Populate DataTable
                    For Each item In List
                        dt.Rows.Add(item("id"),
                                    item("carId"),
                                    item("name"),
                                    item("endDate"))
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

    ' Description: Function to update a table 
    ' Parameters: TheTableToUpdate as String, ID as String, Table as Object
    ' Returns: True if update is successful, False otherwise
    Public Function UpdateTable(TheTableToUpdate As String, ID As String, Table As Object) As Boolean _
        Implements ITableReader.UpdateTable

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim TableWithID As JObject
        Dim Input As String

        ' TODO: check if the request is correct
        Select Case TheTableToUpdate
            Case "Car"
                Request = HttpWebRequest.Create(BaseUrl & "api/Cars/PutCar/" & ID)
                ' TODO: when adding a car the body needs to also include cars id
            Case "GroupMember"
                Request = HttpWebRequest.Create(BaseUrl & "api/GroupMembers/PutGroupMember/" & ID)
            Case "CarIssue"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarIssues/PutCarIssue/" & ID)
            Case "CarLog"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarLogs/PutCarLog/" & ID)
            Case "CarInsurance"
                Request = HttpWebRequest.Create(BaseUrl & "api/CarInsurances/PutCarInsurance/" & ID)
            Case "Group"
                Request = HttpWebRequest.Create(BaseUrl & "api/Groups/PutGroup/" & ID)
            Case Else
                Console.WriteLine("Error: Invalid table type.")
                Return Nothing
        End Select

        ' Add ID to body as "id": "the ID.value"
        TableWithID = JObject.FromObject(Table)
        TableWithID("id") = ID
        Input = JsonConvert.SerializeObject(TableWithID)

        Console.WriteLine("DEBUG: Input: " & Input)

        Request.Method = "PUT"
        Request.ContentType = "application/json"

        ' Add Jwt token
        Request.Headers.Add("Authorization", "Bearer " & JwtToken)

        ' Write the Json Input to Request body
        Request.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(Input), 0, Input.Length)

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

                    Return UpdateTable(TheTableToUpdate, ID, Table)

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return False

        End Try

        Return True
    End Function


    ' Description: Function for Loggin a user in
    ' Parameters: Email as String and Password as String
    ' Returns: True if login is successful, False otherwise

    ' TODO: Return if user is admin or not
    Public Function LoginRegister(Email As String, Password As String, Purpose As String) As Boolean _
        Implements ITableReader.LoginRegister
        Try
            Dim Request As HttpWebRequest
            Dim Response As HttpWebResponse
            Dim Reader As StreamReader
            Dim Input As String
            Dim ResponseString As String

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
            ResponseString = Reader.ReadToEnd()

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

    ' Description: Function for Logging out a user
    ' Parameters: None
    ' Returns: True if logout is successful, False otherwise    
    Public Function Logout() As Boolean _
        Implements ITableReader.Logout

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim Input As String

        ' JSON input string
        Input = "{""refreshToken"":""" & RefreshToken & """}"

        ' HHTP request
        Request = HttpWebRequest.Create(BaseUrl & "api/Account/Logout")
        Request.Method = "POST"

        ' Set the content type to application/json
        Request.ContentType = "application/json"

        ' Add Authorization header
        Request.Headers.Add("Authorization", "Bearer " & JwtToken)

        Request.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(Input), 0, Input.Length)

        ' Get response from server, and see if logout was successful
        Try
            Response = Request.GetResponse()
            Reader = New StreamReader(Response.GetResponseStream)
            JsonResponse = Reader.ReadToEnd()
            Console.WriteLine("DEBUG: Logout successful: " & JsonResponse)

        Catch ex As WebException
            If CType(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized Then
                ' if error is 401, refresh token and retry
                If RefreshJwtToken() Then

                    Return Logout()

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try

        Return True

    End Function

    ' Description: Function to refresh the JWT token
    ' Parameters: None
    ' Returns: True if refresh is successful, False otherwise
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

    Public Function GetLogsByUserId() As Object _
        Implements ITableReader.GetLogsByUserId

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse
        Dim Reader As StreamReader
        Dim JsonResponse As String
        Dim List As JArray
        Dim dt As New DataTable()

        ' HTTP request
        Request = HttpWebRequest.Create(BaseUrl & "api/CarLogs/GetUserCarLogs")
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

                    Return GetLogsByUserId()

                End If
            End If
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing

        End Try

        ' Parse JSON
        List = JArray.Parse(JsonResponse)

        dt.Columns.Add("CarLogID", GetType(String))
        dt.Columns.Add("CarLogCarID", GetType(String))
        dt.Columns.Add("CarLogUserEmail", GetType(String))
        dt.Columns.Add("Start Date", GetType(DateTime))
        dt.Columns.Add("End Date", GetType(DateTime))
        dt.Columns.Add("Starting Point", GetType(String))
        dt.Columns.Add("End Point", GetType(String))
        dt.Columns.Add("Distance", GetType(Double))
        dt.Columns.Add("Comment", GetType(String))

        Try
            ' Populate DataTable
            For Each item In List
                dt.Rows.Add(item("id"),
                            item("carId"),
                            item("email"),
                            item("startDate"),
                            item("endDate"),
                            item("startPoint"),
                            item("endPoint"),
                            item("distance"),
                            item("comment"))
            Next
        Catch ex As WebException
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing
        End Try

        Return dt
    End Function
End Class
