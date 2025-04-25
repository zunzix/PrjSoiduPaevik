Public Interface ITableReader
    'NOTES:
    ' add private function RefreshToken in CTableReader,
    ' which is called whenever jwt token has expired and
    ' takes in user refresh token as parameter and
    ' returns new jwt token / error message(and redirects to login screen).
    ' 
    ' functions return list or something(I don't know what these are in VB) and
    ' files are handled in CTableReader.
    ' Ids are all Guid. refresh token is guid (can be held as a string). jwt token is string.
    ' Some things may be wrong still, gl :)

    ' todo add getTable parameters
    ' what table(group,car,groupmember,carissue,carlog,carinsurance)
    ' returns user specific table list / error message
    Function GetGroupTable()

    ' todo add getSpecificTable parameters
    ' what table(car,groupmember,carissue,carlog,carinsurance), table id
    ' returns specific group/car table list / error message
    ' note : add 2 different private functions for group/car
    Function GetSpecificTables(TheTableToGet As String, ID As String)

    ' todo add addTable parameters
    ' what table(group,car,groupmember,carissue,carlog,carinsurance), new table file(list)
    ' returns success/error message 
    Function AddTable()

    ' todo add removeTable parameters
    ' what table(group,car,groupmember,carissue,carlog,carinsurance), table id
    ' returns success/error message
    Function RemoveTable()

    ' todo add updateTable parameters
    ' what table(group,car,groupmember,carissue,carlog,carinsurance), table id, new table file(list)
    '  returns success/error message 
    Function UpdateTable()

    ' todo add login parameter
    ' user file(email, password)
    ' returns jwt token and refresh token (in single list)/error message
    Function LoginRegister(Email As String, Password As String, Purpose As String) As Boolean

    ' todo add logout paramater
    ' refresh token 
    ' returns success (and redirects to login screen)/error message
    Function Logout()
End Interface
